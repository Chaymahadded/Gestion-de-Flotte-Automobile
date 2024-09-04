namespace WindowsFormsApp1
{
    partial class ListeEntretien
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
            this.dgventretien = new MetroFramework.Controls.MetroGrid();
            this.btnsupprimer = new MetroFramework.Controls.MetroTile();
            this.btnrecherche = new MetroFramework.Controls.MetroTile();
            this.btnajout = new MetroFramework.Controls.MetroTile();
            this.btnmodifier = new MetroFramework.Controls.MetroTile();
            this.btnimprime = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgventretien)).BeginInit();
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
            this.txtrecherhce.Location = new System.Drawing.Point(469, 180);
            this.txtrecherhce.MaxLength = 32767;
            this.txtrecherhce.Name = "txtrecherhce";
            this.txtrecherhce.PasswordChar = '\0';
            this.txtrecherhce.PromptText = "Recherhcer par vehicule, par entretien";
            this.txtrecherhce.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtrecherhce.SelectedText = "";
            this.txtrecherhce.SelectionLength = 0;
            this.txtrecherhce.SelectionStart = 0;
            this.txtrecherhce.ShortcutsEnabled = true;
            this.txtrecherhce.Size = new System.Drawing.Size(365, 31);
            this.txtrecherhce.TabIndex = 31;
            this.txtrecherhce.UseSelectable = true;
            this.txtrecherhce.WaterMark = "Recherhcer par vehicule, par entretien";
            this.txtrecherhce.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtrecherhce.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgventretien
            // 
            this.dgventretien.AllowUserToResizeRows = false;
            this.dgventretien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgventretien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgventretien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgventretien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgventretien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgventretien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgventretien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgventretien.EnableHeadersVisualStyles = false;
            this.dgventretien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgventretien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgventretien.Location = new System.Drawing.Point(24, 235);
            this.dgventretien.Name = "dgventretien";
            this.dgventretien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgventretien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgventretien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgventretien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgventretien.Size = new System.Drawing.Size(1319, 453);
            this.dgventretien.Style = MetroFramework.MetroColorStyle.Teal;
            this.dgventretien.TabIndex = 30;
            this.dgventretien.UseCustomBackColor = true;
            this.dgventretien.UseCustomForeColor = true;
            this.dgventretien.UseStyleColors = true;
            this.dgventretien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgventretien_CellContentClick);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.ActiveControl = null;
            this.btnsupprimer.BackColor = System.Drawing.Color.Teal;
            this.btnsupprimer.Enabled = false;
            this.btnsupprimer.ForeColor = System.Drawing.Color.Snow;
            this.btnsupprimer.Location = new System.Drawing.Point(1246, 38);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(88, 74);
            this.btnsupprimer.TabIndex = 33;
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
            // btnrecherche
            // 
            this.btnrecherche.ActiveControl = null;
            this.btnrecherche.BackColor = System.Drawing.Color.Teal;
            this.btnrecherche.ForeColor = System.Drawing.Color.White;
            this.btnrecherche.Location = new System.Drawing.Point(840, 180);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(33, 29);
            this.btnrecherche.TabIndex = 32;
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
            this.btnajout.Location = new System.Drawing.Point(1058, 38);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(88, 74);
            this.btnajout.TabIndex = 29;
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
            this.btnmodifier.Location = new System.Drawing.Point(1152, 38);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(88, 74);
            this.btnmodifier.TabIndex = 28;
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
            this.btnimprime.Location = new System.Drawing.Point(964, 38);
            this.btnimprime.Name = "btnimprime";
            this.btnimprime.Size = new System.Drawing.Size(88, 74);
            this.btnimprime.TabIndex = 27;
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
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListeEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 725);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.txtrecherhce);
            this.Controls.Add(this.dgventretien);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.btnajout);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnimprime);
            this.Controls.Add(this.pictureBox1);
            this.Movable = false;
            this.Name = "ListeEntretien";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "       Suivi des entretiens";
            this.Load += new System.EventHandler(this.ListeEntretien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgventretien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtrecherhce;
        private MetroFramework.Controls.MetroGrid dgventretien;
        private MetroFramework.Controls.MetroTile btnrecherche;
        private MetroFramework.Controls.MetroTile btnajout;
        private MetroFramework.Controls.MetroTile btnmodifier;
        private MetroFramework.Controls.MetroTile btnimprime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnsupprimer;
    }
}