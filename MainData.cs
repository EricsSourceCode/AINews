// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



using System;
// For Application.
using System.Windows.Forms;



// namespace


public class MainData
{
internal const string VersionDate =
                              "6/21/2024";
// internal const int VersionNumber = 09; // 0.9
private string dataDirectory = "";
// internal Configure config;
private MainForm mForm;
private bool cancelled = false;
private bool isClosing = false;
internal Sha256 sha256;
internal URLFileDct uRLFileDct;



internal MainData( MainForm useForm )
{
mForm = useForm;

setupDirectories();
// config = new Configure( this, dataDirectory +
//                   "Config.txt" );

// config.clearAllOptions();

sha256 = new Sha256( this );
uRLFileDct = new URLFileDct( this );

showStatus( "Programming by Eric Chauvin." );
showStatus( "Version Date: " + VersionDate );
showStatus( " " );
}




internal string getDataDirectory()
{
return dataDirectory;
}



internal string getOldUrlFileName()
{
return "\\AINewsData\\UrlDictionary.txt";
}


private void setupDirectories()
{
try
{
// dataDirectory = Application.StartupPath +
dataDirectory = "\\AIData\\";

// If it doesn't already exist.
SysIO.createDirectory( dataDirectory );

}
catch( Exception )
  {
  string showS =
    "The data directory could not be created.";

  throw new Exception( showS );
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



internal void freeAll()
{


}



internal void showStatus( string status )
{
mForm.showStatus( status );
}



internal void test()
{
mForm.showStatus( "Testing here." );
// sha256.test();

uRLFileDct.readFromFile( getOldUrlFileName() );
uRLFileDct.doSearch();

mForm.showStatus( " " );
mForm.showStatus( "Finished test." );
}



} // Class
