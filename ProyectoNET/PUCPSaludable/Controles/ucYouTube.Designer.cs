
namespace PUCPSaludable.Controles
{
    partial class ucYouTube
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
            this.tlbPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDerecha = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdelante = new MaterialSkin.Controls.MaterialButton();
            this.tlpIzquierda = new System.Windows.Forms.TableLayoutPanel();
            this.btnAtras = new MaterialSkin.Controls.MaterialButton();
            this.wvPlayer = new PUCPSaludable.Controles.ucWebView();
            this.tlbPrincipal.SuspendLayout();
            this.tlpDerecha.SuspendLayout();
            this.tlpIzquierda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlbPrincipal
            // 
            this.tlbPrincipal.ColumnCount = 3;
            this.tlbPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlbPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlbPrincipal.Controls.Add(this.tlpDerecha, 2, 0);
            this.tlbPrincipal.Controls.Add(this.tlpIzquierda, 0, 0);
            this.tlbPrincipal.Controls.Add(this.wvPlayer, 1, 0);
            this.tlbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlbPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlbPrincipal.Name = "tlbPrincipal";
            this.tlbPrincipal.RowCount = 1;
            this.tlbPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbPrincipal.Size = new System.Drawing.Size(695, 233);
            this.tlbPrincipal.TabIndex = 0;
            // 
            // tlpDerecha
            // 
            this.tlpDerecha.ColumnCount = 1;
            this.tlpDerecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDerecha.Controls.Add(this.btnAdelante, 0, 1);
            this.tlpDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDerecha.Location = new System.Drawing.Point(653, 0);
            this.tlpDerecha.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDerecha.Name = "tlpDerecha";
            this.tlpDerecha.RowCount = 3;
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDerecha.Size = new System.Drawing.Size(42, 233);
            this.tlpDerecha.TabIndex = 2;
            // 
            // btnAdelante
            // 
            this.btnAdelante.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAdelante.AutoSize = false;
            this.btnAdelante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdelante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdelante.Depth = 0;
            this.btnAdelante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdelante.DrawShadows = false;
            this.btnAdelante.HighEmphasis = true;
            this.btnAdelante.Icon = global::PUCPSaludable.Properties.Resources.Forward;
            this.btnAdelante.Location = new System.Drawing.Point(0, 98);
            this.btnAdelante.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdelante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAdelante.Size = new System.Drawing.Size(42, 36);
            this.btnAdelante.TabIndex = 0;
            this.btnAdelante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdelante.UseAccentColor = true;
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // tlpIzquierda
            // 
            this.tlpIzquierda.ColumnCount = 1;
            this.tlpIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIzquierda.Controls.Add(this.btnAtras, 0, 1);
            this.tlpIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIzquierda.Location = new System.Drawing.Point(0, 0);
            this.tlpIzquierda.Margin = new System.Windows.Forms.Padding(0);
            this.tlpIzquierda.Name = "tlpIzquierda";
            this.tlpIzquierda.RowCount = 3;
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpIzquierda.Size = new System.Drawing.Size(42, 233);
            this.tlpIzquierda.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAtras.AutoSize = false;
            this.btnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAtras.Depth = 0;
            this.btnAtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAtras.DrawShadows = false;
            this.btnAtras.HighEmphasis = true;
            this.btnAtras.Icon = global::PUCPSaludable.Properties.Resources.Back;
            this.btnAtras.Location = new System.Drawing.Point(0, 98);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAtras.Size = new System.Drawing.Size(42, 36);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAtras.UseAccentColor = true;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // wvPlayer
            // 
            this.wvPlayer.BackColor = System.Drawing.Color.White;
            this.wvPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvPlayer.Location = new System.Drawing.Point(45, 3);
            this.wvPlayer.Name = "wvPlayer";
            this.wvPlayer.Size = new System.Drawing.Size(605, 227);
            this.wvPlayer.TabIndex = 3;
            this.wvPlayer.URL = null;
            // 
            // ucYouTube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlbPrincipal);
            this.Name = "ucYouTube";
            this.Size = new System.Drawing.Size(695, 233);
            this.tlbPrincipal.ResumeLayout(false);
            this.tlpDerecha.ResumeLayout(false);
            this.tlpIzquierda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlbPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpIzquierda;
        private MaterialSkin.Controls.MaterialButton btnAtras;
        private System.Windows.Forms.TableLayoutPanel tlpDerecha;
        private MaterialSkin.Controls.MaterialButton btnAdelante;
        private ucWebView wvPlayer;
    }
}
