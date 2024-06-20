/*

// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;
using System.Text;
using System.IO;
using System.Collections.Generic;



// namespace


public class Configure
{
private MainData mData;
private Dictionary<string, string> CDictionary;
private string fileName = "";
// private UTF8Encoding UEncoding;
private const int maxLength = 1024 * 4;



private Configure()
{
}


internal Configure( MainData useMainData,
                    string fileToUseName )
{
mData = useMainData;
fileName = fileToUseName;
// UEncoding = new UTF8Encoding();
CDictionary = new Dictionary<string, string>();

readFromTextFile();
// mData.showStatus( "Config is: " + fileName );
}



internal int GetCount()
{
return CDictionary.Count;
}



internal string getString( string keyWord,
                           int length )
{
keyWord = keyWord.ToLower().Trim();

string value = "";
if( CDictionary.TryGetValue( keyWord, out value ))
  {
  // value = Utility.GetCleanAsciiString(
  //                Value, Length );
  return value;
  }

return "";
}



internal void setString( string keyWord,
                         string value,
                         bool writeFile )
{
keyWord = keyWord.ToLower().Trim();

if( keyWord == "" )
  return;
  // "Can't add an empty keyword to the
  //  dictionary in Configure.cs."

CDictionary[keyWord] = value;

if( writeFile )
  WriteToTextFile();

}



internal void clearAllOptions()
{
CDictionary.Clear();
setString( "KeyTest", "This and that.", true );
WriteToTextFile();
}



private bool readFromTextFile()
{
CDictionary.Clear();

if( !File.Exists( fileName ))
  return false;

try
{
string Line = "";
using( StreamReader SReader = new
                 StreamReader( fileName  ))
  {
  while( SReader.Peek() >= 0 )
    {
    Line = SReader.ReadLine();
    if( Line == null )
      continue;

    Line = Line.Trim();
    if( Line == "" )
      continue;

    if( !Line.Contains( "\t" ))
      continue;

    string[] SplitString = Line.Split(
                       new Char[] { '\t' } );
    if( SplitString.Length < 2 )
      continue;

    string KeyWord = SplitString[0].Trim();
    string Value = SplitString[1].Trim();
    // KeyWord = Utility.GetCleanAsciiString(
    //                          KeyWord, 100 );
    // Value = Utility.GetCleanAsciiString(
    //             Value, MaxLength );

    if( KeyWord == "" )
      continue;

    CDictionary[KeyWord] = Value;
    // try
    // CDictionary.Add( KeyWord, Value );
    }
  }

return true;
}
catch( Exception ) // Except )
  {
  // ECTime RightNow = new ECTime();
  // RightNow.SetToNow();
  // MForm.Show
  return false;
  }
}




internal bool WriteToTextFile()
{
try
{
using( StreamWriter SWriter = new
                     StreamWriter( fileName  ))
  {
  foreach( KeyValuePair<string, string> Kvp
                               in CDictionary )
    {
    string Line = Kvp.Key + "\t" + Kvp.Value;
    SWriter.WriteLine( Line );
    }

  SWriter.WriteLine( " " );
  }

return true;

}
catch( Exception ) // Except )
  {
  // ECTime RightNow = new ECTime();
  // RightNow.SetToNow();
  // MForm.Show
  return false;
  }
}





} // Class
*/

