// private TextBox MainTextBox;


// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;
// using System.Collections.Generic;
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

internal System.Windows.Forms.MenuStrip
                                   menuStrip1;
internal System.Windows.Forms.ToolStripMenuItem
                        fileToolStripMenuItem;

/*
  internal System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem userSetupToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem saveGraphToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem saveScreenToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem printGraphToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem printScreenToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem configureGeigerPortToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem identifyMonitoringStationToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem configureAlertsToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem otherOptionsToolStripMenuItem;
  internal System.Windows.Forms.Panel ButtonPanel;
  internal System.Windows.Forms.Button SaveImageButton;
*/

  internal System.Windows.Forms.Panel UpperPanel;
  internal System.Windows.Forms.Panel 
                               MainTextPanel;


/*
  internal System.Windows.Forms.GroupBox CountsGroupBox;
  internal System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
  internal System.Windows.Forms.Panel GraphPanel;
  internal System.Windows.Forms.ToolStripMenuItem spreadsheetToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem goToWebSiteToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem sendAlertsByTextToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem helpNarrativeToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem troubleshootNetworkToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem licenseAgreementToolStripMenuItem;
  internal System.Windows.Forms.GroupBox AlertLevelGroupBox;
  internal System.Windows.Forms.GroupBox TimeGroupBox;
  internal System.Windows.Forms.Label CurrentCPMLabel;
  internal System.Windows.Forms.NumericUpDown AlertNumericUpDown;
  internal System.Windows.Forms.Button AdvancedAlertButton;
  internal System.Windows.Forms.Label CurrentCPMValLabel;
  internal System.Windows.Forms.Label LastCPMLabel;
  internal System.Windows.Forms.Label LastCPMValLabel;
  internal System.Windows.Forms.ToolStripMenuItem showUnicodeTextToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem convertMapDataFilesToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem troubleshootGeigerCounterToolStripMenuItem;
  internal System.Windows.Forms.Label MinCPMValLabel;
  internal System.Windows.Forms.Label MinimumCPMLabel;
  internal System.Windows.Forms.Label AvgCPMValLabel;
  internal System.Windows.Forms.Label AvgCPMLabel;
  internal System.Windows.Forms.Label TotalCPMValLabel;
  internal System.Windows.Forms.Label TotalCPMLabel;
  internal System.Windows.Forms.Label MaxCPMValLabel;
  internal System.Windows.Forms.Label MaximumCPMLabel;
  internal System.Windows.Forms.Label ElapsedTimeLabel;
  internal System.Windows.Forms.Label EndingTimeLabel;
  internal System.Windows.Forms.Label BeginningTimeLabel;
  internal System.Windows.Forms.Label ElapsedMinValLabel;
  internal System.Windows.Forms.Label ElapsedDayValLabel;
  internal System.Windows.Forms.Label EndDayValLabel;
  internal System.Windows.Forms.Label BeginDayValLabel;
  internal System.Windows.Forms.Label DayLabel;
  internal System.Windows.Forms.Label ElapsedMinutesLabel;
  internal System.Windows.Forms.Label BeginTimeHourValLabel;
  internal System.Windows.Forms.Label HourLabel;
  internal System.Windows.Forms.Label ElapsedTimeHourValLabel;
  internal System.Windows.Forms.Label EndTimeHourValLabel;
  internal System.Windows.Forms.Timer UpdateDisplayTimer;
  internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
  internal System.Windows.Forms.Button BlinkLEDOffButton;
  internal System.Windows.Forms.Button BlinkLEDOnButton;
  internal System.Windows.Forms.Timer LEDBlinkTimer;
  internal System.Windows.Forms.Timer SingleInstanceTimer;
  internal System.Windows.Forms.Button GraphOptionsButton;
  internal System.Windows.Forms.NotifyIcon notifyIcon1;
  internal System.Windows.Forms.Timer TwoMinuteGuideTimer;
  internal System.Windows.Forms.Timer TaskTrayTimer;
  internal System.Windows.Forms.Timer StartAlertsTimer;
  internal System.Windows.Forms.ToolStripMenuItem troubleshootTextAlertsToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
  internal System.Windows.Forms.PrintDialog printDialog1;
  internal System.Drawing.Printing.PrintDocument ScreenPrintDocument;
  internal System.Windows.Forms.Timer ShowTipsTimer;
  internal System.Windows.Forms.ToolStripMenuItem showOperatingSystemToolStripMenuItem;
  internal System.Windows.Forms.Timer MapDataTimer;
  internal System.Windows.Forms.Button MainMapButton;
  internal System.Windows.Forms.ToolStripMenuItem showMainMapToolStripMenuItem1;
  internal System.Windows.Forms.Timer CheckChatTimer;
  internal System.Windows.Forms.PictureBox NuclearPictureBox;
  internal System.Windows.Forms.ToolStripMenuItem closeAllRemoteGraphsToolStripMenuItem;
  internal System.Windows.Forms.Button ShowSpreadSheetButton;
  internal System.Windows.Forms.Button ViewReportButton;
  internal System.Windows.Forms.Button GoToWebSiteButton;
  internal System.Windows.Forms.Button AHelpButton;
  internal System.Windows.Forms.ToolTip MainToolTip;
  internal System.Windows.Forms.Button TestAlertSoundButton;
  internal System.Windows.Forms.ToolStripMenuItem openInfoFilesToolStripMenuItem;
  internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
  internal System.Windows.Forms.Button TextAlertsButton;
  internal System.Windows.Forms.Button IDButton;
  internal System.Windows.Forms.Label TotalAverageValLabel;
  internal System.Windows.Forms.Label TotalAverageLabel;
  internal System.Windows.Forms.Button ViewGraphsButton;
  internal System.Windows.Forms.ContextMenuStrip AlertContextMenuStrip;
  internal System.Windows.Forms.ToolStripMenuItem testAlertSoundToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem testRemoteAlertSoundToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem viewTrendingGraphsToolStripMenuItem;
  internal System.Windows.Forms.Button PrintButton;
  internal System.Windows.Forms.Label EndTimeAMPMValLabel;
  internal System.Windows.Forms.Label BeginTimeAMPMValLabel;
  internal System.Windows.Forms.Label AvgCPM1HrValLabel;
  internal System.Windows.Forms.Label AvgCPM1HrLabel;
  internal System.Windows.Forms.Label AMPMLabel;
  internal System.Windows.Forms.GroupBox SoundsGroupBox;
  internal System.Windows.Forms.CheckBox PlaySoundsCheckBox;
  internal System.Windows.Forms.RadioButton SoundClickRadioButton;
  internal System.Windows.Forms.RadioButton SoundBeepRadioButton;
  internal System.Windows.Forms.Label SetCPMLabel;
  internal System.Windows.Forms.Label SetMultLabel;
  internal System.Windows.Forms.NumericUpDown AlertMultNumericUpDown;
  internal System.Windows.Forms.ToolStripMenuItem configureGraphUploadingToolStripMenuItem;
  internal System.Windows.Forms.PictureBox MapLegendPictureBox;
  internal System.Windows.Forms.ToolStripMenuItem didYouKnowToolStripMenuItem;
  internal System.Windows.Forms.Timer ShowMainMapTimer;
  internal System.Windows.Forms.Timer GeneralCheckTimer;
  internal System.Windows.Forms.ToolStripMenuItem troubleshootFTPToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem graphPRMToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem readLogDataToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem showSecondMapToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem seeSubscriptionLevelToolStripMenuItem;
  internal System.Windows.Forms.Label LesserOfLabel;
  internal System.Windows.Forms.ToolStripMenuItem convertOldGGDataFilesToolStripMenuItem;
  internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
  internal System.Windows.Forms.ToolStripMenuItem alertLogToolStripMenuItem;
  internal System.Windows.Forms.Timer MessagesCheckTimer;
  internal System.Windows.Forms.Panel ActiveGraphPanel;
  internal System.Windows.Forms.Panel ActiveGraphDrawPanel;
  internal System.Windows.Forms.ToolStripMenuItem setGraphOptionsToolStripMenuItem;
  internal System.Windows.Forms.Panel ActiveGraphClosePanel;
  internal System.Windows.Forms.Button DisableSendCPMButton;
  internal System.Windows.Forms.ToolStripMenuItem pauseSendCPMDataToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem testRSAKeysToolStripMenuItem;
  internal System.Windows.Forms.CheckBox EnableAlertPopupCheckBox;
  internal System.Windows.Forms.CheckBox SeriesAlertLevelCheckBox;
  internal System.Windows.Forms.ToolStripMenuItem registerGeigerGraphToolStripMenuItem;
  internal System.Windows.Forms.Label DemoModeLabel;
  internal System.Windows.Forms.ToolStripMenuItem convertAverageDataToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem troubleshootDataCablesToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem compressHexFilesToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem wiGiSettingsToolStripMenuItem;
  internal System.Windows.Forms.Button UniversalChatButton;
  internal System.Windows.Forms.ToolStripMenuItem liveChatOverTheRadiationNetworkToolStripMenuItem;
  internal System.Windows.Forms.PictureBox GraphPictureBox1;
  internal System.Windows.Forms.PictureBox ActiveGraphPictureBox;
  internal System.Windows.Forms.Button ChatPopupButton;
  internal System.Windows.Forms.Timer RegistrationTimer;
  internal System.Windows.Forms.ToolStripMenuItem graphWiGiToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem graphInspectorUSBToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem historicalGraphToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem configureCOMPortToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem historicalSpreadsheetToolStripMenuItem;
  internal System.Windows.Forms.ContextMenuStrip SpreadsheetContextMenuStrip;
  internal System.Windows.Forms.ToolStripMenuItem viewCurrentSpreadsheetToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem viewHistoricalSpreadsheetToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem getEPARadNetDataToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem ePARadNetGraphToolStripMenuItem;
  internal System.Windows.Forms.Label TestVersionLabel;
  internal System.Windows.Forms.ToolStripMenuItem convertToDailyFilesToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem instalFTDIDriverToolStripMenuItem;
  internal System.Windows.Forms.Button HistoricalGraphButton;
  internal System.Windows.Forms.Timer GG4ImportTimer;
  internal System.Windows.Forms.ToolStripMenuItem privacyPolicyToolStripMenuItem;
  internal System.Windows.Forms.ToolStripMenuItem testHTTPToolStripMenuItem;

*/



  internal MainFormComp( MainForm UseForm )
    {
    MForm = UseForm;

    InitializeComponents();

    // writeButtonImageToResx();
    }



/*
  private void writeButtonImageToResx()
    {
    // Use this to write a resource file, then
    // copy the image in that resx in to the
    // MainForm.resx file.

   Bitmap bmp = new Bitmap(
                      "\\Temp\\ToWrite.bmp" );

    using( ResXResourceWriter resx = new
                       ResXResourceWriter(
               "\\Temp\\TempResource.resx"))
      {
      resx.AddResource( "TextAlertButton.Image",
                         bmp );
      }

    }
*/



private void InitializeComponents()
{
MainPanel = new Panel();
MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
MainPanel.Location = new System.Drawing.Point(0, 478);
MainPanel.Name = "MainPanel";
MainPanel.Size = new System.Drawing.Size(779, 36);

/*
    System.ComponentModel.
           ComponentResourceManager resources =
                        new System.ComponentModel.
                         ComponentResourceManager(
                             typeof(MainForm));

// For the IDButton.
// This is telling it to use a separate IDresources
// to get resources in the StationGraphForm's
// resource file.

    System.ComponentModel.
           ComponentResourceManager IDresources =
                        new System.ComponentModel.
                         ComponentResourceManager(
                 typeof(StationGraphForm));


     // this.components = new System.ComponentModel.
     //                                  Container();
     //System.ComponentModel.
     //    ComponentResourceManager resources =
     //    new System.ComponentModel.
     //   ComponentResourceManager(typeof(MainForm));
*/



this.menuStrip1 = new System.Windows.Forms.
                                    MenuStrip();
this.fileToolStripMenuItem = new System.
                Windows.Forms.ToolStripMenuItem();


/*
      this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.convertOldGGDataFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.convertAverageDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.getEPARadNetDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.convertMapDataFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.testRSAKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.compressHexFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.convertToDailyFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.testHTTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.userSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.identifyMonitoringStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.configureGeigerPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.configureCOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.configureAlertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.setGraphOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.configureGraphUploadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.otherOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.wiGiSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.spreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.historicalSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.historicalGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showMainMapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.showSecondMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.alertLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.goToWebSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewTrendingGraphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeAllRemoteGraphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ePARadNetGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.liveChatOverTheRadiationNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sendAlertsByTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pauseSendCPMDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.graphPRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.graphWiGiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.readLogDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.graphInspectorUSBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpNarrativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.didYouKnowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openInfoFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.troubleshootGeigerCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.troubleshootDataCablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.instalFTDIDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.troubleshootTextAlertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.troubleshootFTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.troubleshootNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.licenseAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.privacyPolicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.registerGeigerGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showUnicodeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.seeSubscriptionLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showOperatingSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ButtonPanel = new System.Windows.Forms.Panel();
      this.HistoricalGraphButton = new System.Windows.Forms.Button();
      this.TestVersionLabel = new System.Windows.Forms.Label();
      this.UniversalChatButton = new System.Windows.Forms.Button();
      this.DemoModeLabel = new System.Windows.Forms.Label();
      this.DisableSendCPMButton = new System.Windows.Forms.Button();
      this.PrintButton = new System.Windows.Forms.Button();
      this.ViewGraphsButton = new System.Windows.Forms.Button();
      this.TextAlertsButton = new System.Windows.Forms.Button();
      this.IDButton = new System.Windows.Forms.Button();
      this.TestAlertSoundButton = new System.Windows.Forms.Button();
      this.AHelpButton = new System.Windows.Forms.Button();
      this.GoToWebSiteButton = new System.Windows.Forms.Button();
      this.ViewReportButton = new System.Windows.Forms.Button();
      this.ShowSpreadSheetButton = new System.Windows.Forms.Button();
      this.MainMapButton = new System.Windows.Forms.Button();
      this.SaveImageButton = new System.Windows.Forms.Button();
      this.UpperPanel = new System.Windows.Forms.Panel();
      this.SoundsGroupBox = new System.Windows.Forms.GroupBox();
      this.SoundClickRadioButton = new System.Windows.Forms.RadioButton();
      this.SoundBeepRadioButton = new System.Windows.Forms.RadioButton();
      this.PlaySoundsCheckBox = new System.Windows.Forms.CheckBox();
      this.GraphOptionsButton = new System.Windows.Forms.Button();
      this.BlinkLEDOffButton = new System.Windows.Forms.Button();
      this.BlinkLEDOnButton = new System.Windows.Forms.Button();
      this.AlertLevelGroupBox = new System.Windows.Forms.GroupBox();
      this.EnableAlertPopupCheckBox = new System.Windows.Forms.CheckBox();
      this.SeriesAlertLevelCheckBox = new System.Windows.Forms.CheckBox();
      this.LesserOfLabel = new System.Windows.Forms.Label();
      this.AlertMultNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.SetMultLabel = new System.Windows.Forms.Label();
      this.SetCPMLabel = new System.Windows.Forms.Label();
      this.AdvancedAlertButton = new System.Windows.Forms.Button();
      this.AlertNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.TimeGroupBox = new System.Windows.Forms.GroupBox();
      this.AMPMLabel = new System.Windows.Forms.Label();
      this.EndTimeAMPMValLabel = new System.Windows.Forms.Label();
      this.BeginTimeAMPMValLabel = new System.Windows.Forms.Label();
      this.ElapsedTimeHourValLabel = new System.Windows.Forms.Label();
      this.EndTimeHourValLabel = new System.Windows.Forms.Label();
      this.BeginTimeHourValLabel = new System.Windows.Forms.Label();
      this.HourLabel = new System.Windows.Forms.Label();
      this.ElapsedMinValLabel = new System.Windows.Forms.Label();
      this.ElapsedDayValLabel = new System.Windows.Forms.Label();
      this.EndDayValLabel = new System.Windows.Forms.Label();
      this.BeginDayValLabel = new System.Windows.Forms.Label();
      this.DayLabel = new System.Windows.Forms.Label();
      this.ElapsedMinutesLabel = new System.Windows.Forms.Label();
      this.ElapsedTimeLabel = new System.Windows.Forms.Label();
      this.EndingTimeLabel = new System.Windows.Forms.Label();
      this.BeginningTimeLabel = new System.Windows.Forms.Label();
      this.CountsGroupBox = new System.Windows.Forms.GroupBox();
      this.AvgCPM1HrValLabel = new System.Windows.Forms.Label();
      this.AvgCPM1HrLabel = new System.Windows.Forms.Label();
      this.TotalAverageValLabel = new System.Windows.Forms.Label();
      this.TotalAverageLabel = new System.Windows.Forms.Label();
      this.TotalCPMValLabel = new System.Windows.Forms.Label();
      this.TotalCPMLabel = new System.Windows.Forms.Label();
      this.MaxCPMValLabel = new System.Windows.Forms.Label();
      this.MaximumCPMLabel = new System.Windows.Forms.Label();
      this.MinCPMValLabel = new System.Windows.Forms.Label();
      this.MinimumCPMLabel = new System.Windows.Forms.Label();
      this.AvgCPMValLabel = new System.Windows.Forms.Label();
      this.AvgCPMLabel = new System.Windows.Forms.Label();
      this.LastCPMLabel = new System.Windows.Forms.Label();
      this.LastCPMValLabel = new System.Windows.Forms.Label();
      this.CurrentCPMValLabel = new System.Windows.Forms.Label();
      this.CurrentCPMLabel = new System.Windows.Forms.Label();
      this.GraphPanel = new System.Windows.Forms.Panel();
      this.ChatPopupButton = new System.Windows.Forms.Button();
      this.ActiveGraphPanel = new System.Windows.Forms.Panel();
      this.ActiveGraphDrawPanel = new System.Windows.Forms.Panel();
      this.ActiveGraphClosePanel = new System.Windows.Forms.Panel();
      this.ActiveGraphPictureBox = new System.Windows.Forms.PictureBox();
      this.MapLegendPictureBox = new System.Windows.Forms.PictureBox();
      this.NuclearPictureBox = new System.Windows.Forms.PictureBox();
      this.GraphPictureBox1 = new System.Windows.Forms.PictureBox();
      this.UpdateDisplayTimer = new System.Windows.Forms.Timer();
      this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.LEDBlinkTimer = new System.Windows.Forms.Timer();
      this.SingleInstanceTimer = new System.Windows.Forms.Timer();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon();
      this.TwoMinuteGuideTimer = new System.Windows.Forms.Timer();
      this.TaskTrayTimer = new System.Windows.Forms.Timer();
      this.StartAlertsTimer = new System.Windows.Forms.Timer();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      this.ScreenPrintDocument = new System.Drawing.Printing.PrintDocument();
      this.ShowTipsTimer = new System.Windows.Forms.Timer();
      this.MapDataTimer = new System.Windows.Forms.Timer();
      this.CheckChatTimer = new System.Windows.Forms.Timer();
      this.MainToolTip = new System.Windows.Forms.ToolTip();
      this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.AlertContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
      this.testAlertSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.testRemoteAlertSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ShowMainMapTimer = new System.Windows.Forms.Timer();
      this.GeneralCheckTimer = new System.Windows.Forms.Timer();
      this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.MessagesCheckTimer = new System.Windows.Forms.Timer();
      this.RegistrationTimer = new System.Windows.Forms.Timer();
      this.SpreadsheetContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
      this.viewCurrentSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewHistoricalSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.GG4ImportTimer = new System.Windows.Forms.Timer();
      this.menuStrip1.SuspendLayout();
      this.ButtonPanel.SuspendLayout();
      this.UpperPanel.SuspendLayout();
      this.SoundsGroupBox.SuspendLayout();
      this.AlertLevelGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AlertMultNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.AlertNumericUpDown)).BeginInit();
      this.TimeGroupBox.SuspendLayout();
      this.CountsGroupBox.SuspendLayout();
      this.GraphPanel.SuspendLayout();
      this.ActiveGraphPanel.SuspendLayout();
      this.ActiveGraphDrawPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ActiveGraphPictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.MapLegendPictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NuclearPictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox1)).BeginInit();
      this.AlertContextMenuStrip.SuspendLayout();
      this.SpreadsheetContextMenuStrip.SuspendLayout();

*/


MainPanel.SuspendLayout();

this.menuStrip1.ImageScalingSize = new 
                    System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new 
         System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem // ,
            // this.userSetupToolStripMenuItem,
            // this.viewToolStripMenuItem,
            // this.networkToolStripMenuItem,
            // this.graphPRMToolStripMenuItem,
            // this.helpToolStripMenuItem
            });
