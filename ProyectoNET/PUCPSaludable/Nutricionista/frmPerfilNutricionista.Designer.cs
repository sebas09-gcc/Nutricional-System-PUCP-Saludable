
namespace PUCPSaludable.Nutricionista
{
    partial class frmPerfilNutricionista
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPerfil = new System.Windows.Forms.TableLayoutPanel();
            this.labInfo = new System.Windows.Forms.Label();
            this.panPerfil = new System.Windows.Forms.Panel();
            this.tbColegiatura = new MaterialSkin.Controls.MaterialTextBox();
            this.btGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btEditar = new MaterialSkin.Controls.MaterialButton();
            this.btCancelar = new MaterialSkin.Controls.MaterialButton();
            this.tbEmailPersonal = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCambiarFoto = new MaterialSkin.Controls.MaterialButton();
            this.tbEmailPUCP = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNombres = new MaterialSkin.Controls.MaterialTextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbOtro = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMujer = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbHombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.tbApellidos = new MaterialSkin.Controls.MaterialTextBox();
            this.gbContactoEmergencias = new System.Windows.Forms.GroupBox();
            this.btnElegirUbicacion = new MaterialSkin.Controls.MaterialButton();
            this.tbTelefonoLaboral = new MaterialSkin.Controls.MaterialTextBox();
            this.tbDireccionLaboral = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.gbFechaNacimiento = new System.Windows.Forms.GroupBox();
            this.ucFechaNacimiento = new PUCPSaludable.Controles.ucFecha();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.ofdElegirFoto = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpPerfil.SuspendLayout();
            this.panPerfil.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbContactoEmergencias.SuspendLayout();
            this.gbFechaNacimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tlpPerfil, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 493);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpPerfil
            // 
            this.tlpPerfil.ColumnCount = 1;
            this.tlpPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPerfil.Controls.Add(this.labInfo, 0, 0);
            this.tlpPerfil.Controls.Add(this.panPerfil, 0, 1);
            this.tlpPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPerfil.Location = new System.Drawing.Point(3, 3);
            this.tlpPerfil.Name = "tlpPerfil";
            this.tlpPerfil.RowCount = 2;
            this.tlpPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerfil.Size = new System.Drawing.Size(978, 487);
            this.tlpPerfil.TabIndex = 7;
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfo.Location = new System.Drawing.Point(3, 0);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(140, 17);
            this.labInfo.TabIndex = 2;
            this.labInfo.Text = "Información personal";
            // 
            // panPerfil
            // 
            this.panPerfil.AutoScroll = true;
            this.panPerfil.Controls.Add(this.tbColegiatura);
            this.panPerfil.Controls.Add(this.btGuardar);
            this.panPerfil.Controls.Add(this.btEditar);
            this.panPerfil.Controls.Add(this.btCancelar);
            this.panPerfil.Controls.Add(this.tbEmailPersonal);
            this.panPerfil.Controls.Add(this.btnCambiarFoto);
            this.panPerfil.Controls.Add(this.tbEmailPUCP);
            this.panPerfil.Controls.Add(this.tbNombres);
            this.panPerfil.Controls.Add(this.gbSexo);
            this.panPerfil.Controls.Add(this.tbApellidos);
            this.panPerfil.Controls.Add(this.gbContactoEmergencias);
            this.panPerfil.Controls.Add(this.tbCodigo);
            this.panPerfil.Controls.Add(this.gbFechaNacimiento);
            this.panPerfil.Controls.Add(this.pbFoto);
            this.panPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPerfil.Location = new System.Drawing.Point(3, 23);
            this.panPerfil.Name = "panPerfil";
            this.panPerfil.Size = new System.Drawing.Size(972, 461);
            this.panPerfil.TabIndex = 1;
            // 
            // tbColegiatura
            // 
            this.tbColegiatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbColegiatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbColegiatura.Depth = 0;
            this.tbColegiatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbColegiatura.HideSelection = true;
            this.tbColegiatura.Hint = "Colegiatura";
            this.tbColegiatura.LeadingIcon = null;
            this.tbColegiatura.Location = new System.Drawing.Point(3, 274);
            this.tbColegiatura.MaxLength = 32767;
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
            this.tbColegiatura.Size = new System.Drawing.Size(360, 48);
            this.tbColegiatura.TabIndex = 56;
            this.tbColegiatura.TabStop = false;
            this.tbColegiatura.Text = " ";
            this.tbColegiatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbColegiatura.TrailingIcon = null;
            this.tbColegiatura.UseSystemPasswordChar = false;
            // 
            // btGuardar
            // 
            this.btGuardar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btGuardar.AutoSize = false;
            this.btGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btGuardar.Depth = 0;
            this.btGuardar.DrawShadows = false;
            this.btGuardar.HighEmphasis = true;
            this.btGuardar.Icon = null;
            this.btGuardar.Location = new System.Drawing.Point(758, 69);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btGuardar.Size = new System.Drawing.Size(84, 36);
            this.btGuardar.TabIndex = 83;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btGuardar.UseAccentColor = true;
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click_1);
            // 
            // btEditar
            // 
            this.btEditar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btEditar.AutoSize = false;
            this.btEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btEditar.Depth = 0;
            this.btEditar.DrawShadows = false;
            this.btEditar.HighEmphasis = true;
            this.btEditar.Icon = null;
            this.btEditar.Location = new System.Drawing.Point(758, 10);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEditar.Name = "btEditar";
            this.btEditar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btEditar.Size = new System.Drawing.Size(84, 36);
            this.btEditar.TabIndex = 82;
            this.btEditar.Text = "EDITAR";
            this.btEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btEditar.UseAccentColor = true;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btCancelar.AutoSize = false;
            this.btCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btCancelar.Depth = 0;
            this.btCancelar.DrawShadows = false;
            this.btCancelar.HighEmphasis = true;
            this.btCancelar.Icon = null;
            this.btCancelar.Location = new System.Drawing.Point(758, 126);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btCancelar.Size = new System.Drawing.Size(84, 36);
            this.btCancelar.TabIndex = 81;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btCancelar.UseAccentColor = true;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbEmailPersonal
            // 
            this.tbEmailPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbEmailPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEmailPersonal.Depth = 0;
            this.tbEmailPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEmailPersonal.HideSelection = true;
            this.tbEmailPersonal.Hint = "Email personal";
            this.tbEmailPersonal.LeadingIcon = null;
            this.tbEmailPersonal.Location = new System.Drawing.Point(3, 220);
            this.tbEmailPersonal.MaxLength = 32767;
            this.tbEmailPersonal.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEmailPersonal.Name = "tbEmailPersonal";
            this.tbEmailPersonal.PasswordChar = '\0';
            this.tbEmailPersonal.PrefixSuffixText = null;
            this.tbEmailPersonal.ReadOnly = false;
            this.tbEmailPersonal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmailPersonal.SelectedText = "";
            this.tbEmailPersonal.SelectionLength = 0;
            this.tbEmailPersonal.SelectionStart = 0;
            this.tbEmailPersonal.ShortcutsEnabled = true;
            this.tbEmailPersonal.Size = new System.Drawing.Size(360, 48);
            this.tbEmailPersonal.TabIndex = 78;
            this.tbEmailPersonal.TabStop = false;
            this.tbEmailPersonal.Text = " ";
            this.tbEmailPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmailPersonal.TrailingIcon = null;
            this.tbEmailPersonal.UseSystemPasswordChar = false;
            // 
            // btnCambiarFoto
            // 
            this.btnCambiarFoto.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnCambiarFoto.AutoSize = false;
            this.btnCambiarFoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCambiarFoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCambiarFoto.Depth = 0;
            this.btnCambiarFoto.DrawShadows = false;
            this.btnCambiarFoto.HighEmphasis = true;
            this.btnCambiarFoto.Icon = null;
            this.btnCambiarFoto.Location = new System.Drawing.Point(279, 121);
            this.btnCambiarFoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCambiarFoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambiarFoto.Name = "btnCambiarFoto";
            this.btnCambiarFoto.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCambiarFoto.Size = new System.Drawing.Size(84, 36);
            this.btnCambiarFoto.TabIndex = 2;
            this.btnCambiarFoto.Text = "CAMBIAR";
            this.btnCambiarFoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCambiarFoto.UseAccentColor = true;
            this.btnCambiarFoto.UseVisualStyleBackColor = true;
            this.btnCambiarFoto.Click += new System.EventHandler(this.btnCambiarFoto_Click);
            // 
            // tbEmailPUCP
            // 
            this.tbEmailPUCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbEmailPUCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEmailPUCP.Depth = 0;
            this.tbEmailPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEmailPUCP.HideSelection = true;
            this.tbEmailPUCP.Hint = "Email PUCP";
            this.tbEmailPUCP.LeadingIcon = null;
            this.tbEmailPUCP.Location = new System.Drawing.Point(3, 166);
            this.tbEmailPUCP.MaxLength = 32767;
            this.tbEmailPUCP.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEmailPUCP.Name = "tbEmailPUCP";
            this.tbEmailPUCP.PasswordChar = '\0';
            this.tbEmailPUCP.PrefixSuffixText = null;
            this.tbEmailPUCP.ReadOnly = false;
            this.tbEmailPUCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmailPUCP.SelectedText = "";
            this.tbEmailPUCP.SelectionLength = 0;
            this.tbEmailPUCP.SelectionStart = 0;
            this.tbEmailPUCP.ShortcutsEnabled = true;
            this.tbEmailPUCP.Size = new System.Drawing.Size(360, 48);
            this.tbEmailPUCP.TabIndex = 77;
            this.tbEmailPUCP.TabStop = false;
            this.tbEmailPUCP.Text = " ";
            this.tbEmailPUCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmailPUCP.TrailingIcon = null;
            this.tbEmailPUCP.UseSystemPasswordChar = false;
            // 
            // tbNombres
            // 
            this.tbNombres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNombres.Depth = 0;
            this.tbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombres.HideSelection = true;
            this.tbNombres.Hint = "Nombres";
            this.tbNombres.LeadingIcon = null;
            this.tbNombres.Location = new System.Drawing.Point(3, 111);
            this.tbNombres.MaxLength = 32767;
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
            this.tbNombres.Size = new System.Drawing.Size(268, 48);
            this.tbNombres.TabIndex = 76;
            this.tbNombres.TabStop = false;
            this.tbNombres.Text = " ";
            this.tbNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNombres.TrailingIcon = null;
            this.tbNombres.UseSystemPasswordChar = false;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbOtro);
            this.gbSexo.Controls.Add(this.rbMujer);
            this.gbSexo.Controls.Add(this.rbHombre);
            this.gbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(378, 3);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(360, 65);
            this.gbSexo.TabIndex = 80;
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
            // tbApellidos
            // 
            this.tbApellidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbApellidos.Depth = 0;
            this.tbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbApellidos.HideSelection = true;
            this.tbApellidos.Hint = "Apellidos";
            this.tbApellidos.LeadingIcon = null;
            this.tbApellidos.Location = new System.Drawing.Point(3, 56);
            this.tbApellidos.MaxLength = 32767;
            this.tbApellidos.MouseState = MaterialSkin.MouseState.OUT;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.PasswordChar = '\0';
            this.tbApellidos.PrefixSuffixText = null;
            this.tbApellidos.ReadOnly = false;
            this.tbApellidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbApellidos.SelectedText = "";
            this.tbApellidos.SelectionLength = 0;
            this.tbApellidos.SelectionStart = 0;
            this.tbApellidos.ShortcutsEnabled = true;
            this.tbApellidos.Size = new System.Drawing.Size(268, 48);
            this.tbApellidos.TabIndex = 75;
            this.tbApellidos.TabStop = false;
            this.tbApellidos.Text = " ";
            this.tbApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbApellidos.TrailingIcon = null;
            this.tbApellidos.UseSystemPasswordChar = false;
            // 
            // gbContactoEmergencias
            // 
            this.gbContactoEmergencias.Controls.Add(this.btnElegirUbicacion);
            this.gbContactoEmergencias.Controls.Add(this.tbTelefonoLaboral);
            this.gbContactoEmergencias.Controls.Add(this.tbDireccionLaboral);
            this.gbContactoEmergencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactoEmergencias.Location = new System.Drawing.Point(378, 74);
            this.gbContactoEmergencias.Name = "gbContactoEmergencias";
            this.gbContactoEmergencias.Size = new System.Drawing.Size(360, 128);
            this.gbContactoEmergencias.TabIndex = 58;
            this.gbContactoEmergencias.TabStop = false;
            this.gbContactoEmergencias.Text = "Información Laboral";
            // 
            // btnElegirUbicacion
            // 
            this.btnElegirUbicacion.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnElegirUbicacion.AutoSize = false;
            this.btnElegirUbicacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnElegirUbicacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnElegirUbicacion.Depth = 0;
            this.btnElegirUbicacion.DrawShadows = false;
            this.btnElegirUbicacion.HighEmphasis = true;
            this.btnElegirUbicacion.Icon = global::PUCPSaludable.Properties.Resources.mapa;
            this.btnElegirUbicacion.Location = new System.Drawing.Point(309, 73);
            this.btnElegirUbicacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnElegirUbicacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnElegirUbicacion.Name = "btnElegirUbicacion";
            this.btnElegirUbicacion.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnElegirUbicacion.Size = new System.Drawing.Size(44, 46);
            this.btnElegirUbicacion.TabIndex = 56;
            this.btnElegirUbicacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnElegirUbicacion.UseAccentColor = true;
            this.btnElegirUbicacion.UseVisualStyleBackColor = true;
            this.btnElegirUbicacion.Click += new System.EventHandler(this.btnElegirUbicacion_Click);
            // 
            // tbTelefonoLaboral
            // 
            this.tbTelefonoLaboral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbTelefonoLaboral.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbTelefonoLaboral.Depth = 0;
            this.tbTelefonoLaboral.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTelefonoLaboral.HideSelection = true;
            this.tbTelefonoLaboral.Hint = "Telefono laboral";
            this.tbTelefonoLaboral.LeadingIcon = null;
            this.tbTelefonoLaboral.Location = new System.Drawing.Point(6, 19);
            this.tbTelefonoLaboral.MaxLength = 32767;
            this.tbTelefonoLaboral.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTelefonoLaboral.Name = "tbTelefonoLaboral";
            this.tbTelefonoLaboral.PasswordChar = '\0';
            this.tbTelefonoLaboral.PrefixSuffixText = null;
            this.tbTelefonoLaboral.ReadOnly = false;
            this.tbTelefonoLaboral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTelefonoLaboral.SelectedText = "";
            this.tbTelefonoLaboral.SelectionLength = 0;
            this.tbTelefonoLaboral.SelectionStart = 0;
            this.tbTelefonoLaboral.ShortcutsEnabled = true;
            this.tbTelefonoLaboral.Size = new System.Drawing.Size(348, 48);
            this.tbTelefonoLaboral.TabIndex = 54;
            this.tbTelefonoLaboral.TabStop = false;
            this.tbTelefonoLaboral.Text = " ";
            this.tbTelefonoLaboral.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTelefonoLaboral.TrailingIcon = null;
            this.tbTelefonoLaboral.UseSystemPasswordChar = false;
            // 
            // tbDireccionLaboral
            // 
            this.tbDireccionLaboral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDireccionLaboral.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDireccionLaboral.Depth = 0;
            this.tbDireccionLaboral.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDireccionLaboral.HideSelection = true;
            this.tbDireccionLaboral.Hint = "Dirección laboral";
            this.tbDireccionLaboral.LeadingIcon = null;
            this.tbDireccionLaboral.Location = new System.Drawing.Point(6, 73);
            this.tbDireccionLaboral.MaxLength = 32767;
            this.tbDireccionLaboral.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDireccionLaboral.Name = "tbDireccionLaboral";
            this.tbDireccionLaboral.PasswordChar = '\0';
            this.tbDireccionLaboral.PrefixSuffixText = null;
            this.tbDireccionLaboral.ReadOnly = true;
            this.tbDireccionLaboral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDireccionLaboral.SelectedText = "";
            this.tbDireccionLaboral.SelectionLength = 0;
            this.tbDireccionLaboral.SelectionStart = 0;
            this.tbDireccionLaboral.ShortcutsEnabled = true;
            this.tbDireccionLaboral.Size = new System.Drawing.Size(296, 48);
            this.tbDireccionLaboral.TabIndex = 55;
            this.tbDireccionLaboral.TabStop = false;
            this.tbDireccionLaboral.Text = " ";
            this.tbDireccionLaboral.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDireccionLaboral.TrailingIcon = null;
            this.tbDireccionLaboral.UseSystemPasswordChar = false;
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCodigo.Depth = 0;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.HideSelection = true;
            this.tbCodigo.Hint = "Código PUCP";
            this.tbCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbCodigo.LeadingIcon = null;
            this.tbCodigo.Location = new System.Drawing.Point(3, 3);
            this.tbCodigo.MaxLength = 32767;
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
            this.tbCodigo.Size = new System.Drawing.Size(268, 48);
            this.tbCodigo.TabIndex = 74;
            this.tbCodigo.TabStop = false;
            this.tbCodigo.Tag = "";
            this.tbCodigo.Text = " ";
            this.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCodigo.TrailingIcon = null;
            this.tbCodigo.UseSystemPasswordChar = false;
            // 
            // gbFechaNacimiento
            // 
            this.gbFechaNacimiento.Controls.Add(this.ucFechaNacimiento);
            this.gbFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFechaNacimiento.Location = new System.Drawing.Point(378, 208);
            this.gbFechaNacimiento.Name = "gbFechaNacimiento";
            this.gbFechaNacimiento.Size = new System.Drawing.Size(360, 75);
            this.gbFechaNacimiento.TabIndex = 79;
            this.gbFechaNacimiento.TabStop = false;
            this.gbFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // ucFechaNacimiento
            // 
            this.ucFechaNacimiento.Fecha = new System.DateTime(1992, 1, 1, 0, 0, 0, 0);
            this.ucFechaNacimiento.Location = new System.Drawing.Point(7, 18);
            this.ucFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.ucFechaNacimiento.Name = "ucFechaNacimiento";
            this.ucFechaNacimiento.Size = new System.Drawing.Size(346, 54);
            this.ucFechaNacimiento.TabIndex = 81;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.LightGray;
            this.pbFoto.Location = new System.Drawing.Point(278, 3);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(85, 109);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFoto.TabIndex = 8;
            this.pbFoto.TabStop = false;
            // 
            // frmPerfilNutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfilNutricionista";
            this.Text = "frmPerfilNutricionista";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpPerfil.ResumeLayout(false);
            this.tlpPerfil.PerformLayout();
            this.panPerfil.ResumeLayout(false);
            this.panPerfil.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbContactoEmergencias.ResumeLayout(false);
            this.gbFechaNacimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpPerfil;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Panel panPerfil;
        private MaterialSkin.Controls.MaterialButton btGuardar;
        private MaterialSkin.Controls.MaterialButton btEditar;
        private MaterialSkin.Controls.MaterialButton btCancelar;
        private MaterialSkin.Controls.MaterialTextBox tbEmailPersonal;
        private MaterialSkin.Controls.MaterialButton btnCambiarFoto;
        private MaterialSkin.Controls.MaterialTextBox tbEmailPUCP;
        private MaterialSkin.Controls.MaterialTextBox tbNombres;
        private System.Windows.Forms.GroupBox gbSexo;
        private MaterialSkin.Controls.MaterialRadioButton rbOtro;
        private MaterialSkin.Controls.MaterialRadioButton rbMujer;
        private MaterialSkin.Controls.MaterialRadioButton rbHombre;
        private MaterialSkin.Controls.MaterialTextBox tbApellidos;
        private System.Windows.Forms.GroupBox gbContactoEmergencias;
        private MaterialSkin.Controls.MaterialTextBox tbTelefonoLaboral;
        private MaterialSkin.Controls.MaterialTextBox tbDireccionLaboral;
        private MaterialSkin.Controls.MaterialTextBox tbCodigo;
        private System.Windows.Forms.GroupBox gbFechaNacimiento;
        private Controles.ucFecha ucFechaNacimiento;
        private System.Windows.Forms.PictureBox pbFoto;
        private MaterialSkin.Controls.MaterialTextBox tbColegiatura;
        private MaterialSkin.Controls.MaterialButton btnElegirUbicacion;
        private System.Windows.Forms.OpenFileDialog ofdElegirFoto;
    }
}