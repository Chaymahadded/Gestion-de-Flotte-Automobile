namespace WindowsFormsApp1
{
    partial class Registre
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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.txtusename = new MetroFramework.Controls.MetroTextBox();
            this.txtpwd = new MetroFramework.Controls.MetroTextBox();
            this.txtcpwd = new MetroFramework.Controls.MetroTextBox();
            this.btncreer = new MetroFramework.Controls.MetroTile();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(227, 196);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(82, 13);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Déja un compte";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.Teal;
            this.metroTile2.Location = new System.Drawing.Point(415, 234);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(73, 36);
            this.metroTile2.TabIndex = 15;
            this.metroTile2.Text = "Fermer";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // txtusename
            // 
            // 
            // 
            // 
            this.txtusename.CustomButton.Image = null;
            this.txtusename.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.txtusename.CustomButton.Name = "";
            this.txtusename.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtusename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusename.CustomButton.TabIndex = 1;
            this.txtusename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusename.CustomButton.UseSelectable = true;
            this.txtusename.CustomButton.Visible = false;
            this.txtusename.Lines = new string[0];
            this.txtusename.Location = new System.Drawing.Point(262, 72);
            this.txtusename.MaxLength = 32767;
            this.txtusename.Name = "txtusename";
            this.txtusename.PasswordChar = '\0';
            this.txtusename.PromptText = "Nom utilisateur";
            this.txtusename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusename.SelectedText = "";
            this.txtusename.SelectionLength = 0;
            this.txtusename.SelectionStart = 0;
            this.txtusename.ShortcutsEnabled = true;
            this.txtusename.Size = new System.Drawing.Size(226, 28);
            this.txtusename.TabIndex = 13;
            this.txtusename.UseSelectable = true;
            this.txtusename.WaterMark = "Nom utilisateur";
            this.txtusename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtpwd.Location = new System.Drawing.Point(262, 118);
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
            this.txtpwd.TabIndex = 12;
            this.txtpwd.UseSelectable = true;
            this.txtpwd.WaterMark = "Mot de passe";
            this.txtpwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtcpwd
            // 
            // 
            // 
            // 
            this.txtcpwd.CustomButton.Image = null;
            this.txtcpwd.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.txtcpwd.CustomButton.Name = "";
            this.txtcpwd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtcpwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcpwd.CustomButton.TabIndex = 1;
            this.txtcpwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcpwd.CustomButton.UseSelectable = true;
            this.txtcpwd.CustomButton.Visible = false;
            this.txtcpwd.Lines = new string[0];
            this.txtcpwd.Location = new System.Drawing.Point(262, 165);
            this.txtcpwd.MaxLength = 32767;
            this.txtcpwd.Name = "txtcpwd";
            this.txtcpwd.PasswordChar = '\0';
            this.txtcpwd.PromptText = "Confirmer mot de passe";
            this.txtcpwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcpwd.SelectedText = "";
            this.txtcpwd.SelectionLength = 0;
            this.txtcpwd.SelectionStart = 0;
            this.txtcpwd.ShortcutsEnabled = true;
            this.txtcpwd.Size = new System.Drawing.Size(226, 28);
            this.txtcpwd.TabIndex = 20;
            this.txtcpwd.UseSelectable = true;
            this.txtcpwd.WaterMark = "Confirmer mot de passe";
            this.txtcpwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcpwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btncreer
            // 
            this.btncreer.ActiveControl = null;
            this.btncreer.BackColor = System.Drawing.Color.Teal;
            this.btncreer.Location = new System.Drawing.Point(336, 234);
            this.btncreer.Name = "btncreer";
            this.btncreer.Size = new System.Drawing.Size(73, 36);
            this.btncreer.TabIndex = 22;
            this.btncreer.Text = "Créer";
            this.btncreer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncreer.UseCustomBackColor = true;
            this.btncreer.UseSelectable = true;
            this.btncreer.Click += new System.EventHandler(this.btncreer_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.eye_closed;
            this.pictureBox6.Location = new System.Drawing.Point(490, 165);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.eye_closed;
            this.pictureBox5.Location = new System.Drawing.Point(490, 118);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources._8;
            this.pictureBox4.Location = new System.Drawing.Point(230, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources._8;
            this.pictureBox3.Location = new System.Drawing.Point(230, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._4;
            this.pictureBox2.Location = new System.Drawing.Point(230, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._10;
            this.pictureBox1.Location = new System.Drawing.Point(23, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Registre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 302);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btncreer);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtcpwd);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.txtusename);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Registre";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Créer Compte";
            this.Load += new System.EventHandler(this.Registre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox txtusename;
        private MetroFramework.Controls.MetroTextBox txtpwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTextBox txtcpwd;
        private MetroFramework.Controls.MetroTile btncreer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}