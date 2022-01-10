
namespace PUCPSaludable.Alumno.Nutricionista
{
    partial class frmAlimentoPredilecto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpAlimentoCalif = new System.Windows.Forms.TableLayoutPanel();
            this.labAlimento = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tlpAlimentoCalif.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpAlimentoCalif);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 62);
            this.panel1.TabIndex = 0;
            // 
            // tlpAlimentoCalif
            // 
            this.tlpAlimentoCalif.ColumnCount = 2;
            this.tlpAlimentoCalif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAlimentoCalif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tlpAlimentoCalif.Controls.Add(this.btnBorrar, 1, 0);
            this.tlpAlimentoCalif.Controls.Add(this.labAlimento, 0, 0);
            this.tlpAlimentoCalif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAlimentoCalif.Location = new System.Drawing.Point(0, 0);
            this.tlpAlimentoCalif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpAlimentoCalif.Name = "tlpAlimentoCalif";
            this.tlpAlimentoCalif.RowCount = 1;
            this.tlpAlimentoCalif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAlimentoCalif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpAlimentoCalif.Size = new System.Drawing.Size(333, 62);
            this.tlpAlimentoCalif.TabIndex = 2;
            // 
            // labAlimento
            // 
            this.labAlimento.AutoSize = true;
            this.labAlimento.Location = new System.Drawing.Point(4, 0);
            this.labAlimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAlimento.Name = "labAlimento";
            this.labAlimento.Size = new System.Drawing.Size(46, 17);
            this.labAlimento.TabIndex = 0;
            this.labAlimento.Text = "label1";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(204, 4);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 28);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // frmAlimentoPredilecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(333, 62);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAlimentoPredilecto";
            this.Text = "AlimentoPredilecto";
            this.panel1.ResumeLayout(false);
            this.tlpAlimentoCalif.ResumeLayout(false);
            this.tlpAlimentoCalif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labAlimento;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TableLayoutPanel tlpAlimentoCalif;
    }
}