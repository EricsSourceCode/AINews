// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;
using System.Text;
using System.IO;



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
  

internal Configure( MainData seMainData,
                    string fileToUseName )
{
mData = UseMainData;
fileName = fileToUseName;
// UEncoding = new UTF8Encoding();
CDictionary = new Dictionary<string, string>();

readFromTextFile();
}



/*
  internal int GetCount()
    {
    return CDictionary.Count;
    }





  // Someone can edit the config text file with another editor
  // and then open it with this program.
  internal string GetString( string KeyWord, int Length )
    {
    KeyWord = KeyWord.ToLower().Trim();

    string Value;
    if( CDictionary.TryGetValue( KeyWord, out Value ))
      {
      Value = Utility.GetCleanAsciiString( Value, Length );
      return Value;
      }
    else
      return "";

    }




  internal void SetString( string KeyWord, string Value )
    {
    KeyWord = Utility.GetCleanAsciiString( KeyWord.ToLower().Trim(), 100 );

    if( KeyWord == "" )
      MessageBox.Show( "Can't add an empty keyword to the dictionary in Configure.cs.", MainForm.MessageBoxTitle, MessageBoxButtons.OK );

    // Value = Utility.GetCleanAsciiString( Value, Length );
    Value = Utility.GetCleanAsciiString( Value, MaxLength );
    CDictionary[KeyWord] = Value;
    }




  internal void ClearAllOptions()
    {
    CDictionary.Clear();

    SetString( "File Cleared", "Nada" );
    WriteToTextFile2();
    }




  private bool ReadFromTextFile()
    {
    CDictionary.Clear();

    if( !File.Exists( FileName ))
      return false;

    try
    {
    string Line;
    using( StreamReader SReader = new StreamReader( FileName  ))
      {
      while( SReader.Peek() >= 0 )
        {
        Line = SReader.ReadLine();
        if( Line == null )
          continue;

        Line = Line.Trim();
        if( Line == "" )
          continue;

        // if( Encrypt != null )
          // Line = Encrypt.DecryptString( Line );

        if( !Line.Contains( "\t" ))
          continue;

        string[] SplitString = Line.Split( new Char[] { '\t' } );
        if( SplitString.Length < 2 )
          continue;

        string KeyWord = SplitString[0].Trim();
        string Value = SplitString[1].Trim();
        KeyWord = Utility.GetCleanAsciiString( KeyWord, 100 );
        Value = Utility.GetCleanAsciiString( Value, MaxLength );

        if( KeyWord == "" )
          continue;

        CDictionary[KeyWord] = Value;
        // try
        // CDictionary.Add( KeyWord, Value );
        }
      }

    return true;

    }
    catch( Exception Except )
      {
      ECTime RightNow = new ECTime();
      RightNow.SetToNow();
      MForm.ShowRNMsgStatus( " " );
      MForm.ShowRNMsgStatus( RightNow.ToLocalDateString() + " at " + RightNow.ToLocalTimeString() );
      MForm.ShowRNMsgStatus( "Error: Could not write the configuration data to the file.\r\n" + Except.Message );
      MForm.ShowRNMsgStatus( " " );
      return false;
      }
    }





  internal bool WriteToTextFile2()
    {
    try
    {
    using( StreamWriter SWriter = new StreamWriter( FileName  ))
      {
      foreach( KeyValuePair<string, string> Kvp in CDictionary )
        {
        string Line = Kvp.Key + "\t" + Kvp.Value;
        // if( Encrypt != null )
          // Line = Encrypt.EncryptString( Line );

        SWriter.WriteLine( Line );
        }

      SWriter.WriteLine( " " );
      }

    return true;

    }
    catch( Exception Except )
      {
      ECTime RightNow = new ECTime();
      RightNow.SetToNow();
      MForm.ShowRNMsgStatus( " " );
      MForm.ShowRNMsgStatus( RightNow.ToLocalDateString() + " at " + RightNow.ToLocalTimeString() );
      MForm.ShowRNMsgStatus( "Error: Could not write the configuration data to the file.\r\n" + Except.Message );
      MForm.ShowRNMsgStatus( " " );
      return false;
      }
    }
*/




} // Class

