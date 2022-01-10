
namespace PUCPSaludable.Controles
{
    partial class ucFechaRango
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
            this.cbAnio = new MaterialSkin.Controls.MaterialComboBox();
            this.cbDia = new MaterialSkin.Controls.MaterialComboBox();
            this.cbMes = new MaterialSkin.Controls.MaterialComboBox();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAnio
            // 
            this.cbAnio.AutoResize = false;
            this.cbAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbAnio.Depth = 0;
            this.cbAnio.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAnio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbAnio.DropDownHeight = 174;
            this.cbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnio.DropDownWidth = 121;
            this.cbAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Hint = "Año";
            this.cbAnio.IntegralHeight = false;
            this.cbAnio.ItemHeight = 43;
            this.cbAnio.Location = new System.Drawing.Point(0, 0);
            this.cbAnio.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.cbAnio.MaxDropDownItems = 4;
            this.cbAnio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(97, 49);
            this.cbAnio.StartIndex = -1;
            this.cbAnio.TabIndex = 73;
            this.cbAnio.SelectedIndexChanged += new System.EventHandler(this.cbAnio_SelectedIndexChanged);
            // 
            // cbDia
            // 
            this.cbDia.AutoResize = false;
            this.cbDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDia.Depth = 0;
            this.cbDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDia.DropDownHeight = 174;
            this.cbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDia.DropDownWidth = 121;
            this.cbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Hint = "Día";
            this.cbDia.IntegralHeight = false;
            this.cbDia.ItemHeight = 43;
            this.cbDia.Location = new System.Drawing.Point(423, 0);
            this.cbDia.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.cbDia.MaxDropDownItems = 4;
            this.cbDia.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(77, 49);
            this.cbDia.StartIndex = -1;
            this.cbDia.TabIndex = 74;
            this.cbDia.SelectedIndexChanged += new System.EventHandler(this.cbDia_SelectedIndexChanged);
            // 
            // cbMes
            // 
            this.cbMes.AutoResize = false;
            this.cbMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMes.Depth = 0;
            this.cbMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMes.DropDownHeight = 174;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.DropDownWidth = 121;
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Hint = "Month";
            this.cbMes.IntegralHeight = false;
            this.cbMes.ItemHeight = 43;
            this.cbMes.Location = new System.Drawing.Point(103, 0);
            this.cbMes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cbMes.MaxDropDownItems = 4;
            this.cbMes.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(314, 49);
            this.cbMes.StartIndex = -1;
            this.cbMes.TabIndex = 72;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpPrincipal.Controls.Add(this.cbAnio, 0, 0);
            this.tlpPrincipal.Controls.Add(this.cbDia, 2, 0);
            this.tlpPrincipal.Controls.Add(this.cbMes, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(500, 50);
            this.tlpPrincipal.TabIndex = 76;
            // 
            // ucFechaRango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "ucFechaRango";
            this.Size = new System.Drawing.Size(500, 50);
            this.Load += new System.EventHandler(this.ucFechaRango_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbAnio;
        private MaterialSkin.Controls.MaterialComboBox cbDia;
        private MaterialSkin.Controls.MaterialComboBox cbMes;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
    }
}
