
namespace PUCPSaludable.Administrador
{
    partial class frmConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarUsuario));
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.labNombreT = new MaterialSkin.Controls.MaterialLabel();
            this.labCodigoT = new MaterialSkin.Controls.MaterialLabel();
            this.labApellidoT = new MaterialSkin.Controls.MaterialLabel();
            this.labRolT = new MaterialSkin.Controls.MaterialLabel();
            this.labEmailT = new MaterialSkin.Controls.MaterialLabel();
            this.labNombres = new MaterialSkin.Controls.MaterialLabel();
            this.labApellidos = new MaterialSkin.Controls.MaterialLabel();
            this.labCodigo = new MaterialSkin.Controls.MaterialLabel();
            this.labCorreo = new MaterialSkin.Controls.MaterialLabel();
            this.labRol = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.LightGray;
            this.pbFoto.Location = new System.Drawing.Point(327, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(95, 115);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 14;
            this.pbFoto.TabStop = false;
            // 
            // labNombreT
            // 
            this.labNombreT.AutoSize = true;
            this.labNombreT.Depth = 0;
            this.labNombreT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labNombreT.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.labNombreT.Location = new System.Drawing.Point(11, 26);
            this.labNombreT.MouseState = MaterialSkin.MouseState.HOVER;
            this.labNombreT.Name = "labNombreT";
            this.labNombreT.Size = new System.Drawing.Size(58, 17);
            this.labNombreT.TabIndex = 17;
            this.labNombreT.Text = "Nombres";
            // 
            // labCodigoT
            // 
            this.labCodigoT.AutoSize = true;
            this.labCodigoT.Depth = 0;
            this.labCodigoT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labCodigoT.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.labCodigoT.Location = new System.Drawing.Point(11, 108);
            this.labCodigoT.MouseState = MaterialSkin.MouseState.HOVER;
            this.labCodigoT.Name = "labCodigoT";
            this.labCodigoT.Size = new System.Drawing.Size(45, 17);
            this.labCodigoT.TabIndex = 18;
            this.labCodigoT.Text = "Código";
            // 
            // labApellidoT
            // 
            this.labApellidoT.AutoSize = true;
            this.labApellidoT.Depth = 0;
            this.labApellidoT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labApellidoT.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.labApellidoT.Location = new System.Drawing.Point(11, 67);
            this.labApellidoT.MouseState = MaterialSkin.MouseState.HOVER;
            this.labApellidoT.Name = "labApellidoT";
            this.labApellidoT.Size = new System.Drawing.Size(57, 17);
            this.labApellidoT.TabIndex = 19;
            this.labApellidoT.Text = "Apellidos";
            // 
            // labRolT
            // 
            this.labRolT.AutoSize = true;
            this.labRolT.Depth = 0;
            this.labRolT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labRolT.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.labRolT.Location = new System.Drawing.Point(11, 190);
            this.labRolT.MouseState = MaterialSkin.MouseState.HOVER;
            this.labRolT.Name = "labRolT";
            this.labRolT.Size = new System.Drawing.Size(21, 17);
            this.labRolT.TabIndex = 21;
            this.labRolT.Text = "Rol";
            // 
            // labEmailT
            // 
            this.labEmailT.AutoSize = true;
            this.labEmailT.Depth = 0;
            this.labEmailT.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labEmailT.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.labEmailT.Location = new System.Drawing.Point(11, 149);
            this.labEmailT.MouseState = MaterialSkin.MouseState.HOVER;
            this.labEmailT.Name = "labEmailT";
            this.labEmailT.Size = new System.Drawing.Size(43, 17);
            this.labEmailT.TabIndex = 22;
            this.labEmailT.Text = "Correo";
            // 
            // labNombres
            // 
            this.labNombres.AutoSize = true;
            this.labNombres.Depth = 0;
            this.labNombres.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labNombres.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labNombres.Location = new System.Drawing.Point(12, 12);
            this.labNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.labNombres.Name = "labNombres";
            this.labNombres.Size = new System.Drawing.Size(50, 14);
            this.labNombres.TabIndex = 23;
            this.labNombres.Text = "Nombres";
            // 
            // labApellidos
            // 
            this.labApellidos.AutoSize = true;
            this.labApellidos.Depth = 0;
            this.labApellidos.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labApellidos.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labApellidos.Location = new System.Drawing.Point(12, 53);
            this.labApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(51, 14);
            this.labApellidos.TabIndex = 24;
            this.labApellidos.Text = "Apellidos";
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Depth = 0;
            this.labCodigo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labCodigo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labCodigo.Location = new System.Drawing.Point(12, 94);
            this.labCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(75, 14);
            this.labCodigo.TabIndex = 25;
            this.labCodigo.Text = "Código PUCP";
            // 
            // labCorreo
            // 
            this.labCorreo.AutoSize = true;
            this.labCorreo.Depth = 0;
            this.labCorreo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labCorreo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labCorreo.Location = new System.Drawing.Point(12, 135);
            this.labCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labCorreo.Name = "labCorreo";
            this.labCorreo.Size = new System.Drawing.Size(66, 14);
            this.labCorreo.TabIndex = 26;
            this.labCorreo.Text = "Email PUCP";
            // 
            // labRol
            // 
            this.labRol.AutoSize = true;
            this.labRol.Depth = 0;
            this.labRol.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labRol.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labRol.Location = new System.Drawing.Point(12, 176);
            this.labRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.labRol.Name = "labRol";
            this.labRol.Size = new System.Drawing.Size(18, 14);
            this.labRol.TabIndex = 27;
            this.labRol.Text = "Rol";
            // 
            // frmConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 214);
            this.Controls.Add(this.labRol);
            this.Controls.Add(this.labCorreo);
            this.Controls.Add(this.labCodigo);
            this.Controls.Add(this.labApellidos);
            this.Controls.Add(this.labNombres);
            this.Controls.Add(this.labEmailT);
            this.Controls.Add(this.labRolT);
            this.Controls.Add(this.labApellidoT);
            this.Controls.Add(this.labCodigoT);
            this.Controls.Add(this.labNombreT);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFoto;
        private MaterialSkin.Controls.MaterialLabel labNombreT;
        private MaterialSkin.Controls.MaterialLabel labCodigoT;
        private MaterialSkin.Controls.MaterialLabel labApellidoT;
        private MaterialSkin.Controls.MaterialLabel labRolT;
        private MaterialSkin.Controls.MaterialLabel labEmailT;
        private MaterialSkin.Controls.MaterialLabel labNombres;
        private MaterialSkin.Controls.MaterialLabel labApellidos;
        private MaterialSkin.Controls.MaterialLabel labCodigo;
        private MaterialSkin.Controls.MaterialLabel labCorreo;
        private MaterialSkin.Controls.MaterialLabel labRol;
    }
}