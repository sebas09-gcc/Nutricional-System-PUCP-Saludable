
namespace PUCPSaludable.Usuario
{
    partial class frmRegistrarsePaso5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarsePaso5));
            this.labAviso = new System.Windows.Forms.Label();
            this.labFotoPerfil = new System.Windows.Forms.Label();
            this.ofdElegirFoto = new System.Windows.Forms.OpenFileDialog();
            this.gbFoto = new System.Windows.Forms.GroupBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnOmitir = new MaterialSkin.Controls.MaterialButton();
            this.btnElegirFoto = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarForo = new MaterialSkin.Controls.MaterialButton();
            this.gbFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labAviso
            // 
            this.labAviso.AutoSize = true;
            this.labAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAviso.Location = new System.Drawing.Point(12, 38);
            this.labAviso.Name = "labAviso";
            this.labAviso.Size = new System.Drawing.Size(194, 13);
            this.labAviso.TabIndex = 38;
            this.labAviso.Text = "Una foto le da personalidad a tu cuenta";
            // 
            // labFotoPerfil
            // 
            this.labFotoPerfil.AutoSize = true;
            this.labFotoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFotoPerfil.Location = new System.Drawing.Point(7, 9);
            this.labFotoPerfil.Name = "labFotoPerfil";
            this.labFotoPerfil.Size = new System.Drawing.Size(248, 25);
            this.labFotoPerfil.TabIndex = 37;
            this.labFotoPerfil.Text = "Agrega una foto de perfil";
            // 
            // ofdElegirFoto
            // 
            this.ofdElegirFoto.FileName = "openFileDialog1";
            // 
            // gbFoto
            // 
            this.gbFoto.Controls.Add(this.pbFoto);
            this.gbFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFoto.Location = new System.Drawing.Point(12, 102);
            this.gbFoto.Name = "gbFoto";
            this.gbFoto.Size = new System.Drawing.Size(361, 201);
            this.gbFoto.TabIndex = 46;
            this.gbFoto.TabStop = false;
            this.gbFoto.Text = "Vista previa";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(104, 24);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(160, 160);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 43;
            this.pbFoto.TabStop = false;
            // 
            // btnOmitir
            // 
            this.btnOmitir.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnOmitir.AutoSize = false;
            this.btnOmitir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOmitir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOmitir.Depth = 0;
            this.btnOmitir.DrawShadows = false;
            this.btnOmitir.HighEmphasis = true;
            this.btnOmitir.Icon = null;
            this.btnOmitir.Location = new System.Drawing.Point(12, 314);
            this.btnOmitir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOmitir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOmitir.Name = "btnOmitir";
            this.btnOmitir.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnOmitir.Size = new System.Drawing.Size(89, 36);
            this.btnOmitir.TabIndex = 48;
            this.btnOmitir.Text = "OMITIR";
            this.btnOmitir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnOmitir.UseAccentColor = true;
            this.btnOmitir.UseVisualStyleBackColor = true;
            this.btnOmitir.Click += new System.EventHandler(this.btnOmitir_Click);
            // 
            // btnElegirFoto
            // 
            this.btnElegirFoto.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnElegirFoto.AutoSize = false;
            this.btnElegirFoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnElegirFoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnElegirFoto.Depth = 0;
            this.btnElegirFoto.DrawShadows = false;
            this.btnElegirFoto.HighEmphasis = true;
            this.btnElegirFoto.Icon = null;
            this.btnElegirFoto.Location = new System.Drawing.Point(12, 57);
            this.btnElegirFoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnElegirFoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnElegirFoto.Name = "btnElegirFoto";
            this.btnElegirFoto.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnElegirFoto.Size = new System.Drawing.Size(361, 36);
            this.btnElegirFoto.TabIndex = 47;
            this.btnElegirFoto.Text = "ELEGIR UNA FOTO DE MI COMPUTADORA";
            this.btnElegirFoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnElegirFoto.UseAccentColor = true;
            this.btnElegirFoto.UseVisualStyleBackColor = true;
            this.btnElegirFoto.Click += new System.EventHandler(this.btnElegirFoto_Click);
            // 
            // btnAgregarForo
            // 
            this.btnAgregarForo.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAgregarForo.AutoSize = false;
            this.btnAgregarForo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarForo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarForo.Depth = 0;
            this.btnAgregarForo.DrawShadows = false;
            this.btnAgregarForo.HighEmphasis = true;
            this.btnAgregarForo.Icon = null;
            this.btnAgregarForo.Location = new System.Drawing.Point(208, 314);
            this.btnAgregarForo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarForo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarForo.Name = "btnAgregarForo";
            this.btnAgregarForo.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAgregarForo.Size = new System.Drawing.Size(165, 36);
            this.btnAgregarForo.TabIndex = 49;
            this.btnAgregarForo.Text = "AGREGAR ESTA FOTO";
            this.btnAgregarForo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarForo.UseAccentColor = true;
            this.btnAgregarForo.UseVisualStyleBackColor = true;
            this.btnAgregarForo.Click += new System.EventHandler(this.btnAgregarForo_Click);
            // 
            // frmRegistrarsePaso5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnAgregarForo);
            this.Controls.Add(this.btnOmitir);
            this.Controls.Add(this.btnElegirFoto);
            this.Controls.Add(this.gbFoto);
            this.Controls.Add(this.labAviso);
            this.Controls.Add(this.labFotoPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarsePaso5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cargar una foto de perfil";
            this.gbFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labAviso;
        private System.Windows.Forms.Label labFotoPerfil;
        private System.Windows.Forms.OpenFileDialog ofdElegirFoto;
        private System.Windows.Forms.GroupBox gbFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private MaterialSkin.Controls.MaterialButton btnElegirFoto;
        private MaterialSkin.Controls.MaterialButton btnOmitir;
        private MaterialSkin.Controls.MaterialButton btnAgregarForo;
    }
}