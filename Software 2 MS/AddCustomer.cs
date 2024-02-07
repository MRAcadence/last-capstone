using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_2_MS
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            TimeLB.Text = DateTime.Now.ToString();
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

        //makes sure that the characters entered in the phone text box are allowed
        private void PhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsDigitOrControlKey(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //makes sure that the characters entered in the address text box are allowed
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

        //makes sure that the characters entered in the zip text box are allowed
        private void ZipTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsDigitOrControlKey(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //makes sure that the characters entered in the country text box are allowed
        private void CountryTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsAllowedCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //makes sure that none of the teext boxes or combos boxes are left blank
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

        //cancel button that exits tis current form and returns to the home page / main form
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        //creates the customer and sends the information to the customer table in the database 
        private void CreateBT_Click(object sender, EventArgs e)
        {
            bool accepted = isEmpty();
            if (accepted == true)
            {
                int makeCountry = Data.makeCountry(CountryTB.Text);
                int makeCity = Data.makeCity(makeCountry, CityTB.Text);
                int makeAddress = Data.makeAddress(makeCity, AddressTB.Text, address2TB.Text, ZipTB.Text, PhoneTB.Text);
                Data.addCustomer(Data.getID("customer", "customerId") + 1, NameTB.Text, makeAddress, YesRB.Checked ? 1 : 0, Data.getTime(), Data.getUserName());
                MessageBox.Show("Customer successfully created!");

                Form main = new Main();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Make Sure That You Have Entered Information For All Feilds.");
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
