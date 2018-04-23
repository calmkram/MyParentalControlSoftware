using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;
using System.Net;
using Microsoft.Win32.TaskScheduler;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string sUserName = "advik";
            PrincipalContext pctx;
            UserPrincipal usr;

            pctx = new PrincipalContext(ContextType.Machine);
            usr = UserPrincipal.FindByIdentity(pctx, IdentityType.SamAccountName, sUserName);

            var myUserLogonTimes = PermittedLogonTimes.GetLogonTimes(usr.PermittedLogonTimes, TimeZoneInfo.FindSystemTimeZoneById(TimeZone.CurrentTimeZone.StandardName));
            for (int iIndex = 0; iIndex < myUserLogonTimes.Count; iIndex++)
            {
                LogonTime lExtractedTime = myUserLogonTimes.ElementAt(iIndex);
                Console.WriteLine("Day ="+lExtractedTime.DayOfWeek.ToString()+"; Begin="+lExtractedTime.BeginTime.ToShortTimeString()+ 
                    "; End="+lExtractedTime.EndTime.ToShortTimeString()+"!");
            }
            for( int iIndex = 0; iIndex < usr.PermittedLogonTimes.Length; iIndex++ )
            {
                Console.WriteLine(iIndex+": "+usr.PermittedLogonTimes.ElementAt(iIndex));
            }*/

            //var zone = TimeZoneInfo.FindSystemTimeZoneById(TimeZone.CurrentTimeZone.StandardName);
            /*var times = new List<MyParentalControlSoftware.LogonTime>();

            var Suntime = new LogonTime(DayOfWeek.Sunday, new DateTime(2011, 1, 1, 0, 0, 0), new DateTime(2011, 1, 1, 1, 0, 0));
            times.Add(Suntime);

            var Montime = new LogonTime(DayOfWeek.Monday, new DateTime(2011, 1, 1, 17, 0, 0), new DateTime(2011, 1, 1, 18, 0, 0));
            times.Add(Montime);

            var Tuetime = new LogonTime(DayOfWeek.Tuesday, new DateTime(2011, 1, 1, 17, 0, 0), new DateTime(2011, 1, 1, 18, 0, 0));
            times.Add(Tuetime);

            var Wedtime = new LogonTime(DayOfWeek.Wednesday, new DateTime(2011, 1, 1, 17, 0, 0), new DateTime(2011, 1, 1, 18, 0, 0));
            times.Add(Wedtime);

            var Thutime = new LogonTime(DayOfWeek.Thursday, new DateTime(2011, 1, 1, 17, 0, 0), new DateTime(2011, 1, 1, 18, 0, 0));
            times.Add(Thutime);

            var Fritime = new LogonTime(DayOfWeek.Friday, new DateTime(2011, 1, 1, 17, 0, 0), new DateTime(2011, 1, 1, 18, 0, 0));
            times.Add(Fritime);

            var Sattime = new LogonTime(DayOfWeek.Saturday, new DateTime(2011, 1, 1, 23, 0, 0), new DateTime(2011, 1, 2, 0, 0, 0));
            times.Add(Sattime);

            var mask = PermittedLogonTimes.GetByteMask(times);

            foreach( byte byteVal in mask)
            {
                Console.WriteLine("{0}", byteVal);
            }*/

            // Access the Task Scheduler and change the trigger times for the Logoff Tasks for both Advik and Adhrit
            using (TaskService ts = new TaskService(@"\"))
            {
                TaskFolder myFolder = ts.GetFolder("Karthik's Custom Tasks");

                var myTasks = myFolder.Tasks.Where(t => t.Name.Equals("Force Advik's User Logoff", StringComparison.OrdinalIgnoreCase));
                Microsoft.Win32.TaskScheduler.Task myTask = myTasks.ElementAt(0);
                myTask.Definition.Triggers.Clear();
                WeeklyTrigger myWeekdayTrigger = new WeeklyTrigger();
                myWeekdayTrigger.StartBoundary = DateTime.Parse("4/22/2018 4:59:30 PM");
                myWeekdayTrigger.DaysOfWeek = DaysOfTheWeek.Monday | DaysOfTheWeek.Tuesday | DaysOfTheWeek.Wednesday | DaysOfTheWeek.Thursday | DaysOfTheWeek.Friday;
                myWeekdayTrigger.WeeksInterval = 1;
                myTask.Definition.Triggers.Add(myWeekdayTrigger);

                myTask.RegisterChanges();
            }
            Console.ReadLine();
        }
    }
}
