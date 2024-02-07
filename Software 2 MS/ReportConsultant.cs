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

    public partial class ReportConsultant : Form
    {
        public ReportConsultant()
        {
            InitializeComponent();
            populateUserList();
            ConsultantCB.SelectedItem = null;
            RepoConsultant.Visible = false;
            ConsultantCB.Text = "--Select--";
            TimeLB.Text = DateTime.Now.ToString();
            
        }

        //pulls information from the database to the userlist 
        public void populateUserList()
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
                
                ConsultantCB.DisplayMember = "Display";
                ConsultantCB.ValueMember = "userId";
                ConsultantCB.DataSource = ds.Tables["User"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Has Occured! " + ex);
            }
        }

        //closes this forma nd returns to the hom page / main form
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

        private void ReportConsultant_Load(object sender, EventArgs e)
        {
            
        }

        //enters information from the database into the combo box
        private void ConsultantCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConsultantCB.SelectedIndex != -1)
            {
                int userId = Convert.ToInt32(ConsultantCB.SelectedValue);
                //string name = Data.getUserName();
                //string userId = ConsultantCB.SelectedValue.ToString();
                DataTable dtr = Data.getAppByUser(userId.ToString());

                RepoConsultant.DataSource = dtr;
                RepoConsultant.Visible = true;
            }
        }

        private void RepoConsultant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
