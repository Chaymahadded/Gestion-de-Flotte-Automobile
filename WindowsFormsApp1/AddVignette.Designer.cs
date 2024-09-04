namespace WindowsFormsApp1
{
    partial class AddVignette
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
            this.cmvehicule = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datep
            // 
            this.datep.Location = new System.Drawing.Point(373, 96);
            this.datep.MinimumSize = new System.Drawing.Size(0, 29);
            this.datep.Name = "datep";
            this.datep.Size = new System.Drawing.Size(120, 29);
            this.datep.Style = MetroFramework.MetroColorStyle.Teal;
            this.datep.TabIndex = 103;
            this.datep.UseCustomBackColor = true;
            this.datep.UseCustomForeColor = true;
            this.datep.UseStyleColors = true;
            // 
            // btnann
            // 
            this.btnann.BackColor = System.Drawing.Color.Red;
            this.btnann.ForeColor = System.Drawing.Color.White;
            this.btnann.Location = new System.Drawing.Point(418, 148);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(76, 34);
            this.btnann.TabIndex = 101;
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
            this.btneng.Location = new System.Drawing.Point(329, 148);
            this.btneng.Name = "btneng";
            this.btneng.Size = new System.Drawing.Size(76, 34);
            this.btneng.TabIndex = 100;
            this.btneng.Text = "Enregistrer";
            this.btneng.UseCustomBackColor = true;
            this.btneng.UseCustomForeColor = true;
            this.btneng.UseSelectable = true;
            this.btneng.UseStyleColors = true;
            this.btneng.Click += new System.EventHandler(this.btneng_Click);
            // 
            // cmvehicule
            // 
            this.cmvehicule.FormattingEnabled = true;
            this.cmvehicule.ItemHeight = 23;
            this.cmvehicule.Location = new System.Drawing.Point(173, 96);
            this.cmvehicule.Name = "cmvehicule";
            this.cmvehicule.Size = new System.Drawing.Size(118, 29);
            this.cmvehicule.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmvehicule.TabIndex = 99;
            this.cmvehicule.UseCustomBackColor = true;
            this.cmvehicule.UseCustomForeColor = true;
            this.cmvehicule.UseSelectable = true;
            this.cmvehicule.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel7.Location = new System.Drawing.Point(313, 106);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 97;
            this.metroLabel7.Text = "Date";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(78, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 95;
            this.metroLabel1.Text = "Véhicule";
            this.metroLabel1.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddVignette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 210);
            this.Controls.Add(this.datep);
            this.Controls.Add(this.btnann);
            this.Controls.Add(this.btneng);
            this.Controls.Add(this.cmvehicule);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "AddVignette";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "       Ajouter Rappel Vignette";
            this.Load += new System.EventHandler(this.AddVignette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime datep;
        private MetroFramework.Controls.MetroButton btnann;
        private MetroFramework.Controls.MetroButton btneng;
        private MetroFramework.Controls.MetroComboBox cmvehicule;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}