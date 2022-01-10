
using System;

namespace PUCPSaludable.Alumno.Citas
{
    partial class frmCitasAlumno
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
            this.tlpDerecho = new System.Windows.Forms.TableLayoutPanel();
            this.ucFecha = new PUCPSaludable.Controles.ucFechaRango();
            this.tbMotivo = new MaterialSkin.Controls.MaterialTextBox();
            this.flpHoras = new System.Windows.Forms.FlowLayoutPanel();
            this.labMotivo = new MaterialSkin.Controls.MaterialLabel();
            this.labHora = new MaterialSkin.Controls.MaterialLabel();
            this.cbEspecialista = new MaterialSkin.Controls.MaterialComboBox();
            this.cbEspecialidad = new MaterialSkin.Controls.MaterialComboBox();
            this.labEspecialista = new MaterialSkin.Controls.MaterialLabel();
            this.labEspecialidad = new MaterialSkin.Controls.MaterialLabel();
            this.labReservarCita = new MaterialSkin.Controls.MaterialLabel();
            this.btnReservar = new MaterialSkin.Controls.MaterialButton();
            this.labOficinaNutri = new MaterialSkin.Controls.MaterialLabel();
            this.labFecha = new MaterialSkin.Controls.MaterialLabel();
            this.labLugar = new MaterialSkin.Controls.MaterialLabel();
            this.tlpIzquierdo = new System.Windows.Forms.TableLayoutPanel();
            this.labProgramadas = new MaterialSkin.Controls.MaterialLabel();
            this.panProgramadas = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.panHistorial = new System.Windows.Forms.Panel();
            this.tlpDerecho.SuspendLayout();
            this.tlpIzquierdo.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDerecho
            // 
            this.tlpDerecho.ColumnCount = 1;
            this.tlpDerecho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDerecho.Controls.Add(this.ucFecha, 0, 8);
            this.tlpDerecho.Controls.Add(this.tbMotivo, 0, 12);
            this.tlpDerecho.Controls.Add(this.flpHoras, 0, 10);
            this.tlpDerecho.Controls.Add(this.labMotivo, 0, 11);
            this.tlpDerecho.Controls.Add(this.labHora, 0, 9);
            this.tlpDerecho.Controls.Add(this.cbEspecialista, 0, 4);
            this.tlpDerecho.Controls.Add(this.cbEspecialidad, 0, 2);
            this.tlpDerecho.Controls.Add(this.labEspecialista, 0, 3);
            this.tlpDerecho.Controls.Add(this.labEspecialidad, 0, 1);
            this.tlpDerecho.Controls.Add(this.labReservarCita, 0, 0);
            this.tlpDerecho.Controls.Add(this.btnReservar, 0, 13);
            this.tlpDerecho.Controls.Add(this.labOficinaNutri, 0, 6);
            this.tlpDerecho.Controls.Add(this.labFecha, 0, 7);
            this.tlpDerecho.Controls.Add(this.labLugar, 0, 5);
            this.tlpDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDerecho.Location = new System.Drawing.Point(440, 10);
            this.tlpDerecho.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDerecho.Name = "tlpDerecho";
            this.tlpDerecho.RowCount = 14;
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpDerecho.Size = new System.Drawing.Size(350, 580);
            this.tlpDerecho.TabIndex = 6;
            // 
            // ucFecha
            // 
            this.ucFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFecha.Fecha = new System.DateTime(((long)(0)));
            this.ucFecha.FechaFin = new System.DateTime(((long)(0)));
            this.ucFecha.FechaInicio = new System.DateTime(((long)(0)));
            this.ucFecha.FirstTime = true;
            this.ucFecha.Location = new System.Drawing.Point(3, 273);
            this.ucFecha.Name = "ucFecha";
            this.ucFecha.Size = new System.Drawing.Size(344, 54);
            this.ucFecha.TabIndex = 14;
            this.ucFecha.DateChanged += new PUCPSaludable.Controles.DateChanged(this.ucFecha_DateChanged);
            // 
            // tbMotivo
            // 
            this.tbMotivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMotivo.Depth = 0;
            this.tbMotivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMotivo.HideSelection = true;
            this.tbMotivo.Hint = "Referencia";
            this.tbMotivo.LeadingIcon = null;
            this.tbMotivo.Location = new System.Drawing.Point(3, 473);
            this.tbMotivo.MaxLength = 6;
            this.tbMotivo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.PasswordChar = '\0';
            this.tbMotivo.PrefixSuffixText = null;
            this.tbMotivo.ReadOnly = false;
            this.tbMotivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbMotivo.SelectedText = "";
            this.tbMotivo.SelectionLength = 0;
            this.tbMotivo.SelectionStart = 0;
            this.tbMotivo.ShortcutsEnabled = true;
            this.tbMotivo.Size = new System.Drawing.Size(344, 48);
            this.tbMotivo.TabIndex = 0;
            this.tbMotivo.TabStop = false;
            this.tbMotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMotivo.TrailingIcon = null;
            this.tbMotivo.UseSystemPasswordChar = false;
            // 
            // flpHoras
            // 
            this.flpHoras.AutoScroll = true;
            this.flpHoras.AutoSize = true;
            this.flpHoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHoras.Location = new System.Drawing.Point(0, 350);
            this.flpHoras.Margin = new System.Windows.Forms.Padding(0);
            this.flpHoras.Name = "flpHoras";
            this.flpHoras.Size = new System.Drawing.Size(350, 100);
            this.flpHoras.TabIndex = 7;
            // 
            // labMotivo
            // 
            this.labMotivo.AutoSize = true;
            this.labMotivo.Depth = 0;
            this.labMotivo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labMotivo.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labMotivo.Location = new System.Drawing.Point(3, 450);
            this.labMotivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labMotivo.Name = "labMotivo";
            this.labMotivo.Size = new System.Drawing.Size(57, 14);
            this.labMotivo.TabIndex = 11;
            this.labMotivo.Text = "Referencia";
            this.labMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labHora
            // 
            this.labHora.AutoSize = true;
            this.labHora.Depth = 0;
            this.labHora.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labHora.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labHora.Location = new System.Drawing.Point(3, 330);
            this.labHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.labHora.Name = "labHora";
            this.labHora.Size = new System.Drawing.Size(28, 14);
            this.labHora.TabIndex = 9;
            this.labHora.Text = "Hora";
            this.labHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEspecialista
            // 
            this.cbEspecialista.AutoResize = false;
            this.cbEspecialista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEspecialista.Depth = 0;
            this.cbEspecialista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEspecialista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEspecialista.DropDownHeight = 174;
            this.cbEspecialista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialista.DropDownWidth = 121;
            this.cbEspecialista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEspecialista.FormattingEnabled = true;
            this.cbEspecialista.Hint = "Elige un especialista";
            this.cbEspecialista.IntegralHeight = false;
            this.cbEspecialista.ItemHeight = 43;
            this.cbEspecialista.Location = new System.Drawing.Point(3, 143);
            this.cbEspecialista.MaxDropDownItems = 4;
            this.cbEspecialista.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEspecialista.Name = "cbEspecialista";
            this.cbEspecialista.Size = new System.Drawing.Size(344, 49);
            this.cbEspecialista.StartIndex = 0;
            this.cbEspecialista.TabIndex = 3;
            this.cbEspecialista.SelectedIndexChanged += new System.EventHandler(this.cbEspecialista_SelectedIndexChanged);
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.AutoResize = false;
            this.cbEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEspecialidad.Depth = 0;
            this.cbEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEspecialidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEspecialidad.DropDownHeight = 174;
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.DropDownWidth = 121;
            this.cbEspecialidad.Enabled = false;
            this.cbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Hint = "Elige una especialidad";
            this.cbEspecialidad.IntegralHeight = false;
            this.cbEspecialidad.ItemHeight = 43;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Nutrición"});
            this.cbEspecialidad.Location = new System.Drawing.Point(3, 63);
            this.cbEspecialidad.MaxDropDownItems = 4;
            this.cbEspecialidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(344, 49);
            this.cbEspecialidad.StartIndex = 0;
            this.cbEspecialidad.TabIndex = 3;
            // 
            // labEspecialista
            // 
            this.labEspecialista.AutoSize = true;
            this.labEspecialista.Depth = 0;
            this.labEspecialista.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labEspecialista.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labEspecialista.Location = new System.Drawing.Point(3, 120);
            this.labEspecialista.MouseState = MaterialSkin.MouseState.HOVER;
            this.labEspecialista.Name = "labEspecialista";
            this.labEspecialista.Size = new System.Drawing.Size(66, 14);
            this.labEspecialista.TabIndex = 4;
            this.labEspecialista.Text = "Especialista";
            this.labEspecialista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labEspecialidad
            // 
            this.labEspecialidad.AutoSize = true;
            this.labEspecialidad.Depth = 0;
            this.labEspecialidad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labEspecialidad.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labEspecialidad.Location = new System.Drawing.Point(3, 40);
            this.labEspecialidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.labEspecialidad.Name = "labEspecialidad";
            this.labEspecialidad.Size = new System.Drawing.Size(70, 14);
            this.labEspecialidad.TabIndex = 4;
            this.labEspecialidad.Text = "Especialidad";
            this.labEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labReservarCita
            // 
            this.labReservarCita.AutoSize = true;
            this.labReservarCita.Depth = 0;
            this.labReservarCita.Dock = System.Windows.Forms.DockStyle.Left;
            this.labReservarCita.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labReservarCita.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labReservarCita.Location = new System.Drawing.Point(3, 0);
            this.labReservarCita.MouseState = MaterialSkin.MouseState.HOVER;
            this.labReservarCita.Name = "labReservarCita";
            this.labReservarCita.Size = new System.Drawing.Size(156, 40);
            this.labReservarCita.TabIndex = 1;
            this.labReservarCita.Text = "Reservar una cita";
            this.labReservarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReservar
            // 
            this.btnReservar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.AutoSize = false;
            this.btnReservar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReservar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReservar.Depth = 0;
            this.btnReservar.DrawShadows = false;
            this.btnReservar.HighEmphasis = true;
            this.btnReservar.Icon = global::PUCPSaludable.Properties.Resources.calendar_dark;
            this.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.Location = new System.Drawing.Point(175, 546);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnReservar.Size = new System.Drawing.Size(175, 34);
            this.btnReservar.TabIndex = 7;
            this.btnReservar.Text = "Reservar Cita";
            this.btnReservar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReservar.UseAccentColor = true;
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // labOficinaNutri
            // 
            this.labOficinaNutri.AutoSize = true;
            this.labOficinaNutri.Depth = 0;
            this.labOficinaNutri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labOficinaNutri.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labOficinaNutri.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.labOficinaNutri.Location = new System.Drawing.Point(3, 220);
            this.labOficinaNutri.MouseState = MaterialSkin.MouseState.HOVER;
            this.labOficinaNutri.Name = "labOficinaNutri";
            this.labOficinaNutri.Size = new System.Drawing.Size(344, 30);
            this.labOficinaNutri.TabIndex = 13;
            this.labOficinaNutri.Text = "Servicio de salud PUCP";
            this.labOficinaNutri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Depth = 0;
            this.labFecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labFecha.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labFecha.Location = new System.Drawing.Point(3, 250);
            this.labFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(34, 14);
            this.labFecha.TabIndex = 8;
            this.labFecha.Text = "Fecha";
            this.labFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labLugar
            // 
            this.labLugar.AutoSize = true;
            this.labLugar.Depth = 0;
            this.labLugar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labLugar.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labLugar.Location = new System.Drawing.Point(3, 200);
            this.labLugar.MouseState = MaterialSkin.MouseState.HOVER;
            this.labLugar.Name = "labLugar";
            this.labLugar.Size = new System.Drawing.Size(33, 14);
            this.labLugar.TabIndex = 12;
            this.labLugar.Text = "Lugar";
            this.labLugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpIzquierdo
            // 
            this.tlpIzquierdo.ColumnCount = 1;
            this.tlpIzquierdo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIzquierdo.Controls.Add(this.labProgramadas, 0, 0);
            this.tlpIzquierdo.Controls.Add(this.panProgramadas, 0, 1);
            this.tlpIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIzquierdo.Location = new System.Drawing.Point(10, 10);
            this.tlpIzquierdo.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tlpIzquierdo.Name = "tlpIzquierdo";
            this.tlpIzquierdo.RowCount = 2;
            this.tlpIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIzquierdo.Size = new System.Drawing.Size(210, 580);
            this.tlpIzquierdo.TabIndex = 0;
            // 
            // labProgramadas
            // 
            this.labProgramadas.AutoSize = true;
            this.labProgramadas.Depth = 0;
            this.labProgramadas.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labProgramadas.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labProgramadas.Location = new System.Drawing.Point(3, 0);
            this.labProgramadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.labProgramadas.Name = "labProgramadas";
            this.labProgramadas.Size = new System.Drawing.Size(121, 24);
            this.labProgramadas.TabIndex = 2;
            this.labProgramadas.Text = "Programadas";
            // 
            // panProgramadas
            // 
            this.panProgramadas.AutoScroll = true;
            this.panProgramadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panProgramadas.Location = new System.Drawing.Point(0, 30);
            this.panProgramadas.Margin = new System.Windows.Forms.Padding(0);
            this.panProgramadas.Name = "panProgramadas";
            this.panProgramadas.Size = new System.Drawing.Size(210, 550);
            this.panProgramadas.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Historial";
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.White;
            this.tlpPrincipal.ColumnCount = 5;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.Controls.Add(this.tlpIzquierdo, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tlpDerecho, 3, 1);
            this.tlpPrincipal.Controls.Add(this.tlpCentro, 2, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.Size = new System.Drawing.Size(800, 600);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tlpCentro
            // 
            this.tlpCentro.ColumnCount = 1;
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCentro.Controls.Add(this.materialLabel1, 0, 0);
            this.tlpCentro.Controls.Add(this.panHistorial, 0, 1);
            this.tlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCentro.Location = new System.Drawing.Point(230, 10);
            this.tlpCentro.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tlpCentro.Name = "tlpCentro";
            this.tlpCentro.RowCount = 2;
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCentro.Size = new System.Drawing.Size(210, 580);
            this.tlpCentro.TabIndex = 7;
            // 
            // panHistorial
            // 
            this.panHistorial.AutoScroll = true;
            this.panHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHistorial.Location = new System.Drawing.Point(0, 30);
            this.panHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.panHistorial.Name = "panHistorial";
            this.panHistorial.Size = new System.Drawing.Size(210, 550);
            this.panHistorial.TabIndex = 4;
            // 
            // frmCitasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tlpPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCitasAlumno";
            this.Text = "frmCitasAlumno";
            this.Load += new System.EventHandler(this.frmCitasAlumno_Load);
            this.tlpDerecho.ResumeLayout(false);
            this.tlpDerecho.PerformLayout();
            this.tlpIzquierdo.ResumeLayout(false);
            this.tlpIzquierdo.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpCentro.ResumeLayout(false);
            this.tlpCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDerecho;
        private MaterialSkin.Controls.MaterialLabel labMotivo;
        private MaterialSkin.Controls.MaterialLabel labHora;
        private MaterialSkin.Controls.MaterialLabel labFecha;
        private MaterialSkin.Controls.MaterialComboBox cbEspecialista;
        private MaterialSkin.Controls.MaterialComboBox cbEspecialidad;
        private MaterialSkin.Controls.MaterialLabel labEspecialista;
        private MaterialSkin.Controls.MaterialLabel labEspecialidad;
        private MaterialSkin.Controls.MaterialLabel labReservarCita;
        private MaterialSkin.Controls.MaterialButton btnReservar;
        private System.Windows.Forms.TableLayoutPanel tlpIzquierdo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel labProgramadas;
        private System.Windows.Forms.Panel panProgramadas;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flpHoras;
        private MaterialSkin.Controls.MaterialLabel labOficinaNutri;
        private MaterialSkin.Controls.MaterialLabel labLugar;
        private System.Windows.Forms.TableLayoutPanel tlpCentro;
        private System.Windows.Forms.Panel panHistorial;
        private MaterialSkin.Controls.MaterialTextBox tbMotivo;
        private PUCPSaludable.Controles.ucFechaRango ucFecha;
    }
}