using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    partial class ListReparation
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
            this.dgvrep = new MetroFramework.Controls.MetroGrid();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnrecherche = new MetroFramework.Controls.MetroTile();
            this.btnajout = new MetroFramework.Controls.MetroTile();
            this.btnmodifier = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsupprimer = new MetroFramework.Controls.MetroTile();
            this.btnimprime = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.txtrecherhce.Location = new System.Drawing.Point(473, 187);
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
            this.txtrecherhce.TabIndex = 38;
            this.txtrecherhce.UseSelectable = true;
            this.txtrecherhce.WaterMark = "Recherhcer par vehicule";
            this.txtrecherhce.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtrecherhce.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvrep
            // 
            this.dgvrep.AllowUserToResizeRows = false;
            this.dgvrep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvrep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvrep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvrep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvrep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrep.EnableHeadersVisualStyles = false;
            this.dgvrep.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvrep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvrep.Location = new System.Drawing.Point(24, 222);
            this.dgvrep.Name = "dgvrep";
            this.dgvrep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrep.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvrep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvrep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrep.Size = new System.Drawing.Size(1319, 441);
            this.dgvrep.Style = MetroFramework.MetroColorStyle.Teal;
            this.dgvrep.TabIndex = 37;
            this.dgvrep.UseCustomBackColor = true;
            this.dgvrep.UseCustomForeColor = true;
            this.dgvrep.UseStyleColors = true;
            this.dgvrep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrep_CellContentClick);
            // 
            // reportViewer
            // 
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "ReportViewer";
            this.reportViewer.Size = new System.Drawing.Size(396, 246);
            this.reportViewer.TabIndex = 0;
            // 
            // btnrecherche
            // 
            this.btnrecherche.ActiveControl = null;
            this.btnrecherche.BackColor = System.Drawing.Color.Teal;
            this.btnrecherche.ForeColor = System.Drawing.Color.White;
            this.btnrecherche.Location = new System.Drawing.Point(844, 187);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(33, 29);
            this.btnrecherche.TabIndex = 39;
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
            this.btnajout.Location = new System.Drawing.Point(1058, 33);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(88, 74);
            this.btnajout.TabIndex = 36;
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
            this.btnmodifier.Location = new System.Drawing.Point(1152, 33);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(88, 74);
            this.btnmodifier.TabIndex = 35;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20;
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.ActiveControl = null;
            this.btnsupprimer.BackColor = System.Drawing.Color.Teal;
            this.btnsupprimer.Enabled = false;
            this.btnsupprimer.ForeColor = System.Drawing.Color.Snow;
            this.btnsupprimer.Location = new System.Drawing.Point(1246, 33);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(88, 74);
            this.btnsupprimer.TabIndex = 40;
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
            this.btnimprime.Location = new System.Drawing.Point(964, 33);
            this.btnimprime.Name = "btnimprime";
            this.btnimprime.Size = new System.Drawing.Size(88, 74);
            this.btnimprime.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnimprime.TabIndex = 41;
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
            this.btnimprime.Click += new System.EventHandler(this.btnimprime_Click_1);
            // 
            // ListReparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 725);
            this.Controls.Add(this.btnimprime);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.txtrecherhce);
            this.Controls.Add(this.dgvrep);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.btnajout);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "ListReparation";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "      Liste des réparation ";
            this.Load += new System.EventHandler(this.ListReparation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtrecherhce;
        private MetroFramework.Controls.MetroGrid dgvrep;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private MetroFramework.Controls.MetroTile btnrecherche;
        private MetroFramework.Controls.MetroTile btnajout;
        private MetroFramework.Controls.MetroTile btnmodifier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnsupprimer;
        private MetroFramework.Controls.MetroTile btnimprime;

        public ReportViewer Rpv { get => reportViewer; set => reportViewer = value; }
    }
}