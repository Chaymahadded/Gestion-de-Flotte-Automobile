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
    public partial class PrintCat : MetroFramework.Forms.MetroForm
    {

        private DataSetGestionVehicule DataSetGestionVehicule;
        private CategorieTableAdapter CategorieTableAdapter;
        public PrintCat()
        {
            InitializeComponent();
            DataSetGestionVehicule = new DataSetGestionVehicule();
            CategorieTableAdapter = new CategorieTableAdapter();
        }

        private void PrintCat_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.DataSetGestionVehicule.EnforceConstraints = false;
            this.CategorieTableAdapter.Fill(this.DataSetGestionVehicule.Categorie);
            reportViewer.LocalReport.ReportPath = "CatReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataSetGestionVehicule.Categorie.ToList()));
            this.reportViewer.RefreshReport();
        }
    }
}
