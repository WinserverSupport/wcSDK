using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BSMiniRPT
{
	public class clsList
	{

		private string mvarName = "";
		private int mvarItemData = 0;

	#region Public Properties ...

		public string DisplayName
		{
			get
			{
				return mvarName;
			}
			set
			{
				mvarName = value;
			}
		}

		public int ItemData
		{
			get
			{
				return mvarItemData;
			}
			set
			{
				mvarItemData = value;
			}
		}

	#endregion

	#region Public Subroutines ...

		public clsList()
		{

		}

		public clsList(string DisplayName, int ItemData)
		{

			mvarName = DisplayName;
			mvarItemData = ItemData;

		}

	#endregion

	#region Public Functions ...

		public override string ToString()
		{

			return mvarName;

		}

	#endregion

	}

} //end of root namespace