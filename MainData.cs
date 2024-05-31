// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



using System;
// using System.Text;
// Application, MessageBox, etc.
using System.Windows.Forms;
// using System.IO;



// namespace


public class MainData
{
internal const string VersionDate =
                              "5/31/2024";
internal const int VersionNumber = 09; // 0.9
private string dataDirectory = "";
// private ConfigureFile configFile;
private MainForm mForm;
internal SysIO sysIO;
private bool cancelled = false;
private bool isClosing = false;



internal MainData( MainForm useForm )
{
mForm = useForm;

sysIO = new SysIO();

setupDirectories();

showStatus( "Programming by Eric Chauvin." );
showStatus( "Version Date: " + VersionDate );
}




internal string getDataDirectory()
{
return dataDirectory;
}



private void setupDirectories()
{
try
{
// dataDirectory = Application.StartupPath +
dataDirectory = "\\AIData\\";

// If it doesn't already exist.
sysIO.createDirectory( dataDirectory );

}
catch( Exception )
  {
  MessageBox.Show(
        "The directory could not be created.",
        "AINews",
       MessageBoxButtons.OK);

  return;
  }
}



internal bool CheckEvents()
{
if( isClosing )
  return false;

Application.DoEvents();

if( cancelled )
  return false;

return true;
}



internal void freeEverything()
{


}



internal void showStatus( string status )
{
mForm.showStatus( status );
}



} // Class
