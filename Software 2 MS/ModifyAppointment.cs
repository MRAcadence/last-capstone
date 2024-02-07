using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Software_2_MS
{
    public partial class ModifyAppointment : Form
    {
        //creates the list 
        public static List<KeyValuePair<string, object>> appList;
        public ModifyAppointment()
        {
            InitializeComponent();
            popuCustList();
            CBDefaultSettings();
            TimeLB.Text = DateTime.Now.ToString();
        }

        //sets appointment list equal to the list 
        public void setAppointList(List<KeyValuePair<string, object>> list)
        {
            appList = list;
        }

        //sets the list equal to the appointment list 
        public static List<KeyValuePair<string, object>> getAppointList()
        {
            return appList;
        }

        //sets the default settings for the combo boxes and text boxes
        public void CBDefaultSettings()
        {
            //fills the text blocks with preselected text 
            CustCB.SelectedItem = null;
            CustCB.Text = "--Select--";
            AppNameTB.Text = "--Please Enter Name--";
            LocationTB.Text = "--Please Enter Location--";
            AppDescTB.Text = "--Please Enter Description--";
            PhoneTB.Text = "--Please Enter Phone Number--";

            //disables the text boxes
            AppCB.Enabled = false;
            AppNameTB.Enabled = false;
            AppDescTB.Enabled = false;
            LocationTB.Enabled = false;
            PhoneTB.Enabled = false;
            TypeCB.Enabled = false;
            StartTP.Enabled = false;
            EndTP.Enabled = false;
            UpdateBT.Enabled = false;

            //sets the font for the text boxes
            AppNameTB.Font = new Font("Arial", 12);
            PhoneTB.Font = new Font("Arial", 12);
            LocationTB.Font = new Font("Arial", 12);
            AppDescTB.Font = new Font("Arial", 12);

            //sets the border style for the text boxes
            AppNameTB.BorderStyle = BorderStyle.FixedSingle;
            PhoneTB.BorderStyle = BorderStyle.FixedSingle;
            LocationTB.BorderStyle = BorderStyle.FixedSingle;
            AppDescTB.BorderStyle = BorderStyle.FixedSingle;

            //sets the alightnment for the text boxes
            AppNameTB.TextAlign = HorizontalAlignment.Center;
            PhoneTB.TextAlign = HorizontalAlignment.Center;
            LocationTB.TextAlign = HorizontalAlignment.Center;
            AppDescTB.TextAlign = HorizontalAlignment.Center;

            //sets the max length of characters that can be entered into the text boxes
            AppNameTB.MaxLength = 50;
            PhoneTB.MaxLength = 50;
            LocationTB.MaxLength = 50;
            AppDescTB.MaxLength = 50;

            //sets the background color for the text boxes 
            AppNameTB.BackColor = Color.LightGray;
            PhoneTB.BackColor = Color.LightGray;
            LocationTB.BackColor = Color.LightGray;
            AppDescTB.BackColor = Color.LightGray;

            //sets the forecolor of the text boxes
            AppNameTB.ForeColor = Color.Blue;
            PhoneTB.ForeColor = Color.Blue;
            LocationTB.ForeColor = Color.Blue;
            AppDescTB.ForeColor = Color.Blue;
        }

        //pulls data from the data base into the comboboxes
        public void popuCustList()
        {
            MySqlConnection con = new MySqlConnection(Data.getConString());

            try
            {
                string q = "SELECT customerId,"+
                    "concat(customerName, ' --ID: ', customerId)"+
                    "as Display FROM customer;";
                MySqlDataAdapter sqlda = new MySqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                sqlda.Fill(ds, "Cust");
                CustCB.DisplayMember = "Display";
                CustCB.ValueMember = "customerId";
                CustCB.DataSource = ds.Tables["Cust"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Has Occured! " + ex);
            }
        }

        //makes sure that there werent any fields in the combo boxes or text boxes left blank 
        private bool isEmpty()
        {
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    TextBox textB = t as TextBox;
                    if (textB.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //checks to make sure that the appointment is actually set during a valid time 
        public int appPass(DateTime start, DateTime end)
        {
            //setting the local time of the user 
            DateTime startLocal = start.ToLocalTime();
            DateTime endLocal = end.ToLocalTime();

            //setting the business hours 
            DateTime startOfBusinessHours = DateTime.Today.AddHours(8);
            DateTime endOfBusinessHours = DateTime.Today.AddHours(17);

            if (startLocal.TimeOfDay < startOfBusinessHours.TimeOfDay || endLocal.TimeOfDay > endOfBusinessHours.TimeOfDay)
            {
                return 1; // outside business hours
            }
            if (Data.appOverlaps(start, end) == true)
            {
                return 2; // overlapping appointments
            }
            if (startLocal.TimeOfDay > endLocal.TimeOfDay)
            {
                return 3; // invalid time range appointment ends before it starts
            }
            if (startLocal.Date != endLocal.Date)
            {
                return 4; // appointments on different days
            }

            return 0; // valid appointment
        }

        //pulls the data into the combo box for the apopintment 
        public void popAppList()
        {
            MySqlConnection con = new MySqlConnection(Data.getConString());
            string universalOffset = (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).ToString().Substring(0, 6));
            try
            {

                string q = $"SELECT appointmentId, concat('ID: ', appointmentId, '--Type: ', type) as Display FROM appointment WHERE customerId = '{CustCB.SelectedValue}';";
                MySqlDataAdapter sqlda = new MySqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                sqlda.Fill(ds, "Appoint");
                AppCB.DisplayMember = "Display";
                AppCB.ValueMember = "appointmentId";
                AppCB.DataSource = ds.Tables["Appoint"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Has Occured! " + ex);
            }
        }
      
        public void popFields(List<KeyValuePair<string, object>> appList)
        {
            //lambda expressions that are for grabbing information values from the applist
            AppNameTB.Text = appList.First(kvp => kvp.Key == "title").Value.ToString();
            AppDescTB.Text = appList.First(kvp => kvp.Key == "description").Value.ToString();
            LocationTB.Text = appList.First(kvp => kvp.Key == "location").Value.ToString();
            PhoneTB.Text = appList.First(kvp => kvp.Key == "contact").Value.ToString();
            TypeCB.SelectedIndex = TypeCB.FindStringExact(appList.First(kvp => kvp.Key == "type").Value.ToString());
            string startTime = appList.Find(kvp => kvp.Key == "start").Value.ToString();
            string endTime = appList.Find(kvp => kvp.Key == "end").Value.ToString();
            StartTP.Value = Convert.ToDateTime(startTime).ToLocalTime();
            EndTP.Value = Convert.ToDateTime(endTime).ToLocalTime();
        }

        //cancel button leaves this page and goes back to the home page / main form
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        private void ModifyAppointment_Load(object sender, EventArgs e)
        {

        }

        //updates the appointment and sends the updated information to the database
        private void UpdateBT_Click(object sender, EventArgs e)
        {
            bool accepted = isEmpty();
            if (accepted == true)
            {
                DialogResult conf = MessageBox.Show("Are you sure you want to update this appointment?", "", MessageBoxButtons.YesNo);
                if (conf == DialogResult.Yes)
                {
                    try
                    {
                        DateTime startTime = StartTP.Value.ToUniversalTime();
                        DateTime endTime = EndTP.Value.ToUniversalTime();
                        int available = appPass(startTime, endTime);
                        switch (available)
                        {
                            case 0:
                                var list = getAppointList();
                                //lambda expression for converting the app list into the dictonary 
                                IDictionary<string, object> dict = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                                // all of the values from the combo boxes and text boxes
                                dict["appointmentId"] = AppCB.SelectedValue;
                                dict["customerId"] = CustCB.SelectedValue;
                                dict["title"] = AppNameTB.Text;
                                dict["description"] = AppDescTB.Text;
                                dict["location"] = LocationTB.Text;
                                dict["contact"] = PhoneTB.Text;
                                dict["type"] = TypeCB.SelectedItem.ToString();
                                dict["start"] = StartTP.Value;
                                dict["end"] = EndTP.Value;
                                dict["url"] = CustCB.SelectedValue;
                               //updating the appointment information
                                Data.updateApp(dict);
                                MessageBox.Show("Updated successfully appointment!");
                                Form main = new Main();
                                main.Show();
                                this.Close();
                                break;
                            case 1: //appointment is not within business hours 
                                MessageBox.Show("Please Select A Time Within Business Hours."); ;
                                break;
                            case 2: //appointment conflicts with another appointment 
                                MessageBox.Show("Please Pick An Appointment That Doesn't Conflict With Another Scheduled Appointment.");
                                break;
                            case 3: //end time is before start time for the appointment 
                                MessageBox.Show("Please Make Sure Your End Time Isn't Before Your Start Time.");
                                break;
                            case 4: //appointment start date is on a seperate day than the end date
                                MessageBox.Show("Please Make Sure That Appointment Start And End Dates Are On The Same Day.");
                                break;

                        }



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            if (accepted == false)
            {
                MessageBox.Show("PLease Make Sure That All Fields Have Values.");
            }
        }

        //setd default controls for the text boxes and combo boxes 
        private void CustCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            popAppList();
            //disables the text boxes and combo boxes 
            AppCB.Enabled = true;
            AppNameTB.Enabled = false;
            AppDescTB.Enabled = false;
            LocationTB.Enabled = false;
            PhoneTB.Enabled = false;
            TypeCB.Enabled = false;
            StartTP.Enabled = false;
            EndTP.Enabled = false;
            UpdateBT.Enabled = false;

            //fills the text blocks with preselected text
            AppNameTB.Text = "--Enter Appointment Name--";
            AppDescTB.Text = "--Enter Appointment Description--";
            LocationTB.Text = "--Enter Location--";
            PhoneTB.Text = "--Enter Phone Number--";
            TypeCB.SelectedItem = null;

            //sets the font for the text boxes
            AppNameTB.Font = new Font("Arial", 12);
            AppDescTB.Font = new Font("Arial", 12);
            LocationTB.Font = new Font("Arial", 12);
            PhoneTB.Font = new Font("Arial", 12);

            //sets the border style for the text boxes
            AppNameTB.BorderStyle = BorderStyle.FixedSingle;
            AppDescTB.BorderStyle = BorderStyle.FixedSingle;
            LocationTB.BorderStyle = BorderStyle.FixedSingle;
            PhoneTB.BorderStyle = BorderStyle.FixedSingle;

            //sets the alightnment for the text boxes
            AppNameTB.TextAlign = HorizontalAlignment.Center;
            AppDescTB.TextAlign = HorizontalAlignment.Center;
            PhoneTB.TextAlign = HorizontalAlignment.Center;
            LocationTB.TextAlign = HorizontalAlignment.Center;

            //sets the max length of characters that can be entered into the text boxes
            AppNameTB.MaxLength = 50;
            AppDescTB.MaxLength = 50;
            PhoneTB.MaxLength = 50;
            LocationTB.MaxLength = 50;

            //sets the background color for the text boxes 
            AppNameTB.BackColor = Color.LightGray;
            AppDescTB.BackColor = Color.LightGray;
            LocationTB.BackColor = Color.LightGray;
            PhoneTB.BackColor = Color.LightGray;

            //sets the forecolor of the text boxes
            AppNameTB.ForeColor = Color.Blue;
            AppDescTB.ForeColor = Color.Blue;
            LocationTB.ForeColor = Color.Blue;
            PhoneTB.ForeColor = Color.Blue;
        }


        //unlocks the previously locked controls for the text boxes and combo boxes 
        private void AppCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = AppCB.SelectedItem as DataRowView;
            int id = Convert.ToInt32(AppCB.SelectedValue);
            var appList = Data.getAppList(id);
            setAppointList(appList);

            if (AppCB.SelectedIndex != -1)
            {
                AppNameTB.Enabled = true;
                AppDescTB.Enabled = true;
                LocationTB.Enabled = true;
                PhoneTB.Enabled = true;
                TypeCB.Enabled = true;
                StartTP.Enabled = true;
                EndTP.Enabled = true;
                UpdateBT.Enabled = true;
                popFields(appList);
            }
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
