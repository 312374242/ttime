using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using UDonkey.Logic;
using UDonkey.RepFile;
using UDonkey.DB;

namespace UDonkey.GUI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{

		private MainFormLogic                  Logic;
		private System.Windows.Forms.MainMenu  MainMenu;
		private System.Windows.Forms.MenuItem  HelpMenuItem;
		private System.Windows.Forms.MenuItem  AboutMenuItem;
		private System.Windows.Forms.MenuItem  UDonkeyMenuItem;
		private System.Windows.Forms.ToolBar ToolBar;
		private System.Windows.Forms.StatusBar MainFormStatusBar;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ToolBarButton toolBarSeparator1;
		private System.Windows.Forms.ToolBarButton scheduleBarButton;
		private System.Windows.Forms.ToolBarButton prevStateButton;
		private System.Windows.Forms.ToolBarButton nextStateButton;
		private System.Windows.Forms.ToolBarButton somethingButton;
		private System.Windows.Forms.ToolBarButton prev10StatesButton;
		private System.Windows.Forms.ToolBarButton next10StatesButton;
		private System.Windows.Forms.TabPage ScheduleTabPage;
		private UDonkey.GUI.ScheduleDataGrid scheduleDataGrid;
		private System.Windows.Forms.TabPage SearchPage;
		private UDonkey.GUI.DBbrowser DBbrowser;
		private System.Windows.Forms.TabPage prefencesPage;
		private UDonkey.GUI.ConfigControl configControl;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.ToolBarButton toolBarSeparator2;
		private System.Windows.Forms.ToolBarButton saveViewButton;
		private System.Windows.Forms.ToolBarButton loadViewButton;
		private System.Windows.Forms.ToolBarButton printButton;
		private System.Windows.Forms.ToolBarButton courseListButton;
		private System.Windows.Forms.ToolBarButton toolBarSeparator3;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem AutoUpdatemenuItem;
		private System.ComponentModel.IContainer components;

