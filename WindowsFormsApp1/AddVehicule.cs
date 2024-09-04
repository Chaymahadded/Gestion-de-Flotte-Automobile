using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class AddVehicule : MetroFramework.Forms.MetroForm
    {
        public AddVehicule()
        {
            InitializeComponent();
        }

        private void AddVehicule_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            cmbcat.Items.Clear();
            cmbut.Items.Clear();
            cmbser.Items.Clear();
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                cmbcat.Items.AddRange(bd.Categories.ToArray());
                cmbcat.DisplayMember = "NumCategorie";
                cmbut.Items.AddRange(bd.UTs.ToArray());
                cmbut.DisplayMember = "NumUT";
                cmbser.Items.AddRange(bd.Services.ToArray());
                cmbser.DisplayMember = "NomService";

            }
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnann_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneng_Click(object sender, EventArgs e)
        {
            if (txtage.Text == "" || txtpuissance.Text == "" ||
            txtenergie.Text == "" || txtindex.Text == "" || 
            txtmarque.Text == "" || txtmatricule.Text == "" ||
            txtnbplace.Text == "" || txtnumchas.Text == "" ||
            datedmc.Value > DateTime.Today ||
            cmbcat.SelectedIndex == -1 ||
            cmbser.SelectedIndex == -1 ||
            cmbut.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    if (bd.Vehicules
                    .Where(x => x.Matricule == txtmatricule.Text)
                    .Count() > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Cette véhicule déjà existe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Vehicule v = new Vehicule();
                        v.NumVehicule = GenerateRandomNum(bd);
                        v.Matricule = txtmatricule.Text;
                        v.Marque = txtmarque.Text;
                        v.Puissance = txtpuissance.Text;
                        v.Energie = txtenergie.Text;
                        v.AgeMoyen = txtage.Text;
                        v.DMC = datedmc.Value;
                        v.Num_Chassis = Convert.ToInt32(txtnumchas.Text);
                        v.NombrePlaces = Convert.ToInt32(txtnbplace.Text);
                        v.Index = Convert.ToInt32(txtindex.Text);
                        v.IdCategorie = ((Categorie)cmbcat.SelectedItem).IdCategorie;
                        v.IdService = ((Service)cmbser.SelectedItem).IdService;
                        v.IdUT = ((UT)cmbut.SelectedItem).IdUT;
                        bd.Vehicules.Add(v);
                        bd.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Véhicule a été ajoutée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    txtage.Text = "";
                    datedmc.Value = DateTime.Today;
                    txtenergie.Text = "";
                    txtindex.Text = "";
                    txtmarque.Text = "";
                    txtmatricule.Text = "";
                    txtnbplace.Text = "";
                    txtnumchas.Text = "";
                    txtpuissance.Text = "";
                    cmbcat.SelectedIndex = -1;
                    cmbser.SelectedIndex = -1 ;
                    cmbut.SelectedIndex = -1;
                    AddVehicule_Load(sender, e);
                }
                
            }
        }
        private int GenerateRandomNum(BDGestionVehiculeContext context)
        {
            Random rnd = new Random();
            int num;
            bool exists;
            do
            {
                num = rnd.Next(10000, 100000);
                exists = context.Vehicules.Any(v => v.NumVehicule == num);
            } while (exists);
            return num;
        }
    }
}
