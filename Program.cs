// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;


namespace AINews
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    Application.ThreadException += new ThreadExceptionEventHandler( MainForm.UIThreadException );
    Application.SetUnhandledExceptionMode( UnhandledExceptionMode.CatchException );

    // AppDomain.CurrentDomain.UnhandledException +=
       //  new UnhandledExceptionEventHandler( CurrentDomain_UnhandledException );

    Application.Run(new MainForm());
    }
  }
}
