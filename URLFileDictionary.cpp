// Copyright Eric Chauvin 2020 - 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




#include "URLFileDictionary.h"
#include "../CppBase/StIO.h"
#include "../CppBase/FileIO.h"


/*
void UrlFileDictionary::clear( void )
{
for( int count = 0; count < keySize; count++ )
  lineArray[count] = null;

}



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


void UrlFileDictionary::readFromFile( void )
{
StIO::putS( "Reading from URL index file." );

// clear();

CharBuf fileBuf;

FileIO::readAll( Configure::getUrlIndexName(),
                 fileBuf );

StIO::putCharBuf( fileBuf );


/*
    StrA fileS = FileUtility.readFileToStrA( mApp,
                                 fileName,
                                 false,
                                 true );

    // mApp.showStatusAsync( "Read file: " + fileS );
    StrArray lines = fileS.splitChar( '\n' );
    final int last = lines.length();
    StrA badS = new StrA( "radiationnetwork.net" );

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
