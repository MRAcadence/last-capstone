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
    
    
    public partial class ModifyCusteromer : Form
    {
        //creates list 
        public static List<KeyValuePair<string, object>> ListCustomer;
        public ModifyCusteromer()
        {
            InitializeComponent();
            popCustomerList();
            DefaultSettings();
            TimeLB.Text = DateTime.Now.ToString();
        }

        //sets the customer list equal to list 
        public void setCustList(List<KeyValuePair<string, object>> list)
        {
            ListCustomer = list;
        }

        //returns the customer list 
        public static List<KeyValuePair<string, object>> getCustList()
        {
            return ListCustomer;
        }

        //sets the default settings for the text boxes and combo boxes 
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
            UpdateBT.Enabled = false;

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

        //populates the selection for the customer list from the database 
        public void popCustomerList()
        {
            MySqlConnection con = new MySqlConnection(Data.getConString());

            try
            {
                string q = $"SELECT customerId, concat(customerName, ' --ID: ', customerId) as Display FROM customer;"; 
                //string q = $"SELECT customerId,"+
                  //  "concat(customerName, ' --ID: ', customerId) as Display"+
                    //"FROM customer;";
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

        //lambda expression to pull the values from the cust list
        public void popFields(List<KeyValuePair<string, object>> ListCustomer)
        {
            //lambda expression to pull the values from the cust list
            NameTB.Text = ListCustomer.First(kvp => kvp.Key == "customerName").Value.ToString();
            PhoneTB.Text = ListCustomer.First(kvp => kvp.Key == "phone").Value.ToString();
            AddressTB.Text = ListCustomer.First(kvp => kvp.Key == "address").Value.ToString();
            CityTB.Text = ListCustomer.First(kvp => kvp.Key == "city").Value.ToString();
            ZipTB.Text = ListCustomer.First(kvp => kvp.Key == "postalCode").Value.ToString();
            CountryTB.Text = ListCustomer.First(kvp => kvp.Key == "country").Value.ToString();
            if (Convert.ToInt32(ListCustomer.First(kvp => kvp.Key == "active").Value) == 1)
            {
                YesRB.Checked = true;
            }
            else
            {
                NoRB.Checked = true;
            }
        }

        //sends the updated information to the customer table in the database 
        private void UpdateBT_Click(object sender, EventArgs e)
        {
            //uses the empty check method to make sure that there are no blank text boxes left on the form
            bool accepted = isEmpty();

            if (accepted == true)
            {
                DialogResult conf = MessageBox.Show("Please Make Sure That You Want To Make These Changes.", "", MessageBoxButtons.YesNo);
                if (conf == DialogResult.Yes)
                {
                    try
                    {
                        var list = getCustList();
                        //converting the l;ist into a dictionary using lambda expressions
                        IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                        dictionary["customerName"] = NameTB.Text;
                        dictionary["phone"] = PhoneTB.Text;
                        dictionary["address"] = AddressTB.Text;
                        dictionary["address2"] = address2TB.Text;
                        dictionary["city"] = CityTB.Text;
                        dictionary["postalCode"] = ZipTB.Text;
                        dictionary["country"] = CountryTB.Text;
                        dictionary["active"] = YesRB.Checked ? 1 : 0;
                        Data.modifyCustomer(dictionary);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                    finally
                    {
                        MessageBox.Show("Information For Customer Has Been Successfuly updated");
                        Form main = new Main();
                        main.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Make Sure No Feilds Are Left Blank");
            }
        }

        //cancel button to close this form and go back to the home page / main form
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }
       
        //uses the empty check method to make sure that there are no blank text boxes left on the form
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

        private void Address2TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ModifyCusteromer_Load(object sender, EventArgs e)
        {

        }

        //puts the selected customers info into the text boxes from the database
        private void CustCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = CustCB.SelectedItem as DataRowView;
            int id = Convert.ToInt32(CustCB.SelectedValue);
            var ListCustomer = Data.customerFinder(id);
            setCustList(ListCustomer);
            if (ListCustomer != null)
            {
                popFields(ListCustomer);
                NameTB.Enabled = true;
                PhoneTB.Enabled = true;
                AddressTB.Enabled = true;
                CityTB.Enabled = true;
                ZipTB.Enabled = true;
                CountryTB.Enabled = true;
                YesRB.Enabled = true;
                NoRB.Enabled = true;
                UpdateBT.Enabled = true;
            }
        }
    }
}
