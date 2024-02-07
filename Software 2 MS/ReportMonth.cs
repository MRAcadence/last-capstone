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
    public partial class ReportMonth : Form
    {
        public ReportMonth()
        {
            InitializeComponent();
            TimeLB.Text = DateTime.Now.ToString();
        }

        //closes this current form and returns to the home page / main form 
        private void CancelBT_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            this.Close();
        }

       

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = typeComboBox.SelectedItem.ToString();
            IDictionary<string, object> dic = Data.appByMonth(t);
            jan.Text = dic["Jan"].ToString();
            feb.Text = dic["Feb"].ToString();
            mar.Text = dic["Mar"].ToString();
            apr.Text = dic["Apr"].ToString();
            may.Text = dic["May"].ToString();
            jun.Text = dic["Jun"].ToString();
            jul.Text = dic["Jul"].ToString();
            aug.Text = dic["Aug"].ToString();
            sep.Text = dic["Sep"].ToString();
            oct.Text = dic["Oct"].ToString();
            nov.Text = dic["Nov"].ToString();
            dec.Text = dic["Feb"].ToString();
        }

        private void ReportMonth_Load(object sender, EventArgs e)
        {

        }
    }
}
