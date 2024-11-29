using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glücksspielapp
{
    public partial class LoginForm : Form
    {
        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblError;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Bitte Benutzername und Passwort eingeben!";
                return;
            }

            // Beispiel: Einfacher Vergleich (später mit Datenbank ersetzen)
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login erfolgreich!");
                this.Hide(); // LoginForm schließen
                MainForm mainForm = new MainForm(); // Hauptfenster öffnen (falls vorhanden)
                mainForm.Show();
            }
            else
            {
                lblError.Text = "Benutzername oder Passwort falsch.";
            }
        }

    }
}
