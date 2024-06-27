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
mData.showStatus( " " );
mData.showStatus( " " );

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

string twoSlashes = "//";
string httpS = "https:";

if( Str.startsWith( result, twoSlashes ))
  result = httpS + result;

if( Str.startsWith( result, "/" ))
  result = baseDomain + result;

return result;
}


======
/*
  private void setupBadLinkArray()
    {
    badLinkArray = new StrArray();
    badLinkArray.append( new StrA( "/radio." ));
    badLinkArray.append( new StrA( "/video." ));

    badLinkArray.append( new StrA( "/privacy-policy" ));

    badLinkArray.append( new StrA( "obituary" ));

    badLinkArray.append( new StrA(
  ".foxnews.com/media/" ));

    badLinkArray.append( new StrA(
  ".foxbusiness.com/lifestyle/" ));

    badLinkArray.append( new StrA(
    ".foxnews.com/opinion/" ));

    badLinkArray.append( new StrA(
      "libertystreeteconomics.newyorkfed.org/" ));

    badLinkArray.append( new StrA(
   ".foxnews.com/video/" ));

    badLinkArray.append( new StrA(
  ".foxnews.com/lifestyle/" ));

    badLinkArray.append( new StrA(
  ".foxbusiness.com/entertainment/" ));


    badLinkArray.append( new StrA(
   ".foxnews.com/health/" ));

  // B.S. ads.
    badLinkArray.append( new StrA(
    ".foxbusiness.com/personal-finance/" ));




    badLinkArray.append( new StrA(
                     ".foxnews.com/entertainment/" ));

    badLinkArray.append( new StrA(
                           "www.foxnews.com/shows" ));
    badLinkArray.append( new StrA(
                   "www.foxnews.com/official-polls" ));
    badLinkArray.append( new StrA(
                 ".foxbusiness.com/closed-captioning/" ));
    badLinkArray.append( new StrA(
                            ".foxnews.com/about/rss/" ));
    badLinkArray.append( new StrA(
                      ".foxnews.com/category/media/" ));
    badLinkArray.append( new StrA(
                            "help.foxbusiness.com" ));
    badLinkArray.append( new StrA(
                          "press.foxbusiness.com/" ));
    badLinkArray.append( new StrA( "press.foxnews.com/" ));
    badLinkArray.append( new StrA( ".foxnews.com/rss/" ));

    badLinkArray.append( new StrA( ".foxnews.com/sports/" ));

    badLinkArray.append( new StrA(
                         ".foxnews.com/newsletters" ));
    badLinkArray.append( new StrA(
               ".foxnews.com/accessibility-statement" ));
    badLinkArray.append( new StrA(
                              ".foxnews.com/contact" ));
    badLinkArray.append( new StrA(
                             "nation.foxnews.com/" ));
    badLinkArray.append( new StrA(
                          ".foxnews.com/compliance" ));
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
    }



  private boolean hasValidDomain( StrA link )
    {
    if( link.containsStrA( new StrA(
        "/site/forms/" )))
      return false;

    if( link.containsStrA( new StrA(
        "/users/admin/" )))
      return false;

    if( link.containsStrA( new StrA(
        "/users/login/" )))
      return false;

    if( link.containsStrA( new StrA(
        "/users/signup/" )))
      return false;

    if( link.containsStrA( new StrA(
        "/classifieds/" )))
      return false;

    if( link.containsStrA( new StrA(
        "/place_an_ad/" )))
      return false;

    if( link.containsStrA( new StrA(
        "application/pdf" )))
      return false;

    if( link.containsStrA( new StrA(
      "coloradomtn.edu/download/" )))
      return false;

    if( link.endsWith( new StrA(
           ".pdf" )))
      return false;

    if( link.endsWith( new StrA(
           ".php" )))
      return false;

    if( link.containsStrA( new StrA(
           "&quot" )))
      return false;

    if( link.containsStrA( new StrA(
           "/../" )))
      return false;

    if( link.endsWith( new StrA(
           ".aspx" )))
      return false;

    if( link.containsStrA( new StrA(
           "leadvilleherald.com" )))
      return false;

    if( link.containsStrA( new StrA(
           "coloradomtn.edu/" )))
      return false;

    if( link.containsStrA( new StrA(
                       ".foxnews.com/" )))
      return true;

    if( link.containsStrA( new StrA(
                       ".msnbc.com/" )))
      return true;

    return false;
    }
*/



internal bool isBadLink( string link )
{
// wa.me is WhatsApp.

if( Str.contains( link, "https://wa.me/" ))
  return true;

if( Str.contains( link, "mailto:" ))
  return true;

/*
    if( link.containsStrA( new StrA( "ftp://" )))
      return true;

    if( link.containsStrA( new StrA( "sms:" )))
      return true;

    if( !hasValidDomain( link ))
      return true;

    if( link.endsWith( new StrA( ".pdf" )))
      return true;

    final int last = badLinkArray.length();
    for( int count = 0; count < last; count++ )
      {
      StrA text = badLinkArray.getStrAt( count );
      if( link.containsStrA( text ))
        return true;

      }
*/

return false;
}



} // Class
