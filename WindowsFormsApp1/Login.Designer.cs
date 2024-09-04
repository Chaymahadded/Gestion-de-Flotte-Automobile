namespace WindowsFormsApp1
{
    partial class Login
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
            this.txtpwd = new MetroFramework.Controls.MetroTextBox();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.btnconnexion = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pwdoublie = new System.Windows.Forms.LinkLabel();
            this.creercompte = new System.Windows.Forms.LinkLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpwd
            // 
            // 
            // 
            // 
            this.txtpwd.CustomButton.Image = null;
            this.txtpwd.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.txtpwd.CustomButton.Name = "";
            this.txtpwd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtpwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpwd.CustomButton.TabIndex = 1;
            this.txtpwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpwd.CustomButton.UseSelectable = true;
            this.txtpwd.CustomButton.Visible = false;
            this.txtpwd.Lines = new string[0];
            this.txtpwd.Location = new System.Drawing.Point(234, 123);
            this.txtpwd.MaxLength = 32767;
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '\0';
            this.txtpwd.PromptText = "Mot de passe";
            this.txtpwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpwd.SelectedText = "";
            this.txtpwd.SelectionLength = 0;
            this.txtpwd.SelectionStart = 0;
            this.txtpwd.ShortcutsEnabled = true;
            this.txtpwd.Size = new System.Drawing.Size(226, 28);
            this.txtpwd.TabIndex = 2;
            this.txtpwd.UseSelectable = true;
            this.txtpwd.WaterMark = "Mot de passe";
            this.txtpwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.CustomButton.Image = null;
            this.txtusername.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.txtusername.CustomButton.Name = "";
            this.txtusername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusername.CustomButton.TabIndex = 1;
            this.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusername.CustomButton.UseSelectable = true;
            this.txtusername.CustomButton.Visible = false;
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(234, 77);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PromptText = "Nom utilisateur";
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(226, 28);
            this.txtusername.TabIndex = 3;
            this.txtusername.UseSelectable = true;
            this.txtusername.WaterMark = "Nom utilisateur";
            this.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnconnexion
            // 
            this.btnconnexion.ActiveControl = null;
            this.btnconnexion.BackColor = System.Drawing.Color.Teal;
            this.btnconnexion.Location = new System.Drawing.Point(246, 185);
            this.btnconnexion.Name = "btnconnexion";
            this.btnconnexion.Size = new System.Drawing.Size(103, 36);
            this.btnconnexion.TabIndex = 4;
            this.btnconnexion.Text = "Connexion";
            this.btnconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnconnexion.UseCustomBackColor = true;
            this.btnconnexion.UseSelectable = true;
            this.btnconnexion.Click += new System.EventHandler(this.btnconnexion_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.Teal;
            this.metroTile2.Location = new System.Drawing.Point(355, 185);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(103, 36);
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "Fermer";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // pwdoublie
            // 
            this.pwdoublie.AutoSize = true;
            this.pwdoublie.Location = new System.Drawing.Point(347, 154);
            this.pwdoublie.Name = "pwdoublie";
            this.pwdoublie.Size = new System.Drawing.Size(111, 13);
            this.pwdoublie.TabIndex = 9;
            this.pwdoublie.TabStop = true;
            this.pwdoublie.Text = "Mot de passe oublié ?";
            this.pwdoublie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pwdoublie_LinkClicked);
            // 
            // creercompte
            // 
            this.creercompte.AutoSize = true;
            this.creercompte.Location = new System.Drawing.Point(199, 154);
            this.creercompte.Name = "creercompte";
            this.creercompte.Size = new System.Drawing.Size(85, 13);
            this.creercompte.TabIndex = 10;
            this.creercompte.TabStop = true;
            this.creercompte.Text = "Créer un compte";
            this.creercompte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creercompte_LinkClicked);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.eye_closed;
            this.pictureBox5.Location = new System.Drawing.Point(464, 123);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources._8;
            this.pictureBox3.Location = new System.Drawing.Point(202, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._4;
            this.pictureBox2.Location = new System.Drawing.Point(202, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(29, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.creercompte);
            this.Controls.Add(this.pwdoublie);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.btnconnexion);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtpwd;
        private MetroFramework.Controls.MetroTextBox txtusername;
        private MetroFramework.Controls.MetroTile btnconnexion;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel pwdoublie;
        private System.Windows.Forms.LinkLabel creercompte;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

