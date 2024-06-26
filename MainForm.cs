// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;
using System.Threading;
using System.Windows.Forms;



// namespace


public class MainForm : Form
{
private System.Threading.Mutex
                    SingleInstanceMutex = null;

private bool isSingleInstance = false;
internal MainFormComp mFormComp;
private System.Windows.Forms.Timer
                          SingleInstanceTimer;
internal MainData mainData;




public MainForm()
{
SingleInstanceTimer = new
                  System.Windows.Forms.Timer();

SingleInstanceTimer.Tick += new System.
     EventHandler(this.SingleInstanceTimer_Tick);


FormClosing += new System.Windows.
          Forms.FormClosingEventHandler(
          MainForm_FormClosing );

/*
Shown += new System.EventHandler(
                       MainForm_Shown);
KeyDown += new System.Windows.Forms.
      KeyEventHandler( MainForm_KeyDown );
Resize += new System.EventHandler(
                     MainForm_Resize);
*/


if( !CheckSingleInstance())
  return;

isSingleInstance = true;

mFormComp = new MainFormComp( this );
this.Controls.Add( mFormComp.mainPanel );

mainData = new MainData( this );
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

if( mainData != null )
  mainData.freeAll();

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



} // Class
