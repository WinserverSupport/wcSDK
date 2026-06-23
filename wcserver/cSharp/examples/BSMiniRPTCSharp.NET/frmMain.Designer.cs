using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BSMiniRPT
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	internal partial class frmMain
	{
	#region Windows Form Designer generated code 
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmMain() : base()
		{
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool Disposing)
		{
			if (Disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this._fraNavigation_0 = new System.Windows.Forms.GroupBox();
            this.txtMaxUserCount = new System.Windows.Forms.TextBox();
            this.txtTotalCalls = new System.Windows.Forms.TextBox();
            this.txtTotalUsers = new System.Windows.Forms.TextBox();
            this.txtTotalFiles = new System.Windows.Forms.TextBox();
            this.txtTotalUsersOn = new System.Windows.Forms.TextBox();
            this.txtTotalMsgs = new System.Windows.Forms.TextBox();
            this.txtLanguages = new System.Windows.Forms.TextBox();
            this.txtDoors = new System.Windows.Forms.TextBox();
            this.txtFileGroups = new System.Windows.Forms.TextBox();
            this.txtActiveFileAreas = new System.Windows.Forms.TextBox();
            this.txtConfGroups = new System.Windows.Forms.TextBox();
            this.txtActiveConfs = new System.Windows.Forms.TextBox();
            this.txtTotalSecurity = new System.Windows.Forms.TextBox();
            this.txtTotalFileAreas = new System.Windows.Forms.TextBox();
            this.txtTotalConfs = new System.Windows.Forms.TextBox();
            this.txtServerBuild = new System.Windows.Forms.TextBox();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.txtFirstCall = new System.Windows.Forms.TextBox();
            this.txtSysop = new System.Windows.Forms.TextBox();
            this.txtSystemName = new System.Windows.Forms.TextBox();
            this._lblTitle_1 = new System.Windows.Forms.Label();
            this._lblInfo_4 = new System.Windows.Forms.Label();
            this._lblInfo_3 = new System.Windows.Forms.Label();
            this._lblInfo_2 = new System.Windows.Forms.Label();
            this._lblInfo_1 = new System.Windows.Forms.Label();
            this._lblCaption_20 = new System.Windows.Forms.Label();
            this._lblCaption_19 = new System.Windows.Forms.Label();
            this._lblCaption_18 = new System.Windows.Forms.Label();
            this._lblCaption_17 = new System.Windows.Forms.Label();
            this._lblCaption_16 = new System.Windows.Forms.Label();
            this._lblCaption_15 = new System.Windows.Forms.Label();
            this._lblCaption_14 = new System.Windows.Forms.Label();
            this._lblCaption_13 = new System.Windows.Forms.Label();
            this._lblCaption_12 = new System.Windows.Forms.Label();
            this._lblCaption_11 = new System.Windows.Forms.Label();
            this._lblCaption_10 = new System.Windows.Forms.Label();
            this._lblCaption_9 = new System.Windows.Forms.Label();
            this._lblCaption_8 = new System.Windows.Forms.Label();
            this._lblCaption_7 = new System.Windows.Forms.Label();
            this._lblCaption_0 = new System.Windows.Forms.Label();
            this._lblCaption_1 = new System.Windows.Forms.Label();
            this._lblCaption_2 = new System.Windows.Forms.Label();
            this._lblCaption_3 = new System.Windows.Forms.Label();
            this._lblCaption_4 = new System.Windows.Forms.Label();
            this._lblCaption_5 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this._fraNavigation_1 = new System.Windows.Forms.GroupBox();
            this.lvwUsers = new System.Windows.Forms.ListView();
            this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglMain = new System.Windows.Forms.ImageList(this.components);
            this.pbUsers = new System.Windows.Forms.ProgressBar();
            this.cmdUsersRefresh = new System.Windows.Forms.Button();
            this.cmdUsersOpen = new System.Windows.Forms.Button();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this._fraNavigation_2 = new System.Windows.Forms.GroupBox();
            this.pbMsgs = new System.Windows.Forms.ProgressBar();
            this.lvwMsgs = new System.Windows.Forms.ListView();
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMSGBody = new System.Windows.Forms.TextBox();
            this.cmdMsgDelete = new System.Windows.Forms.Button();
            this.cmdMsgNew = new System.Windows.Forms.Button();
            this.cmbMAreas = new System.Windows.Forms.ComboBox();
            this.cmdMsgRefresh = new System.Windows.Forms.Button();
            this.cmdMsgOpen = new System.Windows.Forms.Button();
            this.cmbMGroups = new System.Windows.Forms.ComboBox();
            this._lblMessages_1 = new System.Windows.Forms.Label();
            this._lblMessages_0 = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this._fraNavigation_3 = new System.Windows.Forms.GroupBox();
            this.pbFiles = new System.Windows.Forms.ProgressBar();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFileDesc = new System.Windows.Forms.TextBox();
            this.cmbFGroup = new System.Windows.Forms.ComboBox();
            this.cmdFileOpen = new System.Windows.Forms.Button();
            this.cmdFileRefresh = new System.Windows.Forms.Button();
            this.cmbFArea = new System.Windows.Forms.ComboBox();
            this._lblFiles_1 = new System.Windows.Forms.Label();
            this._lblFiles_0 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this._fraNavigation_0.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this._fraNavigation_1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this._fraNavigation_2.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this._fraNavigation_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.TabPage1);
            this.tabMain.Controls.Add(this.TabPage2);
            this.tabMain.Controls.Add(this.TabPage3);
            this.tabMain.Controls.Add(this.TabPage4);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(609, 500);
            this.tabMain.TabIndex = 14;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this._fraNavigation_0);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(601, 474);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Tag = "INFO";
            this.TabPage1.Text = "Information";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // _fraNavigation_0
            // 
            this._fraNavigation_0.BackColor = System.Drawing.Color.Khaki;
            this._fraNavigation_0.Controls.Add(this.txtMaxUserCount);
            this._fraNavigation_0.Controls.Add(this.txtTotalCalls);
            this._fraNavigation_0.Controls.Add(this.txtTotalUsers);
            this._fraNavigation_0.Controls.Add(this.txtTotalFiles);
            this._fraNavigation_0.Controls.Add(this.txtTotalUsersOn);
            this._fraNavigation_0.Controls.Add(this.txtTotalMsgs);
            this._fraNavigation_0.Controls.Add(this.txtLanguages);
            this._fraNavigation_0.Controls.Add(this.txtDoors);
            this._fraNavigation_0.Controls.Add(this.txtFileGroups);
            this._fraNavigation_0.Controls.Add(this.txtActiveFileAreas);
            this._fraNavigation_0.Controls.Add(this.txtConfGroups);
            this._fraNavigation_0.Controls.Add(this.txtActiveConfs);
            this._fraNavigation_0.Controls.Add(this.txtTotalSecurity);
            this._fraNavigation_0.Controls.Add(this.txtTotalFileAreas);
            this._fraNavigation_0.Controls.Add(this.txtTotalConfs);
            this._fraNavigation_0.Controls.Add(this.txtServerBuild);
            this._fraNavigation_0.Controls.Add(this.txtRegNum);
            this._fraNavigation_0.Controls.Add(this.txtFirstCall);
            this._fraNavigation_0.Controls.Add(this.txtSysop);
            this._fraNavigation_0.Controls.Add(this.txtSystemName);
            this._fraNavigation_0.Controls.Add(this._lblTitle_1);
            this._fraNavigation_0.Controls.Add(this._lblInfo_4);
            this._fraNavigation_0.Controls.Add(this._lblInfo_3);
            this._fraNavigation_0.Controls.Add(this._lblInfo_2);
            this._fraNavigation_0.Controls.Add(this._lblInfo_1);
            this._fraNavigation_0.Controls.Add(this._lblCaption_20);
            this._fraNavigation_0.Controls.Add(this._lblCaption_19);
            this._fraNavigation_0.Controls.Add(this._lblCaption_18);
            this._fraNavigation_0.Controls.Add(this._lblCaption_17);
            this._fraNavigation_0.Controls.Add(this._lblCaption_16);
            this._fraNavigation_0.Controls.Add(this._lblCaption_15);
            this._fraNavigation_0.Controls.Add(this._lblCaption_14);
            this._fraNavigation_0.Controls.Add(this._lblCaption_13);
            this._fraNavigation_0.Controls.Add(this._lblCaption_12);
            this._fraNavigation_0.Controls.Add(this._lblCaption_11);
            this._fraNavigation_0.Controls.Add(this._lblCaption_10);
            this._fraNavigation_0.Controls.Add(this._lblCaption_9);
            this._fraNavigation_0.Controls.Add(this._lblCaption_8);
            this._fraNavigation_0.Controls.Add(this._lblCaption_7);
            this._fraNavigation_0.Controls.Add(this._lblCaption_0);
            this._fraNavigation_0.Controls.Add(this._lblCaption_1);
            this._fraNavigation_0.Controls.Add(this._lblCaption_2);
            this._fraNavigation_0.Controls.Add(this._lblCaption_3);
            this._fraNavigation_0.Controls.Add(this._lblCaption_4);
            this._fraNavigation_0.Controls.Add(this._lblCaption_5);
            this._fraNavigation_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fraNavigation_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._fraNavigation_0.Location = new System.Drawing.Point(3, 3);
            this._fraNavigation_0.Name = "_fraNavigation_0";
            this._fraNavigation_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._fraNavigation_0.Size = new System.Drawing.Size(595, 468);
            this._fraNavigation_0.TabIndex = 14;
            this._fraNavigation_0.TabStop = false;
            this._fraNavigation_0.Enter += new System.EventHandler(this._fraNavigation_0_Enter);
            // 
            // txtMaxUserCount
            // 
            this.txtMaxUserCount.Location = new System.Drawing.Point(473, 343);
            this.txtMaxUserCount.Name = "txtMaxUserCount";
            this.txtMaxUserCount.ReadOnly = true;
            this.txtMaxUserCount.Size = new System.Drawing.Size(87, 21);
            this.txtMaxUserCount.TabIndex = 83;
            // 
            // txtTotalCalls
            // 
            this.txtTotalCalls.Location = new System.Drawing.Point(473, 316);
            this.txtTotalCalls.Name = "txtTotalCalls";
            this.txtTotalCalls.ReadOnly = true;
            this.txtTotalCalls.Size = new System.Drawing.Size(87, 21);
            this.txtTotalCalls.TabIndex = 82;
            // 
            // txtTotalUsers
            // 
            this.txtTotalUsers.Location = new System.Drawing.Point(283, 343);
            this.txtTotalUsers.Name = "txtTotalUsers";
            this.txtTotalUsers.ReadOnly = true;
            this.txtTotalUsers.Size = new System.Drawing.Size(87, 21);
            this.txtTotalUsers.TabIndex = 81;
            // 
            // txtTotalFiles
            // 
            this.txtTotalFiles.Location = new System.Drawing.Point(283, 316);
            this.txtTotalFiles.Name = "txtTotalFiles";
            this.txtTotalFiles.ReadOnly = true;
            this.txtTotalFiles.Size = new System.Drawing.Size(87, 21);
            this.txtTotalFiles.TabIndex = 80;
            // 
            // txtTotalUsersOn
            // 
            this.txtTotalUsersOn.Location = new System.Drawing.Point(93, 343);
            this.txtTotalUsersOn.Name = "txtTotalUsersOn";
            this.txtTotalUsersOn.ReadOnly = true;
            this.txtTotalUsersOn.Size = new System.Drawing.Size(87, 21);
            this.txtTotalUsersOn.TabIndex = 79;
            // 
            // txtTotalMsgs
            // 
            this.txtTotalMsgs.Location = new System.Drawing.Point(93, 316);
            this.txtTotalMsgs.Name = "txtTotalMsgs";
            this.txtTotalMsgs.ReadOnly = true;
            this.txtTotalMsgs.Size = new System.Drawing.Size(87, 21);
            this.txtTotalMsgs.TabIndex = 78;
            // 
            // txtLanguages
            // 
            this.txtLanguages.Location = new System.Drawing.Point(473, 272);
            this.txtLanguages.Name = "txtLanguages";
            this.txtLanguages.ReadOnly = true;
            this.txtLanguages.Size = new System.Drawing.Size(87, 21);
            this.txtLanguages.TabIndex = 77;
            // 
            // txtDoors
            // 
            this.txtDoors.Location = new System.Drawing.Point(473, 246);
            this.txtDoors.Name = "txtDoors";
            this.txtDoors.ReadOnly = true;
            this.txtDoors.Size = new System.Drawing.Size(87, 21);
            this.txtDoors.TabIndex = 76;
            // 
            // txtFileGroups
            // 
            this.txtFileGroups.Location = new System.Drawing.Point(283, 272);
            this.txtFileGroups.Name = "txtFileGroups";
            this.txtFileGroups.ReadOnly = true;
            this.txtFileGroups.Size = new System.Drawing.Size(87, 21);
            this.txtFileGroups.TabIndex = 75;
            // 
            // txtActiveFileAreas
            // 
            this.txtActiveFileAreas.Location = new System.Drawing.Point(283, 246);
            this.txtActiveFileAreas.Name = "txtActiveFileAreas";
            this.txtActiveFileAreas.ReadOnly = true;
            this.txtActiveFileAreas.Size = new System.Drawing.Size(87, 21);
            this.txtActiveFileAreas.TabIndex = 74;
            // 
            // txtConfGroups
            // 
            this.txtConfGroups.Location = new System.Drawing.Point(93, 272);
            this.txtConfGroups.Name = "txtConfGroups";
            this.txtConfGroups.ReadOnly = true;
            this.txtConfGroups.Size = new System.Drawing.Size(87, 21);
            this.txtConfGroups.TabIndex = 73;
            // 
            // txtActiveConfs
            // 
            this.txtActiveConfs.Location = new System.Drawing.Point(93, 246);
            this.txtActiveConfs.Name = "txtActiveConfs";
            this.txtActiveConfs.ReadOnly = true;
            this.txtActiveConfs.Size = new System.Drawing.Size(87, 21);
            this.txtActiveConfs.TabIndex = 72;
            // 
            // txtTotalSecurity
            // 
            this.txtTotalSecurity.Location = new System.Drawing.Point(473, 219);
            this.txtTotalSecurity.Name = "txtTotalSecurity";
            this.txtTotalSecurity.ReadOnly = true;
            this.txtTotalSecurity.Size = new System.Drawing.Size(87, 21);
            this.txtTotalSecurity.TabIndex = 71;
            // 
            // txtTotalFileAreas
            // 
            this.txtTotalFileAreas.Location = new System.Drawing.Point(283, 219);
            this.txtTotalFileAreas.Name = "txtTotalFileAreas";
            this.txtTotalFileAreas.ReadOnly = true;
            this.txtTotalFileAreas.Size = new System.Drawing.Size(87, 21);
            this.txtTotalFileAreas.TabIndex = 70;
            // 
            // txtTotalConfs
            // 
            this.txtTotalConfs.Location = new System.Drawing.Point(93, 219);
            this.txtTotalConfs.Name = "txtTotalConfs";
            this.txtTotalConfs.ReadOnly = true;
            this.txtTotalConfs.Size = new System.Drawing.Size(87, 21);
            this.txtTotalConfs.TabIndex = 69;
            // 
            // txtServerBuild
            // 
            this.txtServerBuild.Location = new System.Drawing.Point(388, 150);
            this.txtServerBuild.Name = "txtServerBuild";
            this.txtServerBuild.ReadOnly = true;
            this.txtServerBuild.Size = new System.Drawing.Size(167, 21);
            this.txtServerBuild.TabIndex = 68;
            // 
            // txtRegNum
            // 
            this.txtRegNum.Location = new System.Drawing.Point(388, 120);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.ReadOnly = true;
            this.txtRegNum.Size = new System.Drawing.Size(167, 21);
            this.txtRegNum.TabIndex = 67;
            // 
            // txtFirstCall
            // 
            this.txtFirstCall.Location = new System.Drawing.Point(115, 177);
            this.txtFirstCall.Name = "txtFirstCall";
            this.txtFirstCall.ReadOnly = true;
            this.txtFirstCall.Size = new System.Drawing.Size(167, 21);
            this.txtFirstCall.TabIndex = 66;
            // 
            // txtSysop
            // 
            this.txtSysop.Location = new System.Drawing.Point(115, 150);
            this.txtSysop.Name = "txtSysop";
            this.txtSysop.ReadOnly = true;
            this.txtSysop.Size = new System.Drawing.Size(167, 21);
            this.txtSysop.TabIndex = 65;
            // 
            // txtSystemName
            // 
            this.txtSystemName.Location = new System.Drawing.Point(115, 120);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.ReadOnly = true;
            this.txtSystemName.Size = new System.Drawing.Size(167, 21);
            this.txtSystemName.TabIndex = 64;
            // 
            // _lblTitle_1
            // 
            this._lblTitle_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblTitle_1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTitle_1.ForeColor = System.Drawing.Color.SteelBlue;
            this._lblTitle_1.Location = new System.Drawing.Point(16, 35);
            this._lblTitle_1.Name = "_lblTitle_1";
            this._lblTitle_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblTitle_1.Size = new System.Drawing.Size(553, 41);
            this._lblTitle_1.TabIndex = 61;
            this._lblTitle_1.Text = "bsMini Reports C# Example";
            this._lblTitle_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblInfo_4
            // 
            this._lblInfo_4.AutoSize = true;
            this._lblInfo_4.BackColor = System.Drawing.Color.Transparent;
            this._lblInfo_4.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblInfo_4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblInfo_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblInfo_4.Location = new System.Drawing.Point(411, 162);
            this._lblInfo_4.Name = "_lblInfo_4";
            this._lblInfo_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblInfo_4.Size = new System.Drawing.Size(0, 13);
            this._lblInfo_4.TabIndex = 38;
            // 
            // _lblInfo_3
            // 
            this._lblInfo_3.AutoSize = true;
            this._lblInfo_3.BackColor = System.Drawing.Color.Transparent;
            this._lblInfo_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblInfo_3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblInfo_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblInfo_3.Location = new System.Drawing.Point(411, 146);
            this._lblInfo_3.Name = "_lblInfo_3";
            this._lblInfo_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblInfo_3.Size = new System.Drawing.Size(0, 13);
            this._lblInfo_3.TabIndex = 37;
            // 
            // _lblInfo_2
            // 
            this._lblInfo_2.AutoSize = true;
            this._lblInfo_2.BackColor = System.Drawing.Color.Transparent;
            this._lblInfo_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblInfo_2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblInfo_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblInfo_2.Location = new System.Drawing.Point(139, 178);
            this._lblInfo_2.Name = "_lblInfo_2";
            this._lblInfo_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblInfo_2.Size = new System.Drawing.Size(0, 13);
            this._lblInfo_2.TabIndex = 36;
            // 
            // _lblInfo_1
            // 
            this._lblInfo_1.AutoSize = true;
            this._lblInfo_1.BackColor = System.Drawing.Color.Transparent;
            this._lblInfo_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblInfo_1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblInfo_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblInfo_1.Location = new System.Drawing.Point(139, 162);
            this._lblInfo_1.Name = "_lblInfo_1";
            this._lblInfo_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblInfo_1.Size = new System.Drawing.Size(0, 13);
            this._lblInfo_1.TabIndex = 35;
            // 
            // _lblCaption_20
            // 
            this._lblCaption_20.AutoSize = true;
            this._lblCaption_20.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_20.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_20.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_20.Location = new System.Drawing.Point(390, 222);
            this._lblCaption_20.Name = "_lblCaption_20";
            this._lblCaption_20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_20.Size = new System.Drawing.Size(77, 13);
            this._lblCaption_20.TabIndex = 33;
            this._lblCaption_20.Text = "Total Security:";
            this._lblCaption_20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_19
            // 
            this._lblCaption_19.AutoSize = true;
            this._lblCaption_19.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_19.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_19.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_19.Location = new System.Drawing.Point(375, 249);
            this._lblCaption_19.Name = "_lblCaption_19";
            this._lblCaption_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_19.Size = new System.Drawing.Size(92, 13);
            this._lblCaption_19.TabIndex = 32;
            this._lblCaption_19.Text = "Number of Doors:";
            this._lblCaption_19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_18
            // 
            this._lblCaption_18.AutoSize = true;
            this._lblCaption_18.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_18.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_18.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_18.Location = new System.Drawing.Point(404, 275);
            this._lblCaption_18.Name = "_lblCaption_18";
            this._lblCaption_18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_18.Size = new System.Drawing.Size(63, 13);
            this._lblCaption_18.TabIndex = 31;
            this._lblCaption_18.Text = "Languages:";
            this._lblCaption_18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_17
            // 
            this._lblCaption_17.AutoSize = true;
            this._lblCaption_17.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_17.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_17.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_17.Location = new System.Drawing.Point(193, 222);
            this._lblCaption_17.Name = "_lblCaption_17";
            this._lblCaption_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_17.Size = new System.Drawing.Size(84, 13);
            this._lblCaption_17.TabIndex = 30;
            this._lblCaption_17.Text = "Total File areas:";
            this._lblCaption_17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_16
            // 
            this._lblCaption_16.AutoSize = true;
            this._lblCaption_16.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_16.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_16.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_16.Location = new System.Drawing.Point(186, 250);
            this._lblCaption_16.Name = "_lblCaption_16";
            this._lblCaption_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_16.Size = new System.Drawing.Size(91, 13);
            this._lblCaption_16.TabIndex = 29;
            this._lblCaption_16.Text = "Active File Areas:";
            this._lblCaption_16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_15
            // 
            this._lblCaption_15.AutoSize = true;
            this._lblCaption_15.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_15.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_15.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_15.Location = new System.Drawing.Point(187, 275);
            this._lblCaption_15.Name = "_lblCaption_15";
            this._lblCaption_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_15.Size = new System.Drawing.Size(90, 13);
            this._lblCaption_15.TabIndex = 28;
            this._lblCaption_15.Text = "File Area Groups:";
            this._lblCaption_15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_14
            // 
            this._lblCaption_14.AutoSize = true;
            this._lblCaption_14.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_14.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_14.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_14.Location = new System.Drawing.Point(297, 123);
            this._lblCaption_14.Name = "_lblCaption_14";
            this._lblCaption_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_14.Size = new System.Drawing.Size(93, 13);
            this._lblCaption_14.TabIndex = 27;
            this._lblCaption_14.Text = "Registration Num:";
            this._lblCaption_14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_13
            // 
            this._lblCaption_13.AutoSize = true;
            this._lblCaption_13.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_13.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_13.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_13.Location = new System.Drawing.Point(322, 153);
            this._lblCaption_13.Name = "_lblCaption_13";
            this._lblCaption_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_13.Size = new System.Drawing.Size(68, 13);
            this._lblCaption_13.TabIndex = 26;
            this._lblCaption_13.Text = "Server Build:";
            this._lblCaption_13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_12
            // 
            this._lblCaption_12.AutoSize = true;
            this._lblCaption_12.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_12.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_12.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_12.Location = new System.Drawing.Point(407, 319);
            this._lblCaption_12.Name = "_lblCaption_12";
            this._lblCaption_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_12.Size = new System.Drawing.Size(60, 13);
            this._lblCaption_12.TabIndex = 25;
            this._lblCaption_12.Text = "Total Calls:";
            this._lblCaption_12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_11
            // 
            this._lblCaption_11.AutoSize = true;
            this._lblCaption_11.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_11.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_11.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_11.Location = new System.Drawing.Point(379, 346);
            this._lblCaption_11.Name = "_lblCaption_11";
            this._lblCaption_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_11.Size = new System.Drawing.Size(88, 13);
            this._lblCaption_11.TabIndex = 24;
            this._lblCaption_11.Text = "Max User Count:";
            this._lblCaption_11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_10
            // 
            this._lblCaption_10.AutoSize = true;
            this._lblCaption_10.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_10.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_10.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_10.Location = new System.Drawing.Point(218, 319);
            this._lblCaption_10.Name = "_lblCaption_10";
            this._lblCaption_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_10.Size = new System.Drawing.Size(59, 13);
            this._lblCaption_10.TabIndex = 23;
            this._lblCaption_10.Text = "Total Files:";
            this._lblCaption_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_9
            // 
            this._lblCaption_9.AutoSize = true;
            this._lblCaption_9.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_9.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_9.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_9.Location = new System.Drawing.Point(212, 346);
            this._lblCaption_9.Name = "_lblCaption_9";
            this._lblCaption_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_9.Size = new System.Drawing.Size(65, 13);
            this._lblCaption_9.TabIndex = 22;
            this._lblCaption_9.Text = "Total Users:";
            this._lblCaption_9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_8
            // 
            this._lblCaption_8.AutoSize = true;
            this._lblCaption_8.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_8.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_8.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_8.Location = new System.Drawing.Point(2, 319);
            this._lblCaption_8.Name = "_lblCaption_8";
            this._lblCaption_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_8.Size = new System.Drawing.Size(85, 13);
            this._lblCaption_8.TabIndex = 21;
            this._lblCaption_8.Text = "Total Messages:";
            this._lblCaption_8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_7
            // 
            this._lblCaption_7.AutoSize = true;
            this._lblCaption_7.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_7.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_7.Location = new System.Drawing.Point(7, 343);
            this._lblCaption_7.Name = "_lblCaption_7";
            this._lblCaption_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_7.Size = new System.Drawing.Size(82, 13);
            this._lblCaption_7.TabIndex = 20;
            this._lblCaption_7.Text = "Total Users On:";
            this._lblCaption_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_0
            // 
            this._lblCaption_0.AutoSize = true;
            this._lblCaption_0.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_0.Location = new System.Drawing.Point(33, 123);
            this._lblCaption_0.Name = "_lblCaption_0";
            this._lblCaption_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_0.Size = new System.Drawing.Size(76, 13);
            this._lblCaption_0.TabIndex = 19;
            this._lblCaption_0.Text = "System Name:";
            this._lblCaption_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_1
            // 
            this._lblCaption_1.AutoSize = true;
            this._lblCaption_1.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_1.Location = new System.Drawing.Point(37, 153);
            this._lblCaption_1.Name = "_lblCaption_1";
            this._lblCaption_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_1.Size = new System.Drawing.Size(72, 13);
            this._lblCaption_1.TabIndex = 18;
            this._lblCaption_1.Text = "SysOp Name:";
            this._lblCaption_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_2
            // 
            this._lblCaption_2.AutoSize = true;
            this._lblCaption_2.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_2.Location = new System.Drawing.Point(19, 177);
            this._lblCaption_2.Name = "_lblCaption_2";
            this._lblCaption_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_2.Size = new System.Drawing.Size(90, 13);
            this._lblCaption_2.TabIndex = 17;
            this._lblCaption_2.Text = "First System Call:";
            this._lblCaption_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_3
            // 
            this._lblCaption_3.AutoSize = true;
            this._lblCaption_3.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_3.Location = new System.Drawing.Point(21, 222);
            this._lblCaption_3.Name = "_lblCaption_3";
            this._lblCaption_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_3.Size = new System.Drawing.Size(66, 13);
            this._lblCaption_3.TabIndex = 16;
            this._lblCaption_3.Text = "Total Confs:";
            this._lblCaption_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_4
            // 
            this._lblCaption_4.AutoSize = true;
            this._lblCaption_4.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_4.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_4.Location = new System.Drawing.Point(15, 250);
            this._lblCaption_4.Name = "_lblCaption_4";
            this._lblCaption_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_4.Size = new System.Drawing.Size(72, 13);
            this._lblCaption_4.TabIndex = 15;
            this._lblCaption_4.Text = "Active Confs:";
            this._lblCaption_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblCaption_5
            // 
            this._lblCaption_5.AutoSize = true;
            this._lblCaption_5.BackColor = System.Drawing.Color.Transparent;
            this._lblCaption_5.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblCaption_5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCaption_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblCaption_5.Location = new System.Drawing.Point(16, 275);
            this._lblCaption_5.Name = "_lblCaption_5";
            this._lblCaption_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblCaption_5.Size = new System.Drawing.Size(71, 13);
            this._lblCaption_5.TabIndex = 14;
            this._lblCaption_5.Text = "Conf Groups:";
            this._lblCaption_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this._fraNavigation_1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(601, 474);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Tag = "USERS";
            this.TabPage2.Text = "Users";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // _fraNavigation_1
            // 
            this._fraNavigation_1.Controls.Add(this.lvwUsers);
            this._fraNavigation_1.Controls.Add(this.pbUsers);
            this._fraNavigation_1.Controls.Add(this.cmdUsersRefresh);
            this._fraNavigation_1.Controls.Add(this.cmdUsersOpen);
            this._fraNavigation_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fraNavigation_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._fraNavigation_1.Location = new System.Drawing.Point(3, 3);
            this._fraNavigation_1.Name = "_fraNavigation_1";
            this._fraNavigation_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._fraNavigation_1.Size = new System.Drawing.Size(595, 468);
            this._fraNavigation_1.TabIndex = 10;
            this._fraNavigation_1.TabStop = false;
            // 
            // lvwUsers
            // 
            this.lvwUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader12,
            this.ColumnHeader13,
            this.ColumnHeader14,
            this.ColumnHeader15,
            this.ColumnHeader16,
            this.ColumnHeader17});
            this.lvwUsers.FullRowSelect = true;
            this.lvwUsers.GridLines = true;
            this.lvwUsers.HideSelection = false;
            this.lvwUsers.Location = new System.Drawing.Point(8, 33);
            this.lvwUsers.MultiSelect = false;
            this.lvwUsers.Name = "lvwUsers";
            this.lvwUsers.Size = new System.Drawing.Size(577, 404);
            this.lvwUsers.SmallImageList = this.imglMain;
            this.lvwUsers.TabIndex = 75;
            this.lvwUsers.UseCompatibleStateImageBehavior = false;
            this.lvwUsers.View = System.Windows.Forms.View.Details;
            this.lvwUsers.DoubleClick += new System.EventHandler(this.miniRptLvws_DblClick);
            // 
            // ColumnHeader12
            // 
            this.ColumnHeader12.Text = "Login";
            this.ColumnHeader12.Width = 100;
            // 
            // ColumnHeader13
            // 
            this.ColumnHeader13.Text = "ID";
            this.ColumnHeader13.Width = 35;
            // 
            // ColumnHeader14
            // 
            this.ColumnHeader14.Text = "Real Name";
            this.ColumnHeader14.Width = 100;
            // 
            // ColumnHeader15
            // 
            this.ColumnHeader15.Text = "Primary Profile";
            this.ColumnHeader15.Width = 100;
            // 
            // ColumnHeader16
            // 
            this.ColumnHeader16.Text = "First Call";
            this.ColumnHeader16.Width = 100;
            // 
            // ColumnHeader17
            // 
            this.ColumnHeader17.Text = "Last Call";
            this.ColumnHeader17.Width = 100;
            // 
            // imglMain
            // 
            this.imglMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglMain.ImageStream")));
            this.imglMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imglMain.Images.SetKeyName(0, "user business male 1.ico");
            this.imglMain.Images.SetKeyName(1, "Email Read.ico");
            this.imglMain.Images.SetKeyName(2, "document 1.ico");
            // 
            // pbUsers
            // 
            this.pbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUsers.Location = new System.Drawing.Point(8, 12);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(577, 14);
            this.pbUsers.TabIndex = 74;
            // 
            // cmdUsersRefresh
            // 
            this.cmdUsersRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUsersRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUsersRefresh.Location = new System.Drawing.Point(417, 441);
            this.cmdUsersRefresh.Name = "cmdUsersRefresh";
            this.cmdUsersRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUsersRefresh.Size = new System.Drawing.Size(81, 25);
            this.cmdUsersRefresh.TabIndex = 55;
            this.cmdUsersRefresh.Text = "&Refresh";
            this.cmdUsersRefresh.UseVisualStyleBackColor = true;
            this.cmdUsersRefresh.Click += new System.EventHandler(this.miniRptcmdUsers_Click);
            // 
            // cmdUsersOpen
            // 
            this.cmdUsersOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUsersOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUsersOpen.Location = new System.Drawing.Point(504, 441);
            this.cmdUsersOpen.Name = "cmdUsersOpen";
            this.cmdUsersOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUsersOpen.Size = new System.Drawing.Size(81, 25);
            this.cmdUsersOpen.TabIndex = 54;
            this.cmdUsersOpen.Text = "&Open";
            this.cmdUsersOpen.UseVisualStyleBackColor = true;
            this.cmdUsersOpen.Click += new System.EventHandler(this.miniRptcmdUsers_Click);
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this._fraNavigation_2);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(601, 474);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Tag = "MSGS";
            this.TabPage3.Text = "Messages";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // _fraNavigation_2
            // 
            this._fraNavigation_2.Controls.Add(this.pbMsgs);
            this._fraNavigation_2.Controls.Add(this.lvwMsgs);
            this._fraNavigation_2.Controls.Add(this.txtMSGBody);
            this._fraNavigation_2.Controls.Add(this.cmdMsgDelete);
            this._fraNavigation_2.Controls.Add(this.cmdMsgNew);
            this._fraNavigation_2.Controls.Add(this.cmbMAreas);
            this._fraNavigation_2.Controls.Add(this.cmdMsgRefresh);
            this._fraNavigation_2.Controls.Add(this.cmdMsgOpen);
            this._fraNavigation_2.Controls.Add(this.cmbMGroups);
            this._fraNavigation_2.Controls.Add(this._lblMessages_1);
            this._fraNavigation_2.Controls.Add(this._lblMessages_0);
            this._fraNavigation_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fraNavigation_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._fraNavigation_2.Location = new System.Drawing.Point(3, 3);
            this._fraNavigation_2.Name = "_fraNavigation_2";
            this._fraNavigation_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._fraNavigation_2.Size = new System.Drawing.Size(595, 468);
            this._fraNavigation_2.TabIndex = 11;
            this._fraNavigation_2.TabStop = false;
            // 
            // pbMsgs
            // 
            this.pbMsgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMsgs.Location = new System.Drawing.Point(8, 44);
            this.pbMsgs.Name = "pbMsgs";
            this.pbMsgs.Size = new System.Drawing.Size(577, 14);
            this.pbMsgs.TabIndex = 73;
            // 
            // lvwMsgs
            // 
            this.lvwMsgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMsgs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10,
            this.ColumnHeader11});
            this.lvwMsgs.FullRowSelect = true;
            this.lvwMsgs.GridLines = true;
            this.lvwMsgs.HideSelection = false;
            this.lvwMsgs.Location = new System.Drawing.Point(8, 63);
            this.lvwMsgs.MultiSelect = false;
            this.lvwMsgs.Name = "lvwMsgs";
            this.lvwMsgs.Size = new System.Drawing.Size(577, 219);
            this.lvwMsgs.SmallImageList = this.imglMain;
            this.lvwMsgs.TabIndex = 72;
            this.lvwMsgs.UseCompatibleStateImageBehavior = false;
            this.lvwMsgs.View = System.Windows.Forms.View.Details;
            this.lvwMsgs.SelectedIndexChanged += new System.EventHandler(this.lvwMsgs_SelectedIndexChanged);
            this.lvwMsgs.DoubleClick += new System.EventHandler(this.miniRptLvws_DblClick);
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "To";
            this.ColumnHeader6.Width = 100;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "From";
            this.ColumnHeader7.Width = 100;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Subject";
            this.ColumnHeader8.Width = 100;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "Date";
            this.ColumnHeader9.Width = 100;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "ID";
            this.ColumnHeader10.Width = 100;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "Conf";
            this.ColumnHeader11.Width = 50;
            // 
            // txtMSGBody
            // 
            this.txtMSGBody.AcceptsReturn = true;
            this.txtMSGBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMSGBody.Location = new System.Drawing.Point(8, 288);
            this.txtMSGBody.MaxLength = 0;
            this.txtMSGBody.Multiline = true;
            this.txtMSGBody.Name = "txtMSGBody";
            this.txtMSGBody.ReadOnly = true;
            this.txtMSGBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMSGBody.Size = new System.Drawing.Size(577, 146);
            this.txtMSGBody.TabIndex = 3;
            this.txtMSGBody.WordWrap = false;
            // 
            // cmdMsgDelete
            // 
            this.cmdMsgDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdMsgDelete.BackColor = System.Drawing.SystemColors.Control;
            this.cmdMsgDelete.Location = new System.Drawing.Point(87, 440);
            this.cmdMsgDelete.Name = "cmdMsgDelete";
            this.cmdMsgDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdMsgDelete.Size = new System.Drawing.Size(73, 25);
            this.cmdMsgDelete.TabIndex = 5;
            this.cmdMsgDelete.Text = "&Delete";
            this.cmdMsgDelete.UseVisualStyleBackColor = true;
            this.cmdMsgDelete.Click += new System.EventHandler(this.miniRptcmdMsgs_Click);
            // 
            // cmdMsgNew
            // 
            this.cmdMsgNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdMsgNew.BackColor = System.Drawing.SystemColors.Control;
            this.cmdMsgNew.Location = new System.Drawing.Point(8, 440);
            this.cmdMsgNew.Name = "cmdMsgNew";
            this.cmdMsgNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdMsgNew.Size = new System.Drawing.Size(73, 25);
            this.cmdMsgNew.TabIndex = 4;
            this.cmdMsgNew.Text = "&New";
            this.cmdMsgNew.UseVisualStyleBackColor = true;
            this.cmdMsgNew.Click += new System.EventHandler(this.miniRptcmdMsgs_Click);
            // 
            // cmbMAreas
            // 
            this.cmbMAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAreas.Location = new System.Drawing.Point(344, 16);
            this.cmbMAreas.Name = "cmbMAreas";
            this.cmbMAreas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMAreas.Size = new System.Drawing.Size(241, 21);
            this.cmbMAreas.TabIndex = 1;
            this.cmbMAreas.SelectedIndexChanged += new System.EventHandler(this.cmbMAreas_SelectedIndexChanged);
            // 
            // cmdMsgRefresh
            // 
            this.cmdMsgRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMsgRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.cmdMsgRefresh.Location = new System.Drawing.Point(433, 440);
            this.cmdMsgRefresh.Name = "cmdMsgRefresh";
            this.cmdMsgRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdMsgRefresh.Size = new System.Drawing.Size(73, 25);
            this.cmdMsgRefresh.TabIndex = 6;
            this.cmdMsgRefresh.Text = "&Refresh";
            this.cmdMsgRefresh.UseVisualStyleBackColor = true;
            this.cmdMsgRefresh.Click += new System.EventHandler(this.miniRptcmdMsgs_Click);
            // 
            // cmdMsgOpen
            // 
            this.cmdMsgOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMsgOpen.BackColor = System.Drawing.SystemColors.Control;
            this.cmdMsgOpen.Location = new System.Drawing.Point(512, 440);
            this.cmdMsgOpen.Name = "cmdMsgOpen";
            this.cmdMsgOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdMsgOpen.Size = new System.Drawing.Size(73, 25);
            this.cmdMsgOpen.TabIndex = 7;
            this.cmdMsgOpen.Text = "&Open";
            this.cmdMsgOpen.UseVisualStyleBackColor = true;
            this.cmdMsgOpen.Click += new System.EventHandler(this.miniRptcmdMsgs_Click);
            // 
            // cmbMGroups
            // 
            this.cmbMGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMGroups.Location = new System.Drawing.Point(64, 16);
            this.cmbMGroups.Name = "cmbMGroups";
            this.cmbMGroups.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMGroups.Size = new System.Drawing.Size(225, 21);
            this.cmbMGroups.TabIndex = 0;
            this.cmbMGroups.SelectedIndexChanged += new System.EventHandler(this.cmbMGroups_SelectedIndexChanged);
            // 
            // _lblMessages_1
            // 
            this._lblMessages_1.Location = new System.Drawing.Point(8, 16);
            this._lblMessages_1.Name = "_lblMessages_1";
            this._lblMessages_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblMessages_1.Size = new System.Drawing.Size(41, 17);
            this._lblMessages_1.TabIndex = 59;
            this._lblMessages_1.Text = "Group:";
            this._lblMessages_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblMessages_0
            // 
            this._lblMessages_0.Location = new System.Drawing.Point(296, 16);
            this._lblMessages_0.Name = "_lblMessages_0";
            this._lblMessages_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblMessages_0.Size = new System.Drawing.Size(41, 17);
            this._lblMessages_0.TabIndex = 58;
            this._lblMessages_0.Text = "Area:";
            this._lblMessages_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this._fraNavigation_3);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(601, 474);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Tag = "FILES";
            this.TabPage4.Text = "Files";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // _fraNavigation_3
            // 
            this._fraNavigation_3.Controls.Add(this.pbFiles);
            this._fraNavigation_3.Controls.Add(this.lvwFiles);
            this._fraNavigation_3.Controls.Add(this.txtFileDesc);
            this._fraNavigation_3.Controls.Add(this.cmbFGroup);
            this._fraNavigation_3.Controls.Add(this.cmdFileOpen);
            this._fraNavigation_3.Controls.Add(this.cmdFileRefresh);
            this._fraNavigation_3.Controls.Add(this.cmbFArea);
            this._fraNavigation_3.Controls.Add(this._lblFiles_1);
            this._fraNavigation_3.Controls.Add(this._lblFiles_0);
            this._fraNavigation_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fraNavigation_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this._fraNavigation_3.Location = new System.Drawing.Point(3, 3);
            this._fraNavigation_3.Name = "_fraNavigation_3";
            this._fraNavigation_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._fraNavigation_3.Size = new System.Drawing.Size(595, 468);
            this._fraNavigation_3.TabIndex = 12;
            this._fraNavigation_3.TabStop = false;
            // 
            // pbFiles
            // 
            this.pbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFiles.Location = new System.Drawing.Point(8, 43);
            this.pbFiles.Name = "pbFiles";
            this.pbFiles.Size = new System.Drawing.Size(577, 14);
            this.pbFiles.TabIndex = 72;
            // 
            // lvwFiles
            // 
            this.lvwFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.GridLines = true;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.Location = new System.Drawing.Point(8, 63);
            this.lvwFiles.MultiSelect = false;
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(577, 219);
            this.lvwFiles.SmallImageList = this.imglMain;
            this.lvwFiles.TabIndex = 71;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            this.lvwFiles.SelectedIndexChanged += new System.EventHandler(this.lvwFiles_SelectedIndexChanged);
            this.lvwFiles.DoubleClick += new System.EventHandler(this.miniRptLvws_DblClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "File Name";
            this.ColumnHeader1.Width = 100;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Area";
            this.ColumnHeader2.Width = 50;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Date";
            this.ColumnHeader3.Width = 100;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Uploader";
            this.ColumnHeader4.Width = 100;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Description";
            this.ColumnHeader5.Width = 200;
            // 
            // txtFileDesc
            // 
            this.txtFileDesc.AcceptsReturn = true;
            this.txtFileDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileDesc.Location = new System.Drawing.Point(8, 288);
            this.txtFileDesc.MaxLength = 0;
            this.txtFileDesc.Multiline = true;
            this.txtFileDesc.Name = "txtFileDesc";
            this.txtFileDesc.ReadOnly = true;
            this.txtFileDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFileDesc.Size = new System.Drawing.Size(577, 146);
            this.txtFileDesc.TabIndex = 70;
            this.txtFileDesc.WordWrap = false;
            // 
            // cmbFGroup
            // 
            this.cmbFGroup.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFGroup.Location = new System.Drawing.Point(64, 16);
            this.cmbFGroup.Name = "cmbFGroup";
            this.cmbFGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbFGroup.Size = new System.Drawing.Size(225, 21);
            this.cmbFGroup.TabIndex = 65;
            this.cmbFGroup.SelectedIndexChanged += new System.EventHandler(this.cmbFGroup_SelectedIndexChanged);
            // 
            // cmdFileOpen
            // 
            this.cmdFileOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFileOpen.BackColor = System.Drawing.SystemColors.Control;
            this.cmdFileOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdFileOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFileOpen.Location = new System.Drawing.Point(512, 441);
            this.cmdFileOpen.Name = "cmdFileOpen";
            this.cmdFileOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFileOpen.Size = new System.Drawing.Size(73, 25);
            this.cmdFileOpen.TabIndex = 64;
            this.cmdFileOpen.Text = "&Open";
            this.cmdFileOpen.UseVisualStyleBackColor = true;
            this.cmdFileOpen.Click += new System.EventHandler(this.miniRptcmdFiles_Click);
            // 
            // cmdFileRefresh
            // 
            this.cmdFileRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFileRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.cmdFileRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdFileRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFileRefresh.Location = new System.Drawing.Point(433, 441);
            this.cmdFileRefresh.Name = "cmdFileRefresh";
            this.cmdFileRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFileRefresh.Size = new System.Drawing.Size(73, 25);
            this.cmdFileRefresh.TabIndex = 63;
            this.cmdFileRefresh.Text = "&Refresh";
            this.cmdFileRefresh.UseVisualStyleBackColor = true;
            this.cmdFileRefresh.Click += new System.EventHandler(this.miniRptcmdFiles_Click);
            // 
            // cmbFArea
            // 
            this.cmbFArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFArea.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFArea.Location = new System.Drawing.Point(344, 16);
            this.cmbFArea.Name = "cmbFArea";
            this.cmbFArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbFArea.Size = new System.Drawing.Size(241, 21);
            this.cmbFArea.TabIndex = 62;
            this.cmbFArea.SelectedIndexChanged += new System.EventHandler(this.cmbFArea_SelectedIndexChanged);
            // 
            // _lblFiles_1
            // 
            this._lblFiles_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblFiles_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblFiles_1.Location = new System.Drawing.Point(296, 16);
            this._lblFiles_1.Name = "_lblFiles_1";
            this._lblFiles_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblFiles_1.Size = new System.Drawing.Size(41, 17);
            this._lblFiles_1.TabIndex = 69;
            this._lblFiles_1.Text = "Area:";
            this._lblFiles_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblFiles_0
            // 
            this._lblFiles_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._lblFiles_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblFiles_0.Location = new System.Drawing.Point(8, 16);
            this._lblFiles_0.Name = "_lblFiles_0";
            this._lblFiles_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblFiles_0.Size = new System.Drawing.Size(41, 17);
            this._lblFiles_0.TabIndex = 68;
            this._lblFiles_0.Text = "Group:";
            this._lblFiles_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 500);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(3, 22);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSMiniRPT\'s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this._fraNavigation_0.ResumeLayout(false);
            this._fraNavigation_0.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this._fraNavigation_1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this._fraNavigation_2.ResumeLayout(false);
            this._fraNavigation_2.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this._fraNavigation_3.ResumeLayout(false);
            this._fraNavigation_3.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl tabMain;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.TabPage TabPage4;
		public System.Windows.Forms.GroupBox _fraNavigation_0;
		public System.Windows.Forms.Label _lblTitle_1;
		public System.Windows.Forms.Label _lblInfo_4;
		public System.Windows.Forms.Label _lblInfo_3;
		public System.Windows.Forms.Label _lblInfo_2;
		public System.Windows.Forms.Label _lblInfo_1;
		public System.Windows.Forms.Label _lblCaption_20;
		public System.Windows.Forms.Label _lblCaption_19;
		public System.Windows.Forms.Label _lblCaption_18;
		public System.Windows.Forms.Label _lblCaption_17;
		public System.Windows.Forms.Label _lblCaption_16;
		public System.Windows.Forms.Label _lblCaption_15;
		public System.Windows.Forms.Label _lblCaption_14;
		public System.Windows.Forms.Label _lblCaption_13;
		public System.Windows.Forms.Label _lblCaption_12;
		public System.Windows.Forms.Label _lblCaption_11;
		public System.Windows.Forms.Label _lblCaption_10;
		public System.Windows.Forms.Label _lblCaption_9;
		public System.Windows.Forms.Label _lblCaption_8;
		public System.Windows.Forms.Label _lblCaption_7;
		public System.Windows.Forms.Label _lblCaption_0;
		public System.Windows.Forms.Label _lblCaption_1;
		public System.Windows.Forms.Label _lblCaption_2;
		public System.Windows.Forms.Label _lblCaption_3;
		public System.Windows.Forms.Label _lblCaption_4;
		public System.Windows.Forms.Label _lblCaption_5;
		public System.Windows.Forms.GroupBox _fraNavigation_1;
		public System.Windows.Forms.Button cmdUsersRefresh;
		public System.Windows.Forms.Button cmdUsersOpen;
		public System.Windows.Forms.GroupBox _fraNavigation_2;
		public System.Windows.Forms.Button cmdMsgDelete;
		public System.Windows.Forms.Button cmdMsgNew;
		public System.Windows.Forms.ComboBox cmbMAreas;
		public System.Windows.Forms.Button cmdMsgRefresh;
		public System.Windows.Forms.Button cmdMsgOpen;
		public System.Windows.Forms.ComboBox cmbMGroups;
		public System.Windows.Forms.Label _lblMessages_1;
		public System.Windows.Forms.Label _lblMessages_0;
		public System.Windows.Forms.GroupBox _fraNavigation_3;
		public System.Windows.Forms.ComboBox cmbFGroup;
		public System.Windows.Forms.Button cmdFileOpen;
		public System.Windows.Forms.Button cmdFileRefresh;
		public System.Windows.Forms.ComboBox cmbFArea;
		public System.Windows.Forms.Label _lblFiles_1;
		public System.Windows.Forms.Label _lblFiles_0;
		internal System.Windows.Forms.TextBox txtFirstCall;
		internal System.Windows.Forms.TextBox txtSysop;
		internal System.Windows.Forms.TextBox txtSystemName;
		internal System.Windows.Forms.TextBox txtConfGroups;
		internal System.Windows.Forms.TextBox txtActiveConfs;
		internal System.Windows.Forms.TextBox txtTotalSecurity;
		internal System.Windows.Forms.TextBox txtTotalFileAreas;
		internal System.Windows.Forms.TextBox txtTotalConfs;
		internal System.Windows.Forms.TextBox txtServerBuild;
		internal System.Windows.Forms.TextBox txtRegNum;
		internal System.Windows.Forms.TextBox txtMaxUserCount;
		internal System.Windows.Forms.TextBox txtTotalCalls;
		internal System.Windows.Forms.TextBox txtTotalUsers;
		internal System.Windows.Forms.TextBox txtTotalFiles;
		internal System.Windows.Forms.TextBox txtTotalUsersOn;
		internal System.Windows.Forms.TextBox txtTotalMsgs;
		internal System.Windows.Forms.TextBox txtLanguages;
		internal System.Windows.Forms.TextBox txtDoors;
		internal System.Windows.Forms.TextBox txtFileGroups;
		internal System.Windows.Forms.TextBox txtActiveFileAreas;
		internal System.Windows.Forms.ListView lvwFiles;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ProgressBar pbFiles;
		internal System.Windows.Forms.ListView lvwMsgs;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.ColumnHeader ColumnHeader10;
		internal System.Windows.Forms.ColumnHeader ColumnHeader11;
		internal System.Windows.Forms.ProgressBar pbMsgs;
		internal System.Windows.Forms.ListView lvwUsers;
		internal System.Windows.Forms.ColumnHeader ColumnHeader12;
		internal System.Windows.Forms.ColumnHeader ColumnHeader13;
		internal System.Windows.Forms.ColumnHeader ColumnHeader14;
		internal System.Windows.Forms.ColumnHeader ColumnHeader15;
		internal System.Windows.Forms.ColumnHeader ColumnHeader16;
		internal System.Windows.Forms.ColumnHeader ColumnHeader17;
		internal System.Windows.Forms.ProgressBar pbUsers;
		internal System.Windows.Forms.ImageList imglMain;
		private System.Windows.Forms.TextBox txtMSGBody;
		private System.Windows.Forms.TextBox txtFileDesc;
	#endregion
	}
} //end of root namespace