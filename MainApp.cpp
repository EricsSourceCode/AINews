// Copyright Eric Chauvin, 2021 - 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html


#include "MainApp.h"

#include "../CppBase/StIO.h"
#include "../CppBase/FileIO.h"
// #include "../LinuxApi/SetStack.h"
#include "../CppBase/Casting.h"
#include "../CppBase/Threads.h"


#include "../WinApi/Signals.h"
// #include "../LinuxApi/Signals.h"

// #include "../CryptoBase/Sha256.h"
// #include "../CryptoBase/Base64.h"
// #include "../CryptoBase/AesGalois.h"

#include "../CryptoBase/SPrimes.h"
#include "../CryptoBase/RsaTest.h"
#include "../Network/ClientTls.h"


// int MainApp::mainLoop( int argc, char* argv[] )
int MainApp::mainLoop( void )
{
Int32 delay = 200; // milliseconds.

try
{
BasicTypes::thingsAreRight();

StIO::putLF();
StIO::putS( "AI News." );
StIO::putS( "Programming by Eric Chauvin." );
StIO::printF( "Version date: " );
StIO::putS( getVersionStr() );
StIO::putLF();

// For Linux:
// Int32 stackSize = SetStack::getSize();
// Str showS( stackSize );
// mainIO.appendChars( "Stack size: " );
// mainIO.appendStr( showS );
// mainIO.appendChars( "\n\n" );

Signals::setupControlCSignal();
Signals::setupFpeSignal();
Signals::setupIllegalOpSignal();
Signals::setupBadMemSignal();

StIO::putS( "Initializing." );

quadRes.init( sPrimes );
multInv.init( sPrimes );
// findFacQr.init( intMath, sPrimes );
crtMath.init( intMath,
              sPrimes );
garnerCrt.setUpConstants( sPrimes, intMath );


// StIO::putS( "Starting RSA test." );
// RsaTest rsaTest;
// rsaTest.test( rsa, mod, sPrimes, intMath,
//              findFacSm, //findFacQr,
//              multInv, // quadRes,
//              crtMath, garnerCrt );


testTls();

// urlFileDct.readFromFile();


StIO::putS( "End of the test." );


StIO::putS( "End of main app." );

Threads::sleep( delay );

return 0;
}
catch( const char* in )
  {
  StIO::putS( "Exception in main loop." );
  StIO::putS( in );
  StIO::putLF();

  Threads::sleep( delay );
  return 1;
  }

catch( ... )
  {
  const char* in = "An unknown exception"
                   " happened in the main loop.\n";

  StIO::putS( in );

  Threads::sleep( delay );
  return 1;
  }
}




void MainApp::testTls( void )
{
StIO::putS( "Starting TLS test." );


ClientTls clientTls;


// ==== Add other news sites like Leadville,
// The Economist, etc.

// "https://www.msnbc.com/"
// "https://www.foxnews.com/"

if( !clientTls.startHandshake(
                        "durangoherald.com",
                        "443" ))

// if( !clientTls.startHandshake( "127.0.0.1",
//                               "443" ))

// if( !clientTls.startTestVecHandshake(
//                             "127.0.0.1",
//                             "443" ))
  {
  StIO::putS(
        "ClientTls false on startHandshake." );

  return;
  }

=======

const char* getRequest = "GET / HTTP/1.1\r\n"
               "Host: www.durangoherald.com\r\n"
               "User-Agent: AINews\r\n"
               "Connection: keep-alive\r\n"
               "\r\n";

CharBuf appDataToSend;
appDataToSend.setFromCharPoint( getRequest );

// This will go out after the handshake.
appOutBuf.addCharBuf( appDataToSend );

for( Int32 count = 0; count < 100; count++ )
  {
  if( Signals::getControlCSignal())
    {
    StIO::putS( "Closing on Ctrl-C." );
    break;
    }

  StIO::putS(
        "Top of MainApp.processData loop()." );
  Int32 status = clientTls.processData(
                                  appOutBuf );

  // Shut it down immediately.
  if( status < 0 )
    break;

  // Let it time out so it can send things.
  // if( status == 0 )
    // break;

  Threads::sleep( 1000 );
  }

StIO::putS( "Finished TLS test." );
}
