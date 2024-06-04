// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



// See https://ericssourcecode.github.io/
// For guides and information.



using System;
// using System.Text;
// Application, MessageBox, etc.




// namespace


public class URLFile
{
private MainData mData;
private string linkText = "";
private string fileName = "";
private string url = "";
private string dateTime = "";
private bool anchorsPulled = false;
private string titleHtml = "";


internal URLFile( MainData useMainData )
{
mData = useMainData;
}




bool getAnchorsPulled()
{
return anchorsPulled;
}


void setAnchorsPulled( bool setTo )
{
anchorsPulled = setTo;
}


// Copy on write.
internal string getTitleHtml()
{
return titleHtml;
}


internal string getFileName()
{
return fileName;
}


internal string getLinkText()
{
return linkText;
}


internal string getUrl()
{
return url;
}


internal string getDateTime()
{
return dateTime;
}



void showDateTime()
{
mData.showStatus( dateTime );
}



bool urlIsEqual( string toCheck )
{
if( url == toCheck )
  return true;

return false;
}



void clear()
{
linkText = "";
fileName = "";
url = "";
dateTime = "";
anchorsPulled = false;
titleHtml = "";
}



void copy( URLFile toCopy )
{
linkText = toCopy.linkText;
fileName = toCopy.fileName;
url = toCopy.url;
dateTime = toCopy.dateTime;
anchorsPulled = toCopy.anchorsPulled;
titleHtml = toCopy.titleHtml;
}



/*
===== Java:

  private StrA makeNewFileName( StrA fromURL )
    {
    if( fromURL.length() == 0 )
      return StrA.Empty;

    LocalDateTime rightNow = LocalDateTime.now();
    int year = rightNow.getYear();

    int month = rightNow.getMonthValue();
    int day = rightNow.getDayOfMonth();

    // int getDayOfYear()
    // getDayOfWeek()

    int hour = rightNow.getHour();
    int minute = rightNow.getMinute();
    int second = rightNow.getSecond();
    int nano = rightNow.getNano();

    int index = url.GetCRC16();

    String fileName = "UFile_" +
           year + "_" +
           month + "_" +
           day + "_" +
           hour + "_" +
           minute + "_" +
           second + "_" +
           nano + "_" +
           index + ".txt";

    return new StrA( fileName );
    }



  private StrA makeDateTime()
    {
    LocalDateTime rightNow = LocalDateTime.now();
    int year = rightNow.getYear();
    int month = rightNow.getMonthValue();
    int day = rightNow.getDayOfMonth();
    int hour = rightNow.getHour();
    int minute = rightNow.getMinute();
    int second = rightNow.getSecond();
    int nano = rightNow.getNano();

    String result = "" +
           year + ";" +
           month + ";" +
           day + ";" +
           hour + ";" +
           minute + ";" +
           second + ";" +
           nano;

    return new StrA( result );
    }
*/



string toString()
{
=====
string result = url +
                MarkersAI.URLFileDelimit;

/*
outBuf.appendCharBuf( linkText );
outBuf.appendU16( MarkersAI::URLFileDelimit );
outBuf.appendCharBuf( fileName );
outBuf.appendU16( MarkersAI::URLFileDelimit );
outBuf.appendCharBuf( dateTime );
outBuf.appendU16( MarkersAI::URLFileDelimit );

if( anchorsPulled )
  outBuf.appendU16( 't' & 0xFF );
else
  outBuf.appendU16( 'f' & 0xFF );

outBuf.appendU16( MarkersAI::URLFileDelimit );

outBuf.appendCharBuf( titleHtml );
outBuf.appendU16( MarkersAI::URLFileDelimit );
*/

return result;
}




/*
void URLFile::setFromU16Buf(
                     const Uint16Buf& u16Buf )
{
Int32 startAt = 0;

startAt = u16Buf.getFieldC( url, startAt,
                 MarkersAI::URLFileDelimit );

if( startAt < 0 )
  return;

startAt++; // Go past the delimiter it found.

startAt = u16Buf.getFieldC( linkText, startAt,
                 MarkersAI::URLFileDelimit );

if( startAt < 0 )
  return;

startAt++;

startAt = u16Buf.getFieldC( fileName, startAt,
                 MarkersAI::URLFileDelimit );

if( startAt < 0 )
  return;

startAt++;

startAt = u16Buf.getFieldC( dateTime, startAt,
                 MarkersAI::URLFileDelimit );

if( startAt < 0 )
  return;

startAt++;

CharBuf anchors;
startAt = u16Buf.getFieldC( anchors, startAt,
                 MarkersAI::URLFileDelimit );

if( anchors.getLast() < 1 )
  {
  anchorsPulled = false;
  }
else
  {
  if( anchors.getC( 0 ) == 't' )
    anchorsPulled = true;
  else
    anchorsPulled = false;

  }

startAt++;

u16Buf.getFieldC( titleHtml, startAt,
                 MarkersAI::URLFileDelimit );
}

*/


} // Class
