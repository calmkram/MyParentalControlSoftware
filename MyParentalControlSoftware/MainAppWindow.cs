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
        private int cv_iSunFromTime = -2, cv_iSunToTime = -2;
        private int cv_iMonFromTime = -2, cv_iMonToTime = -2;
        private int cv_iTueFromTime = -2, cv_iTueToTime = -2;
        private int cv_iWedFromTime = -2, cv_iWedToTime = -2;
        private int cv_iThuFromTime = -2, cv_iThuToTime = -2;
        private int cv_iFriFromTime = -2, cv_iFriToTime = -2;
        private int cv_iSatFromTime = -2, cv_iSatToTime = -2;

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
                            cv_iSunFromTime = cmbSunFromTime.SelectedIndex = cmbSunFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iSunToTime = cmbSunToTime.SelectedIndex = cmbSunToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Monday:
                            cv_iMonFromTime = cmbMonFromTime.SelectedIndex = cmbMonFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iMonToTime = cmbMonToTime.SelectedIndex = cmbMonToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Tuesday:
                            cv_iTueFromTime = cmbTuesFromTime.SelectedIndex = cmbTuesFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iTueToTime = cmbTuesToTime.SelectedIndex = cmbTuesToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Wednesday:
                            cv_iWedFromTime = cmbWedFromTime.SelectedIndex = cmbWedFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iWedToTime = cmbWedToTime.SelectedIndex = cmbWedToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Thursday:
                            cv_iThuFromTime = cmbThurFromTime.SelectedIndex = cmbThurFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iThuToTime = cmbThurToTime.SelectedIndex = cmbThurToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Friday:
                            cv_iFriFromTime = cmbFriFromTime.SelectedIndex = cmbFriFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iFriToTime = cmbFriToTime.SelectedIndex = cmbFriToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Saturday:
                            cv_iSatFromTime = cmbSatFromTime.SelectedIndex = cmbSatFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iSatToTime = cmbSatToTime.SelectedIndex = cmbSatToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                    }
                }

                if(usrpSelectedUser.Enabled == true)
                {
                    btnEnableUser.Enabled = false;
                    btnDisableUser.Enabled = true;
                }
                else
                {
                    btnEnableUser.Enabled = true;
                    btnDisableUser.Enabled = false;
                }
                btnSave.Enabled = true;
            }
            else
            {
                grpbxTimeRestrictions.Visible = false;
                //grpbxAppAndWebAccess.Visible = false;
            }
        }

        private void EnableUser_Click(object sender, EventArgs e)
        {
            String sSelectedUserName = "";
            PrincipalContext pctxLocalMachine;
            UserPrincipal usrpSelectedUser;

            try
            {
                sSelectedUserName = cmbUserList.SelectedItem.ToString();
                pctxLocalMachine = new PrincipalContext(ContextType.Machine);
                usrpSelectedUser = UserPrincipal.FindByIdentity(pctxLocalMachine, IdentityType.SamAccountName, sSelectedUserName);
                usrpSelectedUser.Enabled = true;

                usrpSelectedUser.Save();
                MessageBox.Show(sSelectedUserName + " has been enabled now!");
                usrpSelectedUser.Dispose();
                pctxLocalMachine.Dispose();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            btnEnableUser.Enabled = false;
            btnDisableUser.Enabled = true;
        }

        private void DisableUser_Click(object sender, EventArgs e)
        {
            String sSelectedUserName = "";
            PrincipalContext pctxLocalMachine;
            UserPrincipal usrpSelectedUser;

            try
            { 
            sSelectedUserName = cmbUserList.SelectedItem.ToString();
            pctxLocalMachine = new PrincipalContext(ContextType.Machine);
            usrpSelectedUser = UserPrincipal.FindByIdentity(pctxLocalMachine, IdentityType.SamAccountName, sSelectedUserName);
            usrpSelectedUser.Enabled = false;

            usrpSelectedUser.Save();

            MessageBox.Show(sSelectedUserName+" has been disabled now!");
            usrpSelectedUser.Dispose();
            pctxLocalMachine.Dispose();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            btnEnableUser.Enabled = true;
            btnDisableUser.Enabled = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MainAppWindow.ActiveForm.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DateTime dtFromTime, dtToTime;
            String sSelectedUserName = "", sFromTime = "1/1/1900 ", sToTime = "1/1/1900 ";
            LogonTime lSunLogonTime, lMonLogonTime, lTueLogonTime, lWedLogonTime;
            LogonTime lThuLogonTime, lFriLogonTime, lSatLogonTime;
            List<LogonTime> lstLogonTimes = new List<LogonTime>();
            PrincipalContext pctxLocalMachine;
            UserPrincipal usrpSelectedUser;

            sSelectedUserName = cmbUserList.SelectedItem.ToString();
            // Testing to see if I can use the WMI API for Windows Parental Controls
            pctxLocalMachine = new PrincipalContext(ContextType.Machine);
            usrpSelectedUser = UserPrincipal.FindByIdentity(pctxLocalMachine, IdentityType.SamAccountName, sSelectedUserName);


            sFromTime = sFromTime + cmbSunFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbSunToTime.SelectedItem.ToString();
            dtFromTime = DateTime.Parse(sFromTime);
            dtToTime = DateTime.Parse(sToTime);
            lSunLogonTime = new LogonTime(System.DayOfWeek.Sunday, dtFromTime, dtToTime);
            lstLogonTimes.Add(lSunLogonTime);

            sFromTime = "1/1/1900 "; sToTime = "1/1/1900 ";
            sFromTime = sFromTime + cmbMonFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbMonToTime.SelectedItem.ToString();
            dtFromTime = DateTime.Parse(sFromTime);
            dtToTime = DateTime.Parse(sToTime);
            lMonLogonTime = new LogonTime(System.DayOfWeek.Monday, dtFromTime, dtToTime);
            lstLogonTimes.Add(lMonLogonTime);

            sFromTime = "1/1/1900 "; sToTime = "1/1/1900 ";
            sFromTime = sFromTime + cmbTuesFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbTuesToTime.SelectedItem.ToString();
            dtFromTime = DateTime.Parse(sFromTime);
            dtToTime = DateTime.Parse(sToTime);
            lTueLogonTime = new LogonTime(System.DayOfWeek.Tuesday, dtFromTime, dtToTime);
            lstLogonTimes.Add(lTueLogonTime);

            sFromTime = "1/1/1900 "; sToTime = "1/1/1900 ";
            sFromTime = sFromTime + cmbWedFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbWedToTime.SelectedItem.ToString();
            dtFromTime = DateTime.Parse(sFromTime);
            dtToTime = DateTime.Parse(sToTime);
            lWedLogonTime = new LogonTime(System.DayOfWeek.Wednesday, dtFromTime, dtToTime);
            lstLogonTimes.Add(lWedLogonTime);

            sFromTime = "1/1/1900 "; sToTime = "1/1/1900 ";
            sFromTime = sFromTime + cmbThurFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbThurToTime.SelectedItem.ToString();
            dtFromTime = DateTime.Parse(sFromTime);
            dtToTime = DateTime.Parse(sToTime);
            lThuLogonTime = new LogonTime(System.DayOfWeek.Thursday, dtFromTime, dtToTime);
            lstLogonTimes.Add(lThuLogonTime);

            sFromTime = "1/1/1900 "; sToTime = "1/1/1900 ";
            sFromTime = sFromTime + cmbFriFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbFriToTime.SelectedItem.ToString();
            dtFromTime = DateTime.Parse(sFromTime);
            dtToTime = DateTime.Parse(sToTime);
            lFriLogonTime = new LogonTime(System.DayOfWeek.Friday, dtFromTime, dtToTime);
            lstLogonTimes.Add(lFriLogonTime);

            sFromTime = "1/1/1900 "; sToTime = "1/1/1900 ";
            sFromTime = sFromTime + cmbSatFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbSatToTime.SelectedItem.ToString();
            dtFromTime = DateTime.Parse(sFromTime);
            dtToTime = DateTime.Parse(sToTime);
            lSatLogonTime = new LogonTime(System.DayOfWeek.Saturday, dtFromTime, dtToTime);
            lstLogonTimes.Add(lSatLogonTime);

            

            if (cmbSunFromTime.SelectedIndex == cv_iSunFromTime &&
                cmbSunToTime.SelectedIndex == cv_iSunToTime &&
                cmbMonFromTime.SelectedIndex == cv_iMonFromTime &&
                cmbMonToTime.SelectedIndex == cv_iMonToTime &&
                cmbTuesFromTime.SelectedIndex == cv_iTueFromTime &&
                cmbTuesToTime.SelectedIndex == cv_iTueToTime &&
                cmbWedFromTime.SelectedIndex == cv_iWedFromTime &&
                cmbWedToTime.SelectedIndex == cv_iWedToTime &&
                cmbThurFromTime.SelectedIndex == cv_iThuFromTime &&
                cmbThurToTime.SelectedIndex == cv_iThuToTime &&
                cmbFriFromTime.SelectedIndex == cv_iFriFromTime &&
                cmbFriToTime.SelectedIndex == cv_iFriToTime &&
                cmbSatFromTime.SelectedIndex == cv_iSatFromTime &&
                cmbSatToTime.SelectedIndex == cv_iSatToTime)
            {
                MessageBox.Show("No changes made that need to be saved!");
                btnSave.Enabled = false;
            }
            else
            {
                byte[] byteMaskForUser;

                byteMaskForUser = PermittedLogonTimes.GetByteMask(lstLogonTimes);
                usrpSelectedUser.PermittedLogonTimes = byteMaskForUser;
                usrpSelectedUser.Save();

                MessageBox.Show("Successfully saved user time limit changes for " + usrpSelectedUser.Name + "!");

                usrpSelectedUser.Dispose();
                pctxLocalMachine.Dispose();

                btnSave.Enabled = false;
            }
        }
    }
}
