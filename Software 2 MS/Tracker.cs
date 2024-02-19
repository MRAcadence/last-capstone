using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;

namespace Software_2_MS
{
    internal class Tracker
    {

        public static DateTime? time;

         public static void setTime(DateTime? Time)
        {
            time = Time;
        }
        public static DateTime? getTime()
        {
            return time;
        }

        public static void AppReminder()
        {
            try
            {
                var list = Data.getNextApp();
                IDictionary<string, object> dic = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                DateTime? TimeNow = DateTime.Now;
                string t = dic["type"].ToString();
                DateTime? nextApp = Convert.ToDateTime(dic["start"]);
                string name = dic["name"].ToString();
                if (TimeNow != null && nextApp != null)
                {
                    DateTime dt = TimeNow.Value;
                    DateTime dt2 = nextApp.Value;
                    string dString = nextApp.Value.ToString("HH:mm tt");
                    TimeSpan diff = dt2.Subtract(dt);
                    if (diff.Minutes < 15 && diff.TotalMinutes >= 0)
                    {
                        MessageBox.Show("Reminder, Appointment type " + t + " At " + dString + " With Consultant " + name + "!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public static void TrackerLogin(string uName)
        {
            DateTime timeNow = DateTime.Now.ToLocalTime();
            Dictionary<DateTime, string> dic = new Dictionary<DateTime, string>();
            dic.Add(timeNow, uName);
            setTime(time);

            foreach (KeyValuePair<DateTime, string> kv in dic)
            {
                string record = string.Format("Login time = {0}, userName = {1}", kv.Key, kv.Value);
                StringBuilder sb = new StringBuilder();
                sb.Append(record + Environment.NewLine);
                //File.AppendAllText(Application.StartupPath + "_access_records.txt", sb.ToString());
                sb.Clear();
            }
        }
        public static void logOut(string uName)
        {
            Dictionary<DateTime, string> dic = new Dictionary<DateTime, string>();
            dic.Add(DateTime.Now, uName);


            foreach (KeyValuePair<DateTime, string> kv in dic)
            {
                string r = string.Format("Logout time = {0}, userName = {1}", kv.Key, kv.Value);
                StringBuilder sb = new StringBuilder();
                sb.Append(r + Environment.NewLine);
                File.AppendAllText(Application.StartupPath + "_access_records.txt", sb.ToString());
                sb.Clear();
            }
        }
















    }
}
