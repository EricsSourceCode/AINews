// Copyright Eric Chauvin 2020 - 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




#pragma once


#include "../CppBase/BasicTypes.h"
#include "../CppBase/CharBuf.h"
#include "Configure.h"



class UrlFileDictionary
  {
  private:
  bool testForCopy = false;

  // URLFileDictionaryLine lineArray[];
  // static final int keySize = 0xFFFF + 1;
  // private StrA fileName = StrA.Empty;


  public:
  UrlFileDictionary( void )
    {
    // lineArray = new URLFileDictionaryLine[
    //                              keySize];

    }

  UrlFileDictionary(
               const UrlFileDictionary& in )
    {
    if( in.testForCopy )
      return;

    throw "UrlFileDictionary copy constructor.";
    }

  ~UrlFileDictionary( void )
    {
    }

  void readFromFile( void );

  };