this.menuStrip1.Location = new System.
                           Drawing.Point(0, 0);
this.menuStrip1.Name = "menuStrip1";
this.menuStrip1.Size = new System.Drawing.
                                Size(962, 40);
this.menuStrip1.TabIndex = 0;
this.menuStrip1.Text = "menuStrip1";

/*
this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
           this.clearDataToolStripMenuItem,
            this.saveGraphToolStripMenuItem,
            this.saveScreenToolStripMenuItem,
            this.printGraphToolStripMenuItem,
            this.printScreenToolStripMenuItem,
            this.convertOldGGDataFilesToolStripMenuItem,
            this.convertAverageDataToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.getEPARadNetDataToolStripMenuItem,
            this.convertMapDataFilesToolStripMenuItem,
            this.testRSAKeysToolStripMenuItem,
            this.compressHexFilesToolStripMenuItem,
            this.convertToDailyFilesToolStripMenuItem,
            this.testHTTPToolStripMenuItem,
            });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
      this.fileToolStripMenuItem.Text = "&File";
*/



/*
      //
      // clearDataToolStripMenuItem
      //
      this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
      this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.clearDataToolStripMenuItem.Text = "&Clear Data";
      this.clearDataToolStripMenuItem.Click += new System.EventHandler(MForm.clearDataToolStripMenuItem_Click);
      //
      // saveGraphToolStripMenuItem
      //
      this.saveGraphToolStripMenuItem.Name = "saveGraphToolStripMenuItem";
      this.saveGraphToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.saveGraphToolStripMenuItem.Text = "Save &Graph";
      this.saveGraphToolStripMenuItem.Click += new System.EventHandler(MForm.saveGraphToolStripMenuItem_Click);
      //
      // saveScreenToolStripMenuItem
      //
      this.saveScreenToolStripMenuItem.Name = "saveScreenToolStripMenuItem";
      this.saveScreenToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.saveScreenToolStripMenuItem.Text = "Save Scree&n";
      this.saveScreenToolStripMenuItem.Click += new System.EventHandler(MForm.saveScreenToolStripMenuItem_Click);
      //
      // printGraphToolStripMenuItem
      //
      this.printGraphToolStripMenuItem.Name = "printGraphToolStripMenuItem";
      this.printGraphToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.printGraphToolStripMenuItem.Text = "&Print Graph";
      this.printGraphToolStripMenuItem.Click += new System.EventHandler(MForm.printGraphToolStripMenuItem_Click);
      //
      // printScreenToolStripMenuItem
      //
      this.printScreenToolStripMenuItem.Name = "printScreenToolStripMenuItem";
      this.printScreenToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.printScreenToolStripMenuItem.Text = "Prin&t Screen";
      this.printScreenToolStripMenuItem.Click += new System.EventHandler(MForm.printScreenToolStripMenuItem_Click);
      //
      // convertOldGGDataFilesToolStripMenuItem
      //
      this.convertOldGGDataFilesToolStripMenuItem.Name = "convertOldGGDataFilesToolStripMenuItem";
      this.convertOldGGDataFilesToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.convertOldGGDataFilesToolStripMenuItem.Text = "&Import Old GG4 Data";
      this.convertOldGGDataFilesToolStripMenuItem.Click += new System.EventHandler(MForm.convertOldGGDataFilesToolStripMenuItem_Click);
      //
      // convertAverageDataToolStripMenuItem
      //
      this.convertAverageDataToolStripMenuItem.Name = "convertAverageDataToolStripMenuItem";
      this.convertAverageDataToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.convertAverageDataToolStripMenuItem.Text = "Import Old GG5 Average Data";
      this.convertAverageDataToolStripMenuItem.Click += new System.EventHandler(MForm.convertAverageDataToolStripMenuItem_Click);
      //
      // exitToolStripMenuItem
      //
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(MForm.exitToolStripMenuItem_Click);
      //
      // getEPARadNetDataToolStripMenuItem
      //
      this.getEPARadNetDataToolStripMenuItem.Name = "getEPARadNetDataToolStripMenuItem";
      this.getEPARadNetDataToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.getEPARadNetDataToolStripMenuItem.Text = "Get EPA Rad Net Data";
      this.getEPARadNetDataToolStripMenuItem.Click += new System.EventHandler(MForm.getEPARadNetDataToolStripMenuItem_Click);
      //
      // convertMapDataFilesToolStripMenuItem
      //
      this.convertMapDataFilesToolStripMenuItem.Name = "convertMapDataFilesToolStripMenuItem";
      this.convertMapDataFilesToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.convertMapDataFilesToolStripMenuItem.Text = "Convert Map Data Files";
      this.convertMapDataFilesToolStripMenuItem.Click += new System.EventHandler(MForm.convertMapDataFilesToolStripMenuItem_Click);
      //
      // testRSAKeysToolStripMenuItem
      //
      this.testRSAKeysToolStripMenuItem.Name = "testRSAKeysToolStripMenuItem";
      this.testRSAKeysToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.testRSAKeysToolStripMenuItem.Text = "Test";
      this.testRSAKeysToolStripMenuItem.Click += new System.EventHandler(MForm.testRSAKeysToolStripMenuItem_Click);
      //
      // compressHexFilesToolStripMenuItem
      //
      this.compressHexFilesToolStripMenuItem.Name = "compressHexFilesToolStripMenuItem";
      this.compressHexFilesToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.compressHexFilesToolStripMenuItem.Text = "Compress Hex Files";
      this.compressHexFilesToolStripMenuItem.Click += new System.EventHandler(MForm.compressHexFilesToolStripMenuItem_Click);
      //
      // convertToDailyFilesToolStripMenuItem
      //
      this.convertToDailyFilesToolStripMenuItem.Name = "convertToDailyFilesToolStripMenuItem";
      this.convertToDailyFilesToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.convertToDailyFilesToolStripMenuItem.Text = "Convert To Daily Files for Server";
      this.convertToDailyFilesToolStripMenuItem.Click += new System.EventHandler(MForm.convertToDailyFilesToolStripMenuItem_Click);
      //
      // testHTTPToolStripMenuItem
      //
      this.testHTTPToolStripMenuItem.Name = "testHTTPToolStripMenuItem";
      this.testHTTPToolStripMenuItem.Size = new System.Drawing.Size(433, 36);
      this.testHTTPToolStripMenuItem.Text = "Test HTTP";
      this.testHTTPToolStripMenuItem.Click += new System.EventHandler(MForm.testHTTPToolStripMenuItem_Click);
      //
      // userSetupToolStripMenuItem
      //
      this.userSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identifyMonitoringStationToolStripMenuItem,
            this.configureGeigerPortToolStripMenuItem,
            this.configureCOMPortToolStripMenuItem,
            this.configureAlertsToolStripMenuItem,
            this.setGraphOptionsToolStripMenuItem,
            this.configureGraphUploadingToolStripMenuItem,
            this.otherOptionsToolStripMenuItem,
            this.wiGiSettingsToolStripMenuItem});
      this.userSetupToolStripMenuItem.Name = "userSetupToolStripMenuItem";
      this.userSetupToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
      this.userSetupToolStripMenuItem.Text = "&User Setup";
      //
      // identifyMonitoringStationToolStripMenuItem
      //
      this.identifyMonitoringStationToolStripMenuItem.Name = "identifyMonitoringStationToolStripMenuItem";
      this.identifyMonitoringStationToolStripMenuItem.Size = new System.Drawing.Size(402, 36);
      this.identifyMonitoringStationToolStripMenuItem.Text = "&Identify Monitoring Station";
      this.identifyMonitoringStationToolStripMenuItem.Click += new System.EventHandler(MForm.identifyMonitoringStationToolStripMenuItem_Click);
      //
      // configureGeigerPortToolStripMenuItem
      //
      this.configureGeigerPortToolStripMenuItem.Name = "configureGeigerPortToolStripMenuItem";
      this.configureGeigerPortToolStripMenuItem.Size = new System.Drawing.Size(402, 36);
      this.configureGeigerPortToolStripMenuItem.Text = "Select/Browse Geiger &Models";
      this.configureGeigerPortToolStripMenuItem.Click += new System.EventHandler(MForm.configureGeigerPortToolStripMenuItem_Click);
      //
      // configureCOMPortToolStripMenuItem
      //
      this.configureCOMPortToolStripMenuItem.Name = "configureCOMPortToolStripMenuItem";
      this.configureCOMPortToolStripMenuItem.Size = new System.Drawing.Size(402, 36);
      this.configureCOMPortToolStripMenuItem.Text = "Configure COM &Port";
      this.configureCOMPortToolStripMenuItem.Click += new System.EventHandler(MForm.configureCOMPortToolStripMenuItem_Click);
      //
      // configureAlertsToolStripMenuItem
      //
      this.configureAlertsToolStripMenuItem.Name = "configureAlertsToolStripMenuItem";
      this.configureAlertsToolStripMenuItem.Size = new System.Drawing.Size(402, 36);
      this.configureAlertsToolStripMenuItem.Text = "Configure &Alerts";
      this.configureAlertsToolStripMenuItem.Click += new System.EventHandler(MForm.configureAlertsToolStripMenuItem_Click);
      //
      // setGraphOptionsToolStripMenuItem
      //
      this.setGraphOptionsToolStripMenuItem.Name = "setGraphOptionsToolStripMenuItem";
      this.setGraphOptionsToolStripMenuItem.Size = new System.Drawing.Size(402, 36);
      this.setGraphOptionsToolStripMenuItem.Text = "Set &Graph Options";
      this.setGraphOptionsToolStripMenuItem.Click += new System.EventHandler(MForm.graphOptionsToolStripMenuItem_Click);
      //
      // configureGraphUploadingToolStripMenuItem
      //
      this.configureGraphUploadingToolStripMenuItem.Name = "configureGraphUploadingToolStripMenuItem";
      this.configureGraphUploadingToolStripMenuItem.Size = new System.Drawing.Size(402, 36);
      this.configureGraphUploadingToolStripMenuItem.Text = "&Upload Graph";
      this.configureGraphUploadingToolStripMenuItem.Click += new System.EventHandler(MForm.configureGraphUploadingToolStripMenuItem_Click);
      //
      // otherOptionsToolStripMenuItem
      //
      this.otherOptionsToolStripMenuItem.Name = "otherOptionsToolStripMenuItem";
      this.otherOptionsToolStripMenuItem.Size = new System.Drawing.Size(402, 36);
      this.otherOptionsToolStripMenuItem.Text = "Other &Options";
      this.otherOptionsToolStripMenuItem.Click += new System.EventHandler(MForm.otherOptionsToolStripMenuItem_Click);
      //
      // wiGiSettingsToolStripMenuItem
      //
      this.wiGiSettingsToolStripMenuItem.Name = "wiGiSettingsToolStripMenuItem";
      this.wiGiSettingsToolStripMenuItem.Size = new System.Drawing.Size(402, 36);
      this.wiGiSettingsToolStripMenuItem.Text = "&Wi-Gi Settings";
      this.wiGiSettingsToolStripMenuItem.Click += new System.EventHandler(MForm.wiGiSettingsToolStripMenuItem_Click);
      //
      // viewToolStripMenuItem
      //
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spreadsheetToolStripMenuItem,
            this.historicalSpreadsheetToolStripMenuItem,
            this.historicalGraphToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.showMainMapToolStripMenuItem1,
            this.showSecondMapToolStripMenuItem,
            this.alertLogToolStripMenuItem,
            this.goToWebSiteToolStripMenuItem,
            this.viewTrendingGraphsToolStripMenuItem,
            this.closeAllRemoteGraphsToolStripMenuItem,
            this.ePARadNetGraphToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
      this.viewToolStripMenuItem.Text = "&View";
      //
      // spreadsheetToolStripMenuItem
      //
      this.spreadsheetToolStripMenuItem.Name = "spreadsheetToolStripMenuItem";
      this.spreadsheetToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.spreadsheetToolStripMenuItem.Text = "Current &Spreadsheet";
      this.spreadsheetToolStripMenuItem.Click += new System.EventHandler(MForm.spreadsheetToolStripMenuItem_Click);
      //
      // historicalSpreadsheetToolStripMenuItem
      //
      this.historicalSpreadsheetToolStripMenuItem.Name = "historicalSpreadsheetToolStripMenuItem";
      this.historicalSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.historicalSpreadsheetToolStripMenuItem.Text = "H&istorical Spreadsheet";
      this.historicalSpreadsheetToolStripMenuItem.Click += new System.EventHandler(MForm.historicalSpreadsheetToolStripMenuItem_Click);
      //
      // historicalGraphToolStripMenuItem
      //
      this.historicalGraphToolStripMenuItem.Name = "historicalGraphToolStripMenuItem";
      this.historicalGraphToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.historicalGraphToolStripMenuItem.Text = "&Historical Graph";
      this.historicalGraphToolStripMenuItem.Click += new System.EventHandler(MForm.historicalGraphToolStripMenuItem_Click);
      //
      // reportToolStripMenuItem
      //
      this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
      this.reportToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.reportToolStripMenuItem.Text = "&Report";
      this.reportToolStripMenuItem.Click += new System.EventHandler(MForm.reportToolStripMenuItem_Click);
      //
      // showMainMapToolStripMenuItem1
      //
      this.showMainMapToolStripMenuItem1.Name = "showMainMapToolStripMenuItem1";
      this.showMainMapToolStripMenuItem1.Size = new System.Drawing.Size(353, 36);
      this.showMainMapToolStripMenuItem1.Text = "Radiation &Map";
      this.showMainMapToolStripMenuItem1.Click += new System.EventHandler(MForm.showMainMapToolStripMenuItem1_Click);
      //
      // showSecondMapToolStripMenuItem
      //
      this.showSecondMapToolStripMenuItem.Name = "showSecondMapToolStripMenuItem";
      this.showSecondMapToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.showSecondMapToolStripMenuItem.Text = "Show Second Map";
      this.showSecondMapToolStripMenuItem.Click += new System.EventHandler(MForm.showSecondMapToolStripMenuItem_Click);
      //
      // alertLogToolStripMenuItem
      //
      this.alertLogToolStripMenuItem.Name = "alertLogToolStripMenuItem";
      this.alertLogToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.alertLogToolStripMenuItem.Text = "&Alert Log";
      this.alertLogToolStripMenuItem.Click += new System.EventHandler(MForm.alertLogToolStripMenuItem_Click);
      //
      // goToWebSiteToolStripMenuItem
      //
      this.goToWebSiteToolStripMenuItem.Name = "goToWebSiteToolStripMenuItem";
      this.goToWebSiteToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.goToWebSiteToolStripMenuItem.Text = "Go to &Web Site";
      this.goToWebSiteToolStripMenuItem.Click += new System.EventHandler(MForm.goToWebSiteToolStripMenuItem_Click);
      //
      // viewTrendingGraphsToolStripMenuItem
      //
      this.viewTrendingGraphsToolStripMenuItem.Name = "viewTrendingGraphsToolStripMenuItem";
      this.viewTrendingGraphsToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.viewTrendingGraphsToolStripMenuItem.Text = "View &Trending Graphs";
      this.viewTrendingGraphsToolStripMenuItem.Click += new System.EventHandler(MForm.viewTrendingGraphsToolStripMenuItem_Click);
      //
      // closeAllRemoteGraphsToolStripMenuItem
      //
      this.closeAllRemoteGraphsToolStripMenuItem.Name = "closeAllRemoteGraphsToolStripMenuItem";
      this.closeAllRemoteGraphsToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.closeAllRemoteGraphsToolStripMenuItem.Text = "&Close All Remote Graphs";
      this.closeAllRemoteGraphsToolStripMenuItem.Click += new System.EventHandler(MForm.closeAllRemoteGraphsToolStripMenuItem_Click);
      //
      // ePARadNetGraphToolStripMenuItem
      //
      this.ePARadNetGraphToolStripMenuItem.Name = "ePARadNetGraphToolStripMenuItem";
      this.ePARadNetGraphToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
      this.ePARadNetGraphToolStripMenuItem.Text = "EPA Rad Net Graph";
      this.ePARadNetGraphToolStripMenuItem.Click += new System.EventHandler(MForm.ePARadNetGraphToolStripMenuItem_Click);
      //
      // networkToolStripMenuItem
      //
      this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveChatOverTheRadiationNetworkToolStripMenuItem,
            this.sendAlertsByTextToolStripMenuItem,
            this.pauseSendCPMDataToolStripMenuItem});
      this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
      this.networkToolStripMenuItem.Size = new System.Drawing.Size(117, 36);
      this.networkToolStripMenuItem.Text = "&Network";
      //
      // liveChatOverTheRadiationNetworkToolStripMenuItem
      //
      this.liveChatOverTheRadiationNetworkToolStripMenuItem.Name = "liveChatOverTheRadiationNetworkToolStripMenuItem";
      this.liveChatOverTheRadiationNetworkToolStripMenuItem.Size = new System.Drawing.Size(488, 36);
      this.liveChatOverTheRadiationNetworkToolStripMenuItem.Text = "Live &Chat over the Radiation Network";
      this.liveChatOverTheRadiationNetworkToolStripMenuItem.Click += new System.EventHandler(MForm.liveChatOverTheRadiationNetworkToolStripMenuItem_Click);
      //
      // sendAlertsByTextToolStripMenuItem
      //
      this.sendAlertsByTextToolStripMenuItem.Name = "sendAlertsByTextToolStripMenuItem";
      this.sendAlertsByTextToolStripMenuItem.Size = new System.Drawing.Size(488, 36);
      this.sendAlertsByTextToolStripMenuItem.Text = "Send Alerts by &Text Message";
      this.sendAlertsByTextToolStripMenuItem.Click += new System.EventHandler(MForm.sendAlertsByTextToolStripMenuItem_Click);
      //
      // pauseSendCPMDataToolStripMenuItem
      //
      this.pauseSendCPMDataToolStripMenuItem.Name = "pauseSendCPMDataToolStripMenuItem";
      this.pauseSendCPMDataToolStripMenuItem.Size = new System.Drawing.Size(488, 36);
      this.pauseSendCPMDataToolStripMenuItem.Text = "Pause &Send CPM Data";
      this.pauseSendCPMDataToolStripMenuItem.Click += new System.EventHandler(MForm.pauseSendCPMDataToolStripMenuItem_Click);
      //
      // graphPRMToolStripMenuItem
      //
      this.graphPRMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphWiGiToolStripMenuItem,
            this.readLogDataToolStripMenuItem,
            this.graphInspectorUSBToolStripMenuItem});
      this.graphPRMToolStripMenuItem.Name = "graphPRMToolStripMenuItem";
      this.graphPRMToolStripMenuItem.Size = new System.Drawing.Size(149, 36);
      this.graphPRMToolStripMenuItem.Text = "Upload &Log";
      //
      // graphWiGiToolStripMenuItem
      //
      this.graphWiGiToolStripMenuItem.Name = "graphWiGiToolStripMenuItem";
      this.graphWiGiToolStripMenuItem.Size = new System.Drawing.Size(309, 36);
      this.graphWiGiToolStripMenuItem.Text = "Graph &Wi-Gi";
      this.graphWiGiToolStripMenuItem.Click += new System.EventHandler(MForm.graphWiGiToolStripMenuItem_Click);
      //
      // readLogDataToolStripMenuItem
      //
      this.readLogDataToolStripMenuItem.Name = "readLogDataToolStripMenuItem";
      this.readLogDataToolStripMenuItem.Size = new System.Drawing.Size(309, 36);
      this.readLogDataToolStripMenuItem.Text = "Graph &PRM";
      this.readLogDataToolStripMenuItem.Click += new System.EventHandler(MForm.readLogDataToolStripMenuItem_Click);
      //
      // graphInspectorUSBToolStripMenuItem
      //
      this.graphInspectorUSBToolStripMenuItem.Name = "graphInspectorUSBToolStripMenuItem";
      this.graphInspectorUSBToolStripMenuItem.Size = new System.Drawing.Size(309, 36);
      this.graphInspectorUSBToolStripMenuItem.Text = "Graph &Inspector USB";
      this.graphInspectorUSBToolStripMenuItem.Click += new System.EventHandler(MForm.graphInspectorUSBToolStripMenuItem_Click);
      //
      // helpToolStripMenuItem
      //
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpNarrativeToolStripMenuItem,
            this.didYouKnowToolStripMenuItem,
            this.openInfoFilesToolStripMenuItem,
            this.troubleshootGeigerCounterToolStripMenuItem,
            this.troubleshootDataCablesToolStripMenuItem,
            this.instalFTDIDriverToolStripMenuItem,
            this.troubleshootTextAlertsToolStripMenuItem,
            this.troubleshootFTPToolStripMenuItem,
            this.troubleshootNetworkToolStripMenuItem,
            this.licenseAgreementToolStripMenuItem,
            this.privacyPolicyToolStripMenuItem,
            this.registerGeigerGraphToolStripMenuItem,
            this.readMeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.showUnicodeTextToolStripMenuItem,
            this.seeSubscriptionLevelToolStripMenuItem,
            this.showOperatingSystemToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
      this.helpToolStripMenuItem.Text = "&Help";
      //
      // helpNarrativeToolStripMenuItem
      //
      this.helpNarrativeToolStripMenuItem.Name = "helpNarrativeToolStripMenuItem";
      this.helpNarrativeToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.helpNarrativeToolStripMenuItem.Text = "Help &Narrative";
      this.helpNarrativeToolStripMenuItem.Click += new System.EventHandler(MForm.helpNarrativeToolStripMenuItem_Click);
      //
      // didYouKnowToolStripMenuItem
      //
      this.didYouKnowToolStripMenuItem.Name = "didYouKnowToolStripMenuItem";
      this.didYouKnowToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.didYouKnowToolStripMenuItem.Text = "Did You &Know";
      this.didYouKnowToolStripMenuItem.Click += new System.EventHandler(MForm.didYouKnowToolStripMenuItem_Click);
      //
      // openInfoFilesToolStripMenuItem
      //
      this.openInfoFilesToolStripMenuItem.Name = "openInfoFilesToolStripMenuItem";
      this.openInfoFilesToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.openInfoFilesToolStripMenuItem.Text = "&Open MyData Folder";
      this.openInfoFilesToolStripMenuItem.Click += new System.EventHandler(MForm.openInfoFilesToolStripMenuItem_Click);
      //
      // troubleshootGeigerCounterToolStripMenuItem
      //
      this.troubleshootGeigerCounterToolStripMenuItem.Name = "troubleshootGeigerCounterToolStripMenuItem";
      this.troubleshootGeigerCounterToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.troubleshootGeigerCounterToolStripMenuItem.Text = "Troubleshoot &Geiger Counter";
      this.troubleshootGeigerCounterToolStripMenuItem.Click += new System.EventHandler(MForm.troubleshootGeigerCounterToolStripMenuItem_Click_1);
      //
      // troubleshootDataCablesToolStripMenuItem
      //
      this.troubleshootDataCablesToolStripMenuItem.Name = "troubleshootDataCablesToolStripMenuItem";
      this.troubleshootDataCablesToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.troubleshootDataCablesToolStripMenuItem.Text = "Troubleshoot Data &Cables";
      this.troubleshootDataCablesToolStripMenuItem.Click += new System.EventHandler(MForm.troubleshootDataCablesToolStripMenuItem_Click);
      //
      // instalFTDIDriverToolStripMenuItem
      //
      this.instalFTDIDriverToolStripMenuItem.Name = "instalFTDIDriverToolStripMenuItem";
      this.instalFTDIDriverToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.instalFTDIDriverToolStripMenuItem.Text = "&Install FTDI Driver for Data Cable";
      this.instalFTDIDriverToolStripMenuItem.Click += new System.EventHandler(MForm.instalFTDIDriverToolStripMenuItem_Click);
      //
      // troubleshootTextAlertsToolStripMenuItem
      //
      this.troubleshootTextAlertsToolStripMenuItem.Name = "troubleshootTextAlertsToolStripMenuItem";
      this.troubleshootTextAlertsToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.troubleshootTextAlertsToolStripMenuItem.Text = "Troubleshoot &Text Alerts";
      //
      // troubleshootFTPToolStripMenuItem
      //
      this.troubleshootFTPToolStripMenuItem.Name = "troubleshootFTPToolStripMenuItem";
      this.troubleshootFTPToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.troubleshootFTPToolStripMenuItem.Text = "Troubleshoot &FTP Upload";
      this.troubleshootFTPToolStripMenuItem.Click += new System.EventHandler(MForm.troubleshootFTPToolStripMenuItem_Click);
      //
      // troubleshootNetworkToolStripMenuItem
      //
      this.troubleshootNetworkToolStripMenuItem.Name = "troubleshootNetworkToolStripMenuItem";
      this.troubleshootNetworkToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.troubleshootNetworkToolStripMenuItem.Text = "Troubleshoot Net&work";
      this.troubleshootNetworkToolStripMenuItem.Click += new System.EventHandler(MForm.troubleshootNetworkToolStripMenuItem_Click);
      //
      // licenseAgreementToolStripMenuItem
      //
      this.licenseAgreementToolStripMenuItem.Name = "licenseAgreementToolStripMenuItem";
      this.licenseAgreementToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.licenseAgreementToolStripMenuItem.Text = "&License Agreement";
      this.licenseAgreementToolStripMenuItem.Click += new System.EventHandler(MForm.licenseAgreementToolStripMenuItem_Click);
      //
      // privacyPolicyToolStripMenuItem
      //
      this.privacyPolicyToolStripMenuItem.Name = "privacyPolicyToolStripMenuItem";
      this.privacyPolicyToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.privacyPolicyToolStripMenuItem.Text = "Privacy Policy";
      this.privacyPolicyToolStripMenuItem.Click += new System.EventHandler(MForm.privacyPolicyToolStripMenuItem_Click);
      //
      // registerGeigerGraphToolStripMenuItem
      //
      this.registerGeigerGraphToolStripMenuItem.Name = "registerGeigerGraphToolStripMenuItem";
      this.registerGeigerGraphToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.registerGeigerGraphToolStripMenuItem.Text = "GeigerGraph &Registration";
      this.registerGeigerGraphToolStripMenuItem.Click += new System.EventHandler(MForm.registerGeigerGraphToolStripMenuItem_Click);
      //
      // readMeToolStripMenuItem
      //
      this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
      this.readMeToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.readMeToolStripMenuItem.Text = "Read &Me";
      this.readMeToolStripMenuItem.Click += new System.EventHandler(MForm.readMeToolStripMenuItem_Click);
      //
      // aboutToolStripMenuItem
      //
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.aboutToolStripMenuItem.Text = "&About GeigerGraph";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(MForm.aboutToolStripMenuItem_Click);
      //
      // showUnicodeTextToolStripMenuItem
      //
      this.showUnicodeTextToolStripMenuItem.Name = "showUnicodeTextToolStripMenuItem";
      this.showUnicodeTextToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.showUnicodeTextToolStripMenuItem.Text = "Show Unicode Text";
      this.showUnicodeTextToolStripMenuItem.Click += new System.EventHandler(MForm.showUnicodeTextToolStripMenuItem_Click);
      //
      // seeSubscriptionLevelToolStripMenuItem
      //
      this.seeSubscriptionLevelToolStripMenuItem.Name = "seeSubscriptionLevelToolStripMenuItem";
      this.seeSubscriptionLevelToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.seeSubscriptionLevelToolStripMenuItem.Text = "See Subscription Level";
      this.seeSubscriptionLevelToolStripMenuItem.Click += new System.EventHandler(MForm.seeSubscriptionLevelToolStripMenuItem_Click);
      //
      // showOperatingSystemToolStripMenuItem
      //
      this.showOperatingSystemToolStripMenuItem.Name = "showOperatingSystemToolStripMenuItem";
      this.showOperatingSystemToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
      this.showOperatingSystemToolStripMenuItem.Text = "Show Operating System";
      this.showOperatingSystemToolStripMenuItem.Click += new System.EventHandler(MForm.showOperatingSystemToolStripMenuItem_Click);
      //
      // ButtonPanel
      //
      this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ButtonPanel.Controls.Add(this.HistoricalGraphButton);
      this.ButtonPanel.Controls.Add(this.TestVersionLabel);
      this.ButtonPanel.Controls.Add(this.UniversalChatButton);
      this.ButtonPanel.Controls.Add(this.DemoModeLabel);
      this.ButtonPanel.Controls.Add(this.DisableSendCPMButton);
      this.ButtonPanel.Controls.Add(this.PrintButton);
      this.ButtonPanel.Controls.Add(this.ViewGraphsButton);
      this.ButtonPanel.Controls.Add(this.TextAlertsButton);
      this.ButtonPanel.Controls.Add(this.IDButton);
      this.ButtonPanel.Controls.Add(this.TestAlertSoundButton);
      this.ButtonPanel.Controls.Add(this.AHelpButton);
      this.ButtonPanel.Controls.Add(this.GoToWebSiteButton);
      this.ButtonPanel.Controls.Add(this.ViewReportButton);
      this.ButtonPanel.Controls.Add(this.ShowSpreadSheetButton);
      this.ButtonPanel.Controls.Add(this.MainMapButton);
      this.ButtonPanel.Controls.Add(this.SaveImageButton);
      this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.ButtonPanel.Location = new System.Drawing.Point(0, 40);
      this.ButtonPanel.Name = "ButtonPanel";
      this.ButtonPanel.Size = new System.Drawing.Size(962, 32);
      this.ButtonPanel.TabIndex = 1;
      //
      // HistoricalGraphButton
      //
      this.HistoricalGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.HistoricalGraphButton.FlatAppearance.BorderSize = 0;
      this.HistoricalGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.HistoricalGraphButton.Image = ((System.Drawing.Image)(resources.GetObject("HistoricalGraphButton.Image")));
      this.HistoricalGraphButton.Location = new System.Drawing.Point(58, 2);
      this.HistoricalGraphButton.Name = "HistoricalGraphButton";
      this.HistoricalGraphButton.Size = new System.Drawing.Size(26, 26);
      this.HistoricalGraphButton.TabIndex = 15;
      this.HistoricalGraphButton.UseVisualStyleBackColor = true;
      this.HistoricalGraphButton.Click += new System.EventHandler(MForm.HistoricalGraphButton_Click);
      //
      // TestVersionLabel
      //
      this.TestVersionLabel.AutoSize = true;
      this.TestVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.TestVersionLabel.Location = new System.Drawing.Point(718, 4);
      this.TestVersionLabel.Name = "TestVersionLabel";
      this.TestVersionLabel.Size = new System.Drawing.Size(110, 20);
      this.TestVersionLabel.TabIndex = 14;
      this.TestVersionLabel.Text = "Test Version";
      //
      // UniversalChatButton
      //
      this.UniversalChatButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.UniversalChatButton.FlatAppearance.BorderSize = 0;
      this.UniversalChatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.UniversalChatButton.Image = ((System.Drawing.Image)(resources.GetObject("UniversalChatButton.Image")));
      this.UniversalChatButton.Location = new System.Drawing.Point(350, 2);
      this.UniversalChatButton.Name = "UniversalChatButton";
      this.UniversalChatButton.Size = new System.Drawing.Size(26, 26);
      this.UniversalChatButton.TabIndex = 13;
      this.UniversalChatButton.UseVisualStyleBackColor = true;
      this.UniversalChatButton.Click += new System.EventHandler(MForm.UniversalChatButton_Click);
      //
      // DemoModeLabel
      //
      this.DemoModeLabel.AutoSize = true;
      this.DemoModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.DemoModeLabel.ForeColor = System.Drawing.Color.Red;
      this.DemoModeLabel.Location = new System.Drawing.Point(486, 2);
      this.DemoModeLabel.Name = "DemoModeLabel";
      this.DemoModeLabel.Size = new System.Drawing.Size(194, 22);
      this.DemoModeLabel.TabIndex = 12;
      this.DemoModeLabel.Text = "In Demonstration Mode";
      //
      // DisableSendCPMButton
      //
      this.DisableSendCPMButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.DisableSendCPMButton.FlatAppearance.BorderSize = 0;
      this.DisableSendCPMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.DisableSendCPMButton.Image = ((System.Drawing.Image)(resources.GetObject("DisableSendCPMButton.Image")));
      this.DisableSendCPMButton.Location = new System.Drawing.Point(438, 2);
      this.DisableSendCPMButton.Name = "DisableSendCPMButton";
      this.DisableSendCPMButton.Size = new System.Drawing.Size(26, 26);
      this.DisableSendCPMButton.TabIndex = 11;
      this.DisableSendCPMButton.UseVisualStyleBackColor = true;
      this.DisableSendCPMButton.Click += new System.EventHandler(MForm.DisableSendCPMButton_Click);
      //
      // PrintButton
      //
      this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.PrintButton.FlatAppearance.BorderSize = 0;
      this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
      this.PrintButton.Location = new System.Drawing.Point(170, 2);
      this.PrintButton.Name = "PrintButton";
      this.PrintButton.Size = new System.Drawing.Size(26, 26);
      this.PrintButton.TabIndex = 6;
      this.PrintButton.UseVisualStyleBackColor = true;
      this.PrintButton.Click += new System.EventHandler(MForm.PrintButton_Click);
      //
      // ViewGraphsButton
      //
      this.ViewGraphsButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ViewGraphsButton.FlatAppearance.BorderSize = 0;
      this.ViewGraphsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ViewGraphsButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewGraphsButton.Image")));
      this.ViewGraphsButton.Location = new System.Drawing.Point(380, 2);
      this.ViewGraphsButton.Name = "ViewGraphsButton";
      this.ViewGraphsButton.Size = new System.Drawing.Size(26, 26);
      this.ViewGraphsButton.TabIndex = 9;
      this.ViewGraphsButton.UseVisualStyleBackColor = true;
      this.ViewGraphsButton.Click += new System.EventHandler(MForm.ViewGraphsButton_Click);
      //
      // TextAlertsButton
      //
      this.TextAlertsButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TextAlertsButton.FlatAppearance.BorderSize = 0;
      this.TextAlertsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

      // This object in the resx file was copied
      // from a Mineral Search resx file.
      // this.TextAlertsButton.Image =
      //        ((System.Drawing.Image)
      //       (resources.GetObject("ClearSearchButton.Image")));

      this.TextAlertsButton.Image =
              ((System.Drawing.Image)
             (resources.GetObject("TextAlertButton.Image")));

      // ((System.Drawing.Image)(resources.GetObject("EMailAlertsButton.Image")));
      // this.TextAlertsButton.Text = "Tx";

      this.TextAlertsButton.Location = new System.Drawing.Point(410, 2);
      this.TextAlertsButton.Name = "TextAlertsButton";
      this.TextAlertsButton.Size = new System.Drawing.Size(28, 26);
      this.TextAlertsButton.TabIndex = 10;
      this.TextAlertsButton.UseVisualStyleBackColor = true;
      this.TextAlertsButton.Click += new System.EventHandler(MForm.TextAlertsButton_Click);


      // IDButton
      //
      this.IDButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.IDButton.FlatAppearance.BorderSize = 0;
      this.IDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

      // IDButton.Image is how it is named in the
      // resx file.  See the type name also in
      // how IDresources got created.
      // (IDresources.GetObject("IDButton.Image")));

      this.IDButton.Image = ((System.Drawing.Image)(IDresources.GetObject("IDButton.Image")));
      // this.IDButton.Text = "ID";
      this.IDButton.Location = new System.Drawing.Point(30, 2);
      this.IDButton.Name = "IDButton";
      this.IDButton.Size = new System.Drawing.Size(28, 26);
      this.IDButton.TabIndex = 10;
      this.IDButton.UseVisualStyleBackColor = true;
      this.IDButton.Click += new System.EventHandler(MForm.identifyMonitoringStationToolStripMenuItem_Click);




      //
      // TestAlertSoundButton
      //
      this.TestAlertSoundButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TestAlertSoundButton.FlatAppearance.BorderSize = 0;
      this.TestAlertSoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.TestAlertSoundButton.Image = ((System.Drawing.Image)(resources.GetObject("TestAlertSoundButton.Image")));
      this.TestAlertSoundButton.Location = new System.Drawing.Point(142, 2);
      this.TestAlertSoundButton.Name = "TestAlertSoundButton";
      this.TestAlertSoundButton.Size = new System.Drawing.Size(26, 26);
      this.TestAlertSoundButton.TabIndex = 5;
      this.TestAlertSoundButton.UseVisualStyleBackColor = true;
      this.TestAlertSoundButton.Click += new System.EventHandler(MForm.TestAlertSoundButton_Click);
      //
      // AHelpButton
      //
      this.AHelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.AHelpButton.FlatAppearance.BorderSize = 0;
      this.AHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.AHelpButton.Image = ((System.Drawing.Image)(resources.GetObject("AHelpButton.Image")));
      this.AHelpButton.Location = new System.Drawing.Point(198, 2);
      this.AHelpButton.Name = "AHelpButton";
      this.AHelpButton.Size = new System.Drawing.Size(26, 26);
      this.AHelpButton.TabIndex = 7;
      this.AHelpButton.UseVisualStyleBackColor = true;
      this.AHelpButton.Click += new System.EventHandler(MForm.HelpButton_Click);
      //
      // GoToWebSiteButton
      //
      this.GoToWebSiteButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.GoToWebSiteButton.FlatAppearance.BorderSize = 0;
      this.GoToWebSiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.GoToWebSiteButton.Image = ((System.Drawing.Image)(resources.GetObject("GoToWebSiteButton.Image")));
      this.GoToWebSiteButton.Location = new System.Drawing.Point(114, 2);
      this.GoToWebSiteButton.Name = "GoToWebSiteButton";
      this.GoToWebSiteButton.Size = new System.Drawing.Size(26, 26);
      this.GoToWebSiteButton.TabIndex = 4;
      this.GoToWebSiteButton.UseVisualStyleBackColor = true;
      this.GoToWebSiteButton.Click += new System.EventHandler(MForm.GoToWebSiteButton_Click);
      //
      // ViewReportButton
      //
      this.ViewReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ViewReportButton.FlatAppearance.BorderSize = 0;
      this.ViewReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ViewReportButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewReportButton.Image")));
      this.ViewReportButton.Location = new System.Drawing.Point(86, 2);
      this.ViewReportButton.Name = "ViewReportButton";
      this.ViewReportButton.Size = new System.Drawing.Size(26, 26);
      this.ViewReportButton.TabIndex = 3;
      this.ViewReportButton.UseVisualStyleBackColor = true;
      this.ViewReportButton.Click += new System.EventHandler(MForm.ViewReportButton_Click);
      //
      // ShowSpreadSheetButton
      //
      this.ShowSpreadSheetButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ShowSpreadSheetButton.FlatAppearance.BorderSize = 0;
      this.ShowSpreadSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ShowSpreadSheetButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowSpreadSheetButton.Image")));
      this.ShowSpreadSheetButton.Location = new System.Drawing.Point(58, 2);
      this.ShowSpreadSheetButton.Name = "ShowSpreadSheetButton";
      this.ShowSpreadSheetButton.Size = new System.Drawing.Size(26, 26);
      this.ShowSpreadSheetButton.TabIndex = 2;
      this.ShowSpreadSheetButton.UseVisualStyleBackColor = true;
      this.ShowSpreadSheetButton.Click += new System.EventHandler(MForm.ShowSpreadSheetButton_Click);
      //
      // MainMapButton
      //
      this.MainMapButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.MainMapButton.FlatAppearance.BorderSize = 0;
      this.MainMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.MainMapButton.Image = ((System.Drawing.Image)(resources.GetObject("MainMapButton.Image")));
      this.MainMapButton.Location = new System.Drawing.Point(320, 2);
      this.MainMapButton.Name = "MainMapButton";
      this.MainMapButton.Size = new System.Drawing.Size(26, 26);
      this.MainMapButton.TabIndex = 8;
      this.MainMapButton.UseVisualStyleBackColor = true;
      this.MainMapButton.Click += new System.EventHandler(MForm.MainMapButton_Click);
      this.MainMapButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(MForm.MainMapButton_PreviewKeyDown);
      //
      // SaveImageButton
      //
      this.SaveImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.SaveImageButton.FlatAppearance.BorderSize = 0;
      this.SaveImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SaveImageButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveImageButton.Image")));
      this.SaveImageButton.Location = new System.Drawing.Point(2, 2);
      this.SaveImageButton.Name = "SaveImageButton";
      this.SaveImageButton.Size = new System.Drawing.Size(26, 26);
      this.SaveImageButton.TabIndex = 1;
      this.SaveImageButton.UseVisualStyleBackColor = true;
      this.SaveImageButton.Click += new System.EventHandler(MForm.SaveImageButton_Click);
      //
      // UpperPanel
      //
      this.UpperPanel.BackColor = System.Drawing.Color.DarkGray;
      this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.UpperPanel.Controls.Add(this.SoundsGroupBox);
      this.UpperPanel.Controls.Add(this.GraphOptionsButton);
      this.UpperPanel.Controls.Add(this.BlinkLEDOffButton);
      this.UpperPanel.Controls.Add(this.BlinkLEDOnButton);
      this.UpperPanel.Controls.Add(this.AlertLevelGroupBox);
      this.UpperPanel.Controls.Add(this.TimeGroupBox);
      this.UpperPanel.Controls.Add(this.CountsGroupBox);
      this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.UpperPanel.Location = new System.Drawing.Point(0, 72);
      this.UpperPanel.Name = "UpperPanel";
      this.UpperPanel.Size = new System.Drawing.Size(962, 168);
      this.UpperPanel.TabIndex = 2;
      //
      // SoundsGroupBox
      //
      this.SoundsGroupBox.Controls.Add(this.SoundClickRadioButton);
      this.SoundsGroupBox.Controls.Add(this.SoundBeepRadioButton);
      this.SoundsGroupBox.Controls.Add(this.PlaySoundsCheckBox);
      this.SoundsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.SoundsGroupBox.ForeColor = System.Drawing.Color.Black;
      this.SoundsGroupBox.Location = new System.Drawing.Point(676, 4);
      this.SoundsGroupBox.Name = "SoundsGroupBox";
      this.SoundsGroupBox.Size = new System.Drawing.Size(198, 104);
      this.SoundsGroupBox.TabIndex = 3;
      this.SoundsGroupBox.TabStop = false;
      this.SoundsGroupBox.Text = " Sounds ";
      //
      // SoundClickRadioButton
      //
      this.SoundClickRadioButton.AutoSize = true;
      this.SoundClickRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.SoundClickRadioButton.Location = new System.Drawing.Point(24, 74);
      this.SoundClickRadioButton.Name = "SoundClickRadioButton";
      this.SoundClickRadioButton.Size = new System.Drawing.Size(58, 20);
      this.SoundClickRadioButton.TabIndex = 11;
      this.SoundClickRadioButton.TabStop = true;
      this.SoundClickRadioButton.Text = "&Click";
      this.SoundClickRadioButton.UseVisualStyleBackColor = true;
      this.SoundClickRadioButton.Click += new System.EventHandler(MForm.SoundClickRadioButton_Click);
      //
      // SoundBeepRadioButton
      //
      this.SoundBeepRadioButton.AutoSize = true;
      this.SoundBeepRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.SoundBeepRadioButton.Location = new System.Drawing.Point(24, 50);
      this.SoundBeepRadioButton.Name = "SoundBeepRadioButton";
      this.SoundBeepRadioButton.Size = new System.Drawing.Size(61, 20);
      this.SoundBeepRadioButton.TabIndex = 10;
      this.SoundBeepRadioButton.TabStop = true;
      this.SoundBeepRadioButton.Text = "&Beep";
      this.SoundBeepRadioButton.UseVisualStyleBackColor = true;
      this.SoundBeepRadioButton.Click += new System.EventHandler(MForm.SoundBeepRadioButton_Click);
      //
      // PlaySoundsCheckBox
      //
      this.PlaySoundsCheckBox.AutoCheck = false;
      this.PlaySoundsCheckBox.AutoSize = true;
      this.PlaySoundsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.PlaySoundsCheckBox.Location = new System.Drawing.Point(8, 24);
      this.PlaySoundsCheckBox.Name = "PlaySoundsCheckBox";
      this.PlaySoundsCheckBox.Size = new System.Drawing.Size(170, 21);
      this.PlaySoundsCheckBox.TabIndex = 9;
      this.PlaySoundsCheckBox.Text = "Pla&y Sound w/each count";
      this.PlaySoundsCheckBox.UseVisualStyleBackColor = true;
      this.PlaySoundsCheckBox.Click += new System.EventHandler(MForm.PlaySoundsCheckBox_Click);
      //
      // GraphOptionsButton
      //
      this.GraphOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.GraphOptionsButton.Location = new System.Drawing.Point(760, 112);
      this.GraphOptionsButton.Name = "GraphOptionsButton";
      this.GraphOptionsButton.Size = new System.Drawing.Size(116, 26);
      this.GraphOptionsButton.TabIndex = 12;
      this.GraphOptionsButton.Text = "&Graph Options";
      this.GraphOptionsButton.UseVisualStyleBackColor = true;
      this.GraphOptionsButton.Click += new System.EventHandler(MForm.GraphOptionsButton_Click);
      //
      // BlinkLEDOffButton
      //
      this.BlinkLEDOffButton.FlatAppearance.BorderSize = 0;
      this.BlinkLEDOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BlinkLEDOffButton.Image = ((System.Drawing.Image)(resources.GetObject("BlinkLEDOffButton.Image")));
      this.BlinkLEDOffButton.Location = new System.Drawing.Point(722, 132);
      this.BlinkLEDOffButton.Name = "BlinkLEDOffButton";
      this.BlinkLEDOffButton.Size = new System.Drawing.Size(32, 32);
      this.BlinkLEDOffButton.TabIndex = 7;
      this.BlinkLEDOffButton.TabStop = false;
      this.BlinkLEDOffButton.UseVisualStyleBackColor = true;
      //
      // BlinkLEDOnButton
      //
      this.BlinkLEDOnButton.FlatAppearance.BorderSize = 0;
      this.BlinkLEDOnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BlinkLEDOnButton.Image = ((System.Drawing.Image)(resources.GetObject("BlinkLEDOnButton.Image")));
      this.BlinkLEDOnButton.Location = new System.Drawing.Point(680, 112);
      this.BlinkLEDOnButton.Name = "BlinkLEDOnButton";
      this.BlinkLEDOnButton.Size = new System.Drawing.Size(32, 32);
      this.BlinkLEDOnButton.TabIndex = 6;
      this.BlinkLEDOnButton.TabStop = false;
      this.BlinkLEDOnButton.UseVisualStyleBackColor = true;
      //
      // AlertLevelGroupBox
      //
      this.AlertLevelGroupBox.BackColor = System.Drawing.Color.DarkGray;
      this.AlertLevelGroupBox.Controls.Add(this.EnableAlertPopupCheckBox);
      this.AlertLevelGroupBox.Controls.Add(this.SeriesAlertLevelCheckBox);
      this.AlertLevelGroupBox.Controls.Add(this.LesserOfLabel);
      this.AlertLevelGroupBox.Controls.Add(this.AlertMultNumericUpDown);
      this.AlertLevelGroupBox.Controls.Add(this.SetMultLabel);
      this.AlertLevelGroupBox.Controls.Add(this.SetCPMLabel);
      this.AlertLevelGroupBox.Controls.Add(this.AdvancedAlertButton);
      this.AlertLevelGroupBox.Controls.Add(this.AlertNumericUpDown);
      this.AlertLevelGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.AlertLevelGroupBox.ForeColor = System.Drawing.Color.Black;
      this.AlertLevelGroupBox.Location = new System.Drawing.Point(450, 4);
      this.AlertLevelGroupBox.Name = "AlertLevelGroupBox";
      this.AlertLevelGroupBox.Size = new System.Drawing.Size(220, 140);
      this.AlertLevelGroupBox.TabIndex = 2;
      this.AlertLevelGroupBox.TabStop = false;
      this.AlertLevelGroupBox.Text = " Alert Level (Local Station) ";
      //
      // EnableAlertPopupCheckBox
      //
      this.EnableAlertPopupCheckBox.AutoCheck = false;
      this.EnableAlertPopupCheckBox.AutoSize = true;
      this.EnableAlertPopupCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.EnableAlertPopupCheckBox.Location = new System.Drawing.Point(6, 86);
      this.EnableAlertPopupCheckBox.Name = "EnableAlertPopupCheckBox";
      this.EnableAlertPopupCheckBox.Size = new System.Drawing.Size(120, 21);
      this.EnableAlertPopupCheckBox.TabIndex = 6;
      this.EnableAlertPopupCheckBox.Text = "&Enable Pop-Up ";
      this.EnableAlertPopupCheckBox.UseVisualStyleBackColor = true;
      this.EnableAlertPopupCheckBox.Click += new System.EventHandler(MForm.EnableAlertPopupCheckBox_Click);
      //
      // SeriesAlertLevelCheckBox
      //
      this.SeriesAlertLevelCheckBox.AutoCheck = false;
      this.SeriesAlertLevelCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.SeriesAlertLevelCheckBox.Location = new System.Drawing.Point(6, 110);
      this.SeriesAlertLevelCheckBox.Name = "SeriesAlertLevelCheckBox";
      this.SeriesAlertLevelCheckBox.Size = new System.Drawing.Size(128, 22);
      this.SeriesAlertLevelCheckBox.TabIndex = 7;
      this.SeriesAlertLevelCheckBox.Text = "&Show On Graph";
      this.SeriesAlertLevelCheckBox.UseVisualStyleBackColor = true;
      this.SeriesAlertLevelCheckBox.Click += new System.EventHandler(MForm.SeriesAlertLevelCheckBox_Click);
      //
      // LesserOfLabel
      //
      this.LesserOfLabel.AutoSize = true;
      this.LesserOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.LesserOfLabel.Location = new System.Drawing.Point(6, 22);
      this.LesserOfLabel.Name = "LesserOfLabel";
      this.LesserOfLabel.Size = new System.Drawing.Size(60, 15);
      this.LesserOfLabel.TabIndex = 1;
      this.LesserOfLabel.Text = "Lesser of:";
      //
      // AlertMultNumericUpDown
      //
      this.AlertMultNumericUpDown.DecimalPlaces = 2;
      this.AlertMultNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.AlertMultNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.AlertMultNumericUpDown.Location = new System.Drawing.Point(146, 40);
      this.AlertMultNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.AlertMultNumericUpDown.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            65536});
      this.AlertMultNumericUpDown.Name = "AlertMultNumericUpDown";
      this.AlertMultNumericUpDown.Size = new System.Drawing.Size(68, 21);
      this.AlertMultNumericUpDown.TabIndex = 3;
      this.AlertMultNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
      this.AlertMultNumericUpDown.ValueChanged += new System.EventHandler(MForm.AlertMultNumericUpDown_ValueChanged);
      //
      // SetMultLabel
      //
      this.SetMultLabel.AutoSize = true;
      this.SetMultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.SetMultLabel.Location = new System.Drawing.Point(18, 42);
      this.SetMultLabel.Name = "SetMultLabel";
      this.SetMultLabel.Size = new System.Drawing.Size(98, 15);
      this.SetMultLabel.TabIndex = 2;
      this.SetMultLabel.Text = "&Multiple of Base:";
      //
      // SetCPMLabel
      //
      this.SetCPMLabel.AutoSize = true;
      this.SetCPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.SetCPMLabel.Location = new System.Drawing.Point(18, 64);
      this.SetCPMLabel.Name = "SetCPMLabel";
      this.SetCPMLabel.Size = new System.Drawing.Size(69, 15);
      this.SetCPMLabel.TabIndex = 4;
      this.SetCPMLabel.Text = "CPM &Level:";
      //
      // AdvancedAlertButton
      //
      this.AdvancedAlertButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.AdvancedAlertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.AdvancedAlertButton.Location = new System.Drawing.Point(136, 96);
      this.AdvancedAlertButton.Name = "AdvancedAlertButton";
      this.AdvancedAlertButton.Size = new System.Drawing.Size(80, 26);
      this.AdvancedAlertButton.TabIndex = 8;
      this.AdvancedAlertButton.Text = "&Advanced";
      this.AdvancedAlertButton.UseVisualStyleBackColor = true;
      this.AdvancedAlertButton.Click += new System.EventHandler(MForm.AdvancedAlertButton_Click);
      //
      // AlertNumericUpDown
      //
      this.AlertNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.AlertNumericUpDown.Location = new System.Drawing.Point(146, 64);
      this.AlertNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.AlertNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.AlertNumericUpDown.Name = "AlertNumericUpDown";
      this.AlertNumericUpDown.Size = new System.Drawing.Size(68, 21);
      this.AlertNumericUpDown.TabIndex = 5;
      this.AlertNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.AlertNumericUpDown.ValueChanged += new System.EventHandler(MForm.AlertNumericUpDown_ValueChanged);
      //
      // TimeGroupBox
      //
      this.TimeGroupBox.BackColor = System.Drawing.Color.DarkGray;
      this.TimeGroupBox.Controls.Add(this.AMPMLabel);
      this.TimeGroupBox.Controls.Add(this.EndTimeAMPMValLabel);
      this.TimeGroupBox.Controls.Add(this.BeginTimeAMPMValLabel);
      this.TimeGroupBox.Controls.Add(this.ElapsedTimeHourValLabel);
      this.TimeGroupBox.Controls.Add(this.EndTimeHourValLabel);
      this.TimeGroupBox.Controls.Add(this.BeginTimeHourValLabel);
      this.TimeGroupBox.Controls.Add(this.HourLabel);
      this.TimeGroupBox.Controls.Add(this.ElapsedMinValLabel);
      this.TimeGroupBox.Controls.Add(this.ElapsedDayValLabel);
      this.TimeGroupBox.Controls.Add(this.EndDayValLabel);
      this.TimeGroupBox.Controls.Add(this.BeginDayValLabel);
      this.TimeGroupBox.Controls.Add(this.DayLabel);
      this.TimeGroupBox.Controls.Add(this.ElapsedMinutesLabel);
      this.TimeGroupBox.Controls.Add(this.ElapsedTimeLabel);
      this.TimeGroupBox.Controls.Add(this.EndingTimeLabel);
      this.TimeGroupBox.Controls.Add(this.BeginningTimeLabel);
      this.TimeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.TimeGroupBox.ForeColor = System.Drawing.Color.Black;
      this.TimeGroupBox.Location = new System.Drawing.Point(164, 4);
      this.TimeGroupBox.Name = "TimeGroupBox";
      this.TimeGroupBox.Size = new System.Drawing.Size(280, 140);
      this.TimeGroupBox.TabIndex = 1;
      this.TimeGroupBox.TabStop = false;
      this.TimeGroupBox.Text = " Time ";
      //
      // AMPMLabel
      //
      this.AMPMLabel.AutoSize = true;
      this.AMPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.AMPMLabel.Location = new System.Drawing.Point(226, 22);
      this.AMPMLabel.Name = "AMPMLabel";
      this.AMPMLabel.Size = new System.Drawing.Size(47, 15);
      this.AMPMLabel.TabIndex = 24;
      this.AMPMLabel.Text = "AM/PM";
      //
      // EndTimeAMPMValLabel
      //
      this.EndTimeAMPMValLabel.AutoSize = true;
      this.EndTimeAMPMValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.EndTimeAMPMValLabel.Location = new System.Drawing.Point(238, 58);
      this.EndTimeAMPMValLabel.Name = "EndTimeAMPMValLabel";
      this.EndTimeAMPMValLabel.Size = new System.Drawing.Size(14, 15);
      this.EndTimeAMPMValLabel.TabIndex = 23;
      this.EndTimeAMPMValLabel.Text = "0";
      //
      // BeginTimeAMPMValLabel
      //
      this.BeginTimeAMPMValLabel.AutoSize = true;
      this.BeginTimeAMPMValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.BeginTimeAMPMValLabel.Location = new System.Drawing.Point(238, 40);
      this.BeginTimeAMPMValLabel.Name = "BeginTimeAMPMValLabel";
      this.BeginTimeAMPMValLabel.Size = new System.Drawing.Size(14, 15);
      this.BeginTimeAMPMValLabel.TabIndex = 22;
      this.BeginTimeAMPMValLabel.Text = "0";
      //
      // ElapsedTimeHourValLabel
      //
      this.ElapsedTimeHourValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.ElapsedTimeHourValLabel.Location = new System.Drawing.Point(160, 76);
      this.ElapsedTimeHourValLabel.Name = "ElapsedTimeHourValLabel";
      this.ElapsedTimeHourValLabel.Size = new System.Drawing.Size(62, 16);
      this.ElapsedTimeHourValLabel.TabIndex = 12;
      this.ElapsedTimeHourValLabel.Text = "0";
      this.ElapsedTimeHourValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // EndTimeHourValLabel
      //
      this.EndTimeHourValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.EndTimeHourValLabel.Location = new System.Drawing.Point(160, 58);
      this.EndTimeHourValLabel.Name = "EndTimeHourValLabel";
      this.EndTimeHourValLabel.Size = new System.Drawing.Size(62, 16);
      this.EndTimeHourValLabel.TabIndex = 11;
      this.EndTimeHourValLabel.Text = "0";
      this.EndTimeHourValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // BeginTimeHourValLabel
      //
      this.BeginTimeHourValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.BeginTimeHourValLabel.Location = new System.Drawing.Point(160, 40);
      this.BeginTimeHourValLabel.Name = "BeginTimeHourValLabel";
      this.BeginTimeHourValLabel.Size = new System.Drawing.Size(62, 16);
      this.BeginTimeHourValLabel.TabIndex = 10;
      this.BeginTimeHourValLabel.Text = "0";
      this.BeginTimeHourValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // HourLabel
      //
      this.HourLabel.AutoSize = true;
      this.HourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.HourLabel.Location = new System.Drawing.Point(164, 22);
      this.HourLabel.Name = "HourLabel";
      this.HourLabel.Size = new System.Drawing.Size(58, 15);
      this.HourLabel.TabIndex = 9;
      this.HourLabel.Text = "Hr:Mn:Sc";
      this.HourLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // ElapsedMinValLabel
      //
      this.ElapsedMinValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.ElapsedMinValLabel.Location = new System.Drawing.Point(160, 108);
      this.ElapsedMinValLabel.Name = "ElapsedMinValLabel";
      this.ElapsedMinValLabel.Size = new System.Drawing.Size(62, 16);
      this.ElapsedMinValLabel.TabIndex = 8;
      this.ElapsedMinValLabel.Text = "n/a";
      this.ElapsedMinValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // ElapsedDayValLabel
      //
      this.ElapsedDayValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.ElapsedDayValLabel.Location = new System.Drawing.Point(104, 76);
      this.ElapsedDayValLabel.Name = "ElapsedDayValLabel";
      this.ElapsedDayValLabel.Size = new System.Drawing.Size(52, 16);
      this.ElapsedDayValLabel.TabIndex = 7;
      this.ElapsedDayValLabel.Text = "n/a";
      this.ElapsedDayValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // EndDayValLabel
      //
      this.EndDayValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.EndDayValLabel.Location = new System.Drawing.Point(94, 58);
      this.EndDayValLabel.Name = "EndDayValLabel";
      this.EndDayValLabel.Size = new System.Drawing.Size(62, 16);
      this.EndDayValLabel.TabIndex = 6;
      this.EndDayValLabel.Text = "n/a";
      this.EndDayValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // BeginDayValLabel
      //
      this.BeginDayValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.BeginDayValLabel.Location = new System.Drawing.Point(94, 40);
      this.BeginDayValLabel.Name = "BeginDayValLabel";
      this.BeginDayValLabel.Size = new System.Drawing.Size(62, 16);
      this.BeginDayValLabel.TabIndex = 5;
      this.BeginDayValLabel.Text = "n/a";
      this.BeginDayValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // DayLabel
      //
      this.DayLabel.AutoSize = true;
      this.DayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.DayLabel.Location = new System.Drawing.Point(114, 22);
      this.DayLabel.Name = "DayLabel";
      this.DayLabel.Size = new System.Drawing.Size(28, 15);
      this.DayLabel.TabIndex = 4;
      this.DayLabel.Text = "Day";
      //
      // ElapsedMinutesLabel
      //
      this.ElapsedMinutesLabel.AutoSize = true;
      this.ElapsedMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.ElapsedMinutesLabel.Location = new System.Drawing.Point(6, 108);
      this.ElapsedMinutesLabel.Name = "ElapsedMinutesLabel";
      this.ElapsedMinutesLabel.Size = new System.Drawing.Size(102, 15);
      this.ElapsedMinutesLabel.TabIndex = 3;
      this.ElapsedMinutesLabel.Text = "Elapsed Minutes:";
      //
      // ElapsedTimeLabel
      //
      this.ElapsedTimeLabel.AutoSize = true;
      this.ElapsedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.ElapsedTimeLabel.Location = new System.Drawing.Point(6, 76);
      this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
      this.ElapsedTimeLabel.Size = new System.Drawing.Size(86, 15);
      this.ElapsedTimeLabel.TabIndex = 2;
      this.ElapsedTimeLabel.Text = "Elapsed Time:";
      //
      // EndingTimeLabel
      //
      this.EndingTimeLabel.AutoSize = true;
      this.EndingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.EndingTimeLabel.Location = new System.Drawing.Point(6, 58);
      this.EndingTimeLabel.Name = "EndingTimeLabel";
      this.EndingTimeLabel.Size = new System.Drawing.Size(49, 15);
      this.EndingTimeLabel.TabIndex = 1;
      this.EndingTimeLabel.Text = "Ending:";
      //
      // BeginningTimeLabel
      //
      this.BeginningTimeLabel.AutoSize = true;
      this.BeginningTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.BeginningTimeLabel.Location = new System.Drawing.Point(6, 40);
      this.BeginningTimeLabel.Name = "BeginningTimeLabel";
      this.BeginningTimeLabel.Size = new System.Drawing.Size(66, 15);
      this.BeginningTimeLabel.TabIndex = 0;
      this.BeginningTimeLabel.Text = "Beginning:";
      //
      // CountsGroupBox
      //
      this.CountsGroupBox.BackColor = System.Drawing.Color.DarkGray;
      this.CountsGroupBox.Controls.Add(this.AvgCPM1HrValLabel);
      this.CountsGroupBox.Controls.Add(this.AvgCPM1HrLabel);
      this.CountsGroupBox.Controls.Add(this.TotalAverageValLabel);
      this.CountsGroupBox.Controls.Add(this.TotalAverageLabel);
      this.CountsGroupBox.Controls.Add(this.TotalCPMValLabel);
      this.CountsGroupBox.Controls.Add(this.TotalCPMLabel);
      this.CountsGroupBox.Controls.Add(this.MaxCPMValLabel);
      this.CountsGroupBox.Controls.Add(this.MaximumCPMLabel);
      this.CountsGroupBox.Controls.Add(this.MinCPMValLabel);
      this.CountsGroupBox.Controls.Add(this.MinimumCPMLabel);
      this.CountsGroupBox.Controls.Add(this.AvgCPMValLabel);
      this.CountsGroupBox.Controls.Add(this.AvgCPMLabel);
      this.CountsGroupBox.Controls.Add(this.LastCPMLabel);
      this.CountsGroupBox.Controls.Add(this.LastCPMValLabel);
      this.CountsGroupBox.Controls.Add(this.CurrentCPMValLabel);
      this.CountsGroupBox.Controls.Add(this.CurrentCPMLabel);
      this.CountsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.CountsGroupBox.ForeColor = System.Drawing.Color.Black;
      this.CountsGroupBox.Location = new System.Drawing.Point(4, 4);
      this.CountsGroupBox.Name = "CountsGroupBox";
      this.CountsGroupBox.Size = new System.Drawing.Size(154, 158);
      this.CountsGroupBox.TabIndex = 0;
      this.CountsGroupBox.TabStop = false;
      this.CountsGroupBox.Text = " Counts Per Minute ";
      //
      // AvgCPM1HrValLabel
      //
      this.AvgCPM1HrValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.AvgCPM1HrValLabel.Location = new System.Drawing.Point(92, 102);
      this.AvgCPM1HrValLabel.Name = "AvgCPM1HrValLabel";
      this.AvgCPM1HrValLabel.Size = new System.Drawing.Size(58, 16);
      this.AvgCPM1HrValLabel.TabIndex = 22;
      this.AvgCPM1HrValLabel.Text = "0";
      this.AvgCPM1HrValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // AvgCPM1HrLabel
      //
      this.AvgCPM1HrLabel.AutoSize = true;
      this.AvgCPM1HrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.AvgCPM1HrLabel.Location = new System.Drawing.Point(4, 102);
      this.AvgCPM1HrLabel.Name = "AvgCPM1HrLabel";
      this.AvgCPM1HrLabel.Size = new System.Drawing.Size(77, 15);
      this.AvgCPM1HrLabel.TabIndex = 21;
      this.AvgCPM1HrLabel.Text = "Avg (1 Hour):";
      //
      // TotalAverageValLabel
      //
      this.TotalAverageValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.TotalAverageValLabel.Location = new System.Drawing.Point(92, 86);
      this.TotalAverageValLabel.Name = "TotalAverageValLabel";
      this.TotalAverageValLabel.Size = new System.Drawing.Size(58, 16);
      this.TotalAverageValLabel.TabIndex = 20;
      this.TotalAverageValLabel.Text = "15";
      this.TotalAverageValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // TotalAverageLabel
      //
      this.TotalAverageLabel.AutoSize = true;
      this.TotalAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.TotalAverageLabel.Location = new System.Drawing.Point(4, 86);
      this.TotalAverageLabel.Name = "TotalAverageLabel";
      this.TotalAverageLabel.Size = new System.Drawing.Size(54, 15);
      this.TotalAverageLabel.TabIndex = 19;
      this.TotalAverageLabel.Text = "Average:";
      //
      // TotalCPMValLabel
      //
      this.TotalCPMValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.TotalCPMValLabel.Location = new System.Drawing.Point(92, 138);
      this.TotalCPMValLabel.Name = "TotalCPMValLabel";
      this.TotalCPMValLabel.Size = new System.Drawing.Size(58, 16);
      this.TotalCPMValLabel.TabIndex = 18;
      this.TotalCPMValLabel.Text = "45";
      this.TotalCPMValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // TotalCPMLabel
      //
      this.TotalCPMLabel.AutoSize = true;
      this.TotalCPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.TotalCPMLabel.Location = new System.Drawing.Point(4, 138);
      this.TotalCPMLabel.Name = "TotalCPMLabel";
      this.TotalCPMLabel.Size = new System.Drawing.Size(78, 15);
      this.TotalCPMLabel.TabIndex = 17;
      this.TotalCPMLabel.Text = "Total Counts:";
      //
      // MaxCPMValLabel
      //
      this.MaxCPMValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.MaxCPMValLabel.Location = new System.Drawing.Point(92, 66);
      this.MaxCPMValLabel.Name = "MaxCPMValLabel";
      this.MaxCPMValLabel.Size = new System.Drawing.Size(58, 16);
      this.MaxCPMValLabel.TabIndex = 15;
      this.MaxCPMValLabel.Text = "45";
      this.MaxCPMValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // MaximumCPMLabel
      //
      this.MaximumCPMLabel.AutoSize = true;
      this.MaximumCPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.MaximumCPMLabel.Location = new System.Drawing.Point(4, 66);
      this.MaximumCPMLabel.Name = "MaximumCPMLabel";
      this.MaximumCPMLabel.Size = new System.Drawing.Size(66, 15);
      this.MaximumCPMLabel.TabIndex = 14;
      this.MaximumCPMLabel.Text = "Maximum:";
      //
      // MinCPMValLabel
      //
      this.MinCPMValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.MinCPMValLabel.Location = new System.Drawing.Point(92, 50);
      this.MinCPMValLabel.Name = "MinCPMValLabel";
      this.MinCPMValLabel.Size = new System.Drawing.Size(58, 16);
      this.MinCPMValLabel.TabIndex = 12;
      this.MinCPMValLabel.Text = "23";
      this.MinCPMValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // MinimumCPMLabel
      //
      this.MinimumCPMLabel.AutoSize = true;
      this.MinimumCPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.MinimumCPMLabel.Location = new System.Drawing.Point(4, 50);
      this.MinimumCPMLabel.Name = "MinimumCPMLabel";
      this.MinimumCPMLabel.Size = new System.Drawing.Size(63, 15);
      this.MinimumCPMLabel.TabIndex = 11;
      this.MinimumCPMLabel.Text = "Minimum:";
      //
      // AvgCPMValLabel
      //
      this.AvgCPMValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.AvgCPMValLabel.Location = new System.Drawing.Point(92, 118);
      this.AvgCPMValLabel.Name = "AvgCPMValLabel";
      this.AvgCPMValLabel.Size = new System.Drawing.Size(58, 16);
      this.AvgCPMValLabel.TabIndex = 9;
      this.AvgCPMValLabel.Text = "12";
      this.AvgCPMValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // AvgCPMLabel
      //
      this.AvgCPMLabel.AutoSize = true;
      this.AvgCPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.AvgCPMLabel.Location = new System.Drawing.Point(4, 118);
      this.AvgCPMLabel.Name = "AvgCPMLabel";
      this.AvgCPMLabel.Size = new System.Drawing.Size(78, 15);
      this.AvgCPMLabel.TabIndex = 8;
      this.AvgCPMLabel.Text = "Avg (10 min):";
      //
      // LastCPMLabel
      //
      this.LastCPMLabel.AutoSize = true;
      this.LastCPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.LastCPMLabel.Location = new System.Drawing.Point(4, 34);
      this.LastCPMLabel.Name = "LastCPMLabel";
      this.LastCPMLabel.Size = new System.Drawing.Size(63, 15);
      this.LastCPMLabel.TabIndex = 7;
      this.LastCPMLabel.Text = "Last CPM:";
      //
      // LastCPMValLabel
      //
      this.LastCPMValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.LastCPMValLabel.Location = new System.Drawing.Point(92, 34);
      this.LastCPMValLabel.Name = "LastCPMValLabel";
      this.LastCPMValLabel.Size = new System.Drawing.Size(58, 16);
      this.LastCPMValLabel.TabIndex = 5;
      this.LastCPMValLabel.Text = "56";
      this.LastCPMValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // CurrentCPMValLabel
      //
      this.CurrentCPMValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.CurrentCPMValLabel.Location = new System.Drawing.Point(92, 18);
      this.CurrentCPMValLabel.Name = "CurrentCPMValLabel";
      this.CurrentCPMValLabel.Size = new System.Drawing.Size(58, 16);
      this.CurrentCPMValLabel.TabIndex = 3;
      this.CurrentCPMValLabel.Text = "12";
      this.CurrentCPMValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      //
      // CurrentCPMLabel
      //
      this.CurrentCPMLabel.AutoSize = true;
      this.CurrentCPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.CurrentCPMLabel.Location = new System.Drawing.Point(4, 18);
      this.CurrentCPMLabel.Name = "CurrentCPMLabel";
      this.CurrentCPMLabel.Size = new System.Drawing.Size(50, 15);
      this.CurrentCPMLabel.TabIndex = 0;
      this.CurrentCPMLabel.Text = "Current:";
      //
      // GraphPanel
      //
      this.GraphPanel.BackColor = System.Drawing.Color.Blue;
      this.GraphPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.GraphPanel.Controls.Add(this.ChatPopupButton);
      this.GraphPanel.Controls.Add(this.ActiveGraphPanel);
      this.GraphPanel.Controls.Add(this.MapLegendPictureBox);
      this.GraphPanel.Controls.Add(this.NuclearPictureBox);
      this.GraphPanel.Controls.Add(this.GraphPictureBox1);
      this.GraphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GraphPanel.Location = new System.Drawing.Point(0, 240);
      this.GraphPanel.Name = "GraphPanel";
      this.GraphPanel.Size = new System.Drawing.Size(962, 265);
      this.GraphPanel.TabIndex = 3;
      //
      // ChatPopupButton
      //
      this.ChatPopupButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ChatPopupButton.FlatAppearance.BorderSize = 0;
      this.ChatPopupButton.Image = ((System.Drawing.Image)(resources.GetObject("ChatPopupButton.Image")));
      this.ChatPopupButton.Location = new System.Drawing.Point(54, 40);
      this.ChatPopupButton.Name = "ChatPopupButton";
      this.ChatPopupButton.Size = new System.Drawing.Size(76, 70);
      this.ChatPopupButton.TabIndex = 6;
      this.ChatPopupButton.UseVisualStyleBackColor = true;
      this.ChatPopupButton.Click += new System.EventHandler(MForm.ChatPopupButton_Click);
      //
      // ActiveGraphPanel
      //
      this.ActiveGraphPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ActiveGraphPanel.Controls.Add(this.ActiveGraphDrawPanel);
      this.ActiveGraphPanel.Location = new System.Drawing.Point(505, 82);
      this.ActiveGraphPanel.Name = "ActiveGraphPanel";
      this.ActiveGraphPanel.Size = new System.Drawing.Size(213, 120);
      this.ActiveGraphPanel.TabIndex = 3;
      //
      // ActiveGraphDrawPanel
      //
      this.ActiveGraphDrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ActiveGraphDrawPanel.Controls.Add(this.ActiveGraphClosePanel);
      this.ActiveGraphDrawPanel.Controls.Add(this.ActiveGraphPictureBox);
      this.ActiveGraphDrawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ActiveGraphDrawPanel.Location = new System.Drawing.Point(0, 0);
      this.ActiveGraphDrawPanel.Name = "ActiveGraphDrawPanel";
      this.ActiveGraphDrawPanel.Size = new System.Drawing.Size(211, 118);
      this.ActiveGraphDrawPanel.TabIndex = 1;
      //
      // ActiveGraphClosePanel
      //
      this.ActiveGraphClosePanel.BackColor = System.Drawing.Color.LightGray;
      this.ActiveGraphClosePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ActiveGraphClosePanel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ActiveGraphClosePanel.Location = new System.Drawing.Point(0, 92);
      this.ActiveGraphClosePanel.Name = "ActiveGraphClosePanel";
      this.ActiveGraphClosePanel.Size = new System.Drawing.Size(16, 16);
      this.ActiveGraphClosePanel.TabIndex = 0;
      this.ActiveGraphClosePanel.Click += new System.EventHandler(MForm.CloseActiveGraphButton_Click);
      this.ActiveGraphClosePanel.Paint += new System.Windows.Forms.PaintEventHandler(MForm.ActiveGraphClosePanel_Paint);
      //
      // ActiveGraphPictureBox
      //
      this.ActiveGraphPictureBox.BackColor = System.Drawing.Color.White;
      this.ActiveGraphPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ActiveGraphPictureBox.Location = new System.Drawing.Point(0, 0);
      this.ActiveGraphPictureBox.Name = "ActiveGraphPictureBox";
      this.ActiveGraphPictureBox.Size = new System.Drawing.Size(209, 116);
      this.ActiveGraphPictureBox.TabIndex = 1;
      this.ActiveGraphPictureBox.TabStop = false;
      //
      // MapLegendPictureBox
      //
      this.MapLegendPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MapLegendPictureBox.Image")));
      this.MapLegendPictureBox.Location = new System.Drawing.Point(146, 98);
      this.MapLegendPictureBox.Name = "MapLegendPictureBox";
      this.MapLegendPictureBox.Size = new System.Drawing.Size(276, 82);
      this.MapLegendPictureBox.TabIndex = 2;
      this.MapLegendPictureBox.TabStop = false;
      //
      // NuclearPictureBox
      //
      this.NuclearPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NuclearPictureBox.Image")));
      this.NuclearPictureBox.Location = new System.Drawing.Point(428, 58);
      this.NuclearPictureBox.Name = "NuclearPictureBox";
      this.NuclearPictureBox.Size = new System.Drawing.Size(24, 34);
      this.NuclearPictureBox.TabIndex = 1;
      this.NuclearPictureBox.TabStop = false;
      //
      // GraphPictureBox1
      //
      this.GraphPictureBox1.BackColor = System.Drawing.Color.White;
      this.GraphPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GraphPictureBox1.Location = new System.Drawing.Point(0, 0);
      this.GraphPictureBox1.Name = "GraphPictureBox1";
      this.GraphPictureBox1.Size = new System.Drawing.Size(962, 265);
      this.GraphPictureBox1.TabIndex = 4;
      this.GraphPictureBox1.TabStop = false;
      //
      // UpdateDisplayTimer
      //
      this.UpdateDisplayTimer.Tick += new System.EventHandler(MForm.UpdateDisplayTimer_Tick);
      //
      // LEDBlinkTimer
      //
      this.LEDBlinkTimer.Tick += new System.EventHandler(MForm.LEDBlinkTimer_Tick);
      //
      // SingleInstanceTimer
      //
      this.SingleInstanceTimer.Tick += new System.EventHandler(MForm.SingleInstanceTimer_Tick);
      //
      // notifyIcon1
      //
      this.notifyIcon1.BalloonTipText = "GeigerGraph";
      this.notifyIcon1.BalloonTipTitle = "GeigerGraph";
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "GeigerGraph";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.Click += new System.EventHandler(MForm.notifyIcon1_Click);
      this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(MForm.notifyIcon1_MouseDown);
      //
      // TwoMinuteGuideTimer
      //
      this.TwoMinuteGuideTimer.Tick += new System.EventHandler(MForm.TwoMinuteGuideTimer_Tick);
      //
      // TaskTrayTimer
      //
      this.TaskTrayTimer.Tick += new System.EventHandler(MForm.TaskTrayTimer_Tick);
      //
      // StartAlertsTimer
      //
      this.StartAlertsTimer.Tick += new System.EventHandler(MForm.StartAlertsTimer_Tick);
      //
      // printDialog1
      //
      this.printDialog1.Document = this.ScreenPrintDocument;
      this.printDialog1.UseEXDialog = true;
      //
      // ScreenPrintDocument
      //
      this.ScreenPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(MForm.ScreenPrintDocument_PrintPage);
      //
      // ShowTipsTimer
      //
      this.ShowTipsTimer.Tick += new System.EventHandler(MForm.ShowTipsTimer_Tick);
      //
      // MapDataTimer
      //
      this.MapDataTimer.Tick += new System.EventHandler(MForm.MapDataTimer_Tick);
      //
      // CheckChatTimer
      //
      this.CheckChatTimer.Tick += new System.EventHandler(MForm.CheckChatTimer_Tick);
      //
      // OpenFileDialog1
      //
      this.OpenFileDialog1.FileName = "openFileDialog1";
      //
      // AlertContextMenuStrip
      //
      this.AlertContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.AlertContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testAlertSoundToolStripMenuItem,
            this.testRemoteAlertSoundToolStripMenuItem});
      this.AlertContextMenuStrip.Name = "AlertContextMenuStrip";
      this.AlertContextMenuStrip.Size = new System.Drawing.Size(358, 76);
      //
      // testAlertSoundToolStripMenuItem
      //
      this.testAlertSoundToolStripMenuItem.Name = "testAlertSoundToolStripMenuItem";
      this.testAlertSoundToolStripMenuItem.Size = new System.Drawing.Size(357, 36);
      this.testAlertSoundToolStripMenuItem.Text = "Test &Alert Sound";
      this.testAlertSoundToolStripMenuItem.Click += new System.EventHandler(MForm.testAlertSoundToolStripMenuItem_Click);
      //
      // testRemoteAlertSoundToolStripMenuItem
      //
      this.testRemoteAlertSoundToolStripMenuItem.Name = "testRemoteAlertSoundToolStripMenuItem";
      this.testRemoteAlertSoundToolStripMenuItem.Size = new System.Drawing.Size(357, 36);
      this.testRemoteAlertSoundToolStripMenuItem.Text = "Test &Remote Alert Sound";
      this.testRemoteAlertSoundToolStripMenuItem.Click += new System.EventHandler(MForm.testRemoteAlertSoundToolStripMenuItem_Click);
      //
      // ShowMainMapTimer
      //
      this.ShowMainMapTimer.Tick += new System.EventHandler(MForm.ShowMainMapTimer_Tick);
      //
      // GeneralCheckTimer
      //
      this.GeneralCheckTimer.Tick += new System.EventHandler(MForm.GeneralCheckTimer_Tick);
      //
      // FolderBrowserDialog1
      //
      this.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
      //
      // MessagesCheckTimer
      //
      this.MessagesCheckTimer.Tick += new System.EventHandler(MForm.MessagesCheckTimer_Tick);
      //
      // RegistrationTimer
      //
      this.RegistrationTimer.Tick += new System.EventHandler(MForm.RegistrationTimer_Tick);
      //
      // SpreadsheetContextMenuStrip
      //
      this.SpreadsheetContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.SpreadsheetContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCurrentSpreadsheetToolStripMenuItem,
            this.viewHistoricalSpreadsheetToolStripMenuItem});
      this.SpreadsheetContextMenuStrip.Name = "SpreadsheetContextMenuStrip";
      this.SpreadsheetContextMenuStrip.Size = new System.Drawing.Size(386, 76);
      //
      // viewCurrentSpreadsheetToolStripMenuItem
      //
      this.viewCurrentSpreadsheetToolStripMenuItem.Name = "viewCurrentSpreadsheetToolStripMenuItem";
      this.viewCurrentSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(385, 36);
      this.viewCurrentSpreadsheetToolStripMenuItem.Text = "View Current Spreadsheet";
      this.viewCurrentSpreadsheetToolStripMenuItem.Click += new System.EventHandler(MForm.viewCurrentSpreadsheetToolStripMenuItem_Click);
      //
      // viewHistoricalSpreadsheetToolStripMenuItem
      //
      this.viewHistoricalSpreadsheetToolStripMenuItem.Name = "viewHistoricalSpreadsheetToolStripMenuItem";
      this.viewHistoricalSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(385, 36);
      this.viewHistoricalSpreadsheetToolStripMenuItem.Text = "View Historical Spreadsheet";
      this.viewHistoricalSpreadsheetToolStripMenuItem.Click += new System.EventHandler(MForm.viewHistoricalSpreadsheetToolStripMenuItem_Click);
      //
      // GG4ImportTimer
      //
      this.GG4ImportTimer.Tick += new System.EventHandler(MForm.GG4ImportTimer_Tick);


      //
      // MainForm
      //
      MForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      MForm.ClientSize = new System.Drawing.Size(962, 505);

      MainPanel.Controls.Add(this.GraphPanel);
      MainPanel.Controls.Add(this.UpperPanel);
      MainPanel.Controls.Add(this.ButtonPanel);
      MainPanel.Controls.Add(this.menuStrip1);


    GraphPictureBox1.Dock = DockStyle.Fill;
*/



      MForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      MForm.ForeColor = System.Drawing.Color.Black;
      MForm.BackColor = System.Drawing.Color.Silver;

