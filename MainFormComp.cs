// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;



namespace AINews
{

public class MainFormComp
{
private MainForm MForm;
internal Panel MainPanel;
internal TextBox MainTextBox;
internal System.Windows.Forms.MenuStrip
                                   menuStrip1;
internal System.Windows.Forms.ToolStripMenuItem
                        fileToolStripMenuItem;
internal System.Windows.Forms.ToolStripMenuItem
                        exitToolStripMenuItem;

internal System.Windows.Forms.Panel UpperPanel;
internal System.Windows.Forms.Panel
                               MainTextPanel;



internal MainFormComp( MainForm UseForm )
{
MForm = UseForm;

InitializeComponents();
}



private void InitializeComponents()
{
MainPanel = new System.Windows.Forms.Panel();
MainTextBox = new System.Windows.Forms.TextBox();
menuStrip1 = new System.Windows.Forms.MenuStrip();
fileToolStripMenuItem = new System.Windows.
                      Forms.ToolStripMenuItem();
exitToolStripMenuItem = new System.Windows.
                      Forms.ToolStripMenuItem();
UpperPanel = new System.Windows.Forms.Panel();
MainTextPanel = new System.Windows.Forms.Panel();


MainPanel.BorderStyle = System.Windows.Forms.
                      BorderStyle.FixedSingle;
MainPanel.Dock = System.Windows.Forms.
                      DockStyle.Fill;
MainPanel.Location = new System.Drawing.
                      Point(0, 478);
MainPanel.Name = "MainPanel";
MainPanel.Size = new System.Drawing.Size(779, 36);
MainPanel.BackColor = System.Drawing.Color.Black;

menuStrip1 = new System.Windows.Forms.
                                  MenuStrip();
fileToolStripMenuItem = new System.
             Windows.Forms.ToolStripMenuItem();
exitToolStripMenuItem = new System.
             Windows.Forms.ToolStripMenuItem();

MainPanel.SuspendLayout();

menuStrip1.ImageScalingSize = new
                    System.Drawing.Size(20, 20);
menuStrip1.Items.AddRange(new
         System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem // ,
            // this.userSetupToolStripMenuItem,
            // this.viewToolStripMenuItem,
            // this.networkToolStripMenuItem,
            // this.graphPRMToolStripMenuItem,
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
             MForm.exitToolStripMenuItem_Click);


MainTextBox.Dock = System.Windows.Forms.
                          DockStyle.Fill;
MainTextBox.Location = new System.Drawing.
                         Point(0, 28);
MainTextBox.Multiline = true;
MainTextBox.Name = "MainTextBox";
MainTextBox.ReadOnly = false;
MainTextBox.ScrollBars = System.Windows.Forms.
                            ScrollBars.Vertical;
MainTextBox.Size = new System.Drawing.
                            Size(715, 383);
MainTextBox.TabIndex = 1;

MainTextBox.Font = new System.Drawing.
                    Font( "Consolas", 40.0F,
                    System.Drawing.FontStyle.
                    Regular, System.Drawing.
                    GraphicsUnit.Pixel,
                    ((byte)(0)));


UpperPanel.BackColor = System.Drawing.
                           Color.Red;
UpperPanel.BorderStyle = System.Windows.
                   Forms.BorderStyle.FixedSingle;

UpperPanel.Dock = System.Windows.Forms.
                              DockStyle.Top;
UpperPanel.Location = new System.Drawing.
                              Point(0, 72);
UpperPanel.Name = "UpperPanel";
UpperPanel.Size = new System.Drawing.
                               Size(962, 68);
UpperPanel.TabIndex = 2;

MainTextPanel.BackColor = System.Drawing.
                           Color.Green;
MainTextPanel.BorderStyle = System.Windows.
                   Forms.BorderStyle.FixedSingle;

MainTextPanel.Dock = System.Windows.Forms.
                              DockStyle.Fill;
// MainTextPanel.Location = new System.Drawing.
//                              Point(0, 72);
MainTextPanel.Name = "MainTextPanel";
// MainTextPanel.Size = new System.Drawing.
//                              Size(962, 168);
MainTextPanel.TabIndex = 3;




MForm.AutoScaleMode = System.Windows.Forms.
                           AutoScaleMode.None;
MForm.ClientSize = new System.Drawing.
                           Size(962, 505);

MainTextPanel.Controls.Add( MainTextBox );

// They are added in reverse order.
MainPanel.Controls.Add( MainTextPanel );
MainPanel.Controls.Add( UpperPanel );
//   MainPanel.Controls.Add(this.ButtonPanel);
MainPanel.Controls.Add( menuStrip1 );

MForm.Font = new System.Drawing.Font(
             "Microsoft Sans Serif", 36F,
             System.Drawing.FontStyle.Regular,
             System.Drawing.GraphicsUnit.Pixel,
             ((byte)(0)));

// MForm.ForeColor = System.Drawing.Color.Black;
// MForm.BackColor = System.Drawing.Color.Silver;

//   MForm.Icon = ((System.Drawing.Icon)
//        (resources.GetObject("$this.Icon")));

MForm.KeyPreview = true;
MForm.MainMenuStrip = menuStrip1;
MForm.Name = "MainForm";
MForm.StartPosition = System.Windows.Forms.
               FormStartPosition.CenterScreen;
MForm.Text = "AI News";
MForm.WindowState = System.Windows.Forms.
                     FormWindowState.Maximized;

/*
MForm.FormClosing += new System.Windows.
          Forms.FormClosingEventHandler(
          MForm.MainForm_FormClosing);
MForm.Shown += new System.EventHandler(
                         MForm.MainForm_Shown);
MForm.KeyDown += new System.Windows.Forms.
      KeyEventHandler(MForm.MainForm_KeyDown);
MForm.Resize += new System.EventHandler(
                     MForm.MainForm_Resize);
*/

menuStrip1.ResumeLayout(false);
menuStrip1.PerformLayout();

// ButtonPanel.ResumeLayout(false);
// ButtonPanel.PerformLayout();
UpperPanel.ResumeLayout(false);

MainPanel.ResumeLayout(false);
MainPanel.PerformLayout();
}



internal void FreeAll()
{
menuStrip1.Dispose();
fileToolStripMenuItem.Dispose();
exitToolStripMenuItem.Dispose();
UpperPanel.Dispose();
MainTextBox.Dispose();
MainTextPanel.Dispose();
MainPanel.Dispose();
}



internal void ShowStatus( string Status )
{
MainTextBox.AppendText( Status + "\r\n" );
}




} // Class

} // Namespace
