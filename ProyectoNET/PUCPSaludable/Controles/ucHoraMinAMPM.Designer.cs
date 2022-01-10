
namespace PUCPSaludable.Controles
{
    partial class ucHoraMinAMPM
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
            this.cbHora = new MaterialSkin.Controls.MaterialComboBox();
            this.cbAMPM = new MaterialSkin.Controls.MaterialComboBox();
            this.cbMinutos = new MaterialSkin.Controls.MaterialComboBox();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHora
            // 
            this.cbHora.AutoResize = false;
            this.cbHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHora.Depth = 0;
            this.cbHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbHora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbHora.DropDownHeight = 174;
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.DropDownWidth = 121;
            this.cbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Hint = "Hora";
            this.cbHora.IntegralHeight = false;
            this.cbHora.ItemHeight = 43;
            this.cbHora.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbHora.Location = new System.Drawing.Point(0, 0);
            this.cbHora.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.cbHora.MaxDropDownItems = 4;
            this.cbHora.MouseState = MaterialSkin.MouseState.OUT;
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(154, 49);
            this.cbHora.StartIndex = 0;
            this.cbHora.TabIndex = 73;
            // 
            // cbAMPM
            // 
            this.cbAMPM.AutoResize = false;
            this.cbAMPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbAMPM.Depth = 0;
            this.cbAMPM.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAMPM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbAMPM.DropDownHeight = 174;
            this.cbAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAMPM.DropDownWidth = 121;
            this.cbAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbAMPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbAMPM.FormattingEnabled = true;
            this.cbAMPM.Hint = "AM/PM";
            this.cbAMPM.IntegralHeight = false;
            this.cbAMPM.ItemHeight = 43;
            this.cbAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbAMPM.Location = new System.Drawing.Point(320, 0);
            this.cbAMPM.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.cbAMPM.MaxDropDownItems = 4;
            this.cbAMPM.MouseState = MaterialSkin.MouseState.OUT;
            this.cbAMPM.Name = "cbAMPM";
            this.cbAMPM.Size = new System.Drawing.Size(160, 49);
            this.cbAMPM.StartIndex = 0;
            this.cbAMPM.TabIndex = 74;
            // 
            // cbMinutos
            // 
            this.cbMinutos.AutoResize = false;
            this.cbMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMinutos.Depth = 0;
            this.cbMinutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMinutos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMinutos.DropDownHeight = 174;
            this.cbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutos.DropDownWidth = 121;
            this.cbMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Hint = "Minutos";
            this.cbMinutos.IntegralHeight = false;
            this.cbMinutos.ItemHeight = 43;
            this.cbMinutos.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cbMinutos.Location = new System.Drawing.Point(162, 0);
            this.cbMinutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cbMinutos.MaxDropDownItems = 4;
            this.cbMinutos.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(150, 49);
            this.cbMinutos.StartIndex = 0;
            this.cbMinutos.TabIndex = 72;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpPrincipal.Controls.Add(this.cbHora, 0, 0);
            this.tlpPrincipal.Controls.Add(this.cbAMPM, 2, 0);
            this.tlpPrincipal.Controls.Add(this.cbMinutos, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(480, 62);
            this.tlpPrincipal.TabIndex = 76;
            // 
            // ucHoraMinAMPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucHoraMinAMPM";
            this.Size = new System.Drawing.Size(480, 62);
            this.tlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbHora;
        private MaterialSkin.Controls.MaterialComboBox cbAMPM;
        private MaterialSkin.Controls.MaterialComboBox cbMinutos;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
    }
}
