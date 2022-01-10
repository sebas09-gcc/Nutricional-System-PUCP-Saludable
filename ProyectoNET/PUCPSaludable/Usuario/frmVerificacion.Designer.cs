
namespace PUCPSaludable.Usuario
{
    partial class frmVerificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerificacion));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.labEsperandoRespuesta = new System.Windows.Forms.Label();
            this.pbCarga = new System.Windows.Forms.PictureBox();
            this.labAviso = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.Controls.Add(this.labEsperandoRespuesta, 1, 2);
            this.tlpPrincipal.Controls.Add(this.pbCarga, 1, 1);
            this.tlpPrincipal.Controls.Add(this.labAviso, 1, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Size = new System.Drawing.Size(384, 361);
            this.tlpPrincipal.TabIndex = 17;
            // 
            // labEsperandoRespuesta
            // 
            this.labEsperandoRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labEsperandoRespuesta.AutoSize = true;
            this.labEsperandoRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEsperandoRespuesta.ForeColor = System.Drawing.Color.Black;
            this.labEsperandoRespuesta.Location = new System.Drawing.Point(10, 190);
            this.labEsperandoRespuesta.Margin = new System.Windows.Forms.Padding(0);
            this.labEsperandoRespuesta.Name = "labEsperandoRespuesta";
            this.labEsperandoRespuesta.Size = new System.Drawing.Size(364, 25);
            this.labEsperandoRespuesta.TabIndex = 4;
            this.labEsperandoRespuesta.Text = "Esperando respuesta del servidor";
            this.labEsperandoRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCarga
            // 
            this.pbCarga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCarga.Image = global::PUCPSaludable.Properties.Resources.Ripple;
            this.pbCarga.Location = new System.Drawing.Point(10, 75);
            this.pbCarga.Margin = new System.Windows.Forms.Padding(0);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(364, 100);
            this.pbCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCarga.TabIndex = 5;
            this.pbCarga.TabStop = false;
            // 
            // labAviso
            // 
            this.labAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAviso.AutoSize = true;
            this.labAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAviso.Location = new System.Drawing.Point(10, 231);
            this.labAviso.Margin = new System.Windows.Forms.Padding(0);
            this.labAviso.Name = "labAviso";
            this.labAviso.Size = new System.Drawing.Size(364, 54);
            this.labAviso.TabIndex = 9;
            this.labAviso.Text = "Revisa tu correo PUCP y sigue el enlace que te enviamos. Cuando lo hagas este for" +
    "mulario se desbloqueará";
            this.labAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVerificacion
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
            this.Name = "frmVerificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verifica tu cuenta";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label labEsperandoRespuesta;
        private System.Windows.Forms.PictureBox pbCarga;
        private System.Windows.Forms.Label labAviso;
    }
}