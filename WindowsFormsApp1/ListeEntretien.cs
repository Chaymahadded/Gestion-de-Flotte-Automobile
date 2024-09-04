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
    public partial class ListeEntretien : MetroFramework.Forms.MetroForm
    {
        public ListeEntretien()
        {
            InitializeComponent();
        }

        private void ListeEntretien_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
                dgventretien.DataSource = null;
                dgventretien.DataSource = bd.Entretiens.Select(
                    x => new
                    {
                        Numéro = x.IdEntretien,
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
                                Type_Entretien = x.TypeEntretien,
                        Index = x.Kilometrage,

                    }
                    )
                .ToList();
            }
            btnmodifier.Enabled = false;
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AddEntretien addEntretien = new AddEntretien();

            addEntretien.ShowDialog();
            ListeEntretien_Load(sender, e);
        }
        

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgventretien.SelectedRows[0];
            string matricule = selectedRow.Cells["Véhicule"].Value.ToString();
            string index = selectedRow.Cells["Index"].Value.ToString();
            string type = selectedRow.Cells["Type_Entretien"].Value.ToString();
            EditEntretien editEntretien = new EditEntretien(matricule,index, type);
            editEntretien.ShowDialog();
            ListeEntretien_Load(sender, e);
        }

        private void dgventretien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgventretien.SelectedRows.Count == 1)
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
                var resultatsRecherche = bd.Entretiens.Where(x =>
                        bd.Vehicules.Any(v => v.NumVehicule == x.Num_Vehicule &&
                        (v.Matricule.Contains(critereRecherche) ||
                        x.TypeEntretien.Contains(critereRecherche))))
                    .Select(x => new
                    {
                        Numéro = x.IdEntretien,
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
                        Type_Entretien = x.TypeEntretien,
                        Index = x.Kilometrage,
                    }).ToList();
                dgventretien.DataSource = resultatsRecherche;
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dgventretien.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer cet entretien ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        foreach (DataGridViewRow r in dgventretien.SelectedRows)
                        {
                            int id = (int)r.Cells[0].Value;

                            Entretien en = bd.Entretiens.FirstOrDefault(x => x.IdEntretien == id);

                            bd.Entretiens.Remove(en);
                            bd.SaveChanges();

                        }
                        ListeEntretien_Load(sender, e);
                    }
                }
            }
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            PrintEntretien printEntretien = new PrintEntretien();
            printEntretien.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
