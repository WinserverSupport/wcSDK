using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BSMiniRPT
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	internal partial class frmFile
	{
	#region Windows Form Designer generated code 
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmFile() : base()
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
		public System.Windows.Forms.Label lblFile9;
		public System.Windows.Forms.Label lblFile8;
		public System.Windows.Forms.Label lblFile7;
		public System.Windows.Forms.Label lblFile6;
		public System.Windows.Forms.Label lblFile5;
		public System.Windows.Forms.Label lblFile4;
		public System.Windows.Forms.Label lblFile3;
		public System.Windows.Forms.Label lblFile2;
		public System.Windows.Forms.Label lblFile1;
		public System.Windows.Forms.Label lblFStatus;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFile));
			this.cmdFilesClose = new System.Windows.Forms.Button();
			this.txtFileDescription = new System.Windows.Forms.TextBox();
			this.txtFileDownloads = new System.Windows.Forms.TextBox();
			this.txtFileLastAccess = new System.Windows.Forms.TextBox();
			this.txtFileDate = new System.Windows.Forms.TextBox();
			this.txtFilePassword = new System.Windows.Forms.TextBox();
			this.txtFileUploader = new System.Windows.Forms.TextBox();
			this.txtFileSize = new System.Windows.Forms.TextBox();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.txtFileArea = new System.Windows.Forms.TextBox();
			this.lblFile9 = new System.Windows.Forms.Label();
			this.lblFile8 = new System.Windows.Forms.Label();
			this.lblFile7 = new System.Windows.Forms.Label();
			this.lblFile6 = new System.Windows.Forms.Label();
			this.lblFile5 = new System.Windows.Forms.Label();
			this.lblFile4 = new System.Windows.Forms.Label();
			this.lblFile3 = new System.Windows.Forms.Label();
			this.lblFile2 = new System.Windows.Forms.Label();
			this.lblFile1 = new System.Windows.Forms.Label();
			this.lblFStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//cmdFilesClose
			//
			this.cmdFilesClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdFilesClose.Location = new System.Drawing.Point(272, 328);
			this.cmdFilesClose.Name = "cmdFilesClose";
			this.cmdFilesClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdFilesClose.Size = new System.Drawing.Size(81, 33);
			this.cmdFilesClose.TabIndex = 19;
			this.cmdFilesClose.Text = "&Close";
			this.cmdFilesClose.UseVisualStyleBackColor = true;
			//
			//txtFileDescription
			//
			this.txtFileDescription.AcceptsReturn = true;
			this.txtFileDescription.Location = new System.Drawing.Point(93, 224);
			this.txtFileDescription.Multiline = true;
			this.txtFileDescription.Name = "txtFileDescription";
			this.txtFileDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtFileDescription.Size = new System.Drawing.Size(260, 91);
			this.txtFileDescription.TabIndex = 8;
			this.txtFileDescription.WordWrap = false;
			//
			//txtFileDownloads
			//
			this.txtFileDownloads.Location = new System.Drawing.Point(93, 200);
			this.txtFileDownloads.Name = "txtFileDownloads";
			this.txtFileDownloads.Size = new System.Drawing.Size(260, 21);
			this.txtFileDownloads.TabIndex = 7;
			//
			//txtFileLastAccess
			//
			this.txtFileLastAccess.Location = new System.Drawing.Point(93, 176);
			this.txtFileLastAccess.Name = "txtFileLastAccess";
			this.txtFileLastAccess.Size = new System.Drawing.Size(260, 21);
			this.txtFileLastAccess.TabIndex = 6;
			//
			//txtFileDate
			//
			this.txtFileDate.Location = new System.Drawing.Point(93, 152);
			this.txtFileDate.Name = "txtFileDate";
			this.txtFileDate.Size = new System.Drawing.Size(260, 21);
			this.txtFileDate.TabIndex = 5;
			//
			//txtFilePassword
			//
			this.txtFilePassword.Location = new System.Drawing.Point(93, 128);
			this.txtFilePassword.Name = "txtFilePassword";
			this.txtFilePassword.Size = new System.Drawing.Size(260, 21);
			this.txtFilePassword.TabIndex = 4;
			//
			//txtFileUploader
			//
			this.txtFileUploader.Location = new System.Drawing.Point(93, 104);
			this.txtFileUploader.Name = "txtFileUploader";
			this.txtFileUploader.Size = new System.Drawing.Size(260, 21);
			this.txtFileUploader.TabIndex = 3;
			//
			//txtFileSize
			//
			this.txtFileSize.Location = new System.Drawing.Point(93, 80);
			this.txtFileSize.Name = "txtFileSize";
			this.txtFileSize.Size = new System.Drawing.Size(260, 21);
			this.txtFileSize.TabIndex = 2;
			//
			//txtFileName
			//
			this.txtFileName.Location = new System.Drawing.Point(93, 56);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(260, 21);
			this.txtFileName.TabIndex = 1;
			//
			//txtFileArea
			//
			this.txtFileArea.Location = new System.Drawing.Point(93, 32);
			this.txtFileArea.Name = "txtFileArea";
			this.txtFileArea.Size = new System.Drawing.Size(260, 21);
			this.txtFileArea.TabIndex = 0;
			//
			//lblFile9
			//
			this.lblFile9.Location = new System.Drawing.Point(8, 224);
			this.lblFile9.Name = "lblFile9";
			this.lblFile9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFile9.Size = new System.Drawing.Size(79, 17);
			this.lblFile9.TabIndex = 18;
			this.lblFile9.Text = "Description:";
			this.lblFile9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblFile8
			//
			this.lblFile8.Location = new System.Drawing.Point(8, 200);
			this.lblFile8.Name = "lblFile8";
			this.lblFile8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFile8.Size = new System.Drawing.Size(79, 17);
			this.lblFile8.TabIndex = 17;
			this.lblFile8.Text = "Downloads:";
			this.lblFile8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblFile7
			//
			this.lblFile7.Location = new System.Drawing.Point(8, 176);
			this.lblFile7.Name = "lblFile7";
			this.lblFile7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFile7.Size = new System.Drawing.Size(79, 17);
			this.lblFile7.TabIndex = 16;
			this.lblFile7.Text = "Last Access:";
			this.lblFile7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblFile6
			//
			this.lblFile6.Location = new System.Drawing.Point(8, 152);
			this.lblFile6.Name = "lblFile6";
			this.lblFile6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFile6.Size = new System.Drawing.Size(79, 17);
			this.lblFile6.TabIndex = 15;
			this.lblFile6.Text = "File Date:";
			this.lblFile6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblFile5
			//
			this.lblFile5.Location = new System.Drawing.Point(8, 128);
			this.lblFile5.Name = "lblFile5";
			this.lblFile5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFile5.Size = new System.Drawing.Size(79, 17);
			this.lblFile5.TabIndex = 14;
			this.lblFile5.Text = "Password:";
			this.lblFile5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblFile4
			//
			this.lblFile4.Location = new System.Drawing.Point(8, 104);
			this.lblFile4.Name = "lblFile4";
			this.lblFile4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFile4.Size = new System.Drawing.Size(79, 17);
			this.lblFile4.TabIndex = 13;
			this.lblFile4.Text = "Uploader:";
			this.lblFile4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblFile3
			//
			this.lblFile3.Location = new System.Drawing.Point(8, 80);
			this.lblFile3.Name = "lblFile3";
			this.lblFile3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFile3.Size = new System.Drawing.Size(79, 17);
			this.lblFile3.TabIndex = 12;
			this.lblFile3.Text = "File Size:";
			this.lblFile3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblFile2
			//
			this.lblFile2.Location = new System.Drawing.Point(8, 56);
			this.lblFile2.Name = "lblFile2";
			this.lblFile2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFile2.Size = new System.Drawing.Size(79, 17);
			this.lblFile2.TabIndex = 11;
			this.lblFile2.Text = "File Name:";
			this.lblFile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblFile1
			//
			this.lblFile1.Location = new System.Drawing.Point(8, 32);
			this.lblFile1.Name = "lblFile1";
			this.lblFile1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFile1.Size = new System.Drawing.Size(79, 17);
			this.lblFile1.TabIndex = 10;
			this.lblFile1.Text = "Area:";
			this.lblFile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblFStatus
			//
			this.lblFStatus.BackColor = System.Drawing.SystemColors.Highlight;
			this.lblFStatus.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblFStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblFStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblFStatus.Location = new System.Drawing.Point(8, 8);
			this.lblFStatus.Name = "lblFStatus";
			this.lblFStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFStatus.Size = new System.Drawing.Size(345, 17);
			this.lblFStatus.TabIndex = 9;
			this.lblFStatus.Text = "**File DOES NOT Exist on disk**";
			this.lblFStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//frmFile
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0), (float)(13.0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.cmdFilesClose;
			this.ClientSize = new System.Drawing.Size(361, 370);
			this.Controls.Add(this.cmdFilesClose);
			this.Controls.Add(this.txtFileDescription);
			this.Controls.Add(this.txtFileDownloads);
			this.Controls.Add(this.txtFileLastAccess);
			this.Controls.Add(this.txtFileDate);
			this.Controls.Add(this.txtFilePassword);
			this.Controls.Add(this.txtFileUploader);
			this.Controls.Add(this.txtFileSize);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.txtFileArea);
			this.Controls.Add(this.lblFile9);
			this.Controls.Add(this.lblFile8);
			this.Controls.Add(this.lblFile7);
			this.Controls.Add(this.lblFile6);
			this.Controls.Add(this.lblFile5);
			this.Controls.Add(this.lblFile4);
			this.Controls.Add(this.lblFile3);
			this.Controls.Add(this.lblFile2);
			this.Controls.Add(this.lblFile1);
			this.Controls.Add(this.lblFStatus);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)(resources.GetObject("$this.Icon"));
			this.Location = new System.Drawing.Point(3, 22);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFile";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "WINS Files";
			this.ResumeLayout(false);
			this.PerformLayout();

			cmdFilesClose.Click += new System.EventHandler(cmdFiles_Click);

		}
		private System.Windows.Forms.Button cmdFilesClose;
		private System.Windows.Forms.TextBox txtFileDescription;
		private System.Windows.Forms.TextBox txtFileDownloads;
		private System.Windows.Forms.TextBox txtFileLastAccess;
		private System.Windows.Forms.TextBox txtFileDate;
		private System.Windows.Forms.TextBox txtFilePassword;
		private System.Windows.Forms.TextBox txtFileUploader;
		private System.Windows.Forms.TextBox txtFileSize;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.TextBox txtFileArea;
	#endregion
	}
} //end of root namespace