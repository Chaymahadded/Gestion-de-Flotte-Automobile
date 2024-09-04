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
    public partial class EditEntretien : MetroFramework.Forms.MetroForm
    {
        public EditEntretien(string matricule,string index,string type)
        {
            InitializeComponent();
            txtvehicule.Text = matricule;
            txtindex.Text = index;
            txttype.Text = type;
        }

        private void EditEntretien_Load(object sender, EventArgs e)
        {

        }

        private void btneng_Click(object sender, EventArgs e)
        {
            if (
                txtindex.Text == "" ||
                txttype.Text == "" 
)
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    int index = Convert.ToInt32(txtindex.Text);
                    int? num_vehicule = bd.Vehicules
                                        .Where(v => v.Matricule == txtvehicule.Text)
                                        .Select(v => (int?)v.NumVehicule)
                                        .FirstOrDefault();
                    Entretien en = bd.Entretiens
                                .Where(x => x.Num_Vehicule == num_vehicule)
                                .FirstOrDefault();
                    en.TypeEntretien = txttype.Text;
                    en.Kilometrage = index;
                    bd.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, en.TypeEntretien + " a été modifiée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        private void btnann_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
