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
    public partial class EditVT : MetroFramework.Forms.MetroForm
    {
        public EditVT(string matricule, DateTime dateV, DateTime dateprv, string montant)
        {
            InitializeComponent();
            txtvehicule.Text = matricule;
            txtmontant.Text = montant;
            datev.Value = dateV;
            datepv.Value = dateprv;
        }

        private void EditVT_Load(object sender, EventArgs e)
        {

        }

        private void btneng_Click(object sender, EventArgs e)
        {
            if (txtmontant.Text == "" ||
            datev.Value > DateTime.Today ||
            datepv.Value <= DateTime.Today )
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    decimal m = Convert.ToDecimal(txtmontant.Text, CultureInfo.InvariantCulture);
                    int? num_vehicule = bd.Vehicules
    .Where(v => v.Matricule == txtvehicule.Text)
    .Select(v => (int?)v.NumVehicule)
    .FirstOrDefault();

                    VisiteTechnique vt = bd.VisiteTechniques
                                .Where(x => x.Num_Vehicule == num_vehicule)
                                .FirstOrDefault();
                    vt.DateVisite = datev.Value;
                    vt.DatePV = datepv.Value;
                    vt.MontantTotale = m;
                    bd.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Visite technique a été modifiée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
