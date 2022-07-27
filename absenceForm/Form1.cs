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
using System.Data.SqlClient;


namespace absenceForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Utilisateur")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.DimGray;
                textBox1.Text = "Utilisateur";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mot de passe")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.DimGray;
                textBox2.Text = "Mot de passe";
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void HideEye_Click(object sender, EventArgs e)
        {
            DisplayEye.Visible = true;
            HideEye.Visible = false;
            textBox2.UseSystemPasswordChar = false;
        }

        private void DisplayEye_Click(object sender, EventArgs e)
        {
            DisplayEye.Visible = false;
            HideEye.Visible = true;
            textBox2.UseSystemPasswordChar = true;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void login()
        {
            Class1.adapt = new SqlDataAdapter("select * from administrateur", Class1.cnx);
            Class1.ds.Clear();
            Class1.adapt.Fill(Class1.ds, "admin");
            int t = 0;
            for (int i = 0; i < Class1.ds.Tables["admin"].Rows.Count; i++)
            {
                if ((Class1.ds.Tables["admin"].Rows[i][0].ToString() == textBox1.Text) && (Class1.ds.Tables["admin"].Rows[i][1].ToString() == textBox2.Text))
                {
                    Class1.UserA = textBox1.Text;
                    new principal.Homepage().Show();
                    this.Hide();
                    t++;
                    break;
                }
            }
            if (t == 0)
            {
                MessageBox.Show("Le mot de passe est incorrect");
            }
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
