// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




#include "URLFileDct.h"
#include "../CppBase/StIO.h"
#include "../CppBase/FileIO.h"
#include "../CppBase/UTF8Str.h"
#include "../CppBase/Casting.h"



UrlFileDct::UrlFileDct( void )
{
lineArray = new URLFileDctLine[
             Casting::i32ToU64( keySize )];
}



UrlFileDct::UrlFileDct( const UrlFileDct& in )
{
if( in.testForCopy )
  return;

lineArray = new URLFileDctLine[
             Casting::i32ToU64( keySize )];

throw "UrlFileDct copy constructor.";
}



UrlFileDct::~UrlFileDct( void )
{
delete[] lineArray;
}



#include "../CppMem/MemoryWarnTop.h"



void UrlFileDct::clear( void )
{
for( int count = 0; count < keySize; count++ )
  lineArray[count].clear();

}


/*
  private int getIndex( StrA url )
    {
    if( url.length() == 0 )
      return 0;

    int index = url.GetCRC16();
    if( index >= keySize )
      index = keySize - 1;

    return index;
    }



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


void UrlFileDct::readFromFile( void )
{
StIO::putS( "Reading from URL index file." );

// clear();

CharBuf charBuf;

FileIO::readAll( Configure::getUrlIndexName(),
                 charBuf );

// StIO::putCharBuf( charBuf );

UTF8Str utf8Str;
Uint16Buf fileBuf;

utf8Str.charBufToU16Buf( charBuf, fileBuf );

const Int32 last = fileBuf.getLast();
for( Int32 count = 0; count < last; count++ )
  {
  Uint16 val = fileBuf.getVal( count );
  if( val < 127 )
    {
    StIO::putChar( val & 0x7F );
    }
  else
    {
    StIO::putS( "\ndelim" );
    }
  }


/*

    for( int count = 0; count < last; count++ )
      {
      StrA line = lines.getStrAt( count );
      if( line.containsStrA( badS ))
        continue;

      // mApp.showStatusAsync( "line: " + line );
      URLFile uFile = new URLFile( mApp );
      uFile.setFromStrA( line );
      setValue( uFile.getUrl(), uFile );
      }
*/
}


#include "../CppMem/MemoryWarnBottom.h"
