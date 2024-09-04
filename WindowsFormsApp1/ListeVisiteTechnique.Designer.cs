namespace WindowsFormsApp1
{
    partial class ListeVisiteTechnique
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
            this.txtrecherhce = new MetroFramework.Controls.MetroTextBox();
            this.dgvvisite = new MetroFramework.Controls.MetroGrid();
            this.btnrecherche = new MetroFramework.Controls.MetroTile();
            this.btnajout = new MetroFramework.Controls.MetroTile();
            this.btnmodifier = new MetroFramework.Controls.MetroTile();
            this.btnimprime = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsupprimer = new MetroFramework.Controls.MetroTile();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vtTableAdapter = new WindowsFormsApp1.DataSetGestionVehiculeTableAdapters.VTTableAdapter();
            this.dataSetGestionVehicule = new WindowsFormsApp1.DataSetGestionVehicule();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestionVehicule)).BeginInit();
            this.SuspendLayout();
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
            this.txtrecherhce.Location = new System.Drawing.Point(480, 192);
            this.txtrecherhce.MaxLength = 32767;
            this.txtrecherhce.Name = "txtrecherhce";
            this.txtrecherhce.PasswordChar = '\0';
            this.txtrecherhce.PromptText = "Recherhcer par vehicule";
            this.txtrecherhce.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtrecherhce.SelectedText = "";
            this.txtrecherhce.SelectionLength = 0;
            this.txtrecherhce.SelectionStart = 0;
            this.txtrecherhce.ShortcutsEnabled = true;
            this.txtrecherhce.Size = new System.Drawing.Size(365, 31);
            this.txtrecherhce.TabIndex = 17;
            this.txtrecherhce.UseSelectable = true;
            this.txtrecherhce.WaterMark = "Recherhcer par vehicule";
            this.txtrecherhce.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtrecherhce.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvvisite
            // 
            this.dgvvisite.AllowUserToResizeRows = false;
            this.dgvvisite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvvisite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvvisite.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvvisite.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvisite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvvisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvvisite.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvvisite.EnableHeadersVisualStyles = false;
            this.dgvvisite.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvvisite.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvvisite.Location = new System.Drawing.Point(19, 227);
            this.dgvvisite.Name = "dgvvisite";
            this.dgvvisite.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvisite.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvvisite.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvvisite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvisite.Size = new System.Drawing.Size(1324, 424);
            this.dgvvisite.Style = MetroFramework.MetroColorStyle.Teal;
            this.dgvvisite.TabIndex = 16;
            this.dgvvisite.UseCustomBackColor = true;
            this.dgvvisite.UseCustomForeColor = true;
            this.dgvvisite.UseStyleColors = true;
            this.dgvvisite.UseWaitCursor = true;
            this.dgvvisite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvisite_CellContentClick);
            // 
            // btnrecherche
            // 
            this.btnrecherche.ActiveControl = null;
            this.btnrecherche.BackColor = System.Drawing.Color.Teal;
            this.btnrecherche.ForeColor = System.Drawing.Color.White;
            this.btnrecherche.Location = new System.Drawing.Point(851, 192);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(33, 29);
            this.btnrecherche.TabIndex = 18;
            this.btnrecherche.TileImage = global::WindowsFormsApp1.Properties.Resources._19;
            this.btnrecherche.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrecherche.UseCustomBackColor = true;
            this.btnrecherche.UseCustomForeColor = true;
            this.btnrecherche.UseSelectable = true;
            this.btnrecherche.UseStyleColors = true;
            this.btnrecherche.UseTileImage = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // btnajout
            // 
            this.btnajout.ActiveControl = null;
            this.btnajout.BackColor = System.Drawing.Color.Teal;
            this.btnajout.ForeColor = System.Drawing.Color.White;
            this.btnajout.Location = new System.Drawing.Point(1061, 35);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(88, 74);
            this.btnajout.TabIndex = 15;
            this.btnajout.Text = "Ajouter";
            this.btnajout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnajout.TileImage = global::WindowsFormsApp1.Properties.Resources._6;
            this.btnajout.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnajout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnajout.UseCustomBackColor = true;
            this.btnajout.UseCustomForeColor = true;
            this.btnajout.UseSelectable = true;
            this.btnajout.UseStyleColors = true;
            this.btnajout.UseTileImage = true;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.ActiveControl = null;
            this.btnmodifier.BackColor = System.Drawing.Color.Teal;
            this.btnmodifier.Enabled = false;
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(1155, 35);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(88, 74);
            this.btnmodifier.TabIndex = 14;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodifier.TileImage = global::WindowsFormsApp1.Properties.Resources._15;
            this.btnmodifier.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodifier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnmodifier.UseCustomBackColor = true;
            this.btnmodifier.UseCustomForeColor = true;
            this.btnmodifier.UseSelectable = true;
            this.btnmodifier.UseStyleColors = true;
            this.btnmodifier.UseTileImage = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnimprime
            // 
            this.btnimprime.ActiveControl = null;
            this.btnimprime.BackColor = System.Drawing.Color.Teal;
            this.btnimprime.ForeColor = System.Drawing.Color.White;
            this.btnimprime.Location = new System.Drawing.Point(967, 35);
            this.btnimprime.Name = "btnimprime";
            this.btnimprime.Size = new System.Drawing.Size(88, 74);
            this.btnimprime.TabIndex = 12;
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
            this.btnimprime.Click += new System.EventHandler(this.btnimprime_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.ActiveControl = null;
            this.btnsupprimer.BackColor = System.Drawing.Color.Teal;
            this.btnsupprimer.Enabled = false;
            this.btnsupprimer.ForeColor = System.Drawing.Color.Snow;
            this.btnsupprimer.Location = new System.Drawing.Point(1249, 35);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(88, 74);
            this.btnsupprimer.TabIndex = 19;
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
            // reportViewer
            // 
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "ReportViewer";
            this.reportViewer.Size = new System.Drawing.Size(396, 246);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Load += new System.EventHandler(this.btnimprime_Click);
            // 
            // vtTableAdapter
            // 
            this.vtTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetGestionVehicule
            // 
            this.dataSetGestionVehicule.DataSetName = "DataSetGestionVehicule";
            this.dataSetGestionVehicule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListeVisiteTechnique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 725);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.txtrecherhce);
            this.Controls.Add(this.dgvvisite);
            this.Controls.Add(this.btnajout);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnimprime);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "ListeVisiteTechnique";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "      Suivi des visites technique ";
            this.Load += new System.EventHandler(this.ListeVisiteTechnique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestionVehicule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnrecherche;
        private MetroFramework.Controls.MetroTextBox txtrecherhce;
        private MetroFramework.Controls.MetroGrid dgvvisite;
        private MetroFramework.Controls.MetroTile btnajout;
        private MetroFramework.Controls.MetroTile btnmodifier;
        private MetroFramework.Controls.MetroTile btnimprime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnsupprimer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private DataSetGestionVehiculeTableAdapters.VTTableAdapter vtTableAdapter;
        private DataSetGestionVehicule dataSetGestionVehicule;
    }
}