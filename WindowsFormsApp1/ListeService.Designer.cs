namespace WindowsFormsApp1
{
    partial class ListeService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsup = new MetroFramework.Controls.MetroButton();
            this.btneng = new MetroFramework.Controls.MetroButton();
            this.txtcode = new MetroFramework.Controls.MetroTextBox();
            this.txtnom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtrecherche = new MetroFramework.Controls.MetroTextBox();
            this.dgvservice = new MetroFramework.Controls.MetroGrid();
            this.btnrecherche = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvservice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsup
            // 
            this.btnsup.BackColor = System.Drawing.Color.Red;
            this.btnsup.Enabled = false;
            this.btnsup.ForeColor = System.Drawing.Color.White;
            this.btnsup.Location = new System.Drawing.Point(270, 191);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(76, 34);
            this.btnsup.TabIndex = 50;
            this.btnsup.Text = "Supprimer";
            this.btnsup.UseCustomBackColor = true;
            this.btnsup.UseCustomForeColor = true;
            this.btnsup.UseSelectable = true;
            this.btnsup.UseStyleColors = true;
            this.btnsup.Click += new System.EventHandler(this.btnsup_Click);
            // 
            // btneng
            // 
            this.btneng.BackColor = System.Drawing.Color.Green;
            this.btneng.ForeColor = System.Drawing.Color.White;
            this.btneng.Location = new System.Drawing.Point(181, 191);
            this.btneng.Name = "btneng";
            this.btneng.Size = new System.Drawing.Size(76, 34);
            this.btneng.TabIndex = 49;
            this.btneng.Text = "Enregistrer";
            this.btneng.UseCustomBackColor = true;
            this.btneng.UseCustomForeColor = true;
            this.btneng.UseSelectable = true;
            this.btneng.UseStyleColors = true;
            this.btneng.Click += new System.EventHandler(this.btneng_Click);
            // 
            // txtcode
            // 
            // 
            // 
            // 
            this.txtcode.CustomButton.Image = null;
            this.txtcode.CustomButton.Location = new System.Drawing.Point(143, 2);
            this.txtcode.CustomButton.Name = "";
            this.txtcode.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcode.CustomButton.TabIndex = 1;
            this.txtcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcode.CustomButton.UseSelectable = true;
            this.txtcode.CustomButton.Visible = false;
            this.txtcode.Lines = new string[0];
            this.txtcode.Location = new System.Drawing.Point(181, 80);
            this.txtcode.MaxLength = 32767;
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '\0';
            this.txtcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcode.SelectedText = "";
            this.txtcode.SelectionLength = 0;
            this.txtcode.SelectionStart = 0;
            this.txtcode.ShortcutsEnabled = true;
            this.txtcode.Size = new System.Drawing.Size(165, 24);
            this.txtcode.TabIndex = 48;
            this.txtcode.UseSelectable = true;
            this.txtcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtnom
            // 
            // 
            // 
            // 
            this.txtnom.CustomButton.Image = null;
            this.txtnom.CustomButton.Location = new System.Drawing.Point(143, 2);
            this.txtnom.CustomButton.Name = "";
            this.txtnom.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtnom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnom.CustomButton.TabIndex = 1;
            this.txtnom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnom.CustomButton.UseSelectable = true;
            this.txtnom.CustomButton.Visible = false;
            this.txtnom.Lines = new string[0];
            this.txtnom.Location = new System.Drawing.Point(181, 136);
            this.txtnom.MaxLength = 32767;
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnom.SelectedText = "";
            this.txtnom.SelectionLength = 0;
            this.txtnom.SelectionStart = 0;
            this.txtnom.ShortcutsEnabled = true;
            this.txtnom.Size = new System.Drawing.Size(165, 24);
            this.txtnom.TabIndex = 47;
            this.txtnom.UseSelectable = true;
            this.txtnom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(62, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Nom Service";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(62, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Code Service";
            // 
            // txtrecherche
            // 
            // 
            // 
            // 
            this.txtrecherche.CustomButton.Image = null;
            this.txtrecherche.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtrecherche.CustomButton.Name = "";
            this.txtrecherche.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtrecherche.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtrecherche.CustomButton.TabIndex = 1;
            this.txtrecherche.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtrecherche.CustomButton.UseSelectable = true;
            this.txtrecherche.CustomButton.Visible = false;
            this.txtrecherche.Lines = new string[0];
            this.txtrecherche.Location = new System.Drawing.Point(399, 80);
            this.txtrecherche.MaxLength = 32767;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.PasswordChar = '\0';
            this.txtrecherche.PromptText = "Recherhcer";
            this.txtrecherche.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtrecherche.SelectedText = "";
            this.txtrecherche.SelectionLength = 0;
            this.txtrecherche.SelectionStart = 0;
            this.txtrecherche.ShortcutsEnabled = true;
            this.txtrecherche.Size = new System.Drawing.Size(165, 31);
            this.txtrecherche.TabIndex = 43;
            this.txtrecherche.UseSelectable = true;
            this.txtrecherche.WaterMark = "Recherhcer";
            this.txtrecherche.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtrecherche.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvservice
            // 
            this.dgvservice.AllowUserToResizeRows = false;
            this.dgvservice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvservice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvservice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvservice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvservice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvservice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvservice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvservice.EnableHeadersVisualStyles = false;
            this.dgvservice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvservice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvservice.Location = new System.Drawing.Point(399, 136);
            this.dgvservice.Name = "dgvservice";
            this.dgvservice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvservice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvservice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvservice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvservice.Size = new System.Drawing.Size(243, 202);
            this.dgvservice.Style = MetroFramework.MetroColorStyle.Teal;
            this.dgvservice.TabIndex = 42;
            this.dgvservice.UseCustomBackColor = true;
            this.dgvservice.UseCustomForeColor = true;
            this.dgvservice.UseStyleColors = true;
            this.dgvservice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvservice_CellContentClick);
            // 
            // btnrecherche
            // 
            this.btnrecherche.ActiveControl = null;
            this.btnrecherche.BackColor = System.Drawing.Color.Teal;
            this.btnrecherche.Location = new System.Drawing.Point(570, 80);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(33, 29);
            this.btnrecherche.TabIndex = 51;
            this.btnrecherche.TileImage = global::WindowsFormsApp1.Properties.Resources._19;
            this.btnrecherche.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrecherche.UseCustomBackColor = true;
            this.btnrecherche.UseSelectable = true;
            this.btnrecherche.UseTileImage = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.BackColor = System.Drawing.Color.Teal;
            this.metroTile5.Location = new System.Drawing.Point(609, 80);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(33, 29);
            this.metroTile5.TabIndex = 44;
            this.metroTile5.TileImage = global::WindowsFormsApp1.Properties.Resources._16;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(20, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 356);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.btnsup);
            this.Controls.Add(this.btneng);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.dgvservice);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "ListeService";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "     Liste des services";
            this.Load += new System.EventHandler(this.ListeService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvservice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnrecherche;
        private MetroFramework.Controls.MetroButton btnsup;
        private MetroFramework.Controls.MetroButton btneng;
        private MetroFramework.Controls.MetroTextBox txtcode;
        private MetroFramework.Controls.MetroTextBox txtnom;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtrecherche;
        private MetroFramework.Controls.MetroGrid dgvservice;
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}