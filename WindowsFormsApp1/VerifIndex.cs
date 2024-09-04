using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VerifIndex : MetroFramework.Forms.MetroForm
    {
        private string Matricule;

        public VerifIndex(string matricule,string index)
        {
            InitializeComponent();
            txtindex.Text = index;
            Matricule = matricule;
        }

        private void VerifIndex_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnverif_Click(object sender, EventArgs e)
        {
            int nouvelIndex = 0;
            if (int.TryParse(txtindex.Text, out nouvelIndex))
            {
                string entretien = GetEntretienForSelectedVehicle(Matricule);
                int indexEntretien = GetIndexEntretienForSelectedVehicle(Matricule);
                int indexVehicule = GetIndexForSelectedVehicle(Matricule);
                string matricule = GetMatricule(Matricule);

                if (nouvelIndex > indexEntretien+indexVehicule)
                {
                    MetroFramework.MetroMessageBox.Show(this, "L'index du véhicule "+matricule+" a dépassé l'index de l'entretien " + entretien, "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pas d'entretien", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int GetIndexEntretienForSelectedVehicle(string matricule)
        {
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                var vehicule = bd.Vehicules.FirstOrDefault(v => v.Matricule == matricule);
                if (vehicule != null)
                {
                    var entretien = bd.Entretiens.FirstOrDefault(ent => ent.Num_Vehicule == vehicule.NumVehicule);
                    return (int)(entretien != null ? entretien.Kilometrage : 0);
                }
                return 0;
            }
        }
        private int GetIndexForSelectedVehicle(string matricule)
        {
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                var vehicule = bd.Vehicules.FirstOrDefault(v => v.Matricule == matricule);
                if (vehicule != null)
                {
                    var index = Convert.ToInt32(vehicule.Index);
                    return (int)(index != 0 ? index : 0);
                }
                return 0;
            }
        }
        private string GetEntretienForSelectedVehicle(string matricule)
        {
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                var vehicule = bd.Vehicules.FirstOrDefault(v => v.Matricule == matricule);
                if (vehicule != null)
                {
                    var entretien = bd.Entretiens.FirstOrDefault(ent => ent.Num_Vehicule == vehicule.NumVehicule);
                    return (entretien != null ? entretien.TypeEntretien : null);
                }
                return null;
            }
        }
        private string GetMatricule(string matricule)
        {
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                var mat = matricule;
                if (mat != null)
                {
                    
                    return mat;
                }
                return null;
            }
        }

        private void btnann_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
