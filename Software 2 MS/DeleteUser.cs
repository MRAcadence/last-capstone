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
    public partial class DeleteUser : Form
    {
        //creates the list userlist 
        public static List<KeyValuePair<string, object>> UserList;
      
        //sets the user list equal to the current list 
        public void setUserList(List<KeyValuePair<string, object>> list)
        {
            UserList = list;
        }
       //returns the userlist 
        public static List<KeyValuePair<string, object>> getUserList()
        {
            return UserList;
        }
        public DeleteUser()
        {
            InitializeComponent();
            popUserList();
            DefaultSettings();
            TimeLB.Text = DateTime.Now.ToString();
        }

        //fills the combo box with the users from the database
        public void popUserList()
        {
            MySqlConnection con = new MySqlConnection(Data.getConString());
            try
            {
                string q = "SELECT userId, concat(userName, ' --ID: ', userId) as Display FROM user;";
                MySqlDataAdapter sqlda = new MySqlDataAdapter(q, con);
                //opens the connection to the database
                con.Open();
                DataSet ds = new DataSet();
                sqlda.Fill(ds, "User");

                UserCB.DisplayMember = "Display";
                UserCB.ValueMember = "userId";
                UserCB.DataSource = ds.Tables["User"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Has Occured! " + ex);
            }
        }

        //sets the defult settings for the combobox
        public void DefaultSettings()
        {
            UserCB.SelectedItem = null;
            UserCB.Text = "--Select--";
        }

        
     

        //deletes the specified user from the database
        private void DeleteBT_Click(object sender, EventArgs e)
        {
            
            int uId;
            bool parseAccept = Int32.TryParse(UserCB.SelectedValue.ToString(), out uId);
           
            if (uId == Data.getUserID())
            {
                MessageBox.Show("Active Users Cannot Be Deleted, Please Select ANother Non Active User To Delete.");
                return;
            }
            else
            {
                DialogResult con = MessageBox.Show("Are You Sure That You Want To Delete This User? This Action Cannot Be Undone.", "", MessageBoxButtons.YesNo);
                
                if (con == DialogResult.Yes)
                {
                    try
                    {
                        
                        var list = getUserList();

                        //converting the list to a directory using a lambda expression
                       IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                        
                        //uId = Data.getUserID();

                        // Data.deleteUser(uId.ToString());
                        //dictionary["userId"] = uId;
                        

                        Data.deleteUser(dictionary["userId"].ToString());
                        
                        MessageBox.Show("User Was Deleted Successfully.");

                        
                        //Refreshing the appointment list
                        popUserList();
                        
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
        }

        //closes this form and then goes back to the home page / main form
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

        }

        //enables the previously locked defult settings allowing the values to be changed
        private void UserCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserCB.ValueMember == Data.getUserID().ToString())
            {
                MessageBox.Show("You cannot delete the active user. Please logout and switch user to try again.");
                return;
            }
            else
            {
                DataRowView drv = UserCB.SelectedItem as DataRowView;

                int id = Convert.ToInt32(UserCB.SelectedValue);
                var uList = Data.getUserList(id);
                setUserList(uList);


                if (UserCB.SelectedIndex != -1)
                {
                    DeleteBT.Enabled = true;
                }
            }
        }
    }
}
