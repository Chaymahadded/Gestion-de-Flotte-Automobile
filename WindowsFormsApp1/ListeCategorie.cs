using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ListeCategorie : MetroFramework.Forms.MetroForm
    {
        public ListeCategorie()
        {
            InitializeComponent();
        }

        private void ListeCategorie_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
                dgvcat.DataSource = null;
                dgvcat.DataSource = bd.Categories.Select(
                    x => new
                    {
                        Code = x.NumCategorie,
                        Nom = x.NomCategorie,
                        
                    }
                    )
                .ToList();
            }
            btnsup.Enabled = false;
        }

       

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneng_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == "" || txtnom.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        string code = txtcode.Text;
                        if (bd.Categories.Where(x => x.NumCategorie == code).Count() > 0)
                        {
                            if (bd.Categories.Where(x => x.NomCategorie == txtnom.Text).Count() > 0)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Cette catégorie déjà existe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                Categorie c = bd.Categories
                                    .Where(x => x.NumCategorie == code)
                                    .FirstOrDefault();
                                c.NomCategorie = txtnom.Text;
                                bd.SaveChanges();
                            }
                        }
                        else if (bd.Categories.Where(x => x.NomCategorie == txtnom.Text).Count() > 0)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Cette catégorie déjà existe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Categorie c = new Categorie();
                            c.NumCategorie = code;
                            c.NomCategorie = txtnom.Text;
                            bd.Categories.Add(c);
                            bd.SaveChanges();

                            MetroFramework.MetroMessageBox.Show(this, "Catégorie a été ajoutée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        txtcode.Text = "";
                        txtnom.Text = "";
                        ListeCategorie_Load(sender, e);
                    }
                
            }
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            if (dgvcat.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer cette catégorie ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        foreach (DataGridViewRow r in dgvcat.SelectedRows)
                        {
                            string code = (string)r.Cells[0].Value;
                            Categorie c = bd.Categories.FirstOrDefault(x => x.NumCategorie == code);
                            bool categorieUtilisee = bd.Vehicules.Any(v => v.IdCategorie == c.IdCategorie);

                            if (categorieUtilisee)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Cette catégorie est associée à des véhicules et ne peut pas être supprimée.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                bd.Categories.Remove(c);
                                bd.SaveChanges();
                            }
                        }
                        ListeCategorie_Load(sender, e);
                    }
                }
            }
        }


    private void btnrecherche_Click(object sender, EventArgs e)
        {
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                string rechercheTexte = txtrecherche.Text.Trim();
                
                    dgvcat.DataSource = bd.Categories
                        .Where(x => x.NomCategorie.StartsWith(rechercheTexte) || x.NumCategorie.ToString().StartsWith(rechercheTexte))
                        .Select(x => new
                        {
                            Code = x.NumCategorie,
                            Nom = x.NomCategorie
                        })
                        .ToList();
                

            }
        }

        private void dgvcat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcat.SelectedCells.Count > 0)
            {
                int pos = dgvcat.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvcat.Rows[pos];
                txtcode.Text = selectedRow.Cells["Code"].Value.ToString();
                txtnom.Text = selectedRow.Cells["Nom"].Value.ToString();
                btnsup.Enabled = true;
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            PrintCat printCat = new PrintCat();
            printCat.ShowDialog();
        }
    }
}