//       MForm.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

      MForm.KeyPreview = true;
      MForm.MainMenuStrip = this.menuStrip1;
      MForm.Name = "MainForm";
      MForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      MForm.Text = "GeigerGraph";
      MForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;

/*
      MForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MForm.MainForm_FormClosing);
      MForm.Shown += new System.EventHandler(MForm.MainForm_Shown);
      MForm.KeyDown += new System.Windows.Forms.KeyEventHandler(MForm.MainForm_KeyDown);
      MForm.Resize += new System.EventHandler( MForm.MainForm_Resize);
*/

    // SetTabOrder();
    // SetLocations();

      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();

/*
      this.ButtonPanel.ResumeLayout(false);
      this.ButtonPanel.PerformLayout();
      this.UpperPanel.ResumeLayout(false);
      this.SoundsGroupBox.ResumeLayout(false);
      this.SoundsGroupBox.PerformLayout();
      this.AlertLevelGroupBox.ResumeLayout(false);
      this.AlertLevelGroupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AlertMultNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.AlertNumericUpDown)).EndInit();
      this.TimeGroupBox.ResumeLayout(false);
      this.TimeGroupBox.PerformLayout();
      this.CountsGroupBox.ResumeLayout(false);
      this.CountsGroupBox.PerformLayout();
      this.GraphPanel.ResumeLayout(false);
      this.ActiveGraphPanel.ResumeLayout(false);
      this.ActiveGraphDrawPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ActiveGraphPictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.MapLegendPictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NuclearPictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox1)).EndInit();
      this.AlertContextMenuStrip.ResumeLayout(false);
      this.SpreadsheetContextMenuStrip.ResumeLayout(false);
*/

