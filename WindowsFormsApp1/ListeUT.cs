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
    public partial class ListeUT : MetroFramework.Forms.MetroForm
    {
        public ListeUT()
        {
            InitializeComponent();
        }

        private void ListeUT_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
                dgvut.DataSource = null;
                dgvut.DataSource = bd.UTs.Select(
                    x => new
                    {
                        Code = x.NumUT,
                        Nom = x.NomUT,

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
                        if (bd.UTs.Where(x => x.NumUT == code).Count() > 0)
                        {
                            if (bd.UTs.Where(x => x.NomUT == txtnom.Text).Count() > 0)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Cet utilité technique déjà existe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                UT u = bd.UTs
                                .Where(x => x.NumUT == code)
                                    .FirstOrDefault();
                                u.NomUT = txtnom.Text;
                                bd.SaveChanges();
                            }
                        }
                        else if (bd.UTs.Where(x => x.NomUT == txtnom.Text).Count() > 0)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Cet utilité technique déjà existe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            UT u = new UT();
                            u.NumUT = code;
                            u.NomUT = txtnom.Text;
                            bd.UTs.Add(u);
                            bd.SaveChanges();

                            MetroFramework.MetroMessageBox.Show(this, "Utilité technique a été ajoutée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        txtcode.Text = "";
                        txtnom.Text = "";
                        ListeUT_Load(sender, e);
                    }
                
               
            }
        }



        private void btnsup_Click_1(object sender, EventArgs e)
        {
            if (dgvut.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer cette utilité technique ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        foreach (DataGridViewRow r in dgvut.SelectedRows)
                        {
                            string code = (string)r.Cells[0].Value;
                            UT ut = bd.UTs.FirstOrDefault(x => x.NumUT == code);
                            bool utUtilisee = bd.Vehicules.Any(v => v.IdUT == ut.IdUT);

                            if (utUtilisee)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Cette utilité technique est associée à des véhicules et ne peut pas être supprimée.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                bd.UTs.Remove(ut);
                                bd.SaveChanges();
                            }
                        }
                        ListeUT_Load(sender, e);
                    }
                }
            }
        }


        private void btnrecherche_Click(object sender, EventArgs e)
        {
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                string rechercheTexte = txtrecherche.Text.Trim();
                

                
                    dgvut.DataSource = bd.UTs
                        .Where(x => x.NomUT.StartsWith(rechercheTexte) || x.NumUT.ToString().StartsWith(rechercheTexte))
                        .Select(x => new
                        {
                            Code = x.NumUT,
                            Nom = x.NomUT
                        })
                        .ToList();
                
            }


        }

        private void dgvut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvut.SelectedCells.Count > 0)
            {
                int pos = dgvut.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvut.Rows[pos];
                txtcode.Text = selectedRow.Cells["Code"].Value.ToString();
                txtnom.Text = selectedRow.Cells["Nom"].Value.ToString();
                btnsup.Enabled = true;
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            PrintUT printUT = new PrintUT();
            printUT.ShowDialog();
        }
    }
}
