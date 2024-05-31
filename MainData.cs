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
private string dataDirectory = "";
// private ConfigureFile configFile;
private MainForm mForm;
internal SysIO sysIO;



internal MainData( MainForm useForm )
{
mForm = useForm;

sysIO = new SysIO();

setupDirectories();
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



} // Class
