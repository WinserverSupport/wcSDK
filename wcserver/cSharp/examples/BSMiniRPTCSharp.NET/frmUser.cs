using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using wcSDK;

namespace BSMiniRPT
{
	internal partial class frmUser : System.Windows.Forms.Form
	{


		private int mvarUID;

		public int UserID
		{
			get
			{
				return mvarUID;
			}
			set
			{
				mvarUID = value;
			}
		}

		public short LoadUser()
		{

			try
			{
				wcServerAPI.TUser wUser = new wcServerAPI.TUser();
				int uID = 0;

				if (wcServerAPI.GetUserById(mvarUID, ref wUser, ref uID))
				{
					txtUserName.Text = wUser.Info.Name.Trim();
					txtUserID.Text = wUser.Info.ID.ToString().Trim();
					txtUserRealName.Text = wUser.RealName.Trim();
					txtUserFrom.Text = wUser.From.Trim();
					txtUserAddress1.Text = wUser.Address1.Trim();
					txtUserAddress2.Text = wUser.Address2.Trim();
					txtUserCity.Text = wUser.City.Trim();
					txtUserState.Text = wUser.State.Trim();
					txtUserZip.Text = wUser.Zip.Trim();
					txtUserCountry.Text = wUser.Country.Trim();
					txtUserPhone.Text = wUser.PhoneNumber.Trim();
					txtUserDataPhone.Text = wcServerAPI.GetUserVariable(wUser.Info.ID, "Profile", "DataNumber", "");
				}
				else
				{
					MessageBox.Show("Error accessing the selected user", "WINS Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void cmdUsers_Click(object sender, System.EventArgs eventArgs)
		{

			int uID = 0;
			wcServerAPI.TUser wUser = new wcServerAPI.TUser();

			if ((((Button)sender).Name) == this.cmdUserUpdate.Name)
			{
					////Update user information
					if (txtUserName.Text.Trim() == "")
					{
						////Make sure AT LEAST the name is filled in
						MessageBox.Show("You must have a Name filled in", "Entry Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						////Searching for the user to fill out the complete
						////User information variable... Then update what we
						////need to change
						if (wcServerAPI.GetUserById(System.Convert.ToInt32(txtUserID.Text), ref wUser, ref uID))
						{
							wUser.Info.Name = txtUserName.Text.Trim();
							wUser.RealName = txtUserRealName.Text.Trim();
							wUser.From = txtUserFrom.Text.Trim();
							wUser.Address1 = txtUserAddress1.Text.Trim();
							wUser.Address2 = txtUserAddress2.Text.Trim();
							wUser.City = txtUserCity.Text.Trim();
							wUser.State = txtUserState.Text.Trim();
							wUser.Zip = txtUserZip.Text.Trim();
							wUser.Country = txtUserCountry.Text.Trim();
							wUser.PhoneNumber = txtUserPhone.Text.Trim();
							wcServerAPI.SetUserVariable(System.Convert.ToInt32(txtUserID.Text.Trim()), "Profile", "DataNumber", txtUserDataPhone.Text.Trim());
							if (!wcServerAPI.UpdateUser(ref wUser))
							{
								MessageBox.Show("Error updating the specified user", "WINS Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
						else
						{
							MessageBox.Show("Error accessing the specified user record", "WINS Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
			}
			else if ((((Button)sender).Name) == this.cmdUserCancel.Name)
			{
					////Unload form
					this.Dispose();
			}

		}

	}
} //end of root namespace