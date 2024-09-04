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
    public partial class ListeService : MetroFramework.Forms.MetroForm
    {
        public ListeService()
        {
            InitializeComponent();
        }

        private void ListeService_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
                dgvservice.DataSource = null;
                dgvservice.DataSource = bd.Services.Select(
                    x => new
                    {
                        Code = x.NumService,
                        Nom = x.NomService,

                    }
                    )
                .ToList();
            }
            btnsup.Enabled = false;
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
                        if (bd.Services.Where(x => x.NumService == code).Count() > 0)
                        {
                            if (bd.Services.Where(x => x.NomService == txtnom.Text).Count() > 0)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Ce Service déjà exist.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                Service s = bd.Services
                                    .Where(x => x.NumService == code)
                                    .FirstOrDefault();
                                s.NomService = txtnom.Text;
                                bd.SaveChanges();
                            }
                        }
                        else if (bd.Services.Where(x => x.NomService == txtnom.Text).Count() > 0)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Ce Service déjà exist.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Service s = new Service();
                            s.NumService = code;
                            s.NomService = txtnom.Text;
                            bd.Services.Add(s);
                            bd.SaveChanges();

                            MetroFramework.MetroMessageBox.Show(this, "Service a été ajouté avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        txtcode.Text = "";
                        txtnom.Text = "";
                        ListeService_Load(sender, e);
                    }
                }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            if (dgvservice.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer ce service ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                    {
                        foreach (DataGridViewRow r in dgvservice.SelectedRows)
                        {
                            string code = (string)r.Cells[0].Value;
                            Service s = bd.Services.FirstOrDefault(x => x.NumService == code);

                            bool serviceUtilise = bd.Vehicules.Any(v => v.IdService == s.IdService);

                            if (serviceUtilise)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Ce service est associé à des véhicules et ne peut pas être supprimé.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                bd.Services.Remove(s);
                                bd.SaveChanges();
                            }
                        }
                        ListeService_Load(sender, e);
                    }
                }
            }
        }


        private void btnrecherche_Click(object sender, EventArgs e)
        {
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                string rechercheTexte = txtrecherche.Text.Trim();
               
                    dgvservice.DataSource = bd.Services
                        .Where(x => x.NomService.StartsWith(rechercheTexte) || x.NumService.ToString().StartsWith(rechercheTexte))
                        .Select(x => new
                        {
                            Code = x.NumService,
                            Nom = x.NomService
                        })
                        .ToList();
                

            }
        }

        private void dgvservice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvservice.SelectedCells.Count > 0)
            {
                int pos = dgvservice.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvservice.Rows[pos];
                txtcode.Text = selectedRow.Cells["Code"].Value.ToString();
                txtnom.Text = selectedRow.Cells["Nom"].Value.ToString();
                btnsup.Enabled = true;
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            PrintSer printSer = new PrintSer();
            printSer.ShowDialog();
        }
    }
    }

