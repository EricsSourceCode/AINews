// Copyright Eric Chauvin 2024 - 2025.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;
// For Application.
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Media3D;
// using System.Windows.Media.Imaging;



// namespace


public class MainData
{
internal const string versionDate =
                              "1/8/2025";
private string dataDirectory = "";
// internal Configure config;
private MainForm mForm;
private bool cancelled = false;
private bool isClosing = false;
internal Sha256 sha256;

NeuralNet1 neuralNet;
// NeuralNet2 neuralNet;

internal URLFileDct urlFileDct;
internal WebPageDct webPageDct;
private VectorArray demParagArray;
private VectorArray repubParagArray;
private ThreeDScene scene;

// The Visual model that is specific
// to this app.

private VisualModel visModel;

// internal WordDct paragDct;



internal MainData( MainForm useForm )
{
mForm = useForm;

setupDirectories();
// config = new Configure( this, dataDirectory +
//                   "Config.txt" );

// config.clearAllOptions();

neuralNet = new NeuralNet1( this );
// neuralNet = new NeuralNet2( this );

visModel = new VisualModel( this );
scene = new ThreeDScene( this, visModel );


sha256 = new Sha256( this );
urlFileDct = new URLFileDct( this );
webPageDct = new WebPageDct( this );
demParagArray = new VectorArray( this );
repubParagArray = new VectorArray( this );
// batchParagArray = new VectorArray( this );
// labelArray = new VectorArray( this );
// paragDct = new WordDct( this );


showStatus( "Programming by Eric Chauvin." );
showStatus( "Version Date: " + versionDate );
showStatus( " " );
}



internal ThreeDScene getScene()
{
return scene;
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


internal string getWordsFileName()
{
return "\\AIData\\WordsDct.txt";
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



internal void setCancelled( bool setTo )
{
cancelled = setTo;
}


internal bool getCancelled()
{
return cancelled;
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

webPageDct.webPageSearch( toFindUrl,
                      toFind,
                      daysBack );

mForm.showStatus( " " );
mForm.showStatus( "Finished search." );
}




internal void readAllStories()
{
mForm.showStatus( "Reading all stories." );

// paragDct.readAllFromFile();

urlFileDct.readFromOldJavaFile(
                      getOldUrlFileName() );

urlFileDct.readAllWebPages( webPageDct );
                           // , paragDct );

mForm.showStatus( " " );
mForm.showStatus(
             "Finished reading all stories." );
}



internal void neuralTest()
{
mForm.showStatus( "Neural Net Test." );


int inputColumns = 1000;

//                   rows, columns
demParagArray.setSize( 10, inputColumns );
repubParagArray.setSize( 10, inputColumns );

readAllStories(); // In to storyDct.

webPageDct.neuralSearch( demParagArray,
                         repubParagArray );

showStatus( "demParagArray last: " +
                demParagArray.getLastAppend());
showStatus( "repubParagArray last: " +
                repubParagArray.getLastAppend());


neuralNet.test( demParagArray, repubParagArray );

mForm.showStatus( "Neural net test finished." );
}




internal void setFromWeightVecs(
                             VectorFlt vec1,
                             VectorFlt vec2 )
{
visModel.setFromWeightVecs( vec1, vec2 );
}




} // Class
