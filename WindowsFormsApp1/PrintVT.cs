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
    public partial class PrintVT : MetroFramework.Forms.MetroForm
    {
        private DataSetGestionVehicule DataSetGestionVehicule;
        private VTTableAdapter VTTableAdapter;
        public PrintVT()
        {
            InitializeComponent();
            DataSetGestionVehicule = new DataSetGestionVehicule();
            VTTableAdapter = new VTTableAdapter();
        }

        private void PrintVT_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.DataSetGestionVehicule.EnforceConstraints = false;
            this.VTTableAdapter.Fill(this.DataSetGestionVehicule.VT);
            reportViewer.LocalReport.ReportPath = "VtReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataSetGestionVehicule.VT.ToList()));
            this.reportViewer.RefreshReport();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
