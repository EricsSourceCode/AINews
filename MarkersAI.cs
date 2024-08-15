// Copyright Eric Chauvin 2024



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




// Basic Multilingual Plane
// C0 Controls and Basic Latin (Basic Latin)
//                                 (0000 007F)
// C1 Controls and Latin-1 Supplement (0080 00FF)
// Latin Extended-A (0100 017F)
// Latin Extended-B (0180 024F)
// IPA Extensions (0250 02AF)
// Spacing Modifier Letters (02B0 02FF)
// Combining Diacritical Marks (0300 036F)
// General Punctuation (2000 206F)
// Superscripts and Subscripts (2070 209F)
// Currency Symbols (20A0 20CF)
// Combining Diacritical Marks for Symbols
//                                (20D0 20FF)
// Letterlike Symbols (2100 214F)
// Number Forms (2150 218F)
// Arrows (2190 21FF)
// Mathematical Operators (2200 22FF)
// Box Drawing (2500 257F)
// Geometric Shapes (25A0 25FF)
// Miscellaneous Symbols (2600 26FF)
// Dingbats (2700 27BF)
// Miscellaneous Symbols and Arrows (2B00 2BFF)



using System;



// namespace



public class MarkersAI
{
// public const char Begin = '\x2700';
// static const Uint16 End = 0x2701;
//  static const Uint16 ErrorPoint = 0x2702;
public const char BeginCData = '\x2703';
public const char EndCData = '\x2704';
public const char BeginScript = '\x2705';
public const char EndScript = '\x2706';
public const char BeginHtmlComment = '\x2707';
public const char EndHtmlComment = '\x2708';
public const char BeginParagraphTag = '\x2709';
public const char EndParagraphTag = '\x270A';
public const char BeginAnchorTag = '\x270B';
public const char EndAnchorTag = '\x270C';
public const char BeginSpanTag = '\x270D';
public const char StoryDelim = '\x270E';
public const char StoryParagDelim = '\x270F';
public const char StoryListDelim = '\x2710';
public const char WordDelim = '\x2711';
public const char URLFileDelimit = '\x2712';



/*
I will be parsing Javascript:
  EscapedSingleQuote
  EscapedDoubleQuote
  TypeString
  TypeChar
  TypeNumber
  TypeIdentifier
  TypeLineNumber
  SlashStar
  StarSlash
  DoubleSlash
  TypeOperator
  EscapedSlash
  QuoteAsSingleCharacter
  TypeBoolean
  TypeCodeBlock
  ShowOddChar

*/


/*
  public static boolean isMarker( char testChar )
    {
    // Reserve these symbols for markers.
    // Miscellaneous Symbols (0x2600 to 0x26FF)
    // Dingbats (0x2700 to 0x27BF)
    // Miscellaneous Symbols and Arrows
    //                  (0x2B00 to 0x2BFF)

    int value = (int)testChar;
    if( (value >= 0x2600) && (value <= 0x2BFF))
      return true;

    return false;
    }



  public static StrA removeAllMarkers( StrA in )
    {
    if( in == null )
      return StrA.Empty;

    final int max = in.length();
    if( max == 0 )
      return StrA.Empty;

    StrABld sBuilder = new StrABld( in.length());
    for( int count = 0; count < max; count++ )
      {
      char testChar = in.charAt( count );
      if( isMarker( testChar ))
        continue;

      sBuilder.appendChar( testChar );
      }

    return sBuilder.toStrA();
    }



  public static int countMarkers( StrA in )
    {
    if( in == null )
      return 0;

    final int max = in.length();
    if( max == 0 )
      return 0;

    int howMany = 0;
    for( int count = 0; count < max; count++ )
      {
      char testChar = in.charAt( count );
      if( isMarker( testChar ))
        howMany++;

      }

    return howMany;
    }
*/


} // Class