MainPanel.ResumeLayout(false);
MainPanel.PerformLayout();
}



/*
  private void SetLocations()
    {
    SaveImageButton.Location = new System.
                             Drawing.Point(2, 2);
    IDButton.Location = new System.Drawing.
                                     Point(30, 2);
    HistoricalGraphButton.Location = new System.
                             Drawing.Point(58, 2);
    ShowSpreadSheetButton.Location = new System.
                             Drawing.Point(86, 2);
    ViewReportButton.Location = new System.
                             Drawing.Point(114, 2);
    GoToWebSiteButton.Location = new System.
                            Drawing.Point(142, 2);
    TestAlertSoundButton.Location = new System.
                            Drawing.Point(170, 2);
    PrintButton.Location = new System.
                            Drawing.Point(198, 2);
    AHelpButton.Location = new System.
                            Drawing.Point(226, 2);


    MainMapButton.Location = new System.
                           Drawing.Point(320, 2);
    ViewGraphsButton.Location = new System.
                           Drawing.Point(380, 2);
    TextAlertsButton.Location = new System.
                           Drawing.Point(410, 2);
    DisableSendCPMButton.Location = new System.
                           Drawing.Point(438, 2);


///////////
    UpperPanel.
    CountsGroupBox.
    CurrentCPMLabel.
    CurrentCPMValLabel.
    LastCPMLabel.
    LastCPMValLabel.
    MinCPMValLabel.
    MinimumCPMLabel.
    AvgCPMValLabel.
    AvgCPMLabel.
    TotalCPMValLabel.
    TotalCPMLabel.
    MaxCPMValLabel.
    MaximumCPMLabel.
    TotalAverageValLabel.
    TotalAverageLabel.
    AvgCPM1HrValLabel.
    AvgCPM1HrLabel.
    AMPMLabel.
    TimeGroupBox.
    ElapsedTimeLabel.
    EndingTimeLabel.
    BeginningTimeLabel.
    ElapsedMinValLabel.
    ElapsedDayValLabel.
    EndDayValLabel.
    BeginDayValLabel.
    DayLabel.
    ElapsedMinutesLabel.
    BeginTimeHourValLabel.
    HourLabel.
    ElapsedTimeHourValLabel.
    EndTimeHourValLabel.
    EndTimeAMPMValLabel.
    BeginTimeAMPMValLabel.
    AlertLevelGroupBox.
    LesserOfLabel.
    SetMultLabel.
    AlertMultNumericUpDown.
    SetCPMLabel.
    AlertNumericUpDown.
    EnableAlertPopupCheckBox.
    SeriesAlertLevelCheckBox.
    AdvancedAlertButton.
    SoundsGroupBox.
    PlaySoundsCheckBox.
    SoundBeepRadioButton.
    SoundClickRadioButton.
    GraphOptionsButton.
    ChatPopupButton.
    GraphPanel.
    ActiveGraphPanel.
    ActiveGraphDrawPanel.
    ActiveGraphClosePanel.
    NuclearPictureBox.
    BlinkLEDOffButton.
    BlinkLEDOnButton.
    MapLegendPictureBox.


      this.UniversalChatButton.Location = new System.Drawing.Point(350, 2);
      this.SoundsGroupBox.Location = new System.Drawing.Point(676, 4);
      this.SoundClickRadioButton.Location = new System.Drawing.Point(24, 74);
      this.SoundBeepRadioButton.Location = new System.Drawing.Point(24, 50);
      this.PlaySoundsCheckBox.Location = new System.Drawing.Point(8, 24);
      this.GraphOptionsButton.Location = new System.Drawing.Point(760, 112);
      this.BlinkLEDOffButton.Location = new System.Drawing.Point(722, 132);
      this.BlinkLEDOnButton.Location = new System.Drawing.Point(680, 112);
      this.AlertLevelGroupBox.Location = new System.Drawing.Point(450, 4);
      this.EnableAlertPopupCheckBox.Location = new System.Drawing.Point(6, 86);
      this.SeriesAlertLevelCheckBox.Location = new System.Drawing.Point(6, 110);
      this.LesserOfLabel.Location = new System.Drawing.Point(6, 22);
      this.AlertMultNumericUpDown.Location = new System.Drawing.Point(146, 40);
      this.SetMultLabel.Location = new System.Drawing.Point(18, 42);
      this.SetCPMLabel.Location = new System.Drawing.Point(18, 64);
      this.AdvancedAlertButton.Location = new System.Drawing.Point(136, 96);
      this.AlertNumericUpDown.Location = new System.Drawing.Point(146, 64);
      this.TimeGroupBox.Location = new System.Drawing.Point(164, 4);
      this.AMPMLabel.Location = new System.Drawing.Point(226, 22);
      this.EndTimeAMPMValLabel.Location = new System.Drawing.Point(238, 58);
      this.BeginTimeAMPMValLabel.Location = new System.Drawing.Point(238, 40);
      this.ElapsedTimeHourValLabel.Location = new System.Drawing.Point(160, 76);
      this.EndTimeHourValLabel.Location = new System.Drawing.Point(160, 58);
      this.BeginTimeHourValLabel.Location = new System.Drawing.Point(160, 40);
      this.HourLabel.Location = new System.Drawing.Point(164, 22);
      this.ElapsedMinValLabel.Location = new System.Drawing.Point(160, 108);
      this.ElapsedDayValLabel.Location = new System.Drawing.Point(104, 76);
      this.EndDayValLabel.Location = new System.Drawing.Point(94, 58);
      this.BeginDayValLabel.Location = new System.Drawing.Point(94, 40);
      this.DayLabel.Location = new System.Drawing.Point(114, 22);
      this.ElapsedMinutesLabel.Location = new System.Drawing.Point(6, 108);
      this.ElapsedTimeLabel.Location = new System.Drawing.Point(6, 76);
      this.EndingTimeLabel.Location = new System.Drawing.Point(6, 58);
      this.BeginningTimeLabel.Location = new System.Drawing.Point(6, 40);
      this.CountsGroupBox.Location = new System.Drawing.Point(4, 4);
      this.AvgCPM1HrValLabel.Location = new System.Drawing.Point(92, 102);
      this.AvgCPM1HrLabel.Location = new System.Drawing.Point(4, 102);
      this.TotalAverageValLabel.Location = new System.Drawing.Point(92, 86);
      this.TotalAverageLabel.Location = new System.Drawing.Point(4, 86);
      this.TotalCPMValLabel.Location = new System.Drawing.Point(92, 138);
      this.TotalCPMLabel.Location = new System.Drawing.Point(4, 138);
      this.MaxCPMValLabel.Location = new System.Drawing.Point(92, 66);
      this.MaximumCPMLabel.Location = new System.Drawing.Point(4, 66);
      this.MinCPMValLabel.Location = new System.Drawing.Point(92, 50);
      this.MinimumCPMLabel.Location = new System.Drawing.Point(4, 50);
      this.AvgCPMValLabel.Location = new System.Drawing.Point(92, 118);
      this.AvgCPMLabel.Location = new System.Drawing.Point(4, 118);
      this.LastCPMLabel.Location = new System.Drawing.Point(4, 34);
      this.LastCPMValLabel.Location = new System.Drawing.Point(92, 34);
      this.CurrentCPMValLabel.Location = new System.Drawing.Point(92, 18);
      this.CurrentCPMLabel.Location = new System.Drawing.Point(4, 18);
      this.GraphPanel.Location = new System.Drawing.Point(0, 240);
      this.ChatPopupButton.Location = new System.Drawing.Point(54, 40);
      this.ActiveGraphPanel.Location = new System.Drawing.Point(505, 82);
      this.ActiveGraphDrawPanel.Location = new System.Drawing.Point(0, 0);
      this.ActiveGraphClosePanel.Location = new System.Drawing.Point(0, 92);
      this.ActiveGraphPictureBox.Location = new System.Drawing.Point(0, 0);
      this.MapLegendPictureBox.Location = new System.Drawing.Point(146, 98);
      this.NuclearPictureBox.Location = new System.Drawing.Point(428, 58);
      this.GraphPictureBox1.Location = new System.Drawing.Point(0, 0);
////////////////
    }
*/




