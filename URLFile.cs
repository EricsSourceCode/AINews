// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;



// namespace


public class URLFile
{
private MainData mData;
private string linkText = "";
private string fileName = "";
private string url = "";
private TimeEC dateTime;
private bool anchorsPulled = false;
private string titleHtml = "";


private URLFile()
{
}



internal URLFile( MainData useMainData )
{
mData = useMainData;
dateTime = new TimeEC();
}




bool getAnchorsPulled()
{
return anchorsPulled;
}


void setAnchorsPulled( bool setTo )
{
anchorsPulled = setTo;
}


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


internal string getDateTimeStr()
{
return dateTime.getLocalYear() + ";"; // +

// 2024;3;7;10;13;17;877828000;
}


/*
internal void showDateTime()
{
mData.showStatus( getDateTimeStr());
}
*/


internal bool urlIsEqual( string toCheck )
{
if( url == toCheck )
  return true;

return false;
}



internal void clear()
{
linkText = "";
fileName = "";
url = "";
dateTime.setToYear1900();
anchorsPulled = false;
titleHtml = "";
}



internal void copy( URLFile toCopy )
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



internal string toString()
{
string anchors = "f";
if( anchorsPulled )
  anchors = "t";

string result = Str.trim( url ) +
         MarkersAI.URLFileDelimit +
         Str.trim( linkText ) +
         MarkersAI.URLFileDelimit +
         Str.trim( fileName ) +
         MarkersAI.URLFileDelimit +
         dateTime.toDelimStr() +
         MarkersAI.URLFileDelimit +
         anchors +
         MarkersAI.URLFileDelimit +
         Str.trim( titleHtml ) +
         MarkersAI.URLFileDelimit;

return result;
}



internal void setFromStr( string setFrom )
{
clear();

StrAr fields = new StrAr();
fields.split( setFrom, MarkersAI.URLFileDelimit );
int last = fields.getLast();
if( last < 1 )
  return;

url = Str.trim( fields.getStrAt( 0 ));
if( last < 2 )
  return;

linkText = Str.trim( fields.getStrAt( 1 ));
if( last < 3 )
  return;

fileName = Str.trim( fields.getStrAt( 2 ));
if( last < 4 )
  return;

string timeS = fields.getStrAt( 3 );
// mData.showStatus( "setFromDelim: " + timeS );

dateTime.setFromDelim( timeS );
if( last < 5 )
  return;

string anchors = fields.getStrAt( 4 );
if( Str.contains( anchors, "t" ))
  anchorsPulled = true;

if( last < 6 )
  return;

titleHtml = Str.trim( fields.getStrAt( 5 ));
}



internal int getYear()
{
return dateTime.getYear();
}

internal int getMonth()
{
return dateTime.getMonth();
}

internal int getDay()
{
return dateTime.getDay();
}



} // Class
