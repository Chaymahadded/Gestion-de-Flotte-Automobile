namespace WindowsFormsApp1
{
    partial class ListeCategorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtrecherche = new MetroFramework.Controls.MetroTextBox();
            this.dgvcat = new MetroFramework.Controls.MetroGrid();
            this.btnsup = new MetroFramework.Controls.MetroButton();
            this.btneng = new MetroFramework.Controls.MetroButton();
            this.txtcode = new MetroFramework.Controls.MetroTextBox();
            this.txtnom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnrecherche = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.txtrecherche.Location = new System.Drawing.Point(395, 82);
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
            this.txtrecherche.TabIndex = 23;
            this.txtrecherche.UseSelectable = true;
            this.txtrecherche.WaterMark = "Recherhcer";
            this.txtrecherche.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtrecherche.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvcat
            // 
            this.dgvcat.AllowUserToResizeRows = false;
            this.dgvcat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvcat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvcat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcat.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvcat.EnableHeadersVisualStyles = false;
            this.dgvcat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvcat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvcat.Location = new System.Drawing.Point(395, 138);
            this.dgvcat.Name = "dgvcat";
            this.dgvcat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcat.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvcat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvcat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcat.Size = new System.Drawing.Size(243, 202);
            this.dgvcat.Style = MetroFramework.MetroColorStyle.Teal;
            this.dgvcat.TabIndex = 22;
            this.dgvcat.UseCustomBackColor = true;
            this.dgvcat.UseCustomForeColor = true;
            this.dgvcat.UseStyleColors = true;
            this.dgvcat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcat_CellContentClick);
            // 
            // btnsup
            // 
            this.btnsup.BackColor = System.Drawing.Color.Red;
            this.btnsup.Enabled = false;
            this.btnsup.ForeColor = System.Drawing.Color.White;
            this.btnsup.Location = new System.Drawing.Point(266, 193);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(76, 34);
            this.btnsup.TabIndex = 39;
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
            this.btneng.Location = new System.Drawing.Point(177, 193);
            this.btneng.Name = "btneng";
            this.btneng.Size = new System.Drawing.Size(76, 34);
            this.btneng.TabIndex = 38;
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
            this.txtcode.Location = new System.Drawing.Point(177, 82);
            this.txtcode.MaxLength = 32767;
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '\0';
            this.txtcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcode.SelectedText = "";
            this.txtcode.SelectionLength = 0;
            this.txtcode.SelectionStart = 0;
            this.txtcode.ShortcutsEnabled = true;
            this.txtcode.Size = new System.Drawing.Size(165, 24);
            this.txtcode.TabIndex = 37;
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
            this.txtnom.Location = new System.Drawing.Point(177, 138);
            this.txtnom.MaxLength = 32767;
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnom.SelectedText = "";
            this.txtnom.SelectionLength = 0;
            this.txtnom.SelectionStart = 0;
            this.txtnom.ShortcutsEnabled = true;
            this.txtnom.Size = new System.Drawing.Size(165, 24);
            this.txtnom.TabIndex = 36;
            this.txtnom.UseSelectable = true;
            this.txtnom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(58, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Nom Catégorie";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(58, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Code Catégorie";
            // 
            // btnrecherche
            // 
            this.btnrecherche.ActiveControl = null;
            this.btnrecherche.BackColor = System.Drawing.Color.Teal;
            this.btnrecherche.Location = new System.Drawing.Point(566, 82);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(33, 29);
            this.btnrecherche.TabIndex = 40;
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
            this.metroTile5.Location = new System.Drawing.Point(605, 82);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(33, 29);
            this.metroTile5.TabIndex = 24;
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
            this.pictureBox1.Location = new System.Drawing.Point(16, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListeCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 368);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.btnsup);
            this.Controls.Add(this.btneng);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.dgvcat);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "ListeCategorie";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "     Liste des catégories";
            this.Load += new System.EventHandler(this.ListeCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtrecherche;
        private MetroFramework.Controls.MetroGrid dgvcat;
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnsup;
        private MetroFramework.Controls.MetroButton btneng;
        private MetroFramework.Controls.MetroTextBox txtcode;
        private MetroFramework.Controls.MetroTextBox txtnom;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btnrecherche;
    }
}