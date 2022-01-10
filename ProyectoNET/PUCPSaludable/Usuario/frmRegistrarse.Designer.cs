
namespace PUCPSaludable.Usuario
{
    partial class frmRegistrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarse));
            this.tbCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.labRegistarse = new System.Windows.Forms.Label();
            this.tlpBotonVerificar = new System.Windows.Forms.TableLayoutPanel();
            this.btnVerificar = new MaterialSkin.Controls.MaterialButton();
            this.labAviso = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.LinkLabel();
            this.tlpPrincipal.SuspendLayout();
            this.tlpBotonVerificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCodigo.Depth = 0;
            this.tbCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCodigo.HideSelection = true;
            this.tbCodigo.Hint = "Código PUCP";
            this.tbCodigo.LeadingIcon = null;
            this.tbCodigo.Location = new System.Drawing.Point(10, 172);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.tbCodigo.MaxLength = 8;
            this.tbCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.PasswordChar = '\0';
            this.tbCodigo.PrefixSuffixText = null;
            this.tbCodigo.ReadOnly = false;
            this.tbCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCodigo.SelectedText = "";
            this.tbCodigo.SelectionLength = 0;
            this.tbCodigo.SelectionStart = 0;
            this.tbCodigo.ShortcutsEnabled = true;
            this.tbCodigo.Size = new System.Drawing.Size(364, 48);
            this.tbCodigo.TabIndex = 2;
            this.tbCodigo.TabStop = false;
            this.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCodigo.TrailingIcon = null;
            this.tbCodigo.UseSystemPasswordChar = false;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.Controls.Add(this.tbCodigo, 1, 5);
            this.tlpPrincipal.Controls.Add(this.labRegistarse, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tlpBotonVerificar, 1, 7);
            this.tlpPrincipal.Controls.Add(this.labAviso, 1, 3);
            this.tlpPrincipal.Controls.Add(this.btnVolver, 1, 9);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 11;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.Size = new System.Drawing.Size(384, 361);
            this.tlpPrincipal.TabIndex = 4;
            // 
            // labRegistarse
            // 
            this.labRegistarse.AutoSize = true;
            this.labRegistarse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labRegistarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRegistarse.ForeColor = System.Drawing.Color.Black;
            this.labRegistarse.Location = new System.Drawing.Point(10, 10);
            this.labRegistarse.Margin = new System.Windows.Forms.Padding(0);
            this.labRegistarse.Name = "labRegistarse";
            this.labRegistarse.Size = new System.Drawing.Size(364, 72);
            this.labRegistarse.TabIndex = 3;
            this.labRegistarse.Text = "Registrarse";
            this.labRegistarse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpBotonVerificar
            // 
            this.tlpBotonVerificar.ColumnCount = 3;
            this.tlpBotonVerificar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpBotonVerificar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonVerificar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpBotonVerificar.Controls.Add(this.btnVerificar, 1, 0);
            this.tlpBotonVerificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotonVerificar.Location = new System.Drawing.Point(10, 232);
            this.tlpBotonVerificar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotonVerificar.Name = "tlpBotonVerificar";
            this.tlpBotonVerificar.RowCount = 1;
            this.tlpBotonVerificar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonVerificar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpBotonVerificar.Size = new System.Drawing.Size(364, 81);
            this.tlpBotonVerificar.TabIndex = 6;
            // 
            // btnVerificar
            // 
            this.btnVerificar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnVerificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerificar.Depth = 0;
            this.btnVerificar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVerificar.DrawShadows = false;
            this.btnVerificar.HighEmphasis = true;
            this.btnVerificar.Icon = null;
            this.btnVerificar.Location = new System.Drawing.Point(100, 45);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnVerificar.Size = new System.Drawing.Size(164, 36);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerificar.UseAccentColor = true;
            this.btnVerificar.UseCompatibleTextRendering = true;
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // labAviso
            // 
            this.labAviso.AutoSize = true;
            this.labAviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAviso.Location = new System.Drawing.Point(10, 102);
            this.labAviso.Margin = new System.Windows.Forms.Padding(0);
            this.labAviso.Name = "labAviso";
            this.labAviso.Size = new System.Drawing.Size(364, 60);
            this.labAviso.TabIndex = 8;
            this.labAviso.Text = resources.GetString("labAviso.Text");
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.AutoSize = true;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnVolver.LinkColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolver.Location = new System.Drawing.Point(10, 336);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(141, 15);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.TabStop = true;
            this.btnVolver.Text = "Volver al inicio de sesión";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.VisitedLinkColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnVolver_LinkClicked);
            // 
            // frmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrarse";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpBotonVerificar.ResumeLayout(false);
            this.tlpBotonVerificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialTextBox tbCodigo;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label labRegistarse;
        private System.Windows.Forms.TableLayoutPanel tlpBotonVerificar;
        private MaterialSkin.Controls.MaterialButton btnVerificar;
        private System.Windows.Forms.Label labAviso;
        private System.Windows.Forms.LinkLabel btnVolver;
    }
}