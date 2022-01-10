
namespace PUCPSaludable.Alumno.Citas.Controles
{
    partial class ucCitaHist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblCard = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbIco = new System.Windows.Forms.PictureBox();
            this.pnlProg = new System.Windows.Forms.Panel();
            this.ptbCheck = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labHora = new MaterialSkin.Controls.MaterialLabel();
            this.labEspecialista = new MaterialSkin.Controls.MaterialLabel();
            this.labFecha = new MaterialSkin.Controls.MaterialLabel();
            this.btnDetalle = new MaterialSkin.Controls.MaterialButton();
            this.tblCard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIco)).BeginInit();
            this.pnlProg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCheck)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCard
            // 
            this.tblCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblCard.BackColor = System.Drawing.Color.White;
            this.tblCard.ColumnCount = 3;
            this.tblCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCard.Controls.Add(this.panel1, 0, 0);
            this.tblCard.Controls.Add(this.pnlProg, 2, 0);
            this.tblCard.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tblCard.Controls.Add(this.btnDetalle, 1, 2);
            this.tblCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCard.Location = new System.Drawing.Point(0, 0);
            this.tblCard.Name = "tblCard";
            this.tblCard.RowCount = 4;
            this.tblCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCard.Size = new System.Drawing.Size(330, 95);
            this.tblCard.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbIco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 39);
            this.panel1.TabIndex = 1;
            // 
            // ptbIco
            // 
            this.ptbIco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbIco.Image = global::PUCPSaludable.Properties.Resources.manzana_small_bn;
            this.ptbIco.Location = new System.Drawing.Point(0, 0);
            this.ptbIco.Margin = new System.Windows.Forms.Padding(10);
            this.ptbIco.Name = "ptbIco";
            this.ptbIco.Size = new System.Drawing.Size(29, 39);
            this.ptbIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbIco.TabIndex = 1;
            this.ptbIco.TabStop = false;
            // 
            // pnlProg
            // 
            this.pnlProg.Controls.Add(this.ptbCheck);
            this.pnlProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProg.Location = new System.Drawing.Point(303, 3);
            this.pnlProg.Name = "pnlProg";
            this.pnlProg.Size = new System.Drawing.Size(24, 39);
            this.pnlProg.TabIndex = 2;
            // 
            // ptbCheck
            // 
            this.ptbCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbCheck.Image = global::PUCPSaludable.Properties.Resources.check_one;
            this.ptbCheck.Location = new System.Drawing.Point(0, 0);
            this.ptbCheck.Margin = new System.Windows.Forms.Padding(10);
            this.ptbCheck.Name = "ptbCheck";
            this.ptbCheck.Size = new System.Drawing.Size(24, 39);
            this.ptbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCheck.TabIndex = 2;
            this.ptbCheck.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labHora, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labEspecialista, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labFecha, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 39);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labHora
            // 
            this.labHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labHora.AutoSize = true;
            this.labHora.Depth = 0;
            this.labHora.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labHora.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labHora.Location = new System.Drawing.Point(3, 13);
            this.labHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.labHora.Name = "labHora";
            this.labHora.Size = new System.Drawing.Size(53, 13);
            this.labHora.TabIndex = 6;
            this.labHora.Text = "12:00 p.m.";
            // 
            // labEspecialista
            // 
            this.labEspecialista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labEspecialista.AutoSize = true;
            this.labEspecialista.Depth = 0;
            this.labEspecialista.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labEspecialista.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.labEspecialista.Location = new System.Drawing.Point(3, 26);
            this.labEspecialista.MouseState = MaterialSkin.MouseState.HOVER;
            this.labEspecialista.Name = "labEspecialista";
            this.labEspecialista.Size = new System.Drawing.Size(145, 13);
            this.labEspecialista.TabIndex = 4;
            this.labEspecialista.Text = "Atendida por Lic. Patricia Ramirez";
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
            this.labFecha.Size = new System.Drawing.Size(137, 13);
            this.labFecha.TabIndex = 2;
            this.labFecha.Text = "Miercoles, 31 de Diciembre";
            // 
            // btnDetalle
            // 
            this.btnDetalle.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnDetalle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDetalle.Depth = 0;
            this.btnDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetalle.DrawShadows = false;
            this.btnDetalle.HighEmphasis = true;
            this.btnDetalle.Icon = null;
            this.btnDetalle.Location = new System.Drawing.Point(35, 55);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.btnDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDetalle.Size = new System.Drawing.Size(265, 20);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.Text = "ver detalle";
            this.btnDetalle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalle.UseAccentColor = true;
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // ucCitaHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblCard);
            this.Name = "ucCitaHist";
            this.Size = new System.Drawing.Size(330, 95);
            this.tblCard.ResumeLayout(false);
            this.tblCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIco)).EndInit();
            this.pnlProg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCheck)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbIco;
        private System.Windows.Forms.Panel pnlProg;
        private System.Windows.Forms.PictureBox ptbCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel labHora;
        private MaterialSkin.Controls.MaterialLabel labEspecialista;
        private MaterialSkin.Controls.MaterialLabel labFecha;
        private MaterialSkin.Controls.MaterialButton btnDetalle;
    }
}
