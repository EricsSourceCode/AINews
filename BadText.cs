// Copyright Eric Chauvin 2025.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;



// namespace



public class BadText
{
private MainData mData;
private StrAr textAr;



private BadText()
{
}


public BadText( MainData useMData )
{
mData = useMData;

textAr = new StrAr();

setupBadText();
}



internal bool isBadText( string textS )
{
int last = textAr.getLast();

for( int count = 0; count < last; count++ )
  {
  string toCheck = textAr.getStrAt( count );

  if( Str.contains( textS, toCheck ))
    return true;

  }

return false;
}




private void setupBadText()
{
textAr.append( 
      "alerts delivered to your inbox daily" );



/*
The hottest stories ripped from the headlines

By entering your email and clicking the

Privacy Policy

Terms of Use

agree to receive content and promotional

successfully subscribed to this newsletter!


Updated Terms of Use

New Privacy Policy

Your Privacy Choices

Closed Caption Policy


Accessibility Statement

This material may not be published, broadcast,

Quotes displayed in real-time or delayed

. Powered and implemented by

FactSet Digital Solutions


Legal Statement

Mutual Fund and ETF data provided by

Refinitiv Lipper

*/
}



} // Class

