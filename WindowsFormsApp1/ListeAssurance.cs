using DGV2Printer;
using DGVPrinterHelper;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ListeAssurance : MetroFramework.Forms.MetroForm
    {

        public ListeAssurance()
        {
            InitializeComponent();

        }



        private void ListeAssurance_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
                dgvassu.DataSource = null;
                dgvassu.DataSource = bd.Assurances.Select(
                    x => new
                    {
                        Numéro = x.IdAssurance,
                        Véhicule = bd.Vehicules
                                .Where(v => v.NumVehicule == x.Num_Vehicule)
                                .Select(v => v.Matricule)
                                .FirstOrDefault(),
                        Marque = bd.Vehicules
                                .Where(v => v.NumVehicule == x.Num_Vehicule)
                                .Select(v => v.Marque)
                                .FirstOrDefault(),
                        DMC = bd.Vehicules
                                .Where(v => v.NumVehicule == x.Num_Vehicule)
                                .Select(v => v.DMC)
                                .FirstOrDefault(),
                        Puissance = bd.Vehicules
                                .Where(v => v.NumVehicule == x.Num_Vehicule)
                                .Select(v => v.Puissance)
                                .FirstOrDefault(),
                        Date_Rappel = x.DateFin,
                    }
                    )
                .ToList();
            }
            btnmodifier.Enabled = false;
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                string rechercheTexte = txtrecherhce.Text.Trim();
                var vehicules = bd.Vehicules
                    .Where(v => v.Matricule.StartsWith(rechercheTexte))
                    .Select(v => (int?)v.NumVehicule)
                    .ToList();

                var resultats = bd.Assurances
                                    .Where(x => vehicules.Contains(x.Num_Vehicule))
                                    .Select(x => new

                                    {
                                        Numéro = x.IdAssurance,
                                        Véhicule = bd.Vehicules
                                                    .Where(v => v.NumVehicule == x.Num_Vehicule)
                                                    .Select(v => v.Matricule)
                                                    .FirstOrDefault(),
                                        Marque = bd.Vehicules
                                                    .Where(v => v.NumVehicule == x.Num_Vehicule)
                                                    .Select(v => v.Marque)
                                                    .FirstOrDefault(),
                                        DMC = bd.Vehicules
                                                    .Where(v => v.NumVehicule == x.Num_Vehicule)
                                                    .Select(v => v.DMC)
                                                    .FirstOrDefault(),
                                        Puissance = bd.Vehicules
                                                    .Where(v => v.NumVehicule == x.Num_Vehicule)
                                                    .Select(v => v.Puissance)
                                                    .FirstOrDefault(),
                                        Date_Rappel = x.DateFin,
                                    })
                                    .ToList();
                dgvassu.DataSource = resultats;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AddAssurance addAssurance = new AddAssurance();
            addAssurance.ShowDialog();
            ListeAssurance_Load(sender, e);
        }

        private void dgvassu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvassu.SelectedRows.Count == 1)
            {

                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvassu.SelectedRows[0];
            string matricule = selectedRow.Cells["Véhicule"].Value.ToString();
            DateTime datef = Convert.ToDateTime(selectedRow.Cells["Date_Rappel"].Value);
            EditAssurance editassurance = new EditAssurance(matricule, datef);
            editassurance.ShowDialog();
            ListeAssurance_Load(sender, e);

        }

       
       

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dgvassu.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer cet assurance ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        foreach (DataGridViewRow r in dgvassu.SelectedRows)
                        {
                            int id = (int)r.Cells[0].Value;

                            Assurance a = bd.Assurances.FirstOrDefault(x => x.IdAssurance == id);
                            
                                bd.Assurances.Remove(a);
                                bd.SaveChanges();
                            
                        }
                        ListeAssurance_Load(sender, e);
                    }
                }
            }
        }


    }
}
