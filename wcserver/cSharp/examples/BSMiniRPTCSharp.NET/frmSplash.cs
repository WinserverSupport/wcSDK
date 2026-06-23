using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BSMiniRPT
{
	internal partial class frmSplash : System.Windows.Forms.Form
	{


		private void frmSplash_Load(object eventSender, System.EventArgs eventArgs)
		{

			modBSMiniRPT.CenterForm(this);

			this.Refresh();

		}


    }
} //end of root namespace