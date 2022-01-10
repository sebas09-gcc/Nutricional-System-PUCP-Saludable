
namespace PUCPSaludable.Usuario
{
    partial class frmRegistrarsePaso2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarsePaso2));
            this.tbCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.labRegistrarse = new System.Windows.Forms.Label();
            this.btnContinuar = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.tbApellidos = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNombres = new MaterialSkin.Controls.MaterialTextBox();
            this.tbEmailPUCP = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTelefonoMovil = new MaterialSkin.Controls.MaterialTextBox();
            this.gbFechaNacimiento = new System.Windows.Forms.GroupBox();
            this.ucFechaNacimiento = new PUCPSaludable.Controles.ucFecha();
            this.rbHombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbOtro = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMujer = new MaterialSkin.Controls.MaterialRadioButton();
            this.tbContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.tbConfirmarContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.gbFechaNacimiento.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCodigo.Depth = 0;
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCodigo.HideSelection = true;
            this.tbCodigo.Hint = "Código PUCP";
            this.tbCodigo.LeadingIcon = null;
            this.tbCodigo.Location = new System.Drawing.Point(12, 47);
            this.tbCodigo.MaxLength = 8;
            this.tbCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.PasswordChar = '\0';
            this.tbCodigo.PrefixSuffixText = null;
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCodigo.SelectedText = "";
            this.tbCodigo.SelectionLength = 0;
            this.tbCodigo.SelectionStart = 0;
            this.tbCodigo.ShortcutsEnabled = true;
            this.tbCodigo.Size = new System.Drawing.Size(360, 48);
            this.tbCodigo.TabIndex = 54;
            this.tbCodigo.TabStop = false;
            this.tbCodigo.Text = " ";
            this.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCodigo.TrailingIcon = null;
            this.tbCodigo.UseSystemPasswordChar = false;
            // 
            // labRegistrarse
            // 
            this.labRegistrarse.AutoSize = true;
            this.labRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRegistrarse.Location = new System.Drawing.Point(13, 9);
            this.labRegistrarse.Name = "labRegistrarse";
            this.labRegistrarse.Size = new System.Drawing.Size(122, 25);
            this.labRegistrarse.TabIndex = 59;
            this.labRegistrarse.Text = "Registrarse";
            // 
            // btnContinuar
            // 
            this.btnContinuar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnContinuar.AutoSize = false;
            this.btnContinuar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContinuar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnContinuar.Depth = 0;
            this.btnContinuar.DrawShadows = false;
            this.btnContinuar.HighEmphasis = true;
            this.btnContinuar.Icon = null;
            this.btnContinuar.Location = new System.Drawing.Point(255, 597);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContinuar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnContinuar.Size = new System.Drawing.Size(117, 36);
            this.btnContinuar.TabIndex = 64;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnContinuar.UseAccentColor = true;
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(12, 597);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnVolver.Size = new System.Drawing.Size(102, 36);
            this.btnVolver.TabIndex = 63;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnVolver.UseAccentColor = true;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tbApellidos
            // 
            this.tbApellidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbApellidos.Depth = 0;
            this.tbApellidos.Enabled = false;
            this.tbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbApellidos.HideSelection = true;
            this.tbApellidos.Hint = "Apellidos";
            this.tbApellidos.LeadingIcon = null;
            this.tbApellidos.Location = new System.Drawing.Point(12, 101);
            this.tbApellidos.MaxLength = 40;
            this.tbApellidos.MouseState = MaterialSkin.MouseState.OUT;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.PasswordChar = '\0';
            this.tbApellidos.PrefixSuffixText = null;
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbApellidos.SelectedText = "";
            this.tbApellidos.SelectionLength = 0;
            this.tbApellidos.SelectionStart = 0;
            this.tbApellidos.ShortcutsEnabled = true;
            this.tbApellidos.Size = new System.Drawing.Size(360, 48);
            this.tbApellidos.TabIndex = 65;
            this.tbApellidos.TabStop = false;
            this.tbApellidos.Text = " ";
            this.tbApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbApellidos.TrailingIcon = null;
            this.tbApellidos.UseSystemPasswordChar = false;
            // 
            // tbNombres
            // 
            this.tbNombres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNombres.Depth = 0;
            this.tbNombres.Enabled = false;
            this.tbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombres.HideSelection = true;
            this.tbNombres.Hint = "Nombres";
            this.tbNombres.LeadingIcon = null;
            this.tbNombres.Location = new System.Drawing.Point(12, 156);
            this.tbNombres.MaxLength = 40;
            this.tbNombres.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.PasswordChar = '\0';
            this.tbNombres.PrefixSuffixText = null;
            this.tbNombres.ReadOnly = false;
            this.tbNombres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNombres.SelectedText = "";
            this.tbNombres.SelectionLength = 0;
            this.tbNombres.SelectionStart = 0;
            this.tbNombres.ShortcutsEnabled = true;
            this.tbNombres.Size = new System.Drawing.Size(360, 48);
            this.tbNombres.TabIndex = 66;
            this.tbNombres.TabStop = false;
            this.tbNombres.Text = " ";
            this.tbNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNombres.TrailingIcon = null;
            this.tbNombres.UseSystemPasswordChar = false;
            // 
            // tbEmailPUCP
            // 
            this.tbEmailPUCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbEmailPUCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEmailPUCP.Depth = 0;
            this.tbEmailPUCP.Enabled = false;
            this.tbEmailPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEmailPUCP.HideSelection = true;
            this.tbEmailPUCP.Hint = "Email PUCP";
            this.tbEmailPUCP.LeadingIcon = null;
            this.tbEmailPUCP.Location = new System.Drawing.Point(12, 210);
            this.tbEmailPUCP.MaxLength = 256;
            this.tbEmailPUCP.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEmailPUCP.Name = "tbEmailPUCP";
            this.tbEmailPUCP.PasswordChar = '\0';
            this.tbEmailPUCP.PrefixSuffixText = null;
            this.tbEmailPUCP.ReadOnly = true;
            this.tbEmailPUCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmailPUCP.SelectedText = "";
            this.tbEmailPUCP.SelectionLength = 0;
            this.tbEmailPUCP.SelectionStart = 0;
            this.tbEmailPUCP.ShortcutsEnabled = true;
            this.tbEmailPUCP.Size = new System.Drawing.Size(360, 48);
            this.tbEmailPUCP.TabIndex = 67;
            this.tbEmailPUCP.TabStop = false;
            this.tbEmailPUCP.Text = " ";
            this.tbEmailPUCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmailPUCP.TrailingIcon = null;
            this.tbEmailPUCP.UseSystemPasswordChar = false;
            // 
            // tbTelefonoMovil
            // 
            this.tbTelefonoMovil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbTelefonoMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbTelefonoMovil.Depth = 0;
            this.tbTelefonoMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTelefonoMovil.HideSelection = true;
            this.tbTelefonoMovil.Hint = "Telefono";
            this.tbTelefonoMovil.LeadingIcon = null;
            this.tbTelefonoMovil.Location = new System.Drawing.Point(12, 264);
            this.tbTelefonoMovil.MaxLength = 9;
            this.tbTelefonoMovil.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTelefonoMovil.Name = "tbTelefonoMovil";
            this.tbTelefonoMovil.PasswordChar = '\0';
            this.tbTelefonoMovil.PrefixSuffixText = null;
            this.tbTelefonoMovil.ReadOnly = false;
            this.tbTelefonoMovil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTelefonoMovil.SelectedText = "";
            this.tbTelefonoMovil.SelectionLength = 0;
            this.tbTelefonoMovil.SelectionStart = 0;
            this.tbTelefonoMovil.ShortcutsEnabled = true;
            this.tbTelefonoMovil.Size = new System.Drawing.Size(360, 48);
            this.tbTelefonoMovil.TabIndex = 68;
            this.tbTelefonoMovil.TabStop = false;
            this.tbTelefonoMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTelefonoMovil.TrailingIcon = null;
            this.tbTelefonoMovil.UseSystemPasswordChar = false;
            // 
            // gbFechaNacimiento
            // 
            this.gbFechaNacimiento.Controls.Add(this.ucFechaNacimiento);
            this.gbFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFechaNacimiento.Location = new System.Drawing.Point(12, 318);
            this.gbFechaNacimiento.Name = "gbFechaNacimiento";
            this.gbFechaNacimiento.Size = new System.Drawing.Size(360, 75);
            this.gbFechaNacimiento.TabIndex = 72;
            this.gbFechaNacimiento.TabStop = false;
            this.gbFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // ucFechaNacimiento
            // 
            this.ucFechaNacimiento.Fecha = new System.DateTime(2021, 1, 17, 0, 0, 0, 0);
            this.ucFechaNacimiento.Location = new System.Drawing.Point(6, 18);
            this.ucFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.ucFechaNacimiento.Name = "ucFechaNacimiento";
            this.ucFechaNacimiento.Size = new System.Drawing.Size(347, 50);
            this.ucFechaNacimiento.TabIndex = 0;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Depth = 0;
            this.rbHombre.Location = new System.Drawing.Point(6, 19);
            this.rbHombre.Margin = new System.Windows.Forms.Padding(0);
            this.rbHombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbHombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Ripple = true;
            this.rbHombre.Size = new System.Drawing.Size(85, 37);
            this.rbHombre.TabIndex = 73;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbOtro);
            this.gbSexo.Controls.Add(this.rbMujer);
            this.gbSexo.Controls.Add(this.rbHombre);
            this.gbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(12, 399);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(360, 65);
            this.gbSexo.TabIndex = 73;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Depth = 0;
            this.rbOtro.Location = new System.Drawing.Point(172, 19);
            this.rbOtro.Margin = new System.Windows.Forms.Padding(0);
            this.rbOtro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbOtro.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Ripple = true;
            this.rbOtro.Size = new System.Drawing.Size(63, 37);
            this.rbOtro.TabIndex = 75;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Depth = 0;
            this.rbMujer.Location = new System.Drawing.Point(97, 19);
            this.rbMujer.Margin = new System.Windows.Forms.Padding(0);
            this.rbMujer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMujer.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Ripple = true;
            this.rbMujer.Size = new System.Drawing.Size(70, 37);
            this.rbMujer.TabIndex = 74;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // tbContrasena
            // 
            this.tbContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbContrasena.Depth = 0;
            this.tbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbContrasena.HideSelection = true;
            this.tbContrasena.Hint = "Contraseña";
            this.tbContrasena.LeadingIcon = null;
            this.tbContrasena.Location = new System.Drawing.Point(12, 470);
            this.tbContrasena.MaxLength = 40;
            this.tbContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '●';
            this.tbContrasena.PrefixSuffixText = null;
            this.tbContrasena.ReadOnly = false;
            this.tbContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbContrasena.SelectedText = "";
            this.tbContrasena.SelectionLength = 0;
            this.tbContrasena.SelectionStart = 0;
            this.tbContrasena.ShortcutsEnabled = true;
            this.tbContrasena.Size = new System.Drawing.Size(360, 48);
            this.tbContrasena.TabIndex = 74;
            this.tbContrasena.TabStop = false;
            this.tbContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbContrasena.TrailingIcon = null;
            this.tbContrasena.UseSystemPasswordChar = true;
            this.tbContrasena.TextChanged += new System.EventHandler(this.tbContrasena_TextChanged);
            // 
            // tbConfirmarContraseña
            // 
            this.tbConfirmarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbConfirmarContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbConfirmarContraseña.Depth = 0;
            this.tbConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbConfirmarContraseña.HideSelection = true;
            this.tbConfirmarContraseña.Hint = "Confirmar contraseña";
            this.tbConfirmarContraseña.LeadingIcon = null;
            this.tbConfirmarContraseña.Location = new System.Drawing.Point(12, 524);
            this.tbConfirmarContraseña.MaxLength = 40;
            this.tbConfirmarContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.tbConfirmarContraseña.Name = "tbConfirmarContraseña";
            this.tbConfirmarContraseña.PasswordChar = '●';
            this.tbConfirmarContraseña.PrefixSuffixText = null;
            this.tbConfirmarContraseña.ReadOnly = false;
            this.tbConfirmarContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbConfirmarContraseña.SelectedText = "";
            this.tbConfirmarContraseña.SelectionLength = 0;
            this.tbConfirmarContraseña.SelectionStart = 0;
            this.tbConfirmarContraseña.ShortcutsEnabled = true;
            this.tbConfirmarContraseña.Size = new System.Drawing.Size(360, 48);
            this.tbConfirmarContraseña.TabIndex = 75;
            this.tbConfirmarContraseña.TabStop = false;
            this.tbConfirmarContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbConfirmarContraseña.TrailingIcon = null;
            this.tbConfirmarContraseña.UseSystemPasswordChar = true;
            this.tbConfirmarContraseña.TextChanged += new System.EventHandler(this.tbContrasena_TextChanged);
            // 
            // frmRegistrarsePaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 648);
            this.Controls.Add(this.tbConfirmarContraseña);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.tbTelefonoMovil);
            this.Controls.Add(this.tbEmailPUCP);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.labRegistrarse);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbFechaNacimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarsePaso2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registarse";
            this.gbFechaNacimiento.ResumeLayout(false);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox tbCodigo;
        private System.Windows.Forms.Label labRegistrarse;
        private MaterialSkin.Controls.MaterialButton btnContinuar;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialTextBox tbApellidos;
        private MaterialSkin.Controls.MaterialTextBox tbNombres;
        private MaterialSkin.Controls.MaterialTextBox tbEmailPUCP;
        private MaterialSkin.Controls.MaterialTextBox tbTelefonoMovil;
        private System.Windows.Forms.GroupBox gbFechaNacimiento;
        private MaterialSkin.Controls.MaterialRadioButton rbHombre;
        private System.Windows.Forms.GroupBox gbSexo;
        private MaterialSkin.Controls.MaterialRadioButton rbOtro;
        private MaterialSkin.Controls.MaterialRadioButton rbMujer;
        private Controles.ucFecha ucFechaNacimiento;
        private MaterialSkin.Controls.MaterialTextBox tbContrasena;
        private MaterialSkin.Controls.MaterialTextBox tbConfirmarContraseña;
    }
}