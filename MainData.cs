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
                              "8/13/2024";
private string dataDirectory = "";
// internal Configure config;
private MainForm mForm;
private bool cancelled = false;
private bool isClosing = false;
internal Sha256 sha256;
internal URLFileDct urlFileDct;
internal StoryDct storyDct;



internal MainData( MainForm useForm )
{
mForm = useForm;

setupDirectories();
// config = new Configure( this, dataDirectory +
//                   "Config.txt" );

// config.clearAllOptions();

sha256 = new Sha256( this );
urlFileDct = new URLFileDct( this );
storyDct = new StoryDct( this );

showStatus( "Programming by Eric Chauvin." );
showStatus( "Version Date: " + VersionDate );
showStatus( " " );

// storyDct.readAllFromFile();
}




internal string getDataDirectory()
{
return dataDirectory;
}



internal string getOldUrlFileName()
{
return "\\AINewsData\\UrlDictionary.txt";
}



internal string getStoriesFileName()
{
return "\\AIData\\Stories.txt";
}


internal string getOldDataDirectory()
{
return "\\AINewsData\\";
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



internal bool getIsClosing()
{
return isClosing;
}



internal bool checkEvents()
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


internal void clearStatus()
{
mForm.clearStatus();
}




internal void paraSearch( string toFindUrl,
                          string toFind,
                          double daysBack )
{
readAllStories(); // In to storyDct.

// string toFindUrl = "msnbc";
// string toFindUrl = "foxnews";

// mForm.showStatus( "Testing here." );
// sha256.test();

storyDct.storySearch( toFindUrl,
                      toFind,
                      daysBack );

mForm.showStatus( " " );
mForm.showStatus( "Finished search." );
}




internal void readAllStories()
{
mForm.showStatus( "Reading all stories." );

urlFileDct.readFromFile( getOldUrlFileName() );

urlFileDct.readAllStories( storyDct );

mForm.showStatus( " " );
mForm.showStatus(
             "Finished reading all stories." );
}



internal void neuralTest()
{
NeuralNet net = new NeuralNet( this );
net.test();

}



} // Class
