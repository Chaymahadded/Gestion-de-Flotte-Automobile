using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class ListeVehicule : MetroFramework.Forms.MetroForm
    {
        public ListeVehicule()
        {
            InitializeComponent();
        }

        private void ListeVehicule_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
                dgvvehicule.DataSource = null;
                dgvvehicule.DataSource = bd.Vehicules.Select(
                    x => new
                    {
                        Numéro_Véhicule = x.NumVehicule,
                        Matricule = x.Matricule,
                        Marque = x.Marque,
                        Puissance = x.Puissance,
                        Energie = x.Energie,
                        DMC = x.DMC,
                        Numéro_Chassis = x.Num_Chassis,
                        Nombre_Place = x.NombrePlaces,
                        Age_Moyen = x.AgeMoyen,
                        Index = x.Index,
                        Catégorie = bd.Categories
                                .Where(c => c.IdCategorie == x.IdCategorie)
                                .Select(c => c.NumCategorie)
                                .FirstOrDefault(),
                Affectation = bd.Services
                                .Where(s => s.IdService == x.IdService)
                                .Select(s => s.NomService)
                                .FirstOrDefault(),
                        UT = bd.UTs
                                .Where(u => u.IdUT == x.IdUT)
                                .Select(u => u.NumUT)
                                .FirstOrDefault(),

                    }
                    )
                .ToList();
                var vehicules = bd.Vehicules.ToList();
                
               

                if (vehicules.Any())
                {
                    

                    double moyenneAgeMoyen = vehicules.Select(x => Convert.ToDouble(x.AgeMoyen)).Average();
                    txtagemoyen.Text = moyenneAgeMoyen.ToString("F2");
                }
                else
                {
                    txtagemoyen.Text = "0";
                }
            }
            btnmodifier.Enabled = false;
            btnsupprimer.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AddVehicule v = new AddVehicule();  
            v.ShowDialog();
            ListeVehicule_Load(sender, e);
        }

        private void dgvvehicule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvvehicule.SelectedCells.Count > 0)
            {
              
                btnsupprimer.Enabled = true;
            }
            if (dgvvehicule.SelectedRows.Count == 1)
            {

                btnmodifier.Enabled = true;
                btnverif.Enabled = true;
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dgvvehicule.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer ce véhicule ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        foreach (DataGridViewRow r in dgvvehicule.SelectedRows)
                        {
                            string matricule = r.Cells[1].Value.ToString();
                            Vehicule vehicule = bd.Vehicules.FirstOrDefault(x => x.Matricule == matricule);
                            bool assuranceUtilisee = bd.Assurances.Any(a => a.Num_Vehicule == vehicule.NumVehicule);
                            bool visiteTechniqueUtilisee = bd.VisiteTechniques.Any(v => v.Num_Vehicule == vehicule.NumVehicule);
                           bool vignetteUtilisee = bd.Vignettes.Any(v => v.Num_Vehicule == vehicule.NumVehicule);
                            bool entretienUtilisee = bd.Entretiens.Any(ent => ent.Num_Vehicule == vehicule.NumVehicule);
                            bool reparationUtilisee = bd.Reparations.Any(rep => rep.Num_Vehicule == vehicule.NumVehicule);
                            if (assuranceUtilisee || visiteTechniqueUtilisee || vignetteUtilisee || entretienUtilisee || reparationUtilisee)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Ce véhicule est associé à une assurance, une visite technique ou une vignette et ne peut pas être supprimé.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                bd.Vehicules.Remove(vehicule);
                                bd.SaveChanges();
                            }
                        }
                        ListeVehicule_Load(sender, e);
                    }
                }
            }
        }


        private void btnmodifier_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow selectedRow = dgvvehicule.SelectedRows[0];
            string matricule = selectedRow.Cells["Matricule"].Value.ToString();
            string marque = selectedRow.Cells["Marque"].Value.ToString();
            string puissance = selectedRow.Cells["Puissance"].Value.ToString();
            string energie = selectedRow.Cells["Energie"].Value.ToString();
            DateTime dmc = Convert.ToDateTime(selectedRow.Cells["DMC"].Value);
            string numeroChassis = selectedRow.Cells["Numéro_Chassis"].Value.ToString();
            string nombrePlace = selectedRow.Cells["Nombre_Place"].Value.ToString();
            string ageMoyen = selectedRow.Cells["Age_Moyen"].Value.ToString();
            string index = selectedRow.Cells["Index"].Value.ToString();
            string categorie = selectedRow.Cells["Catégorie"].Value.ToString();
            string affectation = selectedRow.Cells["Affectation"].Value.ToString();
            string ut = selectedRow.Cells["UT"].Value.ToString();
            EditVehicule modifierForm = new EditVehicule(matricule, marque, puissance, energie, dmc, numeroChassis, nombrePlace, ageMoyen, index, categorie, affectation, ut);
            modifierForm.ShowDialog();
            ListeVehicule_Load(sender, e);
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                string rechercheTexte = txtrecherhce.Text.Trim();
                    dgvvehicule.DataSource = bd.Vehicules
                         .Where(x => x.Matricule.ToString().StartsWith(rechercheTexte))
                        .Select(x => new
                        {
                            Numéro_Véhicule = x.NumVehicule,
                            Matricule = x.Matricule,
                            Marque = x.Marque,
                            Puissance = x.Puissance,
                            Energie = x.Energie,
                            DMC = x.DMC,
                            Numéro_Chassis = x.Num_Chassis,
                            Nombre_Place = x.NombrePlaces,
                            Age_Moyen = x.AgeMoyen,
                            Index = x.Index,
                            Catégorie = bd.Categories
                                .Where(c => c.IdCategorie == x.IdCategorie)
                                .Select(c => c.NumCategorie)
                                .FirstOrDefault(),
                            Affectation = bd.Services
                                .Where(s => s.IdService == x.IdService)
                                .Select(s => s.NomService)
                                .FirstOrDefault(),
                            UT = bd.UTs
                                .Where(u => u.IdUT == x.IdUT)
                                .Select(u => u.NumUT)
                                .FirstOrDefault(),
                        })
                        .ToList();
                

            }
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            
            PrintVehicule printVehicule = new PrintVehicule();
            printVehicule.ShowDialog();
            
        }

        private void dgvvehicule_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvvehicule.Rows[e.RowIndex];

                int num = Convert.ToInt32(row.Cells["Numéro_Véhicule"].Value);

                RepVehicule reparationForm = new RepVehicule(num);

                reparationForm.ShowDialog();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = dgvvehicule.SelectedRows[0];
            string matricule = selectedRow.Cells["Matricule"].Value.ToString();
            string index = selectedRow.Cells["Index"].Value.ToString();
            
            VerifIndex verifForm = new VerifIndex(matricule, index);
            verifForm.ShowDialog();
            ListeVehicule_Load(sender, e);
        }
    }
}
