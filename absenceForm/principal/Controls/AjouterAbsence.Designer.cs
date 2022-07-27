
namespace absenceForm.principal.Controls
{
    partial class AjouterAbsence
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterAbsence));
            this.label1 = new System.Windows.Forms.Label();
            this.nomCb1 = new Guna.UI.WinForms.GunaComboBox();
            this.formateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istaDataSet = new absenceForm.IstaDataSet();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAbs = new Guna.UI.WinForms.GunaTextBox();
            this.txtJoursJust = new Guna.UI.WinForms.GunaTextBox();
            this.txtJust = new Guna.UI.WinForms.GunaTextBox();
            this.Ddebut = new Guna.UI.WinForms.GunaDateTimePicker();
            this.Dfin = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.istaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formateurTableAdapter = new absenceForm.IstaDataSetTableAdapters.formateurTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.totalAbs = new System.Windows.Forms.Label();
            this.btnFermer = new Guna.UI.WinForms.GunaButton();
            this.jrsAbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Justification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jrsJst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.formateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(327, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // nomCb1
            // 
            this.nomCb1.BackColor = System.Drawing.Color.Transparent;
            this.nomCb1.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.nomCb1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nomCb1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.formateurBindingSource, "cin", true));
            this.nomCb1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nomCb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomCb1.FocusedColor = System.Drawing.Color.Empty;
            this.nomCb1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nomCb1.ForeColor = System.Drawing.Color.Black;
            this.nomCb1.FormattingEnabled = true;
            this.nomCb1.Location = new System.Drawing.Point(397, 16);
            this.nomCb1.Name = "nomCb1";
            this.nomCb1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nomCb1.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.nomCb1.Radius = 12;
            this.nomCb1.Size = new System.Drawing.Size(192, 26);
            this.nomCb1.TabIndex = 1;
            this.nomCb1.SelectedIndexChanged += new System.EventHandler(this.nomCb1_SelectedIndexChanged);
            // 
            // formateurBindingSource
            // 
            this.formateurBindingSource.DataMember = "formateur";
            this.formateurBindingSource.DataSource = this.istaDataSet;
            // 
            // istaDataSet
            // 
            this.istaDataSet.DataSetName = "IstaDataSet";
            this.istaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 45;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jrsAbs,
            this.Justification,
            this.jrsJst,
            this.dateDebut,
            this.dateFin,
            this.code,
            this.btnSupprimer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaDataGridView1.Location = new System.Drawing.Point(0, 293);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 26;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1009, 219);
            this.gunaDataGridView1.TabIndex = 2;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 45;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 26;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Heures d\'absences";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Justification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date debut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(717, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Heures justifiés";
            // 
            // txtAbs
            // 
            this.txtAbs.BackColor = System.Drawing.Color.Transparent;
            this.txtAbs.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAbs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAbs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAbs.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAbs.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAbs.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAbs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAbs.Location = new System.Drawing.Point(185, 109);
            this.txtAbs.Name = "txtAbs";
            this.txtAbs.PasswordChar = '\0';
            this.txtAbs.Radius = 8;
            this.txtAbs.SelectedText = "";
            this.txtAbs.Size = new System.Drawing.Size(105, 30);
            this.txtAbs.TabIndex = 3;
            // 
            // txtJoursJust
            // 
            this.txtJoursJust.BackColor = System.Drawing.Color.Transparent;
            this.txtJoursJust.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtJoursJust.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtJoursJust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJoursJust.FocusedBaseColor = System.Drawing.Color.White;
            this.txtJoursJust.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtJoursJust.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtJoursJust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJoursJust.Location = new System.Drawing.Point(850, 186);
            this.txtJoursJust.Name = "txtJoursJust";
            this.txtJoursJust.PasswordChar = '\0';
            this.txtJoursJust.Radius = 8;
            this.txtJoursJust.SelectedText = "";
            this.txtJoursJust.Size = new System.Drawing.Size(105, 30);
            this.txtJoursJust.TabIndex = 3;
            // 
            // txtJust
            // 
            this.txtJust.BackColor = System.Drawing.Color.Transparent;
            this.txtJust.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtJust.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtJust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJust.FocusedBaseColor = System.Drawing.Color.White;
            this.txtJust.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtJust.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtJust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJust.Location = new System.Drawing.Point(498, 109);
            this.txtJust.Name = "txtJust";
            this.txtJust.PasswordChar = '\0';
            this.txtJust.Radius = 8;
            this.txtJust.SelectedText = "";
            this.txtJust.Size = new System.Drawing.Size(457, 30);
            this.txtJust.TabIndex = 3;
            // 
            // Ddebut
            // 
            this.Ddebut.BackColor = System.Drawing.Color.Transparent;
            this.Ddebut.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ddebut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Ddebut.CustomFormat = null;
            this.Ddebut.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Ddebut.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Ddebut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ddebut.ForeColor = System.Drawing.Color.Black;
            this.Ddebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Ddebut.Location = new System.Drawing.Point(146, 186);
            this.Ddebut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Ddebut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Ddebut.Name = "Ddebut";
            this.Ddebut.OnHoverBaseColor = System.Drawing.Color.White;
            this.Ddebut.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Ddebut.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Ddebut.OnPressedColor = System.Drawing.Color.Black;
            this.Ddebut.Radius = 8;
            this.Ddebut.Size = new System.Drawing.Size(172, 29);
            this.Ddebut.TabIndex = 4;
            this.Ddebut.Text = "28/04/2022";
            this.Ddebut.Value = new System.DateTime(2022, 4, 28, 21, 32, 26, 921);
            // 
            // Dfin
            // 
            this.Dfin.BackColor = System.Drawing.Color.Transparent;
            this.Dfin.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dfin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Dfin.CustomFormat = null;
            this.Dfin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Dfin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dfin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dfin.ForeColor = System.Drawing.Color.Black;
            this.Dfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dfin.Location = new System.Drawing.Point(480, 186);
            this.Dfin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Dfin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Dfin.Name = "Dfin";
            this.Dfin.OnHoverBaseColor = System.Drawing.Color.White;
            this.Dfin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dfin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dfin.OnPressedColor = System.Drawing.Color.Black;
            this.Dfin.Radius = 8;
            this.Dfin.Size = new System.Drawing.Size(172, 29);
            this.Dfin.TabIndex = 4;
            this.Dfin.Text = "28/04/2022";
            this.Dfin.Value = new System.DateTime(2022, 4, 28, 21, 32, 1, 777);
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
            this.gunaButton1.Location = new System.Drawing.Point(594, 249);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(191, 38);
            this.gunaButton1.TabIndex = 5;
            this.gunaButton1.Text = "Ajouter";
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
            this.gunaButton2.Location = new System.Drawing.Point(815, 249);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(191, 38);
            this.gunaButton2.TabIndex = 5;
            this.gunaButton2.Text = "Modifier";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // istaDataSetBindingSource
            // 
            this.istaDataSetBindingSource.DataSource = this.istaDataSet;
            this.istaDataSetBindingSource.Position = 0;
            // 
            // formateurTableAdapter
            // 
            this.formateurTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(24, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre total d\'heures d\'absence :";
            // 
            // totalAbs
            // 
            this.totalAbs.AutoSize = true;
            this.totalAbs.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalAbs.Location = new System.Drawing.Point(297, 245);
            this.totalAbs.Name = "totalAbs";
            this.totalAbs.Size = new System.Drawing.Size(56, 25);
            this.totalAbs.TabIndex = 0;
            this.totalAbs.Text = "Nom";
            this.totalAbs.Visible = false;
            // 
            // btnFermer
            // 
            this.btnFermer.AnimationHoverSpeed = 0.07F;
            this.btnFermer.AnimationSpeed = 0.03F;
            this.btnFermer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFermer.BaseColor = System.Drawing.Color.Transparent;
            this.btnFermer.BorderColor = System.Drawing.Color.Black;
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFermer.FocusedColor = System.Drawing.Color.Empty;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFermer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFermer.Location = new System.Drawing.Point(966, 0);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFermer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFermer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFermer.OnHoverImage = null;
            this.btnFermer.OnPressedColor = System.Drawing.Color.Black;
            this.btnFermer.Size = new System.Drawing.Size(43, 40);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // jrsAbs
            // 
            this.jrsAbs.HeaderText = "Heures d\'absences";
            this.jrsAbs.Name = "jrsAbs";
            // 
            // Justification
            // 
            this.Justification.HeaderText = "Justification";
            this.Justification.Name = "Justification";
            // 
            // jrsJst
            // 
            this.jrsJst.HeaderText = "Heures justifiés";
            this.jrsJst.Name = "jrsJst";
            // 
            // dateDebut
            // 
            this.dateDebut.HeaderText = "Date debut";
            this.dateDebut.Name = "dateDebut";
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "Date fin";
            this.dateFin.Name = "dateFin";
            // 
            // code
            // 
            this.code.HeaderText = "Code absence";
            this.code.Name = "code";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.HeaderText = "";
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseColumnTextForButtonValue = true;
            // 
            // AjouterAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.Dfin);
            this.Controls.Add(this.Ddebut);
            this.Controls.Add(this.txtJust);
            this.Controls.Add(this.txtJoursJust);
            this.Controls.Add(this.txtAbs);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.nomCb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalAbs);
            this.Controls.Add(this.label1);
            this.Name = "AjouterAbsence";
            this.Size = new System.Drawing.Size(1009, 512);
            this.Load += new System.EventHandler(this.AjouterAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox nomCb1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.BindingSource formateurBindingSource;
        private IstaDataSet istaDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtAbs;
        private Guna.UI.WinForms.GunaTextBox txtJoursJust;
        private Guna.UI.WinForms.GunaTextBox txtJust;
        private Guna.UI.WinForms.GunaDateTimePicker Ddebut;
        private Guna.UI.WinForms.GunaDateTimePicker Dfin;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.BindingSource istaDataSetBindingSource;
        private IstaDataSetTableAdapters.formateurTableAdapter formateurTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalAbs;
        private Guna.UI.WinForms.GunaButton btnFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn jrsAbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Justification;
        private System.Windows.Forms.DataGridViewTextBoxColumn jrsJst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
    }
}