/*
  private void SetTabOrder()
    {
    int Index = 0;
    ButtonPanel.TabIndex = Index;
    Index++;
    SaveImageButton.TabIndex = Index;
    Index++;

    IDButton.TabIndex = Index;
    Index++;

    HistoricalGraphButton.TabIndex = Index;
    Index++;
    ShowSpreadSheetButton.TabIndex = Index;
    Index++;
    ViewReportButton.TabIndex = Index;
    Index++;
    GoToWebSiteButton.TabIndex = Index;
    Index++;
    TestAlertSoundButton.TabIndex = Index;
    Index++;
    PrintButton.TabIndex = Index;
    Index++;
    AHelpButton.TabIndex = Index;
    Index++;
    MainMapButton.TabIndex = Index;
    Index++;
    ViewGraphsButton.TabIndex = Index;
    Index++;
    TextAlertsButton.TabIndex = Index;
    Index++;
    DisableSendCPMButton.TabIndex = Index;
    Index++;
    UpperPanel.TabIndex = Index;
    Index++;

    CountsGroupBox.TabIndex = Index;
    Index++;
    CurrentCPMLabel.TabIndex = Index;
    Index++;
    CurrentCPMValLabel.TabIndex = Index;
    Index++;
    LastCPMLabel.TabIndex = Index;
    Index++;
    LastCPMValLabel.TabIndex = Index;
    Index++;
    MinCPMValLabel.TabIndex = Index;
    Index++;
    MinimumCPMLabel.TabIndex = Index;
    Index++;
    AvgCPMValLabel.TabIndex = Index;
    Index++;
    AvgCPMLabel.TabIndex = Index;
    Index++;
    TotalCPMValLabel.TabIndex = Index;
    Index++;
    TotalCPMLabel.TabIndex = Index;
    Index++;
    MaxCPMValLabel.TabIndex = Index;
    Index++;
    MaximumCPMLabel.TabIndex = Index;
    Index++;
    TotalAverageValLabel.TabIndex = Index;
    Index++;
    TotalAverageLabel.TabIndex = Index;
    Index++;
    AvgCPM1HrValLabel.TabIndex = Index;
    Index++;
    AvgCPM1HrLabel.TabIndex = Index;
    Index++;
    AMPMLabel.TabIndex = Index;
    Index++;

    TimeGroupBox.TabIndex = Index;
    Index++;
    ElapsedTimeLabel.TabIndex = Index;
    Index++;
    EndingTimeLabel.TabIndex = Index;
    Index++;
    BeginningTimeLabel.TabIndex = Index;
    Index++;
    ElapsedMinValLabel.TabIndex = Index;
    Index++;
    ElapsedDayValLabel.TabIndex = Index;
    Index++;
    EndDayValLabel.TabIndex = Index;
    Index++;
    BeginDayValLabel.TabIndex = Index;
    Index++;
    DayLabel.TabIndex = Index;
    Index++;
    ElapsedMinutesLabel.TabIndex = Index;
    Index++;
    BeginTimeHourValLabel.TabIndex = Index;
    Index++;
    HourLabel.TabIndex = Index;
    Index++;
    ElapsedTimeHourValLabel.TabIndex = Index;
    Index++;
    EndTimeHourValLabel.TabIndex = Index;
    Index++;
    EndTimeAMPMValLabel.TabIndex = Index;
    Index++;
    BeginTimeAMPMValLabel.TabIndex = Index;
    Index++;

    AlertLevelGroupBox.TabIndex = Index;
    Index++;
    LesserOfLabel.TabIndex = Index;
    Index++;
    SetMultLabel.TabIndex = Index;
    Index++;
    AlertMultNumericUpDown.TabIndex = Index;
    Index++;
    SetCPMLabel.TabIndex = Index;
    Index++;
    AlertNumericUpDown.TabIndex = Index;
    Index++;
    EnableAlertPopupCheckBox.TabIndex = Index;
    Index++;
    SeriesAlertLevelCheckBox.TabIndex = Index;
    Index++;
    AdvancedAlertButton.TabIndex = Index;
    Index++;

    SoundsGroupBox.TabIndex = Index;
    Index++;
    PlaySoundsCheckBox.TabIndex = Index;
    Index++;
    SoundBeepRadioButton.TabIndex = Index;
    Index++;
    SoundClickRadioButton.TabIndex = Index;
    Index++;

    GraphOptionsButton.TabIndex = Index;
    Index++;

    ChatPopupButton.TabIndex = Index;
    Index++;
    GraphPanel.TabIndex = Index;
    Index++;
    ActiveGraphPanel.TabIndex = Index;
    Index++;
    ActiveGraphDrawPanel.TabIndex = Index;
    Index++;
    ActiveGraphClosePanel.TabIndex = Index;
    Index++;
    NuclearPictureBox.TabIndex = Index;
    Index++;
    BlinkLEDOffButton.TabIndex = Index;
    Index++;
    BlinkLEDOnButton.TabIndex = Index;
    Index++;
    MapLegendPictureBox.TabIndex = Index;
    // Index++;
    }
*/






