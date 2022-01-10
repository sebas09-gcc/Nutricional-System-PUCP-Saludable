namespace PUCPSaludable.Common
{
    partial class frmMessageBoxAceptar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBoxAceptar));
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.labTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAceptar.AutoSize = false;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.DrawShadows = false;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(263, 110);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAceptar.Size = new System.Drawing.Size(108, 36);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = true;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.White;
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescripcion.Enabled = false;
            this.tbDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(12, 48);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(364, 55);
            this.tbDescripcion.TabIndex = 5;
            this.tbDescripcion.Text = "Descripción";
            // 
            // labTitulo
            // 
            this.labTitulo.Depth = 0;
            this.labTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitulo.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labTitulo.Location = new System.Drawing.Point(0, 0);
            this.labTitulo.Margin = new System.Windows.Forms.Padding(10);
            this.labTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Padding = new System.Windows.Forms.Padding(10);
            this.labTitulo.Size = new System.Drawing.Size(384, 51);
            this.labTitulo.TabIndex = 4;
            this.labTitulo.Text = "Titulo";
            this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMessageBoxAceptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.labTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMessageBoxAceptar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private MaterialSkin.Controls.MaterialLabel labTitulo;
    }
}