
namespace PUCPSaludable.Alumno.Nutricionista
{
    partial class frmDatosIAIncorrectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosIAIncorrectos));
            this.mlabAntesTaller1 = new MaterialSkin.Controls.MaterialLabel();
            this.mlabAntesTaller2 = new MaterialSkin.Controls.MaterialLabel();
            this.mltbErrores = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.SuspendLayout();
            // 
            // mlabAntesTaller1
            // 
            this.mlabAntesTaller1.AutoSize = true;
            this.mlabAntesTaller1.Depth = 0;
            this.mlabAntesTaller1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mlabAntesTaller1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.mlabAntesTaller1.Location = new System.Drawing.Point(18, 9);
            this.mlabAntesTaller1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlabAntesTaller1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlabAntesTaller1.Name = "mlabAntesTaller1";
            this.mlabAntesTaller1.Size = new System.Drawing.Size(261, 24);
            this.mlabAntesTaller1.TabIndex = 42;
            this.mlabAntesTaller1.Text = "Datos ingresados incorrectos";
            // 
            // mlabAntesTaller2
            // 
            this.mlabAntesTaller2.Depth = 0;
            this.mlabAntesTaller2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlabAntesTaller2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.mlabAntesTaller2.Location = new System.Drawing.Point(11, 39);
            this.mlabAntesTaller2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlabAntesTaller2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlabAntesTaller2.Name = "mlabAntesTaller2";
            this.mlabAntesTaller2.Size = new System.Drawing.Size(274, 24);
            this.mlabAntesTaller2.TabIndex = 43;
            this.mlabAntesTaller2.Text = "Revisa los siguientes campos:";
            this.mlabAntesTaller2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mltbErrores
            // 
            this.mltbErrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mltbErrores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mltbErrores.Depth = 0;
            this.mltbErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mltbErrores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mltbErrores.Location = new System.Drawing.Point(11, 65);
            this.mltbErrores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mltbErrores.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltbErrores.Name = "mltbErrores";
            this.mltbErrores.Size = new System.Drawing.Size(274, 132);
            this.mltbErrores.TabIndex = 45;
            this.mltbErrores.Text = "";
            // 
            // frmDatosIAIncorrectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(296, 208);
            this.Controls.Add(this.mltbErrores);
            this.Controls.Add(this.mlabAntesTaller2);
            this.Controls.Add(this.mlabAntesTaller1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatosIAIncorrectos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mlabAntesTaller1;
        private MaterialSkin.Controls.MaterialLabel mlabAntesTaller2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mltbErrores;
    }
}