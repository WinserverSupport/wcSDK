using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using wcSDK;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnConnect.Enabled = true;
            btnCreate.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (wcServerAPI.WildcatServerConnect(0))
            {
                listBox1.Items.Add("Connected");
                btnConnect.Enabled = false;
                btnCreate.Enabled =  true;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error Connection to Wildcat!");
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (wcServerAPI.WildcatServerCreateContext())
            {
                listBox1.Items.Add("Context Created");
                btnConnect.Enabled = false;
                btnCreate.Enabled = false;
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error Creating Context");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (wcServerAPI.WildcatServerDeleteContext())
            {
                listBox1.Items.Add("Context Deleted");
                btnConnect.Enabled = false;
                btnCreate.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error Deleting Context");
            }
        }
    }
}
