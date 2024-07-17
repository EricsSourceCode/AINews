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



// namespace


public class MainFormComp
{
private MainForm mForm;
internal Panel mainPanel;
internal TextBox mainTextBox;
internal TextBox searchTextBox;

// internal System.Windows.Forms.
//              MenuStrip menuStrip1;
// internal System.Windows.Forms.
//     ToolStripMenuItem fileToolStripMenuItem;
// internal System.Windows.Forms.
//    ToolStripMenuItem exitToolStripMenuItem;
// internal System.Windows.Forms.
//   ToolStripMenuItem testToolStripMenuItem;

internal System.Windows.Forms.Panel guiPanel;
internal System.Windows.Forms.Panel
                               mainTextPanel;
internal System.Windows.Forms.Panel
                               searchTextPanel;

internal System.Windows.Forms.PictureBox
                                guiPictureBox;


internal MainFormComp( MainForm UseForm )
{
mForm = UseForm;

InitializeComponents();
}



private void InitializeComponents()
{
mForm.SuspendLayout();

mainPanel = new System.Windows.Forms.Panel();
mainTextBox = new System.Windows.Forms.TextBox();
searchTextBox = new System.Windows.Forms.TextBox();

/*
menuStrip1 = new System.Windows.Forms.MenuStrip();
fileToolStripMenuItem = new System.Windows.
                      Forms.ToolStripMenuItem();
exitToolStripMenuItem = new System.Windows.
                      Forms.ToolStripMenuItem();
testToolStripMenuItem = new System.Windows.
                      Forms.ToolStripMenuItem();
*/

guiPanel = new System.Windows.Forms.Panel();
searchTextPanel = new System.Windows.Forms.Panel();
mainTextPanel = new System.Windows.Forms.Panel();

guiPictureBox = new System.Windows.
                           Forms.PictureBox();
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
                   Drawing.Size(372, 208);
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

/*
menuStrip1.ImageScalingSize = new
                    System.Drawing.Size(20, 20);
menuStrip1.Items.AddRange(new
         System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem // ,
            // this.userSetupToolStripMenuItem,
            // this.helpToolStripMenuItem
            });

menuStrip1.Location = new System.
                           Drawing.Point(0, 0);
menuStrip1.Name = "menuStrip1";
menuStrip1.Size = new System.Drawing.
                                Size(962, 40);
menuStrip1.TabIndex = 0;
menuStrip1.Text = "menuStrip1";

menuStrip1.Font = new System.Drawing.Font(
             "Microsoft Sans Serif", 36F,
             System.Drawing.FontStyle.Regular,
             System.Drawing.GraphicsUnit.Pixel,
             ((byte)(0)));

fileToolStripMenuItem.DropDownItems.AddRange(
  new System.Windows.Forms.ToolStripItem[] {
            testToolStripMenuItem,
            exitToolStripMenuItem
            });

fileToolStripMenuItem.Name =
                    "fileToolStripMenuItem";
fileToolStripMenuItem.Size = new
                    System.Drawing.Size(64, 36);
fileToolStripMenuItem.Text = "&File";


exitToolStripMenuItem.Name =
                      "exitToolStripMenuItem";
exitToolStripMenuItem.Size = new
                   System.Drawing.Size(433, 36);
exitToolStripMenuItem.Text = "E&xit";
exitToolStripMenuItem.Click += new
             System.EventHandler(
             exitToolStripMenuItem_Click);


testToolStripMenuItem.Name =
                      "testToolStripMenuItem";
testToolStripMenuItem.Size = new
                   System.Drawing.Size(433, 36);
testToolStripMenuItem.Text = "&Test";
testToolStripMenuItem.Click += new
             System.EventHandler(
             testToolStripMenuItem_Click );
*/


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

mainTextBox.Font = new System.Drawing.
                    Font( "Consolas", 40.0F,
                    System.Drawing.FontStyle.
                    Regular, System.Drawing.
                    GraphicsUnit.Pixel,
                    ((byte)(0)));


searchTextBox.Dock = System.Windows.Forms.
                          DockStyle.Fill;
searchTextBox.Location = new System.Drawing.
                         Point(0, 28);

// Make it fill the panel space.
searchTextBox.Multiline = true;


searchTextBox.Name = "SearchTextBox";
searchTextBox.ReadOnly = false;
searchTextBox.ScrollBars = System.Windows.Forms.
                            ScrollBars.None;
// searchTextBox.Size = new System.Drawing.
//                             Size( 5, 5 );
searchTextBox.TabIndex = 1;

searchTextBox.Font = new System.Drawing.
                    Font( "Consolas", 40.0F,
                    System.Drawing.FontStyle.
                    Regular, System.Drawing.
                    GraphicsUnit.Pixel,
                    ((byte)(0)));


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
                               Size(962, 68);
guiPanel.TabIndex = 2;

guiPanel.Controls.Add( guiPictureBox );



searchTextPanel.BackColor = System.Drawing.
                           Color.Red;
searchTextPanel.BorderStyle = System.Windows.
                   Forms.BorderStyle.FixedSingle;

searchTextPanel.Dock = System.Windows.Forms.
                              DockStyle.Top;
searchTextPanel.Location = new System.Drawing.
                              Point(0, 72);
searchTextPanel.Name = "searchTextPanel";
searchTextPanel.Size = new System.Drawing.
                               Size(62, 68);
searchTextPanel.TabIndex = 2;

searchTextPanel.Controls.Add( searchTextBox );



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
// menuStrip1.Dispose();
// fileToolStripMenuItem.Dispose();
// exitToolStripMenuItem.Dispose();

guiPanel.Dispose();
mainTextBox.Dispose();
searchTextBox.Dispose();
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
return searchTextBox.Text.Trim();
}



} // Class
