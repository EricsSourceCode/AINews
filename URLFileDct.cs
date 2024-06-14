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
private static const int keySize = 0xFFFF;
private ByteBuf hash;
private ByteBuf resultHash;
private ByteBuf message;


private URLFileDct( void )
{
}



internal URLFileDct( MainData useMainData )
{
mData = useMainData;

try
{
lineArray = new URLFileDctLine[keySize];
hash = new ByteBuf();
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
lineArray = null;
}



void clear()
{
if( lineArray == null )
  return;

for( int count = 0; count < keySize; count++ )
  lineArray[count].clear();

}



internal int getIndex( string url )
{
int lastUrl = url.getLast();
if( lastUrl == 0 )
  return 0;

message.setFromAsciiStr( url );
mData.sha256.makeHash( resultHash, message );
// string showS = resultHash.getHexStr();
// mData.showStatus( showS );

Int32 index = hash.getU8( 0 );
index <<= 8;
index |= hash.getU8( 1 );

index = index & keySize;
if( index >= keySize )
  index = keySize - 1;

return index;
}




/*
////////
Java:
  public void setValue( StrA key, URLFile value )
    {
    try
    {
    if( key == null )
      return;

    key = key.toLowerCase();
    if( key.length() < 1 )
      return;

    // mApp.showStatusAsync( "Setting value: " + key );

    int index = getIndex( key );
    if( lineArray[index] == null )
      lineArray[index] = new URLFileDictionaryLine( mApp );

    lineArray[index].setValue( key, value );
    }
    catch( Exception e )
      {
      mApp.showStatusAsync( "Exception in setValue()." );
      mApp.showStatusAsync( e.getMessage() );
      }
    }



  public URLFile getValue( StrA key )
    {
    if( key == null )
      return null;

    key = key.toLowerCase();
    if( key.length() < 1 )
      return null;

    int index = getIndex( key );
    if( lineArray[index] == null )
      return null;

    return lineArray[index].getValue( key );
    }



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




internal void readFromFile( void )
{
mData.showStatus(
             "Reading from URL index file." );

clear();

/*
string fileStr = SysIO.readAllText( 
                        string fromFile )


CharBuf cBuf;
FileIO::readAll( Configure::getOldUrlIndexName(),
                 cBuf );

UTF8Str utf8Str;
Uint16Buf fileBuf;
utf8Str.charBufToU16Buf( cBuf, fileBuf );

// const Int32 last = fileBuf.getLast();

Uint16Buf lineBuf;
Int32 where = 0;
Int32 howMany = 0;
for( Int32 count = 0; count < 1000000; count++ )
  {
  where = fileBuf.getField( lineBuf,
                            where, '\n' );

  howMany++;
  if( where < 0 )
    {
    StIO::printF( "\n\nLinks: " );
    StIO::printFD( howMany );
    StIO::putLF();
    return;
    }

  where++;

  URLFile urlFile;
  urlFile.setFromU16Buf( lineBuf );

  CharBuf url;
  urlFile.getUrl( url );
  Int32 index = getIndex( url );
  lineArray[index].setValue( urlFile );
  }
*/
}



/*
void URLFileDct::doSearch( void )
{
=====
StIO::putS( "Doing search." );

Int32 howMany = 0;

Uint16Buf toFind;
toFind.setFromCharPoint( "trump" );

Uint16Buf toFindUrl;
// toFindUrl.setFromCharPoint( "msnbc" );
toFindUrl.setFromCharPoint( "foxnews" );

for( Int32 count = 0; count < keySize; count++ )
  {
  if( howMany > 50 )
    break;

  Int32 last = lineArray[count].getArrayLast();
  if( last < 1 )
    continue;

  for( Int32 countR = 0; countR < last; countR++ )
    {
    lineArray[count].showDateAt( countR );
    howMany++;
    }



///////////
=====
  where = fileBuf.getField( lineBuf,
                            where, '\n' );

  if( where < 0 )
    {
    StIO::printF( "\n\nLinks: " );
    StIO::printFD( howMany );
    StIO::putLF();
    return;
    }

  where++;

  URLFile urlFile;
  urlFile.setFromU16Buf( lineBuf );

  Uint16Buf url;
  urlFile.getUrl( url );
  Int32 index = getIndex( url );

  lineArray[index].setValue( urlFile );

  // if( howMany < 200 )
    {
    // StIO::putLF();
    Uint16Buf showLinkText;
    urlFile.getLinkText( showLinkText );

    if( url.findText( toFindUrl, 0 ) >= 0 )
      {
      if( showLinkText.findText( toFind, 0 )
                                    >= 0 )
        {
        showLinkText.showAscii();
        }
      }

    // url.showAscii();
    // StIO::printF( "URL index is: " );
    // StIO::printFD( index );
    // StIO::putLF();
    }

  howMany++;
////////////

  }

StIO::printF( "\n\nLinks: " );
StIO::printFD( howMany );
StIO::putLF();
}
*/


} // Class
