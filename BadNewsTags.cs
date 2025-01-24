/*

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
       "data-testid=\"playlist-" );

tagsAr.append( "<span class=" +
            "\"video-details__duration\"" );

tagsAr.append( "<button class=" );

tagsAr.append( "<a aria-label=\"" );

tagsAr.append( "<p class=\"copyright\">" );

tagsAr.append( "<label class=\"search-label\"" );

tagsAr.append( "<span class=\"" +
                 "menu-list-item-title\">" );

tagsAr.append(
          "<title class=\"nbc_news_logo\">" );

tagsAr.append(
         "<title class=\"today_logo\">" );

tagsAr.append( "<a href=" +
         "\"https://cnbcrsh.qualtrics.com/" );

tagsAr.append( "<a href=\"https://" +
         "together.nbcuni.com/advertise/" );

tagsAr.append( "https://www.msnbc.com/" +
               "closed-captioning\">" );

tagsAr.append( "animated-ghost-button-" );

tagsAr.append(
     "/msnbc/msnbccom-digital-contacts-" );

tagsAr.append( "msnbc-info/contact-us-" );

tagsAr.append(
            "nbcnews.zendesk.com/hc/en-us" );

tagsAr.append( "www.nbcunicareers.com/" );

tagsAr.append( "www.msnbcstore.com/" );

tagsAr.append(
          "//lipperalpha.refinitiv.com/" );

tagsAr.append( "//www.factset.com/" );

tagsAr.append( "accessibility-statement" );

tagsAr.append( "//www.foxnews.com/contact" );

tagsAr.append( "//help.foxnews.com" );

tagsAr.append(
     ".foxnews.com/closed-captioning" );

tagsAr.append(
    "topnav_more_legal_your_privacy_choices" );

tagsAr.append(
           ".foxnews.com/privacy-policy" );

tagsAr.append(
    "topnav_more_legal_updated_terms_of_use" );

tagsAr.append(
         ".foxnews.com\" class=\"logo\">" );

tagsAr.append( "//www.foxnews.com/video/" );

tagsAr.append( "class=\"login\">" );

tagsAr.append(
             "class=\"js-focus-search\">" );

tagsAr.append( "class=\"js-menu-toggle\">" );

tagsAr.append( "intcmp=\"topnav_ai_10\">" );

tagsAr.append( "intcmp=\"topnav_video_9\">" );

tagsAr.append(
       "intcmp=\"topnav_lifestyle_8\">" );

tagsAr.append(
          "intcmp=\"topnav_sports_7\">" );

tagsAr.append(
        "intcmp=\"topnav_entertainment_6\">" );

tagsAr.append( "intcmp=\"topnav_media_5\">" );

tagsAr.append(
          "intcmp=\"topnav_opinion_4\">" );

tagsAr.append( "intcmp=\"topnav_world_3\">" );

tagsAr.append(
          "intcmp=\"topnav_politics_2\">" );

tagsAr.append( "intcmp=\"topnav_us_1\">" );

// Just <span> by itself.
tagsAr.append( "<span>" );

tagsAr.append(
           ".nbcuniversal.com/privacy/" );

tagsAr.append( "<div class=\"alert-banner\">" );

tagsAr.append(
    "<div class=\"playlist-drawer" );

tagsAr.append( "skip-link__button" );

tagsAr.append( "title class=\"msnbc_logo\">" );

tagsAr.append( "www.bam.org/" );

tagsAr.append(
  "www.msnbc.com/rachel-maddow-presents-ultra" );

tagsAr.append(
  "www.msnbc.com/2024-presidential-election" );

tagsAr.append(
   "www.msnbc.com/rachel-maddow-show" );

tagsAr.append(
  "www.msnbc.com/morning-joe" );

tagsAr.append(
   ".msnbc.com/donald-trump-trials-court-cases" );

tagsAr.append(
   "www.msnbc.com/jen-psaki" );

tagsAr.append(
    "www.msnbc.com/deadline-legal-blog" );

tagsAr.append(
        "www.msnbc.com/reidoutblog" );

tagsAr.append(
  ".msnbc.com/trump-trials-documents-library" );

tagsAr.append(
    "www.msnbc.com/opinion/columnists" );

tagsAr.append(
     "www.msnbc.com/films" );

tagsAr.append(
    "<li class=\"share-li share-li-cta\">" );

tagsAr.append(
   "<span class=\"menu-list-item-time\">" );

tagsAr.append(
  "<p class=\"menu-section-heading\">" );

tagsAr.append(
  "<title class=\"search_title\">" );

tagsAr.append(
   "<div class=\"playlist-drawer__" );

tagsAr.append(
  "<span data-testid=\"unibrow-text" );

tagsAr.append(
   "<li class=\"styles_shareThis" );

tagsAr.append(
   "<span class=\"styles_text" );

tagsAr.append(
   "<span class=\"video-details__by-line" );

tagsAr.append(
   "<a href=\"https://www.youtube.com/" );

tagsAr.append(
    "<a href=\"https://flipboard.com/" );

tagsAr.append(
     "<a href=\"https://www.instagram.com/" );

tagsAr.append(
   "<a href=\"https://twitter.com/" );

tagsAr.append(
   "<a href=\"https://www.facebook.com/" );

tagsAr.append(
   "<span class=\"time\">" );

tagsAr.append(
      "<p class=\"success hide\">" );

tagsAr.append(
     "<p class=\"subscribed hide\">" );

tagsAr.append( "href=\"#\"" );

tagsAr.append( "<a href=\"mailto:" );

tagsAr.append( "class=\"logo\"" );

tagsAr.append( "foxnews-com-rss-feeds" );

tagsAr.append( ".foxnews.com/newsletters" );

tagsAr.append( "class=\"article-date" );

tagsAr.append( ".foxnews.com/terms-of-use" );

tagsAr.append( "//www.linkedin.com/" );

tagsAr.append( "//foxnews.slack.com/" );

tagsAr.append( "//open.spotify.com/" );

tagsAr.append( "//www.iheart.com/" );

}



} // Class

*/
