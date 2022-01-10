
namespace PUCPSaludable.Usuario
{
    partial class frmRegistrarsePaso4Alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarsePaso4Alumno));
            this.labAviso = new System.Windows.Forms.Label();
            this.labInformacionAdicional = new System.Windows.Forms.Label();
            this.gbContactoEmergencias = new System.Windows.Forms.GroupBox();
            this.tbApellidosNombres = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.tbParentesco = new MaterialSkin.Controls.MaterialTextBox();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.btnRegistrarse = new MaterialSkin.Controls.MaterialButton();
            this.gbEspecialidad = new System.Windows.Forms.GroupBox();
            this.cbEspecialidad = new MaterialSkin.Controls.MaterialComboBox();
            this.gbContactoEmergencias.SuspendLayout();
            this.gbEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAviso
            // 
            this.labAviso.AutoSize = true;
            this.labAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAviso.Location = new System.Drawing.Point(12, 38);
            this.labAviso.Name = "labAviso";
            this.labAviso.Size = new System.Drawing.Size(311, 13);
            this.labAviso.TabIndex = 38;
            this.labAviso.Text = "Debes consignar información adicional para completar tu registro";
            // 
            // labInformacionAdicional
            // 
            this.labInformacionAdicional.AutoSize = true;
            this.labInformacionAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInformacionAdicional.Location = new System.Drawing.Point(13, 10);
            this.labInformacionAdicional.Name = "labInformacionAdicional";
            this.labInformacionAdicional.Size = new System.Drawing.Size(215, 25);
            this.labInformacionAdicional.TabIndex = 37;
            this.labInformacionAdicional.Text = "Información adicional";
            // 
            // gbContactoEmergencias
            // 
            this.gbContactoEmergencias.Controls.Add(this.tbApellidosNombres);
            this.gbContactoEmergencias.Controls.Add(this.tbTelefono);
            this.gbContactoEmergencias.Controls.Add(this.tbParentesco);
            this.gbContactoEmergencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactoEmergencias.Location = new System.Drawing.Point(12, 133);
            this.gbContactoEmergencias.Name = "gbContactoEmergencias";
            this.gbContactoEmergencias.Size = new System.Drawing.Size(360, 180);
            this.gbContactoEmergencias.TabIndex = 51;
            this.gbContactoEmergencias.TabStop = false;
            this.gbContactoEmergencias.Text = "Persona de contacto en caso de emergencias";
            // 
            // tbApellidosNombres
            // 
            this.tbApellidosNombres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbApellidosNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbApellidosNombres.Depth = 0;
            this.tbApellidosNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbApellidosNombres.HideSelection = true;
            this.tbApellidosNombres.Hint = "Apellido y nombre";
            this.tbApellidosNombres.LeadingIcon = null;
            this.tbApellidosNombres.Location = new System.Drawing.Point(6, 19);
            this.tbApellidosNombres.MaxLength = 45;
            this.tbApellidosNombres.MouseState = MaterialSkin.MouseState.OUT;
            this.tbApellidosNombres.Name = "tbApellidosNombres";
            this.tbApellidosNombres.PasswordChar = '\0';
            this.tbApellidosNombres.PrefixSuffixText = null;
            this.tbApellidosNombres.ReadOnly = false;
            this.tbApellidosNombres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbApellidosNombres.SelectedText = "";
            this.tbApellidosNombres.SelectionLength = 0;
            this.tbApellidosNombres.SelectionStart = 0;
            this.tbApellidosNombres.ShortcutsEnabled = true;
            this.tbApellidosNombres.Size = new System.Drawing.Size(348, 48);
            this.tbApellidosNombres.TabIndex = 54;
            this.tbApellidosNombres.TabStop = false;
            this.tbApellidosNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbApellidosNombres.TrailingIcon = null;
            this.tbApellidosNombres.UseSystemPasswordChar = false;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbTelefono.Depth = 0;
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTelefono.HideSelection = true;
            this.tbTelefono.Hint = "Teléfono de contacto";
            this.tbTelefono.LeadingIcon = null;
            this.tbTelefono.Location = new System.Drawing.Point(6, 127);
            this.tbTelefono.MaxLength = 9;
            this.tbTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.PasswordChar = '\0';
            this.tbTelefono.PrefixSuffixText = null;
            this.tbTelefono.ReadOnly = false;
            this.tbTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTelefono.SelectedText = "";
            this.tbTelefono.SelectionLength = 0;
            this.tbTelefono.SelectionStart = 0;
            this.tbTelefono.ShortcutsEnabled = true;
            this.tbTelefono.Size = new System.Drawing.Size(348, 48);
            this.tbTelefono.TabIndex = 56;
            this.tbTelefono.TabStop = false;
            this.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTelefono.TrailingIcon = null;
            this.tbTelefono.UseSystemPasswordChar = false;
            // 
            // tbParentesco
            // 
            this.tbParentesco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbParentesco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbParentesco.Depth = 0;
            this.tbParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbParentesco.HideSelection = true;
            this.tbParentesco.Hint = "Parentesco";
            this.tbParentesco.LeadingIcon = null;
            this.tbParentesco.Location = new System.Drawing.Point(6, 73);
            this.tbParentesco.MaxLength = 45;
            this.tbParentesco.MouseState = MaterialSkin.MouseState.OUT;
            this.tbParentesco.Name = "tbParentesco";
            this.tbParentesco.PasswordChar = '\0';
            this.tbParentesco.PrefixSuffixText = null;
            this.tbParentesco.ReadOnly = false;
            this.tbParentesco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbParentesco.SelectedText = "";
            this.tbParentesco.SelectionLength = 0;
            this.tbParentesco.SelectionStart = 0;
            this.tbParentesco.ShortcutsEnabled = true;
            this.tbParentesco.Size = new System.Drawing.Size(348, 48);
            this.tbParentesco.TabIndex = 55;
            this.tbParentesco.TabStop = false;
            this.tbParentesco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbParentesco.TrailingIcon = null;
            this.tbParentesco.UseSystemPasswordChar = false;
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
            this.btnVolver.Location = new System.Drawing.Point(12, 339);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnVolver.Size = new System.Drawing.Size(102, 36);
            this.btnVolver.TabIndex = 57;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnVolver.UseAccentColor = true;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.btnRegistrarse.Location = new System.Drawing.Point(255, 339);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRegistrarse.Size = new System.Drawing.Size(117, 36);
            this.btnRegistrarse.TabIndex = 58;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarse.UseAccentColor = true;
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnConfirmarRegistro_Click);
            // 
            // gbEspecialidad
            // 
            this.gbEspecialidad.Controls.Add(this.cbEspecialidad);
            this.gbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEspecialidad.Location = new System.Drawing.Point(12, 54);
            this.gbEspecialidad.Name = "gbEspecialidad";
            this.gbEspecialidad.Size = new System.Drawing.Size(360, 73);
            this.gbEspecialidad.TabIndex = 57;
            this.gbEspecialidad.TabStop = false;
            this.gbEspecialidad.Text = "Especialidad";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.AutoResize = false;
            this.cbEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEspecialidad.Depth = 0;
            this.cbEspecialidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEspecialidad.DropDownHeight = 174;
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.DropDownWidth = 121;
            this.cbEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.IntegralHeight = false;
            this.cbEspecialidad.ItemHeight = 43;
            this.cbEspecialidad.Location = new System.Drawing.Point(6, 18);
            this.cbEspecialidad.MaxDropDownItems = 4;
            this.cbEspecialidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(348, 49);
            this.cbEspecialidad.StartIndex = 0;
            this.cbEspecialidad.TabIndex = 55;
            // 
            // frmRegistrarsePaso4Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 390);
            this.Controls.Add(this.gbEspecialidad);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbContactoEmergencias);
            this.Controls.Add(this.labAviso);
            this.Controls.Add(this.labInformacionAdicional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarsePaso4Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información adicional y registrar";
            this.gbContactoEmergencias.ResumeLayout(false);
            this.gbEspecialidad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labAviso;
        private System.Windows.Forms.Label labInformacionAdicional;
        private System.Windows.Forms.GroupBox gbContactoEmergencias;
        private MaterialSkin.Controls.MaterialTextBox tbApellidosNombres;
        private MaterialSkin.Controls.MaterialTextBox tbTelefono;
        private MaterialSkin.Controls.MaterialTextBox tbParentesco;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialButton btnRegistrarse;
        private System.Windows.Forms.GroupBox gbEspecialidad;
        private MaterialSkin.Controls.MaterialComboBox cbEspecialidad;
    }
}