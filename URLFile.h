// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



// See https://ericssourcecode.github.io/
// For guides and information.



#pragma once



#include "../CppBase/BasicTypes.h"
#include "../CppBase/Uint16Buf.h"
#include "MarkersAI.h"



// This can be anything at a specific URL.
// It can be an html file, a jpeg file, a pdf
// file, or anything.



class URLFile
  {
  private:
  bool testForCopy = false;

  Uint16Buf title;
  Uint16Buf fileName;
  Uint16Buf url;
  Uint16Buf dateTime;
  bool anchorsPulled = false;


  public:
  URLFile( void )
    {
    }

  URLFile( const URLFile& in )
    {
    if( in.testForCopy )
      return;

    throw "URLFile copy constructor.";
    }

  ~URLFile( void )
    {
    }

  void clear( void );
  void copy( const URLFile& toCopy );
  void toU16Buf( Uint16Buf& outBuf );
  void setFromU16Buf( const Uint16Buf& u16Buf );

  inline bool getAnchorsPulled( void ) const
    {
    return anchorsPulled;
    }

  inline void setAnchorsPulledTrue( void )
    {
    anchorsPulled = true;
    }


  inline void setAnchorsPulledFalse( void )
    {
    anchorsPulled = false;
    }

  };
