
namespace PUCPSaludable.Usuario
{
    partial class frmElegirVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElegirVideo));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.wvPaginaSolicitada = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tlpNavegacion = new System.Windows.Forms.TableLayoutPanel();
            this.tbURL = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSeleccionar = new MaterialSkin.Controls.MaterialButton();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvPaginaSolicitada)).BeginInit();
            this.tlpNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.wvPaginaSolicitada, 0, 1);
            this.tlpPrincipal.Controls.Add(this.tlpNavegacion, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(784, 411);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // wvPaginaSolicitada
            // 
            this.wvPaginaSolicitada.CreationProperties = null;
            this.wvPaginaSolicitada.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvPaginaSolicitada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvPaginaSolicitada.Location = new System.Drawing.Point(0, 46);
            this.wvPaginaSolicitada.Margin = new System.Windows.Forms.Padding(0);
            this.wvPaginaSolicitada.Name = "wvPaginaSolicitada";
            this.wvPaginaSolicitada.Size = new System.Drawing.Size(784, 365);
            this.wvPaginaSolicitada.TabIndex = 1;
            this.wvPaginaSolicitada.ZoomFactor = 1D;
            this.wvPaginaSolicitada.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.wbPaginaSolicitada_SourceChanged);
            // 
            // tlpNavegacion
            // 
            this.tlpNavegacion.ColumnCount = 3;
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpNavegacion.Controls.Add(this.tbURL, 0, 0);
            this.tlpNavegacion.Controls.Add(this.btnSeleccionar, 2, 0);
            this.tlpNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavegacion.Location = new System.Drawing.Point(3, 3);
            this.tlpNavegacion.Name = "tlpNavegacion";
            this.tlpNavegacion.RowCount = 1;
            this.tlpNavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacion.Size = new System.Drawing.Size(778, 40);
            this.tlpNavegacion.TabIndex = 2;
            // 
            // tbURL
            // 
            this.tbURL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbURL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbURL.Depth = 0;
            this.tbURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbURL.HideSelection = true;
            this.tbURL.LeadingIcon = null;
            this.tbURL.Location = new System.Drawing.Point(3, 3);
            this.tbURL.MaxLength = 32767;
            this.tbURL.MouseState = MaterialSkin.MouseState.OUT;
            this.tbURL.Name = "tbURL";
            this.tbURL.PasswordChar = '\0';
            this.tbURL.PrefixSuffixText = null;
            this.tbURL.ReadOnly = false;
            this.tbURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbURL.SelectedText = "";
            this.tbURL.SelectionLength = 0;
            this.tbURL.SelectionStart = 0;
            this.tbURL.ShortcutsEnabled = true;
            this.tbURL.Size = new System.Drawing.Size(552, 36);
            this.tbURL.TabIndex = 4;
            this.tbURL.TabStop = false;
            this.tbURL.Text = "https://";
            this.tbURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbURL.TrailingIcon = null;
            this.tbURL.UseSystemPasswordChar = false;
            this.tbURL.UseTallSize = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeleccionar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSeleccionar.Depth = 0;
            this.btnSeleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeleccionar.DrawShadows = false;
            this.btnSeleccionar.HighEmphasis = true;
            this.btnSeleccionar.Icon = null;
            this.btnSeleccionar.Location = new System.Drawing.Point(662, 6);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSeleccionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSeleccionar.Size = new System.Drawing.Size(112, 28);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSeleccionar.UseAccentColor = true;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmElegirVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmElegirVideo";
            this.Text = "Elegir un video";
            this.tlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wvPaginaSolicitada)).EndInit();
            this.tlpNavegacion.ResumeLayout(false);
            this.tlpNavegacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvPaginaSolicitada;
        private System.Windows.Forms.TableLayoutPanel tlpNavegacion;
        private MaterialSkin.Controls.MaterialTextBox tbURL;
        private MaterialSkin.Controls.MaterialButton btnSeleccionar;
    }
}