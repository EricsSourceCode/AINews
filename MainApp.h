// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



// See https://ericssourcecode.github.io/
// For more information.



#pragma once


#include "../CppBase/BasicTypes.h"
#include "../CppBase/CharBuf.h"
#include "../Network/SocketsApi.h"
#include "Configure.h"
#include "URLFileDct.h"



class MainApp
  {
  private:
  bool testForCopy = false;
  Configure config;
  UrlFileDct urlFileDct;

  // The constructor for SocketsApi does
  // WSAStartup() and the destructor does
  // WSACleanup(). So the Windows dlls stay
  // going for the life of this app.

  // In BuildProj.bat use -lWs2_32.lib
  // to link it with the Windows Sockets
  // library.

  SocketsApi socketsApi;

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
    return "3/21/2024";
    }

  // Int32 mainLoop( Int32 argc, char* argv[] );
  Int32 mainLoop( void );

  };
