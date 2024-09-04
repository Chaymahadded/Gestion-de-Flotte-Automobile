using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RepVehicule : MetroFramework.Forms.MetroForm
    {
        private int numVehicule;
        public RepVehicule(int num)
        {
            InitializeComponent();
            this.numVehicule = num;
        }

        private void RepVehicule_Load(object sender, EventArgs e)
        {
            
            
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
            {
                dgvrepv.DataSource = null;
                dgvrepv.DataSource = bd.Reparations
                    .Where(rep => rep.Num_Vehicule == numVehicule)
                    .Select(
                    x => new
                    {

                        DateReparation = x.DateReparation,
                        Designation =x.Designation,
                        Prix = x.Prix,
                        Quantité = x.Quantite,
                       MontantTotale = x.MontantTotale
                    }
                    )
                .ToList();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            Printrep printrep = new Printrep(numVehicule);
            printrep.ShowDialog();
        }
    }
}
