namespace WindowsFormsApp1
{
    partial class PrintEntretien
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
            this.components = new System.ComponentModel.Container();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.dataSetGestionVehicule1 = new WindowsFormsApp1.DataSetGestionVehicule();
            this.entretienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entretienTableAdapter = new WindowsFormsApp1.DataSetGestionVehiculeTableAdapters.EntretienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestionVehicule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entretienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.AutoSize = true;
            this.reportViewer.Location = new System.Drawing.Point(50, 80);
            this.reportViewer.Name = "ReportViewer";
            this.reportViewer.Size = new System.Drawing.Size(1286, 625);
            this.reportViewer.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(100, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Type Entretien";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Teal;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(555, 29);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(107, 29);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Sélectionner ";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseMnemonic = false;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(260, 29);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(280, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.UseStyleColors = true;
            // 
            // dataSetGestionVehicule1
            // 
            this.dataSetGestionVehicule1.DataSetName = "DataSetGestionVehicule";
            this.dataSetGestionVehicule1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entretienBindingSource
            // 
            this.entretienBindingSource.DataMember = "Entretien";
            this.entretienBindingSource.DataSource = this.dataSetGestionVehicule1;
            // 
            // entretienTableAdapter
            // 
            this.entretienTableAdapter.ClearBeforeFill = true;
            // 
            // PrintEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 725);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.reportViewer);
            this.Movable = false;
            this.Name = "PrintEntretien";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.PrintEntretien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGestionVehicule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entretienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private DataSetGestionVehicule dataSetGestionVehicule1;
        private System.Windows.Forms.BindingSource entretienBindingSource;
        private DataSetGestionVehiculeTableAdapters.EntretienTableAdapter entretienTableAdapter;
    }
}