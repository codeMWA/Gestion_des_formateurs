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
    public partial class absenceControl : UserControl
    {
        public absenceControl()
        {
            InitializeComponent();
            RemplirCB1();
        }
        Entity.DataClasses1DataContext ent = new Entity.DataClasses1DataContext();
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
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }
        void RemplirDGV()
        {
            try
            {
                dataGridView1.Rows.Clear();
                var absences1 = from abs in ent.absence
                                join fr in ent.formateur
                                on abs.cin equals fr.cin
                                select new
                                {
                                    cin = abs.cin,
                                    nom = fr.nom,
                                    prenom = fr.prenom,
                                    joursAbs = abs.heures_absence,
                                    just = abs.justification,
                                    jourJst = abs.heures_justifiés,
                                    Debu = abs.dateDebut,
                                    fin = abs.dateFin
                                };
                foreach (var v in absences1)
                {
                    if (v.cin == nomCb1.SelectedValue.ToString())
                    {
                        dataGridView1.Rows.Add(v.nom, v.prenom, v.joursAbs, v.just, v.jourJst, v.Debu, v.fin);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
           
        }
        void RemplirDGVS()
        {
            try
            {
                dataGridView1.Rows.Clear();
                var absences1 = from abs in ent.absence
                                join fr in ent.formateur
                                on abs.cin equals fr.cin
                                select new
                                {
                                    cin = abs.cin,
                                    nom = fr.nom,
                                    prenom = fr.prenom,
                                    joursAbs = abs.heures_absence,
                                    just = abs.justification,
                                    jourJst = abs.heures_justifiés,
                                    Debu = abs.dateDebut,
                                    fin = abs.dateFin
                                };
                foreach (var v in absences1)
                {
                    dataGridView1.Rows.Add(v.nom, v.prenom, v.joursAbs, v.just, v.jourJst, v.Debu, v.fin);
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

        private void nomCb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Double ac = Convert.ToDouble(ent.absence.Where(z => z.cin == nomCb1.SelectedValue.ToString()).Select(y => y.heures_justifiés).Sum());
                Double ab = Convert.ToDouble(ent.absence.Where(a => a.cin == nomCb1.SelectedValue.ToString()).Select(x => x.heures_absence).Sum());
                totalAbs.Text = ab.ToString();
                totalJust.Text = ac.ToString();
                totalAbs.Visible = true;
                totalJust.Visible = true;
                RemplirDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void absenceControl_Load(object sender, EventArgs e)
        {
            RemplirCB1();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int j = 0;
                var absences2 = from abs in ent.absence
                                select abs;
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet élément ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == dialogResult)
                {
                    foreach (var v in absences2)
                    {
                        if (v.cin == nomCb1.SelectedValue.ToString())
                        {
                            j++;
                            Entity.absence abs4 = ent.absence.FirstOrDefault(x => x.cin == nomCb1.SelectedValue.ToString());
                            ent.absence.DeleteOnSubmit(abs4);
                            ent.SubmitChanges();
                            dataGridView1.Rows.Clear();
                        }
                    }
                }
                totalAbs.Visible = false;
                totalJust.Visible = false;
                if (j != 0)
                {
                    MessageBox.Show("Absence supprimée avec succès");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
           
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            totalAbs.Visible = false;
            totalJust.Visible = false;
            RemplirDGVS();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int j = 0;
                var absences2 = from abs in ent.absence
                                select abs;
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet élément ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == dialogResult)
                {
                    foreach (var v in absences2)
                    {
                        j++;
                        Entity.absence abs4 = ent.absence.FirstOrDefault(x => x.code_abs == v.code_abs);
                        ent.absence.DeleteOnSubmit(abs4);
                        ent.SubmitChanges();
                        dataGridView1.Rows.Clear();
                    }
                }
                totalAbs.Visible = false;
                totalJust.Visible = false;
                if (j != 0)
                {
                    MessageBox.Show("Absence supprimée avec succès ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
           
        }
    }
}
