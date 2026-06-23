using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using wcSDK;

namespace BSMiniRPT
{
	internal partial class frmMSG : System.Windows.Forms.Form
	{


		private int mvarMSGID;
		private int mvarConference;
		private MsgWindowType mvarEnumType;

		private bool boolCheckValidNames;

		public enum MsgWindowType: int
		{
			ENUM_NEWMESSAGE = 0,
			ENUM_REPLYMESSAGE = 1,
			ENUM_EDITMESSAGE = 2,
			ENUM_FORWARDMESSAGE = 3,
			ENUM_VIEWONLY = 4
		}

		public int MsgID
		{
			get
			{
				return mvarMSGID;
			}
			set
			{
				mvarMSGID = value;
			}
		}

		public int Conference
		{
			get
			{
				return mvarConference;
			}
			set
			{
				mvarConference = value;
			}
		}

		public MsgWindowType MessageType
		{
			get
			{
				return mvarEnumType;
			}
			set
			{
				mvarEnumType = value;
			}
		}

		private short LoadMessageView()
		{

			try
			{
				wcServerAPI.TMsgHeader wMSG = new wcServerAPI.TMsgHeader();

				if (wcServerAPI.GetMessageById(mvarConference, mvarMSGID, ref wMSG))
				{
					txtMsgTo.Text = wMSG.MsgTo.Name.Trim();
					txtMsgFrom.Text = wMSG.MsgFrom.Name.Trim();
					txtMsgSubject.Text = wMSG.Subject.Trim();
					txtMSGBody.Text = wcServerAPI.GetText("wc:\\conf(" + mvarConference.ToString().Trim() + ")\\message(" + mvarMSGID.ToString().Trim() + ")").Trim();
					txtMSGBody.Text = txtMSGBody.Text.Replace("\n", Environment.NewLine);
					if (wMSG.IsPrivate != 0)
					{
						ToolStripStatusLabel1.Enabled = true;
					}
					if (wMSG.ReceiptRequested != 0)
					{
						ToolStripStatusLabel2.Enabled = true;
					}
					if (wMSG.Received != 0)
					{
						ToolStripStatusLabel3.Enabled = true;
					}
					if (mvarEnumType == MsgWindowType.ENUM_VIEWONLY)
					{
						picMTools.Visible = false;
						txtMSGBody.Height = stbMsg.Top - txtMSGBody.Top - 5;
					}
				}
				else
				{
					MessageBox.Show("Error accessing the specified message", "WINS Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Dispose();
			}

			return 0;
		}

		public short PrepForMessage()
		{

			try
			{
				wcServerAPI.TMsgHeader wMSG = new wcServerAPI.TMsgHeader();
				wcServerAPI.TConfDesc wCONF = new wcServerAPI.TConfDesc();

				if (wcServerAPI.GetConfDesc(mvarConference, ref wCONF))
				{
					if (wCONF.AllowReturnReceipt != 0)
					{
						chkRR.Enabled = true;
					}
					if (wCONF.ValidateNames != 0)
					{
						boolCheckValidNames = true;
					}
					switch (wCONF.MailType)
					{
						case wcServerAPI.mtNormalPublicPrivate:
						case wcServerAPI.mtNormalPrivate:
						case wcServerAPI.mtEmailOnly:
							chkPVT.Enabled = true;
							break;
						default:
							chkPVT.Enabled = false;
							break;
					}
				}

				if (mvarMSGID == -1)
				{
					txtMsgFrom.Text = modBSMiniRPT.BBSSysopName;
				}
				else
				{
					picMTools.Visible = true;
					switch (mvarEnumType)
					{
						case MsgWindowType.ENUM_EDITMESSAGE:
							////Editing Message
						break;
						case MsgWindowType.ENUM_FORWARDMESSAGE:
							////Forwarded Message
						break;
						case MsgWindowType.ENUM_NEWMESSAGE:
							////New Message
						break;
						case MsgWindowType.ENUM_REPLYMESSAGE:
							////Reply Message
						break;
						case MsgWindowType.ENUM_VIEWONLY:
							////Read Only View
							picMTools.Visible = false;
							LoadMessageView();
							break;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return 0;
		}

	}
} //end of root namespace