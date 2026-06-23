using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BSMiniRPT
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	internal partial class frmMSG
	{
	#region Windows Form Designer generated code 
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmMSG() : base()
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
		public System.Windows.Forms.Panel picMTools;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMSG));
			this.picMTools = new System.Windows.Forms.Panel();
			this.chkRR = new System.Windows.Forms.CheckBox();
			this.chkPVT = new System.Windows.Forms.CheckBox();
			this.cmdSEND = new System.Windows.Forms.Button();
			this.txtMSGBody = new System.Windows.Forms.TextBox();
			this.txtMsgSubject = new System.Windows.Forms.TextBox();
			this.txtMsgFrom = new System.Windows.Forms.TextBox();
			this.txtMsgTo = new System.Windows.Forms.TextBox();
			this.lblMsg3 = new System.Windows.Forms.Label();
			this.lblMsg2 = new System.Windows.Forms.Label();
			this.lblMsg1 = new System.Windows.Forms.Label();
			this.stbMsg = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.picMTools.SuspendLayout();
			this.stbMsg.SuspendLayout();
			this.SuspendLayout();
			//
			//picMTools
			//
			this.picMTools.BackColor = System.Drawing.SystemColors.Control;
			this.picMTools.Controls.Add(this.chkRR);
			this.picMTools.Controls.Add(this.chkPVT);
			this.picMTools.Controls.Add(this.cmdSEND);
			this.picMTools.ForeColor = System.Drawing.SystemColors.ControlText;
			this.picMTools.Location = new System.Drawing.Point(0, 398);
			this.picMTools.Name = "picMTools";
			this.picMTools.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.picMTools.Size = new System.Drawing.Size(441, 41);
			this.picMTools.TabIndex = 8;
			this.picMTools.TabStop = true;
			//
			//chkRR
			//
			this.chkRR.Enabled = false;
			this.chkRR.Location = new System.Drawing.Point(173, 14);
			this.chkRR.Name = "chkRR";
			this.chkRR.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkRR.Size = new System.Drawing.Size(105, 17);
			this.chkRR.TabIndex = 11;
			this.chkRR.Text = "Return Receipt?";
			this.chkRR.UseVisualStyleBackColor = true;
			//
			//chkPVT
			//
			this.chkPVT.Enabled = false;
			this.chkPVT.Location = new System.Drawing.Point(88, 14);
			this.chkPVT.Name = "chkPVT";
			this.chkPVT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkPVT.Size = new System.Drawing.Size(68, 17);
			this.chkPVT.TabIndex = 10;
			this.chkPVT.Text = "Private";
			this.chkPVT.UseVisualStyleBackColor = true;
			//
			//cmdSEND
			//
			this.cmdSEND.Location = new System.Drawing.Point(8, 8);
			this.cmdSEND.Name = "cmdSEND";
			this.cmdSEND.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSEND.Size = new System.Drawing.Size(73, 25);
			this.cmdSEND.TabIndex = 9;
			this.cmdSEND.Text = "&Send";
			this.cmdSEND.UseVisualStyleBackColor = true;
			//
			//txtMSGBody
			//
			this.txtMSGBody.AcceptsReturn = true;
			this.txtMSGBody.Location = new System.Drawing.Point(8, 83);
			this.txtMSGBody.MaxLength = 0;
			this.txtMSGBody.Multiline = true;
			this.txtMSGBody.Name = "txtMSGBody";
			this.txtMSGBody.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMSGBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMSGBody.Size = new System.Drawing.Size(425, 309);
			this.txtMSGBody.TabIndex = 3;
			//
			//txtMsgSubject
			//
			this.txtMsgSubject.AcceptsReturn = true;
			this.txtMsgSubject.Location = new System.Drawing.Point(64, 56);
			this.txtMsgSubject.MaxLength = 0;
			this.txtMsgSubject.Name = "txtMsgSubject";
			this.txtMsgSubject.ReadOnly = true;
			this.txtMsgSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMsgSubject.Size = new System.Drawing.Size(369, 21);
			this.txtMsgSubject.TabIndex = 2;
			//
			//txtMsgFrom
			//
			this.txtMsgFrom.AcceptsReturn = true;
			this.txtMsgFrom.Location = new System.Drawing.Point(64, 32);
			this.txtMsgFrom.MaxLength = 0;
			this.txtMsgFrom.Name = "txtMsgFrom";
			this.txtMsgFrom.ReadOnly = true;
			this.txtMsgFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMsgFrom.Size = new System.Drawing.Size(369, 21);
			this.txtMsgFrom.TabIndex = 1;
			//
			//txtMsgTo
			//
			this.txtMsgTo.AcceptsReturn = true;
			this.txtMsgTo.Location = new System.Drawing.Point(64, 8);
			this.txtMsgTo.MaxLength = 0;
			this.txtMsgTo.Name = "txtMsgTo";
			this.txtMsgTo.ReadOnly = true;
			this.txtMsgTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMsgTo.Size = new System.Drawing.Size(369, 21);
			this.txtMsgTo.TabIndex = 0;
			//
			//lblMsg3
			//
			this.lblMsg3.Location = new System.Drawing.Point(8, 56);
			this.lblMsg3.Name = "lblMsg3";
			this.lblMsg3.Size = new System.Drawing.Size(49, 17);
			this.lblMsg3.TabIndex = 6;
			this.lblMsg3.Text = "Subject:";
			this.lblMsg3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblMsg2
			//
			this.lblMsg2.Location = new System.Drawing.Point(8, 32);
			this.lblMsg2.Name = "lblMsg2";
			this.lblMsg2.Size = new System.Drawing.Size(49, 17);
			this.lblMsg2.TabIndex = 5;
			this.lblMsg2.Text = "From:";
			this.lblMsg2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblMsg1
			//
			this.lblMsg1.Location = new System.Drawing.Point(8, 8);
			this.lblMsg1.Name = "lblMsg1";
			this.lblMsg1.Size = new System.Drawing.Size(49, 17);
			this.lblMsg1.TabIndex = 4;
			this.lblMsg1.Text = "To:";
			this.lblMsg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//stbMsg
			//
			this.stbMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripStatusLabel1, this.ToolStripStatusLabel2, this.ToolStripStatusLabel3});
			this.stbMsg.Location = new System.Drawing.Point(0, 439);
			this.stbMsg.Name = "stbMsg";
			this.stbMsg.Size = new System.Drawing.Size(441, 22);
			this.stbMsg.TabIndex = 9;
			this.stbMsg.Text = "StatusStrip1";
			//
			//ToolStripStatusLabel1
			//
			this.ToolStripStatusLabel1.Enabled = false;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
			this.ToolStripStatusLabel1.Spring = true;
			this.ToolStripStatusLabel1.Text = "PVT";
			//
			//ToolStripStatusLabel2
			//
			this.ToolStripStatusLabel2.Enabled = false;
			this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
			this.ToolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
			this.ToolStripStatusLabel2.Spring = true;
			this.ToolStripStatusLabel2.Text = "RCPT";
			//
			//ToolStripStatusLabel3
			//
			this.ToolStripStatusLabel3.Enabled = false;
			this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
			this.ToolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
			this.ToolStripStatusLabel3.Spring = true;
			this.ToolStripStatusLabel3.Text = "READ";
			//
			//frmMSG
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0), (float)(13.0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(441, 461);
			this.Controls.Add(this.stbMsg);
			this.Controls.Add(this.picMTools);
			this.Controls.Add(this.txtMSGBody);
			this.Controls.Add(this.txtMsgSubject);
			this.Controls.Add(this.txtMsgFrom);
			this.Controls.Add(this.txtMsgTo);
			this.Controls.Add(this.lblMsg3);
			this.Controls.Add(this.lblMsg2);
			this.Controls.Add(this.lblMsg1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)(resources.GetObject("$this.Icon"));
			this.Location = new System.Drawing.Point(3, 22);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMSG";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "WINS Messages";
			this.picMTools.ResumeLayout(false);
			this.stbMsg.ResumeLayout(false);
			this.stbMsg.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label lblMsg3;
		private System.Windows.Forms.Label lblMsg2;
		private System.Windows.Forms.Label lblMsg1;
		private System.Windows.Forms.CheckBox chkRR;
		private System.Windows.Forms.CheckBox chkPVT;
		private System.Windows.Forms.Button cmdSEND;
		private System.Windows.Forms.TextBox txtMSGBody;
		private System.Windows.Forms.TextBox txtMsgSubject;
		private System.Windows.Forms.TextBox txtMsgFrom;
		private System.Windows.Forms.TextBox txtMsgTo;
		internal System.Windows.Forms.StatusStrip stbMsg;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
	#endregion
	}
} //end of root namespace