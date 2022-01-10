
namespace PUCPSaludable.Controles
{
    partial class ucAlimentoListado
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
            this.tlpAlimentoCalif = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labAlimento = new System.Windows.Forms.Label();
            this.tlpAlimentoCalif.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAlimentoCalif
            // 
            this.tlpAlimentoCalif.ColumnCount = 2;
            this.tlpAlimentoCalif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAlimentoCalif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpAlimentoCalif.Controls.Add(this.panel2, 0, 0);
            this.tlpAlimentoCalif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAlimentoCalif.Location = new System.Drawing.Point(0, 0);
            this.tlpAlimentoCalif.Name = "tlpAlimentoCalif";
            this.tlpAlimentoCalif.RowCount = 1;
            this.tlpAlimentoCalif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAlimentoCalif.Size = new System.Drawing.Size(239, 30);
            this.tlpAlimentoCalif.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labAlimento);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(149, 30);
            this.panel2.TabIndex = 2;
            // 
            // labAlimento
            // 
            this.labAlimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labAlimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAlimento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labAlimento.Location = new System.Drawing.Point(5, 0);
            this.labAlimento.Name = "labAlimento";
            this.labAlimento.Size = new System.Drawing.Size(144, 30);
            this.labAlimento.TabIndex = 1;
            this.labAlimento.Text = "label1";
            this.labAlimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAlimentoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpAlimentoCalif);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucAlimentoListado";
            this.Size = new System.Drawing.Size(239, 30);
            this.tlpAlimentoCalif.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAlimentoCalif;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labAlimento;
    }
}
