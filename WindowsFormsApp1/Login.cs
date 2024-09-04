using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {

            InitializeComponent();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            txtpwd.UseSystemPasswordChar = true;
        }



        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnconnexion_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpwd.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {

                    if (bd.Users
                    .Where(x => x.UserName == txtusername.Text && x.Password ==txtpwd.Text)
                    .Count() > 0)
                    {
                        txtusername.Text = "";
                        txtpwd.Text = "";
                        Home h = new Home();
                        this.Hide();
                        h.ShowDialog();
                        
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Nom utilisateur ou mot de passe et incorrecte ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
            }
            
        }

        private void pwdoublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MotDePasseOublie md = new MotDePasseOublie();
            md.ShowDialog();
        }

        private void creercompte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registre r = new Registre();
            r.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtpwd.UseSystemPasswordChar = !txtpwd.UseSystemPasswordChar;
            bool isPasswordVisible = !txtpwd.UseSystemPasswordChar;

            if (isPasswordVisible)
            {
                pictureBox5.Image = Properties.Resources.eye_open;
            }
            else
            {
                pictureBox5.Image = Properties.Resources.eye_closed;
            }

            isPasswordVisible = !isPasswordVisible;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
