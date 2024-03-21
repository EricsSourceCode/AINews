// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




#pragma once


#include "../CppBase/BasicTypes.h"
#include "../CppBase/CharBuf.h"
#include "../CppBase/Uint16Buf.h"
#include "Configure.h"
#include "URLFileDctLine.h"



class UrlFileDct // File Dictionary
  {
  private:
  bool testForCopy = false;

  URLFileDctLine* lineArray;
  static const Int32 keySize = 0xFFF;
  Uint16Buf fileBuf;

  public:
  UrlFileDct( void );
  UrlFileDct( const UrlFileDct& in );
  ~UrlFileDct( void );

  void readFromFile( void );
  void clear( void );

  };
