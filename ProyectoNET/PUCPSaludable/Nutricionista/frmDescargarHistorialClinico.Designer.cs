
namespace PUCPSaludable.Nutricionista
{
    partial class frmDescargarHistorialClinico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescargarHistorialClinico));
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnDescargar = new MaterialSkin.Controls.MaterialButton();
            this.tbNombreArchivo = new MaterialSkin.Controls.MaterialTextBox();
            this.lbCitaHistorica = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.DrawShadows = false;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(207, 159);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnDescargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDescargar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDescargar.Depth = 0;
            this.btnDescargar.DrawShadows = false;
            this.btnDescargar.HighEmphasis = true;
            this.btnDescargar.Icon = null;
            this.btnDescargar.Location = new System.Drawing.Point(340, 158);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDescargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDescargar.Size = new System.Drawing.Size(106, 36);
            this.btnDescargar.TabIndex = 10;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDescargar.UseAccentColor = true;
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // tbNombreArchivo
            // 
            this.tbNombreArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNombreArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNombreArchivo.Depth = 0;
            this.tbNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombreArchivo.HideSelection = true;
            this.tbNombreArchivo.Hint = "Nombre del archivo de salida";
            this.tbNombreArchivo.LeadingIcon = null;
            this.tbNombreArchivo.Location = new System.Drawing.Point(15, 55);
            this.tbNombreArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreArchivo.MaxLength = 32767;
            this.tbNombreArchivo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNombreArchivo.Name = "tbNombreArchivo";
            this.tbNombreArchivo.PasswordChar = '\0';
            this.tbNombreArchivo.PrefixSuffixText = null;
            this.tbNombreArchivo.ReadOnly = false;
            this.tbNombreArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNombreArchivo.SelectedText = "";
            this.tbNombreArchivo.SelectionLength = 0;
            this.tbNombreArchivo.SelectionStart = 0;
            this.tbNombreArchivo.ShortcutsEnabled = true;
            this.tbNombreArchivo.Size = new System.Drawing.Size(467, 48);
            this.tbNombreArchivo.TabIndex = 9;
            this.tbNombreArchivo.TabStop = false;
            this.tbNombreArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNombreArchivo.TrailingIcon = null;
            this.tbNombreArchivo.UseSystemPasswordChar = false;
            // 
            // lbCitaHistorica
            // 
            this.lbCitaHistorica.AutoSize = true;
            this.lbCitaHistorica.Depth = 0;
            this.lbCitaHistorica.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbCitaHistorica.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbCitaHistorica.Location = new System.Drawing.Point(15, 11);
            this.lbCitaHistorica.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCitaHistorica.Name = "lbCitaHistorica";
            this.lbCitaHistorica.Size = new System.Drawing.Size(231, 24);
            this.lbCitaHistorica.TabIndex = 37;
            this.lbCitaHistorica.Text = "Descargar historial clínico";
            // 
            // frmDescargarHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 218);
            this.Controls.Add(this.lbCitaHistorica);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.tbNombreArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDescargarHistorialClinico";
            this.Text = "Descargar historial clínico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnDescargar;
        private MaterialSkin.Controls.MaterialTextBox tbNombreArchivo;
        private MaterialSkin.Controls.MaterialLabel lbCitaHistorica;
    }
}