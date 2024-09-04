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
    public partial class PrintEntretien : MetroFramework.Forms.MetroForm
    {
        private DataSetGestionVehicule DataSetGestionVehicule;
        private entTableAdapter EntTableAdapter;
        public PrintEntretien()
        {
            InitializeComponent();
            DataSetGestionVehicule = new DataSetGestionVehicule();
            EntTableAdapter = new entTableAdapter();
        }

        private void PrintEntretien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGestionVehicule1.Entretien' table. You can move, or remove it, as needed.
            this.entretienTableAdapter.Fill(this.dataSetGestionVehicule1.Entretien);
            this.MaximizeBox = false;

            // Utilisation d'un ensemble pour suivre les valeurs déjà affichées
            HashSet<string> displayedValues = new HashSet<string>();

            // Parcours des données et ajout des valeurs uniques au ComboBox
            foreach (var row in this.dataSetGestionVehicule1.Entretien)
            {
                string dataItem = row.TypeEntretien;

                if (!displayedValues.Contains(dataItem))
                {
                    metroComboBox1.Items.Add(dataItem);
                    displayedValues.Add(dataItem);
                }
            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            this.DataSetGestionVehicule.EnforceConstraints = false;
            this.EntTableAdapter.Fill(this.DataSetGestionVehicule.ent,metroComboBox1.SelectedItem.ToString());
            reportViewer.LocalReport.ReportPath = "EntretienReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DataSetGestionVehicule.ent.ToList()));
            this.reportViewer.RefreshReport();

        }
    }
}
