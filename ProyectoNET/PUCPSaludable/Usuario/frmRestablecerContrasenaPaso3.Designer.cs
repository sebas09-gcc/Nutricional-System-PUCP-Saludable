
namespace PUCPSaludable.Usuario
{
    partial class frmRestablecerContrasenaPaso3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestablecerContrasenaPaso3));
            this.labAviso = new System.Windows.Forms.Label();
            this.labCreaContrasena = new System.Windows.Forms.Label();
            this.tbNuevaContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.tbConfirmarContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // labAviso
            // 
            this.labAviso.AutoSize = true;
            this.labAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAviso.Location = new System.Drawing.Point(12, 38);
            this.labAviso.Name = "labAviso";
            this.labAviso.Size = new System.Drawing.Size(143, 13);
            this.labAviso.TabIndex = 58;
            this.labAviso.Text = "Escribe tu nueva contraseña";
            // 
            // labCreaContrasena
            // 
            this.labCreaContrasena.AutoSize = true;
            this.labCreaContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCreaContrasena.Location = new System.Drawing.Point(10, 9);
            this.labCreaContrasena.Name = "labCreaContrasena";
            this.labCreaContrasena.Size = new System.Drawing.Size(278, 25);
            this.labCreaContrasena.TabIndex = 57;
            this.labCreaContrasena.Text = "Crea una nueva contraseña";
            // 
            // tbNuevaContrasena
            // 
            this.tbNuevaContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNuevaContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNuevaContrasena.Depth = 0;
            this.tbNuevaContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNuevaContrasena.HideSelection = true;
            this.tbNuevaContrasena.Hint = "Nueva contraseña";
            this.tbNuevaContrasena.LeadingIcon = null;
            this.tbNuevaContrasena.Location = new System.Drawing.Point(12, 64);
            this.tbNuevaContrasena.MaxLength = 40;
            this.tbNuevaContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNuevaContrasena.Name = "tbNuevaContrasena";
            this.tbNuevaContrasena.PasswordChar = '●';
            this.tbNuevaContrasena.PrefixSuffixText = null;
            this.tbNuevaContrasena.ReadOnly = false;
            this.tbNuevaContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNuevaContrasena.SelectedText = "";
            this.tbNuevaContrasena.SelectionLength = 0;
            this.tbNuevaContrasena.SelectionStart = 0;
            this.tbNuevaContrasena.ShortcutsEnabled = true;
            this.tbNuevaContrasena.Size = new System.Drawing.Size(360, 48);
            this.tbNuevaContrasena.TabIndex = 64;
            this.tbNuevaContrasena.TabStop = false;
            this.tbNuevaContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNuevaContrasena.TrailingIcon = null;
            this.tbNuevaContrasena.UseSystemPasswordChar = true;
            this.tbNuevaContrasena.TextChanged += new System.EventHandler(this.tbConfirmarContrasena_TextChanged);
            // 
            // tbConfirmarContrasena
            // 
            this.tbConfirmarContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbConfirmarContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbConfirmarContrasena.Depth = 0;
            this.tbConfirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbConfirmarContrasena.HideSelection = true;
            this.tbConfirmarContrasena.Hint = "Confirmar contraseña";
            this.tbConfirmarContrasena.LeadingIcon = null;
            this.tbConfirmarContrasena.Location = new System.Drawing.Point(12, 118);
            this.tbConfirmarContrasena.MaxLength = 40;
            this.tbConfirmarContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.tbConfirmarContrasena.Name = "tbConfirmarContrasena";
            this.tbConfirmarContrasena.PasswordChar = '●';
            this.tbConfirmarContrasena.PrefixSuffixText = null;
            this.tbConfirmarContrasena.ReadOnly = false;
            this.tbConfirmarContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbConfirmarContrasena.SelectedText = "";
            this.tbConfirmarContrasena.SelectionLength = 0;
            this.tbConfirmarContrasena.SelectionStart = 0;
            this.tbConfirmarContrasena.ShortcutsEnabled = true;
            this.tbConfirmarContrasena.Size = new System.Drawing.Size(360, 48);
            this.tbConfirmarContrasena.TabIndex = 65;
            this.tbConfirmarContrasena.TabStop = false;
            this.tbConfirmarContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbConfirmarContrasena.TrailingIcon = null;
            this.tbConfirmarContrasena.UseSystemPasswordChar = true;
            this.tbConfirmarContrasena.TextChanged += new System.EventHandler(this.tbConfirmarContrasena_TextChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnConfirmar.AutoSize = false;
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.DrawShadows = false;
            this.btnConfirmar.HighEmphasis = true;
            this.btnConfirmar.Icon = null;
            this.btnConfirmar.Location = new System.Drawing.Point(257, 313);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConfirmar.Size = new System.Drawing.Size(115, 36);
            this.btnConfirmar.TabIndex = 66;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmar.UseAccentColor = true;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmRestablecerContrasenaPaso3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbConfirmarContrasena);
            this.Controls.Add(this.tbNuevaContrasena);
            this.Controls.Add(this.labAviso);
            this.Controls.Add(this.labCreaContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRestablecerContrasenaPaso3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RestablecerContrasenaPaso3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labAviso;
        private System.Windows.Forms.Label labCreaContrasena;
        private MaterialSkin.Controls.MaterialTextBox tbNuevaContrasena;
        private MaterialSkin.Controls.MaterialTextBox tbConfirmarContrasena;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
    }
}