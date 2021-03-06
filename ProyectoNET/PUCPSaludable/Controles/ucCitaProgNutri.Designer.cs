
namespace PUCPSaludable.Controles
{
    partial class ucCitaProgNutri
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
            this.tblCard = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labHora = new MaterialSkin.Controls.MaterialLabel();
            this.labLugar = new MaterialSkin.Controls.MaterialLabel();
            this.labFecha = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbIco = new System.Windows.Forms.PictureBox();
            this.pnlProg = new System.Windows.Forms.Panel();
            this.ptbProg = new System.Windows.Forms.PictureBox();
            this.tblCard.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIco)).BeginInit();
            this.pnlProg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProg)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCard
            // 
            this.tblCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblCard.BackColor = System.Drawing.Color.White;
            this.tblCard.ColumnCount = 3;
            this.tblCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblCard.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tblCard.Controls.Add(this.panel1, 0, 0);
            this.tblCard.Controls.Add(this.pnlProg, 2, 0);
            this.tblCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCard.Location = new System.Drawing.Point(0, 0);
            this.tblCard.Name = "tblCard";
            this.tblCard.RowCount = 4;
            this.tblCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tblCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCard.Size = new System.Drawing.Size(330, 95);
            this.tblCard.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labHora, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labLugar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labFecha, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(38, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 32);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // labHora
            // 
            this.labHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labHora.AutoSize = true;
            this.labHora.Depth = 0;
            this.labHora.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labHora.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labHora.Location = new System.Drawing.Point(3, 11);
            this.labHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.labHora.Name = "labHora";
            this.labHora.Size = new System.Drawing.Size(53, 11);
            this.labHora.TabIndex = 6;
            this.labHora.Text = "12:00 p.m.";
            // 
            // labLugar
            // 
            this.labLugar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labLugar.AutoSize = true;
            this.labLugar.Depth = 0;
            this.labLugar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labLugar.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.labLugar.Location = new System.Drawing.Point(3, 22);
            this.labLugar.MouseState = MaterialSkin.MouseState.HOVER;
            this.labLugar.Name = "labLugar";
            this.labLugar.Size = new System.Drawing.Size(130, 10);
            this.labLugar.TabIndex = 4;
            this.labLugar.Text = "Servicio de Salud PUCP, C. 10";
            // 
            // labFecha
            // 
            this.labFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labFecha.AutoSize = true;
            this.labFecha.Depth = 0;
            this.labFecha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labFecha.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labFecha.Location = new System.Drawing.Point(3, 0);
            this.labFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(137, 11);
            this.labFecha.TabIndex = 2;
            this.labFecha.Text = "Miercoles, 31 de Diciembre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbIco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 32);
            this.panel1.TabIndex = 1;
            // 
            // ptbIco
            // 
            this.ptbIco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbIco.Image = global::PUCPSaludable.Properties.Resources.manzana_small_bn;
            this.ptbIco.Location = new System.Drawing.Point(0, 0);
            this.ptbIco.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.ptbIco.Name = "ptbIco";
            this.ptbIco.Size = new System.Drawing.Size(29, 32);
            this.ptbIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbIco.TabIndex = 1;
            this.ptbIco.TabStop = false;
            // 
            // pnlProg
            // 
            this.pnlProg.Controls.Add(this.ptbProg);
            this.pnlProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProg.Location = new System.Drawing.Point(283, 3);
            this.pnlProg.Name = "pnlProg";
            this.pnlProg.Size = new System.Drawing.Size(44, 32);
            this.pnlProg.TabIndex = 2;
            // 
            // ptbProg
            // 
            this.ptbProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbProg.Image = global::PUCPSaludable.Properties.Resources.hoy;
            this.ptbProg.Location = new System.Drawing.Point(0, 0);
            this.ptbProg.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.ptbProg.Name = "ptbProg";
            this.ptbProg.Size = new System.Drawing.Size(44, 32);
            this.ptbProg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbProg.TabIndex = 2;
            this.ptbProg.TabStop = false;
            // 
            // ucCitaProgNutri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblCard);
            this.Name = "ucCitaProgNutri";
            this.Size = new System.Drawing.Size(330, 95);
            this.tblCard.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIco)).EndInit();
            this.pnlProg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel labHora;
        private MaterialSkin.Controls.MaterialLabel labLugar;
        private MaterialSkin.Controls.MaterialLabel labFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbIco;
        private System.Windows.Forms.Panel pnlProg;
        private System.Windows.Forms.PictureBox ptbProg;
    }
}
