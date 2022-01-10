
namespace PUCPSaludable.Alumno
{
    partial class frmPlanAlimentario
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
            this.tlp_base = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerarPDF = new MaterialSkin.Controls.MaterialButton();
            this.btnLista = new MaterialSkin.Controls.MaterialButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.panCalendario = new System.Windows.Forms.Panel();
            this.tlpCalendario = new System.Windows.Forms.TableLayoutPanel();
            this.panHeaderMiercoles = new System.Windows.Forms.Panel();
            this.labHeaderMiercoles = new System.Windows.Forms.Label();
            this.panHeaderSabado = new System.Windows.Forms.Panel();
            this.labHeaderSabado = new System.Windows.Forms.Label();
            this.panHeaderViernes = new System.Windows.Forms.Panel();
            this.labHeaderViernes = new System.Windows.Forms.Label();
            this.panHeaderJueves = new System.Windows.Forms.Panel();
            this.labHeaderJueves = new System.Windows.Forms.Label();
            this.panHeaderMartes = new System.Windows.Forms.Panel();
            this.labHeaderMartes = new System.Windows.Forms.Label();
            this.panHeaderLunes = new System.Windows.Forms.Panel();
            this.labHeaderLunes = new System.Windows.Forms.Label();
            this.panHeaderDomingo = new System.Windows.Forms.Panel();
            this.labHeaderDomingo = new System.Windows.Forms.Label();
            this.panComida = new System.Windows.Forms.Panel();
            this.labHeaderComida = new System.Windows.Forms.Label();
            this.labDesayuno = new MaterialSkin.Controls.MaterialLabel();
            this.labMediMan = new MaterialSkin.Controls.MaterialLabel();
            this.labAlmuerzo = new MaterialSkin.Controls.MaterialLabel();
            this.labMerienda = new MaterialSkin.Controls.MaterialLabel();
            this.Cena = new MaterialSkin.Controls.MaterialLabel();
            this.tlp_base.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panCalendario.SuspendLayout();
            this.tlpCalendario.SuspendLayout();
            this.panHeaderMiercoles.SuspendLayout();
            this.panHeaderSabado.SuspendLayout();
            this.panHeaderViernes.SuspendLayout();
            this.panHeaderJueves.SuspendLayout();
            this.panHeaderMartes.SuspendLayout();
            this.panHeaderLunes.SuspendLayout();
            this.panHeaderDomingo.SuspendLayout();
            this.panComida.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_base
            // 
            this.tlp_base.ColumnCount = 3;
            this.tlp_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_base.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tlp_base.Controls.Add(this.panCalendario, 1, 2);
            this.tlp_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_base.Location = new System.Drawing.Point(0, 0);
            this.tlp_base.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_base.Name = "tlp_base";
            this.tlp_base.RowCount = 4;
            this.tlp_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_base.Size = new System.Drawing.Size(784, 561);
            this.tlp_base.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnGenerarPDF, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLista, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 40);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnGenerarPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerarPDF.Depth = 0;
            this.btnGenerarPDF.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerarPDF.DrawShadows = false;
            this.btnGenerarPDF.HighEmphasis = true;
            this.btnGenerarPDF.Icon = null;
            this.btnGenerarPDF.Location = new System.Drawing.Point(587, 6);
            this.btnGenerarPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerarPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnGenerarPDF.Size = new System.Drawing.Size(173, 28);
            this.btnGenerarPDF.TabIndex = 4;
            this.btnGenerarPDF.Text = "exportar COMO pdf";
            this.btnGenerarPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerarPDF.UseAccentColor = true;
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // btnLista
            // 
            this.btnLista.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnLista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLista.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLista.Depth = 0;
            this.btnLista.DrawShadows = false;
            this.btnLista.HighEmphasis = true;
            this.btnLista.Icon = null;
            this.btnLista.Location = new System.Drawing.Point(4, 6);
            this.btnLista.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLista.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLista.Name = "btnLista";
            this.btnLista.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLista.Size = new System.Drawing.Size(225, 28);
            this.btnLista.TabIndex = 5;
            this.btnLista.Text = "GENERAR LISTA DE COMPRAS";
            this.btnLista.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLista.UseAccentColor = true;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panCalendario
            // 
            this.panCalendario.Controls.Add(this.tlpCalendario);
            this.panCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCalendario.Location = new System.Drawing.Point(10, 50);
            this.panCalendario.Margin = new System.Windows.Forms.Padding(0);
            this.panCalendario.Name = "panCalendario";
            this.panCalendario.Size = new System.Drawing.Size(764, 501);
            this.panCalendario.TabIndex = 5;
            // 
            // tlpCalendario
            // 
            this.tlpCalendario.ColumnCount = 8;
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCalendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCalendario.Controls.Add(this.panHeaderMiercoles, 4, 0);
            this.tlpCalendario.Controls.Add(this.panHeaderSabado, 7, 0);
            this.tlpCalendario.Controls.Add(this.panHeaderViernes, 6, 0);
            this.tlpCalendario.Controls.Add(this.panHeaderJueves, 5, 0);
            this.tlpCalendario.Controls.Add(this.panHeaderMartes, 3, 0);
            this.tlpCalendario.Controls.Add(this.panHeaderLunes, 2, 0);
            this.tlpCalendario.Controls.Add(this.panHeaderDomingo, 1, 0);
            this.tlpCalendario.Controls.Add(this.panComida, 0, 0);
            this.tlpCalendario.Controls.Add(this.labDesayuno, 0, 1);
            this.tlpCalendario.Controls.Add(this.labMediMan, 0, 2);
            this.tlpCalendario.Controls.Add(this.labAlmuerzo, 0, 3);
            this.tlpCalendario.Controls.Add(this.labMerienda, 0, 4);
            this.tlpCalendario.Controls.Add(this.Cena, 0, 5);
            this.tlpCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCalendario.Location = new System.Drawing.Point(0, 0);
            this.tlpCalendario.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCalendario.Name = "tlpCalendario";
            this.tlpCalendario.RowCount = 6;
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCalendario.Size = new System.Drawing.Size(764, 501);
            this.tlpCalendario.TabIndex = 4;
            // 
            // panHeaderMiercoles
            // 
            this.panHeaderMiercoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.panHeaderMiercoles.Controls.Add(this.labHeaderMiercoles);
            this.panHeaderMiercoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHeaderMiercoles.Location = new System.Drawing.Point(380, 0);
            this.panHeaderMiercoles.Margin = new System.Windows.Forms.Padding(0);
            this.panHeaderMiercoles.Name = "panHeaderMiercoles";
            this.panHeaderMiercoles.Size = new System.Drawing.Size(95, 30);
            this.panHeaderMiercoles.TabIndex = 3;
            // 
            // labHeaderMiercoles
            // 
            this.labHeaderMiercoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.labHeaderMiercoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labHeaderMiercoles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderMiercoles.ForeColor = System.Drawing.Color.White;
            this.labHeaderMiercoles.Location = new System.Drawing.Point(0, 0);
            this.labHeaderMiercoles.Name = "labHeaderMiercoles";
            this.labHeaderMiercoles.Size = new System.Drawing.Size(95, 30);
            this.labHeaderMiercoles.TabIndex = 1;
            this.labHeaderMiercoles.Text = "Miércoles";
            this.labHeaderMiercoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderSabado
            // 
            this.panHeaderSabado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.panHeaderSabado.Controls.Add(this.labHeaderSabado);
            this.panHeaderSabado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHeaderSabado.Location = new System.Drawing.Point(665, 0);
            this.panHeaderSabado.Margin = new System.Windows.Forms.Padding(0);
            this.panHeaderSabado.Name = "panHeaderSabado";
            this.panHeaderSabado.Size = new System.Drawing.Size(99, 30);
            this.panHeaderSabado.TabIndex = 6;
            // 
            // labHeaderSabado
            // 
            this.labHeaderSabado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.labHeaderSabado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labHeaderSabado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderSabado.ForeColor = System.Drawing.Color.White;
            this.labHeaderSabado.Location = new System.Drawing.Point(0, 0);
            this.labHeaderSabado.Name = "labHeaderSabado";
            this.labHeaderSabado.Size = new System.Drawing.Size(99, 30);
            this.labHeaderSabado.TabIndex = 1;
            this.labHeaderSabado.Text = "Sábado";
            this.labHeaderSabado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderViernes
            // 
            this.panHeaderViernes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.panHeaderViernes.Controls.Add(this.labHeaderViernes);
            this.panHeaderViernes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHeaderViernes.Location = new System.Drawing.Point(570, 0);
            this.panHeaderViernes.Margin = new System.Windows.Forms.Padding(0);
            this.panHeaderViernes.Name = "panHeaderViernes";
            this.panHeaderViernes.Size = new System.Drawing.Size(95, 30);
            this.panHeaderViernes.TabIndex = 5;
            // 
            // labHeaderViernes
            // 
            this.labHeaderViernes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.labHeaderViernes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labHeaderViernes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderViernes.ForeColor = System.Drawing.Color.White;
            this.labHeaderViernes.Location = new System.Drawing.Point(0, 0);
            this.labHeaderViernes.Name = "labHeaderViernes";
            this.labHeaderViernes.Size = new System.Drawing.Size(95, 30);
            this.labHeaderViernes.TabIndex = 1;
            this.labHeaderViernes.Text = "Viernes";
            this.labHeaderViernes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderJueves
            // 
            this.panHeaderJueves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.panHeaderJueves.Controls.Add(this.labHeaderJueves);
            this.panHeaderJueves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHeaderJueves.Location = new System.Drawing.Point(475, 0);
            this.panHeaderJueves.Margin = new System.Windows.Forms.Padding(0);
            this.panHeaderJueves.Name = "panHeaderJueves";
            this.panHeaderJueves.Size = new System.Drawing.Size(95, 30);
            this.panHeaderJueves.TabIndex = 4;
            // 
            // labHeaderJueves
            // 
            this.labHeaderJueves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.labHeaderJueves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labHeaderJueves.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderJueves.ForeColor = System.Drawing.Color.White;
            this.labHeaderJueves.Location = new System.Drawing.Point(0, 0);
            this.labHeaderJueves.Name = "labHeaderJueves";
            this.labHeaderJueves.Size = new System.Drawing.Size(95, 30);
            this.labHeaderJueves.TabIndex = 1;
            this.labHeaderJueves.Text = "Jueves";
            this.labHeaderJueves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderMartes
            // 
            this.panHeaderMartes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.panHeaderMartes.Controls.Add(this.labHeaderMartes);
            this.panHeaderMartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHeaderMartes.Location = new System.Drawing.Point(285, 0);
            this.panHeaderMartes.Margin = new System.Windows.Forms.Padding(0);
            this.panHeaderMartes.Name = "panHeaderMartes";
            this.panHeaderMartes.Size = new System.Drawing.Size(95, 30);
            this.panHeaderMartes.TabIndex = 2;
            // 
            // labHeaderMartes
            // 
            this.labHeaderMartes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.labHeaderMartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labHeaderMartes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderMartes.ForeColor = System.Drawing.Color.White;
            this.labHeaderMartes.Location = new System.Drawing.Point(0, 0);
            this.labHeaderMartes.Name = "labHeaderMartes";
            this.labHeaderMartes.Size = new System.Drawing.Size(95, 30);
            this.labHeaderMartes.TabIndex = 1;
            this.labHeaderMartes.Text = "Martes";
            this.labHeaderMartes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderLunes
            // 
            this.panHeaderLunes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.panHeaderLunes.Controls.Add(this.labHeaderLunes);
            this.panHeaderLunes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHeaderLunes.Location = new System.Drawing.Point(190, 0);
            this.panHeaderLunes.Margin = new System.Windows.Forms.Padding(0);
            this.panHeaderLunes.Name = "panHeaderLunes";
            this.panHeaderLunes.Size = new System.Drawing.Size(95, 30);
            this.panHeaderLunes.TabIndex = 1;
            // 
            // labHeaderLunes
            // 
            this.labHeaderLunes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.labHeaderLunes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labHeaderLunes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderLunes.ForeColor = System.Drawing.Color.White;
            this.labHeaderLunes.Location = new System.Drawing.Point(0, 0);
            this.labHeaderLunes.Name = "labHeaderLunes";
            this.labHeaderLunes.Size = new System.Drawing.Size(95, 30);
            this.labHeaderLunes.TabIndex = 1;
            this.labHeaderLunes.Text = "Lunes";
            this.labHeaderLunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderDomingo
            // 
            this.panHeaderDomingo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.panHeaderDomingo.Controls.Add(this.labHeaderDomingo);
            this.panHeaderDomingo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHeaderDomingo.Location = new System.Drawing.Point(95, 0);
            this.panHeaderDomingo.Margin = new System.Windows.Forms.Padding(0);
            this.panHeaderDomingo.Name = "panHeaderDomingo";
            this.panHeaderDomingo.Size = new System.Drawing.Size(95, 30);
            this.panHeaderDomingo.TabIndex = 0;
            // 
            // labHeaderDomingo
            // 
            this.labHeaderDomingo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.labHeaderDomingo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labHeaderDomingo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderDomingo.ForeColor = System.Drawing.Color.White;
            this.labHeaderDomingo.Location = new System.Drawing.Point(0, 0);
            this.labHeaderDomingo.Name = "labHeaderDomingo";
            this.labHeaderDomingo.Size = new System.Drawing.Size(95, 30);
            this.labHeaderDomingo.TabIndex = 1;
            this.labHeaderDomingo.Text = "Domingo";
            this.labHeaderDomingo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panComida
            // 
            this.panComida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.panComida.Controls.Add(this.labHeaderComida);
            this.panComida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panComida.Location = new System.Drawing.Point(0, 0);
            this.panComida.Margin = new System.Windows.Forms.Padding(0);
            this.panComida.Name = "panComida";
            this.panComida.Size = new System.Drawing.Size(95, 30);
            this.panComida.TabIndex = 7;
            // 
            // labHeaderComida
            // 
            this.labHeaderComida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.labHeaderComida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labHeaderComida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderComida.ForeColor = System.Drawing.Color.White;
            this.labHeaderComida.Location = new System.Drawing.Point(0, 0);
            this.labHeaderComida.Name = "labHeaderComida";
            this.labHeaderComida.Size = new System.Drawing.Size(95, 30);
            this.labHeaderComida.TabIndex = 0;
            this.labHeaderComida.Text = "Comida";
            this.labHeaderComida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDesayuno
            // 
            this.labDesayuno.AutoSize = true;
            this.labDesayuno.BackColor = System.Drawing.Color.Transparent;
            this.labDesayuno.Depth = 0;
            this.labDesayuno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labDesayuno.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labDesayuno.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labDesayuno.Location = new System.Drawing.Point(10, 40);
            this.labDesayuno.Margin = new System.Windows.Forms.Padding(10);
            this.labDesayuno.MouseState = MaterialSkin.MouseState.HOVER;
            this.labDesayuno.Name = "labDesayuno";
            this.labDesayuno.Size = new System.Drawing.Size(75, 74);
            this.labDesayuno.TabIndex = 9;
            this.labDesayuno.Text = "Desayuno";
            this.labDesayuno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMediMan
            // 
            this.labMediMan.AutoSize = true;
            this.labMediMan.BackColor = System.Drawing.Color.Transparent;
            this.labMediMan.Depth = 0;
            this.labMediMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMediMan.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labMediMan.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labMediMan.Location = new System.Drawing.Point(10, 134);
            this.labMediMan.Margin = new System.Windows.Forms.Padding(10);
            this.labMediMan.MouseState = MaterialSkin.MouseState.HOVER;
            this.labMediMan.Name = "labMediMan";
            this.labMediMan.Size = new System.Drawing.Size(75, 74);
            this.labMediMan.TabIndex = 10;
            this.labMediMan.Text = "Media Mañana";
            this.labMediMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAlmuerzo
            // 
            this.labAlmuerzo.AutoSize = true;
            this.labAlmuerzo.BackColor = System.Drawing.Color.Transparent;
            this.labAlmuerzo.Depth = 0;
            this.labAlmuerzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labAlmuerzo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labAlmuerzo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labAlmuerzo.Location = new System.Drawing.Point(10, 228);
            this.labAlmuerzo.Margin = new System.Windows.Forms.Padding(10);
            this.labAlmuerzo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labAlmuerzo.Name = "labAlmuerzo";
            this.labAlmuerzo.Size = new System.Drawing.Size(75, 74);
            this.labAlmuerzo.TabIndex = 11;
            this.labAlmuerzo.Text = "Almuerzo";
            this.labAlmuerzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMerienda
            // 
            this.labMerienda.AutoSize = true;
            this.labMerienda.BackColor = System.Drawing.Color.Transparent;
            this.labMerienda.Depth = 0;
            this.labMerienda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMerienda.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labMerienda.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labMerienda.Location = new System.Drawing.Point(10, 322);
            this.labMerienda.Margin = new System.Windows.Forms.Padding(10);
            this.labMerienda.MouseState = MaterialSkin.MouseState.HOVER;
            this.labMerienda.Name = "labMerienda";
            this.labMerienda.Size = new System.Drawing.Size(75, 74);
            this.labMerienda.TabIndex = 12;
            this.labMerienda.Text = "Merienda";
            this.labMerienda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cena
            // 
            this.Cena.AutoSize = true;
            this.Cena.BackColor = System.Drawing.Color.Transparent;
            this.Cena.Depth = 0;
            this.Cena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cena.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Cena.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.Cena.Location = new System.Drawing.Point(10, 416);
            this.Cena.Margin = new System.Windows.Forms.Padding(10);
            this.Cena.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(75, 75);
            this.Cena.TabIndex = 13;
            this.Cena.Text = "Cena";
            this.Cena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPlanAlimentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tlp_base);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlanAlimentario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlanAlimentarioEdit";
            this.Load += new System.EventHandler(this.frmPlanAlimentario_Load);
            this.tlp_base.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panCalendario.ResumeLayout(false);
            this.tlpCalendario.ResumeLayout(false);
            this.tlpCalendario.PerformLayout();
            this.panHeaderMiercoles.ResumeLayout(false);
            this.panHeaderSabado.ResumeLayout(false);
            this.panHeaderViernes.ResumeLayout(false);
            this.panHeaderJueves.ResumeLayout(false);
            this.panHeaderMartes.ResumeLayout(false);
            this.panHeaderLunes.ResumeLayout(false);
            this.panHeaderDomingo.ResumeLayout(false);
            this.panComida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_base;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialButton btnGenerarPDF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnLista;
        private System.Windows.Forms.Panel panCalendario;
        private System.Windows.Forms.TableLayoutPanel tlpCalendario;
        private System.Windows.Forms.Panel panHeaderMiercoles;
        private System.Windows.Forms.Label labHeaderMiercoles;
        private System.Windows.Forms.Panel panHeaderSabado;
        private System.Windows.Forms.Label labHeaderSabado;
        private System.Windows.Forms.Panel panHeaderViernes;
        private System.Windows.Forms.Label labHeaderViernes;
        private System.Windows.Forms.Panel panHeaderJueves;
        private System.Windows.Forms.Label labHeaderJueves;
        private System.Windows.Forms.Panel panHeaderMartes;
        private System.Windows.Forms.Label labHeaderMartes;
        private System.Windows.Forms.Panel panHeaderLunes;
        private System.Windows.Forms.Label labHeaderLunes;
        private System.Windows.Forms.Panel panHeaderDomingo;
        private System.Windows.Forms.Label labHeaderDomingo;
        private System.Windows.Forms.Panel panComida;
        private System.Windows.Forms.Label labHeaderComida;
        private MaterialSkin.Controls.MaterialLabel labDesayuno;
        private MaterialSkin.Controls.MaterialLabel labMediMan;
        private MaterialSkin.Controls.MaterialLabel labAlmuerzo;
        private MaterialSkin.Controls.MaterialLabel labMerienda;
        private MaterialSkin.Controls.MaterialLabel Cena;
    }
}