namespace WindowsFormsApp1
{
    partial class EditVT
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
            this.datepv = new MetroFramework.Controls.MetroDateTime();
            this.datev = new MetroFramework.Controls.MetroDateTime();
            this.btnann = new MetroFramework.Controls.MetroButton();
            this.btneng = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtvehicule = new MetroFramework.Controls.MetroTextBox();
            this.txtmontant = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datepv
            // 
            this.datepv.Location = new System.Drawing.Point(472, 94);
            this.datepv.MinimumSize = new System.Drawing.Size(0, 29);
            this.datepv.Name = "datepv";
            this.datepv.Size = new System.Drawing.Size(120, 29);
            this.datepv.Style = MetroFramework.MetroColorStyle.Teal;
            this.datepv.TabIndex = 92;
            this.datepv.UseCustomBackColor = true;
            this.datepv.UseCustomForeColor = true;
            this.datepv.UseStyleColors = true;
            // 
            // datev
            // 
            this.datev.Location = new System.Drawing.Point(174, 145);
            this.datev.MinimumSize = new System.Drawing.Size(0, 29);
            this.datev.Name = "datev";
            this.datev.Size = new System.Drawing.Size(118, 29);
            this.datev.Style = MetroFramework.MetroColorStyle.Teal;
            this.datev.TabIndex = 91;
            this.datev.UseCustomBackColor = true;
            this.datev.UseCustomForeColor = true;
            this.datev.UseStyleColors = true;
            // 
            // btnann
            // 
            this.btnann.BackColor = System.Drawing.Color.Red;
            this.btnann.ForeColor = System.Drawing.Color.White;
            this.btnann.Location = new System.Drawing.Point(514, 207);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(76, 34);
            this.btnann.TabIndex = 90;
            this.btnann.Text = "Annuler";
            this.btnann.UseCustomBackColor = true;
            this.btnann.UseCustomForeColor = true;
            this.btnann.UseSelectable = true;
            this.btnann.UseStyleColors = true;
            this.btnann.Click += new System.EventHandler(this.btnann_Click);
            // 
            // btneng
            // 
            this.btneng.BackColor = System.Drawing.Color.Green;
            this.btneng.ForeColor = System.Drawing.Color.White;
            this.btneng.Location = new System.Drawing.Point(425, 207);
            this.btneng.Name = "btneng";
            this.btneng.Size = new System.Drawing.Size(76, 34);
            this.btneng.TabIndex = 89;
            this.btneng.Text = "Enregistrer";
            this.btneng.UseCustomBackColor = true;
            this.btneng.UseCustomForeColor = true;
            this.btneng.UseSelectable = true;
            this.btneng.UseStyleColors = true;
            this.btneng.Click += new System.EventHandler(this.btneng_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel8.Location = new System.Drawing.Point(314, 156);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(63, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 87;
            this.metroLabel8.Text = "Montant";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel7.Location = new System.Drawing.Point(314, 104);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(137, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 86;
            this.metroLabel7.Text = "Date prochaine visite";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(79, 156);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 85;
            this.metroLabel2.Text = "Date Visite";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(79, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 84;
            this.metroLabel1.Text = "Véhicule";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtvehicule
            // 
            // 
            // 
            // 
            this.txtvehicule.CustomButton.Image = null;
            this.txtvehicule.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtvehicule.CustomButton.Name = "";
            this.txtvehicule.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtvehicule.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtvehicule.CustomButton.TabIndex = 1;
            this.txtvehicule.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtvehicule.CustomButton.UseSelectable = true;
            this.txtvehicule.CustomButton.Visible = false;
            this.txtvehicule.Lines = new string[0];
            this.txtvehicule.Location = new System.Drawing.Point(172, 94);
            this.txtvehicule.MaxLength = 32767;
            this.txtvehicule.Name = "txtvehicule";
            this.txtvehicule.PasswordChar = '\0';
            this.txtvehicule.ReadOnly = true;
            this.txtvehicule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtvehicule.SelectedText = "";
            this.txtvehicule.SelectionLength = 0;
            this.txtvehicule.SelectionStart = 0;
            this.txtvehicule.ShortcutsEnabled = true;
            this.txtvehicule.Size = new System.Drawing.Size(120, 30);
            this.txtvehicule.TabIndex = 83;
            this.txtvehicule.UseSelectable = true;
            this.txtvehicule.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtvehicule.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtmontant
            // 
            // 
            // 
            // 
            this.txtmontant.CustomButton.Image = null;
            this.txtmontant.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtmontant.CustomButton.Name = "";
            this.txtmontant.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtmontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmontant.CustomButton.TabIndex = 1;
            this.txtmontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmontant.CustomButton.UseSelectable = true;
            this.txtmontant.CustomButton.Visible = false;
            this.txtmontant.Lines = new string[0];
            this.txtmontant.Location = new System.Drawing.Point(472, 144);
            this.txtmontant.MaxLength = 32767;
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.PasswordChar = '\0';
            this.txtmontant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmontant.SelectedText = "";
            this.txtmontant.SelectionLength = 0;
            this.txtmontant.SelectionStart = 0;
            this.txtmontant.ShortcutsEnabled = true;
            this.txtmontant.Size = new System.Drawing.Size(120, 30);
            this.txtmontant.TabIndex = 93;
            this.txtmontant.UseSelectable = true;
            this.txtmontant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmontant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 252);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.datepv);
            this.Controls.Add(this.datev);
            this.Controls.Add(this.btnann);
            this.Controls.Add(this.btneng);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtvehicule);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "EditVT";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "       Modifier visite technique";
            this.Load += new System.EventHandler(this.EditVT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime datepv;
        private MetroFramework.Controls.MetroDateTime datev;
        private MetroFramework.Controls.MetroButton btnann;
        private MetroFramework.Controls.MetroButton btneng;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtvehicule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtmontant;
    }
}