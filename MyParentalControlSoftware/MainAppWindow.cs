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
using Microsoft.Win32.TaskScheduler;

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

            // Clear the user dropdown list and populate with the current list of users on the computer
            cmbUserList.Items.Clear();
            SelectQuery myQuery = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(myQuery);
            foreach (ManagementObject envVar in searcher.Get())
            {
                cmbUserList.Items.Add(envVar["Name"]);
            }

            // Clear and load the hourly times in the From and To time drop down lists
            DateTime dtFromTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime dtToTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            cmbSunFromTime.Items.Clear();
            cmbMonFromTime.Items.Clear();
            cmbTueFromTime.Items.Clear();
            cmbWedFromTime.Items.Clear();
            cmbThuFromTime.Items.Clear();
            cmbFriFromTime.Items.Clear();
            cmbSatFromTime.Items.Clear();
            cmbSunToTime.Items.Clear();
            cmbMonToTime.Items.Clear();
            cmbTueToTime.Items.Clear();
            cmbWedToTime.Items.Clear();
            cmbThuToTime.Items.Clear();
            cmbFriToTime.Items.Clear();
            cmbSatToTime.Items.Clear();

            for( int iIndex = 0; iIndex < 24; iIndex++ )
            {
                cmbSunFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbMonFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbTueFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbWedFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbThuFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbFriFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbSatFromTime.Items.Add(dtFromTime.ToShortTimeString());
                cmbSunToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbMonToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbTueToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbWedToTime.Items.Add(dtToTime.ToShortTimeString());
                cmbThuToTime.Items.Add(dtToTime.ToShortTimeString());
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

                // Retrieve the selected user name and retrieve the User object
                sSelectedUserName = cmbUserList.SelectedItem.ToString();
                pctxLocalMachine = new PrincipalContext(ContextType.Machine);
                usrpSelectedUser = UserPrincipal.FindByIdentity(pctxLocalMachine, IdentityType.SamAccountName, sSelectedUserName);

                // If the user account is enabled, enable the hourly times dropdown
                if (usrpSelectedUser.Enabled == true)
                {
                    cmbSunFromTime.Enabled = true;
                    cmbSunToTime.Enabled = true;
                    cmbMonFromTime.Enabled = true;
                    cmbMonToTime.Enabled = true;
                    cmbTueFromTime.Enabled = true;
                    cmbTueToTime.Enabled = true;
                    cmbWedFromTime.Enabled = true;
                    cmbWedToTime.Enabled = true;
                    cmbThuFromTime.Enabled = true;
                    cmbThuToTime.Enabled = true;
                    cmbFriFromTime.Enabled = true;
                    cmbFriToTime.Enabled = true;
                    cmbSatFromTime.Enabled = true;
                    cmbSatToTime.Enabled = true;
                    btnSave.Enabled = true;
                }
                else
                {
                    cmbSunFromTime.Enabled = false;
                    cmbSunToTime.Enabled = false;
                    cmbMonFromTime.Enabled = false;
                    cmbMonToTime.Enabled = false;
                    cmbTueFromTime.Enabled = false;
                    cmbTueToTime.Enabled = false;
                    cmbWedFromTime.Enabled = false;
                    cmbWedToTime.Enabled = false;
                    cmbThuFromTime.Enabled = false;
                    cmbThuToTime.Enabled = false;
                    cmbFriFromTime.Enabled = false;
                    cmbFriToTime.Enabled = false;
                    cmbSatFromTime.Enabled = false;
                    cmbSatToTime.Enabled = false;
                    btnSave.Enabled = false;
                }

                varSelectedUserLogonTimes = PermittedLogonTimes.GetLogonTimes(usrpSelectedUser.PermittedLogonTimes);

                cmbSunFromTime.SelectedIndex = -1;
                cmbMonFromTime.SelectedIndex = -1;
                cmbTueFromTime.SelectedIndex = -1;
                cmbWedFromTime.SelectedIndex = -1;
                cmbThuFromTime.SelectedIndex = -1;
                cmbFriFromTime.SelectedIndex = -1;
                cmbSatFromTime.SelectedIndex = -1;
                cmbSunToTime.SelectedIndex = -1;
                cmbMonToTime.SelectedIndex = -1;
                cmbTueToTime.SelectedIndex = -1;
                cmbWedToTime.SelectedIndex = -1;
                cmbThuToTime.SelectedIndex = -1;
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
                            cv_iTueFromTime = cmbTueFromTime.SelectedIndex = cmbTueFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iTueToTime = cmbTueToTime.SelectedIndex = cmbTueToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Wednesday:
                            cv_iWedFromTime = cmbWedFromTime.SelectedIndex = cmbWedFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iWedToTime = cmbWedToTime.SelectedIndex = cmbWedToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
                            break;
                        case DayOfWeek.Thursday:
                            cv_iThuFromTime = cmbThuFromTime.SelectedIndex = cmbThuFromTime.Items.IndexOf(lExtractedTime.BeginTime.ToShortTimeString());
                            cv_iThuToTime = cmbThuToTime.SelectedIndex = cmbThuToTime.Items.IndexOf(lExtractedTime.EndTime.ToShortTimeString());
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

                cmbSunFromTime.Enabled = true;
                cmbSunToTime.Enabled = true;
                cmbMonFromTime.Enabled = true;
                cmbMonToTime.Enabled = true;
                cmbTueFromTime.Enabled = true;
                cmbTueToTime.Enabled = true;
                cmbWedFromTime.Enabled = true;
                cmbWedToTime.Enabled = true;
                cmbThuFromTime.Enabled = true;
                cmbThuToTime.Enabled = true;
                cmbFriFromTime.Enabled = true;
                cmbFriToTime.Enabled = true;
                cmbSatFromTime.Enabled = true;
                cmbSatToTime.Enabled = true;
                btnSave.Enabled = true;

                // Disable triggers for scheduled tasks in the Task Scheduler
                using (TaskService ts = new TaskService(@"\"))
                {
                    TaskFolder myFolder = ts.GetFolder("Karthik's Custom Tasks");

                    var myTasks = myFolder.Tasks.Where(t => t.Name.Equals(sSelectedUserName + " Force Logoff", StringComparison.OrdinalIgnoreCase));
                    Microsoft.Win32.TaskScheduler.Task myTask = myTasks.ElementAt(0);
                    //myTask.Enabled = true;
                    myTask.Definition.Settings.Enabled = true;
                    myTask.RegisterChanges();
                }
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

                cmbSunFromTime.Enabled = false;
                cmbSunToTime.Enabled = false;
                cmbMonFromTime.Enabled = false;
                cmbMonToTime.Enabled = false;
                cmbTueFromTime.Enabled = false;
                cmbTueToTime.Enabled = false;
                cmbWedFromTime.Enabled = false;
                cmbWedToTime.Enabled = false;
                cmbThuFromTime.Enabled = false;
                cmbThuToTime.Enabled = false;
                cmbFriFromTime.Enabled = false;
                cmbFriToTime.Enabled = false;
                cmbSatFromTime.Enabled = false;
                cmbSatToTime.Enabled = false;
                btnSave.Enabled = false;

                // Disable triggers for scheduled tasks in the Task Scheduler
                using (TaskService ts = new TaskService(@"\"))
                {
                    TaskFolder myFolder = ts.GetFolder("Karthik's Custom Tasks");

                    var myTasks = myFolder.Tasks.Where(t => t.Name.Equals(sSelectedUserName + " Force Logoff", StringComparison.OrdinalIgnoreCase));
                    Microsoft.Win32.TaskScheduler.Task myTask = myTasks.ElementAt(0);
                    //myTask.Enabled = false;
                    myTask.Definition.Settings.Enabled = false;
                    myTask.RegisterChanges();
                }

                MessageBox.Show(sSelectedUserName + " has been disabled now!");
                usrpSelectedUser.Dispose();
                pctxLocalMachine.Dispose();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
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
            DateTime dtSunFromTime, dtMonFromTime, dtTueFromTime, dtWedFromTime, dtThuFromTime, dtFriFromTime, dtSatFromTime;
            DateTime dtSunToTime, dtMonToTime, dtTueToTime, dtWedToTime, dtThuToTime, dtFriToTime, dtSatToTime;
            String sSelectedUserName = "", sFromTime = "", sToTime = "";
            LogonTime lSunLogonTime, lMonLogonTime, lTueLogonTime, lWedLogonTime;
            LogonTime lThuLogonTime, lFriLogonTime, lSatLogonTime;
            List<LogonTime> lstLogonTimes = new List<LogonTime>();
            PrincipalContext pctxLocalMachine;
            UserPrincipal usrpSelectedUser;

            sSelectedUserName = cmbUserList.SelectedItem.ToString();
            // Testing to see if I can use the WMI API for Windows Parental Controls
            pctxLocalMachine = new PrincipalContext(ContextType.Machine);
            usrpSelectedUser = UserPrincipal.FindByIdentity(pctxLocalMachine, IdentityType.SamAccountName, sSelectedUserName);

            sFromTime = "1/1/" + DateTime.Now.Year + " "; sToTime = "1/1/" + DateTime.Now.Year + " ";
            sFromTime = sFromTime + cmbSunFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbSunToTime.SelectedItem.ToString();
            dtSunFromTime = DateTime.Parse(sFromTime);
            dtSunToTime = DateTime.Parse(sToTime);
            lSunLogonTime = new LogonTime(System.DayOfWeek.Sunday, dtSunFromTime, dtSunToTime);
            lstLogonTimes.Add(lSunLogonTime);

            sFromTime = "1/1/"+DateTime.Now.Year + " "; sToTime = "1/1/" + DateTime.Now.Year + " ";
            sFromTime = sFromTime + cmbMonFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbMonToTime.SelectedItem.ToString();
            dtMonFromTime = DateTime.Parse(sFromTime);
            dtMonToTime = DateTime.Parse(sToTime);
            lMonLogonTime = new LogonTime(System.DayOfWeek.Monday, dtMonFromTime, dtMonToTime);
            lstLogonTimes.Add(lMonLogonTime);

            sFromTime = "1/1/" + DateTime.Now.Year + " "; sToTime = "1/1/" + DateTime.Now.Year + " ";
            sFromTime = sFromTime + cmbTueFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbTueToTime.SelectedItem.ToString();
            dtTueFromTime = DateTime.Parse(sFromTime);
            dtTueToTime = DateTime.Parse(sToTime);
            lTueLogonTime = new LogonTime(System.DayOfWeek.Tuesday, dtTueFromTime, dtTueToTime);
            lstLogonTimes.Add(lTueLogonTime);

            sFromTime = "1/1/" + DateTime.Now.Year + " "; sToTime = "1/1/" + DateTime.Now.Year + " ";
            sFromTime = sFromTime + cmbWedFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbWedToTime.SelectedItem.ToString();
            dtWedFromTime = DateTime.Parse(sFromTime);
            dtWedToTime = DateTime.Parse(sToTime);
            lWedLogonTime = new LogonTime(System.DayOfWeek.Wednesday, dtWedFromTime, dtWedToTime);
            lstLogonTimes.Add(lWedLogonTime);

            sFromTime = "1/1/" + DateTime.Now.Year + " "; sToTime = "1/1/" + DateTime.Now.Year + " ";
            sFromTime = sFromTime + cmbThuFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbThuToTime.SelectedItem.ToString();
            dtThuFromTime = DateTime.Parse(sFromTime);
            dtThuToTime = DateTime.Parse(sToTime);
            lThuLogonTime = new LogonTime(System.DayOfWeek.Thursday, dtThuFromTime, dtThuToTime);
            lstLogonTimes.Add(lThuLogonTime);

            sFromTime = "1/1/" + DateTime.Now.Year + " "; sToTime = "1/1/" + DateTime.Now.Year + " ";
            sFromTime = sFromTime + cmbFriFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbFriToTime.SelectedItem.ToString();
            dtFriFromTime = DateTime.Parse(sFromTime);
            dtFriToTime = DateTime.Parse(sToTime);
            lFriLogonTime = new LogonTime(System.DayOfWeek.Friday, dtFriFromTime, dtFriToTime);
            lstLogonTimes.Add(lFriLogonTime);

            sFromTime = "1/1/" + DateTime.Now.Year + " "; sToTime = "1/1/" + DateTime.Now.Year + " ";
            sFromTime = sFromTime + cmbSatFromTime.SelectedItem.ToString();
            sToTime = sToTime + cmbSatToTime.SelectedItem.ToString();
            dtSatFromTime = DateTime.Parse(sFromTime);
            dtSatToTime = DateTime.Parse(sToTime);
            lSatLogonTime = new LogonTime(System.DayOfWeek.Saturday, dtSatFromTime, dtSatToTime);
            lstLogonTimes.Add(lSatLogonTime);

            // Access the Task Scheduler and change the trigger times for the Logoff Tasks for both Advik and Adhrit
            using (TaskService ts = new TaskService(@"\"))
            {
                TaskFolder myFolder = ts.GetFolder("Karthik's Custom Tasks");

                if (myFolder.Tasks.Count > 0)
                {
                    var myTasks = myFolder.Tasks.Where(t => t.Name.Equals(sSelectedUserName + " Force Logoff", StringComparison.OrdinalIgnoreCase));
                    Microsoft.Win32.TaskScheduler.Task myTask = myTasks.ElementAt(0);
                    myTask.Definition.Triggers.Clear();

                    if (dtMonToTime.ToShortTimeString() == dtTueToTime.ToShortTimeString() &&
                        dtTueToTime.ToShortTimeString() == dtWedToTime.ToShortTimeString() &&
                        dtWedToTime.ToShortTimeString() == dtThuToTime.ToShortTimeString() &&
                        dtThuToTime.ToShortTimeString() == dtFriToTime.ToShortTimeString())
                    {
                        WeeklyTrigger myWeekdayTrigger = new WeeklyTrigger();
                        myWeekdayTrigger.StartBoundary = dtMonToTime.AddSeconds(-30);
                        myWeekdayTrigger.DaysOfWeek = DaysOfTheWeek.Monday | DaysOfTheWeek.Tuesday | DaysOfTheWeek.Wednesday | DaysOfTheWeek.Thursday | DaysOfTheWeek.Friday;
                        myWeekdayTrigger.WeeksInterval = 1;
                        myTask.Definition.Triggers.Add(myWeekdayTrigger);
                    }
                    else
                    {
                        WeeklyTrigger myMondayTrigger = new WeeklyTrigger(DaysOfTheWeek.Monday);
                        myMondayTrigger.StartBoundary = dtMonToTime.AddSeconds(-30);
                        myMondayTrigger.WeeksInterval = 1;
                        myTask.Definition.Triggers.Add(myMondayTrigger);

                        WeeklyTrigger myTuesdayTrigger = new WeeklyTrigger(DaysOfTheWeek.Tuesday);
                        myTuesdayTrigger.StartBoundary = dtTueToTime.AddSeconds(-30);
                        myTuesdayTrigger.WeeksInterval = 1;
                        myTask.Definition.Triggers.Add(myTuesdayTrigger);

                        WeeklyTrigger myWednesdayTrigger = new WeeklyTrigger(DaysOfTheWeek.Wednesday);
                        myWednesdayTrigger.StartBoundary = dtWedToTime.AddSeconds(-30);
                        myWednesdayTrigger.WeeksInterval = 1;
                        myTask.Definition.Triggers.Add(myWednesdayTrigger);

                        WeeklyTrigger myThursdayTrigger = new WeeklyTrigger(DaysOfTheWeek.Thursday);
                        myThursdayTrigger.StartBoundary = dtThuToTime.AddSeconds(-30);
                        myThursdayTrigger.WeeksInterval = 1;
                        myTask.Definition.Triggers.Add(myThursdayTrigger);

                        WeeklyTrigger myFridayTrigger = new WeeklyTrigger(DaysOfTheWeek.Friday);
                        myFridayTrigger.StartBoundary = dtFriToTime.AddSeconds(-30);
                        myFridayTrigger.WeeksInterval = 1;
                        myTask.Definition.Triggers.Add(myFridayTrigger);
                    }

                    if (dtSunToTime.ToShortTimeString() == dtSatToTime.ToShortTimeString())
                    {
                        WeeklyTrigger myWeekendTrigger = new WeeklyTrigger(DaysOfTheWeek.Saturday | DaysOfTheWeek.Sunday);
                        myWeekendTrigger.StartBoundary = dtSunToTime.AddSeconds(-30);
                        myWeekendTrigger.WeeksInterval = 1;
                        myTask.Definition.Triggers.Add(myWeekendTrigger);
                    }
                    else
                    {
                        WeeklyTrigger mySaturdayTrigger = new WeeklyTrigger(DaysOfTheWeek.Saturday);
                        mySaturdayTrigger.StartBoundary = dtSatToTime.AddSeconds(-30);
                        mySaturdayTrigger.WeeksInterval = 1;
                        myTask.Definition.Triggers.Add(mySaturdayTrigger);

                        WeeklyTrigger mySundayTrigger = new WeeklyTrigger(DaysOfTheWeek.Sunday);
                        mySundayTrigger.StartBoundary = dtSunToTime.AddSeconds(-30);
                        mySundayTrigger.WeeksInterval = 1;
                        myTask.Definition.Triggers.Add(mySundayTrigger);
                    }
                    myTask.RegisterChanges();
                }
            }

            if (cmbSunFromTime.SelectedIndex == cv_iSunFromTime &&
                cmbSunToTime.SelectedIndex == cv_iSunToTime &&
                cmbMonFromTime.SelectedIndex == cv_iMonFromTime &&
                cmbMonToTime.SelectedIndex == cv_iMonToTime &&
                cmbTueFromTime.SelectedIndex == cv_iTueFromTime &&
                cmbTueToTime.SelectedIndex == cv_iTueToTime &&
                cmbWedFromTime.SelectedIndex == cv_iWedFromTime &&
                cmbWedToTime.SelectedIndex == cv_iWedToTime &&
                cmbThuFromTime.SelectedIndex == cv_iThuFromTime &&
                cmbThuToTime.SelectedIndex == cv_iThuToTime &&
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
