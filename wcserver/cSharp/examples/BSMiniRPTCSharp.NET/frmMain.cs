using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using wcSDK;

namespace BSMiniRPT
{
	internal partial class frmMain : System.Windows.Forms.Form
	{

	#region Form Events ...

		private void frmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{

			try
			{
				wcServerAPI.WildcatServerDeleteContext();
			}
			catch (Exception ex)
			{

			}

		}

		private void frmMain_Load(object eventSender, System.EventArgs eventArgs)
		{
			////First we attempt to login to WINS

            Form frmSplash = new frmSplash();

            frmSplash.Show();
            frmSplash.Refresh();

			if (modBSMiniRPT.ConnectToWINS())
			{
				////Filling in the information tab
				f_GetWCInformation();
				frmSplash.Dispose();
			}
			else
			{
				frmSplash.Dispose();
				this.Dispose();
			}

		}

	#endregion

	#region Control Events ...

		private void cmbFArea_SelectedIndexChanged(object sender, System.EventArgs eventArgs)
		{

			s_ReloadFiles();

		}

		private void cmbFGroup_SelectedIndexChanged(object sender, System.EventArgs eventArgs)
		{

			f_LoadWCFileAreas(((clsList)(cmbFGroup.Items[cmbFGroup.SelectedIndex])).ItemData);

		}

		private void cmbMAreas_SelectedIndexChanged(object sender, System.EventArgs eventArgs)
		{

			s_ReloadMessages();

		}

		private void cmbMGroups_SelectedIndexChanged(object sender, System.EventArgs eventArgs)
		{

			f_LoadWCMSGAreas(((clsList)(cmbMGroups.Items[cmbMGroups.SelectedIndex])).ItemData);

		}

