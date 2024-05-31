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
// using System.IO;



// namespace


public class MainForm : Form
{
internal const string VersionDate =
                               "5/31/2024";
internal const int VersionNumber = 09; // 0.9
private System.Threading.Mutex
                    SingleInstanceMutex = null;

private bool IsSingleInstance = false;
private bool IsClosing = false;
private bool Cancelled = false;
internal MainFormComp MFormComp;
private System.Windows.Forms.Timer
                          SingleInstanceTimer;
internal MainData mainData;


public MainForm()
{
InitializeGuiComponents();

if( !CheckSingleInstance())
  return;

IsSingleInstance = true;

mainData = new MainData( this );

MFormComp = new MainFormComp( this );
this.Controls.Add( MFormComp.MainPanel );

ShowStatus( "Programming by Eric Chauvin." );
ShowStatus( "Version Date: " + VersionDate );
}




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




private void FreeEverything()
{
SingleInstanceTimer.Dispose();
MFormComp.FreeAll();
}




private void MainForm_FormClosing(
         object sender, FormClosingEventArgs e )
{
/*
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
*/

IsClosing = true;

if( IsSingleInstance )
  {
  // SaveAllFiles();
  }

FreeEverything();
}



internal void ShowStatus( string Status )
{
if( IsClosing )
  return;

MFormComp.ShowStatus( Status );
}




private void InitializeGuiComponents()
{
SingleInstanceTimer = new
                  System.Windows.Forms.Timer();

SuspendLayout();

SingleInstanceTimer.Tick += new System.
     EventHandler(this.SingleInstanceTimer_Tick);

this.AutoScaleMode = System.Windows.Forms.
                             AutoScaleMode.None;

this.BackColor = System.Drawing.Color.Black;
this.ClientSize = new System.Drawing.
                             Size(715, 411);

this.Name = "MainForm";
this.StartPosition = System.Windows.Forms.
               FormStartPosition.CenterScreen;
this.Text = "AINews";
this.FormClosing += new System.Windows.
             Forms.FormClosingEventHandler(
             this.MainForm_FormClosing);

// this.Font =

this.ResumeLayout(false);
this.PerformLayout();
}



internal void exitToolStripMenuItem_Click(
                     object sender, EventArgs e)
{
Close();
}



} // Class
