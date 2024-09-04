namespace WindowsFormsApp1
{
    partial class AddReparation
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtmontant = new MetroFramework.Controls.MetroTextBox();
            this.daterep = new MetroFramework.Controls.MetroDateTime();
            this.cmvehicule = new MetroFramework.Controls.MetroComboBox();
            this.btnann = new MetroFramework.Controls.MetroButton();
            this.btneng = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtdesg = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtprix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtqte = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel7.Location = new System.Drawing.Point(381, 177);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 110;
            this.metroLabel7.Text = "Montant";
            this.metroLabel7.UseStyleColors = true;
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
            this.txtmontant.Location = new System.Drawing.Point(474, 165);
            this.txtmontant.MaxLength = 32767;
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.PasswordChar = '\0';
            this.txtmontant.ReadOnly = true;
            this.txtmontant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmontant.SelectedText = "";
            this.txtmontant.SelectionLength = 0;
            this.txtmontant.SelectionStart = 0;
            this.txtmontant.ShortcutsEnabled = true;
            this.txtmontant.Size = new System.Drawing.Size(120, 30);
            this.txtmontant.TabIndex = 109;
            this.txtmontant.UseSelectable = true;
            this.txtmontant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmontant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // daterep
            // 
            this.daterep.Location = new System.Drawing.Point(211, 115);
            this.daterep.MinimumSize = new System.Drawing.Size(0, 29);
            this.daterep.Name = "daterep";
            this.daterep.Size = new System.Drawing.Size(118, 29);
            this.daterep.Style = MetroFramework.MetroColorStyle.Teal;
            this.daterep.TabIndex = 107;
            this.daterep.UseCustomBackColor = true;
            this.daterep.UseCustomForeColor = true;
            this.daterep.UseStyleColors = true;
            // 
            // cmvehicule
            // 
            this.cmvehicule.FormattingEnabled = true;
            this.cmvehicule.ItemHeight = 23;
            this.cmvehicule.Location = new System.Drawing.Point(211, 63);
            this.cmvehicule.Name = "cmvehicule";
            this.cmvehicule.Size = new System.Drawing.Size(118, 29);
            this.cmvehicule.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmvehicule.TabIndex = 106;
            this.cmvehicule.UseCustomBackColor = true;
            this.cmvehicule.UseCustomForeColor = true;
            this.cmvehicule.UseSelectable = true;
            this.cmvehicule.UseStyleColors = true;
            // 
            // btnann
            // 
            this.btnann.BackColor = System.Drawing.Color.Red;
            this.btnann.ForeColor = System.Drawing.Color.White;
            this.btnann.Location = new System.Drawing.Point(519, 224);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(76, 34);
            this.btnann.TabIndex = 105;
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
            this.btneng.Location = new System.Drawing.Point(430, 224);
            this.btneng.Name = "btneng";
            this.btneng.Size = new System.Drawing.Size(76, 34);
            this.btneng.TabIndex = 104;
            this.btneng.Text = "Enregistrer";
            this.btneng.UseCustomBackColor = true;
            this.btneng.UseCustomForeColor = true;
            this.btneng.UseSelectable = true;
            this.btneng.UseStyleColors = true;
            this.btneng.Click += new System.EventHandler(this.btneng_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel9.Location = new System.Drawing.Point(381, 73);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(63, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 103;
            this.metroLabel9.Text = "Quantité";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(76, 176);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 101;
            this.metroLabel3.Text = "Designation ";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(76, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 100;
            this.metroLabel2.Text = "Date Réparation";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(76, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 99;
            this.metroLabel1.Text = "Matricule";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtdesg
            // 
            // 
            // 
            // 
            this.txtdesg.CustomButton.Image = null;
            this.txtdesg.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtdesg.CustomButton.Name = "";
            this.txtdesg.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtdesg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdesg.CustomButton.TabIndex = 1;
            this.txtdesg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdesg.CustomButton.UseSelectable = true;
            this.txtdesg.CustomButton.Visible = false;
            this.txtdesg.Lines = new string[0];
            this.txtdesg.Location = new System.Drawing.Point(209, 166);
            this.txtdesg.MaxLength = 32767;
            this.txtdesg.Name = "txtdesg";
            this.txtdesg.PasswordChar = '\0';
            this.txtdesg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdesg.SelectedText = "";
            this.txtdesg.SelectionLength = 0;
            this.txtdesg.SelectionStart = 0;
            this.txtdesg.ShortcutsEnabled = true;
            this.txtdesg.Size = new System.Drawing.Size(120, 30);
            this.txtdesg.TabIndex = 97;
            this.txtdesg.UseSelectable = true;
            this.txtdesg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdesg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(36, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtprix
            // 
            // 
            // 
            // 
            this.txtprix.CustomButton.Image = null;
            this.txtprix.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtprix.CustomButton.Name = "";
            this.txtprix.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtprix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtprix.CustomButton.TabIndex = 1;
            this.txtprix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtprix.CustomButton.UseSelectable = true;
            this.txtprix.CustomButton.Visible = false;
            this.txtprix.Lines = new string[0];
            this.txtprix.Location = new System.Drawing.Point(474, 114);
            this.txtprix.MaxLength = 32767;
            this.txtprix.Name = "txtprix";
            this.txtprix.PasswordChar = '\0';
            this.txtprix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprix.SelectedText = "";
            this.txtprix.SelectionLength = 0;
            this.txtprix.SelectionStart = 0;
            this.txtprix.ShortcutsEnabled = true;
            this.txtprix.Size = new System.Drawing.Size(120, 30);
            this.txtprix.TabIndex = 98;
            this.txtprix.UseSelectable = true;
            this.txtprix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtprix.TextChanged += new System.EventHandler(this.txtprix_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel8.Location = new System.Drawing.Point(381, 125);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(31, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 102;
            this.metroLabel8.Text = "Prix";
            this.metroLabel8.UseStyleColors = true;
            // 
            // txtqte
            // 
            // 
            // 
            // 
            this.txtqte.CustomButton.Image = null;
            this.txtqte.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtqte.CustomButton.Name = "";
            this.txtqte.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtqte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtqte.CustomButton.TabIndex = 1;
            this.txtqte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtqte.CustomButton.UseSelectable = true;
            this.txtqte.CustomButton.Visible = false;
            this.txtqte.Lines = new string[0];
            this.txtqte.Location = new System.Drawing.Point(474, 63);
            this.txtqte.MaxLength = 32767;
            this.txtqte.Name = "txtqte";
            this.txtqte.PasswordChar = '\0';
            this.txtqte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtqte.SelectedText = "";
            this.txtqte.SelectionLength = 0;
            this.txtqte.SelectionStart = 0;
            this.txtqte.ShortcutsEnabled = true;
            this.txtqte.Size = new System.Drawing.Size(120, 30);
            this.txtqte.TabIndex = 111;
            this.txtqte.UseSelectable = true;
            this.txtqte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtqte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtqte.TextChanged += new System.EventHandler(this.txtqte_TextChanged);
            // 
            // AddReparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 283);
            this.Controls.Add(this.txtqte);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.daterep);
            this.Controls.Add(this.cmvehicule);
            this.Controls.Add(this.btnann);
            this.Controls.Add(this.btneng);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.txtdesg);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "AddReparation";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "        Ajouter réparation";
            this.Load += new System.EventHandler(this.AddReparation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtmontant;
        private MetroFramework.Controls.MetroDateTime daterep;
        private MetroFramework.Controls.MetroComboBox cmvehicule;
        private MetroFramework.Controls.MetroButton btnann;
        private MetroFramework.Controls.MetroButton btneng;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtdesg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtprix;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtqte;
    }
}