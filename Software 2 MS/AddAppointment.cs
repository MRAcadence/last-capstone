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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent(); 
            popCustList();
            DefaultSettings();
            EndTP.Value = EndTP.Value.AddHours(1);
            TimeLB.Text = DateTime.Now.ToString();
        }

        //sets the default settings for the text boxes and combo boxes 
        public void DefaultSettings()
        {
            //fills the text blocks with preselected text 
            CustCB.SelectedItem = null;
            CustCB.Text = "--Select--";
            TypeCB.Text = "--Select--";
            AppNameTB.Text = "--Please Enter Name--";
            LocationTB.Text = "--Please Enter Location--";
            AppDescTB.Text = "--Please Enter Description--";
            PhoneTB.Text = "--Please Enter Phone Number--";

            //disables the text boxes
            AppNameTB.Enabled = false;
            AppDescTB.Enabled = false;
            LocationTB.Enabled = false;
            PhoneTB.Enabled = false;
            TypeCB.Enabled = false;
            CreateBT.Enabled = false;

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

        //uses the empty check method to make sure that there are no blank text boxes left on the form
        private bool emptyCheck()
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

        //populates the appointment list with information from the database 
        public void popCustList()
        {
            MySqlConnection con = new MySqlConnection(Data.getConString());

            try
            {
                string q = "SELECT customerId, concat(customerName, ' --ID: ', customerId) as Display FROM customer;";
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
                MessageBox.Show("An Error Occured! " + ex);
            }
        }

        public int appointmentAllowed(DateTime start, DateTime end)
        {

            DateTime startLocal = start.ToLocalTime();
            DateTime endLocal = end.ToLocalTime();
            
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

        private void CreateBT_Click(object sender, EventArgs e)
        {
            //take currently selected customer and create an appointment for that customer
            bool accepted = emptyCheck();
            if (accepted == true)
            {
                if (CustCB.SelectedItem != null)
                {
                    DataRowView drv = CustCB.SelectedItem as DataRowView;
                    int customerID = Convert.ToInt32(CustCB.SelectedValue);
                    DateTime startTime = StartTP.Value.ToUniversalTime();
                    DateTime endTime = EndTP.Value.ToUniversalTime();

                    int allowed = appointmentAllowed(startTime, endTime);
                    
                    switch (allowed)
                    {
                        case 0:
                            Data.createApp(customerID, CustCB.Text, AppDescTB.Text, LocationTB.Text, PhoneTB.Text, TypeCB.SelectedItem.ToString(), startTime, endTime);
                            MessageBox.Show("Successfully Created Your Appointment.");
                            Form main = new Main();
                            main.Show();
                            this.Close();


                            break;
                        case 1:
                            MessageBox.Show("Please Select A Time Within Business Hours."); ;
                            break;
                        case 2:
                            MessageBox.Show("Please Pick An Appointment That Doesn't Conflict With Another Scheduled Appointment.");
                            break;
                        case 3:
                            MessageBox.Show("Please Make Sure Your End Time Isn't Before Your Start Time.");
                            break;
                        case 4:
                            MessageBox.Show("Please Make Sure That Appointment Start And End Dates Are On The Same Day.");
                            break;

                    }
                }
            }
            if (accepted == false)
            {
                MessageBox.Show("Please Make Sure No Fields Are Left Empty.");
            }
        }

        //cancel button click to exit this form and go back to the dashboard / main form
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        //enables the previously disabled fields for user interaction
        private void CustCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected value changed");
            CustCB.Enabled = true;
            AppDescTB.Enabled = true;
            AppNameTB.Enabled = true;
            LocationTB.Enabled = true;
            PhoneTB.Enabled = true;
            TypeCB.Enabled = true;
            CreateBT.Enabled = true;
        }

    }
}
