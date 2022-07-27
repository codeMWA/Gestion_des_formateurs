
namespace absenceForm.principal.Controls
{
    partial class passwordControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNv = new System.Windows.Forms.TextBox();
            this.txtCfr = new System.Windows.Forms.TextBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.hideEye1 = new System.Windows.Forms.PictureBox();
            this.hideEye2 = new System.Windows.Forms.PictureBox();
            this.hideEye3 = new System.Windows.Forms.PictureBox();
            this.displayEye1 = new System.Windows.Forms.PictureBox();
            this.displayEye2 = new System.Windows.Forms.PictureBox();
            this.displayEye3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hideEye1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideEye2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideEye3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayEye1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayEye2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayEye3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de passe actuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nouveau mot de passe ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirmez le nouveau mot de passe ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(348, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 1);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(348, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(348, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 1);
            this.panel3.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(348, 126);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(468, 26);
            this.txtPass.TabIndex = 4;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyUp);
            // 
            // txtNv
            // 
            this.txtNv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNv.Location = new System.Drawing.Point(348, 207);
            this.txtNv.Multiline = true;
            this.txtNv.Name = "txtNv";
            this.txtNv.PasswordChar = '*';
            this.txtNv.Size = new System.Drawing.Size(468, 26);
            this.txtNv.TabIndex = 4;
            this.txtNv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNv_KeyDown);
            this.txtNv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNv_KeyUp);
            // 
            // txtCfr
            // 
            this.txtCfr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCfr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCfr.Location = new System.Drawing.Point(348, 283);
            this.txtCfr.Multiline = true;
            this.txtCfr.Name = "txtCfr";
            this.txtCfr.PasswordChar = '*';
            this.txtCfr.Size = new System.Drawing.Size(468, 26);
            this.txtCfr.TabIndex = 4;
            this.txtCfr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCfr_KeyDown);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton2.BorderSize = 2;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(652, 401);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(197, 39);
            this.gunaButton2.TabIndex = 5;
            this.gunaButton2.Text = "Clear";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(139, 401);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(371, 39);
            this.gunaButton1.TabIndex = 5;
            this.gunaButton1.Text = "Changer";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = global::absenceForm.Properties.Resources._5919711c2d2accce1615685b7b5128cc;
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton3.Location = new System.Drawing.Point(966, 0);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(43, 39);
            this.gunaButton3.TabIndex = 6;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // hideEye1
            // 
            this.hideEye1.Image = global::absenceForm.Properties.Resources.icons8_hide_96;
            this.hideEye1.Location = new System.Drawing.Point(822, 126);
            this.hideEye1.Name = "hideEye1";
            this.hideEye1.Size = new System.Drawing.Size(44, 26);
            this.hideEye1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideEye1.TabIndex = 7;
            this.hideEye1.TabStop = false;
            this.hideEye1.Visible = false;
            this.hideEye1.Click += new System.EventHandler(this.hideEye1_Click);
            // 
            // hideEye2
            // 
            this.hideEye2.Image = global::absenceForm.Properties.Resources.icons8_hide_96;
            this.hideEye2.Location = new System.Drawing.Point(822, 207);
            this.hideEye2.Name = "hideEye2";
            this.hideEye2.Size = new System.Drawing.Size(44, 26);
            this.hideEye2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideEye2.TabIndex = 7;
            this.hideEye2.TabStop = false;
            this.hideEye2.Visible = false;
            this.hideEye2.Click += new System.EventHandler(this.hideEye2_Click);
            // 
            // hideEye3
            // 
            this.hideEye3.Image = global::absenceForm.Properties.Resources.icons8_hide_96;
            this.hideEye3.Location = new System.Drawing.Point(822, 283);
            this.hideEye3.Name = "hideEye3";
            this.hideEye3.Size = new System.Drawing.Size(44, 26);
            this.hideEye3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideEye3.TabIndex = 7;
            this.hideEye3.TabStop = false;
            this.hideEye3.Visible = false;
            this.hideEye3.Click += new System.EventHandler(this.hideEye3_Click);
            // 
            // displayEye1
            // 
            this.displayEye1.Image = global::absenceForm.Properties.Resources.icons8_eye_90;
            this.displayEye1.Location = new System.Drawing.Point(822, 126);
            this.displayEye1.Name = "displayEye1";
            this.displayEye1.Size = new System.Drawing.Size(44, 26);
            this.displayEye1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayEye1.TabIndex = 7;
            this.displayEye1.TabStop = false;
            this.displayEye1.Click += new System.EventHandler(this.displayEye1_Click);
            // 
            // displayEye2
            // 
            this.displayEye2.Image = global::absenceForm.Properties.Resources.icons8_eye_90;
            this.displayEye2.Location = new System.Drawing.Point(822, 207);
            this.displayEye2.Name = "displayEye2";
            this.displayEye2.Size = new System.Drawing.Size(44, 26);
            this.displayEye2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayEye2.TabIndex = 7;
            this.displayEye2.TabStop = false;
            this.displayEye2.Click += new System.EventHandler(this.displayEye2_Click);
            // 
            // displayEye3
            // 
            this.displayEye3.Image = global::absenceForm.Properties.Resources.icons8_eye_90;
            this.displayEye3.Location = new System.Drawing.Point(822, 283);
            this.displayEye3.Name = "displayEye3";
            this.displayEye3.Size = new System.Drawing.Size(44, 26);
            this.displayEye3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayEye3.TabIndex = 7;
            this.displayEye3.TabStop = false;
            this.displayEye3.Click += new System.EventHandler(this.displayEye3_Click);
            // 
            // passwordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.hideEye3);
            this.Controls.Add(this.hideEye2);
            this.Controls.Add(this.displayEye3);
            this.Controls.Add(this.displayEye2);
            this.Controls.Add(this.displayEye1);
            this.Controls.Add(this.hideEye1);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.txtCfr);
            this.Controls.Add(this.txtNv);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "passwordControl";
            this.Size = new System.Drawing.Size(1009, 512);
            this.Load += new System.EventHandler(this.passwordControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hideEye1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideEye2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideEye3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayEye1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayEye2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayEye3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNv;
        private System.Windows.Forms.TextBox txtCfr;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private System.Windows.Forms.PictureBox hideEye1;
        private System.Windows.Forms.PictureBox hideEye2;
        private System.Windows.Forms.PictureBox hideEye3;
        private System.Windows.Forms.PictureBox displayEye1;
        private System.Windows.Forms.PictureBox displayEye2;
        private System.Windows.Forms.PictureBox displayEye3;
    }
}
