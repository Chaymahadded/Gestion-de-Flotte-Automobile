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
    public partial class AddVignette : MetroFramework.Forms.MetroForm
    {
        public AddVignette()
        {
            InitializeComponent();
        }

        private void AddVignette_Load(object sender, EventArgs e)
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
            datep.Value <= DateTime.Today ||
            cmvehicule.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    Vignette v = new Vignette();
                    v.DatePV = datep.Value;
                    v.Num_Vehicule = ((Vehicule)cmvehicule.SelectedItem).NumVehicule;
                    bd.Vignettes.Add(v);
                    bd.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Vignette a été ajoutée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datep.Value = DateTime.Today;
                    cmvehicule.SelectedIndex = -1;
                    AddVignette_Load(sender, e);
                }
            }
        }
    }
}
