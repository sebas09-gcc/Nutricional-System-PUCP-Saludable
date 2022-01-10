
namespace PUCPSaludable.Nutricionista
{
    partial class frmPerfilAlumnoNutricionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilAlumnoNutricionista));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPerfil = new System.Windows.Forms.TableLayoutPanel();
            this.labInfo = new System.Windows.Forms.Label();
            this.panPerfil = new System.Windows.Forms.Panel();
            this.btnAnhadirPlanAlimentario = new MaterialSkin.Controls.MaterialButton();
            this.btnAbrirIndicSalud = new MaterialSkin.Controls.MaterialButton();
            this.gbEspecialidad = new System.Windows.Forms.GroupBox();
            this.cbEspecialidad = new MaterialSkin.Controls.MaterialComboBox();
            this.tbEmailPersonal = new MaterialSkin.Controls.MaterialTextBox();
            this.tbEmailPUCP = new MaterialSkin.Controls.MaterialTextBox();
            this.gbNivel = new System.Windows.Forms.GroupBox();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpPerfil.SuspendLayout();
            this.panPerfil.SuspendLayout();
            this.gbEspecialidad.SuspendLayout();
            this.gbNivel.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 467);
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
            this.tlpPerfil.Size = new System.Drawing.Size(747, 461);
            this.tlpPerfil.TabIndex = 7;
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfo.Location = new System.Drawing.Point(3, 0);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(134, 17);
            this.labInfo.TabIndex = 2;
            this.labInfo.Text = "Información alumno";
            // 
            // panPerfil
            // 
            this.panPerfil.AutoScroll = true;
            this.panPerfil.Controls.Add(this.btnAnhadirPlanAlimentario);
            this.panPerfil.Controls.Add(this.btnAbrirIndicSalud);
            this.panPerfil.Controls.Add(this.gbEspecialidad);
            this.panPerfil.Controls.Add(this.tbEmailPersonal);
            this.panPerfil.Controls.Add(this.tbEmailPUCP);
            this.panPerfil.Controls.Add(this.gbNivel);
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
            this.panPerfil.Size = new System.Drawing.Size(741, 435);
            this.panPerfil.TabIndex = 1;
            // 
            // btnAnhadirPlanAlimentario
            // 
            this.btnAnhadirPlanAlimentario.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAnhadirPlanAlimentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnhadirPlanAlimentario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnhadirPlanAlimentario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnhadirPlanAlimentario.Depth = 0;
            this.btnAnhadirPlanAlimentario.DrawShadows = false;
            this.btnAnhadirPlanAlimentario.HighEmphasis = true;
            this.btnAnhadirPlanAlimentario.Icon = null;
            this.btnAnhadirPlanAlimentario.Location = new System.Drawing.Point(198, 381);
            this.btnAnhadirPlanAlimentario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnhadirPlanAlimentario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnhadirPlanAlimentario.Name = "btnAnhadirPlanAlimentario";
            this.btnAnhadirPlanAlimentario.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAnhadirPlanAlimentario.Size = new System.Drawing.Size(158, 36);
            this.btnAnhadirPlanAlimentario.TabIndex = 86;
            this.btnAnhadirPlanAlimentario.Text = "PLAN ALIMENTARIO";
            this.btnAnhadirPlanAlimentario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnhadirPlanAlimentario.UseAccentColor = true;
            this.btnAnhadirPlanAlimentario.UseVisualStyleBackColor = true;
            this.btnAnhadirPlanAlimentario.Click += new System.EventHandler(this.btnAnhadirPlanAlimentario_Click);
            // 
            // btnAbrirIndicSalud
            // 
            this.btnAbrirIndicSalud.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAbrirIndicSalud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirIndicSalud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbrirIndicSalud.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAbrirIndicSalud.Depth = 0;
            this.btnAbrirIndicSalud.DrawShadows = false;
            this.btnAbrirIndicSalud.HighEmphasis = true;
            this.btnAbrirIndicSalud.Icon = null;
            this.btnAbrirIndicSalud.Location = new System.Drawing.Point(10, 381);
            this.btnAbrirIndicSalud.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAbrirIndicSalud.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbrirIndicSalud.Name = "btnAbrirIndicSalud";
            this.btnAbrirIndicSalud.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAbrirIndicSalud.Size = new System.Drawing.Size(165, 36);
            this.btnAbrirIndicSalud.TabIndex = 85;
            this.btnAbrirIndicSalud.Text = "INDICADORES SALUD";
            this.btnAbrirIndicSalud.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAbrirIndicSalud.UseAccentColor = true;
            this.btnAbrirIndicSalud.UseVisualStyleBackColor = true;
            this.btnAbrirIndicSalud.Click += new System.EventHandler(this.btnAbrirIndicSalud_Click);
            // 
            // gbEspecialidad
            // 
            this.gbEspecialidad.Controls.Add(this.cbEspecialidad);
            this.gbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEspecialidad.Location = new System.Drawing.Point(378, 353);
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
            this.tbEmailPersonal.ReadOnly = true;
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
            this.tbEmailPUCP.ReadOnly = true;
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
            // gbNivel
            // 
            this.gbNivel.Controls.Add(this.tbCreditos);
            this.gbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNivel.Location = new System.Drawing.Point(378, 79);
            this.gbNivel.Name = "gbNivel";
            this.gbNivel.Size = new System.Drawing.Size(360, 73);
            this.gbNivel.TabIndex = 59;
            this.gbNivel.TabStop = false;
            this.gbNivel.Text = "Nivel según créditos";
            // 
            // tbCreditos
            // 
            this.tbCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCreditos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCreditos.Depth = 0;
            this.tbCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCreditos.HideSelection = true;
            this.tbCreditos.Hint = "Créditos aprobados";
            this.tbCreditos.LeadingIcon = null;
            this.tbCreditos.Location = new System.Drawing.Point(6, 19);
            this.tbCreditos.MaxLength = 32767;
            this.tbCreditos.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCreditos.Name = "tbCreditos";
            this.tbCreditos.PasswordChar = '\0';
            this.tbCreditos.PrefixSuffixText = null;
            this.tbCreditos.ReadOnly = true;
            this.tbCreditos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCreditos.SelectedText = "";
            this.tbCreditos.SelectionLength = 0;
            this.tbCreditos.SelectionStart = 0;
            this.tbCreditos.ShortcutsEnabled = true;
            this.tbCreditos.Size = new System.Drawing.Size(348, 48);
            this.tbCreditos.TabIndex = 54;
            this.tbCreditos.TabStop = false;
            this.tbCreditos.Text = " ";
            this.tbCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCreditos.TrailingIcon = null;
            this.tbCreditos.UseSystemPasswordChar = false;
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
            this.tbNombres.ReadOnly = true;
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
            this.tbApellidos.ReadOnly = true;
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
            this.gbContactoEmergencias.Location = new System.Drawing.Point(378, 167);
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
            this.tbApellidosNombres.MaxLength = 32767;
            this.tbApellidosNombres.MouseState = MaterialSkin.MouseState.OUT;
            this.tbApellidosNombres.Name = "tbApellidosNombres";
            this.tbApellidosNombres.PasswordChar = '\0';
            this.tbApellidosNombres.PrefixSuffixText = null;
            this.tbApellidosNombres.ReadOnly = true;
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
            this.tbTelefono.MaxLength = 32767;
            this.tbTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.PasswordChar = '\0';
            this.tbTelefono.PrefixSuffixText = null;
            this.tbTelefono.ReadOnly = true;
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
            this.tbParentesco.MaxLength = 32767;
            this.tbParentesco.MouseState = MaterialSkin.MouseState.OUT;
            this.tbParentesco.Name = "tbParentesco";
            this.tbParentesco.PasswordChar = '\0';
            this.tbParentesco.PrefixSuffixText = null;
            this.tbParentesco.ReadOnly = true;
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
            this.tbCodigo.ReadOnly = true;
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
            // frmPerfilAlumnoNutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(753, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerfilAlumnoNutricionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información Alumno";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpPerfil.ResumeLayout(false);
            this.tlpPerfil.PerformLayout();
            this.panPerfil.ResumeLayout(false);
            this.panPerfil.PerformLayout();
            this.gbEspecialidad.ResumeLayout(false);
            this.gbNivel.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbEspecialidad;
        private MaterialSkin.Controls.MaterialComboBox cbEspecialidad;
        private MaterialSkin.Controls.MaterialTextBox tbEmailPersonal;
        private MaterialSkin.Controls.MaterialTextBox tbEmailPUCP;
        private System.Windows.Forms.GroupBox gbNivel;
        private MaterialSkin.Controls.MaterialTextBox tbCreditos;
        private MaterialSkin.Controls.MaterialTextBox tbNombres;
        private System.Windows.Forms.GroupBox gbSexo;
        private MaterialSkin.Controls.MaterialRadioButton rbOtro;
        private MaterialSkin.Controls.MaterialRadioButton rbMujer;
        private MaterialSkin.Controls.MaterialRadioButton rbHombre;
        private MaterialSkin.Controls.MaterialTextBox tbApellidos;
        private System.Windows.Forms.GroupBox gbContactoEmergencias;
        private MaterialSkin.Controls.MaterialTextBox tbApellidosNombres;
        private MaterialSkin.Controls.MaterialTextBox tbTelefono;
        private MaterialSkin.Controls.MaterialTextBox tbParentesco;
        private MaterialSkin.Controls.MaterialTextBox tbCodigo;
        private System.Windows.Forms.GroupBox gbFechaNacimiento;
        private Controles.ucFecha ucFechaNacimiento;
        private System.Windows.Forms.PictureBox pbFoto;
        private MaterialSkin.Controls.MaterialButton btnAnhadirPlanAlimentario;
        private MaterialSkin.Controls.MaterialButton btnAbrirIndicSalud;
    }
}