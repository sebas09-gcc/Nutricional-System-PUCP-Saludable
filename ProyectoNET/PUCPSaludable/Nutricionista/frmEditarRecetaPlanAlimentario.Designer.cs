
namespace PUCPSaludable.Nutricionista
{
    partial class frmEditarRecetaPlanAlimentario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarRecetaPlanAlimentario));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPresets = new System.Windows.Forms.DataGridView();
            this.NombreReglaAutorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoReglaAutorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panTipoCom = new System.Windows.Forms.Panel();
            this.labTipoCom = new MaterialSkin.Controls.MaterialLabel();
            this.btnSeleccionar = new MaterialSkin.Controls.MaterialButton();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresets)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panTipoCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.dgvPresets, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(644, 387);
            this.tlpPrincipal.TabIndex = 43;
            // 
            // dgvPresets
            // 
            this.dgvPresets.AllowUserToAddRows = false;
            this.dgvPresets.AllowUserToDeleteRows = false;
            this.dgvPresets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresets.BackgroundColor = System.Drawing.Color.White;
            this.dgvPresets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPresets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPresets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreReglaAutorizado,
            this.CodigoReglaAutorizado});
            this.dgvPresets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPresets.EnableHeadersVisualStyles = false;
            this.dgvPresets.Location = new System.Drawing.Point(13, 63);
            this.dgvPresets.MultiSelect = false;
            this.dgvPresets.Name = "dgvPresets";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPresets.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPresets.RowHeadersVisible = false;
            this.dgvPresets.RowHeadersWidth = 72;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPresets.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPresets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresets.Size = new System.Drawing.Size(618, 311);
            this.dgvPresets.TabIndex = 32;
            this.dgvPresets.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPresets_CellFormatting);
            // 
            // NombreReglaAutorizado
            // 
            this.NombreReglaAutorizado.HeaderText = "Nombre";
            this.NombreReglaAutorizado.MinimumWidth = 9;
            this.NombreReglaAutorizado.Name = "NombreReglaAutorizado";
            // 
            // CodigoReglaAutorizado
            // 
            this.CodigoReglaAutorizado.FillWeight = 40F;
            this.CodigoReglaAutorizado.HeaderText = "Kcal";
            this.CodigoReglaAutorizado.MinimumWidth = 9;
            this.CodigoReglaAutorizado.Name = "CodigoReglaAutorizado";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panTipoCom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSeleccionar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(618, 44);
            this.tableLayoutPanel3.TabIndex = 33;
            // 
            // panTipoCom
            // 
            this.panTipoCom.Controls.Add(this.labTipoCom);
            this.panTipoCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTipoCom.Location = new System.Drawing.Point(0, 0);
            this.panTipoCom.Margin = new System.Windows.Forms.Padding(0);
            this.panTipoCom.Name = "panTipoCom";
            this.panTipoCom.Size = new System.Drawing.Size(518, 54);
            this.panTipoCom.TabIndex = 0;
            // 
            // labTipoCom
            // 
            this.labTipoCom.AutoSize = true;
            this.labTipoCom.Depth = 0;
            this.labTipoCom.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labTipoCom.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labTipoCom.Location = new System.Drawing.Point(3, 11);
            this.labTipoCom.MouseState = MaterialSkin.MouseState.HOVER;
            this.labTipoCom.Name = "labTipoCom";
            this.labTipoCom.Size = new System.Drawing.Size(47, 24);
            this.labTipoCom.TabIndex = 0;
            this.labTipoCom.Text = "Cena";
            this.labTipoCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeleccionar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSeleccionar.Depth = 0;
            this.btnSeleccionar.DrawShadows = false;
            this.btnSeleccionar.HighEmphasis = true;
            this.btnSeleccionar.Icon = null;
            this.btnSeleccionar.Location = new System.Drawing.Point(520, 3);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSeleccionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSeleccionar.Size = new System.Drawing.Size(96, 36);
            this.btnSeleccionar.TabIndex = 44;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSeleccionar.UseAccentColor = true;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmEditarRecetaPlanAlimentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 387);
            this.Controls.Add(this.tlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarRecetaPlanAlimentario";
            this.Text = "Editar receta";
            this.tlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresets)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panTipoCom.ResumeLayout(false);
            this.panTipoCom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.DataGridView dgvPresets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panTipoCom;
        private MaterialSkin.Controls.MaterialButton btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreReglaAutorizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoReglaAutorizado;
        private MaterialSkin.Controls.MaterialLabel labTipoCom;
    }
}