		public MainForm( MainFormLogic logic )
		{
			Logic = logic;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.MainMenu = new System.Windows.Forms.MainMenu();
			this.HelpMenuItem = new System.Windows.Forms.MenuItem();
			this.UDonkeyMenuItem = new System.Windows.Forms.MenuItem();
			this.AboutMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.AutoUpdatemenuItem = new System.Windows.Forms.MenuItem();
			this.MainFormStatusBar = new System.Windows.Forms.StatusBar();
			this.ToolBar = new System.Windows.Forms.ToolBar();
			this.scheduleBarButton = new System.Windows.Forms.ToolBarButton();
			this.toolBarSeparator1 = new System.Windows.Forms.ToolBarButton();
			this.prev10StatesButton = new System.Windows.Forms.ToolBarButton();
			this.prevStateButton = new System.Windows.Forms.ToolBarButton();
			this.nextStateButton = new System.Windows.Forms.ToolBarButton();
			this.next10StatesButton = new System.Windows.Forms.ToolBarButton();
			this.toolBarSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.saveViewButton = new System.Windows.Forms.ToolBarButton();
			this.loadViewButton = new System.Windows.Forms.ToolBarButton();
			this.toolBarSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.printButton = new System.Windows.Forms.ToolBarButton();
			this.courseListButton = new System.Windows.Forms.ToolBarButton();
			this.somethingButton = new System.Windows.Forms.ToolBarButton();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.ScheduleTabPage = new System.Windows.Forms.TabPage();
			this.scheduleDataGrid = new UDonkey.GUI.ScheduleDataGrid();
			this.SearchPage = new System.Windows.Forms.TabPage();
			this.DBbrowser = new UDonkey.GUI.DBbrowser();
			this.prefencesPage = new System.Windows.Forms.TabPage();
			this.configControl = new UDonkey.GUI.ConfigControl();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.ScheduleTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).BeginInit();
			this.SearchPage.SuspendLayout();
			this.prefencesPage.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem2,
																					 this.HelpMenuItem});
			// 
			// HelpMenuItem
			// 
			this.HelpMenuItem.Index = 1;
			this.HelpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.UDonkeyMenuItem,
																						 this.AboutMenuItem});
			this.HelpMenuItem.Text = "����";
			// 
			// UDonkeyMenuItem
			// 
			this.UDonkeyMenuItem.Index = 0;
			this.UDonkeyMenuItem.Text = "����� �� �����";
			this.UDonkeyMenuItem.Click += new System.EventHandler(this.UDonkeyMenuItem_Click);
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Index = 1;
			this.AboutMenuItem.Text = "�����";
			this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.AutoUpdatemenuItem});
			this.menuItem2.Text = "����";
			// 
			// AutoUpdatemenuItem
			// 
			this.AutoUpdatemenuItem.Index = 0;
			this.AutoUpdatemenuItem.Text = "����� �������";
			// 
			// MainFormStatusBar
			// 
			this.MainFormStatusBar.Location = new System.Drawing.Point(0, 555);
			this.MainFormStatusBar.Name = "MainFormStatusBar";
			this.MainFormStatusBar.Size = new System.Drawing.Size(920, 22);
			this.MainFormStatusBar.TabIndex = 1;
			this.MainFormStatusBar.Text = "UDonkey";
			// 
			// ToolBar
			// 
			this.ToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					   this.scheduleBarButton,
																					   this.toolBarSeparator1,
																					   this.prev10StatesButton,
																					   this.prevStateButton,
																					   this.nextStateButton,
																					   this.next10StatesButton,
																					   this.toolBarSeparator2,
																					   this.saveViewButton,
																					   this.loadViewButton,
																					   this.toolBarSeparator3,
																					   this.printButton,
																					   this.courseListButton,
																					   this.somethingButton});
			this.ToolBar.ButtonSize = new System.Drawing.Size(91, 38);
			this.ToolBar.DropDownArrows = true;
			this.ToolBar.ImageList = this.imageList;
			this.ToolBar.Location = new System.Drawing.Point(0, 0);
			this.ToolBar.Name = "ToolBar";
			this.ToolBar.ShowToolTips = true;
			this.ToolBar.Size = new System.Drawing.Size(920, 44);
			this.ToolBar.TabIndex = 2;
			this.ToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar_ButtonClick);
			// 
			// scheduleBarButton
			// 
			this.scheduleBarButton.ImageIndex = 0;
			this.scheduleBarButton.Tag = "Scedule";
			this.scheduleBarButton.Text = "��� ������";
			this.scheduleBarButton.ToolTipText = "��� ������";
			// 
			// toolBarSeparator1
			// 
			this.toolBarSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// prev10StatesButton
			// 
			this.prev10StatesButton.Enabled = false;
			this.prev10StatesButton.ImageIndex = 4;
			this.prev10StatesButton.Tag = "Prev10StatesButton";
			this.prev10StatesButton.Text = "10 �����";
			this.prev10StatesButton.ToolTipText = "���� 10 ������ �����";
			// 
			// prevStateButton
			// 
			this.prevStateButton.Enabled = false;
			this.prevStateButton.ImageIndex = 2;
			this.prevStateButton.Tag = "PrevStateButton";
			this.prevStateButton.Text = "������ ������";
			this.prevStateButton.ToolTipText = "������ ������";
			// 
			// nextStateButton
			// 
			this.nextStateButton.Enabled = false;
			this.nextStateButton.ImageIndex = 1;
			this.nextStateButton.Tag = "NextStateButton";
			this.nextStateButton.Text = "������ ����";
			this.nextStateButton.ToolTipText = "������ ����";
			// 
			// next10StatesButton
			// 
			this.next10StatesButton.Enabled = false;
			this.next10StatesButton.ImageIndex = 3;
			this.next10StatesButton.Tag = "Next10StatesButton";
			this.next10StatesButton.Text = "����� 10";
			this.next10StatesButton.ToolTipText = "���� 10 ������ �����";
			// 
			// toolBarSeparator2
			// 
			this.toolBarSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// saveViewButton
			// 
			this.saveViewButton.ImageIndex = 7;
			this.saveViewButton.Tag = "SaveView";
			this.saveViewButton.Text = "���� �����";
			this.saveViewButton.ToolTipText = "���� ����� ������";
			// 
			// loadViewButton
			// 
			this.loadViewButton.ImageIndex = 8;
			this.loadViewButton.Tag = "LoadView";
			this.loadViewButton.Text = "��� �����";
			this.loadViewButton.ToolTipText = "��� ����� �����";
			// 
			// toolBarSeparator3
			// 
			this.toolBarSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// printButton
			// 
			this.printButton.ImageIndex = 9;
			this.printButton.Tag = "Print";
			this.printButton.Text = "���� �����";
			this.printButton.ToolTipText = "���� ������";
			// 
			// courseListButton
			// 
			this.courseListButton.ImageIndex = 10;
			this.courseListButton.Tag = "CourseList";
			this.courseListButton.Text = "����� ������";
			this.courseListButton.ToolTipText = "��� ����� ������";
			// 
			// somethingButton
			// 
			this.somethingButton.Tag = "Something";
			this.somethingButton.Text = "����";
			this.somethingButton.ToolTipText = "����� ���� �� ����";
			this.somethingButton.Visible = false;
			// 
			// imageList
			// 
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ScheduleTabPage
			// 
			this.ScheduleTabPage.Controls.Add(this.scheduleDataGrid);
			this.ScheduleTabPage.ImageIndex = 0;
			this.ScheduleTabPage.Location = new System.Drawing.Point(4, 22);
			this.ScheduleTabPage.Name = "ScheduleTabPage";
			this.ScheduleTabPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ScheduleTabPage.Size = new System.Drawing.Size(912, 485);
			this.ScheduleTabPage.TabIndex = 0;
			this.ScheduleTabPage.Text = "�����";
			// 
			// scheduleDataGrid
			// 
			this.scheduleDataGrid.AllowNavigation = false;
			this.scheduleDataGrid.AllowSorting = false;
			this.scheduleDataGrid.BackgroundColor = System.Drawing.SystemColors.HotTrack;
			this.scheduleDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.scheduleDataGrid.DataMember = "";
			this.scheduleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scheduleDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.scheduleDataGrid.HoverString = "";
			this.scheduleDataGrid.Location = new System.Drawing.Point(0, 0);
			this.scheduleDataGrid.Name = "scheduleDataGrid";
			this.scheduleDataGrid.ReadOnly = true;
			this.scheduleDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.scheduleDataGrid.RowHeadersVisible = false;
			this.scheduleDataGrid.Size = new System.Drawing.Size(912, 485);
			this.scheduleDataGrid.TabIndex = 0;
			// 
			// SearchPage
			// 
			this.SearchPage.Controls.Add(this.DBbrowser);
			this.SearchPage.ImageIndex = 5;
			this.SearchPage.Location = new System.Drawing.Point(4, 22);
			this.SearchPage.Name = "SearchPage";
			this.SearchPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SearchPage.Size = new System.Drawing.Size(912, 485);
			this.SearchPage.TabIndex = 1;
			this.SearchPage.Text = "�����";
			// 
			// DBbrowser
			// 
			this.DBbrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.DBbrowser.AutoScroll = true;
			this.DBbrowser.Course = null;
			this.DBbrowser.FacultyClicked = false;
			this.DBbrowser.Location = new System.Drawing.Point(0, 0);
			this.DBbrowser.Name = "DBbrowser";
			this.DBbrowser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.DBbrowser.SelectedPoints = "0";
			this.DBbrowser.Size = new System.Drawing.Size(912, 480);
			this.DBbrowser.TabIndex = 0;
			// 
			// prefencesPage
			// 
			this.prefencesPage.Controls.Add(this.configControl);
			this.prefencesPage.ImageIndex = 6;
			this.prefencesPage.Location = new System.Drawing.Point(4, 22);
			this.prefencesPage.Name = "prefencesPage";
			this.prefencesPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.prefencesPage.Size = new System.Drawing.Size(912, 485);
			this.prefencesPage.TabIndex = 2;
			this.prefencesPage.Text = "������";
			// 
			// configControl
			// 
			this.configControl.AllowCollisions = false;
			this.configControl.AllowRegSplit = true;
			this.configControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.configControl.AutoScroll = true;
			this.configControl.EndHour = "20";
			this.configControl.ExportLocation = true;
			this.configControl.ExportName = true;
			this.configControl.ExportNumber = true;
			this.configControl.ExportRegNum = true;
			this.configControl.ExportTeacher = false;
			this.configControl.ExportType = true;
			this.configControl.Font = new System.Drawing.Font("David", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.configControl.FreeMonday = false;
			this.configControl.FreeSunday = false;
			this.configControl.FreeThursday = false;
			this.configControl.FreeTuesday = false;
			this.configControl.FreeWednesday = false;
			this.configControl.Friday = false;
			this.configControl.Location = new System.Drawing.Point(0, 0);
			this.configControl.MaxCollisions = 1;
			this.configControl.MaxDailyHours = 0;
			this.configControl.MinDailyHours = 0;
			this.configControl.MinFreeDays = 0;
			this.configControl.Monday = true;
			this.configControl.MondayEndHour = "20";
			this.configControl.MondayStartHour = "8";
			this.configControl.Name = "configControl";
			this.configControl.PrefEndHour = 0;
			this.configControl.PrefFreeDays = 0;
			this.configControl.PrefHoles = 0;
			this.configControl.PrefStartHour = 0;
			this.configControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.configControl.Saturday = false;
			this.configControl.Size = new System.Drawing.Size(912, 485);
			this.configControl.StartHour = "8";
			this.configControl.Sunday = true;
			this.configControl.SundayEndHour = "20";
			this.configControl.SundayStartHour = "8";
			this.configControl.TabIndex = 0;
			this.configControl.TestAlert = true;
			this.configControl.TestInterval = 1;
			this.configControl.Thursday = true;
			this.configControl.ThursdayEndHour = "20";
			this.configControl.ThursdayStartHour = "8";
			this.configControl.Tuesday = true;
			this.configControl.TuesdayEndHour = "20";
			this.configControl.TuesdayStartHour = "8";
			this.configControl.Wednesday = true;
			this.configControl.WednesdayEndHour = "20";
			this.configControl.WednesdayStartHour = "8";
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.ScheduleTabPage);
			this.TabControl.Controls.Add(this.SearchPage);
			this.TabControl.Controls.Add(this.prefencesPage);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.ImageList = this.imageList;
			this.TabControl.ItemSize = new System.Drawing.Size(46, 18);
			this.TabControl.Location = new System.Drawing.Point(0, 44);
			this.TabControl.Name = "TabControl";
			this.TabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(920, 511);
			this.TabControl.TabIndex = 4;
			this.TabControl.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 577);
			this.Controls.Add(this.TabControl);
			this.Controls.Add(this.ToolBar);
			this.Controls.Add(this.MainFormStatusBar);
			this.Menu = this.MainMenu;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "UDonkey";
			this.ScheduleTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).EndInit();
			this.SearchPage.ResumeLayout(false);
			this.prefencesPage.ResumeLayout(false);
			this.TabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		#region Events Handlers
		private void AboutMenuItem_Click(object sender, System.EventArgs e)
		{
			AboutForm form = new AboutForm();
			form.ShowDialog( this );
		}


		private void UDonkeyMenuItem_Click(object sender, System.EventArgs e)
		{
			UDonkeyForm form = new UDonkeyForm();
			form.ShowDialog( this );
		}

		private void ToolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			Logic.ToolBar_ButtonClick( sender, e );
		}
		private void SelectedIndexChanged(object sender, System.EventArgs e)
		{
			TabControl tabs = (TabControl)sender;
			Control control = tabs.Controls[tabs.SelectedIndex];
			tabs.Refresh();
			control.Refresh();
			return;
		}
		#endregion Events Handlers
		public void AddPage( TabPage page )
		{
			this.TabControl.Controls.Add( page );
		}
		public void RemovePage( TabPage page )
		{
			this.TabControl.Controls.Remove( page );
		}

		#region Properties
		public int SelectedTab
		{
			set{ this.TabControl.SelectedIndex = value; }
		}
		public ScheduleDataGrid Grid
		{
			get { return scheduleDataGrid; } 
		}
		public StatusBar StatusBar
		{
			get { return MainFormStatusBar; } 
		}
		public DBbrowser DBBrowserControl
		{
			get{ return DBbrowser; }
		}
		public ToolBar ToolBarControl
		{
			get{ return ToolBar; }
		}
		public ConfigControl ConfigControl
		{
			get{ return configControl; }
		}
		public MenuItem AutoUpdateMenuItem
		{
			get { return AutoUpdatemenuItem; }
		}
		#endregion Properties
	}
}
