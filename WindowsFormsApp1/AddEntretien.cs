using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddEntretien : MetroFramework.Forms.MetroForm
    {
       
        public AddEntretien()
        {
            InitializeComponent();
        }

        private void AddEntretien_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            cmvehicule.Items.Clear();
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                cmvehicule.Items.AddRange(bd.Vehicules.ToArray());
                cmvehicule.DisplayMember = "Matricule";

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
            if (
                txtindex.Text == "" ||
                txttype.Text == "" ||
            cmvehicule.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    int index = Convert.ToInt32(txtindex.Text);
                    Entretien en = new Entretien();
                    en.TypeEntretien = txttype.Text;
                    en.Kilometrage = index;
                    en.Num_Vehicule = ((Vehicule)cmvehicule.SelectedItem).NumVehicule;
                    bd.Entretiens.Add(en);
                    bd.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, en.TypeEntretien+" a été ajoutée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtindex.Text = "";
                txttype.Text = "";
                    cmvehicule.SelectedIndex = -1;
                    AddEntretien_Load(sender, e);
                }
            }
        }


    }
}
