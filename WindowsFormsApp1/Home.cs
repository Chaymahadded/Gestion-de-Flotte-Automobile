using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            MaximizeBox = false;
            listBox.Items.Clear();
            using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())

            {
               
                var vehicules = bd.Vehicules.ToList();

                if (vehicules.Any())
                {
                    string nbvehicule = vehicules.Count().ToString();
                    nb.Text = nbvehicule;

                    double moyenneAgeMoyen = vehicules.Select(x => Convert.ToDouble(x.AgeMoyen)).Average();
                    age.Text = moyenneAgeMoyen.ToString("F2");
                }
                else
                {
                    age.Text = "0";
                }
                DateTime dateActuelle = DateTime.Today;
                DateTime dateAlerte = dateActuelle.AddDays(2);
                var assurance = bd.Assurances
                    .Where(v => v.DateFin >= dateActuelle && v.DateFin <= dateAlerte)
                    .ToList();
                foreach (var a in assurance)
                {
                    listBox.Items.Add($"Alerte : L'assurance du véhicule {a.Num_Vehicule} se termine le {a.DateFin.Value.ToShortDateString()}");
                }
                var visite = bd.VisiteTechniques
                    .Where(v => v.DatePV >= dateActuelle && v.DatePV <= dateAlerte)
                    .ToList();
                foreach (var v in visite)
                {
                    listBox.Items.Add($"Alerte : Visite technique du véhicule {v.Num_Vehicule} est le {v.DatePV.Value.ToShortDateString()}");
                }
                var vignette = bd.Vignettes
                    .Where(v => v.DatePV >= dateActuelle && v.DatePV <= dateAlerte)
                    .ToList();
                foreach (var v in vignette)
                {
                    listBox.Items.Add($"Alerte : Payement des vignette du véhicule {v.Num_Vehicule} est le {v.DatePV.Value.ToShortDateString()}");
                }
                
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnvehicule_Click(object sender, EventArgs e)
        {
            ListeVehicule listeVehicule = new ListeVehicule();
            listeVehicule.ShowDialog();
            Home_Load(sender, e);
            
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            ListeCategorie listeCategorie = new ListeCategorie();
            listeCategorie.ShowDialog();
            Home_Load(sender, e);

        }

        private void btnut_Click(object sender, EventArgs e)
        {
            ListeUT listeUT = new ListeUT();    
            listeUT.ShowDialog();
            Home_Load(sender, e);

        }

        private void btnser_Click(object sender, EventArgs e)
        {
            ListeService listeService = new ListeService();
            listeService.ShowDialog();
            Home_Load(sender, e);

        }

        private void btnvt_Click(object sender, EventArgs e)
        {
            ListeVisiteTechnique listeVisiteTechnique = new ListeVisiteTechnique();
            listeVisiteTechnique.ShowDialog();
            Home_Load(sender, e);

        }

        private void btnasssu_Click(object sender, EventArgs e)
        {
            ListeAssurance listeAssurance = new ListeAssurance();
            listeAssurance.ShowDialog();
            Home_Load(sender, e);

        }

        private void btnvignette_Click(object sender, EventArgs e)
        {
            ListeVignette listeVignette = new ListeVignette();
            listeVignette.ShowDialog();
            Home_Load(sender, e);

        }

        private void btndeco_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnentre_Click(object sender, EventArgs e)
        {
            ListeEntretien listeEntretien = new ListeEntretien();
            listeEntretien.ShowDialog();
            Home_Load(sender, e);

        }

        private void btnrep_Click(object sender, EventArgs e)
        {
            ListReparation listReparation = new ListReparation();
            listReparation.ShowDialog();
            Home_Load(sender, e);

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
