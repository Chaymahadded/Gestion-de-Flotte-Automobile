using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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

    public partial class ListeVisiteTechnique : MetroFramework.Forms.MetroForm
    {



        public ListeVisiteTechnique()
        {

            InitializeComponent();

        }

        private void ListeVisiteTechnique_Load(object sender, EventArgs e)
        {

            MaximizeBox = false;
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
                dgvvisite.DataSource = null;
                dgvvisite.DataSource = bd.VisiteTechniques.Select(
                    x => new
                    {
                        Numéro = x.IdVisiteTech,

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
                        Date_Visite = x.DateVisite,
                        Date_Prochaine_Visite = x.DatePV,
                        Montant = x.MontantTotale
                    }
                    )
                .ToList();
            }
            btnmodifier.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AddVT addVT = new AddVT();
            addVT.ShowDialog();
            ListeVisiteTechnique_Load(sender, e);
        }

        private void dgvvisite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvvisite.SelectedRows.Count == 1)
            {

                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
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

                var resultats = bd.VisiteTechniques
                                    .Where(x => vehicules.Contains(x.Num_Vehicule))
                                    .Select(x => new
                                    {
                                        Numéro = x.IdVisiteTech,

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
                                        Date_Visite = x.DateVisite,
                                        Date_Prochaine_Visite = x.DatePV,
                                        Montant = x.MontantTotale
                                    })
                                    .ToList();
                dgvvisite.DataSource = resultats;
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvvisite.SelectedRows[0];
            string matricule = selectedRow.Cells["Véhicule"].Value.ToString();
            DateTime datev = Convert.ToDateTime(selectedRow.Cells["Date_Visite"].Value);
            DateTime datepv = Convert.ToDateTime(selectedRow.Cells["Date_Prochaine_Visite"].Value);
            string montant = selectedRow.Cells["Montant"].Value.ToString();
            EditVT editVT = new EditVT(matricule, datev, datepv, montant);
            editVT.ShowDialog();
            ListeVisiteTechnique_Load(sender, e);
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dgvvisite.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer cette visite technique ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        foreach (DataGridViewRow r in dgvvisite.SelectedRows)
                        {
                            int id = (int)r.Cells[0].Value;

                            VisiteTechnique v = bd.VisiteTechniques.FirstOrDefault(x => x.IdVisiteTech == id);

                            bd.VisiteTechniques.Remove(v);
                            bd.SaveChanges();

                        }
                        ListeVisiteTechnique_Load(sender, e);
                    }
                }
            }
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            
            PrintVT printVT = new PrintVT();
            printVT.ShowDialog();

        }
    }
    }
