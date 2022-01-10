
namespace PUCPSaludable.Controles
{
    partial class ucPlanAlimCardEdit
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.labNombreReceta = new System.Windows.Forms.Label();
            this.labKcal = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnMostrar = new System.Windows.Forms.PictureBox();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.tlpPrincipal.ColumnCount = 4;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.Controls.Add(this.labNombreReceta, 1, 1);
            this.tlpPrincipal.Controls.Add(this.labKcal, 1, 2);
            this.tlpPrincipal.Controls.Add(this.btnEditar, 2, 2);
            this.tlpPrincipal.Controls.Add(this.btnMostrar, 2, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.Size = new System.Drawing.Size(250, 100);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // labNombreReceta
            // 
            this.labNombreReceta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labNombreReceta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreReceta.Location = new System.Drawing.Point(10, 10);
            this.labNombreReceta.Margin = new System.Windows.Forms.Padding(0);
            this.labNombreReceta.Name = "labNombreReceta";
            this.labNombreReceta.Size = new System.Drawing.Size(210, 60);
            this.labNombreReceta.TabIndex = 0;
            this.labNombreReceta.Text = "name";
            // 
            // labKcal
            // 
            this.labKcal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labKcal.ForeColor = System.Drawing.Color.DarkGray;
            this.labKcal.Location = new System.Drawing.Point(10, 72);
            this.labKcal.Margin = new System.Windows.Forms.Padding(0);
            this.labKcal.Name = "labKcal";
            this.labKcal.Size = new System.Drawing.Size(210, 18);
            this.labKcal.TabIndex = 1;
            this.labKcal.Text = "kcal";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::PUCPSaludable.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(222, 72);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(16, 16);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 2;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnEditar_MouseLeave);
            this.btnEditar.MouseHover += new System.EventHandler(this.btnEditar_MouseHover);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Image = global::PUCPSaludable.Properties.Resources.arrow_right_up;
            this.btnMostrar.Location = new System.Drawing.Point(222, 12);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(16, 16);
            this.btnMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.TabStop = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            this.btnMostrar.MouseLeave += new System.EventHandler(this.btnMostrar_MouseLeave);
            this.btnMostrar.MouseHover += new System.EventHandler(this.btnMostrar_MouseHover);
            // 
            // ucPlanAlimCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpPrincipal);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucPlanAlimCardEdit";
            this.Size = new System.Drawing.Size(250, 100);
            this.tlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label labNombreReceta;
        private System.Windows.Forms.Label labKcal;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnMostrar;
    }
}
