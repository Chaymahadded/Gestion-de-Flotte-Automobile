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
    public partial class Registre : MetroFramework.Forms.MetroForm
    {
        public Registre()
        {
            InitializeComponent();
        }

        private void Registre_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        
            txtpwd.UseSystemPasswordChar = true;
            txtcpwd.UseSystemPasswordChar = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncreer_Click(object sender, EventArgs e)
        {
            if (txtusename.Text == "" || txtpwd.Text == "" || txtcpwd.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtpwd.Text != txtcpwd.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Les mots de passe que vous avez saisis ne correspondent pas. Veuillez vérifier et réessayer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {

                    if (bd.Users
                    .Where(x => x.UserName == txtusename.Text)
                    .Count() > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Le nom d'User que vous avez saisi est déjà utilisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        User u = new User();
                        u.UserName = txtusename.Text;
                        u.Password = txtpwd.Text;
                        u.CleRecuperation = GenerateRandomKey(bd);
                        bd.Users.Add(u);
                        bd.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Gardez votre clé de récupération : " + u.CleRecuperation, "Clé de récupération", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 
                    txtusename.Text = "";
                    txtpwd.Text = "";
                    txtcpwd.Text = "";
                    this.Close();
                }
            }
        }
        private int GenerateRandomKey(BDGestionVehiculeContext context)
        {
            Random rnd = new Random();
            int key;
            bool exists;
            do
            {
                key = rnd.Next(1000, 10000);
                exists = context.Users.Any(u => u.CleRecuperation == key);
            } while (exists);
            return key;
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            txtcpwd.UseSystemPasswordChar = !txtcpwd.UseSystemPasswordChar;
            bool isPasswordVisible = !txtcpwd.UseSystemPasswordChar;

            if (isPasswordVisible)
            {
                pictureBox6.Image = Properties.Resources.eye_open;
            }
            else
            {
                pictureBox6.Image = Properties.Resources.eye_closed;
            }

            isPasswordVisible = !isPasswordVisible;
        }
    }
}
