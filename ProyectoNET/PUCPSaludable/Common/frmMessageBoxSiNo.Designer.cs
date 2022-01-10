
namespace PUCPSaludable.Common
{
    partial class frmMessageBoxSiNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBoxSiNo));
            this.labTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btnSi = new MaterialSkin.Controls.MaterialButton();
            this.btnNo = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
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
            this.labTitulo.TabIndex = 0;
            this.labTitulo.Text = "Titulo";
            this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tbDescripcion.TabIndex = 1;
            this.tbDescripcion.Text = "Descripción";
            // 
            // btnSi
            // 
            this.btnSi.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnSi.AutoSize = false;
            this.btnSi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSi.Depth = 0;
            this.btnSi.DrawShadows = false;
            this.btnSi.HighEmphasis = true;
            this.btnSi.Icon = null;
            this.btnSi.Location = new System.Drawing.Point(277, 110);
            this.btnSi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSi.Name = "btnSi";
            this.btnSi.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSi.Size = new System.Drawing.Size(94, 36);
            this.btnSi.TabIndex = 2;
            this.btnSi.Text = "SÍ";
            this.btnSi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSi.UseAccentColor = true;
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnNo.AutoSize = false;
            this.btnNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNo.Depth = 0;
            this.btnNo.DrawShadows = false;
            this.btnNo.HighEmphasis = true;
            this.btnNo.Icon = null;
            this.btnNo.Location = new System.Drawing.Point(175, 110);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnNo.Size = new System.Drawing.Size(94, 36);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "NO";
            this.btnNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnNo.UseAccentColor = true;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmMessageBoxSiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.labTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMessageBoxSiNo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labTitulo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private MaterialSkin.Controls.MaterialButton btnSi;
        private MaterialSkin.Controls.MaterialButton btnNo;
    }
}