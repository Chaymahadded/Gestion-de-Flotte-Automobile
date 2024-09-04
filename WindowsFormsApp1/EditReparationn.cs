using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditReparationn : MetroFramework.Forms.MetroForm
    {
        public EditReparationn(string matricule, DateTime dateRep, string designation, string quantite, string montant, string prix)
        {
            InitializeComponent();
            txtvehicule.Text = matricule;
            txtmontant.Text = montant;
            daterep.Value = dateRep;
            txtdesg.Text = designation;
            txtprix.Text = prix;
            txtqte.Text = quantite;
        }

            private void EditReparationn_Load(object sender, EventArgs e)
        {

        }

        private void btneng_Click(object sender, EventArgs e)
        {
            if (txtdesg.Text == "" ||
                          txtprix.Text == "" ||
                            txtqte.Text == "" ||
                      daterep.Value > DateTime.Today )
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    decimal m = Convert.ToDecimal(txtmontant.Text, CultureInfo.InvariantCulture);
                    decimal p = Convert.ToDecimal(txtprix.Text, CultureInfo.InvariantCulture);
                    int? num_vehicule = bd.Vehicules
                                         .Where(v => v.Matricule == txtvehicule.Text)
                                         .Select(v => (int?)v.NumVehicule)
                                         .FirstOrDefault();
                    Reparation r = bd.Reparations
                                .Where(x => x.Num_Vehicule == num_vehicule)
                                .FirstOrDefault();
                    r.DateReparation = daterep.Value;
                    r.Designation = txtdesg.Text;
                    r.MontantTotale = m;
                    r.Prix = p;
                    r.Quantite = txtqte.Text;
                    bd.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Réparation a été ajoutée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditReparationn_Load(sender, e);
                }
            }
            }

        private void txtprix_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtqte_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            if (!string.IsNullOrEmpty(txtprix.Text) && !string.IsNullOrEmpty(txtqte.Text) &&
                decimal.TryParse(txtprix.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal prix) &&
                decimal.TryParse(txtqte.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal qte))
            {
                decimal montantTotal = prix * qte;
                txtmontant.Text = montantTotal.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                txtmontant.Text = "";
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
