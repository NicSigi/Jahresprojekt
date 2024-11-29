namespace Glücksspielapp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.Text = "Willkommen! Bitte einloggen";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // txtUsername
            // 
            this.txtUsername.Text = "Benutzername eingeben";  // Placeholder für Benutzername
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(75, 100);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 30);
            this.txtUsername.GotFocus += (sender, e) =>
            {
                if (txtUsername.Text == "Benutzername eingeben")
                {
                    txtUsername.Text = "";
                    txtUsername.ForeColor = System.Drawing.Color.Black;
                }
            };
            this.txtUsername.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Text = "Benutzername eingeben";  // Placeholder zurücksetzen
                    txtUsername.ForeColor = System.Drawing.Color.Gray;
                }
            };

            // 
            // txtPassword
            // 
            this.txtPassword.Text = "Passwort eingeben";  // Placeholder für Passwort
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(75, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 30);
            this.txtPassword.PasswordChar = '\0';  // Passwortfeld sichtbar
            this.txtPassword.GotFocus += (sender, e) =>
            {
                if (txtPassword.Text == "Passwort eingeben")
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = System.Drawing.Color.Black;
                    txtPassword.PasswordChar = '*'; // Passwort verstecken
                }
            };
            this.txtPassword.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Text = "Passwort eingeben";  // Placeholder zurücksetzen
                    txtPassword.ForeColor = System.Drawing.Color.Gray;
                    txtPassword.PasswordChar = '\0'; // Passwort sichtbar machen
                }
            };

            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(150, 200);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);

            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(75, 250);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(250, 20);
            this.lblError.Text = "";

            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblError);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzer Login";
        }



        #endregion
    }
}