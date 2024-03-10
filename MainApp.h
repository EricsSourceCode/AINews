// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



// See https://ericinarizona.github.io/
// For more information.


#pragma once


#include "../CppBase/BasicTypes.h"
#include "../CppBase/CharBuf.h"
#include "Configure.h"
#include "URLFileDictionary.h"



class MainApp
  {
  private:
  bool testForCopy = false;
  Configure config;
  UrlFileDictionary urlFileDictionary;

  public:
  MainApp( void )
    {
    }


  MainApp( const MainApp& in )
    {
    if( in.testForCopy )
      return;

    throw "MainApp copy constructor.";
    }

  ~MainApp( void )
    {
    }

  static const char* getVersionStr( void )
    {
    return "2/14/2024";
    }

  // Int32 mainLoop( Int32 argc, char* argv[] );
  Int32 mainLoop( void );

  };
