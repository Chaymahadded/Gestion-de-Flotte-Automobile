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
    public partial class AddVT : MetroFramework.Forms.MetroForm
    {
        public AddVT()
        {
            InitializeComponent();
        }

        private void AddVT_Load(object sender, EventArgs e)
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

        private void btneng_Click(object sender, EventArgs e)
        {
            if (txtmontant.Text == "" || 
            datev.Value > DateTime.Today ||
            datepv.Value <= DateTime.Today ||
            cmvehicule.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    decimal m = Convert.ToDecimal(txtmontant.Text, CultureInfo.InvariantCulture);
                    VisiteTechnique v = new VisiteTechnique();
                        v.DateVisite = datev.Value;
                        v.DatePV = datepv.Value;
                        v.MontantTotale = m;
                        v.Num_Vehicule = ((Vehicule)cmvehicule.SelectedItem).NumVehicule;
                        bd.VisiteTechniques.Add(v);
                        bd.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Visite technique a été ajoutée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtmontant.Text = "";
                        datev.Value = DateTime.Today;
                        datepv.Value = DateTime.Today;
                        cmvehicule.SelectedIndex = -1;
                        AddVT_Load(sender, e);
                }

            }
        
    }

        private void btnann_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmvehicule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datev_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datepv_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
