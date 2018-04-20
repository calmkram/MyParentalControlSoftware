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
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace MyParentalControlSoftware
{
    public partial class MainAppWindow : Form
    {
        public MainAppWindow()
        {
            InitializeComponent();

            cmbUserList.Items.Clear();
            SelectQuery myQuery = new SelectQuery("Win32_UserAccount", "LocalAccount=true AND SIDType=1 AND AccountType=512");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(myQuery);
            foreach (ManagementObject envVar in searcher.Get())
            {
                cmbUserList.Items.Add(envVar["Name"]);
            }

            // Load the hourly times in the From and To time drop down lists
            DateTime dtFromTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime dtToTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            cmbSunFromTime.Items.Clear();
            cmbMonFromTime.Items.Clear();
            cmbTuesFromTime.Items.Clear();
            cmbWedFromTime.Items.Clear();
            cmbThurFromTime.Items.Clear();
            cmbFriFromTime.Items.Clear();
            cmbSatFromTime.Items.Clear();
            cmbSunToTime.Items.Clear();
            cmbMonToTime.Items.Clear();
            cmbTuesToTime.Items.Clear();
            cmbWedToTime.Items.Clear();
            cmbThurToTime.Items.Clear();
            cmbFriToTime.Items.Clear();
            cmbSatToTime.Items.Clear();

            for( int iIndex = 0; iIndex < 24; iIndex++ )
            {
                cmbSunFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbMonFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbTuesFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbWedFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbThurFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbFriFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbSatFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbSunToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbMonToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbTuesToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbWedToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbThurToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbFriToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbSatToTime.Items.Add(dtToTime.ToShortTimeString());
                dtFromTime = dtFromTime.AddHours(1);
                dtToTime = dtToTime.AddHours(1);
            }
        }

        private void UserList_TextChanged(object sender, EventArgs e)
        {
            var varSelectedUserLogonTimes = new List<LogonTime>();
            String sSelectedUserName = "";
            PrincipalContext pctxLocalMachine;
            UserPrincipal usrpSelectedUser;

            if (cmbUserList.SelectedIndex > -1)
            {
                grpbxTimeRestrictions.Visible = true;
                //grpbxAppAndWebAccess.Visible = true;

                sSelectedUserName = cmbUserList.SelectedItem.ToString();
                // Testing to see if I can use the WMI API for Windows Parental Controls
                pctxLocalMachine = new PrincipalContext(ContextType.Machine);
                usrpSelectedUser = UserPrincipal.FindByIdentity(pctxLocalMachine, IdentityType.SamAccountName, sSelectedUserName);

                varSelectedUserLogonTimes = PermittedLogonTimes.GetLogonTimes(usrpSelectedUser.PermittedLogonTimes);

                cmbSunFromTime.SelectedIndex = -1;
                cmbMonFromTime.SelectedIndex = -1;
                cmbTuesFromTime.SelectedIndex = -1;
                cmbWedFromTime.SelectedIndex = -1;
                cmbThurFromTime.SelectedIndex = -1;
                cmbFriFromTime.SelectedIndex = -1;
                cmbSatFromTime.SelectedIndex = -1;
                cmbSunToTime.SelectedIndex = -1;
                cmbMonToTime.SelectedIndex = -1;
                cmbTuesToTime.SelectedIndex = -1;
                cmbWedToTime.SelectedIndex = -1;
                cmbThurToTime.SelectedIndex = -1;
                cmbFriToTime.SelectedIndex = -1;
                cmbSatToTime.SelectedIndex = -1;

                for ( int iIndex = 0; iIndex < varSelectedUserLogonTimes.Count; iIndex++ )
                {
                    LogonTime lExtractedTime = varSelectedUserLogonTimes.ElementAt(iIndex);

                    switch (lExtractedTime.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            cmbSunFromTime.SelectedIndex = cmbSunFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cmbSunToTime.SelectedIndex = cmbSunToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Monday:
                            cmbMonFromTime.SelectedIndex = cmbMonFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cmbMonToTime.SelectedIndex = cmbMonToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Tuesday:
                            cmbTuesFromTime.SelectedIndex = cmbTuesFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cmbTuesToTime.SelectedIndex = cmbTuesToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Wednesday:
                            cmbWedFromTime.SelectedIndex = cmbWedFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cmbWedToTime.SelectedIndex = cmbWedToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Thursday:
                            cmbThurFromTime.SelectedIndex = cmbThurFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cmbThurToTime.SelectedIndex = cmbThurToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Friday:
                            cmbFriFromTime.SelectedIndex = cmbFriFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cmbFriToTime.SelectedIndex = cmbFriToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Saturday:
                            cmbSatFromTime.SelectedIndex = cmbSatFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cmbSatToTime.SelectedIndex = cmbSatToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                    }
                }
            }
            else
            {
                grpbxTimeRestrictions.Visible = false;
                //grpbxAppAndWebAccess.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainAppWindow.ActiveForm.Close();
        }
    }
}
