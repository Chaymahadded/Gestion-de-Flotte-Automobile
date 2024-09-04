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
    public partial class AddReparation : MetroFramework.Forms.MetroForm
    {
        public AddReparation()
        {
            InitializeComponent();
        }

        private void AddReparation_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            cmvehicule.Items.Clear();
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                cmvehicule.Items.AddRange(bd.Vehicules.ToArray());
                cmvehicule.DisplayMember = "Matricule";

            }
            txtmontant.Text = "";
            
        }

        private void btneng_Click(object sender, EventArgs e)
        {
            if (txtdesg.Text == "" ||
                           txtprix.Text == "" ||
                             txtqte.Text == "" ||
                       daterep.Value > DateTime.Today ||
                       cmvehicule.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    decimal m = Convert.ToDecimal(txtmontant.Text, CultureInfo.InvariantCulture);
                    decimal p = Convert.ToDecimal(txtprix.Text, CultureInfo.InvariantCulture);
                    Reparation r = new Reparation();
                    r.DateReparation = daterep.Value;
                    r.Designation = txtdesg.Text;
                    r.MontantTotale = m;
                    r.Prix = p;
                    r.Quantite = txtqte.Text;
                    r.Num_Vehicule = ((Vehicule)cmvehicule.SelectedItem).NumVehicule;
                    bd.Reparations.Add(r);
                    bd.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this,"Réparation a été ajoutée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmontant.Text = "";
                    txtdesg.Text = "";
                    txtprix.Text = "";
                    txtqte.Text = "";
                    daterep.Value = DateTime.Today;
                    cmvehicule.SelectedIndex = -1;
                    AddReparation_Load(sender, e);
                }
            }
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtqte_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtprix_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnann_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
