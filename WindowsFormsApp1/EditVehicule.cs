using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditVehicule : MetroFramework.Forms.MetroForm
    {
        public EditVehicule(string matricule, string marque, string puissance, string energie, DateTime dmc, string numeroChassis, string nombrePlace, string ageMoyen, string index, string categorie, string affectation, string ut)
        {
            InitializeComponent();
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
            txtmatricule.Text = matricule;
            txtmarque.Text = marque;
            txtpuissance.Text = puissance;
            txtenergie.Text = energie;
            datedmc.Value = dmc;
            txtnumchas.Text = numeroChassis;
            txtnbplace.Text = nombrePlace;
            txtage.Text = ageMoyen;
            txtindex.Text = index;
            RemplirComboBox(cmbcat, categorie);
            RemplirComboBox(cmbser, affectation);
            RemplirComboBox(cmbut, ut);
        }
        private void RemplirComboBox(ComboBox comboBox, string valeur)
        {
          
            int index = comboBox.FindStringExact(valeur);
            if (index != -1)
            {
                comboBox.SelectedIndex = index;
            }
            else
            {
                comboBox.Items.Add(valeur);
                comboBox.SelectedIndex = comboBox.Items.Count - 1;
            }
        }

        private void EditVehicule_Load(object sender, EventArgs e)
        {
            
            
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
                    Vehicule v = bd.Vehicules
                                .Where(x => x.Matricule == txtmatricule.Text)
                                .FirstOrDefault();
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
                        bd.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Véhicule a été modifiée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                }
            }
                }
    }
}
