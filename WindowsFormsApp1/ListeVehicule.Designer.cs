namespace WindowsFormsApp1
{
    partial class ListeVehicule
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
            this.dgvvehicule = new MetroFramework.Controls.MetroGrid();
            this.txtrecherhce = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtagemoyen = new MetroFramework.Controls.MetroTextBox();
            this.btnrecherche = new MetroFramework.Controls.MetroTile();
            this.btnajout = new MetroFramework.Controls.MetroTile();
            this.btnmodifier = new MetroFramework.Controls.MetroTile();
            this.btnsupprimer = new MetroFramework.Controls.MetroTile();
            this.btnimprime = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnverif = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvvehicule
            // 
            this.dgvvehicule.AllowUserToResizeRows = false;
            this.dgvvehicule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvvehicule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvvehicule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvvehicule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvehicule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvvehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvvehicule.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvvehicule.EnableHeadersVisualStyles = false;
            this.dgvvehicule.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvvehicule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvvehicule.Location = new System.Drawing.Point(23, 193);
            this.dgvvehicule.Name = "dgvvehicule";
            this.dgvvehicule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvehicule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvvehicule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvvehicule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvehicule.Size = new System.Drawing.Size(1316, 455);
            this.dgvvehicule.Style = MetroFramework.MetroColorStyle.Teal;
            this.dgvvehicule.TabIndex = 6;
            this.dgvvehicule.UseCustomBackColor = true;
            this.dgvvehicule.UseCustomForeColor = true;
            this.dgvvehicule.UseStyleColors = true;
            this.dgvvehicule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvehicule_CellContentClick);
            this.dgvvehicule.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvvehicule_CellMouseDoubleClick);
            // 
            // txtrecherhce
            // 
            // 
            // 
            // 
            this.txtrecherhce.CustomButton.Image = null;
            this.txtrecherhce.CustomButton.Location = new System.Drawing.Point(335, 1);
            this.txtrecherhce.CustomButton.Name = "";
            this.txtrecherhce.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtrecherhce.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtrecherhce.CustomButton.TabIndex = 1;
            this.txtrecherhce.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtrecherhce.CustomButton.UseSelectable = true;
            this.txtrecherhce.CustomButton.Visible = false;
            this.txtrecherhce.Lines = new string[0];
            this.txtrecherhce.Location = new System.Drawing.Point(411, 156);
            this.txtrecherhce.MaxLength = 32767;
            this.txtrecherhce.Name = "txtrecherhce";
            this.txtrecherhce.PasswordChar = '\0';
            this.txtrecherhce.PromptText = "Recherhcer par matricule";
            this.txtrecherhce.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtrecherhce.SelectedText = "";
            this.txtrecherhce.SelectionLength = 0;
            this.txtrecherhce.SelectionStart = 0;
            this.txtrecherhce.ShortcutsEnabled = true;
            this.txtrecherhce.Size = new System.Drawing.Size(365, 31);
            this.txtrecherhce.TabIndex = 7;
            this.txtrecherhce.UseSelectable = true;
            this.txtrecherhce.WaterMark = "Recherhcer par matricule";
            this.txtrecherhce.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtrecherhce.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(1042, 664);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Age Moyen";
            // 
            // txtagemoyen
            // 
            // 
            // 
            // 
            this.txtagemoyen.CustomButton.Image = null;
            this.txtagemoyen.CustomButton.Location = new System.Drawing.Point(55, 2);
            this.txtagemoyen.CustomButton.Name = "";
            this.txtagemoyen.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtagemoyen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtagemoyen.CustomButton.TabIndex = 1;
            this.txtagemoyen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtagemoyen.CustomButton.UseSelectable = true;
            this.txtagemoyen.CustomButton.Visible = false;
            this.txtagemoyen.Lines = new string[0];
            this.txtagemoyen.Location = new System.Drawing.Point(1138, 660);
            this.txtagemoyen.MaxLength = 32767;
            this.txtagemoyen.Name = "txtagemoyen";
            this.txtagemoyen.PasswordChar = '\0';
            this.txtagemoyen.ReadOnly = true;
            this.txtagemoyen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtagemoyen.SelectedText = "";
            this.txtagemoyen.SelectionLength = 0;
            this.txtagemoyen.SelectionStart = 0;
            this.txtagemoyen.ShortcutsEnabled = true;
            this.txtagemoyen.Size = new System.Drawing.Size(75, 22);
            this.txtagemoyen.TabIndex = 10;
            this.txtagemoyen.UseSelectable = true;
            this.txtagemoyen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtagemoyen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnrecherche
            // 
            this.btnrecherche.ActiveControl = null;
            this.btnrecherche.BackColor = System.Drawing.Color.Teal;
            this.btnrecherche.ForeColor = System.Drawing.Color.Snow;
            this.btnrecherche.Location = new System.Drawing.Point(782, 156);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(33, 29);
            this.btnrecherche.TabIndex = 8;
            this.btnrecherche.TileImage = global::WindowsFormsApp1.Properties.Resources._19;
            this.btnrecherche.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrecherche.UseCustomBackColor = true;
            this.btnrecherche.UseCustomForeColor = true;
            this.btnrecherche.UseSelectable = true;
            this.btnrecherche.UseTileImage = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // btnajout
            // 
            this.btnajout.ActiveControl = null;
            this.btnajout.BackColor = System.Drawing.Color.Teal;
            this.btnajout.ForeColor = System.Drawing.Color.Snow;
            this.btnajout.Location = new System.Drawing.Point(1054, 31);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(88, 74);
            this.btnajout.TabIndex = 5;
            this.btnajout.Text = "Ajouter";
            this.btnajout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnajout.TileImage = global::WindowsFormsApp1.Properties.Resources._6;
            this.btnajout.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnajout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnajout.UseCustomBackColor = true;
            this.btnajout.UseCustomForeColor = true;
            this.btnajout.UseSelectable = true;
            this.btnajout.UseTileImage = true;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.ActiveControl = null;
            this.btnmodifier.BackColor = System.Drawing.Color.Teal;
            this.btnmodifier.Enabled = false;
            this.btnmodifier.ForeColor = System.Drawing.Color.Snow;
            this.btnmodifier.Location = new System.Drawing.Point(1148, 31);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(88, 74);
            this.btnmodifier.TabIndex = 4;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodifier.TileImage = global::WindowsFormsApp1.Properties.Resources._15;
            this.btnmodifier.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodifier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnmodifier.UseCustomBackColor = true;
            this.btnmodifier.UseCustomForeColor = true;
            this.btnmodifier.UseSelectable = true;
            this.btnmodifier.UseTileImage = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.ActiveControl = null;
            this.btnsupprimer.BackColor = System.Drawing.Color.Teal;
            this.btnsupprimer.Enabled = false;
            this.btnsupprimer.ForeColor = System.Drawing.Color.Snow;
            this.btnsupprimer.Location = new System.Drawing.Point(1242, 31);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(88, 74);
            this.btnsupprimer.TabIndex = 3;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsupprimer.TileImage = global::WindowsFormsApp1.Properties.Resources._13;
            this.btnsupprimer.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsupprimer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnsupprimer.UseCustomBackColor = true;
            this.btnsupprimer.UseCustomForeColor = true;
            this.btnsupprimer.UseSelectable = true;
            this.btnsupprimer.UseTileImage = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnimprime
            // 
            this.btnimprime.ActiveControl = null;
            this.btnimprime.BackColor = System.Drawing.Color.Teal;
            this.btnimprime.ForeColor = System.Drawing.Color.White;
            this.btnimprime.Location = new System.Drawing.Point(960, 31);
            this.btnimprime.Name = "btnimprime";
            this.btnimprime.Size = new System.Drawing.Size(88, 74);
            this.btnimprime.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnimprime.TabIndex = 2;
            this.btnimprime.Text = "Imprimer";
            this.btnimprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnimprime.TileImage = global::WindowsFormsApp1.Properties.Resources._35;
            this.btnimprime.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnimprime.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnimprime.UseCustomBackColor = true;
            this.btnimprime.UseCustomForeColor = true;
            this.btnimprime.UseSelectable = true;
            this.btnimprime.UseStyleColors = true;
            this.btnimprime.UseTileImage = true;
            this.btnimprime.UseWaitCursor = true;
            this.btnimprime.Click += new System.EventHandler(this.btnimprime_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(23, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnverif
            // 
            this.btnverif.ActiveControl = null;
            this.btnverif.BackColor = System.Drawing.Color.Teal;
            this.btnverif.Enabled = false;
            this.btnverif.ForeColor = System.Drawing.Color.White;
            this.btnverif.Location = new System.Drawing.Point(848, 31);
            this.btnverif.Name = "btnverif";
            this.btnverif.Size = new System.Drawing.Size(106, 74);
            this.btnverif.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnverif.TabIndex = 11;
            this.btnverif.Text = "Vérifier index";
            this.btnverif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnverif.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnverif.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnverif.UseCustomBackColor = true;
            this.btnverif.UseCustomForeColor = true;
            this.btnverif.UseSelectable = true;
            this.btnverif.UseStyleColors = true;
            this.btnverif.UseTileImage = true;
            this.btnverif.UseWaitCursor = true;
            this.btnverif.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // ListeVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 725);
            this.Controls.Add(this.btnverif);
            this.Controls.Add(this.txtagemoyen);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.txtrecherhce);
            this.Controls.Add(this.dgvvehicule);
            this.Controls.Add(this.btnajout);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnimprime);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "ListeVehicule";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "      Liste des véhicules";
            this.Load += new System.EventHandler(this.ListeVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnimprime;
        private MetroFramework.Controls.MetroTile btnsupprimer;
        private MetroFramework.Controls.MetroTile btnmodifier;
        private MetroFramework.Controls.MetroTile btnajout;
        private MetroFramework.Controls.MetroGrid dgvvehicule;
        private MetroFramework.Controls.MetroTextBox txtrecherhce;
        private MetroFramework.Controls.MetroTile btnrecherche;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtagemoyen;
        private MetroFramework.Controls.MetroTile btnverif;
    }
}