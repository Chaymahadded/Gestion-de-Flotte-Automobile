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
    public partial class EditVignette : MetroFramework.Forms.MetroForm
    {
        public EditVignette(string matricule, DateTime datef)
        {
            InitializeComponent();
            txtvehicule.Text = matricule;
            datep.Value = datef;
        }

        private void EditVignette_Load(object sender, EventArgs e)
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
            datep.Value <= DateTime.Today)
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    int? num_vehicule = bd.Vehicules
    .Where(vh => vh.Matricule == txtvehicule.Text)
    .Select(vh => (int?)vh.NumVehicule)
    .FirstOrDefault();

                    Vignette v = bd.Vignettes
                                .Where(x => x.Num_Vehicule == num_vehicule)
                                .FirstOrDefault();

                    v.DatePV = datep.Value;

                    bd.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Vignette a été modifiée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }
    }
}
