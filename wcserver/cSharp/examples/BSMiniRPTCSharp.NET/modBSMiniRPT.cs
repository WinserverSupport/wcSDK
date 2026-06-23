using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using wcSDK;

namespace BSMiniRPT
{
	internal static class modBSMiniRPT
	{

	#region Public Windows Constants ...

		public const int LOCALE_SSHORTDATE = 0X1F;
		public const int LOCALE_SDATE = 0X1D;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=25)]
		public static string DateMask;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=25)]
		public static string DateSeparator;

	#endregion

	#region Public Windows DLL Imports

		[DllImport("kernel32.dll", EntryPoint="GetLocaleInfoA")]
		public extern static int GetLocaleInfo(int Locale, int LCType, string lpLCData, int cchData);

		[DllImport("kernel32.dll", EntryPoint="GetDateFormatA")]
		public extern static int GetDateFormat(int Locale, int dwFlags, ref wcServerAPI.SYSTEMTIME lpDate, string lpFormat, string lpDateStr, int cchDate);

		[DllImport("kernel32.dll")]
		public extern static int GetThreadLocale();

	#endregion

	#region Public Variables ...

		public static string BBSName;
		public static string BBSReg;
		public static string BBSSysopName;
        public static string ConnectedServer;
		public static bool isNewWINS;

	#endregion

	#region Public Functions ...

		public static int CenterForm(System.Windows.Forms.Form frmWhatForm)
		{

			frmWhatForm.Left = System.Convert.ToInt32((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - frmWhatForm.Width) / 2);
			frmWhatForm.Top = System.Convert.ToInt32((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - frmWhatForm.Height) / 2);

			return 0;
		}

		public static short MouseHour()
		{

			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

			return 0;
		}

		public static short MouseNormal()
		{

			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

			return 0;
		}


		public static bool ConnectToWINS()
		{
			return ConnectToWINS(null);
		}

		public static bool ConnectToWINS(object objStatus)
		{
			bool tempConnectToWINS = false;

			wcServerAPI.TMakewild myMW = new wcServerAPI.TMakewild();
			int RetVal = 0;

			tempConnectToWINS = true;

			if (objStatus == null)
			{
			}
			else
			{
				((System.Windows.Forms.Label)objStatus).Text = "Finding WINS Server...";
				((System.Windows.Forms.Label)objStatus).Refresh();
			}

			if (wcServerAPI.WildcatServerConnect(0))
			{
                ConnectedServer = wcSDK.wcServerAPI.GetConnectedServer();
                if (objStatus == null)
				{
				}
				else
				{
                    ((System.Windows.Forms.Label)objStatus).Text = "Creating Context...";
					((System.Windows.Forms.Label)objStatus).Refresh();
				}
				if (wcServerAPI.WildcatServerCreateContext())
				{
					if (objStatus == null)
					{
					}
					else
					{
						((System.Windows.Forms.Label)objStatus).Text = "Logging in as SYSTEM...";
						((System.Windows.Forms.Label)objStatus).Refresh();
					}
					if (wcServerAPI.LoginSystem())
					{
					}
					else
					{
						wcServerAPI.WildcatServerDeleteContext();
						MessageBox.Show("Unable to login as system" + Environment.NewLine + "Error:  " + WildcatError(Marshal.GetLastWin32Error()), "Can't login", MessageBoxButtons.OK, MessageBoxIcon.Error);
						tempConnectToWINS = false;
					}
					if (objStatus == null)
					{
					}
					else
					{
						((System.Windows.Forms.Label)objStatus).Text = "Please Wait (continuing)...";
						((System.Windows.Forms.Label)objStatus).Refresh();
					}
				}
				else
				{
                    MessageBox.Show("Unable to create context" + Environment.NewLine + "Error:  " + WildcatError(Marshal.GetLastWin32Error()), "Unable to create context", MessageBoxButtons.OK, MessageBoxIcon.Error);
					tempConnectToWINS = false;
				}
			}
			else
			{
                MessageBox.Show("Unable to connect to server" + Environment.NewLine + "Error:  " + WildcatError(Marshal.GetLastWin32Error()), "Unable to connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tempConnectToWINS = false;
			}

			if (System.Convert.ToSingle(wcServerAPI.GetWildcatVersion().ToString().Trim() + "." + wcServerAPI.GetWildcatBuild().ToString().Trim()) > 1.44)
			{
				isNewWINS = true;
			}

			wcServerAPI.GetMakewild(ref myMW);

			BBSName = myMW.BBSName.Trim();
			BBSReg = myMW.RegString.Trim();
			BBSSysopName = myMW.SysopName.Trim();

			return tempConnectToWINS;
		}


		public static string DateToDateString(wcServerAPI.FileTime ft)
		{
			return DateToDateString(ft, false);
		}

		public static string DateToDateString(wcServerAPI.FileTime ft, bool DoTime)
		{
			string tempDateToDateString = null;

			wcServerAPI.SYSTEMTIME s = new wcServerAPI.SYSTEMTIME();
			string DateStr = "";
			int nResult = 0;

			if (GetLocaleInfo(GetThreadLocale(), LOCALE_SSHORTDATE, DateMask, 25) == 0)
			{
				DateMask = "MM/dd/yyyy";
			}
			if (GetLocaleInfo(GetThreadLocale(), LOCALE_SDATE, DateSeparator, 25) == 0)
			{
				DateSeparator = "/";
			}

			tempDateToDateString = "";

			if (wcServerAPI.FileTimeToSystemTime(ref ft, ref s) == 0)
			{
				tempDateToDateString = "";
			}
			else
			{
				nResult = GetDateFormat(GetThreadLocale(), 0, ref s, DateMask.Trim(), DateStr, 25);

				tempDateToDateString = DateStr;

				string myTempString = null;
				if (tempDateToDateString.Trim() == "")
				{
					myTempString = s.wMonth.ToString("0#") + DateSeparator.Trim() + s.wDay.ToString("0#") + DateSeparator.Trim() + s.wYear.ToString("####");
					if (DoTime)
					{
						myTempString = myTempString + " " + s.wHour.ToString("0#") + ":" + s.wMinute.ToString("0#");
					}
					if (Microsoft.VisualBasic.Information.IsDate(myTempString))
					{
						tempDateToDateString = myTempString;
					}
					else
					{
						tempDateToDateString = System.DateTime.Now.ToString("d") + " " + System.DateTime.Now.ToString("t");
					}
				}
				else
				{
					myTempString = tempDateToDateString;
					if (DoTime)
					{
						myTempString = tempDateToDateString + " " + s.wHour.ToString("0#") + ":" + s.wMinute.ToString("0#");
					}
					if (Microsoft.VisualBasic.Information.IsDate(myTempString))
					{
						tempDateToDateString = myTempString;
					}
					else
					{
						tempDateToDateString = System.DateTime.Now.ToString("d") + " " + System.DateTime.Now.ToString("t");
					}
				}
			}

			return tempDateToDateString;
		}

        public static string WildcatError(int DLLError)
        {
            string tempWildcatError = null;
            if (DLLError == wcServerAPI.WC_STATUS_BASE)
            {
                tempWildcatError = "WINS (Base Error)";
            }
            else if (DLLError == wcServerAPI.WC_UNSUPPORTED_VERSION)
            {
                tempWildcatError = "WINS (Unsupported Version)";
            }
            else if (DLLError == wcServerAPI.WC_CONTEXT_NOT_INITIALIZED)
            {
                tempWildcatError = "WIN (Server Context not initialized)";
            }
            else if (DLLError == wcServerAPI.WC_INVALID_NODE_NUMBER)
            {
                tempWildcatError = "WINS (Invalid Node Number)";
            }
            else if (DLLError == wcServerAPI.WC_USER_NOT_FOUND)
            {
                tempWildcatError = "WINS (User was not found)";
            }
            else if (DLLError == wcServerAPI.WC_INCORRECT_PASSWORD)
            {
                tempWildcatError = "WINS (Incorrect Password)";
            }
            else if (DLLError == wcServerAPI.WC_USER_NOT_LOGGED_IN)
            {
                tempWildcatError = "WINS (User is not logged in)";
            }
            else if (DLLError == wcServerAPI.WC_INVALID_INDEX)
            {
                tempWildcatError = "WINS (Invalid Index)";
            }
            else if (DLLError == wcServerAPI.WC_INVALID_OBJECT_ID)
            {
                tempWildcatError = "WINS (Invalid Object ID)";
            }
            else if (DLLError == wcServerAPI.WC_GROUP_ALREADY_EXISTS)
            {
                tempWildcatError = "WINS (Group Already Exists)";
            }
            else if (DLLError == wcServerAPI.WC_GROUP_NOT_FOUND)
            {
                tempWildcatError = "WINS (Group Not Found)";
            }
            else if (DLLError == wcServerAPI.WC_OBJECTID_ALREADY_EXISTS)
            {
                tempWildcatError = "WINS (ObjectID already Exists)";
            }
            else if (DLLError == wcServerAPI.WC_NAME_NOT_FOUND)
            {
                tempWildcatError = "WINS (Name Not Found)";
            }
            else if (DLLError == wcServerAPI.WC_NAME_ALREADY_EXISTS)
            {
                tempWildcatError = "WINS (Name Already exists)";
            }
            else if (DLLError == wcServerAPI.WC_ALREADY_LOGGED_IN)
            {
                tempWildcatError = "WINS (Wildcat already logged in)";
            }
            else if (DLLError == wcServerAPI.WC_ITEM_NOT_FOUND)
            {
                tempWildcatError = "WINS (Item Not Found)";
            }
            else if (DLLError == wcServerAPI.WC_ITEM_REQUIRES_NAME)
            {
                tempWildcatError = "WINS (Item Requires a name)";
            }
            else if (DLLError == wcServerAPI.WC_ITEM_ALREADY_EXISTS)
            {
                tempWildcatError = "WINS (Item Already Exists)";
            }
            else if (DLLError == wcServerAPI.WC_ITEM_NAME_DIFFERENT)
            {
                tempWildcatError = "WINS (Item Name is Different)";
            }
            else if (DLLError == wcServerAPI.WC_RECORD_NOT_FOUND)
            {
                tempWildcatError = "WINS (Record Not Found)";
            }
            else if (DLLError == wcServerAPI.WC_ACCESS_DENIED)
            {
                tempWildcatError = "WINS (Access is DENIED)";
            }
            else if (DLLError == wcServerAPI.WC_NODE_ALREADY_IN_USE)
            {
                tempWildcatError = "WINS (Node is already is use)";
            }
            else if (DLLError == wcServerAPI.WC_USER_ALREADY_LOGGED_IN)
            {
                tempWildcatError = "WINS (Users already logged in)";
            }
            else if (DLLError == wcServerAPI.WC_INVALID_CONNECTION_ID)
            {
                tempWildcatError = "WINS (Invalid Connection ID)";
            }
            else if (DLLError == wcServerAPI.WC_INVALID_CONFERENCE)
            {
                tempWildcatError = "WINS (Invalid Conference)";
            }
            else if (DLLError == wcServerAPI.WC_INVALID_CONFERENCEGROUP)
            {
                tempWildcatError = "WINS (Invalid Conference Group)";
            }
            else if (DLLError == wcServerAPI.WC_INVALID_FILEAREA)
            {
                tempWildcatError = "WINS (Invalid File Area)";
            }
            else if (DLLError == wcServerAPI.WC_INVALID_FILEGROUP)
            {
                tempWildcatError = "WINS (Invalid File Group)";
            }
            else if (DLLError == wcServerAPI.WC_DUPLICATE_RECORD)
            {
                tempWildcatError = "WINS (Duplicate Record)";
            }
            else if (DLLError == wcServerAPI.WC_NO_ACTION_TAKEN)
            {
                tempWildcatError = "WINS (No Action Taken)";
            }
            else if (DLLError == wcServerAPI.WC_ACCOUNT_LOCKED_OUT)
            {
                tempWildcatError = "WINS (Account has been locked out)";
            }
            else if (DLLError == wcServerAPI.WC_FILE_SEARCH_SYNTAX)
            {
                tempWildcatError = "WINS (File Search Sytax Error)";
            }
            else if (DLLError == wcServerAPI.WC_REQUEST_NOT_ADDED)
            {
                tempWildcatError = "WINS (Request was not added)";
            }
            else if (DLLError == wcServerAPI.WC_CONTEXT_MULTI_REFS)
            {
                tempWildcatError = "WINS (Mutlpile references - Context)";
            }
            else if (DLLError == wcServerAPI.WC_CONTEXT_ALREADY_INITIALIZED)
            {
                tempWildcatError = "WINS (Context has already been initialized)";
            }
            else if (DLLError == wcServerAPI.WC_NO_NODES_AVAILABLE)
            {
                tempWildcatError = "WINS (There are no nodes available)";
            }
            else
            {
                tempWildcatError = "Application (Unspecified Error) ---- ";
            }
            return tempWildcatError;
        }
    
#endregion

	}
} //end of root namespace