// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;



// namespace


public class MainForm : Form
{
private System.Threading.Mutex
                    SingleInstanceMutex = null;

private bool isSingleInstance = false;
private bool shownOnce = false;
private int mouseX = 0;
private int mouseY = 0;
internal MainFormComp mFormComp;
private System.Windows.Forms.Timer
                          SingleInstanceTimer;
internal MainData mData;
private Bitmap guiBitmap;
private int mainScreenWidth = 1024; // Default
private int mainScreenHeight = 768;
private GuiMain guiMain;




public MainForm()
{
SingleInstanceTimer = new
                  System.Windows.Forms.Timer();

SingleInstanceTimer.Tick += new System.
     EventHandler(this.SingleInstanceTimer_Tick);


FormClosing += new System.Windows.
          Forms.FormClosingEventHandler(
          MainForm_FormClosing );

Shown += new System.EventHandler(
                       MainForm_Shown);

KeyDown += new System.Windows.Forms.
      KeyEventHandler( MainForm_KeyDown );

// Resize += new System.EventHandler(
//                     MainForm_Resize);

if( !CheckSingleInstance())
  return;

isSingleInstance = true;

mFormComp = new MainFormComp( this );
this.Controls.Add( mFormComp.mainPanel );

mData = new MainData( this );
guiMain = new GuiMain( mData );
// Not here.  guiMain.drawToBitmap();
}




// This has to be added in the Program.cs file.
//   Application.ThreadException += new
// ThreadExceptionEventHandler(
//  MainForm.UIThreadException );
//   Application.SetUnhandledExceptionMode(
//  UnhandledExceptionMode.CatchException );

internal static void UIThreadException(
     object sender, ThreadExceptionEventArgs t )
{
string ErrorString = t.Exception.Message;

try
{
string showS = "There was an unexpected" +
     " error:\r\n\r\n" +
     ErrorString;

MessageBox.Show( showS, "AINews",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Stop );

}
finally
  {
  Application.Exit();
  }
}



internal void MainForm_KeyDown( object sender,
                                KeyEventArgs e )
{
// See KeyEventArgs and Keys.enum

// if( e.Control )
// if( e.Shift )
// if( e.KeyCode == Keys.E ) // The letter E.

if( e.KeyCode == Keys.Escape )
  {
  mData.setCancelled( true );
  showStatus( "Cancelled." );
  }
}



internal int getMainScreenWidth()
{
return mainScreenWidth;
}


internal int getMainScreenHeight()
{
return mainScreenHeight;
}



private void SingleInstanceTimer_Tick(
                   object sender, EventArgs e)
{
SingleInstanceTimer.Stop();
Application.Exit();
}



private bool CheckSingleInstance()
{
bool InitialOwner = false; // Owner for
                       // single instance check.
string ShowS = "Another instance of AINews" +
      " is already running." +
      " This instance will close.";

try
{
SingleInstanceMutex = new System.Threading.
               Mutex( true,
               "AINews Single Instance",
               out InitialOwner );
}
catch
  {
  MessageBox.Show( ShowS, "AINews",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Stop );
  // mutex.Close();
  // mutex = null;

  // Can't do this here:
  // Application.Exit();
  SingleInstanceTimer.Interval = 50;
  SingleInstanceTimer.Start();
  return false;
  }

if( !InitialOwner )
  {
  MessageBox.Show( ShowS, "AINews",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop );
  // Application.Exit();
  SingleInstanceTimer.Interval = 50;
  SingleInstanceTimer.Start();
  return false;
  }

return true;
}




private void freeAll()
{
SingleInstanceTimer.Dispose();

if( !isSingleInstance )
  return;

if( mData != null )
  mData.freeAll();

if( mFormComp != null )
  mFormComp.freeAll();

}



private void MainForm_FormClosing(
         object sender, FormClosingEventArgs e )
{
/*
if( isSingleInstance )
  {
  if( DialogResult.Yes != MessageBox.Show(
            "Close the program?",
            "AINews",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question ))
    {
    e.Cancel = true;
    return;
    }
  }
*/

// Do freeAll() instead of a ~Destructor or
// Finalize.  Call Dispose() from there.

freeAll();
}




internal void showStatus( string status )
{
mFormComp.showStatus( status );
}


internal void clearStatus()
{
mFormComp.clearStatus();
}



// Do drawToBitmap() when ever something
// changes like
//    if( e.KeyCode == Keys.Right )



private void drawToBitmap()
{
// if( !IsEnabled )
//   return;

if( guiBitmap == null )
  return;

try
{
Size sz = mFormComp.guiPanel.Size;
if( sz.Width < 10 )
  return;

if( sz.Height < 10 )
  return;

using( Graphics bitGraph = Graphics.FromImage(
                             guiBitmap ))
  {
  if( bitGraph == null )
    return;

  guiMain.draw( sz.Width,
                sz.Height,
                bitGraph );

  }

mFormComp.guiPictureBox.Image = guiBitmap;
}
catch( Exception ) // Except )
  {
  throw new Exception( "Can't draw bitmap." );
  }
}




internal void MainForm_Shown( object sender,
                              EventArgs e)
{
if( !isSingleInstance )
  return;

if( shownOnce )
  return;

shownOnce = true;

Screen mainScreen = Screen.FromControl( this );
Rectangle wArea = mainScreen.WorkingArea;
mainScreenWidth = wArea.Width;
mainScreenHeight = wArea.Height;

guiBitmap = new Bitmap(
           mainScreenWidth, mainScreenHeight );
           // PixelFormat.Canonical );

drawToBitmap();
mFormComp.guiPictureBox.Image = guiBitmap;
mFormComp.searchTextBox.Focus(); // Select()
}



internal void guiPictureBox_MouseDown(
              object sender, MouseEventArgs e )
{
if( e.Button == MouseButtons.Left )
  {
  // showStatus( "Left button." );
  mouseX = e.X;
  mouseY = e.Y;
  double daysBack = 0;

  try
  {
  daysBack = Double.Parse( mFormComp.
                            getDaysBackText());
  daysBack = -daysBack;
  }
  catch( Exception )
    {
    clearStatus();
    showStatus( "Bad days back string." );
    return;
    }

  if( guiMain.isInsideDemocratBtn( mouseX,
                                   mouseY ))
    {
    clearStatus();
    showStatus( " " );
    showStatus( "Searching MSNBC." );
    mData.paraSearch( "msnbc",
                    mFormComp.getSearchText(),
                    daysBack );

    mFormComp.mainTextBox.Focus(); // Select()
    }

  if( guiMain.isInsideRepubBtn( mouseX,
                                mouseY ))
    {
    clearStatus();
    showStatus( " " );
    showStatus( "Searching FOXNEWS." );
    mData.paraSearch( "foxnews",
                   mFormComp.getSearchText(),
                   daysBack );

    mFormComp.mainTextBox.Focus(); // Select()
    }

  if( guiMain.isInsideTestBtn( mouseX,
                               mouseY ))
    {
    clearStatus();
    // mData.readAllStories();
    mData.neuralTest();
    showStatus( "Test finished." );
    }

  }

if( e.Button == MouseButtons.Right )
  {
  showStatus( "Right button." );
  }

//  Size Sz = PIP1PictureBox.Size;
//  Sz.Height,
//  Sz.Width,
// e.X,
// e.Y,

}




} // Class
