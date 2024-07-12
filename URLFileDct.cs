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
  {
  // Distribute those last two at keySize
  // and keySize - 1 more evenly.
  // index = keySize - 1;
  int lastB = message.getLast();
  byte lastByte = message.getU8( lastB - 1 );
  index = index - lastByte;
  }

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




internal void readFromFile( string fileName )
{
mData.showStatus(
             "Reading from URL index file." );
mData.showStatus( fileName );

clear();

string fileStr = SysIO.readAllText( fileName );

StrAr lines = new StrAr();
lines.split( fileStr, '\n' );
int last = lines.getLast();

mData.showStatus( "Links: " + last );

for( int count = 0; count < last; count++ )
  {
  string line = lines.getStrAt( count );
  line = Str.trim( line );

  URLFile urlFile = new URLFile( mData );
  urlFile.setFromStr( line );

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




internal void titleSearch()
{
mData.showStatus( "Doing title search." );

int howMany = 0;

// string toFind = "trump";
// string toFind = "biden";

// string toFindUrl = "msnbc";
string toFindUrl = "foxnews";

URLFile urlFile = new URLFile( mData );
TimeEC timeEC = new TimeEC();

for( int count = 0; count < keySize; count++ )
  {
  if( (count % 10) == 0 )
    {
    if( !mData.checkEvents())
      return;

    }

  if( howMany > 50 )
    break;

  int last = lineArray[count].getArrayLast();
  if( last < 1 )
    continue;

  // mData.showStatus( "Last: " + last );
  for( int countR = 0; countR < last; countR++ )
    {
    lineArray[count].getCopyURLFileAt(
                                    urlFile,
                                    countR );

    // string linkDate = urlFile.
     //                    getDateTimeStr();

    // string showS = urlFile.toString();
    // mData.showStatus( showS );

    if( urlFile.getYear() < 2024 )
      continue;

    if( urlFile.getMonth() < 6 )
      continue;

    // if( urlFile.getDay() < 15 )
      // continue;

    string url = urlFile.getUrl();
    string showUrl = url;
    url = Str.toLower( url );
    if( !Str.contains( url, toFindUrl ))
      continue;

    string linkText = urlFile.getLinkText();
    string showLinkText = linkText;
    linkText = Str.toLower( linkText );
    // if( !Str.contains( linkText, toFind ))
      // continue;

    mData.showStatus( " " );
    mData.showStatus( " " );
    mData.showStatus( " " );
    // mData.showStatus( "Year: " +
    //                      urlFile.getYear());

    mData.showStatus( showLinkText );
    mData.showStatus( showUrl );
    // lineArray[count].showDateAt( countR );

    howMany++;
    if( howMany > 50 )
      break;

    }
  }

mData.showStatus( "\r\nMatching links: " +
                                     howMany );
}




internal void htmlSearch()
{
mData.showStatus( "Doing HTML search." );

int howMany = 0;

// string toFind = "trump";
// string toFind = "biden";

// string toFindUrl = "msnbc";
string toFindUrl = "foxnews";

URLFile urlFile = new URLFile( mData );
TimeEC timeEC = new TimeEC();

for( int count = 0; count < keySize; count++ )
  {
  if( (count % 10) == 0 )
    {
    if( !mData.checkEvents())
      return;

    }

  if( howMany > 50 )
    break;

  int last = lineArray[count].getArrayLast();
  if( last < 1 )
    continue;

  // mData.showStatus( "Last: " + last );
  for( int countR = 0; countR < last; countR++ )
    {
    lineArray[count].getCopyURLFileAt(
                                    urlFile,
                                    countR );

    // string linkDate = urlFile.
     //                    getDateTimeStr();

    if( urlFile.getYear() < 2024 )
      continue;

    if( urlFile.getMonth() < 6 )
      continue;

    // if( urlFile.getDay() < 15 )
      // continue;

    string url = urlFile.getUrl();
    string urlFrom = url;
    url = Str.toLower( url );
    if( !Str.contains( url, toFindUrl ))
      continue;

    string linkText = urlFile.getLinkText();
    string showLinkText = linkText;

/*
    linkText = Str.toLower( linkText );
    // if( !Str.contains( linkText, toFind ))
      // continue;
    */

    string fileName = urlFile.getFileName();
    string fullPath = mData.
                    getOldDataDirectory() +
                    "URLFiles\\" + fileName;

    if( !SysIO.fileExists( fullPath ))
      continue;

    HtmlFile htmlFile = new HtmlFile( mData,
                                      urlFrom,
                                      fullPath );

    htmlFile.readFileS();
    htmlFile.markupSections();
    // htmlFile.processNewAnchorTags();
===== Give it the linkText.
There is no title.
    Story story = new Story( mData, urlFrom );
    htmlFile.makeStory( story );

    mData.showStatus(
                "\r\nFinished Html file." );

    howMany++;

    // return;
    }
  }

mData.showStatus( "\r\nMatching links: " +
                                     howMany );
}




} // Class
