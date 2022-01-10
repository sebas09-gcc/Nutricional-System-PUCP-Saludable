
namespace PUCPSaludable.Alumno.Citas
{
    partial class frmDetalleCitaProgramada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleCitaProgramada));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.miUbicacion = new PUCPSaludable.Controles.ucMap();
            this.labDetalle = new MaterialSkin.Controls.MaterialLabel();
            this.labFecha = new MaterialSkin.Controls.MaterialLabel();
            this.lblTituloDetalle = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminarCita = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.miUbicacion, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labDetalle, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labFecha, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTituloDetalle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminarCita, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 511);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // miUbicacion
            // 
            this.miUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miUbicacion.Location = new System.Drawing.Point(13, 183);
            this.miUbicacion.Name = "miUbicacion";
            this.miUbicacion.Size = new System.Drawing.Size(708, 315);
            this.miUbicacion.TabIndex = 10;
            this.miUbicacion.Ubicacion = ((System.ValueTuple<double, double, string>)(resources.GetObject("miUbicacion.Ubicacion")));
            // 
            // labDetalle
            // 
            this.labDetalle.Depth = 0;
            this.labDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labDetalle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labDetalle.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labDetalle.Location = new System.Drawing.Point(13, 120);
            this.labDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labDetalle.Name = "labDetalle";
            this.labDetalle.Size = new System.Drawing.Size(708, 60);
            this.labDetalle.TabIndex = 5;
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Depth = 0;
            this.labFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labFecha.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labFecha.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labFecha.Location = new System.Drawing.Point(13, 90);
            this.labFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(708, 30);
            this.labFecha.TabIndex = 6;
            this.labFecha.Text = "Fecha y hora";
            this.labFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.Depth = 0;
            this.lblTituloDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTituloDetalle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTituloDetalle.Location = new System.Drawing.Point(13, 60);
            this.lblTituloDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloDetalle.Name = "lblTituloDetalle";
            this.lblTituloDetalle.Size = new System.Drawing.Size(708, 30);
            this.lblTituloDetalle.TabIndex = 5;
            this.lblTituloDetalle.Text = "Cita programada";
            this.lblTituloDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnEliminarCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCita.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarCita.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarCita.Depth = 0;
            this.btnEliminarCita.DrawShadows = false;
            this.btnEliminarCita.HighEmphasis = true;
            this.btnEliminarCita.Icon = null;
            this.btnEliminarCita.Location = new System.Drawing.Point(588, 16);
            this.btnEliminarCita.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarCita.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEliminarCita.Size = new System.Drawing.Size(132, 36);
            this.btnEliminarCita.TabIndex = 11;
            this.btnEliminarCita.Text = "cancelar cita";
            this.btnEliminarCita.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarCita.UseAccentColor = true;
            this.btnEliminarCita.UseVisualStyleBackColor = true;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // frmDetalleCitaProgramada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "frmDetalleCitaProgramada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cita programada";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lblTituloDetalle;
        private MaterialSkin.Controls.MaterialLabel labFecha;
        private PUCPSaludable.Controles.ucMap miUbicacion;
        private MaterialSkin.Controls.MaterialLabel labDetalle;
        private MaterialSkin.Controls.MaterialButton btnEliminarCita;
    }
}