using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace MyParentalControlSoftware
{
    public partial class MainAppWindow : Form
    {
        public MainAppWindow()
        {
            InitializeComponent();

            cmbUserList.Items.Clear();
            SelectQuery myQuery = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(myQuery);
            foreach (ManagementObject envVar in searcher.Get())
            {
                cmbUserList.Items.Add(envVar["Name"]);
            }
        }

        private void UserList_TextChanged(object sender, EventArgs e)
        {
            if(cmbUserList.SelectedIndex > -1)
            {
                grpbxTimeRestrictions.Visible = true;
            }
            else
            {
                grpbxTimeRestrictions.Visible = false;
            }
        }
    }
}
