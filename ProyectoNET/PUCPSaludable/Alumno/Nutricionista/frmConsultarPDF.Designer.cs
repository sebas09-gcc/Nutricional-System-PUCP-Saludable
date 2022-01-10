
namespace PUCPSaludable.Alumno.Nutricionista
{
    partial class frmConsultarPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPDF));
            this.wbConstancia = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnDescargar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.wbConstancia)).BeginInit();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbConstancia
            // 
            this.wbConstancia.CreationProperties = null;
            this.wbConstancia.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbConstancia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbConstancia.Location = new System.Drawing.Point(0, 50);
            this.wbConstancia.Margin = new System.Windows.Forms.Padding(0);
            this.wbConstancia.Name = "wbConstancia";
            this.wbConstancia.Size = new System.Drawing.Size(784, 461);
            this.wbConstancia.TabIndex = 0;
            this.wbConstancia.ZoomFactor = 0.75D;
            this.wbConstancia.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.wbConstancia_NavigationCompleted);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.White;
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Controls.Add(this.wbConstancia, 0, 1);
            this.tlpPrincipal.Controls.Add(this.btnDescargar, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(784, 511);
            this.tlpPrincipal.TabIndex = 1;
            this.tlpPrincipal.Visible = false;
            // 
            // btnDescargar
            // 
            this.btnDescargar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnDescargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDescargar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDescargar.Depth = 0;
            this.btnDescargar.DrawShadows = false;
            this.btnDescargar.HighEmphasis = true;
            this.btnDescargar.Icon = null;
            this.btnDescargar.Location = new System.Drawing.Point(10, 6);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnDescargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDescargar.Size = new System.Drawing.Size(106, 36);
            this.btnDescargar.TabIndex = 1;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDescargar.UseAccentColor = true;
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // frmConsultarPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Constancia de seguro contra accidentes";
            ((System.ComponentModel.ISupportInitialize)(this.wbConstancia)).EndInit();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wbConstancia;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private MaterialSkin.Controls.MaterialButton btnDescargar;
    }
}