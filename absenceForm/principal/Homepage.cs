using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using absenceClass;

namespace absenceForm.principal
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        void DisplayContent(Control cn)
        {
            ajouterUser1.Visible = false;
            passwordControl1.Visible = false;
            ajouterAbsence1.Visible = false;
            absenceControl1.Visible = false;
            autorisationControl1.Visible = false;
            cn.Visible = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DisplayContent(ajouterUser1);
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment déconnecter ?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                new Form1().Show();
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            label1.Text = Class1.UserA;
            label1.Visible = true;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            DisplayContent(passwordControl1);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DisplayContent(ajouterAbsence1);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            DisplayContent(absenceControl1);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            DisplayContent(autorisationControl1);
        }
    }
}
