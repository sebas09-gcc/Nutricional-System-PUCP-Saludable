
namespace PUCPSaludable.Usuario
{
    partial class frmIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciarSesion));
            this.btnIniciarSesion = new MaterialSkin.Controls.MaterialButton();
            this.tlbRestablecerRegistrarse = new System.Windows.Forms.TableLayoutPanel();
            this.btnRestablecerContrasena = new System.Windows.Forms.LinkLabel();
            this.btnRegistrarse = new System.Windows.Forms.LinkLabel();
            this.tbUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.tbContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.labIniciarSesion = new System.Windows.Forms.Label();
            this.swiRecordarme = new MaterialSkin.Controls.MaterialSwitch();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotonIniciarSesion = new System.Windows.Forms.TableLayoutPanel();
            this.tlbRestablecerRegistrarse.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpBotonIniciarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnIniciarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciarSesion.Depth = 0;
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIniciarSesion.DrawShadows = false;
            this.btnIniciarSesion.HighEmphasis = true;
            this.btnIniciarSesion.Icon = null;
            this.btnIniciarSesion.Location = new System.Drawing.Point(100, 8);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnIniciarSesion.Size = new System.Drawing.Size(164, 36);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIniciarSesion.UseAccentColor = true;
            this.btnIniciarSesion.UseCompatibleTextRendering = true;
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // tlbRestablecerRegistrarse
            // 
            this.tlbRestablecerRegistrarse.ColumnCount = 2;
            this.tlbRestablecerRegistrarse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbRestablecerRegistrarse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbRestablecerRegistrarse.Controls.Add(this.btnRestablecerContrasena, 0, 0);
            this.tlbRestablecerRegistrarse.Controls.Add(this.btnRegistrarse, 1, 0);
            this.tlbRestablecerRegistrarse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbRestablecerRegistrarse.Location = new System.Drawing.Point(10, 333);
            this.tlbRestablecerRegistrarse.Margin = new System.Windows.Forms.Padding(0);
            this.tlbRestablecerRegistrarse.Name = "tlbRestablecerRegistrarse";
            this.tlbRestablecerRegistrarse.RowCount = 1;
            this.tlbRestablecerRegistrarse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbRestablecerRegistrarse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlbRestablecerRegistrarse.Size = new System.Drawing.Size(364, 18);
            this.tlbRestablecerRegistrarse.TabIndex = 7;
            // 
            // btnRestablecerContrasena
            // 
            this.btnRestablecerContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestablecerContrasena.AutoSize = true;
            this.btnRestablecerContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerContrasena.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnRestablecerContrasena.LinkColor = System.Drawing.Color.PaleVioletRed;
            this.btnRestablecerContrasena.Location = new System.Drawing.Point(0, 3);
            this.btnRestablecerContrasena.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestablecerContrasena.Name = "btnRestablecerContrasena";
            this.btnRestablecerContrasena.Size = new System.Drawing.Size(144, 15);
            this.btnRestablecerContrasena.TabIndex = 0;
            this.btnRestablecerContrasena.TabStop = true;
            this.btnRestablecerContrasena.Text = "Reestablecer contraseña";
            this.btnRestablecerContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestablecerContrasena.VisitedLinkColor = System.Drawing.Color.Green;
            this.btnRestablecerContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRestablecerContrasena_LinkClicked);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarse.AutoSize = true;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnRegistrarse.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarse.Location = new System.Drawing.Point(294, 3);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(70, 15);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.TabStop = true;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.White;
            this.tbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUsuario.Depth = 0;
            this.tbUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUsuario.HideSelection = true;
            this.tbUsuario.Hint = "Código PUCP o email";
            this.tbUsuario.LeadingIcon = null;
            this.tbUsuario.Location = new System.Drawing.Point(10, 102);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.tbUsuario.MaxLength = 50;
            this.tbUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PasswordChar = '\0';
            this.tbUsuario.PrefixSuffixText = null;
            this.tbUsuario.ReadOnly = false;
            this.tbUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUsuario.SelectedText = "";
            this.tbUsuario.SelectionLength = 0;
            this.tbUsuario.SelectionStart = 0;
            this.tbUsuario.ShortcutsEnabled = true;
            this.tbUsuario.Size = new System.Drawing.Size(364, 48);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.TabStop = false;
            this.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsuario.TrailingIcon = null;
            this.tbUsuario.UseSystemPasswordChar = false;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbVerificar_TextChanged);
            // 
            // tbContrasena
            // 
            this.tbContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbContrasena.Depth = 0;
            this.tbContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbContrasena.HideSelection = true;
            this.tbContrasena.Hint = "Password";
            this.tbContrasena.LeadingIcon = null;
            this.tbContrasena.Location = new System.Drawing.Point(10, 162);
            this.tbContrasena.Margin = new System.Windows.Forms.Padding(0);
            this.tbContrasena.MaxLength = 50;
            this.tbContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '●';
            this.tbContrasena.PrefixSuffixText = null;
            this.tbContrasena.ReadOnly = false;
            this.tbContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbContrasena.SelectedText = "";
            this.tbContrasena.SelectionLength = 0;
            this.tbContrasena.SelectionStart = 0;
            this.tbContrasena.ShortcutsEnabled = true;
            this.tbContrasena.Size = new System.Drawing.Size(364, 48);
            this.tbContrasena.TabIndex = 2;
            this.tbContrasena.TabStop = false;
            this.tbContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbContrasena.TrailingIcon = null;
            this.tbContrasena.UseSystemPasswordChar = true;
            this.tbContrasena.TextChanged += new System.EventHandler(this.tbVerificar_TextChanged);
            // 
            // labIniciarSesion
            // 
            this.labIniciarSesion.AutoSize = true;
            this.labIniciarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.labIniciarSesion.Location = new System.Drawing.Point(10, 10);
            this.labIniciarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.labIniciarSesion.Name = "labIniciarSesion";
            this.labIniciarSesion.Size = new System.Drawing.Size(364, 72);
            this.labIniciarSesion.TabIndex = 3;
            this.labIniciarSesion.Text = "Iniciar Sesión";
            this.labIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // swiRecordarme
            // 
            this.swiRecordarme.AutoSize = true;
            this.swiRecordarme.Checked = true;
            this.swiRecordarme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.swiRecordarme.Depth = 0;
            this.swiRecordarme.Location = new System.Drawing.Point(10, 222);
            this.swiRecordarme.Margin = new System.Windows.Forms.Padding(0);
            this.swiRecordarme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swiRecordarme.MouseState = MaterialSkin.MouseState.HOVER;
            this.swiRecordarme.Name = "swiRecordarme";
            this.swiRecordarme.Ripple = true;
            this.swiRecordarme.Size = new System.Drawing.Size(202, 37);
            this.swiRecordarme.TabIndex = 4;
            this.swiRecordarme.Text = "Mantener sesión activa";
            this.swiRecordarme.UseVisualStyleBackColor = true;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.Controls.Add(this.tbUsuario, 1, 3);
            this.tlpPrincipal.Controls.Add(this.tbContrasena, 1, 5);
            this.tlpPrincipal.Controls.Add(this.labIniciarSesion, 1, 1);
            this.tlpPrincipal.Controls.Add(this.swiRecordarme, 1, 7);
            this.tlpPrincipal.Controls.Add(this.tlpBotonIniciarSesion, 1, 9);
            this.tlpPrincipal.Controls.Add(this.tlbRestablecerRegistrarse, 1, 11);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.MaximumSize = new System.Drawing.Size(400, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 13;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(384, 361);
            this.tlpPrincipal.TabIndex = 2;
            // 
            // tlpBotonIniciarSesion
            // 
            this.tlpBotonIniciarSesion.ColumnCount = 3;
            this.tlpBotonIniciarSesion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpBotonIniciarSesion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonIniciarSesion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpBotonIniciarSesion.Controls.Add(this.btnIniciarSesion, 1, 0);
            this.tlpBotonIniciarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotonIniciarSesion.Location = new System.Drawing.Point(10, 269);
            this.tlpBotonIniciarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotonIniciarSesion.Name = "tlpBotonIniciarSesion";
            this.tlpBotonIniciarSesion.RowCount = 1;
            this.tlpBotonIniciarSesion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonIniciarSesion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpBotonIniciarSesion.Size = new System.Drawing.Size(364, 44);
            this.tlpBotonIniciarSesion.TabIndex = 6;
            // 
            // frmIniciarSesion
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
            this.Name = "frmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.frmIniciarSesion_Load);
            this.tlbRestablecerRegistrarse.ResumeLayout(false);
            this.tlbRestablecerRegistrarse.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpBotonIniciarSesion.ResumeLayout(false);
            this.tlpBotonIniciarSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnIniciarSesion;
        private System.Windows.Forms.TableLayoutPanel tlbRestablecerRegistrarse;
        private System.Windows.Forms.LinkLabel btnRestablecerContrasena;
        private System.Windows.Forms.LinkLabel btnRegistrarse;
        public MaterialSkin.Controls.MaterialTextBox tbUsuario;
        public MaterialSkin.Controls.MaterialTextBox tbContrasena;
        private System.Windows.Forms.Label labIniciarSesion;
        private MaterialSkin.Controls.MaterialSwitch swiRecordarme;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBotonIniciarSesion;
    }
}