
namespace PUCPSaludable.Alumno
{
    partial class frmIMCDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIMCDashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEstatura = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPesoHabitual = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSumarDatosIMC = new MaterialSkin.Controls.MaterialButton();
            this.panLabelIndicacion = new System.Windows.Forms.Panel();
            this.lblIndicacionSue = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panLabelIndicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panLabelIndicacion, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 260);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbEstatura);
            this.panel1.Controls.Add(this.tbPesoHabitual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 126);
            this.panel1.TabIndex = 0;
            // 
            // tbEstatura
            // 
            this.tbEstatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbEstatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEstatura.Depth = 0;
            this.tbEstatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEstatura.HideSelection = true;
            this.tbEstatura.Hint = "Estatura (cm)";
            this.tbEstatura.LeadingIcon = null;
            this.tbEstatura.Location = new System.Drawing.Point(14, 66);
            this.tbEstatura.MaxLength = 32767;
            this.tbEstatura.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.PasswordChar = '\0';
            this.tbEstatura.PrefixSuffixText = null;
            this.tbEstatura.ReadOnly = false;
            this.tbEstatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEstatura.SelectedText = "";
            this.tbEstatura.SelectionLength = 0;
            this.tbEstatura.SelectionStart = 0;
            this.tbEstatura.ShortcutsEnabled = true;
            this.tbEstatura.Size = new System.Drawing.Size(259, 48);
            this.tbEstatura.TabIndex = 13;
            this.tbEstatura.TabStop = false;
            this.tbEstatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEstatura.TrailingIcon = null;
            this.tbEstatura.UseSystemPasswordChar = false;
            // 
            // tbPesoHabitual
            // 
            this.tbPesoHabitual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPesoHabitual.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPesoHabitual.Depth = 0;
            this.tbPesoHabitual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPesoHabitual.HideSelection = true;
            this.tbPesoHabitual.Hint = "Peso (Kg)";
            this.tbPesoHabitual.LeadingIcon = null;
            this.tbPesoHabitual.Location = new System.Drawing.Point(14, 11);
            this.tbPesoHabitual.MaxLength = 32767;
            this.tbPesoHabitual.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPesoHabitual.Name = "tbPesoHabitual";
            this.tbPesoHabitual.PasswordChar = '\0';
            this.tbPesoHabitual.PrefixSuffixText = null;
            this.tbPesoHabitual.ReadOnly = false;
            this.tbPesoHabitual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPesoHabitual.SelectedText = "";
            this.tbPesoHabitual.SelectionLength = 0;
            this.tbPesoHabitual.SelectionStart = 0;
            this.tbPesoHabitual.ShortcutsEnabled = true;
            this.tbPesoHabitual.Size = new System.Drawing.Size(259, 48);
            this.tbPesoHabitual.TabIndex = 12;
            this.tbPesoHabitual.TabStop = false;
            this.tbPesoHabitual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPesoHabitual.TrailingIcon = null;
            this.tbPesoHabitual.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSumarDatosIMC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 61);
            this.panel2.TabIndex = 1;
            // 
            // btnSumarDatosIMC
            // 
            this.btnSumarDatosIMC.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnSumarDatosIMC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSumarDatosIMC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSumarDatosIMC.Depth = 0;
            this.btnSumarDatosIMC.DrawShadows = false;
            this.btnSumarDatosIMC.HighEmphasis = true;
            this.btnSumarDatosIMC.Icon = null;
            this.btnSumarDatosIMC.Location = new System.Drawing.Point(185, 13);
            this.btnSumarDatosIMC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSumarDatosIMC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSumarDatosIMC.Name = "btnSumarDatosIMC";
            this.btnSumarDatosIMC.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSumarDatosIMC.Size = new System.Drawing.Size(88, 36);
            this.btnSumarDatosIMC.TabIndex = 80;
            this.btnSumarDatosIMC.Text = "agregar";
            this.btnSumarDatosIMC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSumarDatosIMC.UseAccentColor = true;
            this.btnSumarDatosIMC.UseVisualStyleBackColor = true;
            this.btnSumarDatosIMC.Click += new System.EventHandler(this.btnSumarDatosIMC_Click);
            // 
            // panLabelIndicacion
            // 
            this.panLabelIndicacion.Controls.Add(this.lblIndicacionSue);
            this.panLabelIndicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLabelIndicacion.Location = new System.Drawing.Point(2, 2);
            this.panLabelIndicacion.Margin = new System.Windows.Forms.Padding(2);
            this.panLabelIndicacion.Name = "panLabelIndicacion";
            this.panLabelIndicacion.Size = new System.Drawing.Size(287, 61);
            this.panLabelIndicacion.TabIndex = 2;
            // 
            // lblIndicacionSue
            // 
            this.lblIndicacionSue.Depth = 0;
            this.lblIndicacionSue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIndicacionSue.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblIndicacionSue.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblIndicacionSue.Location = new System.Drawing.Point(0, 0);
            this.lblIndicacionSue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndicacionSue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIndicacionSue.Name = "lblIndicacionSue";
            this.lblIndicacionSue.Size = new System.Drawing.Size(287, 61);
            this.lblIndicacionSue.TabIndex = 0;
            this.lblIndicacionSue.Text = "Estatura y peso actuales";
            this.lblIndicacionSue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIMCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(291, 260);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIMCDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panLabelIndicacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnSumarDatosIMC;
        private System.Windows.Forms.Panel panLabelIndicacion;
        private MaterialSkin.Controls.MaterialLabel lblIndicacionSue;
        private MaterialSkin.Controls.MaterialTextBox tbEstatura;
        private MaterialSkin.Controls.MaterialTextBox tbPesoHabitual;
    }
}