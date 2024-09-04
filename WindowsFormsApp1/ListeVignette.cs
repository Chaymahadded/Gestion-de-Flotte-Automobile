using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ListeVignette : MetroFramework.Forms.MetroForm
    {
        public ListeVignette()
        {
            InitializeComponent();
        }

        private void ListeVignette_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
                dgvvignette.DataSource = null;
                dgvvignette.DataSource = bd.Vignettes.Select(
                    x => new
                    {
                        Numéro = x.Id_Vignette,
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
                        Date_Rappel = x.DatePV,
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

        private void dgvvignette_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvvignette.SelectedRows.Count == 1)
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

                var resultats = bd.Vignettes
                                    .Where(x => vehicules.Contains(x.Num_Vehicule))
                                    .Select(x => new
                                    {
                                        Numéro = x.Id_Vignette,
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
                                        Date_Rappel = x.DatePV,
                                    })
                                    .ToList();
                dgvvignette.DataSource = resultats;
            }
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AddVignette addVignette = new AddVignette();
            addVignette.ShowDialog();
            ListeVignette_Load(sender, e);
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvvignette.SelectedRows[0];
            string matricule = selectedRow.Cells["Véhicule"].Value.ToString();
            DateTime datef = Convert.ToDateTime(selectedRow.Cells["Date_Rappel"].Value);
            EditVignette editVignette = new EditVignette(matricule, datef);
            editVignette.ShowDialog();
            ListeVignette_Load(sender, e);
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dgvvignette.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        foreach (DataGridViewRow r in dgvvignette.SelectedRows)
                        {
                            int id = (int)r.Cells[0].Value;

                            Vignette v = bd.Vignettes.FirstOrDefault(x => x.Id_Vignette == id);

                            bd.Vignettes.Remove(v);
                            bd.SaveChanges();

                        }
                        ListeVignette_Load(sender, e);
                    }
                }
            }
        }

       
    }
}
