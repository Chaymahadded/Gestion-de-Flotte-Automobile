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
    public partial class PrintVehicule : MetroFramework.Forms.MetroForm
    {
        private DataSetGestionVehicule DataSetGestionVehicule;
        private VTableAdapter VTableAdapter;
        public PrintVehicule()
        {
            InitializeComponent();
            DataSetGestionVehicule = new DataSetGestionVehicule();
            VTableAdapter = new VTableAdapter();
        }

        private void PrintVehicule_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.DataSetGestionVehicule.EnforceConstraints = false;
            this.VTableAdapter.Fill(this.DataSetGestionVehicule.V);
            reportViewer.LocalReport.ReportPath = "VehiculeReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataSetGestionVehicule.V.ToList()));
            this.reportViewer.RefreshReport();

        }
    }
}
