using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using absenceClass;
namespace absenceForm.principal.Controls
{
    public partial class passwordControl : UserControl
    {
        public passwordControl()
        {
            InitializeComponent();
        }
        Entity.DataClasses1DataContext ent = new Entity.DataClasses1DataContext();
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtNv.Clear();
            txtCfr.Clear();
        }
        void changerPass()
        {
            try
            {
                int i = 0;
                if (txtNv.Text == txtCfr.Text)
                {
                    Entity.administrateur adm1 = ent.administrateur.FirstOrDefault(x => x.userA == Class1.UserA);
                    var admins = from adm in ent.administrateur
                                 select adm;
                    foreach (var v in admins)
                    {
                        if ((v.userA == Class1.UserA) && (v.passwordA == txtPass.Text))
                        {
                            i++;
                            adm1.passwordA = txtNv.Text;
                            ent.SubmitChanges();
                            MessageBox.Show("Le mot de passe a été modifié avec succès");
                            break;
                        }
                    }
                    if (i == 0)
                    {
                        MessageBox.Show("Le mot de passe actuel est incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("Le nouveau mot de passe n'est pas confirmé");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            changerPass();
            
            
        }

        private void displayEye1_Click(object sender, EventArgs e)
        {
            displayEye1.Visible = false;
            hideEye1.Visible = true;
            txtPass.UseSystemPasswordChar = true;
        }

        private void hideEye1_Click(object sender, EventArgs e)
        {
            displayEye1.Visible = true;
            hideEye1.Visible = false;
            txtPass.UseSystemPasswordChar = false;
        }

        private void displayEye2_Click(object sender, EventArgs e)
        {
            displayEye2.Visible = false;
            hideEye2.Visible = true;
            txtNv.UseSystemPasswordChar = true;
        }

        private void hideEye2_Click(object sender, EventArgs e)
        {
            displayEye2.Visible = true;
            hideEye2.Visible = false;
            txtNv.UseSystemPasswordChar = false;
        }

        private void displayEye3_Click(object sender, EventArgs e)
        {
            displayEye3.Visible = false;
            hideEye3.Visible = true;
            txtCfr.UseSystemPasswordChar = true;
        }

        private void hideEye3_Click(object sender, EventArgs e)
        {
            displayEye3.Visible = true;
            hideEye3.Visible = false;
            txtCfr.UseSystemPasswordChar = false;
        }

        private void passwordControl_Load(object sender, EventArgs e)
        {

        }

        private void txtCfr_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                changerPass();
            }
        }

        private void txtNv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changerPass();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changerPass();
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtNv_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
