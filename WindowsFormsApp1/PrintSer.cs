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
    public partial class PrintSer : MetroFramework.Forms.MetroForm
    {
        private DataSetGestionVehicule DataSetGestionVehicule;
        private ServiceTableAdapter ServiceTableAdapter;
        public PrintSer()
        {
            InitializeComponent();
            DataSetGestionVehicule = new DataSetGestionVehicule();
            ServiceTableAdapter = new ServiceTableAdapter();
        }

        private void PrintSer_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.DataSetGestionVehicule.EnforceConstraints = false;
            this.ServiceTableAdapter.Fill(this.DataSetGestionVehicule.Service);
            reportViewer.LocalReport.ReportPath = "SerReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataSetGestionVehicule.Service.ToList()));
            this.reportViewer.RefreshReport();
        }
    }
}
