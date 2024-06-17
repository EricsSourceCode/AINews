// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



using System;



// namespace



public class URLFileDctLine
{
private MainData mData;
private URLFile[] valueArray;
private int arrayLast = 0;



private URLFileDctLine()
{
}



internal URLFileDctLine( MainData useMainData )
{
mData = useMainData;

try
{
valueArray = new URLFile[2];
}
catch( Exception Except )
  {
  freeAll();
  mData.showStatus(
     "Not enough memory for URLFileDct." );
  mData.showStatus( Except.Message );
  // return;
  }
}


internal void freeAll()
{
arrayLast = 0;
valueArray = null;
}



internal int getArrayLast()
{
return arrayLast;
}



internal void clear()
{
arrayLast = 0;
}



void resizeArrays( int toAdd )
{
int arraySize = valueArray.Length;
int newSize = arraySize + toAdd;

try
{
Array.Resize( ref valueArray, newSize );
}
catch( Exception Except )
  {
  freeAll();
  mData.showStatus(
         "Not enough memory for URLFileDct." );
  mData.showStatus( Except.Message );
  // return;
  }
}



/*

Int32 URLFileDctLine::getIndexOfUrl(
                   const CharBuf& url ) const
{
if( arrayLast < 1 )
  return -1;

const Int32 max = arrayLast;
for( Int32 count = 0; count < max; count++ )
  {
  if( valueArray[count].urlIsEqual( url ))
    return count;

  }

return -1;
}



void URLFileDctLine::setValue(
                         const URLFile& value )
{
// This sets the URLFile to the new value
// whether it's already there or not.

CharBuf url;
value.getUrl( url );

Int32 index = getIndexOfUrl( url );
if( index >= 0 )
  {
  valueArray[index].copy( value );
  }
else
  {
  if( arrayLast >= arraySize )
    resizeArrays( 16 );

  valueArray[arrayLast].copy( value );
  arrayLast++;
  }
}


void URLFileDctLine::getValue(
                          const CharBuf& url,
                          URLFile& urlFile ) const
{
urlFile.clear();
Int32 index = getIndexOfUrl( url );
if( index < 0 )
  return;

urlFile.copy( valueArray[index] );
}


void URLFileDctLine::showDateAt(
                     const Int32 where ) const
{
if( where < 0 )
  return;

if( where >= arrayLast )
  return;

valueArray[where].showDateTime();
}




====
// Java:

  public StrA makeKeysValuesStrA()
    {
    if( arrayLast < 1 )
      return StrA.Empty;

    StrABld sBld = new StrABld( 1024 * 8 );

    for( int count = 0; count < arrayLast; count++ )
      {
      StrA line = valueArray[count].toStrA();
      sBld.appendStrA( line );
      sBld.appendChar( '\n' );
      }

    return sBld.toStrA();
    }



  public StrA makeFilesStrA()
    {
    if( arrayLast < 1 )
      return StrA.Empty;

    StrABld sBld = new StrABld( 1024 * 8 );

    for( int count = 0; count < arrayLast; count++ )
      {
      StrA line = valueArray[count].getFileName();
      sBld.appendStrA( line );
      sBld.appendChar( '\n' );
      }

    return sBld.toStrA();
    }



  }
*/


} // Class
