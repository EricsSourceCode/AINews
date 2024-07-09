// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;



// namespace



public class Paragraph
{
private MainData mData;
private string fromURL = "";
private SBuilder rawTagBld;

private string paraStr = "";

/*
private string linkText = "";
private string link = "";
private string baseDomain = "";
private string baseHttpS = "";
*/


private Paragraph()
{
}


internal Paragraph( MainData mDataToUse,
                   string useBaseURL )
{
mData = mDataToUse;
fromURL = useBaseURL;
rawTagBld = new SBuilder();
// baseDomain = getDomainFromLink( fromURL );
// baseHttpS = "https://" + baseDomain;
}



internal string getParaStr()
{
return paraStr;
}



internal void addRawText( string inS )
{
rawTagBld.appendStr( inS );
}



internal void clear()
{
rawTagBld.clear();
paraStr = "";
// Leave fromURL alone.
}



internal void processPara()
{
paraStr = rawTagBld.toString();
if( Str.contains( paraStr,
                  "class=\"copyright\"" ) ||
    Str.contains( paraStr,
               "class=\"subscribed hide\"" ) ||
    Str.contains( paraStr,
               "class=\"success hide\"" ) ||
    Str.contains( paraStr,
               "class=\"dek\"" ))
  {
  paraStr = "";
  return;
  }

/*
// mData.showStatus( " " );
// mData.showStatus( "Raw: " + text );

StrAr lineParts = new StrAr();
lineParts.split( text, '>' );
int lastPart = lineParts.getLast();
if( lastPart == 0 )
  {
  mData.showStatus(
     "The anchor tag doesn't have any parts." );
  mData.showStatus( "Text: " + text );
  return false;
  }

if( lastPart > 2 )
  {
  mData.showStatus( "Anchor tag lastPart > 2." );
  mData.showStatus( "text: " + text );
  return false;
  }

linkText = "";
if( lastPart >= 2 )
  linkText = lineParts.getStrAt( 1 );

linkText = Str.cleanAscii( linkText );
linkText = Str.trim( linkText );

string insideTag = lineParts.getStrAt( 0 );
// mData.showStatus( "insideTag: " + insideTag );

StrAr tagAttr = new StrAr();
tagAttr.split( insideTag, ' ' );
int lastAttr = tagAttr.getLast();
if( lastAttr == 0 )
  {
  mData.showStatus(
        "URLParse: lastAttr is zero." );
  return false;
  }

link = "";
for( int count = 0; count < lastAttr; count++ )
  {
  string attr = tagAttr.getStrAt( count );
  if( Str.contains( attr, "href=" ))
    {
    link = attr;
    break;
    }
  }

link = Str.replace( link, "href=", "" );
link = Str.replace( link, "\"", " " );
link = Str.replace( link, "\'", "" );
link = Str.cleanAscii( link );
link = Str.trim( link );


link = fixupLink( link );
if( link.Length == 0 )
  {
  mData.showStatus( "Link length is zero." );
  return false;
  }

// mData.showStatus( "Before goodlink." );
// mData.showStatus( "Link: " + link );

if( !GoodLink.isGoodLink( link ))
  {
  // mData.showStatus( "isGoodLink is false." );
  return false;
  }

// Get links from top layer only.
// if( !( Str.endsWith( fromURL,
//                      "foxnews.com/" ) ||
//       Str.endsWith( fromURL,
//                      "msnbc.com/" )))
//    {
//  mData.showStatus( "not top layer link." );
//  return false; // Don't want deeper levels.
// }

// mData.showStatus( " " );
// mData.showStatus( "In UrlParse." );
// mData.showStatus( "linkText: " + linkText );
// mData.showStatus( "Link: " + link );
// mData.showStatus( "fromURL: " + fromURL );
*/

}





} // Class
