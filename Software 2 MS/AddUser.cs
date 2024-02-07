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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            DefaultSettings();
            TimeLB.Text = DateTime.Now.ToString();
        }
        //checks that no text boxes or combo boxes were left blank 
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

        public void DefaultSettings()
        {
            //fills the text blocks with preselected text
            UsrNmTB.Text = "--Please Enter UserName--";
            PsswrdTB.Text = "Please Enter Passwrod--";
            ConPsswrdTB.Text = "--Confirm Password--";

            //sets the font for the text boxes
            UsrNmTB.Font = new Font("Arial", 12);
            PsswrdTB.Font = new Font("Arial", 12);
            ConPsswrdTB.Font = new Font("Arial", 12);

            //sets the border style for the text boxes
            UsrNmTB.BorderStyle = BorderStyle.FixedSingle;
            PsswrdTB.BorderStyle = BorderStyle.FixedSingle;
            ConPsswrdTB.BorderStyle = BorderStyle.FixedSingle;

            //sets the alightnment for the text boxes
            UsrNmTB.TextAlign = HorizontalAlignment.Center;
            PsswrdTB.TextAlign = HorizontalAlignment.Center;
            ConPsswrdTB.TextAlign = HorizontalAlignment.Center;

            //sets the max length of characters that can be entered into the text boxes
            UsrNmTB.MaxLength = 50;
            PsswrdTB.MaxLength = 50;
            ConPsswrdTB.MaxLength = 50;

            //sets the background color for the text boxes 
            UsrNmTB.BackColor = Color.LightGray;
            PsswrdTB.BackColor = Color.LightGray;
            ConPsswrdTB.BackColor = Color.LightGray;

            //sets the forecolor of the text boxes
            UsrNmTB.ForeColor = Color.Blue;
            PsswrdTB.ForeColor = Color.Blue;
            ConPsswrdTB.ForeColor = Color.Blue;
        }
        //makes sure that any feilds that aree filled out are filled out with the only alllowable characters
        private bool IsAllowedCharacter(char character)
        {
            return char.IsLetter(character) || char.IsWhiteSpace(character) || char.IsControl(character);
        }

        //closes the current form and returns to the home page / main form
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        //creates the user and sends the data to the database 
        private void CreateBT_Click(object sender, EventArgs e)
        {
            bool accepted = isEmpty();
            if (accepted == true)
            {
                if (PsswrdTB.Text == ConPsswrdTB.Text)
                {
                    Data.addUser(Data.getID("user", "userId") + 1, UsrNmTB.Text, PsswrdTB.Text, YesRB.Checked ? 1 : 0, Data.getTime(), Data.getUserName());
                    MessageBox.Show("Successfully Created Customer!");
                    Form main = new Main();
                    main.Show();
                    this.Close();
                }
                else MessageBox.Show("Please Make Sure That Both Passwords Match.");
            }
            else MessageBox.Show("Please Make Sure To Correctly Fill Out All Fields.");
        }

        private void UsrNmTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsAllowedCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PasswordCKBX_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCKBX.Checked == true)
            {
                PsswrdTB.UseSystemPasswordChar = false;
                ConPsswrdTB.UseSystemPasswordChar = false;
            }
            else
            {
                PsswrdTB.UseSystemPasswordChar = true;
                ConPsswrdTB.UseSystemPasswordChar = true;
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
