namespace WindowsFormsApp1
{
    partial class VerifIndex
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
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtindex = new MetroFramework.Controls.MetroTextBox();
            this.btnann = new MetroFramework.Controls.MetroButton();
            this.btnverif = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel9.Location = new System.Drawing.Point(90, 99);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(122, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 33;
            this.metroLabel9.Text = "Index Actuelle";
            this.metroLabel9.UseStyleColors = true;
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
            this.txtindex.Location = new System.Drawing.Point(250, 94);
            this.txtindex.MaxLength = 32767;
            this.txtindex.Name = "txtindex";
            this.txtindex.PasswordChar = '\0';
            this.txtindex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtindex.SelectedText = "";
            this.txtindex.SelectionLength = 0;
            this.txtindex.SelectionStart = 0;
            this.txtindex.ShortcutsEnabled = true;
            this.txtindex.Size = new System.Drawing.Size(120, 30);
            this.txtindex.TabIndex = 32;
            this.txtindex.UseSelectable = true;
            this.txtindex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtindex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnann
            // 
            this.btnann.BackColor = System.Drawing.Color.Red;
            this.btnann.ForeColor = System.Drawing.Color.White;
            this.btnann.Location = new System.Drawing.Point(366, 172);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(76, 34);
            this.btnann.TabIndex = 54;
            this.btnann.Text = "Annuler";
            this.btnann.UseCustomBackColor = true;
            this.btnann.UseCustomForeColor = true;
            this.btnann.UseSelectable = true;
            this.btnann.UseStyleColors = true;
            this.btnann.Click += new System.EventHandler(this.btnann_Click);
            // 
            // btnverif
            // 
            this.btnverif.BackColor = System.Drawing.Color.Green;
            this.btnverif.ForeColor = System.Drawing.Color.White;
            this.btnverif.Location = new System.Drawing.Point(277, 172);
            this.btnverif.Name = "btnverif";
            this.btnverif.Size = new System.Drawing.Size(76, 34);
            this.btnverif.TabIndex = 53;
            this.btnverif.Text = "Vérifier";
            this.btnverif.UseCustomBackColor = true;
            this.btnverif.UseCustomForeColor = true;
            this.btnverif.UseSelectable = true;
            this.btnverif.UseStyleColors = true;
            this.btnverif.Click += new System.EventHandler(this.btnverif_Click);
            // 
            // VerifIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 229);
            this.Controls.Add(this.btnann);
            this.Controls.Add(this.btnverif);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtindex);
            this.Movable = false;
            this.Name = "VerifIndex";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Vérifier Index";
            this.Load += new System.EventHandler(this.VerifIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtindex;
        private MetroFramework.Controls.MetroButton btnann;
        private MetroFramework.Controls.MetroButton btnverif;
    }
}