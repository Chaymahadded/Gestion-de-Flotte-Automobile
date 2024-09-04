namespace WindowsFormsApp1
{
    partial class AddAssurance
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
            this.datefin = new MetroFramework.Controls.MetroDateTime();
            this.btnann = new MetroFramework.Controls.MetroButton();
            this.btneng = new MetroFramework.Controls.MetroButton();
            this.cmvehicule = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datefin
            // 
            this.datefin.Location = new System.Drawing.Point(341, 75);
            this.datefin.MinimumSize = new System.Drawing.Size(0, 29);
            this.datefin.Name = "datefin";
            this.datefin.Size = new System.Drawing.Size(120, 29);
            this.datefin.Style = MetroFramework.MetroColorStyle.Teal;
            this.datefin.TabIndex = 92;
            this.datefin.UseCustomBackColor = true;
            this.datefin.UseCustomForeColor = true;
            this.datefin.UseStyleColors = true;
            // 
            // btnann
            // 
            this.btnann.BackColor = System.Drawing.Color.Red;
            this.btnann.ForeColor = System.Drawing.Color.White;
            this.btnann.Location = new System.Drawing.Point(382, 126);
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
            this.btneng.Location = new System.Drawing.Point(293, 126);
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
            // cmvehicule
            // 
            this.cmvehicule.FormattingEnabled = true;
            this.cmvehicule.ItemHeight = 23;
            this.cmvehicule.Location = new System.Drawing.Point(153, 75);
            this.cmvehicule.Name = "cmvehicule";
            this.cmvehicule.Size = new System.Drawing.Size(118, 29);
            this.cmvehicule.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmvehicule.TabIndex = 88;
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
            this.metroLabel7.Location = new System.Drawing.Point(293, 85);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 86;
            this.metroLabel7.Text = "Date ";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(58, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 84;
            this.metroLabel1.Text = "Véhicule";
            this.metroLabel1.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(13, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddAssurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 192);
            this.Controls.Add(this.datefin);
            this.Controls.Add(this.btnann);
            this.Controls.Add(this.btneng);
            this.Controls.Add(this.cmvehicule);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "AddAssurance";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "     Ajouter Rappel Assurance";
            this.Load += new System.EventHandler(this.AddAssurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime datefin;
        private MetroFramework.Controls.MetroButton btnann;
        private MetroFramework.Controls.MetroButton btneng;
        private MetroFramework.Controls.MetroComboBox cmvehicule;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}