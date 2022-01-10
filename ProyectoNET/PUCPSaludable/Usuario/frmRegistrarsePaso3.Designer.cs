
namespace PUCPSaludable.Usuario
{
    partial class frmRegistrarsePaso3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarsePaso3));
            this.tbSoloLecturaAvisoRol = new System.Windows.Forms.TextBox();
            this.labRol = new System.Windows.Forms.Label();
            this.labAviso = new System.Windows.Forms.Label();
            this.btnAlumno = new MaterialSkin.Controls.MaterialButton();
            this.btnNutricionista = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // tbSoloLecturaAvisoRol
            // 
            this.tbSoloLecturaAvisoRol.BackColor = System.Drawing.Color.White;
            this.tbSoloLecturaAvisoRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoloLecturaAvisoRol.Enabled = false;
            this.tbSoloLecturaAvisoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoloLecturaAvisoRol.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSoloLecturaAvisoRol.Location = new System.Drawing.Point(12, 309);
            this.tbSoloLecturaAvisoRol.Multiline = true;
            this.tbSoloLecturaAvisoRol.Name = "tbSoloLecturaAvisoRol";
            this.tbSoloLecturaAvisoRol.ReadOnly = true;
            this.tbSoloLecturaAvisoRol.Size = new System.Drawing.Size(360, 40);
            this.tbSoloLecturaAvisoRol.TabIndex = 18;
            this.tbSoloLecturaAvisoRol.Text = "Si eliges Nutricionista, deberás esperar a la aprobación del administrador del si" +
    "stema. Esto podría tardar varias horas.";
            // 
            // labRol
            // 
            this.labRol.AutoSize = true;
            this.labRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRol.Location = new System.Drawing.Point(12, 9);
            this.labRol.Name = "labRol";
            this.labRol.Size = new System.Drawing.Size(114, 25);
            this.labRol.TabIndex = 12;
            this.labRol.Text = "Elige tu rol";
            // 
            // labAviso
            // 
            this.labAviso.AutoSize = true;
            this.labAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAviso.Location = new System.Drawing.Point(14, 37);
            this.labAviso.Name = "labAviso";
            this.labAviso.Size = new System.Drawing.Size(331, 13);
            this.labAviso.TabIndex = 13;
            this.labAviso.Text = "Los roles Nutricionista, Psicólogo y Entrenador requerirán aprobación";
            // 
            // btnAlumno
            // 
            this.btnAlumno.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAlumno.AutoSize = false;
            this.btnAlumno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlumno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAlumno.Depth = 0;
            this.btnAlumno.DrawShadows = false;
            this.btnAlumno.HighEmphasis = true;
            this.btnAlumno.Icon = null;
            this.btnAlumno.Location = new System.Drawing.Point(13, 65);
            this.btnAlumno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAlumno.Size = new System.Drawing.Size(359, 36);
            this.btnAlumno.TabIndex = 19;
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAlumno.UseAccentColor = true;
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnNutricionista
            // 
            this.btnNutricionista.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnNutricionista.AutoSize = false;
            this.btnNutricionista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNutricionista.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNutricionista.Depth = 0;
            this.btnNutricionista.DrawShadows = false;
            this.btnNutricionista.HighEmphasis = true;
            this.btnNutricionista.Icon = null;
            this.btnNutricionista.Location = new System.Drawing.Point(11, 113);
            this.btnNutricionista.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNutricionista.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNutricionista.Name = "btnNutricionista";
            this.btnNutricionista.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnNutricionista.Size = new System.Drawing.Size(360, 36);
            this.btnNutricionista.TabIndex = 20;
            this.btnNutricionista.Text = "Nutricionista";
            this.btnNutricionista.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNutricionista.UseAccentColor = true;
            this.btnNutricionista.UseVisualStyleBackColor = true;
            this.btnNutricionista.Click += new System.EventHandler(this.btnNutricionista_Click);
            // 
            // frmRegistrarsePaso3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnNutricionista);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.tbSoloLecturaAvisoRol);
            this.Controls.Add(this.labAviso);
            this.Controls.Add(this.labRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarsePaso3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elige tu rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSoloLecturaAvisoRol;
        private System.Windows.Forms.Label labRol;
        private System.Windows.Forms.Label labAviso;
        private MaterialSkin.Controls.MaterialButton btnAlumno;
        private MaterialSkin.Controls.MaterialButton btnNutricionista;
    }
}