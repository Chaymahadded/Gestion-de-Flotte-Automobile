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
    public partial class Printrep : MetroFramework.Forms.MetroForm
    {
        private int numVehicule;
        private DataSetGestionVehicule DataSetGestionVehicule;
        private RepTableAdapter RepTableAdapter;
        public Printrep(int num)
        {
            InitializeComponent();
            this.numVehicule = num;
            DataSetGestionVehicule = new DataSetGestionVehicule();
            RepTableAdapter = new RepTableAdapter();


        }

        private void Printrep_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.DataSetGestionVehicule.EnforceConstraints = false;
            this.RepTableAdapter.Fill(this.DataSetGestionVehicule.Rep,numVehicule);
            reportViewer.LocalReport.ReportPath = "FicheReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataSetGestionVehicule.Rep.ToList()));
            this.reportViewer.RefreshReport();
        }
    }
}
