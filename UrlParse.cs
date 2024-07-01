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
private string baseURL = "";
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
baseURL = useBaseURL;
rawTagBld = new SBuilder();
baseDomain = getDomainFromLink( baseURL );
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

if( isBadLink( link ))
  return false;

mData.showStatus( "linkText: " + linkText );
mData.showStatus( "Link: " + link );
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



private void setupBadLinkArray()
{
badLinkArray.append( "/radio." );

badLinkArray.append( "/video." );

badLinkArray.append( "/privacy-policy" );

badLinkArray.append( "obituary" );

badLinkArray.append( ".foxnews.com/media/" );

badLinkArray.append( 
              ".foxbusiness.com/lifestyle/" );

badLinkArray.append( ".foxnews.com/opinion/" );

badLinkArray.append( ".foxnews.com/video/" );

badLinkArray.append( 
               ".foxnews.com/lifestyle/" );

badLinkArray.append( 
        ".foxbusiness.com/entertainment/" );

badLinkArray.append( ".foxnews.com/health/" );

// B.S. ads.
badLinkArray.append( 
       ".foxbusiness.com/personal-finance/" );

badLinkArray.append( 
              ".foxnews.com/entertainment/" );

badLinkArray.append( "www.foxnews.com/shows" );

badLinkArray.append( 
             "www.foxnews.com/official-polls" );

badLinkArray.append( 
       ".foxbusiness.com/closed-captioning/" );

badLinkArray.append( 
                ".foxnews.com/about/rss/" ));

badLinkArray.append(
             ".foxnews.com/category/media/" );

badLinkArray.append( "help.foxbusiness.com" );

badLinkArray.append( "press.foxbusiness.com/" );

badLinkArray.append( "press.foxnews.com/" );

badLinkArray.append( ".foxnews.com/rss/" );

badLinkArray.append( ".foxnews.com/sports/" );

badLinkArray.append( 
            ".foxnews.com/newsletters" );

badLinkArray.append( 
     ".foxnews.com/accessibility-statement" );

badLinkArray.append( ".foxnews.com/contact" );

badLinkArray.append( "nation.foxnews.com/" );

badLinkArray.append( 
            ".foxnews.com/compliance" );

========
badLinkArray.append( new StrA(
                   ".foxbusiness.com/terms-of-use" ));
    badLinkArray.append( new StrA(
                             "facebook.com/" ));
    badLinkArray.append( new StrA( "twitter.com/" ));

    badLinkArray.append( new StrA(
                         "instagram.com/" ));

    badLinkArray.append( new StrA(
        "ballantinecommunicationsinc.com/" ));


    badLinkArray.append( new StrA(
          "4cornersjobs.com/" ));

    badLinkArray.append( new StrA(
                "dgomag.com" ));

    badLinkArray.append( new StrA(
       "/directoryplus.com" ));

    badLinkArray.append( new StrA(
    "durangoherald-co.newsmemory.com/" ));

    badLinkArray.append( new StrA(
        "/bcimedia.com" ));

    badLinkArray.append( new StrA(
         ".fourcornersexpos.com" ));

    badLinkArray.append( new StrA( ".foxnews.com/entertainment/" ));

    // badLinkArray.append( new StrA( "" ));
*/
}




private bool hasValidDomain( string link )
{
if( Str.contains( link, "/site/forms/" ))
  return false;

if( Str.contains( link, "/users/admin/" ))
  return false;

if( Str.contains( link, "/users/login/" ))
  return false;

if( Str.contains( link, "/users/signup/" ))
  return false;

if( Str.contains( link, "/classifieds/" ))
  return false;

if( Str.contains( link, "/place_an_ad/" ))
  return false;

if( Str.contains( link, "application/pdf" ))
  return false;

if( Str.contains( link, 
                "coloradomtn.edu/download/" ))
  return false;

if( Str.endsWith( link, ".pdf" ))
  return false;

if( Str.endsWith( link, ".php" ))
  return false;

if( Str.contains( link, "&quot" ))
  return false;

if( Str.contains( link, "/../" ))
  return false;

if( Str.endsWith( link, ".aspx" ))
  return false;

if( Str.contains( link, "leadvilleherald.com" ))
  return false;

if( Str.contains( link, "coloradomtn.edu/" ))
  return false;

if( Str.contains( link, ".foxnews.com/" ))
  return true;

if( Str.contains( link, ".msnbc.com/" ))
  return true;

return false;
}




internal bool isBadLink( string link )
{
// mData.showStatus( "isBadLink(): " + link );

// wa.me is WhatsApp.

if( Str.contains( link, "https://wa.me/" ))
  return true;

if( Str.contains( link, "mailto:" ))
  return true;

if( Str.contains( link, "ftp://" ))
  return true;

if( Str.contains( link, "sms:" ))
  return true;

if( !hasValidDomain( link ))
  return true;

if( Str.endsWith( link, ".pdf" ))
  return true;

/*
int last = badLinkArray.getLast();
for( int count = 0; count < last; count++ )
  {
  string text = badLinkArray.getStrAt( count );
  if( Str.contains( link, text ))
    return true;

  }
*/

return false;
}



} // Class
