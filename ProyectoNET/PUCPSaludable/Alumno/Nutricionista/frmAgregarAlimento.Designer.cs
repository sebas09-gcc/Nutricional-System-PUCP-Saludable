
namespace PUCPSaludable.Alumno.Nutricionista
{
    partial class frmAgregarAlimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarAlimento));
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.cbSelAlimento = new MaterialSkin.Controls.MaterialComboBox();
            this.lbAgregarA = new MaterialSkin.Controls.MaterialLabel();
            this.txbIngredi = new MaterialSkin.Controls.MaterialTextBox();
            this.rbPredielcto = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbNoPredilecto = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAlergico = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.DrawShadows = false;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(230, 209);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAgregar.Size = new System.Drawing.Size(184, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = true;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbSelAlimento
            // 
            this.cbSelAlimento.AutoResize = false;
            this.cbSelAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSelAlimento.Depth = 0;
            this.cbSelAlimento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSelAlimento.DropDownHeight = 174;
            this.cbSelAlimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelAlimento.DropDownWidth = 121;
            this.cbSelAlimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSelAlimento.FormattingEnabled = true;
            this.cbSelAlimento.IntegralHeight = false;
            this.cbSelAlimento.ItemHeight = 43;
            this.cbSelAlimento.Location = new System.Drawing.Point(11, 95);
            this.cbSelAlimento.MaxDropDownItems = 4;
            this.cbSelAlimento.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSelAlimento.Name = "cbSelAlimento";
            this.cbSelAlimento.Size = new System.Drawing.Size(403, 49);
            this.cbSelAlimento.StartIndex = 0;
            this.cbSelAlimento.TabIndex = 6;
            this.cbSelAlimento.DataSourceChanged += new System.EventHandler(this.cbSelAlimento_DataSourceChanged);
            // 
            // lbAgregarA
            // 
            this.lbAgregarA.AutoSize = true;
            this.lbAgregarA.Depth = 0;
            this.lbAgregarA.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbAgregarA.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbAgregarA.Location = new System.Drawing.Point(127, 7);
            this.lbAgregarA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbAgregarA.Name = "lbAgregarA";
            this.lbAgregarA.Size = new System.Drawing.Size(152, 24);
            this.lbAgregarA.TabIndex = 7;
            this.lbAgregarA.Text = "AgregarAlimento";
            // 
            // txbIngredi
            // 
            this.txbIngredi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbIngredi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIngredi.Depth = 0;
            this.txbIngredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbIngredi.HideSelection = true;
            this.txbIngredi.Hint = "Buscar ingrediente";
            this.txbIngredi.LeadingIcon = null;
            this.txbIngredi.Location = new System.Drawing.Point(11, 42);
            this.txbIngredi.Margin = new System.Windows.Forms.Padding(2);
            this.txbIngredi.MaxLength = 32767;
            this.txbIngredi.MouseState = MaterialSkin.MouseState.OUT;
            this.txbIngredi.Name = "txbIngredi";
            this.txbIngredi.PasswordChar = '\0';
            this.txbIngredi.PrefixSuffixText = null;
            this.txbIngredi.ReadOnly = false;
            this.txbIngredi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbIngredi.SelectedText = "";
            this.txbIngredi.SelectionLength = 0;
            this.txbIngredi.SelectionStart = 0;
            this.txbIngredi.ShortcutsEnabled = true;
            this.txbIngredi.Size = new System.Drawing.Size(403, 48);
            this.txbIngredi.TabIndex = 11;
            this.txbIngredi.TabStop = false;
            this.txbIngredi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIngredi.TrailingIcon = null;
            this.txbIngredi.UseSystemPasswordChar = false;
            this.txbIngredi.TextChanged += new System.EventHandler(this.txbIngredi_TextChanged);
            // 
            // rbPredielcto
            // 
            this.rbPredielcto.AutoSize = true;
            this.rbPredielcto.Depth = 0;
            this.rbPredielcto.Location = new System.Drawing.Point(11, 147);
            this.rbPredielcto.Margin = new System.Windows.Forms.Padding(0);
            this.rbPredielcto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPredielcto.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPredielcto.Name = "rbPredielcto";
            this.rbPredielcto.Ripple = true;
            this.rbPredielcto.Size = new System.Drawing.Size(97, 37);
            this.rbPredielcto.TabIndex = 12;
            this.rbPredielcto.TabStop = true;
            this.rbPredielcto.Text = "Predilecto";
            this.rbPredielcto.UseVisualStyleBackColor = true;
            this.rbPredielcto.CheckedChanged += new System.EventHandler(this.rbPredielcto_CheckedChanged);
            // 
            // rbNoPredilecto
            // 
            this.rbNoPredilecto.AutoSize = true;
            this.rbNoPredilecto.Depth = 0;
            this.rbNoPredilecto.Location = new System.Drawing.Point(108, 147);
            this.rbNoPredilecto.Margin = new System.Windows.Forms.Padding(0);
            this.rbNoPredilecto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNoPredilecto.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNoPredilecto.Name = "rbNoPredilecto";
            this.rbNoPredilecto.Ripple = true;
            this.rbNoPredilecto.Size = new System.Drawing.Size(117, 37);
            this.rbNoPredilecto.TabIndex = 13;
            this.rbNoPredilecto.TabStop = true;
            this.rbNoPredilecto.Text = "No predilecto";
            this.rbNoPredilecto.UseVisualStyleBackColor = true;
            this.rbNoPredilecto.CheckedChanged += new System.EventHandler(this.rbNoPredilecto_CheckedChanged);
            // 
            // rbAlergico
            // 
            this.rbAlergico.AutoSize = true;
            this.rbAlergico.Depth = 0;
            this.rbAlergico.Location = new System.Drawing.Point(230, 147);
            this.rbAlergico.Margin = new System.Windows.Forms.Padding(0);
            this.rbAlergico.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAlergico.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAlergico.Name = "rbAlergico";
            this.rbAlergico.Ripple = true;
            this.rbAlergico.Size = new System.Drawing.Size(85, 37);
            this.rbAlergico.TabIndex = 14;
            this.rbAlergico.TabStop = true;
            this.rbAlergico.Text = "Alérgico";
            this.rbAlergico.UseVisualStyleBackColor = true;
            this.rbAlergico.CheckedChanged += new System.EventHandler(this.rbAlergico_CheckedChanged);
            // 
            // frmAgregarAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 260);
            this.Controls.Add(this.rbAlergico);
            this.Controls.Add(this.rbNoPredilecto);
            this.Controls.Add(this.rbPredielcto);
            this.Controls.Add(this.txbIngredi);
            this.Controls.Add(this.lbAgregarA);
            this.Controls.Add(this.cbSelAlimento);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialComboBox cbSelAlimento;
        private MaterialSkin.Controls.MaterialLabel lbAgregarA;
        private MaterialSkin.Controls.MaterialTextBox txbIngredi;
        private MaterialSkin.Controls.MaterialRadioButton rbPredielcto;
        private MaterialSkin.Controls.MaterialRadioButton rbNoPredilecto;
        private MaterialSkin.Controls.MaterialRadioButton rbAlergico;
    }
}