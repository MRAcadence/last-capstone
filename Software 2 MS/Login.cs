using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_2_MS
{
    public partial class Login : Form
    {

        public string loginError = "Username or password do match. Please enter the correct information.";
        public string exitMessage = "Are you sure you want to exit?";
        public Login()
        {
            InitializeComponent();
            languageCheck(CultureInfo.CurrentUICulture.LCID);
            TimeLB.Text = DateTime.Now.ToString();
        }

        private void languageCheck(int LCID)
        {
            
            if (LCID == 1036)
            {
                this.Text = "Connexion";                        // connection
                UserNameLB.Text = "Nom d'utilisateur";          // username
                PassLB.Text = "Mot de passe";                   // password
                LoginBT.Text = "Connexion";                     // connection
                ExitBT.Text = "Sortie";                         // exit
                loginError = "Le nom d'utilisateur ou le mot de passe correspondent à tous les comptes. Veuillez réessayer."; // string error
                exitMessage = "Voulez-vous vraiment sortir?";   // string exit
                label1.Text = "Se connecter";
                PasswordCKBX.Text = "montrer le mot de passe";
            }
            else if (LCID == 1031)
            {
                this.Text = "Verbindung";                       // connection
                UserNameLB.Text = "Nutzername";                 // username
                PassLB.Text = "Passwort";                       // password
                LoginBT.Text = "Verbindung";                    // connection
                ExitBT.Text = "Ausfahrt";                       // exit
                loginError = "Benutzername oder Passwort stimmen mit allen Konten überein. Bitte versuche es erneut."; // string error
                exitMessage = "Willst du wirklich gehen?";      // string exit
            }
            else if (LCID == 1082)
            {
                this.Text = "Conexión";                         // connection
                UserNameLB.Text = "Nombre de usuario";          // username
                PassLB.Text = "Contraseña";                     // password
                LoginBT.Text = "Conexión";                      // connection
                ExitBT.Text = "Salida";                         // exit
                loginError = "El nombre de usuario o la contraseña coinciden con cualquier cuenta. Inténtalo de nuevo."; // string error
                exitMessage = "¿Realmente desea salir?";        // string exit
            }
            else if (LCID == 1049)
            {
                this.Text = "Связь";                            // connection
                UserNameLB.Text = "Имя пользователя";           // username
                PassLB.Text = "Пароль";                         // password
                LoginBT.Text = "Связь";                         // connection
                ExitBT.Text = "Выход";                          // exit
                loginError = "Имя пользователя или пароль соответствуют любым учетным записям. Пожалуйста, попробуйте еще раз."; // string error
                exitMessage = "Вы действительно хотите выйти?"; // string exit
            }
            else if (LCID == 1053)
            {
                this.Text = "förbindelse";                      // connection
                UserNameLB.Text = "Användarnamn";               // username
                PassLB.Text = "Lösenord";                       // password
                LoginBT.Text = "förbindelse";                   // connection
                ExitBT.Text = "Utgång";                         // exit
                loginError = "Användarnamn eller lösenord matchar alla konton. Var god försök igen."; // string error
                exitMessage = "Vill du verkligen avsluta?";     // string exit
            }
        }

        //exits the program 
        private void ExitBT_Click(object sender, EventArgs e)
        {
            var conf = MessageBox.Show(exitMessage, this.Text, MessageBoxButtons.YesNo);
            if (conf == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //logs user into the program by comparing information entered into prompts against information stored in the database
        private void LoginBT_Click(object sender, EventArgs e)
        {
            string user = UsrNameTB.Text;
            string password = PsswrdTB.Text;
            //compares username and password the database
            if (Data.userCheck(user, password) == 1)
            {
                //using timestamp login and record with tracker to .txt file/ open the main page / close the login page
                Tracker.TrackerLogin(Data.getUserName());
                Form Main = new Main();
                Tracker.AppReminder();
                Main.Show();
                this.Hide();

            }
            else MessageBox.Show(loginError);
        }

        //adds a functionality to the login page where it automatically make sthe password hiddden but you cna click the checkbox to show the characters in the text box
        private void PasswordCKBX_CheckedChanged(object sender, EventArgs e)
        {
            if(PasswordCKBX.Checked == true) 
            {
                PsswrdTB.UseSystemPasswordChar = false;
            }
            else
            {
                PsswrdTB.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
