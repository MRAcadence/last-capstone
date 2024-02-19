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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;

namespace Software_2_MS
{
    public partial class ModifyUser : Form
    {
        //creates list list
        public static List<KeyValuePair<string, object>> userList;
        public ModifyUser()
        {
            InitializeComponent();
            popUserList();
            DefaultSettings();
            TimeLB.Text = DateTime.Now.ToString();
        }

        //cancel button to exit this form and go back to the home page / main form 
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        //uses the empty check method to make sure that there are no blank text boxes left on the form
        public bool isEmpty()
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

        //uses the create button to send the updated information for the user to the database
        private void CreateBT_Click(object sender, EventArgs e)
        {
            //uses the empty check method to make sure that there are no blank text boxes left on the form
            bool accepted = isEmpty();

            if (accepted == true)
            {
                DialogResult conf = MessageBox.Show("Please Make Sure You Want To Commit This Update.", "", MessageBoxButtons.YesNo);
                if (conf == DialogResult.Yes)
                {
                    if (PsswrdTB.Text == ConPsswrdTB.Text)
                    {
                        try
                        {
                            var list = getUserList();
                            //converts the list to dictionary using lambda expressions
                            IDictionary<string, object> dict = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                            dict["userId"] = Convert.ToInt32(UserCB.SelectedValue); 
                            dict["userName"] = UsrNmTB.Text;
                            dict["password"] = PsswrdTB.Text;
                            dict["active"] = YesRB.Checked ? 1 : 0;
                            Data.updateUser(dict);
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                        }
                        finally
                        {
                            MessageBox.Show("User updated");
                            Form main = new Main();
                            main.Show();
                            this.Close();
                        }
                    }
                    else MessageBox.Show("Please Make Sure Passwrds Are The Same.");
                }
            }
            else
            {
                MessageBox.Show("Please Make Sure To Leave No Fields Empty.");
            }
        }

        //sets the user list equal to list 
        public void setUserList(List<KeyValuePair<string, object>> list)
        {
            userList = list;
        }

        //returns the user list
        public static List<KeyValuePair<string, object>> getUserList()
        {
            return userList;
        }

        //sets the default settings for the text boxes and combo boxes 
        public void DefaultSettings()
        {
            //fills the text blocks with preselected text
            UserCB.SelectedItem = null;
            UserCB.Text = "--Select--";
            UsrNmTB.Text = "--Please Enter UserName--";
            PsswrdTB.Text = "Please Enter Passwrod--";
            ConPsswrdTB.Text = "--Confirm Password--";

            //disables the text boxes
            YesRB.Checked = false;
            NoRB.Checked = false;
            UsrNmTB.Enabled = false;
            PsswrdTB.Enabled = false;
            ConPsswrdTB.Enabled = false;
            YesRB.Enabled = false;
            NoRB.Enabled = false;
            CreateBT.Enabled = false;

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

        //pulls information from the database to pop the list 
        public void popUserList()
        {
            MySqlConnection con = new MySqlConnection(Data.getConString());

            try
            {
                string q = "SELECT userId, concat(userName, ' --ID: ', userId)"+
                    "as Display FROM user;";
                    
                MySqlDataAdapter sqlda = new MySqlDataAdapter(q, con);
                con.Open();
                DataSet ds = new DataSet();
                sqlda.Fill(ds, "User");
                UserCB.DisplayMember = "Display";
                UserCB.ValueMember = "userId";
                UserCB.DataSource = ds.Tables["User"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
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

        //enables the previously locked text boxes and combo boxes 
        private void UserCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = UserCB.SelectedItem as DataRowView;
            int uId = Convert.ToInt32(UserCB.SelectedValue);
            var uList = Data.findUser(uId);
            setUserList(uList);

            if (uList != null)
            {

                UsrNmTB.Enabled = true;
                PsswrdTB.Enabled = true;
                ConPsswrdTB.Enabled = true;
                YesRB.Enabled = true;
                NoRB.Enabled = true;
                CreateBT.Enabled = true;

            }
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {

        }
    }
}
