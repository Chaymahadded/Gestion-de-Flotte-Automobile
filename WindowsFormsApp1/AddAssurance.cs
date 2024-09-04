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
    public partial class AddAssurance : MetroFramework.Forms.MetroForm
    {
        
        public AddAssurance()
        {
            InitializeComponent();
        }

        private void AddAssurance_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            cmvehicule.Items.Clear();
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                cmvehicule.Items.AddRange(bd.Vehicules.ToArray());
                cmvehicule.DisplayMember = "Matricule";

            }
        }

        private void btneng_Click(object sender, EventArgs e)
        {
            if (
            datefin.Value <= DateTime.Today ||
            cmvehicule.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    Assurance a = new Assurance();
                    a.DateFin = datefin.Value;
                    a.Num_Vehicule = ((Vehicule)cmvehicule.SelectedItem).NumVehicule;
                    bd.Assurances.Add(a);
                    bd.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Assurance a été ajoutée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datefin.Value = DateTime.Today;
                    cmvehicule.SelectedIndex = -1;
                    AddAssurance_Load(sender, e);
                }
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
    }
}
