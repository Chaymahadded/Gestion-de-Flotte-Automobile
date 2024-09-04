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
    public partial class PrintReparation : MetroFramework.Forms.MetroForm
    {
        private DataSetGestionVehicule DataSetGestionVehicule;
        private DepenseTableAdapter DepenseTableAdapter;
        public PrintReparation()
        {
            InitializeComponent();
            DataSetGestionVehicule = new DataSetGestionVehicule();
            DepenseTableAdapter = new DepenseTableAdapter();
        }

        private void PrintReparation_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.DataSetGestionVehicule.EnforceConstraints = false;
            this.DepenseTableAdapter.Fill(this.DataSetGestionVehicule.Depense);
            reportViewer.LocalReport.ReportPath = "ReparationReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataSetGestionVehicule.Depense.ToList()));
            this.reportViewer.RefreshReport();
        }
    }
}