/*
  internal void FreeAll()
    {
    MainPanel.Dispose();

    menuStrip1.Dispose();
    fileToolStripMenuItem.Dispose();
    exitToolStripMenuItem.Dispose();
    userSetupToolStripMenuItem.Dispose();
    viewToolStripMenuItem.Dispose();
    networkToolStripMenuItem.Dispose();
    helpToolStripMenuItem.Dispose();
    clearDataToolStripMenuItem.Dispose();
    saveGraphToolStripMenuItem.Dispose();
    saveScreenToolStripMenuItem.Dispose();
    printGraphToolStripMenuItem.Dispose();
    printScreenToolStripMenuItem.Dispose();
    configureGeigerPortToolStripMenuItem.Dispose();
    identifyMonitoringStationToolStripMenuItem.Dispose();
    configureAlertsToolStripMenuItem.Dispose();
    otherOptionsToolStripMenuItem.Dispose();
    ButtonPanel.Dispose();
    SaveImageButton.Dispose();
    UpperPanel.Dispose();
    CountsGroupBox.Dispose();
    aboutToolStripMenuItem.Dispose();
    GraphPanel.Dispose();
    spreadsheetToolStripMenuItem.Dispose();
    reportToolStripMenuItem.Dispose();
    goToWebSiteToolStripMenuItem.Dispose();
    sendAlertsByTextToolStripMenuItem.Dispose();
    helpNarrativeToolStripMenuItem.Dispose();
    troubleshootNetworkToolStripMenuItem.Dispose();
    licenseAgreementToolStripMenuItem.Dispose();
    AlertLevelGroupBox.Dispose();
    TimeGroupBox.Dispose();
    CurrentCPMLabel.Dispose();
    AlertNumericUpDown.Dispose();
    AdvancedAlertButton.Dispose();
    CurrentCPMValLabel.Dispose();
    LastCPMLabel.Dispose();
    LastCPMValLabel.Dispose();
    showUnicodeTextToolStripMenuItem.Dispose();
    convertMapDataFilesToolStripMenuItem.Dispose();
    troubleshootGeigerCounterToolStripMenuItem.Dispose();
    MinCPMValLabel.Dispose();
    MinimumCPMLabel.Dispose();
    AvgCPMValLabel.Dispose();
    AvgCPMLabel.Dispose();
    TotalCPMValLabel.Dispose();
    TotalCPMLabel.Dispose();
    MaxCPMValLabel.Dispose();
    MaximumCPMLabel.Dispose();
    ElapsedTimeLabel.Dispose();
    EndingTimeLabel.Dispose();
    BeginningTimeLabel.Dispose();
    ElapsedMinValLabel.Dispose();
    ElapsedDayValLabel.Dispose();
    EndDayValLabel.Dispose();
    BeginDayValLabel.Dispose();
    DayLabel.Dispose();
    ElapsedMinutesLabel.Dispose();
    BeginTimeHourValLabel.Dispose();
    HourLabel.Dispose();
    ElapsedTimeHourValLabel.Dispose();
    EndTimeHourValLabel.Dispose();
    UpdateDisplayTimer.Dispose();
    SaveFileDialog1.Dispose();
    BlinkLEDOffButton.Dispose();
    BlinkLEDOnButton.Dispose();
    LEDBlinkTimer.Dispose();
    SingleInstanceTimer.Dispose();
    GraphOptionsButton.Dispose();
    notifyIcon1.Dispose();
    TwoMinuteGuideTimer.Dispose();
    TaskTrayTimer.Dispose();
    StartAlertsTimer.Dispose();
    troubleshootTextAlertsToolStripMenuItem.Dispose();
    readMeToolStripMenuItem.Dispose();
    printDialog1.Dispose();
    ScreenPrintDocument.Dispose();
    ShowTipsTimer.Dispose();
    showOperatingSystemToolStripMenuItem.Dispose();
    MapDataTimer.Dispose();
    MainMapButton.Dispose();
    showMainMapToolStripMenuItem1.Dispose();
    CheckChatTimer.Dispose();
    NuclearPictureBox.Dispose();
    closeAllRemoteGraphsToolStripMenuItem.Dispose();
    ShowSpreadSheetButton.Dispose();
    ViewReportButton.Dispose();
    GoToWebSiteButton.Dispose();
    AHelpButton.Dispose();
    MainToolTip.Dispose();
    TestAlertSoundButton.Dispose();
    openInfoFilesToolStripMenuItem.Dispose();
    OpenFileDialog1.Dispose();
    TextAlertsButton.Dispose();
    IDButton.Dispose();
    TotalAverageValLabel.Dispose();
    TotalAverageLabel.Dispose();
    ViewGraphsButton.Dispose();
    AlertContextMenuStrip.Dispose();
    testAlertSoundToolStripMenuItem.Dispose();
    testRemoteAlertSoundToolStripMenuItem.Dispose();
    viewTrendingGraphsToolStripMenuItem.Dispose();
    PrintButton.Dispose();
    EndTimeAMPMValLabel.Dispose();
    BeginTimeAMPMValLabel.Dispose();
    AvgCPM1HrValLabel.Dispose();
    AvgCPM1HrLabel.Dispose();
    AMPMLabel.Dispose();
    SoundsGroupBox.Dispose();
    PlaySoundsCheckBox.Dispose();
    SoundClickRadioButton.Dispose();
    SoundBeepRadioButton.Dispose();
    SetCPMLabel.Dispose();
    SetMultLabel.Dispose();
    AlertMultNumericUpDown.Dispose();
    configureGraphUploadingToolStripMenuItem.Dispose();
    MapLegendPictureBox.Dispose();
    didYouKnowToolStripMenuItem.Dispose();
    ShowMainMapTimer.Dispose();
    GeneralCheckTimer.Dispose();
    troubleshootFTPToolStripMenuItem.Dispose();
    graphPRMToolStripMenuItem.Dispose();
    readLogDataToolStripMenuItem.Dispose();
    showSecondMapToolStripMenuItem.Dispose();
    seeSubscriptionLevelToolStripMenuItem.Dispose();
    LesserOfLabel.Dispose();
    convertOldGGDataFilesToolStripMenuItem.Dispose();
    FolderBrowserDialog1.Dispose();
    alertLogToolStripMenuItem.Dispose();
    MessagesCheckTimer.Dispose();
    ActiveGraphPanel.Dispose();
    ActiveGraphDrawPanel.Dispose();
    setGraphOptionsToolStripMenuItem.Dispose();
    ActiveGraphClosePanel.Dispose();
    DisableSendCPMButton.Dispose();
    pauseSendCPMDataToolStripMenuItem.Dispose();
    testRSAKeysToolStripMenuItem.Dispose();
    EnableAlertPopupCheckBox.Dispose();
    SeriesAlertLevelCheckBox.Dispose();
    registerGeigerGraphToolStripMenuItem.Dispose();
    DemoModeLabel.Dispose();
    convertAverageDataToolStripMenuItem.Dispose();
    troubleshootDataCablesToolStripMenuItem.Dispose();
    compressHexFilesToolStripMenuItem.Dispose();
    wiGiSettingsToolStripMenuItem.Dispose();
    UniversalChatButton.Dispose();
    liveChatOverTheRadiationNetworkToolStripMenuItem.Dispose();
    GraphPictureBox1.Dispose();
    ActiveGraphPictureBox.Dispose();
    ChatPopupButton.Dispose();
    RegistrationTimer.Dispose();
    graphWiGiToolStripMenuItem.Dispose();
    graphInspectorUSBToolStripMenuItem.Dispose();
    historicalGraphToolStripMenuItem.Dispose();
    configureCOMPortToolStripMenuItem.Dispose();
    historicalSpreadsheetToolStripMenuItem.Dispose();
    SpreadsheetContextMenuStrip.Dispose();
    viewCurrentSpreadsheetToolStripMenuItem.Dispose();
    viewHistoricalSpreadsheetToolStripMenuItem.Dispose();
    getEPARadNetDataToolStripMenuItem.Dispose();
    ePARadNetGraphToolStripMenuItem.Dispose();
    TestVersionLabel.Dispose();
    convertToDailyFilesToolStripMenuItem.Dispose();
    instalFTDIDriverToolStripMenuItem.Dispose();
    HistoricalGraphButton.Dispose();
    GG4ImportTimer.Dispose();
    privacyPolicyToolStripMenuItem.Dispose();
    testHTTPToolStripMenuItem.Dispose();
    }
*/



} // Class

} // Namespace

