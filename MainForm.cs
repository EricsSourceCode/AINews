// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;



namespace AINews
{


public class MainForm : Form
{
internal const string VersionDate =
                               "5/29/2024";
internal const int VersionNumber = 09; // 0.9
private System.Threading.Mutex
                    SingleInstanceMutex = null;

private bool IsSingleInstance = false;
// private MenuEvents MEvents;
private bool IsClosing = false;
private bool Cancelled = false;

/*
  private string DataDirectory = "";
  // private ConfigureFile ConfigFile;
  // private ThreeDForm ThreeDF;
*/

private TextBox MainTextBox;


private System.Windows.Forms.Timer
                          SingleInstanceTimer;



public MainForm()
{
// MEvents = new MenuEvents( this );
InitializeGuiComponents();

if( !CheckSingleInstance())
  return;

IsSingleInstance = true;


/*
    ///////////
    // Keep this at the top.
    SetupDirectories();


    ShowStatus( "Version Date now: " + VersionDate );
    // ShowStatus( "ThreeDScene.MoveToEarthView() is" );
    // ShowStatus( "set to -x, 0, 0." );
    // ShowStatus( "That points from the sun to the earth" );
    // ShowStatus( "(it's negative x) at Spring Equinox." );



    // DrawBitmap DrawBMap = new DrawBitmap( this );
    // DrawBMap.MakeImageFile( "C:\\Eric\\ClimateModel\\bin\\Release\\Earth.jpg" );

    // JPLHorizonsData JPLData = new JPLHorizonsData( this );
    // string FileName = "C:\\Eric\\ClimateModel\\EphemerisData\\JPLSpaceStation.txt";
    // string FileName = "C:\\Eric\\ClimateModel\\EphemerisData\\JPLSun.txt";
    // JPLData.ReadFromTextFile( FileName );
*/
}



/*
  internal string GetDataDirectory()
    {
    return DataDirectory;
    }



  private void SetupDirectories()
    {
    try
    {
    DataDirectory = Application.StartupPath + "\\Data\\";
    if( !Directory.Exists( DataDirectory ))
      Directory.CreateDirectory( DataDirectory );

    }
    catch( Exception )
      {
      MessageBox.Show( "Error: The directory could not be created.", MessageBoxTitle, MessageBoxButtons.OK);
      return;
      }
    }
*/



internal bool CheckEvents()
{
if( IsClosing )
  return false;

Application.DoEvents();

if( Cancelled )
  return false;

return true;
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
string ShowString = "There was an unexpected" +
     " error:\r\n\r\n" +
     "The program will close now.\r\n\r\n" +
     ErrorString;

MessageBox.Show( ShowString,
           "Program Error",
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



/*
  internal void ShowEarthScene()
    {
    try
    {
    if( ThreeDF == null )
      ThreeDF = new ThreeDForm( this );

    if( ThreeDF.IsDisposed )
      ThreeDF = new ThreeDForm( this );

    ThreeDF.Show();
    ThreeDF.WindowState = FormWindowState.Maximized;
    ThreeDF.BringToFront();
    }
    catch( Exception Except )
      {
      MessageBox.Show( "Exception in MainForm.ShowEarthScene(): " + Except.Message, MessageBoxTitle, MessageBoxButtons.OK);
      return;
      }
    }



  private void FreeEverything()
    {
    // MEvents.FreeEverything();

    MainTextBox.Dispose();
    SingleInstanceTimer.Dispose();
    }
*/



private void MainForm_FormClosing(
         object sender, FormClosingEventArgs e )
{
if( IsSingleInstance )
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

IsClosing = true;

if( IsSingleInstance )
  {
  // SaveAllFiles();
  // DisposeOfEverything();
  }

// FreeEverything();
}



/*
  internal void ShowStatus( string Status )
    {
    if( IsClosing )
      return;

    MainTextBox.AppendText( Status + "\r\n" );
    }
*/




private void InitializeGuiComponents()
{
// MEvents.InitializeGuiComponents();

SingleInstanceTimer = new
                  System.Windows.Forms.Timer();

MainTextBox = new System.Windows.Forms.TextBox();

SuspendLayout();

MainTextBox.Dock = System.Windows.Forms.
                          DockStyle.Fill;
MainTextBox.Location = new System.Drawing.
                         Point(0, 28);
MainTextBox.Multiline = true;
MainTextBox.Name = "MainTextBox";
MainTextBox.ReadOnly = true;
MainTextBox.ScrollBars = System.Windows.Forms.
                            ScrollBars.Vertical;
MainTextBox.Size = new System.Drawing.
                            Size(715, 383);
MainTextBox.TabIndex = 1;

SingleInstanceTimer.Tick += new System.
     EventHandler(this.SingleInstanceTimer_Tick);

this.AutoScaleMode = System.Windows.Forms.
                             AutoScaleMode.None;

this.BackColor = System.Drawing.Color.Black;
this.ClientSize = new System.Drawing.
                             Size(715, 411);

this.Controls.Add(this.MainTextBox);

/*
this.Controls.Add( MEvents.menuStrip1 );
this.ForeColor = System.Drawing.Color.White;
this.MainMenuStrip = MEvents.menuStrip1;
this.MainMenuStrip.Font = new System.
          Drawing.Font("Segoe UI", 38F,
          System.Drawing.FontStyle.Regular,
          System.Drawing.GraphicsUnit.Pixel,
          ((byte)(0)));
*/

this.Name = "MainForm";
this.StartPosition = System.Windows.Forms.
               FormStartPosition.CenterScreen;
this.Text = "AINews";
this.FormClosing += new System.Windows.
             Forms.FormClosingEventHandler(
             this.MainForm_FormClosing);

this.Font = new System.Drawing.Font(
               "Consolas", 34.0F,
               System.Drawing.FontStyle.Regular,
               System.Drawing.GraphicsUnit.Pixel,
               ((byte)(0)));

MainTextBox.Font = new System.Drawing.
                    Font( "Consolas", 54.0F,
                    System.Drawing.FontStyle.
                    Regular, System.Drawing.
                    GraphicsUnit.Pixel,
                    ((byte)(0)));

// MEvents.ResumeLayout();
this.ResumeLayout(false);
this.PerformLayout();
}


} // Class
} // Namespace
