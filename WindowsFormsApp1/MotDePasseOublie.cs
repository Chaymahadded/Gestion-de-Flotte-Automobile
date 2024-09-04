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
    public partial class MotDePasseOublie : MetroFramework.Forms.MetroForm
    {
        public MotDePasseOublie()
        {
            InitializeComponent();
        }

        private void MotDePasseOublie_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            txtpwd.UseSystemPasswordChar = true;
            txtcpwd.UseSystemPasswordChar = true;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if (txtclerec.Text == "" || txtpwd.Text == "" || txtcpwd.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BDGestionVehiculeContext bd = new BDGestionVehiculeContext())
                {
                    int cleRecuperation = Convert.ToInt32(txtclerec.Text);
                    if (bd.Users
                    .Where(x => x.CleRecuperation == cleRecuperation)
                    .Count() > 0)
                    {
                        if (txtpwd.Text != txtcpwd.Text)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Les mots de passe que vous avez saisis ne correspondent pas. Veuillez vérifier et réessayer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            User u = bd.Users
                                .Where(x => x.CleRecuperation == cleRecuperation)
                                .FirstOrDefault();
                            u.Password = txtpwd.Text;
                            bd.SaveChanges();
                            txtclerec.Text = "";
                            txtpwd.Text = "";
                            txtcpwd.Text = "";
                            MetroFramework.MetroMessageBox.Show(this, "Votre mot de passe a été changé avec succès. Gardez-le en sécurité !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MotDePasseOublie_Load(sender, e);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Veuillez vérifier votre clé de récupération", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

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
