// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;



// namespace



public class UrlParse
{
private MainData mData;
private string fromURL = "";
private SBuilder rawTagBld;
private string linkText = "";
private string link = "";
private string baseDomain = "";
private string baseHttpS = "";
private StrAr badLinkArray;



private UrlParse()
{
}


internal UrlParse( MainData mDataToUse,
                   string useBaseURL )
{
mData = mDataToUse;
fromURL = useBaseURL;
rawTagBld = new SBuilder();
baseDomain = getDomainFromLink( fromURL );
baseHttpS = "https://" + baseDomain;
badLinkArray = new StrAr();
}



internal string getLink()
{
return link;
}


internal string getLinkText()
{
return linkText;
}


internal void addRawText( string inS )
{
rawTagBld.appendStr( inS );
}



internal void clear()
{
rawTagBld.clear();
linkText = "";
link = "";
// Leave fromURL alone.
}



internal bool processLink()
{
// mData.showStatus( " " );
// mData.showStatus( " " );

string text = rawTagBld.toString();
if( text.Length == 0 )
  return false;

if( !Str.contains( text, "href=" ))
  return false;

// An empty reference:
if( Str.contains( text, "href=\"\"" ))
  return false;

if( Str.contains( text, "onclick" ))
  return false;

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

// cleanUnicodeField();

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
// link = link.cleanUnicodeField().trim();

link = fixupLink( link );
if( link.Length == 0 )
  return false;

if( !GoodLink.isGoodLink( link ))
  return false;

if( !( Str.endsWith( fromURL, 
                      "foxnews.com/" ) ||
       Str.endsWith( fromURL,
                      "msnbc.com/" )))
  return false; // Don't want deeper levels.


mData.showStatus( " " );
mData.showStatus( "In UrlParse." );
mData.showStatus( "linkText: " + linkText );
mData.showStatus( "Link: " + link );
mData.showStatus( "fromURL: " + fromURL );
return true;
}



internal static string getDomainFromLink(
                                string linkIn )
{
if( linkIn.Length == 0 )
  return "";

StrAr linkParts = new StrAr();
linkParts.split( linkIn, '/' );
int last = linkParts.getLast();
for( int count = 0; count < last; count++ )
  {
  string part = linkParts.getStrAt( count );
  // Get the first thing that contains
  // a dot.  Like .com, .org, and so on.
  if( Str.contains( part, "." ))
    {
    return part;
    }
  }

return "";
}




private string fixupLink( string inS )
{
if( inS.Length < 2 )
  return "";

// if( base.endsWithChar( '/' ))
  // base = base.substring( 0, base.length()
//                                       - 2 );

string result = inS;

StrAr paramParts = new StrAr();
paramParts.split( result, '?' );
int lastParam = paramParts.getLast();
if( lastParam == 0 )
  {
  mData.showStatus(
             "URLParse: lastParam is zero." );
  return "";
  }

result = paramParts.getStrAt( 0 );
result = Str.trim( result );

// mData.showStatus( "top result: " + result );

if( Str.startsWith( result, "//" ))
  result = "https:" + result;

if( Str.startsWith( result, "/" ))
  result = baseDomain + result;

// mData.showStatus(
//           "In fixup result: " + result );

return result;
}



} // Class
