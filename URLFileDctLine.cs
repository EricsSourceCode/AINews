// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



// See https://ericssourcecode.github.io/
// For guides and information.



using System;



// namespace



public class URLFileDctLine
{

// URLFile* valueArray;
// int arraySize = 2;
private int arrayLast = 0;

internal int getArrayLast()
{
return arrayLast;
}



/*
URLFileDctLine::URLFileDctLine( void )
{
valueArray = new URLFile[
              Casting::i32ToU64( arraySize )];

}



URLFileDctLine::URLFileDctLine(
                    const URLFileDctLine& in )
{
valueArray = new URLFile[
              Casting::i32ToU64( arraySize )];

if( in.testForCopy )
  return;

throw "URLFileDctLine copy constructor.";
}



URLFileDctLine::~URLFileDctLine( void )
{
delete[] valueArray;
}




void URLFileDctLine::clear()
{
arrayLast = 0;

// const Int32 last = arraySize;
// for( Int32 count = 0; count < last; count++ )
  // valueArray[count].clear();

}



void URLFileDctLine::resizeArrays(
                           const Int32 toAdd )
{
if( arrayLast > arraySize )
  throw
     "URLFileDctLine::resizeArrays arrayLast";

const Int32 newSize = arraySize + toAdd;

URLFile* newValueArray;
newValueArray = new URLFile[
             Casting::i32ToU64( newSize )];

const Int32 max = arrayLast;
for( Int32 count = 0; count < max; count++ )
  newValueArray[count].copy( valueArray[count] );

arraySize = newSize;
delete[] valueArray;
valueArray = newValueArray;
}



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

