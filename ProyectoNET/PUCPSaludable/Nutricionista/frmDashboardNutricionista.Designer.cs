
namespace PUCPSaludable.Nutricionista
{
    partial class frmDashboardNutricionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardNutricionista));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panTitulo = new System.Windows.Forms.Panel();
            this.labMensaje = new MaterialSkin.Controls.MaterialLabel();
            this.labSaludo = new MaterialSkin.Controls.MaterialLabel();
            this.tlpSeparacion1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSeparacion11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGraficoIMCSueno = new System.Windows.Forms.TableLayoutPanel();
            this.labCantidadAtendidos = new System.Windows.Forms.Label();
            this.labGraficoIMCPromEsp = new System.Windows.Forms.Label();
            this.wvCitasMes = new PUCPSaludable.Controles.ucWebView();
            this.wvIMCEspecialidad = new PUCPSaludable.Controles.ucWebView();
            this.tlpSeparacion12 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGraficoVideo = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHorasSueno = new System.Windows.Forms.TableLayoutPanel();
            this.labGraficoVideo = new System.Windows.Forms.Label();
            this.btnElegirVideo = new MaterialSkin.Controls.MaterialButton();
            this.wvVideos = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tlpEventos = new System.Windows.Forms.TableLayoutPanel();
            this.labEventos = new System.Windows.Forms.Label();
            this.panEventos = new System.Windows.Forms.Panel();
            this.labGraficoCantCatIMC = new System.Windows.Forms.Label();
            this.wvIMCCategoriaIMC = new PUCPSaludable.Controles.ucWebView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarMensaje = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbTitulo = new MaterialSkin.Controls.MaterialTextBox();
            this.tbMensaje = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.labSave = new MaterialSkin.Controls.MaterialLabel();
            this.tlpPrincipal.SuspendLayout();
            this.panTitulo.SuspendLayout();
            this.tlpSeparacion1.SuspendLayout();
            this.tlpSeparacion11.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpGraficoIMCSueno.SuspendLayout();
            this.tlpSeparacion12.SuspendLayout();
            this.tlpGraficoVideo.SuspendLayout();
            this.tlpHorasSueno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideos)).BeginInit();
            this.tlpEventos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.panTitulo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpSeparacion1, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tlpPrincipal.TabIndex = 2;
            // 
            // panTitulo
            // 
            this.panTitulo.Controls.Add(this.labMensaje);
            this.panTitulo.Controls.Add(this.labSaludo);
            this.panTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTitulo.Location = new System.Drawing.Point(3, 3);
            this.panTitulo.Name = "panTitulo";
            this.panTitulo.Size = new System.Drawing.Size(794, 44);
            this.panTitulo.TabIndex = 0;
            // 
            // labMensaje
            // 
            this.labMensaje.AutoSize = true;
            this.labMensaje.Depth = 0;
            this.labMensaje.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labMensaje.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labMensaje.Location = new System.Drawing.Point(6, 25);
            this.labMensaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.labMensaje.Name = "labMensaje";
            this.labMensaje.Size = new System.Drawing.Size(222, 14);
            this.labMensaje.TabIndex = 5;
            this.labMensaje.Text = "Este es un resumen de lo más importante";
            // 
            // labSaludo
            // 
            this.labSaludo.AutoSize = true;
            this.labSaludo.Depth = 0;
            this.labSaludo.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labSaludo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labSaludo.Location = new System.Drawing.Point(6, 0);
            this.labSaludo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labSaludo.Name = "labSaludo";
            this.labSaludo.Size = new System.Drawing.Size(100, 24);
            this.labSaludo.TabIndex = 4;
            this.labSaludo.Text = "Hola, Juan!";
            // 
            // tlpSeparacion1
            // 
            this.tlpSeparacion1.ColumnCount = 2;
            this.tlpSeparacion1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpSeparacion1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpSeparacion1.Controls.Add(this.tlpSeparacion11, 0, 0);
            this.tlpSeparacion1.Controls.Add(this.tlpSeparacion12, 1, 0);
            this.tlpSeparacion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeparacion1.Location = new System.Drawing.Point(3, 53);
            this.tlpSeparacion1.Name = "tlpSeparacion1";
            this.tlpSeparacion1.RowCount = 1;
            this.tlpSeparacion1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeparacion1.Size = new System.Drawing.Size(794, 394);
            this.tlpSeparacion1.TabIndex = 1;
            // 
            // tlpSeparacion11
            // 
            this.tlpSeparacion11.ColumnCount = 1;
            this.tlpSeparacion11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeparacion11.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpSeparacion11.Controls.Add(this.tlpGraficoIMCSueno, 0, 0);
            this.tlpSeparacion11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeparacion11.Location = new System.Drawing.Point(3, 3);
            this.tlpSeparacion11.Name = "tlpSeparacion11";
            this.tlpSeparacion11.RowCount = 2;
            this.tlpSeparacion11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeparacion11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeparacion11.Size = new System.Drawing.Size(444, 388);
            this.tlpSeparacion11.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.wvIMCCategoriaIMC, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labGraficoCantCatIMC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 197);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 188);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tlpGraficoIMCSueno
            // 
            this.tlpGraficoIMCSueno.ColumnCount = 2;
            this.tlpGraficoIMCSueno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraficoIMCSueno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraficoIMCSueno.Controls.Add(this.labCantidadAtendidos, 0, 0);
            this.tlpGraficoIMCSueno.Controls.Add(this.labGraficoIMCPromEsp, 1, 0);
            this.tlpGraficoIMCSueno.Controls.Add(this.wvCitasMes, 0, 1);
            this.tlpGraficoIMCSueno.Controls.Add(this.wvIMCEspecialidad, 1, 1);
            this.tlpGraficoIMCSueno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGraficoIMCSueno.Location = new System.Drawing.Point(3, 3);
            this.tlpGraficoIMCSueno.Name = "tlpGraficoIMCSueno";
            this.tlpGraficoIMCSueno.RowCount = 2;
            this.tlpGraficoIMCSueno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpGraficoIMCSueno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGraficoIMCSueno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGraficoIMCSueno.Size = new System.Drawing.Size(438, 188);
            this.tlpGraficoIMCSueno.TabIndex = 1;
            // 
            // labCantidadAtendidos
            // 
            this.labCantidadAtendidos.AutoSize = true;
            this.labCantidadAtendidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidadAtendidos.Location = new System.Drawing.Point(3, 0);
            this.labCantidadAtendidos.Name = "labCantidadAtendidos";
            this.labCantidadAtendidos.Size = new System.Drawing.Size(156, 17);
            this.labCantidadAtendidos.TabIndex = 0;
            this.labCantidadAtendidos.Text = "Citas atendidas por mes";
            // 
            // labGraficoIMCPromEsp
            // 
            this.labGraficoIMCPromEsp.AutoSize = true;
            this.labGraficoIMCPromEsp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGraficoIMCPromEsp.Location = new System.Drawing.Point(222, 0);
            this.labGraficoIMCPromEsp.Name = "labGraficoIMCPromEsp";
            this.labGraficoIMCPromEsp.Size = new System.Drawing.Size(201, 17);
            this.labGraficoIMCPromEsp.TabIndex = 2;
            this.labGraficoIMCPromEsp.Text = "IMC promedio por especialidad";
            // 
            // wvCitasMes
            // 
            this.wvCitasMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvCitasMes.Location = new System.Drawing.Point(6, 39);
            this.wvCitasMes.Margin = new System.Windows.Forms.Padding(6);
            this.wvCitasMes.Name = "wvCitasMes";
            this.wvCitasMes.Size = new System.Drawing.Size(207, 143);
            this.wvCitasMes.TabIndex = 3;
            this.wvCitasMes.URL = null;
            // 
            // wvIMCEspecialidad
            // 
            this.wvIMCEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvIMCEspecialidad.Location = new System.Drawing.Point(225, 39);
            this.wvIMCEspecialidad.Margin = new System.Windows.Forms.Padding(6);
            this.wvIMCEspecialidad.Name = "wvIMCEspecialidad";
            this.wvIMCEspecialidad.Size = new System.Drawing.Size(207, 143);
            this.wvIMCEspecialidad.TabIndex = 4;
            this.wvIMCEspecialidad.URL = null;
            // 
            // tlpSeparacion12
            // 
            this.tlpSeparacion12.ColumnCount = 1;
            this.tlpSeparacion12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeparacion12.Controls.Add(this.tlpGraficoVideo, 0, 1);
            this.tlpSeparacion12.Controls.Add(this.tlpEventos, 0, 0);
            this.tlpSeparacion12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeparacion12.Location = new System.Drawing.Point(453, 3);
            this.tlpSeparacion12.Name = "tlpSeparacion12";
            this.tlpSeparacion12.RowCount = 2;
            this.tlpSeparacion12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeparacion12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeparacion12.Size = new System.Drawing.Size(338, 388);
            this.tlpSeparacion12.TabIndex = 1;
            // 
            // tlpGraficoVideo
            // 
            this.tlpGraficoVideo.ColumnCount = 1;
            this.tlpGraficoVideo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGraficoVideo.Controls.Add(this.tlpHorasSueno, 0, 0);
            this.tlpGraficoVideo.Controls.Add(this.wvVideos, 0, 1);
            this.tlpGraficoVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGraficoVideo.Location = new System.Drawing.Point(3, 197);
            this.tlpGraficoVideo.Name = "tlpGraficoVideo";
            this.tlpGraficoVideo.RowCount = 2;
            this.tlpGraficoVideo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGraficoVideo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGraficoVideo.Size = new System.Drawing.Size(332, 188);
            this.tlpGraficoVideo.TabIndex = 5;
            // 
            // tlpHorasSueno
            // 
            this.tlpHorasSueno.ColumnCount = 2;
            this.tlpHorasSueno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHorasSueno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpHorasSueno.Controls.Add(this.labGraficoVideo, 0, 0);
            this.tlpHorasSueno.Controls.Add(this.btnElegirVideo, 1, 0);
            this.tlpHorasSueno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHorasSueno.Location = new System.Drawing.Point(0, 0);
            this.tlpHorasSueno.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHorasSueno.Name = "tlpHorasSueno";
            this.tlpHorasSueno.RowCount = 1;
            this.tlpHorasSueno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHorasSueno.Size = new System.Drawing.Size(332, 20);
            this.tlpHorasSueno.TabIndex = 7;
            // 
            // labGraficoVideo
            // 
            this.labGraficoVideo.AutoSize = true;
            this.labGraficoVideo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGraficoVideo.Location = new System.Drawing.Point(3, 0);
            this.labGraficoVideo.Name = "labGraficoVideo";
            this.labGraficoVideo.Size = new System.Drawing.Size(121, 17);
            this.labGraficoVideo.TabIndex = 2;
            this.labGraficoVideo.Text = "Video informativo";
            // 
            // btnElegirVideo
            // 
            this.btnElegirVideo.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnElegirVideo.AutoSize = false;
            this.btnElegirVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnElegirVideo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnElegirVideo.Depth = 0;
            this.btnElegirVideo.DrawShadows = false;
            this.btnElegirVideo.HighEmphasis = true;
            this.btnElegirVideo.Icon = null;
            this.btnElegirVideo.Location = new System.Drawing.Point(290, 0);
            this.btnElegirVideo.Margin = new System.Windows.Forms.Padding(0);
            this.btnElegirVideo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnElegirVideo.Name = "btnElegirVideo";
            this.btnElegirVideo.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnElegirVideo.Size = new System.Drawing.Size(40, 20);
            this.btnElegirVideo.TabIndex = 0;
            this.btnElegirVideo.Text = "+";
            this.btnElegirVideo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnElegirVideo.UseAccentColor = true;
            this.btnElegirVideo.UseVisualStyleBackColor = true;
            this.btnElegirVideo.Click += new System.EventHandler(this.btnElegirVideo_Click);
            // 
            // wvVideos
            // 
            this.wvVideos.CreationProperties = null;
            this.wvVideos.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvVideos.Location = new System.Drawing.Point(3, 23);
            this.wvVideos.Name = "wvVideos";
            this.wvVideos.Size = new System.Drawing.Size(326, 162);
            this.wvVideos.TabIndex = 2;
            this.wvVideos.ZoomFactor = 1D;
            // 
            // tlpEventos
            // 
            this.tlpEventos.ColumnCount = 1;
            this.tlpEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEventos.Controls.Add(this.labEventos, 0, 0);
            this.tlpEventos.Controls.Add(this.panEventos, 0, 1);
            this.tlpEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEventos.Location = new System.Drawing.Point(3, 3);
            this.tlpEventos.Name = "tlpEventos";
            this.tlpEventos.RowCount = 2;
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEventos.Size = new System.Drawing.Size(332, 188);
            this.tlpEventos.TabIndex = 4;
            // 
            // labEventos
            // 
            this.labEventos.AutoSize = true;
            this.labEventos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEventos.Location = new System.Drawing.Point(3, 0);
            this.labEventos.Name = "labEventos";
            this.labEventos.Size = new System.Drawing.Size(123, 17);
            this.labEventos.TabIndex = 0;
            this.labEventos.Text = "Citas programadas";
            // 
            // panEventos
            // 
            this.panEventos.AutoScroll = true;
            this.panEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panEventos.Location = new System.Drawing.Point(3, 23);
            this.panEventos.Name = "panEventos";
            this.panEventos.Size = new System.Drawing.Size(326, 162);
            this.panEventos.TabIndex = 1;
            // 
            // labGraficoCantCatIMC
            // 
            this.labGraficoCantCatIMC.AutoSize = true;
            this.labGraficoCantCatIMC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGraficoCantCatIMC.Location = new System.Drawing.Point(3, 0);
            this.labGraficoCantCatIMC.Name = "labGraficoCantCatIMC";
            this.labGraficoCantCatIMC.Size = new System.Drawing.Size(196, 17);
            this.labGraficoCantCatIMC.TabIndex = 4;
            this.labGraficoCantCatIMC.Text = "Alumnos por categoría de IMC";
            // 
            // wvIMCCategoriaIMC
            // 
            this.wvIMCCategoriaIMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvIMCCategoriaIMC.Location = new System.Drawing.Point(6, 26);
            this.wvIMCCategoriaIMC.Margin = new System.Windows.Forms.Padding(6);
            this.wvIMCCategoriaIMC.Name = "wvIMCCategoriaIMC";
            this.wvIMCCategoriaIMC.Size = new System.Drawing.Size(207, 156);
            this.wvIMCCategoriaIMC.TabIndex = 9;
            this.wvIMCCategoriaIMC.URL = null;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGuardarMensaje, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(219, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(219, 20);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mensaje informativo";
            // 
            // btnGuardarMensaje
            // 
            this.btnGuardarMensaje.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnGuardarMensaje.AutoSize = false;
            this.btnGuardarMensaje.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarMensaje.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarMensaje.Depth = 0;
            this.btnGuardarMensaje.DrawShadows = false;
            this.btnGuardarMensaje.HighEmphasis = true;
            this.btnGuardarMensaje.Icon = null;
            this.btnGuardarMensaje.Location = new System.Drawing.Point(177, 0);
            this.btnGuardarMensaje.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardarMensaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarMensaje.Name = "btnGuardarMensaje";
            this.btnGuardarMensaje.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnGuardarMensaje.Size = new System.Drawing.Size(40, 20);
            this.btnGuardarMensaje.TabIndex = 0;
            this.btnGuardarMensaje.Text = "+";
            this.btnGuardarMensaje.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarMensaje.UseAccentColor = true;
            this.btnGuardarMensaje.UseVisualStyleBackColor = true;
            this.btnGuardarMensaje.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tbTitulo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbMensaje, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labSave, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(219, 20);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(219, 168);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // tbTitulo
            // 
            this.tbTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbTitulo.Depth = 0;
            this.tbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitulo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTitulo.HideSelection = true;
            this.tbTitulo.Hint = "Título";
            this.tbTitulo.LeadingIcon = null;
            this.tbTitulo.Location = new System.Drawing.Point(0, 0);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.tbTitulo.MaxLength = 255;
            this.tbTitulo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.PasswordChar = '\0';
            this.tbTitulo.PrefixSuffixText = null;
            this.tbTitulo.ReadOnly = false;
            this.tbTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTitulo.SelectedText = "";
            this.tbTitulo.SelectionLength = 0;
            this.tbTitulo.SelectionStart = 0;
            this.tbTitulo.ShortcutsEnabled = true;
            this.tbTitulo.Size = new System.Drawing.Size(219, 48);
            this.tbTitulo.TabIndex = 0;
            this.tbTitulo.TabStop = false;
            this.tbTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTitulo.TrailingIcon = null;
            this.tbTitulo.UseSystemPasswordChar = false;
            // 
            // tbMensaje
            // 
            this.tbMensaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbMensaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMensaje.Depth = 0;
            this.tbMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMensaje.HideSelection = true;
            this.tbMensaje.Hint = "Mensaje";
            this.tbMensaje.Location = new System.Drawing.Point(0, 52);
            this.tbMensaje.Margin = new System.Windows.Forms.Padding(0);
            this.tbMensaje.MaxLength = 600;
            this.tbMensaje.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.PasswordChar = '\0';
            this.tbMensaje.ReadOnly = false;
            this.tbMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMensaje.SelectedText = "";
            this.tbMensaje.SelectionLength = 0;
            this.tbMensaje.SelectionStart = 0;
            this.tbMensaje.ShortcutsEnabled = true;
            this.tbMensaje.Size = new System.Drawing.Size(219, 96);
            this.tbMensaje.TabIndex = 1;
            this.tbMensaje.TabStop = false;
            this.tbMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMensaje.UseSystemPasswordChar = false;
            // 
            // labSave
            // 
            this.labSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labSave.AutoSize = true;
            this.labSave.Depth = 0;
            this.labSave.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labSave.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labSave.Location = new System.Drawing.Point(158, 155);
            this.labSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.labSave.Name = "labSave";
            this.labSave.Size = new System.Drawing.Size(58, 13);
            this.labSave.TabIndex = 2;
            this.labSave.Text = "Guardado...";
            // 
            // frmDashboardNutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboardNutricionista";
            this.Text = "PUCP Saludable";
            this.Load += new System.EventHandler(this.frmDashboardNutricionista_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.panTitulo.ResumeLayout(false);
            this.panTitulo.PerformLayout();
            this.tlpSeparacion1.ResumeLayout(false);
            this.tlpSeparacion11.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpGraficoIMCSueno.ResumeLayout(false);
            this.tlpGraficoIMCSueno.PerformLayout();
            this.tlpSeparacion12.ResumeLayout(false);
            this.tlpGraficoVideo.ResumeLayout(false);
            this.tlpHorasSueno.ResumeLayout(false);
            this.tlpHorasSueno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideos)).EndInit();
            this.tlpEventos.ResumeLayout(false);
            this.tlpEventos.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel panTitulo;
        private MaterialSkin.Controls.MaterialLabel labMensaje;
        private MaterialSkin.Controls.MaterialLabel labSaludo;
        private System.Windows.Forms.TableLayoutPanel tlpSeparacion1;
        private System.Windows.Forms.TableLayoutPanel tlpSeparacion11;
        private System.Windows.Forms.TableLayoutPanel tlpGraficoIMCSueno;
        private System.Windows.Forms.Label labGraficoIMCPromEsp;
        private Controles.ucWebView wvCitasMes;
        private Controles.ucWebView wvIMCEspecialidad;
        private System.Windows.Forms.TableLayoutPanel tlpSeparacion12;
        private System.Windows.Forms.TableLayoutPanel tlpEventos;
        private System.Windows.Forms.Label labEventos;
        private System.Windows.Forms.Panel panEventos;
        private System.Windows.Forms.Label labCantidadAtendidos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpGraficoVideo;
        private System.Windows.Forms.TableLayoutPanel tlpHorasSueno;
        private System.Windows.Forms.Label labGraficoVideo;
        private MaterialSkin.Controls.MaterialButton btnElegirVideo;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvVideos;
        private Controles.ucWebView wvIMCCategoriaIMC;
        private System.Windows.Forms.Label labGraficoCantCatIMC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnGuardarMensaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialTextBox tbTitulo;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbMensaje;
        private MaterialSkin.Controls.MaterialLabel labSave;
    }
}
