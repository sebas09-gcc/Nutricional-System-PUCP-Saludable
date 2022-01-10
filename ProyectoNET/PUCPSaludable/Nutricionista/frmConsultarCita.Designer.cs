
namespace PUCPSaludable.Nutricionista
{
    partial class frmConsultarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCita));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panIzquierdo = new System.Windows.Forms.Panel();
            this.tbEnlace = new MaterialSkin.Controls.MaterialTextBox();
            this.tbDuracion = new MaterialSkin.Controls.MaterialTextBox();
            this.tbHora = new MaterialSkin.Controls.MaterialTextBox();
            this.tbFecha = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCorreoPUCP = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNombres = new MaterialSkin.Controls.MaterialTextBox();
            this.tbApellidos = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCodigoPUCP = new MaterialSkin.Controls.MaterialTextBox();
            this.panDerecho = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tlpPrincipal.SuspendLayout();
            this.panIzquierdo.SuspendLayout();
            this.panDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpPrincipal.Controls.Add(this.panIzquierdo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.panDerecho, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(584, 411);
            this.tlpPrincipal.TabIndex = 21;
            // 
            // panIzquierdo
            // 
            this.panIzquierdo.Controls.Add(this.tbEnlace);
            this.panIzquierdo.Controls.Add(this.tbDuracion);
            this.panIzquierdo.Controls.Add(this.tbHora);
            this.panIzquierdo.Controls.Add(this.tbFecha);
            this.panIzquierdo.Controls.Add(this.tbCorreoPUCP);
            this.panIzquierdo.Controls.Add(this.tbNombres);
            this.panIzquierdo.Controls.Add(this.tbApellidos);
            this.panIzquierdo.Controls.Add(this.tbCodigoPUCP);
            this.panIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panIzquierdo.Margin = new System.Windows.Forms.Padding(0);
            this.panIzquierdo.Name = "panIzquierdo";
            this.panIzquierdo.Size = new System.Drawing.Size(434, 411);
            this.panIzquierdo.TabIndex = 20;
            // 
            // tbEnlace
            // 
            this.tbEnlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbEnlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEnlace.Depth = 0;
            this.tbEnlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEnlace.HideSelection = true;
            this.tbEnlace.Hint = "Enlace a la reunión";
            this.tbEnlace.LeadingIcon = null;
            this.tbEnlace.Location = new System.Drawing.Point(11, 271);
            this.tbEnlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEnlace.MaxLength = 32767;
            this.tbEnlace.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEnlace.Name = "tbEnlace";
            this.tbEnlace.PasswordChar = '\0';
            this.tbEnlace.PrefixSuffixText = null;
            this.tbEnlace.ReadOnly = false;
            this.tbEnlace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEnlace.SelectedText = "";
            this.tbEnlace.SelectionLength = 0;
            this.tbEnlace.SelectionStart = 0;
            this.tbEnlace.ShortcutsEnabled = true;
            this.tbEnlace.Size = new System.Drawing.Size(410, 48);
            this.tbEnlace.TabIndex = 27;
            this.tbEnlace.TabStop = false;
            this.tbEnlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEnlace.TrailingIcon = null;
            this.tbEnlace.UseSystemPasswordChar = false;
            // 
            // tbDuracion
            // 
            this.tbDuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbDuracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDuracion.Depth = 0;
            this.tbDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDuracion.HideSelection = true;
            this.tbDuracion.Hint = "Duración";
            this.tbDuracion.LeadingIcon = null;
            this.tbDuracion.Location = new System.Drawing.Point(278, 219);
            this.tbDuracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDuracion.MaxLength = 32767;
            this.tbDuracion.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.PasswordChar = '\0';
            this.tbDuracion.PrefixSuffixText = null;
            this.tbDuracion.ReadOnly = false;
            this.tbDuracion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDuracion.SelectedText = "";
            this.tbDuracion.SelectionLength = 0;
            this.tbDuracion.SelectionStart = 0;
            this.tbDuracion.ShortcutsEnabled = true;
            this.tbDuracion.Size = new System.Drawing.Size(143, 48);
            this.tbDuracion.TabIndex = 26;
            this.tbDuracion.TabStop = false;
            this.tbDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDuracion.TrailingIcon = null;
            this.tbDuracion.UseSystemPasswordChar = false;
            // 
            // tbHora
            // 
            this.tbHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbHora.Depth = 0;
            this.tbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbHora.HideSelection = true;
            this.tbHora.Hint = "Hora";
            this.tbHora.LeadingIcon = null;
            this.tbHora.Location = new System.Drawing.Point(169, 219);
            this.tbHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHora.MaxLength = 32767;
            this.tbHora.MouseState = MaterialSkin.MouseState.OUT;
            this.tbHora.Name = "tbHora";
            this.tbHora.PasswordChar = '\0';
            this.tbHora.PrefixSuffixText = null;
            this.tbHora.ReadOnly = false;
            this.tbHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbHora.SelectedText = "";
            this.tbHora.SelectionLength = 0;
            this.tbHora.SelectionStart = 0;
            this.tbHora.ShortcutsEnabled = true;
            this.tbHora.Size = new System.Drawing.Size(105, 48);
            this.tbHora.TabIndex = 25;
            this.tbHora.TabStop = false;
            this.tbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbHora.TrailingIcon = null;
            this.tbHora.UseSystemPasswordChar = false;
            // 
            // tbFecha
            // 
            this.tbFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbFecha.Depth = 0;
            this.tbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbFecha.HideSelection = true;
            this.tbFecha.Hint = "Fecha";
            this.tbFecha.LeadingIcon = null;
            this.tbFecha.Location = new System.Drawing.Point(11, 219);
            this.tbFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFecha.MaxLength = 32767;
            this.tbFecha.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.PasswordChar = '\0';
            this.tbFecha.PrefixSuffixText = null;
            this.tbFecha.ReadOnly = false;
            this.tbFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFecha.SelectedText = "";
            this.tbFecha.SelectionLength = 0;
            this.tbFecha.SelectionStart = 0;
            this.tbFecha.ShortcutsEnabled = true;
            this.tbFecha.Size = new System.Drawing.Size(154, 48);
            this.tbFecha.TabIndex = 24;
            this.tbFecha.TabStop = false;
            this.tbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFecha.TrailingIcon = null;
            this.tbFecha.UseSystemPasswordChar = false;
            // 
            // tbCorreoPUCP
            // 
            this.tbCorreoPUCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCorreoPUCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCorreoPUCP.Depth = 0;
            this.tbCorreoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCorreoPUCP.HideSelection = true;
            this.tbCorreoPUCP.Hint = "Correo PUCP";
            this.tbCorreoPUCP.LeadingIcon = null;
            this.tbCorreoPUCP.Location = new System.Drawing.Point(11, 167);
            this.tbCorreoPUCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCorreoPUCP.MaxLength = 32767;
            this.tbCorreoPUCP.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCorreoPUCP.Name = "tbCorreoPUCP";
            this.tbCorreoPUCP.PasswordChar = '\0';
            this.tbCorreoPUCP.PrefixSuffixText = null;
            this.tbCorreoPUCP.ReadOnly = false;
            this.tbCorreoPUCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCorreoPUCP.SelectedText = "";
            this.tbCorreoPUCP.SelectionLength = 0;
            this.tbCorreoPUCP.SelectionStart = 0;
            this.tbCorreoPUCP.ShortcutsEnabled = true;
            this.tbCorreoPUCP.Size = new System.Drawing.Size(410, 48);
            this.tbCorreoPUCP.TabIndex = 23;
            this.tbCorreoPUCP.TabStop = false;
            this.tbCorreoPUCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCorreoPUCP.TrailingIcon = null;
            this.tbCorreoPUCP.UseSystemPasswordChar = false;
            // 
            // tbNombres
            // 
            this.tbNombres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNombres.Depth = 0;
            this.tbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombres.HideSelection = true;
            this.tbNombres.Hint = "Nombres";
            this.tbNombres.LeadingIcon = null;
            this.tbNombres.Location = new System.Drawing.Point(11, 115);
            this.tbNombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombres.MaxLength = 32767;
            this.tbNombres.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.PasswordChar = '\0';
            this.tbNombres.PrefixSuffixText = null;
            this.tbNombres.ReadOnly = false;
            this.tbNombres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNombres.SelectedText = "";
            this.tbNombres.SelectionLength = 0;
            this.tbNombres.SelectionStart = 0;
            this.tbNombres.ShortcutsEnabled = true;
            this.tbNombres.Size = new System.Drawing.Size(410, 48);
            this.tbNombres.TabIndex = 22;
            this.tbNombres.TabStop = false;
            this.tbNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNombres.TrailingIcon = null;
            this.tbNombres.UseSystemPasswordChar = false;
            // 
            // tbApellidos
            // 
            this.tbApellidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbApellidos.Depth = 0;
            this.tbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbApellidos.HideSelection = true;
            this.tbApellidos.Hint = "Apellidos";
            this.tbApellidos.LeadingIcon = null;
            this.tbApellidos.Location = new System.Drawing.Point(11, 63);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbApellidos.MaxLength = 32767;
            this.tbApellidos.MouseState = MaterialSkin.MouseState.OUT;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.PasswordChar = '\0';
            this.tbApellidos.PrefixSuffixText = null;
            this.tbApellidos.ReadOnly = false;
            this.tbApellidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbApellidos.SelectedText = "";
            this.tbApellidos.SelectionLength = 0;
            this.tbApellidos.SelectionStart = 0;
            this.tbApellidos.ShortcutsEnabled = true;
            this.tbApellidos.Size = new System.Drawing.Size(410, 48);
            this.tbApellidos.TabIndex = 21;
            this.tbApellidos.TabStop = false;
            this.tbApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbApellidos.TrailingIcon = null;
            this.tbApellidos.UseSystemPasswordChar = false;
            // 
            // tbCodigoPUCP
            // 
            this.tbCodigoPUCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCodigoPUCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCodigoPUCP.Depth = 0;
            this.tbCodigoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCodigoPUCP.HideSelection = true;
            this.tbCodigoPUCP.Hint = "Código PUCP";
            this.tbCodigoPUCP.LeadingIcon = null;
            this.tbCodigoPUCP.Location = new System.Drawing.Point(11, 11);
            this.tbCodigoPUCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCodigoPUCP.MaxLength = 32767;
            this.tbCodigoPUCP.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCodigoPUCP.Name = "tbCodigoPUCP";
            this.tbCodigoPUCP.PasswordChar = '\0';
            this.tbCodigoPUCP.PrefixSuffixText = null;
            this.tbCodigoPUCP.ReadOnly = false;
            this.tbCodigoPUCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCodigoPUCP.SelectedText = "";
            this.tbCodigoPUCP.SelectionLength = 0;
            this.tbCodigoPUCP.SelectionStart = 0;
            this.tbCodigoPUCP.ShortcutsEnabled = true;
            this.tbCodigoPUCP.Size = new System.Drawing.Size(410, 48);
            this.tbCodigoPUCP.TabIndex = 20;
            this.tbCodigoPUCP.TabStop = false;
            this.tbCodigoPUCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCodigoPUCP.TrailingIcon = null;
            this.tbCodigoPUCP.UseSystemPasswordChar = false;
            // 
            // panDerecho
            // 
            this.panDerecho.Controls.Add(this.pbFoto);
            this.panDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDerecho.Location = new System.Drawing.Point(436, 2);
            this.panDerecho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panDerecho.Name = "panDerecho";
            this.panDerecho.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panDerecho.Size = new System.Drawing.Size(146, 407);
            this.panDerecho.TabIndex = 22;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.LightGray;
            this.pbFoto.Location = new System.Drawing.Point(17, 9);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(119, 161);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 11;
            this.pbFoto.TabStop = false;
            // 
            // frmConsultarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarCita";
            this.Text = "Consultar cita";
            this.tlpPrincipal.ResumeLayout(false);
            this.panIzquierdo.ResumeLayout(false);
            this.panDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel panIzquierdo;
        private MaterialSkin.Controls.MaterialTextBox tbEnlace;
        private MaterialSkin.Controls.MaterialTextBox tbDuracion;
        private MaterialSkin.Controls.MaterialTextBox tbHora;
        private MaterialSkin.Controls.MaterialTextBox tbFecha;
        private MaterialSkin.Controls.MaterialTextBox tbCorreoPUCP;
        private MaterialSkin.Controls.MaterialTextBox tbNombres;
        private MaterialSkin.Controls.MaterialTextBox tbApellidos;
        private MaterialSkin.Controls.MaterialTextBox tbCodigoPUCP;
        private System.Windows.Forms.Panel panDerecho;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}