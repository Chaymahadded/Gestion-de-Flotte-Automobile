namespace WindowsFormsApp1
{
    partial class EditVignette
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
            this.datep = new MetroFramework.Controls.MetroDateTime();
            this.btnann = new MetroFramework.Controls.MetroButton();
            this.btneng = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtvehicule = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datep
            // 
            this.datep.Location = new System.Drawing.Point(365, 93);
            this.datep.MinimumSize = new System.Drawing.Size(0, 29);
            this.datep.Name = "datep";
            this.datep.Size = new System.Drawing.Size(120, 29);
            this.datep.Style = MetroFramework.MetroColorStyle.Teal;
            this.datep.TabIndex = 114;
            this.datep.UseCustomBackColor = true;
            this.datep.UseCustomForeColor = true;
            this.datep.UseStyleColors = true;
            // 
            // btnann
            // 
            this.btnann.BackColor = System.Drawing.Color.Red;
            this.btnann.ForeColor = System.Drawing.Color.White;
            this.btnann.Location = new System.Drawing.Point(409, 141);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(76, 34);
            this.btnann.TabIndex = 112;
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
            this.btneng.Location = new System.Drawing.Point(320, 141);
            this.btneng.Name = "btneng";
            this.btneng.Size = new System.Drawing.Size(76, 34);
            this.btneng.TabIndex = 111;
            this.btneng.Text = "Enregistrer";
            this.btneng.UseCustomBackColor = true;
            this.btneng.UseCustomForeColor = true;
            this.btneng.UseSelectable = true;
            this.btneng.UseStyleColors = true;
            this.btneng.Click += new System.EventHandler(this.btneng_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel7.Location = new System.Drawing.Point(305, 103);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 108;
            this.metroLabel7.Text = "Date ";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(70, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 106;
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
            this.txtvehicule.Location = new System.Drawing.Point(165, 93);
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
            this.txtvehicule.TabIndex = 115;
            this.txtvehicule.UseSelectable = true;
            this.txtvehicule.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtvehicule.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditVignette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 201);
            this.Controls.Add(this.txtvehicule);
            this.Controls.Add(this.datep);
            this.Controls.Add(this.btnann);
            this.Controls.Add(this.btneng);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "EditVignette";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "     Modifier Rappel Vignette";
            this.Load += new System.EventHandler(this.EditVignette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime datep;
        private MetroFramework.Controls.MetroButton btnann;
        private MetroFramework.Controls.MetroButton btneng;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtvehicule;
    }
}