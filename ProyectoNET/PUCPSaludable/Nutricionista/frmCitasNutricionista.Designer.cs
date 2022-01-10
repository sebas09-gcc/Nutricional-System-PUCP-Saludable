
namespace PUCPSaludable.Nutricionista
{
    partial class frmCitasNutricionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitasNutricionista));
            this.tsTabControl = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tpCitasProgramadas = new System.Windows.Forms.TabPage();
            this.panCitasProg = new System.Windows.Forms.Panel();
            this.tpCitasHistoricas = new System.Windows.Forms.TabPage();
            this.panCItasHist = new System.Windows.Forms.Panel();
            this.tlpPrincipalGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panFoto = new System.Windows.Forms.Panel();
            this.labEdad = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tlpEventos = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistrarAtencion = new MaterialSkin.Controls.MaterialButton();
            this.labEventos = new System.Windows.Forms.Label();
            this.panHistorialCitas = new System.Windows.Forms.Panel();
            this.lanNotasImportantes = new System.Windows.Forms.Label();
            this.panNotasImportantes = new System.Windows.Forms.Panel();
            this.tbAlimentosAlergias = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbNotasImportantes = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tlpDetalleClinico = new System.Windows.Forms.TableLayoutPanel();
            this.labDetalleClinico = new System.Windows.Forms.Label();
            this.panBotonesInferiores = new System.Windows.Forms.Panel();
            this.btnAnhadirPlanAlimentario = new MaterialSkin.Controls.MaterialButton();
            this.btnAnhadirHistorialClinico = new MaterialSkin.Controls.MaterialButton();
            this.labPreferenciasAlimentarias = new System.Windows.Forms.Label();
            this.lanNombrePaciente = new MaterialSkin.Controls.MaterialLabel();
            this.tlpPreferenciasAlimentarias = new System.Windows.Forms.TableLayoutPanel();
            this.tbAlimentosGusta = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbAlimentosDisgusta = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.labGusta = new System.Windows.Forms.Label();
            this.labDisgusta = new System.Windows.Forms.Label();
            this.tbDetalleClinico = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.tlpCitasProgramadasHistoricas = new System.Windows.Forms.TableLayoutPanel();
            this.panTituloTab = new System.Windows.Forms.Panel();
            this.labFechaCita = new System.Windows.Forms.Label();
            this.labHoraCita = new System.Windows.Forms.Label();
            this.labFechaHoraAtencionCita = new System.Windows.Forms.Label();
            this.tcTabControl.SuspendLayout();
            this.tpCitasProgramadas.SuspendLayout();
            this.tpCitasHistoricas.SuspendLayout();
            this.tlpPrincipalGlobal.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.panFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tlpEventos.SuspendLayout();
            this.panNotasImportantes.SuspendLayout();
            this.tlpDetalleClinico.SuspendLayout();
            this.panBotonesInferiores.SuspendLayout();
            this.tlpPreferenciasAlimentarias.SuspendLayout();
            this.tlpCitasProgramadasHistoricas.SuspendLayout();
            this.panTituloTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsTabControl
            // 
            this.tsTabControl.BaseTabControl = this.tcTabControl;
            this.tsTabControl.Depth = 0;
            this.tsTabControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tsTabControl.Location = new System.Drawing.Point(-62, 1);
            this.tsTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsTabControl.Name = "tsTabControl";
            this.tsTabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsTabControl.Size = new System.Drawing.Size(362, 48);
            this.tsTabControl.TabIndex = 0;
            this.tsTabControl.TabIndicatorHeight = 1;
            // 
            // tcTabControl
            // 
            this.tcTabControl.Controls.Add(this.tpCitasProgramadas);
            this.tcTabControl.Controls.Add(this.tpCitasHistoricas);
            this.tcTabControl.Depth = 0;
            this.tcTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabControl.Location = new System.Drawing.Point(0, 50);
            this.tcTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tcTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcTabControl.Multiline = true;
            this.tcTabControl.Name = "tcTabControl";
            this.tcTabControl.SelectedIndex = 0;
            this.tcTabControl.Size = new System.Drawing.Size(300, 521);
            this.tcTabControl.TabIndex = 2;
            // 
            // tpCitasProgramadas
            // 
            this.tpCitasProgramadas.Controls.Add(this.panCitasProg);
            this.tpCitasProgramadas.Location = new System.Drawing.Point(4, 22);
            this.tpCitasProgramadas.Name = "tpCitasProgramadas";
            this.tpCitasProgramadas.Padding = new System.Windows.Forms.Padding(3);
            this.tpCitasProgramadas.Size = new System.Drawing.Size(292, 495);
            this.tpCitasProgramadas.TabIndex = 0;
            this.tpCitasProgramadas.Text = "Programadas";
            this.tpCitasProgramadas.UseVisualStyleBackColor = true;
            // 
            // panCitasProg
            // 
            this.panCitasProg.AutoScroll = true;
            this.panCitasProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCitasProg.Location = new System.Drawing.Point(3, 3);
            this.panCitasProg.Name = "panCitasProg";
            this.panCitasProg.Size = new System.Drawing.Size(286, 489);
            this.panCitasProg.TabIndex = 0;
            // 
            // tpCitasHistoricas
            // 
            this.tpCitasHistoricas.Controls.Add(this.panCItasHist);
            this.tpCitasHistoricas.Location = new System.Drawing.Point(4, 22);
            this.tpCitasHistoricas.Name = "tpCitasHistoricas";
            this.tpCitasHistoricas.Padding = new System.Windows.Forms.Padding(3);
            this.tpCitasHistoricas.Size = new System.Drawing.Size(292, 495);
            this.tpCitasHistoricas.TabIndex = 1;
            this.tpCitasHistoricas.Text = "Históricas";
            this.tpCitasHistoricas.UseVisualStyleBackColor = true;
            // 
            // panCItasHist
            // 
            this.panCItasHist.AutoScroll = true;
            this.panCItasHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCItasHist.Location = new System.Drawing.Point(3, 3);
            this.panCItasHist.Name = "panCItasHist";
            this.panCItasHist.Size = new System.Drawing.Size(286, 489);
            this.panCItasHist.TabIndex = 0;
            // 
            // tlpPrincipalGlobal
            // 
            this.tlpPrincipalGlobal.ColumnCount = 2;
            this.tlpPrincipalGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpPrincipalGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipalGlobal.Controls.Add(this.tlpPrincipal, 1, 0);
            this.tlpPrincipalGlobal.Controls.Add(this.tlpCitasProgramadasHistoricas, 0, 0);
            this.tlpPrincipalGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipalGlobal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipalGlobal.Name = "tlpPrincipalGlobal";
            this.tlpPrincipalGlobal.RowCount = 1;
            this.tlpPrincipalGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipalGlobal.Size = new System.Drawing.Size(1000, 571);
            this.tlpPrincipalGlobal.TabIndex = 1;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpPrincipal.Controls.Add(this.panFoto, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpEventos, 2, 0);
            this.tlpPrincipal.Controls.Add(this.tlpDetalleClinico, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(300, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(700, 571);
            this.tlpPrincipal.TabIndex = 29;
            // 
            // panFoto
            // 
            this.panFoto.Controls.Add(this.labFechaHoraAtencionCita);
            this.panFoto.Controls.Add(this.labHoraCita);
            this.panFoto.Controls.Add(this.labFechaCita);
            this.panFoto.Controls.Add(this.labEdad);
            this.panFoto.Controls.Add(this.pbFoto);
            this.panFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFoto.Location = new System.Drawing.Point(2, 2);
            this.panFoto.Margin = new System.Windows.Forms.Padding(2);
            this.panFoto.Name = "panFoto";
            this.panFoto.Size = new System.Drawing.Size(116, 567);
            this.panFoto.TabIndex = 29;
            // 
            // labEdad
            // 
            this.labEdad.AutoSize = true;
            this.labEdad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEdad.Location = new System.Drawing.Point(28, 137);
            this.labEdad.Name = "labEdad";
            this.labEdad.Size = new System.Drawing.Size(60, 17);
            this.labEdad.TabIndex = 29;
            this.labEdad.Text = "Edad: 18";
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbFoto.Image = global::PUCPSaludable.Properties.Resources.Persona;
            this.pbFoto.InitialImage = global::PUCPSaludable.Properties.Resources.Persona;
            this.pbFoto.Location = new System.Drawing.Point(10, 10);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(96, 117);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 9;
            this.pbFoto.TabStop = false;
            // 
            // tlpEventos
            // 
            this.tlpEventos.ColumnCount = 1;
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEventos.Controls.Add(this.btnRegistrarAtencion, 0, 4);
            this.tlpEventos.Controls.Add(this.labEventos, 0, 0);
            this.tlpEventos.Controls.Add(this.panHistorialCitas, 0, 1);
            this.tlpEventos.Controls.Add(this.lanNotasImportantes, 0, 2);
            this.tlpEventos.Controls.Add(this.panNotasImportantes, 0, 3);
            this.tlpEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEventos.Location = new System.Drawing.Point(400, 0);
            this.tlpEventos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEventos.Name = "tlpEventos";
            this.tlpEventos.RowCount = 5;
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpEventos.Size = new System.Drawing.Size(300, 571);
            this.tlpEventos.TabIndex = 24;
            // 
            // btnRegistrarAtencion
            // 
            this.btnRegistrarAtencion.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnRegistrarAtencion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarAtencion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarAtencion.Depth = 0;
            this.btnRegistrarAtencion.DrawShadows = false;
            this.btnRegistrarAtencion.HighEmphasis = true;
            this.btnRegistrarAtencion.Icon = null;
            this.btnRegistrarAtencion.Location = new System.Drawing.Point(2, 534);
            this.btnRegistrarAtencion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegistrarAtencion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarAtencion.Name = "btnRegistrarAtencion";
            this.btnRegistrarAtencion.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRegistrarAtencion.Size = new System.Drawing.Size(175, 34);
            this.btnRegistrarAtencion.TabIndex = 25;
            this.btnRegistrarAtencion.Text = "REGISTRAR ATENCIÓN";
            this.btnRegistrarAtencion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarAtencion.UseAccentColor = true;
            this.btnRegistrarAtencion.UseVisualStyleBackColor = true;
            this.btnRegistrarAtencion.Click += new System.EventHandler(this.btnRegistrarAtencion_Click);
            // 
            // labEventos
            // 
            this.labEventos.AutoSize = true;
            this.labEventos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEventos.Location = new System.Drawing.Point(3, 0);
            this.labEventos.Name = "labEventos";
            this.labEventos.Size = new System.Drawing.Size(112, 17);
            this.labEventos.TabIndex = 0;
            this.labEventos.Text = "Historial de citas";
            // 
            // panHistorialCitas
            // 
            this.panHistorialCitas.AutoScroll = true;
            this.panHistorialCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHistorialCitas.Location = new System.Drawing.Point(0, 20);
            this.panHistorialCitas.Margin = new System.Windows.Forms.Padding(0);
            this.panHistorialCitas.Name = "panHistorialCitas";
            this.panHistorialCitas.Size = new System.Drawing.Size(300, 331);
            this.panHistorialCitas.TabIndex = 1;
            // 
            // lanNotasImportantes
            // 
            this.lanNotasImportantes.AutoSize = true;
            this.lanNotasImportantes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanNotasImportantes.Location = new System.Drawing.Point(3, 351);
            this.lanNotasImportantes.Name = "lanNotasImportantes";
            this.lanNotasImportantes.Size = new System.Drawing.Size(58, 17);
            this.lanNotasImportantes.TabIndex = 2;
            this.lanNotasImportantes.Text = "Alergias";
            // 
            // panNotasImportantes
            // 
            this.panNotasImportantes.Controls.Add(this.tbAlimentosAlergias);
            this.panNotasImportantes.Controls.Add(this.tbNotasImportantes);
            this.panNotasImportantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panNotasImportantes.Location = new System.Drawing.Point(3, 374);
            this.panNotasImportantes.Name = "panNotasImportantes";
            this.panNotasImportantes.Size = new System.Drawing.Size(294, 154);
            this.panNotasImportantes.TabIndex = 3;
            // 
            // tbAlimentosAlergias
            // 
            this.tbAlimentosAlergias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbAlimentosAlergias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAlimentosAlergias.Depth = 0;
            this.tbAlimentosAlergias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAlimentosAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAlimentosAlergias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbAlimentosAlergias.Location = new System.Drawing.Point(0, 0);
            this.tbAlimentosAlergias.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbAlimentosAlergias.Name = "tbAlimentosAlergias";
            this.tbAlimentosAlergias.ReadOnly = true;
            this.tbAlimentosAlergias.Size = new System.Drawing.Size(294, 154);
            this.tbAlimentosAlergias.TabIndex = 4;
            this.tbAlimentosAlergias.Text = resources.GetString("tbAlimentosAlergias.Text");
            // 
            // tbNotasImportantes
            // 
            this.tbNotasImportantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbNotasImportantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNotasImportantes.Depth = 0;
            this.tbNotasImportantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNotasImportantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNotasImportantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbNotasImportantes.Location = new System.Drawing.Point(0, 0);
            this.tbNotasImportantes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbNotasImportantes.Name = "tbNotasImportantes";
            this.tbNotasImportantes.Size = new System.Drawing.Size(294, 154);
            this.tbNotasImportantes.TabIndex = 3;
            this.tbNotasImportantes.Text = resources.GetString("tbNotasImportantes.Text");
            // 
            // tlpDetalleClinico
            // 
            this.tlpDetalleClinico.ColumnCount = 1;
            this.tlpDetalleClinico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetalleClinico.Controls.Add(this.labDetalleClinico, 0, 1);
            this.tlpDetalleClinico.Controls.Add(this.panBotonesInferiores, 0, 5);
            this.tlpDetalleClinico.Controls.Add(this.labPreferenciasAlimentarias, 0, 3);
            this.tlpDetalleClinico.Controls.Add(this.lanNombrePaciente, 0, 0);
            this.tlpDetalleClinico.Controls.Add(this.tlpPreferenciasAlimentarias, 0, 4);
            this.tlpDetalleClinico.Controls.Add(this.tbDetalleClinico, 0, 2);
            this.tlpDetalleClinico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetalleClinico.Location = new System.Drawing.Point(120, 0);
            this.tlpDetalleClinico.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDetalleClinico.Name = "tlpDetalleClinico";
            this.tlpDetalleClinico.RowCount = 6;
            this.tlpDetalleClinico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpDetalleClinico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetalleClinico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpDetalleClinico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetalleClinico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpDetalleClinico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpDetalleClinico.Size = new System.Drawing.Size(280, 571);
            this.tlpDetalleClinico.TabIndex = 28;
            // 
            // labDetalleClinico
            // 
            this.labDetalleClinico.AutoSize = true;
            this.labDetalleClinico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetalleClinico.Location = new System.Drawing.Point(3, 40);
            this.labDetalleClinico.Name = "labDetalleClinico";
            this.labDetalleClinico.Size = new System.Drawing.Size(82, 17);
            this.labDetalleClinico.TabIndex = 29;
            this.labDetalleClinico.Text = "Diagnostico";
            // 
            // panBotonesInferiores
            // 
            this.panBotonesInferiores.Controls.Add(this.btnAnhadirPlanAlimentario);
            this.panBotonesInferiores.Controls.Add(this.btnAnhadirHistorialClinico);
            this.panBotonesInferiores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBotonesInferiores.Location = new System.Drawing.Point(0, 530);
            this.panBotonesInferiores.Margin = new System.Windows.Forms.Padding(0);
            this.panBotonesInferiores.Name = "panBotonesInferiores";
            this.panBotonesInferiores.Size = new System.Drawing.Size(280, 41);
            this.panBotonesInferiores.TabIndex = 26;
            // 
            // btnAnhadirPlanAlimentario
            // 
            this.btnAnhadirPlanAlimentario.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAnhadirPlanAlimentario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnhadirPlanAlimentario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnhadirPlanAlimentario.Depth = 0;
            this.btnAnhadirPlanAlimentario.DrawShadows = false;
            this.btnAnhadirPlanAlimentario.HighEmphasis = true;
            this.btnAnhadirPlanAlimentario.Icon = null;
            this.btnAnhadirPlanAlimentario.Location = new System.Drawing.Point(175, 2);
            this.btnAnhadirPlanAlimentario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnhadirPlanAlimentario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnhadirPlanAlimentario.Name = "btnAnhadirPlanAlimentario";
            this.btnAnhadirPlanAlimentario.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAnhadirPlanAlimentario.Size = new System.Drawing.Size(158, 36);
            this.btnAnhadirPlanAlimentario.TabIndex = 24;
            this.btnAnhadirPlanAlimentario.Text = "PLAN ALIMENTARIO";
            this.btnAnhadirPlanAlimentario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnhadirPlanAlimentario.UseAccentColor = true;
            this.btnAnhadirPlanAlimentario.UseVisualStyleBackColor = true;
            this.btnAnhadirPlanAlimentario.Click += new System.EventHandler(this.btnAnhadirPlanAlimentario_Click);
            // 
            // btnAnhadirHistorialClinico
            // 
            this.btnAnhadirHistorialClinico.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAnhadirHistorialClinico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnhadirHistorialClinico.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnhadirHistorialClinico.Depth = 0;
            this.btnAnhadirHistorialClinico.DrawShadows = false;
            this.btnAnhadirHistorialClinico.HighEmphasis = true;
            this.btnAnhadirHistorialClinico.Icon = null;
            this.btnAnhadirHistorialClinico.Location = new System.Drawing.Point(0, 2);
            this.btnAnhadirHistorialClinico.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnhadirHistorialClinico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnhadirHistorialClinico.Name = "btnAnhadirHistorialClinico";
            this.btnAnhadirHistorialClinico.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAnhadirHistorialClinico.Size = new System.Drawing.Size(165, 36);
            this.btnAnhadirHistorialClinico.TabIndex = 23;
            this.btnAnhadirHistorialClinico.Text = "INDICADORES SALUD";
            this.btnAnhadirHistorialClinico.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnhadirHistorialClinico.UseAccentColor = true;
            this.btnAnhadirHistorialClinico.UseVisualStyleBackColor = true;
            this.btnAnhadirHistorialClinico.Click += new System.EventHandler(this.btnAnhadirHistorialClinico_Click);
            // 
            // labPreferenciasAlimentarias
            // 
            this.labPreferenciasAlimentarias.AutoSize = true;
            this.labPreferenciasAlimentarias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPreferenciasAlimentarias.Location = new System.Drawing.Point(3, 330);
            this.labPreferenciasAlimentarias.Name = "labPreferenciasAlimentarias";
            this.labPreferenciasAlimentarias.Size = new System.Drawing.Size(163, 17);
            this.labPreferenciasAlimentarias.TabIndex = 28;
            this.labPreferenciasAlimentarias.Text = "Preferencias alimentarias";
            // 
            // lanNombrePaciente
            // 
            this.lanNombrePaciente.Depth = 0;
            this.lanNombrePaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lanNombrePaciente.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lanNombrePaciente.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lanNombrePaciente.Location = new System.Drawing.Point(3, 0);
            this.lanNombrePaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lanNombrePaciente.Name = "lanNombrePaciente";
            this.lanNombrePaciente.Size = new System.Drawing.Size(274, 40);
            this.lanNombrePaciente.TabIndex = 22;
            this.lanNombrePaciente.Text = "Juan Perez";
            this.lanNombrePaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpPreferenciasAlimentarias
            // 
            this.tlpPreferenciasAlimentarias.ColumnCount = 2;
            this.tlpPreferenciasAlimentarias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPreferenciasAlimentarias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPreferenciasAlimentarias.Controls.Add(this.tbAlimentosGusta, 0, 1);
            this.tlpPreferenciasAlimentarias.Controls.Add(this.tbAlimentosDisgusta, 0, 1);
            this.tlpPreferenciasAlimentarias.Controls.Add(this.labGusta, 0, 0);
            this.tlpPreferenciasAlimentarias.Controls.Add(this.labDisgusta, 1, 0);
            this.tlpPreferenciasAlimentarias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPreferenciasAlimentarias.Location = new System.Drawing.Point(0, 350);
            this.tlpPreferenciasAlimentarias.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPreferenciasAlimentarias.Name = "tlpPreferenciasAlimentarias";
            this.tlpPreferenciasAlimentarias.RowCount = 2;
            this.tlpPreferenciasAlimentarias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPreferenciasAlimentarias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPreferenciasAlimentarias.Size = new System.Drawing.Size(280, 180);
            this.tlpPreferenciasAlimentarias.TabIndex = 30;
            // 
            // tbAlimentosGusta
            // 
            this.tbAlimentosGusta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbAlimentosGusta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAlimentosGusta.Depth = 0;
            this.tbAlimentosGusta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAlimentosGusta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAlimentosGusta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbAlimentosGusta.Location = new System.Drawing.Point(3, 23);
            this.tbAlimentosGusta.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbAlimentosGusta.Name = "tbAlimentosGusta";
            this.tbAlimentosGusta.ReadOnly = true;
            this.tbAlimentosGusta.Size = new System.Drawing.Size(134, 154);
            this.tbAlimentosGusta.TabIndex = 32;
            this.tbAlimentosGusta.Text = resources.GetString("tbAlimentosGusta.Text");
            // 
            // tbAlimentosDisgusta
            // 
            this.tbAlimentosDisgusta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbAlimentosDisgusta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAlimentosDisgusta.Depth = 0;
            this.tbAlimentosDisgusta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAlimentosDisgusta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAlimentosDisgusta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbAlimentosDisgusta.Location = new System.Drawing.Point(143, 23);
            this.tbAlimentosDisgusta.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbAlimentosDisgusta.Name = "tbAlimentosDisgusta";
            this.tbAlimentosDisgusta.ReadOnly = true;
            this.tbAlimentosDisgusta.Size = new System.Drawing.Size(134, 154);
            this.tbAlimentosDisgusta.TabIndex = 31;
            this.tbAlimentosDisgusta.Text = resources.GetString("tbAlimentosDisgusta.Text");
            // 
            // labGusta
            // 
            this.labGusta.AutoSize = true;
            this.labGusta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGusta.Location = new System.Drawing.Point(3, 0);
            this.labGusta.Name = "labGusta";
            this.labGusta.Size = new System.Drawing.Size(43, 17);
            this.labGusta.TabIndex = 29;
            this.labGusta.Text = "Gusta";
            // 
            // labDisgusta
            // 
            this.labDisgusta.AutoSize = true;
            this.labDisgusta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDisgusta.Location = new System.Drawing.Point(143, 0);
            this.labDisgusta.Name = "labDisgusta";
            this.labDisgusta.Size = new System.Drawing.Size(62, 17);
            this.labDisgusta.TabIndex = 30;
            this.labDisgusta.Text = "Disgusta";
            // 
            // tbDetalleClinico
            // 
            this.tbDetalleClinico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDetalleClinico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDetalleClinico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDetalleClinico.Depth = 0;
            this.tbDetalleClinico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDetalleClinico.HideSelection = true;
            this.tbDetalleClinico.Hint = "Escriba el diagnostico aquí";
            this.tbDetalleClinico.Location = new System.Drawing.Point(3, 63);
            this.tbDetalleClinico.MaxLength = 32767;
            this.tbDetalleClinico.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDetalleClinico.Name = "tbDetalleClinico";
            this.tbDetalleClinico.PasswordChar = '\0';
            this.tbDetalleClinico.ReadOnly = false;
            this.tbDetalleClinico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDetalleClinico.SelectedText = "";
            this.tbDetalleClinico.SelectionLength = 0;
            this.tbDetalleClinico.SelectionStart = 0;
            this.tbDetalleClinico.ShortcutsEnabled = true;
            this.tbDetalleClinico.Size = new System.Drawing.Size(274, 264);
            this.tbDetalleClinico.TabIndex = 31;
            this.tbDetalleClinico.TabStop = false;
            this.tbDetalleClinico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDetalleClinico.UseSystemPasswordChar = false;
            // 
            // tlpCitasProgramadasHistoricas
            // 
            this.tlpCitasProgramadasHistoricas.ColumnCount = 1;
            this.tlpCitasProgramadasHistoricas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCitasProgramadasHistoricas.Controls.Add(this.tcTabControl, 0, 1);
            this.tlpCitasProgramadasHistoricas.Controls.Add(this.panTituloTab, 0, 0);
            this.tlpCitasProgramadasHistoricas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCitasProgramadasHistoricas.Location = new System.Drawing.Point(0, 0);
            this.tlpCitasProgramadasHistoricas.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCitasProgramadasHistoricas.Name = "tlpCitasProgramadasHistoricas";
            this.tlpCitasProgramadasHistoricas.RowCount = 2;
            this.tlpCitasProgramadasHistoricas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCitasProgramadasHistoricas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCitasProgramadasHistoricas.Size = new System.Drawing.Size(300, 571);
            this.tlpCitasProgramadasHistoricas.TabIndex = 30;
            // 
            // panTituloTab
            // 
            this.panTituloTab.Controls.Add(this.tsTabControl);
            this.panTituloTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTituloTab.Location = new System.Drawing.Point(0, 0);
            this.panTituloTab.Margin = new System.Windows.Forms.Padding(0);
            this.panTituloTab.Name = "panTituloTab";
            this.panTituloTab.Size = new System.Drawing.Size(300, 50);
            this.panTituloTab.TabIndex = 1;
            // 
            // labFechaCita
            // 
            this.labFechaCita.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFechaCita.Location = new System.Drawing.Point(7, 202);
            this.labFechaCita.Name = "labFechaCita";
            this.labFechaCita.Size = new System.Drawing.Size(100, 23);
            this.labFechaCita.TabIndex = 30;
            this.labFechaCita.Text = "Fecha";
            this.labFechaCita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHoraCita
            // 
            this.labHoraCita.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHoraCita.Location = new System.Drawing.Point(7, 219);
            this.labHoraCita.Name = "labHoraCita";
            this.labHoraCita.Size = new System.Drawing.Size(100, 23);
            this.labHoraCita.TabIndex = 31;
            this.labHoraCita.Text = "Hora";
            this.labHoraCita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labFechaHoraAtencionCita
            // 
            this.labFechaHoraAtencionCita.AutoSize = true;
            this.labFechaHoraAtencionCita.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFechaHoraAtencionCita.Location = new System.Drawing.Point(19, 185);
            this.labFechaHoraAtencionCita.Name = "labFechaHoraAtencionCita";
            this.labFechaHoraAtencionCita.Size = new System.Drawing.Size(78, 17);
            this.labFechaHoraAtencionCita.TabIndex = 32;
            this.labFechaHoraAtencionCita.Text = "Cita del día";
            // 
            // frmCitasNutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 571);
            this.Controls.Add(this.tlpPrincipalGlobal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCitasNutricionista";
            this.Text = "Citas";
            this.tcTabControl.ResumeLayout(false);
            this.tpCitasProgramadas.ResumeLayout(false);
            this.tpCitasHistoricas.ResumeLayout(false);
            this.tlpPrincipalGlobal.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.panFoto.ResumeLayout(false);
            this.panFoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tlpEventos.ResumeLayout(false);
            this.tlpEventos.PerformLayout();
            this.panNotasImportantes.ResumeLayout(false);
            this.tlpDetalleClinico.ResumeLayout(false);
            this.tlpDetalleClinico.PerformLayout();
            this.panBotonesInferiores.ResumeLayout(false);
            this.panBotonesInferiores.PerformLayout();
            this.tlpPreferenciasAlimentarias.ResumeLayout(false);
            this.tlpPreferenciasAlimentarias.PerformLayout();
            this.tlpCitasProgramadasHistoricas.ResumeLayout(false);
            this.panTituloTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector tsTabControl;
        private MaterialSkin.Controls.MaterialTabControl tcTabControl;
        private System.Windows.Forms.TabPage tpCitasProgramadas;
        private System.Windows.Forms.TabPage tpCitasHistoricas;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipalGlobal;
        private System.Windows.Forms.TableLayoutPanel tlpCitasProgramadasHistoricas;
        private System.Windows.Forms.Panel panTituloTab;
        private System.Windows.Forms.Panel panCItasHist;
        private System.Windows.Forms.Panel panCitasProg;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel panFoto;
        private System.Windows.Forms.Label labEdad;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TableLayoutPanel tlpEventos;
        private MaterialSkin.Controls.MaterialButton btnRegistrarAtencion;
        private System.Windows.Forms.Label labEventos;
        private System.Windows.Forms.Panel panHistorialCitas;
        private System.Windows.Forms.Label lanNotasImportantes;
        private System.Windows.Forms.Panel panNotasImportantes;
        private MaterialSkin.Controls.MaterialMultiLineTextBox tbAlimentosAlergias;
        private MaterialSkin.Controls.MaterialMultiLineTextBox tbNotasImportantes;
        private System.Windows.Forms.TableLayoutPanel tlpDetalleClinico;
        private System.Windows.Forms.Label labDetalleClinico;
        private System.Windows.Forms.Panel panBotonesInferiores;
        private MaterialSkin.Controls.MaterialButton btnAnhadirPlanAlimentario;
        private MaterialSkin.Controls.MaterialButton btnAnhadirHistorialClinico;
        private System.Windows.Forms.Label labPreferenciasAlimentarias;
        private MaterialSkin.Controls.MaterialLabel lanNombrePaciente;
        private System.Windows.Forms.TableLayoutPanel tlpPreferenciasAlimentarias;
        private MaterialSkin.Controls.MaterialMultiLineTextBox tbAlimentosGusta;
        private MaterialSkin.Controls.MaterialMultiLineTextBox tbAlimentosDisgusta;
        private System.Windows.Forms.Label labGusta;
        private System.Windows.Forms.Label labDisgusta;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbDetalleClinico;
        private System.Windows.Forms.Label labFechaCita;
        private System.Windows.Forms.Label labHoraCita;
        private System.Windows.Forms.Label labFechaHoraAtencionCita;
    }
}