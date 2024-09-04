using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSetGestionVehiculeTableAdapters;

namespace WindowsFormsApp1
{
    public partial class PrintUT : MetroFramework.Forms.MetroForm
    {
        private DataSetGestionVehicule DataSetGestionVehicule;
        private UTTableAdapter UTTableAdapter;
        public PrintUT()
        {
            InitializeComponent();
            DataSetGestionVehicule = new DataSetGestionVehicule();
            UTTableAdapter = new UTTableAdapter();
        }

        private void PrintUT_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.DataSetGestionVehicule.EnforceConstraints = false;
            this.UTTableAdapter.Fill(this.DataSetGestionVehicule.UT);
            reportViewer.LocalReport.ReportPath = "UTReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataSetGestionVehicule.UT.ToList()));
            this.reportViewer.RefreshReport();
        }
    }
}
