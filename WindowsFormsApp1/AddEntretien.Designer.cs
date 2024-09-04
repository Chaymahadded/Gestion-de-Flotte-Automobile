namespace WindowsFormsApp1
{
    partial class AddEntretien
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
            this.btnann = new MetroFramework.Controls.MetroButton();
            this.btneng = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtindex = new MetroFramework.Controls.MetroTextBox();
            this.txttype = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmvehicule = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnann
            // 
            this.btnann.BackColor = System.Drawing.Color.Red;
            this.btnann.ForeColor = System.Drawing.Color.White;
            this.btnann.Location = new System.Drawing.Point(592, 164);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(76, 34);
            this.btnann.TabIndex = 79;
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
            this.btneng.Location = new System.Drawing.Point(503, 164);
            this.btneng.Name = "btneng";
            this.btneng.Size = new System.Drawing.Size(76, 34);
            this.btneng.TabIndex = 78;
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
            this.metroLabel9.Location = new System.Drawing.Point(370, 74);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(42, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 71;
            this.metroLabel9.Text = "Index";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(61, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 65;
            this.metroLabel3.Text = "Type Entretien";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(61, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 63;
            this.metroLabel1.Text = "Matricule";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtindex
            // 
            // 
            // 
            // 
            this.txtindex.CustomButton.Image = null;
            this.txtindex.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtindex.CustomButton.Name = "";
            this.txtindex.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtindex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtindex.CustomButton.TabIndex = 1;
            this.txtindex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtindex.CustomButton.UseSelectable = true;
            this.txtindex.CustomButton.Visible = false;
            this.txtindex.Lines = new string[0];
            this.txtindex.Location = new System.Drawing.Point(548, 62);
            this.txtindex.MaxLength = 32767;
            this.txtindex.Name = "txtindex";
            this.txtindex.PasswordChar = '\0';
            this.txtindex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtindex.SelectedText = "";
            this.txtindex.SelectionLength = 0;
            this.txtindex.SelectionStart = 0;
            this.txtindex.ShortcutsEnabled = true;
            this.txtindex.Size = new System.Drawing.Size(120, 30);
            this.txtindex.TabIndex = 62;
            this.txtindex.UseSelectable = true;
            this.txtindex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtindex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txttype
            // 
            // 
            // 
            // 
            this.txttype.CustomButton.Image = null;
            this.txttype.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txttype.CustomButton.Name = "";
            this.txttype.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txttype.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttype.CustomButton.TabIndex = 1;
            this.txttype.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttype.CustomButton.UseSelectable = true;
            this.txttype.CustomButton.Visible = false;
            this.txttype.Lines = new string[0];
            this.txttype.Location = new System.Drawing.Point(194, 114);
            this.txttype.MaxLength = 32767;
            this.txttype.Name = "txttype";
            this.txttype.PasswordChar = '\0';
            this.txttype.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttype.SelectedText = "";
            this.txttype.SelectionLength = 0;
            this.txttype.SelectionStart = 0;
            this.txttype.ShortcutsEnabled = true;
            this.txttype.Size = new System.Drawing.Size(120, 30);
            this.txttype.TabIndex = 57;
            this.txttype.UseSelectable = true;
            this.txttype.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttype.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(21, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmvehicule
            // 
            this.cmvehicule.FormattingEnabled = true;
            this.cmvehicule.ItemHeight = 23;
            this.cmvehicule.Location = new System.Drawing.Point(196, 63);
            this.cmvehicule.Name = "cmvehicule";
            this.cmvehicule.Size = new System.Drawing.Size(118, 29);
            this.cmvehicule.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmvehicule.TabIndex = 89;
            this.cmvehicule.UseCustomBackColor = true;
            this.cmvehicule.UseCustomForeColor = true;
            this.cmvehicule.UseSelectable = true;
            this.cmvehicule.UseStyleColors = true;
            // 
            // AddEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 225);
            this.Controls.Add(this.cmvehicule);
            this.Controls.Add(this.btnann);
            this.Controls.Add(this.btneng);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtindex);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "AddEntretien";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "     Ajouter Entretien";
            this.Load += new System.EventHandler(this.AddEntretien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnann;
        private MetroFramework.Controls.MetroButton btneng;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtindex;
        private MetroFramework.Controls.MetroTextBox txttype;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox cmvehicule;
    }
}