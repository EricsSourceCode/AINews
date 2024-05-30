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


public class MainData
{
private string DataDirectory = "";
// private ConfigureFile ConfigFile;
private MainForm MForm;


internal MainData( MainForm UseForm )
{
MForm = UseForm;

SetupDirectories();
}




internal string GetDataDirectory()
{
return DataDirectory;
}



private void SetupDirectories()
{
try
{
DataDirectory = Application.StartupPath +
                            "\\Data\\";
if( !Directory.Exists( DataDirectory ))
  Directory.CreateDirectory( DataDirectory );

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
} // Namespace




