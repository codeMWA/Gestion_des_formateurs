
namespace absenceForm.principal.Controls
{
    partial class autorisationControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CBformateur = new Guna.UI.WinForms.GunaComboBox();
            this.CBcas = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeuresAbs = new Guna.UI.WinForms.GunaTextBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.dateDebut = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dateFin = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nbrLabel = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgv1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBformateur
            // 
            this.CBformateur.BackColor = System.Drawing.Color.Transparent;
            this.CBformateur.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.CBformateur.BorderColor = System.Drawing.Color.Black;
            this.CBformateur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBformateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBformateur.FocusedColor = System.Drawing.Color.Empty;
            this.CBformateur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBformateur.ForeColor = System.Drawing.Color.Black;
            this.CBformateur.FormattingEnabled = true;
            this.CBformateur.Location = new System.Drawing.Point(115, 51);
            this.CBformateur.Name = "CBformateur";
            this.CBformateur.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CBformateur.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.CBformateur.Radius = 8;
            this.CBformateur.Size = new System.Drawing.Size(175, 26);
            this.CBformateur.TabIndex = 0;
            this.CBformateur.SelectedIndexChanged += new System.EventHandler(this.CBformateur_SelectedIndexChanged);
            // 
            // CBcas
            // 
            this.CBcas.BackColor = System.Drawing.Color.Transparent;
            this.CBcas.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.CBcas.BorderColor = System.Drawing.Color.Black;
            this.CBcas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBcas.FocusedColor = System.Drawing.Color.Empty;
            this.CBcas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBcas.ForeColor = System.Drawing.Color.Black;
            this.CBcas.FormattingEnabled = true;
            this.CBcas.Location = new System.Drawing.Point(115, 134);
            this.CBcas.Name = "CBcas";
            this.CBcas.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CBcas.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.CBcas.Radius = 8;
            this.CBcas.Size = new System.Drawing.Size(175, 26);
            this.CBcas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHeuresAbs
            // 
            this.txtHeuresAbs.BackColor = System.Drawing.Color.Transparent;
            this.txtHeuresAbs.BaseColor = System.Drawing.Color.White;
            this.txtHeuresAbs.BorderColor = System.Drawing.Color.Black;
            this.txtHeuresAbs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHeuresAbs.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHeuresAbs.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtHeuresAbs.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHeuresAbs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHeuresAbs.Location = new System.Drawing.Point(738, 52);
            this.txtHeuresAbs.Name = "txtHeuresAbs";
            this.txtHeuresAbs.PasswordChar = '\0';
            this.txtHeuresAbs.Radius = 10;
            this.txtHeuresAbs.SelectedText = "";
            this.txtHeuresAbs.Size = new System.Drawing.Size(223, 30);
            this.txtHeuresAbs.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.DimGray;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderSize = 2;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(84, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 8;
            this.btnSave.Size = new System.Drawing.Size(316, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateDebut
            // 
            this.dateDebut.BackColor = System.Drawing.Color.Transparent;
            this.dateDebut.BaseColor = System.Drawing.Color.White;
            this.dateDebut.BorderColor = System.Drawing.Color.Black;
            this.dateDebut.CustomFormat = null;
            this.dateDebut.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateDebut.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateDebut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateDebut.ForeColor = System.Drawing.Color.Black;
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDebut.Location = new System.Drawing.Point(738, 134);
            this.dateDebut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateDebut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateDebut.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateDebut.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateDebut.OnPressedColor = System.Drawing.Color.Black;
            this.dateDebut.Radius = 10;
            this.dateDebut.Size = new System.Drawing.Size(223, 30);
            this.dateDebut.TabIndex = 4;
            this.dateDebut.Text = "03/07/2022";
            this.dateDebut.Value = new System.DateTime(2022, 7, 3, 17, 22, 29, 208);
            // 
            // dateFin
            // 
            this.dateFin.BackColor = System.Drawing.Color.Transparent;
            this.dateFin.BaseColor = System.Drawing.Color.White;
            this.dateFin.BorderColor = System.Drawing.Color.Black;
            this.dateFin.CustomFormat = null;
            this.dateFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateFin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateFin.ForeColor = System.Drawing.Color.Black;
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFin.Location = new System.Drawing.Point(738, 208);
            this.dateFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFin.Name = "dateFin";
            this.dateFin.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateFin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateFin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateFin.OnPressedColor = System.Drawing.Color.Black;
            this.dateFin.Radius = 10;
            this.dateFin.Size = new System.Drawing.Size(223, 30);
            this.dateFin.TabIndex = 4;
            this.dateFin.Text = "03/07/2022";
            this.dateFin.Value = new System.DateTime(2022, 7, 3, 17, 14, 37, 47);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Heures autorisés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date debut";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(3, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nombre total d\'heures autorisés :";
            // 
            // nbrLabel
            // 
            this.nbrLabel.AutoSize = true;
            this.nbrLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nbrLabel.Location = new System.Drawing.Point(273, 268);
            this.nbrLabel.Name = "nbrLabel";
            this.nbrLabel.Size = new System.Drawing.Size(51, 25);
            this.nbrLabel.TabIndex = 10;
            this.nbrLabel.Text = "NBR";
            this.nbrLabel.Visible = false;
            this.nbrLabel.Click += new System.EventHandler(this.nbrLabel_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.dateDebut);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.btnSave);
            this.gunaGroupBox1.Controls.Add(this.dateFin);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtHeuresAbs);
            this.gunaGroupBox1.Controls.Add(this.CBcas);
            this.gunaGroupBox1.Controls.Add(this.CBformateur);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1009, 259);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "L\'autorisation";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgv1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv1.ColumnHeadersHeight = 26;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.btnSupprimer});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv1.Location = new System.Drawing.Point(0, 299);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1009, 213);
            this.dgv1.TabIndex = 12;
            this.dgv1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv1.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgv1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv1.ThemeStyle.HeaderStyle.Height = 26;
            this.dgv1.ThemeStyle.ReadOnly = false;
            this.dgv1.ThemeStyle.RowsStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv1.ThemeStyle.RowsStyle.Height = 23;
            this.dgv1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cas";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Heures autorisés";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date debut";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date fin";
            this.Column5.Name = "Column5";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.HeaderText = "";
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseColumnTextForButtonValue = true;
            // 
            // autorisationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.nbrLabel);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.label7);
            this.Name = "autorisationControl";
            this.Size = new System.Drawing.Size(1009, 512);
            this.Load += new System.EventHandler(this.autorisationControl_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox CBformateur;
        private Guna.UI.WinForms.GunaComboBox CBcas;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtHeuresAbs;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaDateTimePicker dateDebut;
        private Guna.UI.WinForms.GunaDateTimePicker dateFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nbrLabel;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaDataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
    }
}
