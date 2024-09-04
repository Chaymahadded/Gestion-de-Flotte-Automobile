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
    public partial class EditAssurance : MetroFramework.Forms.MetroForm
    {
        public EditAssurance(string matricule, DateTime datef)
        {
            InitializeComponent();
            txtvehicule.Text = matricule;
            datefin.Value = datef;
        }

        private void EditAssurance_Load(object sender, EventArgs e)
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
            if (
            
            datefin.Value <= DateTime.Today)
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    int? num_vehicule = bd.Vehicules
    .Where(v => v.Matricule == txtvehicule.Text)
    .Select(v => (int?)v.NumVehicule)
    .FirstOrDefault();

                    Assurance a = bd.Assurances
                                .Where(x => x.Num_Vehicule == num_vehicule)
                                .FirstOrDefault();
                    a.DateFin = datefin.Value;
                    bd.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Assurance a été modifiée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }
    }
}
