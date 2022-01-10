
namespace PUCPSaludable.Nutricionista
{
    partial class frmPrincipalNutricionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalNutricionista));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNavegacion = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnDashboard = new MaterialSkin.Controls.MaterialButton();
            this.btnAlumnos = new MaterialSkin.Controls.MaterialButton();
            this.btnDisponibilidad = new MaterialSkin.Controls.MaterialButton();
            this.btnCitas = new MaterialSkin.Controls.MaterialButton();
            this.btnPerfil = new MaterialSkin.Controls.MaterialButton();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.tlpPrincipal.SuspendLayout();
            this.tlpNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpNavegacion, 0, 0);
            this.tlpPrincipal.Controls.Add(this.panPrincipal, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1096, 575);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // tlpNavegacion
            // 
            this.tlpNavegacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlpNavegacion.ColumnCount = 9;
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpNavegacion.Controls.Add(this.btnSalir, 7, 1);
            this.tlpNavegacion.Controls.Add(this.btnDashboard, 1, 1);
            this.tlpNavegacion.Controls.Add(this.btnAlumnos, 3, 1);
            this.tlpNavegacion.Controls.Add(this.btnDisponibilidad, 4, 1);
            this.tlpNavegacion.Controls.Add(this.btnCitas, 2, 1);
            this.tlpNavegacion.Controls.Add(this.btnPerfil, 6, 1);
            this.tlpNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavegacion.Location = new System.Drawing.Point(0, 0);
            this.tlpNavegacion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNavegacion.Name = "tlpNavegacion";
            this.tlpNavegacion.RowCount = 3;
            this.tlpNavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpNavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpNavegacion.Size = new System.Drawing.Size(1096, 66);
            this.tlpNavegacion.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.DrawShadows = false;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = global::PUCPSaludable.Properties.Resources.logout;
            this.btnSalir.Location = new System.Drawing.Point(1040, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSalir.Size = new System.Drawing.Size(42, 34);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnSalir.UseAccentColor = true;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnDashboard.AutoSize = false;
            this.btnDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDashboard.Depth = 0;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashboard.DrawShadows = false;
            this.btnDashboard.HighEmphasis = true;
            this.btnDashboard.Icon = null;
            this.btnDashboard.Location = new System.Drawing.Point(14, 16);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDashboard.Size = new System.Drawing.Size(92, 34);
            this.btnDashboard.TabIndex = 12;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Text = "Inicio";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnDashboard.UseAccentColor = true;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAlumnos.AutoSize = false;
            this.btnAlumnos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlumnos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAlumnos.Depth = 0;
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlumnos.DrawShadows = false;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.HighEmphasis = true;
            this.btnAlumnos.Icon = null;
            this.btnAlumnos.Location = new System.Drawing.Point(214, 16);
            this.btnAlumnos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlumnos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAlumnos.Size = new System.Drawing.Size(92, 34);
            this.btnAlumnos.TabIndex = 12;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlumnos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnAlumnos.UseAccentColor = true;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnDisponibilidad
            // 
            this.btnDisponibilidad.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnDisponibilidad.AutoSize = false;
            this.btnDisponibilidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisponibilidad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDisponibilidad.Depth = 0;
            this.btnDisponibilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisponibilidad.DrawShadows = false;
            this.btnDisponibilidad.HighEmphasis = true;
            this.btnDisponibilidad.Icon = null;
            this.btnDisponibilidad.Location = new System.Drawing.Point(314, 16);
            this.btnDisponibilidad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDisponibilidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisponibilidad.Name = "btnDisponibilidad";
            this.btnDisponibilidad.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDisponibilidad.Size = new System.Drawing.Size(142, 34);
            this.btnDisponibilidad.TabIndex = 13;
            this.btnDisponibilidad.Text = "Disponibilidad";
            this.btnDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisponibilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisponibilidad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnDisponibilidad.UseAccentColor = true;
            this.btnDisponibilidad.UseVisualStyleBackColor = true;
            this.btnDisponibilidad.Click += new System.EventHandler(this.btnDisponibilidad_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnCitas.AutoSize = false;
            this.btnCitas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCitas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCitas.Depth = 0;
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCitas.DrawShadows = false;
            this.btnCitas.HighEmphasis = true;
            this.btnCitas.Icon = null;
            this.btnCitas.Location = new System.Drawing.Point(114, 16);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCitas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnCitas.Size = new System.Drawing.Size(92, 34);
            this.btnCitas.TabIndex = 11;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCitas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCitas.UseAccentColor = true;
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnPerfil.AutoSize = false;
            this.btnPerfil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPerfil.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPerfil.Depth = 0;
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPerfil.DrawShadows = false;
            this.btnPerfil.HighEmphasis = true;
            this.btnPerfil.Icon = global::PUCPSaludable.Properties.Resources.user;
            this.btnPerfil.Location = new System.Drawing.Point(990, 16);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPerfil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnPerfil.Size = new System.Drawing.Size(42, 34);
            this.btnPerfil.TabIndex = 15;
            this.btnPerfil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnPerfil.UseAccentColor = true;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // panPrincipal
            // 
            this.panPrincipal.BackColor = System.Drawing.Color.White;
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Location = new System.Drawing.Point(0, 66);
            this.panPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(1096, 509);
            this.panPrincipal.TabIndex = 4;
            // 
            // frmPrincipalNutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 575);
            this.Controls.Add(this.tlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipalNutricionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUCP Saludable";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpNavegacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpNavegacion;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnDashboard;
        private MaterialSkin.Controls.MaterialButton btnAlumnos;
        private MaterialSkin.Controls.MaterialButton btnDisponibilidad;
        private MaterialSkin.Controls.MaterialButton btnCitas;
        private MaterialSkin.Controls.MaterialButton btnPerfil;
    }
}
