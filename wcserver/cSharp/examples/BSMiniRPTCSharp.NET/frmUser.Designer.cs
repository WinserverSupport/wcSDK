using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BSMiniRPT
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	internal partial class frmUser
	{
	#region Windows Form Designer generated code 
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmUser() : base()
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
		public System.Windows.Forms.Label _lblUsers_8;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
			this.cmdUserCancel = new System.Windows.Forms.Button();
			this.cmdUserUpdate = new System.Windows.Forms.Button();
			this.txtUserDataPhone = new System.Windows.Forms.TextBox();
			this.txtUserPhone = new System.Windows.Forms.TextBox();
			this.txtUserCountry = new System.Windows.Forms.TextBox();
			this.txtUserZip = new System.Windows.Forms.TextBox();
			this.txtUserState = new System.Windows.Forms.TextBox();
			this.txtUserCity = new System.Windows.Forms.TextBox();
			this.txtUserAddress2 = new System.Windows.Forms.TextBox();
			this.txtUserAddress1 = new System.Windows.Forms.TextBox();
			this.txtUserFrom = new System.Windows.Forms.TextBox();
			this.txtUserRealName = new System.Windows.Forms.TextBox();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this._lblUsers_11 = new System.Windows.Forms.Label();
			this._lblUsers_10 = new System.Windows.Forms.Label();
			this._lblUsers_9 = new System.Windows.Forms.Label();
			this._lblUsers_8 = new System.Windows.Forms.Label();
			this._lblUsers_7 = new System.Windows.Forms.Label();
			this._lblUsers_6 = new System.Windows.Forms.Label();
			this._lblUsers_5 = new System.Windows.Forms.Label();
			this._lblUsers_4 = new System.Windows.Forms.Label();
			this._lblUsers_3 = new System.Windows.Forms.Label();
			this._lblUsers_2 = new System.Windows.Forms.Label();
			this._lblUsers_1 = new System.Windows.Forms.Label();
			this._lblUsers_0 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//cmdUserCancel
			//
			this.cmdUserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdUserCancel.Location = new System.Drawing.Point(248, 264);
			this.cmdUserCancel.Name = "cmdUserCancel";
			this.cmdUserCancel.Size = new System.Drawing.Size(105, 33);
			this.cmdUserCancel.TabIndex = 13;
			this.cmdUserCancel.Text = "&Cancel";
			this.cmdUserCancel.UseVisualStyleBackColor = true;
			//
			//cmdUserUpdate
			//
			this.cmdUserUpdate.Location = new System.Drawing.Point(136, 264);
			this.cmdUserUpdate.Name = "cmdUserUpdate";
			this.cmdUserUpdate.Size = new System.Drawing.Size(105, 33);
			this.cmdUserUpdate.TabIndex = 12;
			this.cmdUserUpdate.Text = "&Update User";
			this.cmdUserUpdate.UseVisualStyleBackColor = true;
			//
			//txtUserDataPhone
			//
			this.txtUserDataPhone.Location = new System.Drawing.Point(84, 232);
			this.txtUserDataPhone.MaxLength = 0;
			this.txtUserDataPhone.Name = "txtUserDataPhone";
			this.txtUserDataPhone.Size = new System.Drawing.Size(269, 19);
			this.txtUserDataPhone.TabIndex = 11;
			//
			//txtUserPhone
			//
			this.txtUserPhone.Location = new System.Drawing.Point(84, 208);
			this.txtUserPhone.MaxLength = 0;
			this.txtUserPhone.Name = "txtUserPhone";
			this.txtUserPhone.Size = new System.Drawing.Size(269, 19);
			this.txtUserPhone.TabIndex = 10;
			//
			//txtUserCountry
			//
			this.txtUserCountry.Location = new System.Drawing.Point(84, 176);
			this.txtUserCountry.MaxLength = 0;
			this.txtUserCountry.Name = "txtUserCountry";
			this.txtUserCountry.Size = new System.Drawing.Size(269, 19);
			this.txtUserCountry.TabIndex = 9;
			//
			//txtUserZip
			//
			this.txtUserZip.Location = new System.Drawing.Point(280, 152);
			this.txtUserZip.MaxLength = 0;
			this.txtUserZip.Name = "txtUserZip";
			this.txtUserZip.Size = new System.Drawing.Size(73, 19);
			this.txtUserZip.TabIndex = 8;
			//
			//txtUserState
			//
			this.txtUserState.Location = new System.Drawing.Point(84, 152);
			this.txtUserState.MaxLength = 0;
			this.txtUserState.Name = "txtUserState";
			this.txtUserState.Size = new System.Drawing.Size(133, 19);
			this.txtUserState.TabIndex = 7;
			//
			//txtUserCity
			//
			this.txtUserCity.Location = new System.Drawing.Point(84, 128);
			this.txtUserCity.MaxLength = 0;
			this.txtUserCity.Name = "txtUserCity";
			this.txtUserCity.Size = new System.Drawing.Size(269, 19);
			this.txtUserCity.TabIndex = 6;
			//
			//txtUserAddress2
			//
			this.txtUserAddress2.Location = new System.Drawing.Point(84, 104);
			this.txtUserAddress2.MaxLength = 0;
			this.txtUserAddress2.Name = "txtUserAddress2";
			this.txtUserAddress2.Size = new System.Drawing.Size(269, 19);
			this.txtUserAddress2.TabIndex = 5;
			//
			//txtUserAddress1
			//
			this.txtUserAddress1.Location = new System.Drawing.Point(84, 80);
			this.txtUserAddress1.MaxLength = 0;
			this.txtUserAddress1.Name = "txtUserAddress1";
			this.txtUserAddress1.Size = new System.Drawing.Size(269, 19);
			this.txtUserAddress1.TabIndex = 4;
			//
			//txtUserFrom
			//
			this.txtUserFrom.Location = new System.Drawing.Point(84, 56);
			this.txtUserFrom.MaxLength = 0;
			this.txtUserFrom.Name = "txtUserFrom";
			this.txtUserFrom.Size = new System.Drawing.Size(269, 19);
			this.txtUserFrom.TabIndex = 3;
			//
			//txtUserRealName
			//
			this.txtUserRealName.Location = new System.Drawing.Point(84, 32);
			this.txtUserRealName.MaxLength = 0;
			this.txtUserRealName.Name = "txtUserRealName";
			this.txtUserRealName.Size = new System.Drawing.Size(269, 19);
			this.txtUserRealName.TabIndex = 2;
			//
			//txtUserID
			//
			this.txtUserID.Location = new System.Drawing.Point(296, 8);
			this.txtUserID.MaxLength = 0;
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.ReadOnly = true;
			this.txtUserID.Size = new System.Drawing.Size(57, 19);
			this.txtUserID.TabIndex = 1;
			//
			//txtUserName
			//
			this.txtUserName.Location = new System.Drawing.Point(84, 8);
			this.txtUserName.MaxLength = 0;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(165, 19);
			this.txtUserName.TabIndex = 0;
			//
			//_lblUsers_11
			//
			this._lblUsers_11.Location = new System.Drawing.Point(8, 232);
			this._lblUsers_11.Name = "_lblUsers_11";
			this._lblUsers_11.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_11.TabIndex = 25;
			this._lblUsers_11.Text = "Data:";
			this._lblUsers_11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_10
			//
			this._lblUsers_10.Location = new System.Drawing.Point(8, 208);
			this._lblUsers_10.Name = "_lblUsers_10";
			this._lblUsers_10.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_10.TabIndex = 24;
			this._lblUsers_10.Text = "Phone:";
			this._lblUsers_10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_9
			//
			this._lblUsers_9.Location = new System.Drawing.Point(8, 176);
			this._lblUsers_9.Name = "_lblUsers_9";
			this._lblUsers_9.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_9.TabIndex = 23;
			this._lblUsers_9.Text = "Country:";
			this._lblUsers_9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_8
			//
			this._lblUsers_8.BackColor = System.Drawing.Color.Transparent;
			this._lblUsers_8.Cursor = System.Windows.Forms.Cursors.Default;
			this._lblUsers_8.Font = new System.Drawing.Font("Arial", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._lblUsers_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lblUsers_8.Location = new System.Drawing.Point(216, 152);
			this._lblUsers_8.Name = "_lblUsers_8";
			this._lblUsers_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lblUsers_8.Size = new System.Drawing.Size(57, 17);
			this._lblUsers_8.TabIndex = 22;
			this._lblUsers_8.Text = "Zip:";
			this._lblUsers_8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//_lblUsers_7
			//
			this._lblUsers_7.Location = new System.Drawing.Point(8, 152);
			this._lblUsers_7.Name = "_lblUsers_7";
			this._lblUsers_7.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_7.TabIndex = 21;
			this._lblUsers_7.Text = "State:";
			this._lblUsers_7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_6
			//
			this._lblUsers_6.Location = new System.Drawing.Point(8, 128);
			this._lblUsers_6.Name = "_lblUsers_6";
			this._lblUsers_6.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_6.TabIndex = 20;
			this._lblUsers_6.Text = "City:";
			this._lblUsers_6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_5
			//
			this._lblUsers_5.Location = new System.Drawing.Point(8, 104);
			this._lblUsers_5.Name = "_lblUsers_5";
			this._lblUsers_5.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_5.TabIndex = 19;
			this._lblUsers_5.Text = "Address2:";
			this._lblUsers_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_4
			//
			this._lblUsers_4.Location = new System.Drawing.Point(8, 80);
			this._lblUsers_4.Name = "_lblUsers_4";
			this._lblUsers_4.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_4.TabIndex = 18;
			this._lblUsers_4.Text = "Address1:";
			this._lblUsers_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_3
			//
			this._lblUsers_3.Location = new System.Drawing.Point(8, 56);
			this._lblUsers_3.Name = "_lblUsers_3";
			this._lblUsers_3.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_3.TabIndex = 17;
			this._lblUsers_3.Text = "From:";
			this._lblUsers_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_2
			//
			this._lblUsers_2.Location = new System.Drawing.Point(8, 32);
			this._lblUsers_2.Name = "_lblUsers_2";
			this._lblUsers_2.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_2.TabIndex = 16;
			this._lblUsers_2.Text = "Real Name:";
			this._lblUsers_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_1
			//
			this._lblUsers_1.Location = new System.Drawing.Point(232, 8);
			this._lblUsers_1.Name = "_lblUsers_1";
			this._lblUsers_1.Size = new System.Drawing.Size(57, 17);
			this._lblUsers_1.TabIndex = 15;
			this._lblUsers_1.Text = "ID:";
			this._lblUsers_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//_lblUsers_0
			//
			this._lblUsers_0.Location = new System.Drawing.Point(8, 8);
			this._lblUsers_0.Name = "_lblUsers_0";
			this._lblUsers_0.Size = new System.Drawing.Size(70, 17);
			this._lblUsers_0.TabIndex = 14;
			this._lblUsers_0.Text = "Name:";
			this._lblUsers_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmUser
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0), (float)(13.0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdUserCancel;
			this.ClientSize = new System.Drawing.Size(362, 306);
			this.Controls.Add(this.cmdUserCancel);
			this.Controls.Add(this.cmdUserUpdate);
			this.Controls.Add(this.txtUserDataPhone);
			this.Controls.Add(this.txtUserPhone);
			this.Controls.Add(this.txtUserCountry);
			this.Controls.Add(this.txtUserZip);
			this.Controls.Add(this.txtUserState);
			this.Controls.Add(this.txtUserCity);
			this.Controls.Add(this.txtUserAddress2);
			this.Controls.Add(this.txtUserAddress1);
			this.Controls.Add(this.txtUserFrom);
			this.Controls.Add(this.txtUserRealName);
			this.Controls.Add(this.txtUserID);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this._lblUsers_11);
			this.Controls.Add(this._lblUsers_10);
			this.Controls.Add(this._lblUsers_9);
			this.Controls.Add(this._lblUsers_8);
			this.Controls.Add(this._lblUsers_7);
			this.Controls.Add(this._lblUsers_6);
			this.Controls.Add(this._lblUsers_5);
			this.Controls.Add(this._lblUsers_4);
			this.Controls.Add(this._lblUsers_3);
			this.Controls.Add(this._lblUsers_2);
			this.Controls.Add(this._lblUsers_1);
			this.Controls.Add(this._lblUsers_0);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)(resources.GetObject("$this.Icon"));
			this.Location = new System.Drawing.Point(3, 22);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "WINS Users";
			this.ResumeLayout(false);

			cmdUserCancel.Click += new System.EventHandler(cmdUsers_Click);
			cmdUserUpdate.Click += new System.EventHandler(cmdUsers_Click);

		}
		private System.Windows.Forms.Label _lblUsers_11;
		private System.Windows.Forms.Label _lblUsers_10;
		private System.Windows.Forms.Label _lblUsers_9;
		private System.Windows.Forms.Label _lblUsers_7;
		private System.Windows.Forms.Label _lblUsers_6;
		private System.Windows.Forms.Label _lblUsers_5;
		private System.Windows.Forms.Label _lblUsers_4;
		private System.Windows.Forms.Label _lblUsers_3;
		private System.Windows.Forms.Label _lblUsers_2;
		private System.Windows.Forms.Label _lblUsers_1;
		private System.Windows.Forms.Label _lblUsers_0;
		private System.Windows.Forms.Button cmdUserCancel;
		private System.Windows.Forms.Button cmdUserUpdate;
		private System.Windows.Forms.TextBox txtUserDataPhone;
		private System.Windows.Forms.TextBox txtUserPhone;
		private System.Windows.Forms.TextBox txtUserCountry;
		private System.Windows.Forms.TextBox txtUserZip;
		private System.Windows.Forms.TextBox txtUserState;
		private System.Windows.Forms.TextBox txtUserCity;
		private System.Windows.Forms.TextBox txtUserAddress2;
		private System.Windows.Forms.TextBox txtUserAddress1;
		private System.Windows.Forms.TextBox txtUserFrom;
		private System.Windows.Forms.TextBox txtUserRealName;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.TextBox txtUserName;
	#endregion
	}
} //end of root namespace