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
    public partial class autorisationControl : UserControl
    {
        public autorisationControl()
        {
            InitializeComponent();
            RemplirCBformateur();
        }
        Entity.DataClasses1DataContext ent = new Entity.DataClasses1DataContext();
        private void nbrLabel_Click(object sender, EventArgs e)
        {

        }
        void RemplirDgv()
        {
            var autors = from at in ent.autorisation
                         select at;
            dgv1.Rows.Clear();
            foreach(var v in autors)
            {
                if(v.cin == CBformateur.SelectedValue.ToString())
                {
                    dgv1.Rows.Add(v.codeAuto,v.cas,v.heures_autorisé,v.dateDebut,v.dateFin);
                }
            }
        }
        void RemplirCBformateur()
        {
            try
            {
                var formateurs = from fr in ent.formateur
                                 select fr;
                CBformateur.DataSource = formateurs.ToList();
                CBformateur.DisplayMember = "nom";
                CBformateur.ValueMember = "cin";
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            
        }
        private void autorisationControl_Load(object sender, EventArgs e)
        {
            CBcas.Items.Add("autorisé");
            CBcas.Items.Add("non autorisé");
            RemplirCBformateur();
        }
        void NombreH()
        {
            Double nbrH = Convert.ToDouble(ent.autorisation.Where(x => x.cin == CBformateur.SelectedValue.ToString()).Select(x => x.heures_autorisé).Sum());
            nbrLabel.Text = nbrH.ToString();
            nbrLabel.Visible = true;
        }

        private void CBformateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreH();
            RemplirDgv();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Entity.autorisation aut = new Entity.autorisation();
            aut.cin = CBformateur.SelectedValue.ToString();
            aut.cas = CBcas.Text;
            aut.heures_autorisé = Convert.ToDecimal(txtHeuresAbs.Text);
            aut.dateDebut = dateDebut.Text;
            aut.dateFin = dateFin.Text;
            ent.autorisation.InsertOnSubmit(aut);
            ent.SubmitChanges();
            MessageBox.Show("L'autorisation a été enregistrée avec succès");
            txtHeuresAbs.Clear();
            NombreH();
            RemplirDgv();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                int a = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet élément ?","Confirmation",MessageBoxButtons.YesNo);
                if(DialogResult.Yes == dialogResult)
                {
                    Entity.autorisation at1 = ent.autorisation.FirstOrDefault(x => x.codeAuto == a);
                    ent.autorisation.DeleteOnSubmit(at1);
                    ent.SubmitChanges();
                    MessageBox.Show("L'autorisation a été supprimée avec succès");
                    NombreH();
                    RemplirDgv();
                }
            }
        }
    }
}
