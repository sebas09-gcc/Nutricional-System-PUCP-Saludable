
namespace PUCPSaludable.Controles
{
    partial class ucSesion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panSesion = new System.Windows.Forms.Panel();
            this.carSesion = new MaterialSkin.Controls.MaterialCard();
            this.tlpDivision = new System.Windows.Forms.TableLayoutPanel();
            this.labFecha = new MaterialSkin.Controls.MaterialLabel();
            this.labDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.panSesion.SuspendLayout();
            this.carSesion.SuspendLayout();
            this.tlpDivision.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSesion
            // 
            this.panSesion.Controls.Add(this.carSesion);
            this.panSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSesion.Location = new System.Drawing.Point(0, 0);
            this.panSesion.Margin = new System.Windows.Forms.Padding(0);
            this.panSesion.Name = "panSesion";
            this.panSesion.Padding = new System.Windows.Forms.Padding(4);
            this.panSesion.Size = new System.Drawing.Size(400, 50);
            this.panSesion.TabIndex = 1;
            // 
            // carSesion
            // 
            this.carSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.carSesion.Controls.Add(this.tlpDivision);
            this.carSesion.Depth = 0;
            this.carSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.carSesion.Location = new System.Drawing.Point(4, 4);
            this.carSesion.Margin = new System.Windows.Forms.Padding(0);
            this.carSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.carSesion.Name = "carSesion";
            this.carSesion.Padding = new System.Windows.Forms.Padding(4);
            this.carSesion.Size = new System.Drawing.Size(392, 42);
            this.carSesion.TabIndex = 1;
            // 
            // tlpDivision
            // 
            this.tlpDivision.ColumnCount = 1;
            this.tlpDivision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDivision.Controls.Add(this.labFecha, 0, 1);
            this.tlpDivision.Controls.Add(this.labDescripcion, 0, 0);
            this.tlpDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDivision.Location = new System.Drawing.Point(4, 4);
            this.tlpDivision.Name = "tlpDivision";
            this.tlpDivision.RowCount = 2;
            this.tlpDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDivision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDivision.Size = new System.Drawing.Size(384, 34);
            this.tlpDivision.TabIndex = 2;
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Depth = 0;
            this.labFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.labFecha.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labFecha.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.labFecha.Location = new System.Drawing.Point(3, 17);
            this.labFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(378, 13);
            this.labFecha.TabIndex = 1;
            this.labFecha.Text = "Descripción";
            // 
            // labDescripcion
            // 
            this.labDescripcion.AutoEllipsis = true;
            this.labDescripcion.AutoSize = true;
            this.labDescripcion.Depth = 0;
            this.labDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labDescripcion.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labDescripcion.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labDescripcion.Location = new System.Drawing.Point(3, 3);
            this.labDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(378, 14);
            this.labDescripcion.TabIndex = 0;
            this.labDescripcion.Text = "Título";
            // 
            // ucSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panSesion);
            this.Name = "ucSesion";
            this.Size = new System.Drawing.Size(400, 50);
            this.panSesion.ResumeLayout(false);
            this.carSesion.ResumeLayout(false);
            this.tlpDivision.ResumeLayout(false);
            this.tlpDivision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSesion;
        private MaterialSkin.Controls.MaterialCard carSesion;
        private System.Windows.Forms.TableLayoutPanel tlpDivision;
        private MaterialSkin.Controls.MaterialLabel labFecha;
        private MaterialSkin.Controls.MaterialLabel labDescripcion;
    }
}
