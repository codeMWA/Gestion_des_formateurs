
namespace absenceForm.principal.Controls
{
    partial class absenceControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(absenceControl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomCb1 = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.btnFermer = new Guna.UI.WinForms.GunaButton();
            this.label7 = new System.Windows.Forms.Label();
            this.totalAbs = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.totalJust = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JrsAbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.just = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jrsJust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ddebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dfin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.Prenom,
            this.JrsAbs,
            this.just,
            this.jrsJust,
            this.Ddebut,
            this.Dfin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1009, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomCb1
            // 
            this.nomCb1.BackColor = System.Drawing.Color.Transparent;
            this.nomCb1.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.nomCb1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nomCb1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nomCb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomCb1.FocusedColor = System.Drawing.Color.Empty;
            this.nomCb1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nomCb1.ForeColor = System.Drawing.Color.Black;
            this.nomCb1.FormattingEnabled = true;
            this.nomCb1.Location = new System.Drawing.Point(127, 46);
            this.nomCb1.Name = "nomCb1";
            this.nomCb1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nomCb1.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.nomCb1.Radius = 12;
            this.nomCb1.Size = new System.Drawing.Size(192, 26);
            this.nomCb1.TabIndex = 3;
            this.nomCb1.SelectedIndexChanged += new System.EventHandler(this.nomCb1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(73, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(610, 46);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(191, 38);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Text = "Supprimer par nom";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton2.BorderSize = 2;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(536, 177);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(379, 38);
            this.gunaButton2.TabIndex = 6;
            this.gunaButton2.Text = "Supprimer toutes les absences";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton3.BorderSize = 2;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(77, 177);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 10;
            this.gunaButton3.Size = new System.Drawing.Size(379, 38);
            this.gunaButton3.TabIndex = 6;
            this.gunaButton3.Text = "Afficher toutes les absences";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.AnimationHoverSpeed = 0.07F;
            this.btnFermer.AnimationSpeed = 0.03F;
            this.btnFermer.BackColor = System.Drawing.Color.Transparent;
            this.btnFermer.BaseColor = System.Drawing.Color.Transparent;
            this.btnFermer.BorderColor = System.Drawing.Color.Black;
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFermer.FocusedColor = System.Drawing.Color.Empty;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFermer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFermer.Location = new System.Drawing.Point(969, 0);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFermer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFermer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFermer.OnHoverImage = null;
            this.btnFermer.OnPressedColor = System.Drawing.Color.Black;
            this.btnFermer.Size = new System.Drawing.Size(40, 30);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(73, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre total d\'heures d\'absence :";
            // 
            // totalAbs
            // 
            this.totalAbs.AutoSize = true;
            this.totalAbs.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalAbs.Location = new System.Drawing.Point(346, 117);
            this.totalAbs.Name = "totalAbs";
            this.totalAbs.Size = new System.Drawing.Size(56, 25);
            this.totalAbs.TabIndex = 9;
            this.totalAbs.Text = "Nom";
            this.totalAbs.Visible = false;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaButton1);
            this.gunaGroupBox1.Controls.Add(this.btnFermer);
            this.gunaGroupBox1.Controls.Add(this.totalJust);
            this.gunaGroupBox1.Controls.Add(this.totalAbs);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.nomCb1);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineTop = 33;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1009, 162);
            this.gunaGroupBox1.TabIndex = 10;
            this.gunaGroupBox1.Text = "Gestion des absences";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // totalJust
            // 
            this.totalJust.AutoSize = true;
            this.totalJust.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalJust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalJust.Location = new System.Drawing.Point(804, 114);
            this.totalJust.Name = "totalJust";
            this.totalJust.Size = new System.Drawing.Size(56, 25);
            this.totalJust.TabIndex = 9;
            this.totalJust.Text = "Nom";
            this.totalJust.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(543, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre total d\'heures justifiés:";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // JrsAbs
            // 
            this.JrsAbs.HeaderText = "Heures d\'absence";
            this.JrsAbs.Name = "JrsAbs";
            // 
            // just
            // 
            this.just.HeaderText = "Justification";
            this.just.Name = "just";
            // 
            // jrsJust
            // 
            this.jrsJust.HeaderText = "Heures justifiés";
            this.jrsJust.Name = "jrsJust";
            // 
            // Ddebut
            // 
            this.Ddebut.HeaderText = "Date debut";
            this.Ddebut.Name = "Ddebut";
            // 
            // Dfin
            // 
            this.Dfin.HeaderText = "DateFin";
            this.Dfin.Name = "Dfin";
            // 
            // absenceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "absenceControl";
            this.Size = new System.Drawing.Size(1009, 512);
            this.Load += new System.EventHandler(this.absenceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaComboBox nomCb1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton btnFermer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalAbs;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label totalJust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn JrsAbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn just;
        private System.Windows.Forms.DataGridViewTextBoxColumn jrsJust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ddebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dfin;
    }
}
