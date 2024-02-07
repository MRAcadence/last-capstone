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
    public partial class DeleteAppointment : Form
    {
        public static List<KeyValuePair<string, object>> appointmentList;
        public static List<KeyValuePair<string, object>> getAppointList()
        {
            return appointmentList;
        }

        public void setAppList(List<KeyValuePair<string, object>> list)
        {
            appointmentList = list;
        }
        public DeleteAppointment()
        {
            InitializeComponent();
            popCustomerList();
            popAppointmentList();
            DefaultSettings();
            TimeLB.Text = DateTime.Now.ToString();
        }

        public void DefaultSettings()
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
            DeleteBT.Enabled = false;

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

        public void popCustomerList()
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
                MessageBox.Show("Error occured! " + ex);
            }
        }
        public void popAppointmentList()
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
                MessageBox.Show("Error occured! " + ex);
            }
        }
        public void populateFields(List<KeyValuePair<string, object>> appList)
        {
            //lambda expression to retrieve values from given appointmentList
            AppNameTB.Text = appList.First(kvp => kvp.Key == "title").Value.ToString();
            AppDescTB.Text = appList.First(kvp => kvp.Key == "description").Value.ToString();
            LocationTB.Text = appList.First(kvp => kvp.Key == "location").Value.ToString();
            PhoneTB.Text = appList.First(kvp => kvp.Key == "contact").Value.ToString();
            TypeCB.SelectedIndex = TypeCB.FindStringExact(appList.First(kvp => kvp.Key == "type").Value.ToString());
            
            string startTime = appointmentList.Find(kvp => kvp.Key == "start").Value.ToString();
            string endTime = appointmentList.Find(kvp => kvp.Key == "end").Value.ToString();
            StartTP.Value = Convert.ToDateTime(startTime).ToLocalTime();
            EndTP.Value = Convert.ToDateTime(endTime).ToLocalTime();
        }

        private void DeleteAppointment_Load(object sender, EventArgs e)
        {

        }

        //closes this form and goe sback to the home page / main form 
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this appointment? This action cannot be undone.", "", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    //delete appointment
                    var list = getAppointList();

                    //lambda expression to convert list to dictionary
                    IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                    Data.deleteApp(dictionary);
                    MessageBox.Show("Appointment successfully deleted.");
                    //refresh appointment list
                    popAppointmentList();
                    Form main = new Main();
                    main.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void CustCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            popAppointmentList();
            
            AppCB.Enabled = true;
            AppCB.SelectedItem = null;
            AppCB.Text = "--Select--";
            AppNameTB.Enabled = false;
            AppDescTB.Enabled = false;
            LocationTB.Enabled = false;
            PhoneTB.Enabled = false;
            TypeCB.Enabled = false;
            StartTP.Enabled = false;
            EndTP.Enabled = false;
            DeleteBT.Enabled = false;
            AppNameTB.Text = null;
            AppDescTB.Text = null;
            LocationTB.Text = null;
            PhoneTB.Text = null;
            TypeCB.SelectedItem = null;
        }

        private void AppCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataRowView drv = AppCB.SelectedItem as DataRowView;
            int id = Convert.ToInt32(AppCB.SelectedValue);
            var appList = Data.getAppList(id);
            setAppList(appList);
            

            if (AppCB.SelectedIndex != -1)
            {
                DeleteBT.Enabled = true;
                populateFields(appointmentList);
            }
        } 
    }
}
