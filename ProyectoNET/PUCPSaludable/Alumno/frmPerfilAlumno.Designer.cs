﻿
namespace PUCPSaludable.Alumno
{
    partial class frmPerfilAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilAlumno));
            this.tsConfiguracion = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcConfiguracion = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPerfil = new System.Windows.Forms.TabPage();
            this.tlpPerfil = new System.Windows.Forms.TableLayoutPanel();
            this.labInfo = new System.Windows.Forms.Label();
            this.panPerfil = new System.Windows.Forms.Panel();
            this.gbEspecialidad = new System.Windows.Forms.GroupBox();
            this.cbEspecialidad = new MaterialSkin.Controls.MaterialComboBox();
            this.btGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btEditar = new MaterialSkin.Controls.MaterialButton();
            this.btCancelar = new MaterialSkin.Controls.MaterialButton();
            this.tbEmailPersonal = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCambiarFoto = new MaterialSkin.Controls.MaterialButton();
            this.tbEmailPUCP = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCreditos = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNombres = new MaterialSkin.Controls.MaterialTextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbOtro = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMujer = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbHombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.tbApellidos = new MaterialSkin.Controls.MaterialTextBox();
            this.gbContactoEmergencias = new System.Windows.Forms.GroupBox();
            this.tbApellidosNombres = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.tbParentesco = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.gbFechaNacimiento = new System.Windows.Forms.GroupBox();
            this.ucFechaNacimiento = new PUCPSaludable.Controles.ucFecha();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tabSesiones = new System.Windows.Forms.TabPage();
            this.tlpSesiones = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDivision = new System.Windows.Forms.TableLayoutPanel();
            this.panSesiones = new System.Windows.Forms.Panel();
            this.btnCerrarSesionesActivas = new MaterialSkin.Controls.MaterialButton();
            this.labSesiones = new System.Windows.Forms.Label();
            this.panConfiguracion = new System.Windows.Forms.Panel();
            this.labConstanciaSeguro = new MaterialSkin.Controls.MaterialLabel();
            this.ofdElegirFoto = new System.Windows.Forms.OpenFileDialog();
            this.tcConfiguracion.SuspendLayout();
            this.tabPerfil.SuspendLayout();
            this.tlpPerfil.SuspendLayout();
            this.panPerfil.SuspendLayout();
            this.gbEspecialidad.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbContactoEmergencias.SuspendLayout();
            this.gbFechaNacimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tabSesiones.SuspendLayout();
            this.tlpSesiones.SuspendLayout();
            this.tlpDivision.SuspendLayout();
            this.panConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsConfiguracion
            // 
            this.tsConfiguracion.BaseTabControl = this.tcConfiguracion;
            this.tsConfiguracion.Depth = 0;
            this.tsConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsConfiguracion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tsConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.tsConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsConfiguracion.Name = "tsConfiguracion";
            this.tsConfiguracion.Size = new System.Drawing.Size(1000, 48);
            this.tsConfiguracion.TabIndex = 3;
            // 
            // tcConfiguracion
            // 
            this.tcConfiguracion.Controls.Add(this.tabPerfil);
            this.tcConfiguracion.Controls.Add(this.tabSesiones);
            this.tcConfiguracion.Depth = 0;
            this.tcConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.tcConfiguracion.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tcConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcConfiguracion.Multiline = true;
            this.tcConfiguracion.Name = "tcConfiguracion";
            this.tcConfiguracion.SelectedIndex = 0;
            this.tcConfiguracion.Size = new System.Drawing.Size(1000, 532);
            this.tcConfiguracion.TabIndex = 0;
            // 
            // tabPerfil
            // 
            this.tabPerfil.BackColor = System.Drawing.Color.White;
            this.tabPerfil.Controls.Add(this.tlpPerfil);
            this.tabPerfil.Location = new System.Drawing.Point(4, 22);
            this.tabPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.tabPerfil.Name = "tabPerfil";
            this.tabPerfil.Padding = new System.Windows.Forms.Padding(10);
            this.tabPerfil.Size = new System.Drawing.Size(992, 506);
            this.tabPerfil.TabIndex = 0;
            this.tabPerfil.Text = "Perfil";
            // 
            // tlpPerfil
            // 
            this.tlpPerfil.ColumnCount = 1;
            this.tlpPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPerfil.Controls.Add(this.labInfo, 0, 0);
            this.tlpPerfil.Controls.Add(this.panPerfil, 0, 1);
            this.tlpPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPerfil.Location = new System.Drawing.Point(10, 10);
            this.tlpPerfil.Name = "tlpPerfil";
            this.tlpPerfil.RowCount = 2;
            this.tlpPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerfil.Size = new System.Drawing.Size(972, 486);
            this.tlpPerfil.TabIndex = 6;
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
            this.panPerfil.Controls.Add(this.tbCreditos);
            this.panPerfil.Controls.Add(this.gbEspecialidad);
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
            this.panPerfil.Size = new System.Drawing.Size(966, 460);
            this.panPerfil.TabIndex = 1;
            // 
            // gbEspecialidad
            // 
            this.gbEspecialidad.Controls.Add(this.cbEspecialidad);
            this.gbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEspecialidad.Location = new System.Drawing.Point(378, 260);
            this.gbEspecialidad.Name = "gbEspecialidad";
            this.gbEspecialidad.Size = new System.Drawing.Size(360, 73);
            this.gbEspecialidad.TabIndex = 84;
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
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
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
            this.tbEmailPersonal.MaxLength = 256;
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
            this.tbEmailPUCP.MaxLength = 256;
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
            // tbCreditos
            // 
            this.tbCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCreditos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCreditos.Depth = 0;
            this.tbCreditos.Enabled = false;
            this.tbCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCreditos.HideSelection = true;
            this.tbCreditos.Hint = "Créditos aprobados";
            this.tbCreditos.LeadingIcon = null;
            this.tbCreditos.Location = new System.Drawing.Point(378, 339);
            this.tbCreditos.MaxLength = 32767;
            this.tbCreditos.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCreditos.Name = "tbCreditos";
            this.tbCreditos.PasswordChar = '\0';
            this.tbCreditos.PrefixSuffixText = null;
            this.tbCreditos.ReadOnly = false;
            this.tbCreditos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCreditos.SelectedText = "";
            this.tbCreditos.SelectionLength = 0;
            this.tbCreditos.SelectionStart = 0;
            this.tbCreditos.ShortcutsEnabled = true;
            this.tbCreditos.Size = new System.Drawing.Size(10, 48);
            this.tbCreditos.TabIndex = 54;
            this.tbCreditos.TabStop = false;
            this.tbCreditos.Text = " ";
            this.tbCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCreditos.TrailingIcon = null;
            this.tbCreditos.UseSystemPasswordChar = false;
            this.tbCreditos.Visible = false;
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
            this.tbApellidos.MaxLength = 40;
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
            this.gbContactoEmergencias.Controls.Add(this.tbApellidosNombres);
            this.gbContactoEmergencias.Controls.Add(this.tbTelefono);
            this.gbContactoEmergencias.Controls.Add(this.tbParentesco);
            this.gbContactoEmergencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactoEmergencias.Location = new System.Drawing.Point(378, 74);
            this.gbContactoEmergencias.Name = "gbContactoEmergencias";
            this.gbContactoEmergencias.Size = new System.Drawing.Size(360, 180);
            this.gbContactoEmergencias.TabIndex = 58;
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
            this.tbApellidosNombres.Text = " ";
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
            this.tbTelefono.Text = " ";
            this.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTelefono.TrailingIcon = null;
            this.tbTelefono.UseSystemPasswordChar = false;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
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
            this.tbParentesco.Text = " ";
            this.tbParentesco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbParentesco.TrailingIcon = null;
            this.tbParentesco.UseSystemPasswordChar = false;
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
            this.gbFechaNacimiento.Location = new System.Drawing.Point(3, 274);
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
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 8;
            this.pbFoto.TabStop = false;
            // 
            // tabSesiones
            // 
            this.tabSesiones.BackColor = System.Drawing.Color.White;
            this.tabSesiones.Controls.Add(this.tlpSesiones);
            this.tabSesiones.Location = new System.Drawing.Point(4, 22);
            this.tabSesiones.Margin = new System.Windows.Forms.Padding(0);
            this.tabSesiones.Name = "tabSesiones";
            this.tabSesiones.Padding = new System.Windows.Forms.Padding(10);
            this.tabSesiones.Size = new System.Drawing.Size(992, 506);
            this.tabSesiones.TabIndex = 2;
            this.tabSesiones.Text = "Sesiones";
            // 
            // tlpSesiones
            // 
            this.tlpSesiones.ColumnCount = 1;
            this.tlpSesiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSesiones.Controls.Add(this.tlpDivision, 0, 1);
            this.tlpSesiones.Controls.Add(this.labSesiones, 0, 0);
            this.tlpSesiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSesiones.Location = new System.Drawing.Point(10, 10);
            this.tlpSesiones.Name = "tlpSesiones";
            this.tlpSesiones.RowCount = 2;
            this.tlpSesiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSesiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSesiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSesiones.Size = new System.Drawing.Size(972, 486);
            this.tlpSesiones.TabIndex = 5;
            // 
            // tlpDivision
            // 
            this.tlpDivision.ColumnCount = 3;
            this.tlpDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tlpDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tlpDivision.Controls.Add(this.panSesiones, 0, 0);
            this.tlpDivision.Controls.Add(this.btnCerrarSesionesActivas, 2, 0);
            this.tlpDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDivision.Location = new System.Drawing.Point(3, 23);
            this.tlpDivision.Name = "tlpDivision";
            this.tlpDivision.RowCount = 1;
            this.tlpDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDivision.Size = new System.Drawing.Size(966, 460);
            this.tlpDivision.TabIndex = 1;
            // 
            // panSesiones
            // 
            this.panSesiones.AutoScroll = true;
            this.panSesiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSesiones.Location = new System.Drawing.Point(0, 0);
            this.panSesiones.Margin = new System.Windows.Forms.Padding(0);
            this.panSesiones.Name = "panSesiones";
            this.panSesiones.Size = new System.Drawing.Size(450, 460);
            this.panSesiones.TabIndex = 5;
            // 
            // btnCerrarSesionesActivas
            // 
            this.btnCerrarSesionesActivas.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnCerrarSesionesActivas.AutoSize = false;
            this.btnCerrarSesionesActivas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesionesActivas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesionesActivas.Depth = 0;
            this.btnCerrarSesionesActivas.DrawShadows = false;
            this.btnCerrarSesionesActivas.HighEmphasis = true;
            this.btnCerrarSesionesActivas.Icon = null;
            this.btnCerrarSesionesActivas.Location = new System.Drawing.Point(710, 6);
            this.btnCerrarSesionesActivas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesionesActivas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesionesActivas.Name = "btnCerrarSesionesActivas";
            this.btnCerrarSesionesActivas.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCerrarSesionesActivas.Size = new System.Drawing.Size(252, 36);
            this.btnCerrarSesionesActivas.TabIndex = 4;
            this.btnCerrarSesionesActivas.Text = "CERRAR SESIONES, excepto esta";
            this.btnCerrarSesionesActivas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSesionesActivas.UseAccentColor = true;
            this.btnCerrarSesionesActivas.UseVisualStyleBackColor = true;
            this.btnCerrarSesionesActivas.Click += new System.EventHandler(this.btnCerrarSesionesActivas_Click);
            // 
            // labSesiones
            // 
            this.labSesiones.AutoSize = true;
            this.labSesiones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSesiones.Location = new System.Drawing.Point(3, 0);
            this.labSesiones.Name = "labSesiones";
            this.labSesiones.Size = new System.Drawing.Size(107, 17);
            this.labSesiones.TabIndex = 0;
            this.labSesiones.Text = "Sesiones activas";
            // 
            // panConfiguracion
            // 
            this.panConfiguracion.Controls.Add(this.tcConfiguracion);
            this.panConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panConfiguracion.Location = new System.Drawing.Point(0, 48);
            this.panConfiguracion.Name = "panConfiguracion";
            this.panConfiguracion.Size = new System.Drawing.Size(1000, 532);
            this.panConfiguracion.TabIndex = 4;
            // 
            // labConstanciaSeguro
            // 
            this.labConstanciaSeguro.AutoSize = true;
            this.labConstanciaSeguro.Depth = 0;
            this.labConstanciaSeguro.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labConstanciaSeguro.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labConstanciaSeguro.Location = new System.Drawing.Point(13, 10);
            this.labConstanciaSeguro.MouseState = MaterialSkin.MouseState.HOVER;
            this.labConstanciaSeguro.Name = "labConstanciaSeguro";
            this.labConstanciaSeguro.Size = new System.Drawing.Size(218, 14);
            this.labConstanciaSeguro.TabIndex = 0;
            this.labConstanciaSeguro.Text = "Constancia de seguro contra accidentes";
            // 
            // ofdElegirFoto
            // 
            this.ofdElegirFoto.FileName = "openFileDialog1";
            // 
            // frmPerfilAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.panConfiguracion);
            this.Controls.Add(this.tsConfiguracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerfilAlumno";
            this.Text = "Perfil";
            this.tcConfiguracion.ResumeLayout(false);
            this.tabPerfil.ResumeLayout(false);
            this.tlpPerfil.ResumeLayout(false);
            this.tlpPerfil.PerformLayout();
            this.panPerfil.ResumeLayout(false);
            this.gbEspecialidad.ResumeLayout(false);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbContactoEmergencias.ResumeLayout(false);
            this.gbFechaNacimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tabSesiones.ResumeLayout(false);
            this.tlpSesiones.ResumeLayout(false);
            this.tlpSesiones.PerformLayout();
            this.tlpDivision.ResumeLayout(false);
            this.panConfiguracion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tsConfiguracion;
        private MaterialSkin.Controls.MaterialTabControl tcConfiguracion;
        private System.Windows.Forms.TabPage tabPerfil;
        private System.Windows.Forms.Panel panConfiguracion;
        private MaterialSkin.Controls.MaterialLabel labConstanciaSeguro;
        private System.Windows.Forms.TabPage tabSesiones;
        private System.Windows.Forms.TableLayoutPanel tlpPerfil;
        private System.Windows.Forms.Panel panPerfil;
        private System.Windows.Forms.TableLayoutPanel tlpSesiones;
        private System.Windows.Forms.Label labSesiones;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.GroupBox gbSexo;
        private MaterialSkin.Controls.MaterialRadioButton rbOtro;
        private MaterialSkin.Controls.MaterialRadioButton rbMujer;
        private MaterialSkin.Controls.MaterialRadioButton rbHombre;
        private MaterialSkin.Controls.MaterialButton btnCambiarFoto;
        private System.Windows.Forms.OpenFileDialog ofdElegirFoto;
        private MaterialSkin.Controls.MaterialTextBox tbCreditos;
        private System.Windows.Forms.GroupBox gbContactoEmergencias;
        private MaterialSkin.Controls.MaterialTextBox tbApellidosNombres;
        private MaterialSkin.Controls.MaterialTextBox tbTelefono;
        private MaterialSkin.Controls.MaterialTextBox tbParentesco;
        private System.Windows.Forms.TableLayoutPanel tlpDivision;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesionesActivas;
        private System.Windows.Forms.Panel panSesiones;
        private System.Windows.Forms.Label labInfo;
        private MaterialSkin.Controls.MaterialTextBox tbEmailPersonal;
        private MaterialSkin.Controls.MaterialTextBox tbEmailPUCP;
        private MaterialSkin.Controls.MaterialTextBox tbNombres;
        private MaterialSkin.Controls.MaterialTextBox tbApellidos;
        private MaterialSkin.Controls.MaterialTextBox tbCodigo;
        private System.Windows.Forms.GroupBox gbFechaNacimiento;
        private Controles.ucFecha ucFechaNacimiento;
        private MaterialSkin.Controls.MaterialButton btGuardar;
        private MaterialSkin.Controls.MaterialButton btEditar;
        private MaterialSkin.Controls.MaterialButton btCancelar;
        private System.Windows.Forms.GroupBox gbEspecialidad;
        private MaterialSkin.Controls.MaterialComboBox cbEspecialidad;
    }
}