		private void lvwFiles_SelectedIndexChanged(object sender, System.EventArgs e)
		{


			if (lvwFiles.SelectedItems.Count > 0)
			{
				modBSMiniRPT.MouseHour();

				try
				{
					wcServerAPI.TFullFileRecord wFullFile = new wcServerAPI.TFullFileRecord();
					wcServerAPI.TFileRecord wFile = new wcServerAPI.TFileRecord();
					int fID = 0;
					short myX = 0;

					txtFileDesc.ForeColor = System.Drawing.Color.Red;
					txtFileDesc.Text = "(No Long Description Available)";

					if (wcServerAPI.GetFileRecByNameArea(lvwFiles.SelectedItems[0].Text, System.Convert.ToInt32(lvwFiles.SelectedItems[0].SubItems[1].Text), ref wFile, ref fID))
					{
						if (wFile.HasLongDescription != 0)
						{
							if (wcServerAPI.GetFullFileRec(ref wFile, ref wFullFile))
							{
								txtFileDesc.Text = "";
								txtFileDesc.ForeColor = System.Drawing.SystemColors.WindowText;
								for (myX = 0; myX <= 14; myX++)
								{
									if (wFullFile.LongDescription[myX].Description.Trim() != "")
									{
										txtFileDesc.Text = txtFileDesc.Text + wFullFile.LongDescription[myX].Description.TrimEnd(' ') + Environment.NewLine;
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				modBSMiniRPT.MouseNormal();
			}

		}

		private void lvwMsgs_SelectedIndexChanged(object sender, System.EventArgs e)
		{

			if (lvwMsgs.SelectedItems.Count == 0)
			{
			}
			else
			{
				string tmpString = null;
				tmpString = System.Convert.ToString(wcServerAPI.GetText("wc:\\conf(" + lvwMsgs.SelectedItems[0].SubItems[5].Text.Trim() + ")\\message(" + lvwMsgs.SelectedItems[0].SubItems[4].Text.Trim() + ")")).Trim();
				txtMSGBody.Text = tmpString.Replace("\n", Environment.NewLine);
			}

		}

		private void miniRptcmdFiles_Click(object sender, System.EventArgs eventArgs)
		{

			if ((((Button)sender).Name) == this.cmdFileOpen.Name)
			{
					////Open
					s_LoadFileForm();
			}
			else if ((((Button)sender).Name) == this.cmdFileRefresh.Name)
			{
					////Refresh List
					s_ReloadFiles();
			}

		}

		private void miniRptcmdUsers_Click(object sender, System.EventArgs e)
		{

			if ((((Button)sender).Name) == this.cmdUsersOpen.Name)
			{
					s_LoadUserForm();
			}
			else if ((((Button)sender).Name) == this.cmdUsersRefresh.Name)
			{
					f_LoadWCUsers();
			}

		}

		private void miniRptLvws_DblClick(object sender, System.EventArgs eventArgs)
		{

			if ((((ListView)sender).Name) == this.lvwFiles.Name)
			{
					s_LoadFileForm();
			}
			else if ((((ListView)sender).Name) == this.lvwMsgs.Name)
			{
					s_LoadMsgForm();
			}
			else if ((((ListView)sender).Name) == this.lvwUsers.Name)
			{
					s_LoadUserForm();
			}

		}

		private void miniRptcmdMsgs_Click(object sender, System.EventArgs eventArgs)
		{

			frmMSG myNewMSG = new frmMSG();
			wcServerAPI.TMsgHeader wMSG = new wcServerAPI.TMsgHeader();

			if ((((Button)sender).Name) == this.cmdMsgOpen.Name)
			{
					////Open MSG
					s_LoadMsgForm();
			}
			else if ((((Button)sender).Name) == this.cmdMsgRefresh.Name)
			{
					////Refresh Display
					s_ReloadMessages();
			}
			else if ((((Button)sender).Name) == this.cmdMsgNew.Name)
			{
					myNewMSG.Conference = ((clsList)(cmbMAreas.Items[cmbMAreas.SelectedIndex])).ItemData;
					myNewMSG.MsgID = -1;
					myNewMSG.MessageType = frmMSG.MsgWindowType.ENUM_NEWMESSAGE;
					myNewMSG.PrepForMessage();
					myNewMSG.Show();
			}
			else if ((((Button)sender).Name) == this.cmdMsgDelete.Name)
			{
					if (lvwMsgs.SelectedItems.Count == 0)
					{
					}
					else
					{
						DialogResult questAskSure = MessageBox.Show("Are you sure you wish to delete this message?", "Confirm Delete...", MessageBoxButtons.OK);
						if (questAskSure == System.Windows.Forms.DialogResult.Yes)
						{
							if (wcServerAPI.GetMessageById(System.Convert.ToInt32(lvwMsgs.SelectedItems[0].SubItems[5].Text), System.Convert.ToInt32(lvwMsgs.SelectedItems[0].SubItems[4].Text), ref wMSG))
							{
								if (wcServerAPI.DeleteMessage(ref wMSG))
								{
									lvwMsgs.Items.Remove(lvwMsgs.SelectedItems[0]);
								}
								else
								{
									MessageBox.Show("Error removing the selected message", "WINS Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}
							else
							{
								MessageBox.Show("Error finding the selected message", "WINS Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
			}

		}

		private void tabMain_SelectedIndexChanged(object sender, System.EventArgs e)
		{

			My.MyApplication.Application.DoEvents();

			switch (tabMain.SelectedTab.Tag.ToString())
			{
				case "INFO":
					////Information
					f_GetWCInformation();
					break;
				case "USERS":
					////Users
					////Only load them once when its first accessed
					if (lvwUsers.Items.Count == 0)
					{
						f_LoadWCUsers();
					}
					break;
				case "MSGS":
					////Messages
					if (lvwMsgs.Items.Count == 0)
					{
						f_LoadWCMSGGroups();
					}
					break;
				case "FILES":
					////Files
					if (lvwFiles.Items.Count == 0)
					{
						f_LoadWCFileGroups();
					}
					break;
			}

			My.MyApplication.Application.DoEvents();

		}

	#endregion

	#region Private Functions ...

		private short f_GetWCInformation()
		{

			try
			{
				wcServerAPI.TMakewild myMW = new wcServerAPI.TMakewild();
				if (wcServerAPI.GetMakewild(ref myMW))
				{
					txtSystemName.Text = modBSMiniRPT.BBSName.Trim();
					txtSysop.Text = modBSMiniRPT.BBSSysopName.Trim();
					txtFirstCall.Text = myMW.FirstCall.Trim();
					txtRegNum.Text = myMW.RegString.Trim();
					txtServerBuild.Text = wcServerAPI.GetWildcatBuild().ToString().Trim();
					txtTotalConfs.Text = wcServerAPI.GetConferenceCount().ToString().Trim();
					txtActiveConfs.Text = wcServerAPI.GetEffectiveConferenceCount(0, 0).ToString().Trim();
					txtConfGroups.Text = wcServerAPI.GetConferenceGroupCount().ToString().Trim();
					txtTotalFileAreas.Text = wcServerAPI.GetFileAreaCount().ToString().Trim();
					txtActiveFileAreas.Text = wcServerAPI.GetEffectiveFileAreaCount(0, 0).ToString().Trim();
					txtFileGroups.Text = wcServerAPI.GetFileGroupCount().ToString().Trim();
					txtTotalSecurity.Text = wcServerAPI.GetSecurityProfileCount().ToString().Trim();
					txtDoors.Text = wcServerAPI.GetDoorCount().ToString().Trim();
					txtLanguages.Text = wcServerAPI.GetLanguageCount().ToString().Trim();
					txtTotalMsgs.Text = wcServerAPI.GetTotalMessages().ToString().Trim();
					txtTotalUsersOn.Text = wcServerAPI.GetUsersOnline().ToString().Trim();
					txtTotalFiles.Text = wcServerAPI.GetTotalFiles().ToString().Trim();
					txtTotalUsers.Text = wcServerAPI.GetTotalUsers().ToString().Trim();
					txtTotalCalls.Text = wcServerAPI.GetTotalCalls(0).ToString().Trim();
					txtMaxUserCount.Text = wcServerAPI.GetMaximumUserCount().ToString().Trim();
				}
				else
				{
					MessageBox.Show("Error pulling the MakeWild information", "WINServer DLL Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return 0;
		}

		private short f_LoadWCFileAreas(int lngFGroup)
		{

			My.MyApplication.Application.DoEvents();

			modBSMiniRPT.MouseHour();

			try
			{
				wcServerAPI.TFileArea wFileArea = new wcServerAPI.TFileArea();
				int AREA = 0;

				cmbFArea.Items.Clear();
				cmbFArea.Items.Add(new clsList("(None)", -1));

				AREA = wcServerAPI.GetFirstFileArea(lngFGroup, 0);

				while (AREA > -1)
				{
					if (wcServerAPI.GetFileArea(AREA, ref wFileArea))
					{
						if (wFileArea.name.Trim() == "")
						{
						}
						else
						{
							cmbFArea.Items.Add(new clsList(wFileArea.name.Trim(), wFileArea.Number));
						}
						AREA = wcServerAPI.GetNextFileArea(lngFGroup, 0, AREA);
					}
					else
					{
						AREA = -1;
					}
				}

				cmbFArea.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			modBSMiniRPT.MouseNormal();

			My.MyApplication.Application.DoEvents();

			return 0;
		}

		private short f_LoadWCFileGroups()
		{

			My.MyApplication.Application.DoEvents();

			try
			{
				int myX = 0;
				int lngGCount = 0;
				wcServerAPI.TFileGroup myFGroup = new wcServerAPI.TFileGroup();

				lngGCount = wcServerAPI.GetFileGroupCount();

				int tempFor1 = lngGCount;
				for (myX = 0; myX < tempFor1; myX++)
				{
					if (wcServerAPI.GetFileGroup(myX, ref myFGroup))
					{
						if (myFGroup.name.Trim() != "")
						{
							cmbFGroup.Items.Add(new clsList(myFGroup.name.Trim(), myFGroup.Number));
						}
					}
				}

				if (cmbFGroup.Items.Count > 0)
				{
					cmbFGroup.SelectedIndex = 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			My.MyApplication.Application.DoEvents();

			return 0;
		}

		private short f_LoadWCFilesByArea(int lngArea)
		{

			My.MyApplication.Application.DoEvents();

			try
			{
				wcServerAPI.TFileRecord wFile = new wcServerAPI.TFileRecord();
				System.Windows.Forms.ListViewItem Itmx = null;
				int fID = 0;
				int lngFileCount = 0;

				lvwFiles.Items.Clear();

				lngFileCount = wcServerAPI.GetTotalFilesInArea(lngArea);

				if (lngFileCount > 0)
				{
					pbFiles.Maximum = lngFileCount;
					if (wcServerAPI.SearchFileRecByAreaName(lngArea, "", ref wFile, ref fID))
					{
						pbFiles.Value = pbFiles.Value + 1;
						Itmx = lvwFiles.Items.Add(wFile.Name.Trim(), 2);
						Itmx.SubItems.Add(wFile.Area.ToString().Trim());
						Itmx.SubItems.Add(modBSMiniRPT.DateToDateString(wFile.FileTime, true).Trim());
						Itmx.SubItems.Add(wFile.Uploader.Name.Trim());
						Itmx.SubItems.Add(wFile.Description.Trim());
						while (wcServerAPI.GetNextFileRec(wcServerAPI.FileAreaNameKey, ref wFile, ref fID))
						{
							if (pbFiles.Value == pbFiles.Maximum)
							{
								break;
							}
							else
							{
								pbFiles.Value = pbFiles.Value + 1;
								Itmx = lvwFiles.Items.Add(wFile.Name.Trim(), 2);
								Itmx.SubItems.Add(wFile.Area.ToString().Trim());
								Itmx.SubItems.Add(modBSMiniRPT.DateToDateString(wFile.FileTime, true).Trim());
								Itmx.SubItems.Add(wFile.Uploader.Name.Trim());
								Itmx.SubItems.Add(wFile.Description.Trim());
							}
						}
						if (lvwFiles.Items.Count > 0)
						{
							lvwFiles.Items[0].Selected = true;
						}
					}
				}
				pbFiles.Value = 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			My.MyApplication.Application.DoEvents();

			return 0;
		}

		private short f_LoadWCMSGAreas(int lngMGroup)
		{

			My.MyApplication.Application.DoEvents();

			modBSMiniRPT.MouseHour();

			try
			{
				wcServerAPI.TConfDesc msgCONFD = new wcServerAPI.TConfDesc();
				int Conf = 0;

				cmbMAreas.Items.Clear();
				cmbMAreas.Items.Add(new clsList("(None)", -1));

				Conf = wcServerAPI.GetFirstConference(lngMGroup, 0);

				while (Conf > -1)
				{
					if (wcServerAPI.GetConfDesc(Conf, ref msgCONFD))
					{
						if (msgCONFD.name.Trim() == "")
						{
						}
						else
						{
							cmbMAreas.Items.Add(new clsList(msgCONFD.name.Trim(), msgCONFD.Number));
						}
						Conf = wcServerAPI.GetNextConference(lngMGroup, 0, Conf);
					}
					else
					{
						Conf = -1;
					}
				}
				cmbMAreas.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			modBSMiniRPT.MouseNormal();

			My.MyApplication.Application.DoEvents();

			return 0;
		}

		private short f_LoadWCMSGGroups()
		{

			My.MyApplication.Application.DoEvents();

			try
			{
				int myX = 0;
				int lngGCount = 0;
				wcServerAPI.TConferenceGroup myCGroup = new wcServerAPI.TConferenceGroup();

				lngGCount = wcServerAPI.GetConferenceGroupCount();

				int tempFor1 = lngGCount;
				for (myX = 0; myX < tempFor1; myX++)
				{
					if (wcServerAPI.GetConferenceGroup(myX, ref myCGroup))
					{
						if (myCGroup.name.Trim() != "")
						{
							cmbMGroups.Items.Add(new clsList(myCGroup.name.Trim(), myCGroup.Number));
						}
					}
				}

				if (cmbMGroups.Items.Count > 0)
				{
					cmbMGroups.SelectedIndex = 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			My.MyApplication.Application.DoEvents();

			return 0;
		}

		private short f_LoadWCMSGSByArea(int lngArea)
		{

			My.MyApplication.Application.DoEvents();

			try
			{
				wcServerAPI.TMsgHeader wMSG = new wcServerAPI.TMsgHeader();
				System.Windows.Forms.ListViewItem Itmx = null;
				int lngMSGID = 0;
				int lngMSGCount = 0;

				lvwMsgs.Items.Clear();

				lngMSGCount = wcServerAPI.GetTotalMessagesInConference(lngArea);

				lngMSGID = 0;

				if (lngMSGCount > 0)
				{
					pbMsgs.Maximum = lngMSGCount;
					while (wcServerAPI.SearchMessageById(lngArea, lngMSGID, ref wMSG))
					{
						if (pbMsgs.Value + 1 > pbMsgs.Maximum)
						{
							pbMsgs.Maximum = pbMsgs.Value + 1;
						}
						pbMsgs.Value = pbMsgs.Value + 1;
						Itmx = lvwMsgs.Items.Add(wMSG.MsgTo.Name.Trim(), 1);
						Itmx.SubItems.Add(wMSG.MsgFrom.Name.Trim());
						Itmx.SubItems.Add(wMSG.Subject.Trim());
						Itmx.SubItems.Add(modBSMiniRPT.DateToDateString(wMSG.MsgTime, true).Trim());
						Itmx.SubItems.Add(wMSG.Id.ToString().Trim());
						Itmx.SubItems.Add(wMSG.Conference.ToString().Trim());
						lngMSGID = wMSG.Id + 1;
					}
				}
				pbMsgs.Value = 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			My.MyApplication.Application.DoEvents();

			return 0;
		}

		private short f_LoadWCUsers()
		{

			My.MyApplication.Application.DoEvents();

			try
			{
				int lngTotal = 0;
				wcServerAPI.TUser wUser = new wcServerAPI.TUser();
				int myX = 0;
				System.Windows.Forms.ListViewItem Itmx = null;
				int tID = 0;

				lngTotal = wcServerAPI.GetTotalUsers();
				////For demo purposes we are just loading
				////100 Users in the list
				if (lngTotal > 100)
				{
					lngTotal = 100;
				}

				lvwUsers.Items.Clear();

				if (lngTotal > 0)
				{
					pbUsers.Maximum = lngTotal;
					if (wcServerAPI.GetFirstUser(wcServerAPI.UserLastNameKey, ref wUser, ref tID))
					{
						pbUsers.Value = pbUsers.Value + 1;
						Itmx = lvwUsers.Items.Add("A-" + wUser.Info.ID.ToString().Trim(), wUser.Info.Name.Trim(), 0);
						Itmx.SubItems.Add(wUser.Info.ID.ToString().Trim());
						Itmx.SubItems.Add(wUser.RealName.Trim());
						Itmx.SubItems.Add(wUser.Security[0].SecurityProfile.Trim());
						Itmx.SubItems.Add(modBSMiniRPT.DateToDateString(wUser.FirstCall, true).Trim());
						Itmx.SubItems.Add(modBSMiniRPT.DateToDateString(wUser.LastCall, true).Trim());
						int tempFor1 = lngTotal;
						for (myX = 2; myX <= tempFor1; myX++)
						{
							pbUsers.Value = pbUsers.Value + 1;
							if (wcServerAPI.GetNextUser(wcServerAPI.UserLastNameKey, ref wUser, ref tID))
							{
								Itmx = lvwUsers.Items.Add("A-" + wUser.Info.ID.ToString().Trim(), wUser.Info.Name.Trim(), 0);
								Itmx.SubItems.Add(wUser.Info.ID.ToString().Trim());
								Itmx.SubItems.Add(wUser.RealName.Trim());
								Itmx.SubItems.Add(wUser.Security[0].SecurityProfile.Trim());
								Itmx.SubItems.Add(modBSMiniRPT.DateToDateString(wUser.FirstCall, true).Trim());
								Itmx.SubItems.Add(modBSMiniRPT.DateToDateString(wUser.LastCall, true).Trim());
							}
						}
					}
					else
					{
						MessageBox.Show("Error accessing the user database", "User DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				pbUsers.Value = 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			My.MyApplication.Application.DoEvents();

			return 0;
		}

	#endregion

	#region Private SubRoutines ...

		private void s_LoadFileForm()
		{

			try
			{
				frmFile myNewFile = new frmFile();
				if (lvwFiles.SelectedItems.Count == 0)
				{
				}
				else
				{
					myNewFile.PrepFiles(((clsList)(cmbFArea.Items[cmbFArea.SelectedIndex])).ItemData, lvwFiles.SelectedItems[0].Text);
					myNewFile.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void s_LoadMsgForm()
		{

			try
			{
				frmMSG myNewMSG = new frmMSG();
				if (lvwMsgs.SelectedItems.Count == 0)
				{
				}
				else
				{
					myNewMSG.Conference = System.Convert.ToInt32(lvwMsgs.SelectedItems[0].SubItems[5].Text.Trim());
					myNewMSG.MsgID = System.Convert.ToInt32(lvwMsgs.SelectedItems[0].SubItems[4].Text.Trim());
					myNewMSG.MessageType = frmMSG.MsgWindowType.ENUM_VIEWONLY;
					myNewMSG.PrepForMessage();
					myNewMSG.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void s_LoadUserForm()
		{

			try
			{
				frmUser myNewUser = new frmUser();
				if (lvwUsers.SelectedItems.Count == 0)
				{
					////Checking to make sure there is a selected item
				}
				else
				{
					myNewUser.UserID = System.Convert.ToInt32(lvwUsers.SelectedItems[0].SubItems[1].Text);
					myNewUser.LoadUser();
					myNewUser.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void s_ReloadFiles()
		{

			My.MyApplication.Application.DoEvents();

			try
			{
				txtFileDesc.Text = "";
				if (((clsList)(cmbFArea.Items[cmbFArea.SelectedIndex])).ItemData == -1)
				{
					lvwFiles.Items.Clear();
				}
				else
				{
					f_LoadWCFilesByArea(((clsList)(cmbFArea.Items[cmbFArea.SelectedIndex])).ItemData);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			My.MyApplication.Application.DoEvents();

		}

		private void s_ReloadMessages()
		{

			My.MyApplication.Application.DoEvents();

			try
			{
				txtMSGBody.Text = "";

				if (((clsList)(cmbMAreas.Items[cmbMAreas.SelectedIndex])).ItemData == -1)
				{
					lvwMsgs.Items.Clear();
				}
				else
				{
					f_LoadWCMSGSByArea(((clsList)(cmbMAreas.Items[cmbMAreas.SelectedIndex])).ItemData);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			My.MyApplication.Application.DoEvents();

		}

        #endregion

        private void _fraNavigation_0_Enter(object sender, EventArgs e)
        {

        }
    }
} //end of root namespace