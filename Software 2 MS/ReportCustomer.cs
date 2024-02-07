using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Software_2_MS
{
    public partial class ReportCustomer : Form
    {
        public ReportCustomer()
        {
            InitializeComponent();
            popCustList();
            CustomerCB.SelectedItem = null;
            RepoCustDV.Visible = false;
            CustomerCB.Text = "--Select--";
            TimeLB.Text = DateTime.Now.ToString();
        }
        
        //pulls information from the data base to the customer combo box
        public void popCustList()
        {
            MySqlConnection con = new MySqlConnection(Data.getConString());

            try
            {
                string q = "SELECT customerId, concat(customerName, ' --ID: ', customerId)"+
                    "as Display FROM customer;";
                MySqlDataAdapter sqlda = new MySqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                sqlda.Fill(ds, "Cust");
                CustomerCB.DisplayMember = "Display";
                CustomerCB.ValueMember = "customerId";
                CustomerCB.DataSource = ds.Tables["Cust"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
            }
        }

        //closes this form and redirects back to the home page / main form
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        //fetches the appointment data for the selected customer 
        private void CustomerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerCB.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(CustomerCB.SelectedValue);
                DataTable dtr = Data.getAppByCust(id.ToString());
                RepoCustDV.DataSource = dtr;
                RepoCustDV.Visible = true;
            }
        }

        private void ReportCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
