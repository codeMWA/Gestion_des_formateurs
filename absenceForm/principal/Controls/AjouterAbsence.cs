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

namespace absenceForm.principal.Controls
{
    public partial class AjouterAbsence : UserControl
    {
        Entity.DataClasses1DataContext ent = new Entity.DataClasses1DataContext();
        public AjouterAbsence()
        {
            InitializeComponent();
            RemplirCB1();
        }
        void ClearTexts()
        {
            txtAbs.Clear();
            txtJust.Clear();
            txtJoursJust.Clear();
        }

        void RemplirCB1()
        {
            try
            {
                var formateurs = from fr in ent.formateur
                                 select fr;
                nomCb1.DataSource = formateurs.ToList();
                nomCb1.DisplayMember = "nom";
                nomCb1.ValueMember = "cin";
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }
        void RemplirDGV()
        {
            try
            {
                gunaDataGridView1.Rows.Clear();
                var absences1 = from abs in ent.absence
                                select abs;
                foreach (var v in absences1)
                {
                    if (v.cin == nomCb1.SelectedValue.ToString())
                    {
                        gunaDataGridView1.Rows.Add(v.heures_absence, v.justification, v.heures_justifiés, v.dateDebut, v.dateFin, v.code_abs);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private void AjouterAbsence_Load(object sender, EventArgs e)
        {
            
            RemplirCB1();
        }

        private void nomCb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClearTexts();
                RemplirDGV();
                Double ab = Convert.ToDouble(ent.absence.Where(a => a.cin == nomCb1.SelectedValue.ToString()).Select(x => x.heures_absence).Sum());
                totalAbs.Text = ab.ToString();
                totalAbs.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Entity.absence abs = new Entity.absence();
                abs.cin = nomCb1.SelectedValue.ToString();
                abs.heures_absence = Convert.ToDecimal(txtAbs.Text);
                abs.dateDebut = Ddebut.Text;
                abs.dateFin = Dfin.Text;
                abs.justification = txtJust.Text;
                abs.heures_justifiés = Convert.ToDecimal(txtJoursJust.Text);
                ent.absence.InsertOnSubmit(abs);
                ent.SubmitChanges();
                ClearTexts();
                totalAbs.Visible = false;
                RemplirDGV();
                MessageBox.Show("Absence ajoutée avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Entity.absence abs1 = ent.absence.FirstOrDefault(x => x.code_abs == Class1.codeA);
                abs1.heures_absence = Convert.ToDecimal(txtAbs.Text);
                abs1.dateDebut = Ddebut.Text;
                abs1.dateFin = Dfin.Text;
                abs1.justification = txtJust.Text;
                abs1.heures_justifiés = Convert.ToDecimal(txtJoursJust.Text);
                ent.SubmitChanges();
                ClearTexts();
                totalAbs.Visible = false;
                RemplirDGV();
                MessageBox.Show("L'absence a été modifiée avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                try
                {
                    Class1.codeA = Convert.ToInt32(gunaDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet élément ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult.Yes == dialogResult)
                    {
                        Entity.absence abs2 = ent.absence.FirstOrDefault(a => a.code_abs == Class1.codeA);
                        ent.absence.DeleteOnSubmit(abs2);
                        ent.SubmitChanges();
                        MessageBox.Show("Absence supprimée avec succès");
                        ClearTexts();
                        RemplirDGV();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
               
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Class1.codeA = Convert.ToInt32(gunaDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                var absences = from abs in ent.absence
                               select abs;
                foreach (var v in absences)
                {
                    if (v.code_abs == Class1.codeA)
                    {
                        txtAbs.Text = v.heures_absence.ToString();
                        txtJust.Text = v.justification.ToString();
                        txtJoursJust.Text = v.heures_justifiés.ToString();
                        Ddebut.Text = v.dateDebut;
                        Dfin.Text = v.dateFin;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
