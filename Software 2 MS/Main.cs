using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Software_2_MS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            AppCalDV.DataSource = displayCalendar(WeekRB.Checked);
            //displayReminder(appCalendar);
            TimeLB.Text = DateTime.Now.ToString();
        }
        public void updateCalendar()
        {
            AppCalDV.DataSource = displayCalendar(WeekRB.Checked);
        }

        public static Array displayCalendar(bool week)
        {
            MySqlConnection con = new MySqlConnection(Data.conString);
            con.Open();
            var q = $"SELECT customerId, type, start, end, appointmentId, userId FROM appointment WHERE userId = '{Data.getUserID()}'";
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader r = cmd.ExecuteReader();
            Dictionary<int, Hashtable> appointments = new Dictionary<int, Hashtable>();

            //create dictionary of appointments
            while (r.Read())
            {
                Hashtable appointment = new Hashtable();
                appointment.Add("customerId", r[0]);
                appointment.Add("type", r[1]);
                appointment.Add("start", r[2]);
                appointment.Add("end", r[3]);
                appointment.Add("userId", r[5]);
                appointments.Add(Convert.ToInt32(r[4]), appointment);
            }
            r.Close();

            //assigns username to appointment dictionary
            foreach (var app in appointments.Values)
            {
                q = $"SELECT userName FROM user WHERE userId = '{app["userId"]}'";
                cmd = new MySqlCommand(q, con);
                r = cmd.ExecuteReader();
                r.Read();
                app.Add("userName", r[0]);
                r.Close();
            }

            //assigns customerName to appointment dictionary
            foreach (var app in appointments.Values)
            {
                q = $"SELECT customerName FROM customer WHERE customerId = '{app["customerId"]}'";
                cmd = new MySqlCommand(q, con);
                r = cmd.ExecuteReader();
                r.Read();
                app.Add("customerName", r[0]);
                r.Close();
            }
            Dictionary<int, Hashtable> pAppointments = new Dictionary<int, Hashtable>();
            
            foreach (var app in appointments)
            {
                DateTime startTime = DateTime.Parse(app.Value["start"].ToString());
                DateTime endTime = DateTime.Parse(app.Value["end"].ToString());
                DateTime currentTime = DateTime.UtcNow;
                //week is checked this is our appointment list
                if (week)
                {
                    DateTime sunday = currentTime.AddDays(-(int)currentTime.DayOfWeek);
                    DateTime saturday = currentTime.AddDays(-(int)currentTime.DayOfWeek + (int)DayOfWeek.Saturday);
                    if (startTime >= sunday && endTime < saturday)
                    {
                        pAppointments.Add(app.Key, app.Value);
                    }
                }
                //if not we get month appointments
                else
                {
                    DateTime firstOfMonth = new DateTime(currentTime.Year, currentTime.Month, 1);
                    DateTime lastOfMonth = firstOfMonth.AddMonths(1).AddDays(0);
                    if (startTime >= firstOfMonth && endTime < lastOfMonth)
                    {
                        pAppointments.Add(app.Key, app.Value);
                    }
                }
            }

            //what we display to the user in the calendar view
            Data.setAppointments(appointments);
            var appointmentArray = from row in pAppointments
                            select new
                            {
                                id = row.Key,
                                type = row.Value["type"],
                                start = Convert.ToDateTime(row.Value["start"].ToString()).ToLocalTime(),
                                end = Convert.ToDateTime(row.Value["end"].ToString()).ToLocalTime(),
                                customer = row.Value["customerName"]
                            };
            con.Close();
            return appointmentArray.ToArray();

        }

        //tracks the required info into the text log when the main form is logged out of 
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tracker.logOut(Data.getUserName());
        }

        //opens the form for adding users
        private void UserAddBT_Click(object sender, EventArgs e)
        {
            Form add = new AddUser();
            add.Show();
            this.Hide();
        }

        //opens the form for modifying users
        private void UserModBT_Click(object sender, EventArgs e)
        {
            Form uModify = new ModifyUser();
            uModify.Show(); 
            this.Hide();
        }

        //opens the form for deleting users 
        private void UserDelBT_Click(object sender, EventArgs e)
        {
            Form uDelete = new DeleteUser();
            uDelete.Show();
            this.Hide();
        }

        //opens the form for adding customers 
        private void CustAddBT_Click(object sender, EventArgs e)
        {
            Form cAdd = new AddCustomer();
            cAdd.Show();
            this.Hide();
        }

        //opens the form for modifying customers 
        private void CustModBT_Click(object sender, EventArgs e)
        {
            Form cMod = new ModifyCusteromer();
            cMod.Show();
            this.Hide();
        }

        //opens the form for deleting custoemrs 
        private void CustDelBT_Click(object sender, EventArgs e)
        {
            Form cDelete = new DeleteCustomer();
            cDelete.Show();
            this.Hide();
        }

        //opens the form for adding appointments 
        private void AppAddBT_Click(object sender, EventArgs e)
        {
            Form aAdd = new AddAppointment();
            aAdd.Show();
            this.Hide();
        }

        //opens the form for modifying appointments 
        private void AppModBT_Click(object sender, EventArgs e)
        {
            Form aMod = new ModifyAppointment();
            aMod.Show(); 
            this.Hide();
        }

        //opens the form for deleting appointments 
        private void AppDelBT_Click(object sender, EventArgs e)
        {
            Form aDelete = new DeleteAppointment();
            aDelete.Show();
            this.Hide();
        }

        //opens the month report form 
        private void MonthRepoBT_Click(object sender, EventArgs e)
        {
            Form repoMonth = new ReportMonth();
            repoMonth.Show();
            this.Hide();
        }

        //opens the customer report form 
        private void CustRepoBT_Click(object sender, EventArgs e)
        {
            Form repoCust = new ReportCustomer();
            repoCust.Show();
            this.Hide();
        }

        //opens the consltant report form
        private void ConsultantRepoBT_Click(object sender, EventArgs e)
        {
            Form repoCon = new ReportConsultant();
            repoCon.Show();
            this.Hide();
        }

        private void FilterCustBT_Click(object sender, EventArgs e)
        {
            Form repoCust = new ReportCustomer();
            repoCust.Show();
            this.Hide();
        }

        private void FilterConBT_Click(object sender, EventArgs e)
        {
            Form repoCon = new ReportConsultant();
            repoCon.Show();
            this.Hide();
        }

        private void UpdateBT_Click(object sender, EventArgs e)
        {
            updateCalendar();
        }

        private void WeekRB_CheckedChanged(object sender, EventArgs e)
        {
            updateCalendar();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
