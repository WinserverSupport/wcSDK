using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using wcSDK;

namespace BSMiniRPT
{
	internal partial class frmFile : System.Windows.Forms.Form
	{


		public short PrepFiles(int lngArea, string strFileName)
		{

			try
			{
				wcServerAPI.TFileRecord wFile = new wcServerAPI.TFileRecord();
				wcServerAPI.TFileArea wFileA = new wcServerAPI.TFileArea();
				int fID = 0;

				if (wcServerAPI.GetFileRecByAreaName(lngArea, strFileName, ref wFile, ref fID))
				{
					if (wcServerAPI.GetFileArea(lngArea, ref wFileA))
					{
						if (wcServerAPI.WcExistFile("wc:\\file\\area(" + wFileA.Number.ToString().Trim() + ")\\" + wFile.Name.Trim()))
						{
							lblFStatus.Text = "**File Exists On Disk**";
						}
						txtFileArea.Text = "(" + wFile.Area.ToString().Trim() + "). " + wFileA.name.Trim();
						txtFileName.Text = wFile.Name.Trim();
						txtFileSize.Text = wFile.Size.ToString("###,###,###,###,###,###,###");
						txtFileUploader.Text = wFile.Uploader.Name.Trim();
						txtFilePassword.Text = wFile.Password.Trim();
						txtFileDate.Text = modBSMiniRPT.DateToDateString(wFile.FileTime, true).Trim();
						txtFileLastAccess.Text = modBSMiniRPT.DateToDateString(wFile.LastAccessed, true).Trim();
						txtFileDownloads.Text = wFile.Downloads.ToString().Trim();
						txtFileDescription.Text = wFile.Description.Trim();
					}
					else
					{
						MessageBox.Show("Error pulling the area description", "WINS Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
				}
				else
				{
					MessageBox.Show("Error pulling the selected file", "WINS Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected Error occurred" + Environment.NewLine + "Error:  " + ex.ToString() + Environment.NewLine + "Message:  " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return 0;
		}

		private void cmdFiles_Click(object eventSender, System.EventArgs eventArgs)
		{

			this.Dispose();

		}

	}
} //end of root namespace