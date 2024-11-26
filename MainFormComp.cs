// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;
// using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
// using System.Resources;
using System.Windows.Controls;
using System.Windows.Forms.Integration;



// namespace


public class MainFormComp
{
private MainForm mForm;

// ElementHost is needed to set the screen
// scale when the program first starts.
// Not later when the 3D window opens.

private ElementHost mainElementHost;


internal System.Windows.Forms.Panel mainPanel;
internal System.Windows.Forms.TextBox
                               mainTextBox;
internal System.Windows.Forms.TextBox
                               searchTextBox;
internal System.Windows.Forms.TextBox
                               daysBackTextBox;

internal System.Windows.Forms.Label searchLabel;
internal System.Windows.Forms.Panel guiPanel;
internal System.Windows.Forms.Panel
                               mainTextPanel;
internal System.Windows.Forms.Panel
                               searchTextPanel;

internal System.Windows.Forms.PictureBox
                                guiPictureBox;
internal System.Drawing.Font mainFont;





internal MainFormComp( MainForm UseForm )
{
mForm = UseForm;

InitializeComponents();
}



private void InitializeComponents()
{
mForm.SuspendLayout();

mainElementHost = new System.Windows.Forms.
                       Integration.ElementHost();

mainPanel = new System.Windows.Forms.Panel();
mainTextBox = new System.Windows.Forms.TextBox();
searchTextBox = new System.Windows.
                            Forms.TextBox();
daysBackTextBox = new System.Windows.
                            Forms.TextBox();
searchLabel = new System.Windows.Forms.Label();
guiPanel = new System.Windows.Forms.Panel();
searchTextPanel = new System.Windows.Forms.Panel();
mainTextPanel = new System.Windows.Forms.Panel();
guiPictureBox = new System.Windows.
                           Forms.PictureBox();

// Font mainFont = new Font(
//                   FontFamily.GenericSansSerif,
//                   36.0F,
//                   FontStyle.Regular, // Bold
//                   GraphicsUnit.Pixel );

mainFont = new System.Drawing.Font(
              "Consolas", 50.0F,
              System.Drawing.FontStyle.Regular,
              System.Drawing.GraphicsUnit.Pixel,
              ((byte)(0)) );


((System.ComponentModel.ISupportInitialize)
              (guiPictureBox)).BeginInit();

guiPictureBox.BorderStyle = System.Windows.
                 Forms.BorderStyle.FixedSingle;

guiPictureBox.Dock = System.Windows.
                         Forms.DockStyle.Fill;
guiPictureBox.Location = new System.
                           Drawing.Point(0, 0);
guiPictureBox.Name = "mainPictureBox";
guiPictureBox.Size = new System.
                   Drawing.Size(472, 308);
guiPictureBox.TabIndex = 0;
guiPictureBox.TabStop = false;


/*
guiPictureBox.MouseDoubleClick += new
                    System.Windows.Forms.
                    MouseEventHandler(
    mainDrawPanel_MouseDoubleClick );
*/

guiPictureBox.MouseDown += new System.
          Windows.Forms.MouseEventHandler(
          mForm.guiPictureBox_MouseDown );

/*
guiPictureBox.MouseMove += new System.
             Windows.Forms.MouseEventHandler(
          mainDrawPanel_MouseMove );
*/

((System.ComponentModel.ISupportInitialize)(
                    guiPictureBox)).EndInit();


mainPanel.BorderStyle = System.Windows.Forms.
                      BorderStyle.FixedSingle;
mainPanel.Dock = System.Windows.Forms.
                      DockStyle.Fill;
mainPanel.Location = new System.Drawing.
                      Point(0, 478);
mainPanel.Name = "MainPanel";
mainPanel.Size = new System.Drawing.Size(779, 36);
mainPanel.BackColor = System.Drawing.Color.Black;

mainPanel.SuspendLayout();


mainTextBox.Dock = System.Windows.Forms.
                          DockStyle.Fill;
mainTextBox.Location = new System.Drawing.
                         Point(0, 28);
mainTextBox.Multiline = true;
mainTextBox.Name = "MainTextBox";
mainTextBox.ReadOnly = false;
mainTextBox.ScrollBars = System.Windows.Forms.
                            ScrollBars.Vertical;
mainTextBox.Size = new System.Drawing.
                            Size(715, 383);
mainTextBox.TabIndex = 1;
mainTextBox.Font = mainFont;


searchTextBox.Dock = System.Windows.Forms.
                          DockStyle.None;
searchTextBox.Location = new System.Drawing.
                         Point( 204, 10 );
searchTextBox.Multiline = false;
searchTextBox.Name = "searchTextBox";
searchTextBox.ReadOnly = false;
searchTextBox.ScrollBars = System.Windows.Forms.
                            ScrollBars.None;
searchTextBox.Size = new System.Drawing.
                             Size( 350, 50 );
searchTextBox.TabIndex = 1;
searchTextBox.Font = mainFont;


daysBackTextBox.Dock = System.Windows.Forms.
                          DockStyle.None;
daysBackTextBox.Location = new System.Drawing.
                         Point( 570, 10 );
daysBackTextBox.Multiline = false;
daysBackTextBox.Name = "daysBackTextBox";
daysBackTextBox.ReadOnly = false;
daysBackTextBox.ScrollBars = System.Windows.Forms.
                            ScrollBars.None;
daysBackTextBox.Size = new System.Drawing.
                             Size( 140, 50 );
daysBackTextBox.TabIndex = 2;
daysBackTextBox.Font = mainFont;
daysBackTextBox.Text = "2.0";

searchLabel.AutoSize = true;
searchLabel.Font = mainFont;
searchLabel.Location = new System.Drawing.
                          Point( 5, 12 );
searchLabel.Name = "searchLabel";
// searchLabel.Size = new System.Drawing.
                         // Size(110, 20);
searchLabel.TabIndex = 1;
searchLabel.Text = "Search:";



guiPanel.BackColor = System.Drawing.
                           Color.Black;
guiPanel.BorderStyle = System.Windows.
                   Forms.BorderStyle.FixedSingle;

guiPanel.Dock = System.Windows.Forms.
                              DockStyle.Top;
guiPanel.Location = new System.Drawing.
                              Point(0, 72);
guiPanel.Name = "guiPanel";
guiPanel.Size = new System.Drawing.
                               Size(962, 90);
guiPanel.TabIndex = 2;

guiPanel.Controls.Add( guiPictureBox );



searchTextPanel.BackColor = System.Drawing.
                           Color.Black;
searchTextPanel.BorderStyle = System.Windows.
                   Forms.BorderStyle.FixedSingle;

searchTextPanel.Dock = System.Windows.Forms.
                              DockStyle.Top;
searchTextPanel.Location = new System.Drawing.
                              Point(0, 72);
searchTextPanel.Name = "searchTextPanel";
searchTextPanel.Size = new System.Drawing.
                               Size( 10, 90 );
searchTextPanel.TabIndex = 2;

searchTextPanel.Controls.Add(
                          daysBackTextBox );
searchTextPanel.Controls.Add( searchTextBox );
searchTextPanel.Controls.Add( searchLabel );


mainTextPanel.BackColor = System.Drawing.
                           Color.Green;
mainTextPanel.BorderStyle = System.Windows.
                   Forms.BorderStyle.FixedSingle;

mainTextPanel.Dock = System.Windows.Forms.
                              DockStyle.Fill;
mainTextPanel.Name = "MainTextPanel";
mainTextPanel.TabIndex = 3;

mForm.AutoScaleMode = System.Windows.Forms.
                           AutoScaleMode.None;

mForm.ClientSize = new System.Drawing.
                           Size(962, 505);

mainTextPanel.Controls.Add( mainTextBox );

// They are added in reverse order.
mainPanel.Controls.Add( mainTextPanel );
mainPanel.Controls.Add( searchTextPanel );
mainPanel.Controls.Add( guiPanel );
//   MainPanel.Controls.Add(this.ButtonPanel);
// mainPanel.Controls.Add( menuStrip1 );

mForm.Font = new System.Drawing.Font(
             "Microsoft Sans Serif", 36F,
             System.Drawing.FontStyle.Regular,
             System.Drawing.GraphicsUnit.Pixel,
             ((byte)(0)));

//   mForm.Icon = ((System.Drawing.Icon)
//        (resources.GetObject("$this.Icon")));

mForm.KeyPreview = true;
// mForm.MainMenuStrip = menuStrip1;
mForm.Name = "MainForm";
mForm.StartPosition = System.Windows.Forms.
               FormStartPosition.CenterScreen;
mForm.Text = "AI News";
mForm.WindowState = System.Windows.Forms.
                     FormWindowState.Maximized;

mForm.BackColor = System.Drawing.Color.Black;
// mForm.ForeColor = System.Drawing.Color.Black;


// menuStrip1.ResumeLayout(false);
// menuStrip1.PerformLayout();

// ButtonPanel.ResumeLayout(false);
// ButtonPanel.PerformLayout();

guiPanel.ResumeLayout(false);
guiPanel.PerformLayout();

mainPanel.ResumeLayout(false);
mainPanel.PerformLayout();

mForm.ResumeLayout(false);
mForm.PerformLayout();
}



internal void freeAll()
{
searchLabel.Dispose();
guiPictureBox.Dispose();
mainFont.Dispose();
guiPanel.Dispose();
mainTextBox.Dispose();
searchTextBox.Dispose();
daysBackTextBox.Dispose();
searchLabel.Dispose();
mainTextPanel.Dispose();
searchTextPanel.Dispose();
mainPanel.Dispose();
}



internal void showStatus( string status )
{
mainTextBox.AppendText( status + "\r\n" );
}


internal void clearStatus()
{
mainTextBox.Text = "";
}



/*
private void exitToolStripMenuItem_Click(
                     object sender, EventArgs e)
{
mForm.Close();
}
*/


/*
private void testToolStripMenuItem_Click(
                     object sender, EventArgs e)
{
mForm.mainData.test();
}
*/


internal string getSearchText()
{
return Str.toLower( Str.trim(
              searchTextBox.Text ));
}


internal string getDaysBackText()
{
return Str.trim( daysBackTextBox.Text );
}



} // Class
