
namespace PUCPSaludable.Alumno.Citas
{
    partial class frmRegistrarCita1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarCita1));
            this.btnCancelarReserva = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.tblDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.labDetalle = new MaterialSkin.Controls.MaterialLabel();
            this.labAdvertencia = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptarReserva = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblDetalle.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnCancelarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancelarReserva.AutoSize = false;
            this.btnCancelarReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelarReserva.Depth = 0;
            this.btnCancelarReserva.DrawShadows = false;
            this.btnCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.HighEmphasis = true;
            this.btnCancelarReserva.Icon = null;
            this.btnCancelarReserva.Location = new System.Drawing.Point(10, 4);
            this.btnCancelarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnCancelarReserva.Size = new System.Drawing.Size(165, 38);
            this.btnCancelarReserva.TabIndex = 9;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelarReserva.UseAccentColor = true;
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.labTitulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tblDetalle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 361);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Depth = 0;
            this.labTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTitulo.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labTitulo.Location = new System.Drawing.Point(13, 10);
            this.labTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(458, 30);
            this.labTitulo.TabIndex = 5;
            this.labTitulo.Text = "¿Continuar con la reserva?";
            this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblDetalle
            // 
            this.tblDetalle.ColumnCount = 1;
            this.tblDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetalle.Controls.Add(this.labDetalle, 0, 1);
            this.tblDetalle.Controls.Add(this.labAdvertencia, 0, 0);
            this.tblDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDetalle.Location = new System.Drawing.Point(10, 70);
            this.tblDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.tblDetalle.Name = "tblDetalle";
            this.tblDetalle.RowCount = 3;
            this.tblDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDetalle.Size = new System.Drawing.Size(464, 235);
            this.tblDetalle.TabIndex = 7;
            // 
            // labDetalle
            // 
            this.labDetalle.AutoSize = true;
            this.labDetalle.Depth = 0;
            this.labDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labDetalle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labDetalle.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labDetalle.Location = new System.Drawing.Point(3, 73);
            this.labDetalle.Margin = new System.Windows.Forms.Padding(3);
            this.labDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labDetalle.Name = "labDetalle";
            this.labDetalle.Size = new System.Drawing.Size(458, 111);
            this.labDetalle.TabIndex = 4;
            this.labDetalle.Text = "Detalles de la atención\r\nFecha: 13/03/2021\r\nHora: 09:20\r\nLugar: Servicio de Salud" +
    " PUCP, Consultorio 10\r\nEspecialista: María Cabrera";
            this.labDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labAdvertencia
            // 
            this.labAdvertencia.AutoSize = true;
            this.labAdvertencia.Depth = 0;
            this.labAdvertencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labAdvertencia.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labAdvertencia.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labAdvertencia.Location = new System.Drawing.Point(3, 3);
            this.labAdvertencia.Margin = new System.Windows.Forms.Padding(3);
            this.labAdvertencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.labAdvertencia.Name = "labAdvertencia";
            this.labAdvertencia.Size = new System.Drawing.Size(458, 64);
            this.labAdvertencia.TabIndex = 3;
            this.labAdvertencia.Text = "Está a punto de registrar una cita. \r\nCon ello se compromete a asistir a la sesió" +
    "n en la fecha y hora indicadas o cancelar oportunamente.";
            this.labAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.btnCancelarReserva, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAceptarReserva, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 305);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(464, 46);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // btnAceptarReserva
            // 
            this.btnAceptarReserva.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAceptarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAceptarReserva.AutoSize = false;
            this.btnAceptarReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptarReserva.Depth = 0;
            this.btnAceptarReserva.DrawShadows = false;
            this.btnAceptarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarReserva.HighEmphasis = true;
            this.btnAceptarReserva.Icon = null;
            this.btnAceptarReserva.Location = new System.Drawing.Point(288, 4);
            this.btnAceptarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptarReserva.Name = "btnAceptarReserva";
            this.btnAceptarReserva.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAceptarReserva.Size = new System.Drawing.Size(165, 38);
            this.btnAceptarReserva.TabIndex = 8;
            this.btnAceptarReserva.Text = "CONTINUAR";
            this.btnAceptarReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptarReserva.UseAccentColor = true;
            this.btnAceptarReserva.UseVisualStyleBackColor = true;
            this.btnAceptarReserva.Click += new System.EventHandler(this.btnAceptarReserva_Click);
            // 
            // frmRegistrarCita1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarCita1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmación de reserva de cita";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblDetalle.ResumeLayout(false);
            this.tblDetalle.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCancelarReserva;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel labTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnAceptarReserva;
        private System.Windows.Forms.TableLayoutPanel tblDetalle;
        private MaterialSkin.Controls.MaterialLabel labDetalle;
        private MaterialSkin.Controls.MaterialLabel labAdvertencia;
    }
}