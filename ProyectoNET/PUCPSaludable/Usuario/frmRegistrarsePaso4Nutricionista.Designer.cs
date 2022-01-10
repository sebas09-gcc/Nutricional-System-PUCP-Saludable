
namespace PUCPSaludable.Usuario
{
    partial class frmRegistrarsePaso4Nutricionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarsePaso4Nutricionista));
            this.labAviso = new System.Windows.Forms.Label();
            this.labTituloColegiatura = new System.Windows.Forms.Label();
            this.tbColegiatura = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegistrarse = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // labAviso
            // 
            this.labAviso.AutoSize = true;
            this.labAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAviso.Location = new System.Drawing.Point(11, 37);
            this.labAviso.Name = "labAviso";
            this.labAviso.Size = new System.Drawing.Size(275, 13);
            this.labAviso.TabIndex = 20;
            this.labAviso.Text = "Debes consignar tu colegiatura para completar el registro";
            // 
            // labTituloColegiatura
            // 
            this.labTituloColegiatura.AutoSize = true;
            this.labTituloColegiatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloColegiatura.Location = new System.Drawing.Point(7, 9);
            this.labTituloColegiatura.Name = "labTituloColegiatura";
            this.labTituloColegiatura.Size = new System.Drawing.Size(122, 25);
            this.labTituloColegiatura.TabIndex = 19;
            this.labTituloColegiatura.Text = "Colegiatura";
            // 
            // tbColegiatura
            // 
            this.tbColegiatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbColegiatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbColegiatura.Depth = 0;
            this.tbColegiatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbColegiatura.HideSelection = true;
            this.tbColegiatura.Hint = "Código de colegiatura";
            this.tbColegiatura.LeadingIcon = null;
            this.tbColegiatura.Location = new System.Drawing.Point(12, 63);
            this.tbColegiatura.MaxLength = 10;
            this.tbColegiatura.MouseState = MaterialSkin.MouseState.OUT;
            this.tbColegiatura.Name = "tbColegiatura";
            this.tbColegiatura.PasswordChar = '\0';
            this.tbColegiatura.PrefixSuffixText = null;
            this.tbColegiatura.ReadOnly = false;
            this.tbColegiatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbColegiatura.SelectedText = "";
            this.tbColegiatura.SelectionLength = 0;
            this.tbColegiatura.SelectionStart = 0;
            this.tbColegiatura.ShortcutsEnabled = true;
            this.tbColegiatura.Size = new System.Drawing.Size(358, 48);
            this.tbColegiatura.TabIndex = 31;
            this.tbColegiatura.TabStop = false;
            this.tbColegiatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbColegiatura.TrailingIcon = null;
            this.tbColegiatura.UseSystemPasswordChar = false;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnRegistrarse.AutoSize = false;
            this.btnRegistrarse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarse.Depth = 0;
            this.btnRegistrarse.DrawShadows = false;
            this.btnRegistrarse.HighEmphasis = true;
            this.btnRegistrarse.Icon = null;
            this.btnRegistrarse.Location = new System.Drawing.Point(255, 313);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRegistrarse.Size = new System.Drawing.Size(117, 36);
            this.btnRegistrarse.TabIndex = 60;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarse.UseAccentColor = true;
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnConfirmarRegistro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnVolver.AutoSize = false;
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.DrawShadows = false;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(12, 313);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnVolver.Size = new System.Drawing.Size(102, 36);
            this.btnVolver.TabIndex = 59;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnVolver.UseAccentColor = true;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmRegistrarsePaso4Nutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tbColegiatura);
            this.Controls.Add(this.labAviso);
            this.Controls.Add(this.labTituloColegiatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarsePaso4Nutricionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consignar colegiatura y registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labAviso;
        private System.Windows.Forms.Label labTituloColegiatura;
        private MaterialSkin.Controls.MaterialTextBox tbColegiatura;
        private MaterialSkin.Controls.MaterialButton btnRegistrarse;
        private MaterialSkin.Controls.MaterialButton btnVolver;
    }
}