
namespace PUCPSaludable.Usuario
{
    partial class frmRestablecerContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestablecerContrasena));
            this.labAviso = new System.Windows.Forms.Label();
            this.labRestablecerContrasena = new System.Windows.Forms.Label();
            this.tbCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEnviarConfirmacion = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // labAviso
            // 
            this.labAviso.AutoSize = true;
            this.labAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAviso.Location = new System.Drawing.Point(12, 38);
            this.labAviso.Name = "labAviso";
            this.labAviso.Size = new System.Drawing.Size(283, 13);
            this.labAviso.TabIndex = 53;
            this.labAviso.Text = "Te enviaremos un email de confirmación a tu correo PUCP";
            // 
            // labRestablecerContrasena
            // 
            this.labRestablecerContrasena.AutoSize = true;
            this.labRestablecerContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRestablecerContrasena.Location = new System.Drawing.Point(7, 9);
            this.labRestablecerContrasena.Name = "labRestablecerContrasena";
            this.labRestablecerContrasena.Size = new System.Drawing.Size(240, 25);
            this.labRestablecerContrasena.TabIndex = 52;
            this.labRestablecerContrasena.Text = "Restablecer contraseña";
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCodigo.Depth = 0;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCodigo.HideSelection = true;
            this.tbCodigo.Hint = "Código PUCP";
            this.tbCodigo.LeadingIcon = null;
            this.tbCodigo.Location = new System.Drawing.Point(12, 58);
            this.tbCodigo.MaxLength = 8;
            this.tbCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.PasswordChar = '\0';
            this.tbCodigo.PrefixSuffixText = null;
            this.tbCodigo.ReadOnly = false;
            this.tbCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCodigo.SelectedText = "";
            this.tbCodigo.SelectionLength = 0;
            this.tbCodigo.SelectionStart = 0;
            this.tbCodigo.ShortcutsEnabled = true;
            this.tbCodigo.Size = new System.Drawing.Size(360, 48);
            this.tbCodigo.TabIndex = 57;
            this.tbCodigo.TabStop = false;
            this.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCodigo.TrailingIcon = null;
            this.tbCodigo.UseSystemPasswordChar = false;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // btnEnviarConfirmacion
            // 
            this.btnEnviarConfirmacion.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnEnviarConfirmacion.AutoSize = false;
            this.btnEnviarConfirmacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviarConfirmacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEnviarConfirmacion.Depth = 0;
            this.btnEnviarConfirmacion.DrawShadows = false;
            this.btnEnviarConfirmacion.HighEmphasis = true;
            this.btnEnviarConfirmacion.Icon = null;
            this.btnEnviarConfirmacion.Location = new System.Drawing.Point(173, 313);
            this.btnEnviarConfirmacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnviarConfirmacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarConfirmacion.Name = "btnEnviarConfirmacion";
            this.btnEnviarConfirmacion.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEnviarConfirmacion.Size = new System.Drawing.Size(199, 36);
            this.btnEnviarConfirmacion.TabIndex = 58;
            this.btnEnviarConfirmacion.Text = "ENVIAR CONFIRMACIÓN";
            this.btnEnviarConfirmacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEnviarConfirmacion.UseAccentColor = true;
            this.btnEnviarConfirmacion.UseVisualStyleBackColor = true;
            this.btnEnviarConfirmacion.Click += new System.EventHandler(this.btnEnviarConfirmacion_Click);
            // 
            // frmRestablecerContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnEnviarConfirmacion);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.labAviso);
            this.Controls.Add(this.labRestablecerContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRestablecerContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restablecer contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labAviso;
        private System.Windows.Forms.Label labRestablecerContrasena;
        private MaterialSkin.Controls.MaterialTextBox tbCodigo;
        private MaterialSkin.Controls.MaterialButton btnEnviarConfirmacion;
    }
}