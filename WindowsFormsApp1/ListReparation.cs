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
using DGV2Printer;

namespace WindowsFormsApp1
{
    public partial class ListReparation : MetroFramework.Forms.MetroForm
    {
        public ListReparation()
        {
            InitializeComponent();
        }

        private void ListReparation_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
                dgvrep.DataSource = null;
                dgvrep.DataSource = bd.Reparations.Select(
                    x => new
                    {
                        Numéro = x.IdReparation,
                        Véhicule = bd.Vehicules
                                .Where(v => v.NumVehicule == x.Num_Vehicule)
                                .Select(v => v.Matricule)
                                .FirstOrDefault(),
                        Marque = bd.Vehicules
                                .Where(v => v.NumVehicule == x.Num_Vehicule)
                                .Select(v => v.Marque)
                                .FirstOrDefault(),
                        Date_Réparation = x.DateReparation,
                        Designation = x.Designation,
                        Quantité = x.Quantite,
                        Prix = x.Prix,
                        Montant = x.MontantTotale

                    }
                    )
                .ToList();
            }
            btnmodifier.Enabled = false;
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AddReparation addReparation = new AddReparation();
            addReparation.ShowDialog();
            ListReparation_Load(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvrep.SelectedRows[0];
            string matricule = selectedRow.Cells["Véhicule"].Value.ToString();
            DateTime daterep = Convert.ToDateTime(selectedRow.Cells["Date_Réparation"].Value);
            string designation = selectedRow.Cells["Designation"].Value.ToString();
            string montant = selectedRow.Cells["Montant"].Value.ToString();
            string quantite = selectedRow.Cells["Quantité"].Value.ToString();
            string prix = selectedRow.Cells["Prix"].Value.ToString();
            EditReparationn editReparation = new EditReparationn(matricule, daterep, designation, quantite, montant, prix);
            editReparation.ShowDialog();
            ListReparation_Load(sender, e);

        }

        private void dgvrep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvrep.SelectedRows.Count == 1)
            {

                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            string critereRecherche = txtrecherhce.Text.Trim();
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                var resultatsRecherche = bd.Reparations.Where(x =>
                        bd.Vehicules.Any(v => v.NumVehicule == x.Num_Vehicule &&
                        (v.Matricule.Contains(critereRecherche))))
                    .Select(x => new
                    {
                        Numéro = x.IdReparation,
                        Véhicule = bd.Vehicules
                                .Where(v => v.NumVehicule == x.Num_Vehicule)
                                .Select(v => v.Matricule)
                                .FirstOrDefault(),
                        Marque = bd.Vehicules
                                .Where(v => v.NumVehicule == x.Num_Vehicule)
                                .Select(v => v.Marque)
                                .FirstOrDefault(),
                        Date_Réparation = x.DateReparation,
                        Designation = x.Designation,
                        Quantité = x.Quantite,
                        Prix = x.Prix,
                        Montant = x.MontantTotale
                    }).ToList();
                dgvrep.DataSource = resultatsRecherche;
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dgvrep.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer cette réparation ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        foreach (DataGridViewRow r in dgvrep.SelectedRows)
                        {
                            int id = (int)r.Cells[0].Value;

                            Reparation rep = bd.Reparations.FirstOrDefault(x => x.IdReparation == id);

                            bd.Reparations.Remove(rep);
                            bd.SaveChanges();

                        }
                        ListReparation_Load(sender, e);
                    }
                }
            }
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            PrintReparation printReparation = new PrintReparation();
            printReparation.ShowDialog();
        }

        private void btnimprime_Click_1(object sender, EventArgs e)
        {
            PrintReparation printReparation = new PrintReparation();
            printReparation.ShowDialog();
        }
    }
}

