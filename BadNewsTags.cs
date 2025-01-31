// Copyright Eric Chauvin 2025.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;



// namespace



public class BadNewsTags
{
private MainData mData;
private string tagText = "";
private StrAr tagsAr;



private BadNewsTags()
{
}


public BadNewsTags( MainData useMData )
{
mData = useMData;

tagsAr = new StrAr();

setupBadTags();
}



internal void setTagText( string inS )
{
tagText = inS;
}



internal string getTagText()
{
return tagText;
}



internal bool isBadTag()
{
int last = tagsAr.getLast();

for( int count = 0; count < last; count++ )
  {
  string toCheck = tagsAr.getStrAt( count );

  if( Str.contains( tagText, toCheck ))
    return true;

  }

return false;
}




private void setupBadTags()
{
tagsAr.append(
   "<span class=\"menu-list-item" );

tagsAr.append(
         "<div class=\"playlist-drawer" );

tagsAr.append(
         "<span class=\"playlist-drawer" );

tagsAr.append(
         "<h2 class=\"playlist-drawer" );

tagsAr.append(
    "<button class=\"video-details" );

tagsAr.append(
          "<span class=\"video-details" );

// No class= or anything.
tagsAr.append( "<span>" );

tagsAr.append(
   "<label class=\"search-label" );

tagsAr.append(
    "<title class=\"search_title" );

tagsAr.append(
    "<p class=\"menu-section-" );

tagsAr.append(
        "<title class=\"msnbc_logo" );

tagsAr.append(
         "<title class=\"nbc_news_logo" );

tagsAr.append( "qualtrics.com" );

tagsAr.append( ".nbcuniversal.com/" );

tagsAr.append( ".nbcuni.com/" );

tagsAr.append( "closed-captioning" );

tagsAr.append( "<h2 class=\"title" );

tagsAr.append( "<a aria-label=" );

tagsAr.append( "<option" ); 

tagsAr.append( "<label class=\"label" );

tagsAr.append( "<p class=\"disclaimer" );

tagsAr.append( "<a href=\"#\">" );

tagsAr.append( "<div class=\"video-container" );

tagsAr.append( "<a class=\"logo" );

tagsAr.append( "data-omtr-intcmp=" );

tagsAr.append( "<a href=\"#\" class=" );


}




} // Class
