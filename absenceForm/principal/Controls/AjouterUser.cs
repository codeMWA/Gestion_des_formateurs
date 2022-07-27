using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace absenceForm.principal.Controls
{
    public partial class AjouterUser : UserControl
    {
        public AjouterUser()
        {
            InitializeComponent();
        }
        Entity.DataClasses1DataContext entit = new Entity.DataClasses1DataContext();
        void RemplirDGV()
        {
            try
            {
                gunaDataGridView1.Rows.Clear();
                var formateurs0 = from fr in entit.formateur
                                  select fr;
                foreach (var v in formateurs0)
                {
                    gunaDataGridView1.Rows.Add(v.cin, v.nom, v.prenom, v.tele);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        void RempliCBX()
        {
            try
            {
                gunaComboBox1.Items.Clear();
                var formateurs = from fr in entit.formateur
                                 select fr;
                foreach (var v in formateurs)
                {
                    gunaComboBox1.Items.Add(v.nom);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }
        void ClearTexts()
        {
            txtCin.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtTele.Clear();
        }
        private void AjouterUser_Load(object sender, EventArgs e)
        {          
            RemplirDGV();
            RempliCBX();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Entity.formateur forma = new Entity.formateur();
                forma.cin = txtCin.Text;
                forma.nom = txtNom.Text;
                forma.prenom = txtPrenom.Text;
                forma.tele = txtTele.Text;
                entit.formateur.InsertOnSubmit(forma);
                entit.SubmitChanges();
                ClearTexts();
                MessageBox.Show("Le formateur a été ajouté avec succès");
                RemplirDGV();
                RempliCBX();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Entity.formateur forma1 = entit.formateur.First(x => x.nom == gunaComboBox1.Text);
                forma1.cin = txtCin.Text;
                forma1.nom = txtNom.Text;
                forma1.prenom = txtPrenom.Text;
                forma1.tele = txtTele.Text;
                entit.SubmitChanges();
                ClearTexts();
                MessageBox.Show("Le formateur a été modifié avec succès");
                RemplirDGV();
                RempliCBX();
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var formateurs1 = from fr in entit.formateur
                                  select fr;
                foreach (var v in formateurs1)
                {
                    if (v.nom == gunaComboBox1.Text)
                    {
                        txtCin.Text = v.cin;
                        txtNom.Text = v.nom;
                        txtPrenom.Text = v.prenom;
                        txtTele.Text = v.tele;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.ColumnIndex == 4)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer ce formateur!", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult.Yes == dialogResult)
                    {
                        Entity.formateur forma2 = entit.formateur.First(x => x.cin == gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                        entit.formateur.DeleteOnSubmit(forma2);
                        entit.SubmitChanges();
                        ClearTexts();
                        MessageBox.Show("Le formateur a été supprimé avec succès");
                        RemplirDGV();
                        RempliCBX();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
