// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



using System;



// namespace



public class URLFileDct // Dictionary of URLs.
{
private MainData mData;
private URLFileDctLine[] lineArray;
private const int keySize = 0xFF;
private ByteBuf resultHash;
private ByteBuf message;


private URLFileDct()
{
}



internal URLFileDct( MainData useMainData )
{
mData = useMainData;

try
{
lineArray = new URLFileDctLine[keySize];
for( int count = 0; count < keySize; count++ )
  lineArray[count] = new URLFileDctLine( mData );

resultHash = new ByteBuf();
message = new ByteBuf();

}
catch( Exception Except )
  {
  freeAll();
  mData.showStatus(
     "Not enough memory for URLFileDctLines." );
  mData.showStatus( Except.Message );
  // return;
  }
}



void freeAll()
{
clear();
// lineArray = null;
}



void clear()
{
for( int count = 0; count < keySize; count++ )
  lineArray[count].clear();

}



internal int getIndex( string url )
{
if( url.Length == 0 )
  return 0;

message.setFromAsciiStr( url );
mData.sha256.makeHash( resultHash, message );
// string showS = resultHash.getHexStr();
// mData.showStatus( showS );

int index = resultHash.getU8( 0 );
index <<= 8;
index |= resultHash.getU8( 1 );

index = index & keySize;
if( index == keySize )
  index = keySize - 1;

/*
  {
  // Distribute those last two at keySize
  // and keySize - 1 more evenly.
  // index = keySize - 1;
  int lastB = message.getLast();
  byte lastByte = message.getU8( lastB - 1 );
  index = index - lastByte;
  }
*/

return index;
}



internal void setValue( string key,
                        URLFile value )
{
try
{
if( key == null )
  return;

key = Str.toLower( key );
if( key == "" )
  return;

int index = getIndex( key );

lineArray[index].setValue( value );
}
catch( Exception )
  {
  throw new Exception(
       "URLFileDct Exception in setValue()." );
  }
}



internal void getValue( string key,
                        URLFile toGet )
{
toGet.clear();
if( key == null )
  return;

key = Str.toLower( key );
if( key == "" )
  return;

int index = getIndex( key );
if( lineArray[index].getArrayLast() == 0 )
  return;

lineArray[index].getValue( key, toGet );
}



/*
  public StrA makeKeysValuesStrA()
    {
    try
    {
    StrABld sBld = new StrABld( 1024 * 64 );

    for( int count = 0; count < keySize; count++ )
      {
      if( lineArray[count] == null )
        continue;

      StrA lines = lineArray[count].
                                 makeKeysValuesStrA();

      if( lines.length() == 0 )
        continue;

      // mApp.showStatusAsync( "At " + count +
      //                " length: " + lines.length() );


      sBld.appendStrA( lines );
      }

    return sBld.toStrA();
    }
    catch( Exception e )
      {
      mApp.showStatusAsync( "Exception in URLFileDictionary.makeKeysValuesStrA():\n" );
      mApp.showStatusAsync( e.getMessage() );
      return StrA.Empty;
      }
    }



  public boolean keyExists( StrA key )
    {
    if( key == null )
      return false;

    key = key.trim().toLowerCase();
    if( key.length() < 1 )
      return false;

    int index = getIndex( key );
    if( lineArray[index] == null )
      return false;

    return lineArray[index].keyExists( key );
    }



  public void saveToFile()
    {
    StrA fileS = makeKeysValuesStrA();
    FileUtility.writeStrAToFile( mApp,
                                 fileName,
                                 fileS,
                                 false,
                                 true );
    }
*/




internal void readFromOldJavaFile(
                             string fileName )
{
// mData.showStatus(
//         "Reading from URL index file." );
// mData.showStatus( fileName );

clear();

string fileStr = SysIO.readAllText( fileName );

StrAr lines = new StrAr();
lines.split( fileStr, '\n' );
int last = lines.getLast();

// mData.showStatus( "Links: " + last );

for( int count = 0; count < last; count++ )
  {
  string line = lines.getStrAt( count );
  line = Str.trim( line );

  URLFile urlFile = new URLFile( mData );
  urlFile.setFromOldJavaStr( line );

  string url = urlFile.getUrl();
  // mData.showStatus( urlFile.toString());

  int index = getIndex( url );
  // mData.showStatus( "index: " + index );
  // if( count > 50 )
    // break;

  lineArray[index].setValue( urlFile );

  // URLFile testUrlFile = new URLFile( mData );
  // getValue( url, testUrlFile );
  // mData.showStatus( "here: " );
  // mData.showStatus( testUrlFile.toString());
  }
}



internal void htmlSearch( string toFindUrl,
                   string toFind,
                   double daysBack,
                   StoryDct storyDct,
                   FloatMatrix paragMatrix )
{
// mData.showStatus( "Doing HTML search." );

toFindUrl = Str.toLower( toFindUrl );
toFind = Str.toLower( toFind );

storyDct.clear();

// int howMany = 0;

URLFile urlFile = new URLFile( mData );
TimeEC timeEC = new TimeEC();
TimeEC oldTime = new TimeEC();
oldTime.setToNow();
oldTime.addDays( daysBack );
// addHours()
ulong oldIndex = oldTime.getIndex();

for( int count = 0; count < keySize; count++ )
  {
  if( (count % 20) == 0 )
    {
    if( !mData.checkEvents())
      return;

    }

  // if( howMany > 20 )
    // break;

  int last = lineArray[count].getArrayLast();
  if( last < 1 )
    continue;

  // mData.showStatus( "Last: " + last );
  for( int countR = 0; countR < last; countR++ )
    {
    lineArray[count].getCopyURLFileAt(
                                    urlFile,
                                    countR );

    ulong linkDateIndex = urlFile.getDateIndex();

    if( linkDateIndex < oldIndex )
      continue;

    // if( urlFile.getYear() < 2024 )
      // continue;

    string url = urlFile.getUrl();
    string urlFrom = url;
    url = Str.toLower( url );
    if( !Str.contains( url, toFindUrl ))
      continue;

    string linkText = urlFile.getLinkText();
    string linkTextLower =
                      Str.toLower( linkText );

    if( !Str.contains( url, toFindUrl ))
      continue;

   if( !Str.contains( linkTextLower, toFind ))
      continue;

    string fileName = urlFile.getFileName();
    string fullPath = mData.
                    getOldDataDirectory() +
                    "URLFiles\\" + fileName;

    if( !SysIO.fileExists( fullPath ))
      continue;

    HtmlFile htmlFile = new HtmlFile( mData,
                                urlFrom,
                                fullPath,
                                linkDateIndex,
                                linkText );

    htmlFile.readFileS();
    htmlFile.markupSections();
    // htmlFile.processNewAnchorTags();


    Story story = new Story( mData, urlFrom,
                  linkDateIndex, linkText );

    if( htmlFile.makeStory( story ))
      {
      storyDct.setValue( story.getUrl(), story );
      story.showStory();
      }

    // howMany++;

    // return;
    }
  }

storyDct.writeAllToFile();
}




internal void readAllStories(
                     StoryDct storyDct )
{
mData.showStatus( "Reading all stories." );

storyDct.readAllFromFile();

URLFile urlFile = new URLFile( mData );

int howMany = 0;
for( int count = 0; count < keySize; count++ )
  {
  if( (count % 20) == 0 )
    {
    if( !mData.checkEvents())
      return;

    }

  // if( howMany > 50 )
    // break;

  int last = lineArray[count].getArrayLast();
  if( last < 1 )
    continue;

  // mData.showStatus( "Last: " + last );
  for( int countR = 0; countR < last; countR++ )
    {
    lineArray[count].getCopyURLFileAt(
                                    urlFile,
                                    countR );

    string urlFrom = urlFile.getUrl();

    // If it already has this story.
    if( storyDct.keyExists( urlFrom ))
      continue;


    string fileName = urlFile.getFileName();
    string fullPath = mData.
                    getOldDataDirectory() +
                    "URLFiles\\" + fileName;

    if( !SysIO.fileExists( fullPath ))
      continue;

    ulong linkDateIndex = urlFile.getDateIndex();
    string linkText = urlFile.getLinkText();

    HtmlFile htmlFile = new HtmlFile( mData,
                                urlFrom,
                                fullPath,
                                linkDateIndex,
                                linkText );

    htmlFile.readFileS();
    htmlFile.markupSections();

    Story story = new Story( mData, urlFrom,
                  linkDateIndex, linkText );

    if( htmlFile.makeStory( story ))
      {
      storyDct.setValue( story.getUrl(), story );
      // story.showStory();
      howMany++;
      }
    }
  }

mData.showStatus(
        "Stories from old data: " + howMany );

storyDct.writeAllToFile();
}




} // Class
