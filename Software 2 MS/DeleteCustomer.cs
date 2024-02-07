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
    public partial class DeleteCustomer : Form
    {
        public static List<KeyValuePair<string, object>> CustList;
        public DeleteCustomer()
        {
            InitializeComponent();
            popCustomerList();
            DefaultSettings();
            TimeLB.Text = DateTime.Now.ToString();
        }

        // exits this form and heads back to the home page / main form
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        //deletes the customer by removing theentry from the database 
        private void DeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Are you sure you want to delete this customer? This cannot be undone.", "", MessageBoxButtons.YesNo);
            
            if (conf == DialogResult.Yes)
            {
                try
                {
                    var list = getCustList();
                    IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                    bool appointments = Data.checkApp(dictionary["customerId"].ToString());
                    
                    if (appointments == false)
                    {
                        Data.custDelete(dictionary);
                    }
                    else
                    {
                        DialogResult confirmation2 = MessageBox.Show("Are You Sure You Want To Delete This Customer?", "", MessageBoxButtons.YesNo);
                        if (confirmation2 == DialogResult.Yes)
                        {
                            Data.deleteCustomerApp(dictionary["customerId"].ToString());
                            Data.custDelete(dictionary);
                        }
                        else
                        {
                            return;
                        }
                    }
                    MessageBox.Show("Successfully Deleted Customer.");
                    Form main = new Main();
                    main.Show();
                    this.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        //enters customers from the database into the customers combobox
        public void popCustomerList()
        {
            MySqlConnection con = new MySqlConnection(Data.getConString());

            try
            {
                string query = "SELECT customerId, concat(customerName, ' --ID: ', customerId) as Display FROM customer;";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, con);
                con.Open();
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds, "Cust");
                CustCB.DisplayMember = "Display";
                CustCB.ValueMember = "customerId";
                CustCB.DataSource = ds.Tables["Cust"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
            }
        }
        public void setCustList(List<KeyValuePair<string, object>> list)
        {
            CustList = list;
        }
        public static List<KeyValuePair<string, object>> getCustList()
        {
            return CustList;
        }

        //once customer has been selected text boxes are filled with customer information (this is not editable)
        public void popFields(List<KeyValuePair<string, object>> custList)
        {
            //lambda expressions to retrieve values from given custList
            NameTB.Text = custList.First(kvp => kvp.Key == "customerName").Value.ToString();
            PhoneTB.Text = custList.First(kvp => kvp.Key == "phone").Value.ToString();
            AddressTB.Text = custList.First(kvp => kvp.Key == "address").Value.ToString();
            CityTB.Text = custList.First(kvp => kvp.Key == "city").Value.ToString();
            ZipTB.Text = custList.First(kvp => kvp.Key == "postalCode").Value.ToString();
            CountryTB.Text = custList.First(kvp => kvp.Key == "country").Value.ToString();
            if (Convert.ToInt32(custList.First(kvp => kvp.Key == "active").Value) == 1)
            {
                YesRB.Checked = true;
            }
            else
            {
                NoRB.Checked = true;
            }
        }

        //sets the default settings for the text boxes combo boxes and radio buttons
        public void DefaultSettings()
        {
            //fills the text blocks with preselected text 
            CustCB.SelectedItem = null;
            CustCB.Text = "--Select--";
            NameTB.Text = "--Please Enter Name--";
            PhoneTB.Text = "--Please Enter Phone Number--";
            AddressTB.Text = "--Please Enter Address--";
            CityTB.Text = "--Please Enter City--";
            ZipTB.Text = "--Please Enter Zip--";
            CountryTB.Text = "--Please Enter Name--";
            
            //disables the text boxes
            YesRB.Checked = false;
            NoRB.Checked = false;
            NameTB.Enabled = false;
            PhoneTB.Enabled = false;
            AddressTB.Enabled = false;
            CityTB.Enabled = false;
            ZipTB.Enabled = false;
            CountryTB.Enabled = false;
            YesRB.Enabled = false;
            NoRB.Enabled = false;
            
            //sets the font for the text boxes 
            NameTB.Font = new Font("Arial", 12);
            PhoneTB.Font = new Font("Arial", 12);
            AddressTB.Font = new Font("Arial", 12);
            CityTB.Font = new Font("Arial", 12);
            ZipTB.Font = new Font("Arial", 12);
            CountryTB.Font = new Font("Arial", 12);
           
            //sets the border style for the text boxes
            NameTB.BorderStyle = BorderStyle.FixedSingle;
            PhoneTB.BorderStyle = BorderStyle.FixedSingle;
            AddressTB.BorderStyle = BorderStyle.FixedSingle;
            CityTB.BorderStyle = BorderStyle.FixedSingle;
            ZipTB.BorderStyle = BorderStyle.FixedSingle;
            CountryTB.BorderStyle = BorderStyle.FixedSingle; 
            
            //sets the alightnment for the text boxes
            NameTB.TextAlign = HorizontalAlignment.Center;
            PhoneTB.TextAlign = HorizontalAlignment.Center;
            AddressTB.TextAlign = HorizontalAlignment.Center;
            CityTB.TextAlign = HorizontalAlignment.Center;
            ZipTB.TextAlign = HorizontalAlignment.Center;
            CountryTB.TextAlign = HorizontalAlignment.Center;
           
            //sets the max length of characters that can be entered into the text boxes
            NameTB.MaxLength = 50;
            PhoneTB.MaxLength = 50;
            AddressTB.MaxLength = 50;
            CityTB.MaxLength = 50;
            ZipTB.MaxLength = 50;
            CountryTB.MaxLength = 50; 
           
            //sets the background color for the text boxes 
            NameTB.BackColor = Color.LightGray;
            PhoneTB.BackColor = Color.LightGray;
            AddressTB.BackColor = Color.LightGray;
            CityTB.BackColor = Color.LightGray;
            ZipTB.BackColor = Color.LightGray;
            CountryTB.BackColor = Color.LightGray;
            
            //sets the forecolor of the text boxes
            NameTB.ForeColor = Color.Blue;
            PhoneTB.ForeColor = Color.Blue;
            AddressTB.ForeColor = Color.Blue;
            CityTB.ForeColor = Color.Blue;
            ZipTB.ForeColor = Color.Blue;
            CountryTB.ForeColor = Color.Blue;
        }

        //makes sure that the text box is fulled out with letters and not white space or numbers
        private bool IsAllowedCharacter(char character)
        {
            return char.IsLetter(character) || char.IsWhiteSpace(character) || char.IsControl(character);
        }
        //makes sure that the text box is flled iwth numbers and not letters or whitespace 
        private bool IsDigitOrControlKey(char character)
        {
            return char.IsDigit(character) || char.IsControl(character);
        }
        //these are the specific text boxes that use one of the two above methods to make sure there are no errors when filling out the form
        private void NameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsAllowedCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsDigitOrControlKey(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddressTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsAllowedCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ZipTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsDigitOrControlKey(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CountryTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsAllowedCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //chekcs to make sure that none of the text box or combo box fields are left blank
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

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }


        //enables the previously disabled text box and combo box entry fields 
        private void CustCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = CustCB.SelectedItem as DataRowView;
            int id = Convert.ToInt32(CustCB.SelectedValue);
            var customerList = Data.customerFinder(id);
            setCustList(customerList);
            if (customerList != null)
            {
                popFields(customerList);
            }
        }
    }
}
