
namespace PUCPSaludable.Alumno.Nutricionista
{
    partial class frmDetalleReceta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleReceta));
            this.labRecipeName = new MaterialSkin.Controls.MaterialLabel();
            this.LabelInstructions = new MaterialSkin.Controls.MaterialLabel();
            this.ListBoxIngredients = new System.Windows.Forms.ListBox();
            this.TextBoxInstructions = new System.Windows.Forms.TextBox();
            this.PanelContenedorPrincipal = new System.Windows.Forms.Panel();
            this.LabelIngredients = new MaterialSkin.Controls.MaterialLabel();
            this.LabelBottom = new System.Windows.Forms.Label();
            this.wvImagen = new PUCPSaludable.Controles.ucWebView();
            this.PanelContenedorPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // labRecipeName
            // 
            this.labRecipeName.AutoSize = true;
            this.labRecipeName.Depth = 0;
            this.labRecipeName.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labRecipeName.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labRecipeName.Location = new System.Drawing.Point(12, 8);
            this.labRecipeName.Margin = new System.Windows.Forms.Padding(3);
            this.labRecipeName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labRecipeName.Name = "labRecipeName";
            this.labRecipeName.Size = new System.Drawing.Size(330, 29);
            this.labRecipeName.TabIndex = 5;
            this.labRecipeName.Text = "Sandwich de salmón ahumado";
            // 
            // LabelInstructions
            // 
            this.LabelInstructions.AutoSize = true;
            this.LabelInstructions.Depth = 0;
            this.LabelInstructions.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelInstructions.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelInstructions.Location = new System.Drawing.Point(13, 319);
            this.LabelInstructions.Margin = new System.Windows.Forms.Padding(3);
            this.LabelInstructions.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelInstructions.Name = "LabelInstructions";
            this.LabelInstructions.Size = new System.Drawing.Size(131, 24);
            this.LabelInstructions.TabIndex = 8;
            this.LabelInstructions.Text = "Procedimiento";
            // 
            // ListBoxIngredients
            // 
            this.ListBoxIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxIngredients.Enabled = false;
            this.ListBoxIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxIngredients.FormattingEnabled = true;
            this.ListBoxIngredients.ItemHeight = 16;
            this.ListBoxIngredients.Location = new System.Drawing.Point(12, 283);
            this.ListBoxIngredients.Name = "ListBoxIngredients";
            this.ListBoxIngredients.Size = new System.Drawing.Size(560, 16);
            this.ListBoxIngredients.Sorted = true;
            this.ListBoxIngredients.TabIndex = 0;
            this.ListBoxIngredients.UseTabStops = false;
            // 
            // TextBoxInstructions
            // 
            this.TextBoxInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInstructions.Location = new System.Drawing.Point(11, 349);
            this.TextBoxInstructions.Multiline = true;
            this.TextBoxInstructions.Name = "TextBoxInstructions";
            this.TextBoxInstructions.Size = new System.Drawing.Size(560, 30);
            this.TextBoxInstructions.TabIndex = 10;
            this.TextBoxInstructions.Text = "Las indicaciones van aquí";
            this.TextBoxInstructions.TextChanged += new System.EventHandler(this.TextBoxInstructions_TextChanged);
            // 
            // PanelContenedorPrincipal
            // 
            this.PanelContenedorPrincipal.Controls.Add(this.wvImagen);
            this.PanelContenedorPrincipal.Controls.Add(this.LabelIngredients);
            this.PanelContenedorPrincipal.Controls.Add(this.LabelBottom);
            this.PanelContenedorPrincipal.Controls.Add(this.TextBoxInstructions);
            this.PanelContenedorPrincipal.Controls.Add(this.ListBoxIngredients);
            this.PanelContenedorPrincipal.Controls.Add(this.LabelInstructions);
            this.PanelContenedorPrincipal.Controls.Add(this.labRecipeName);
            this.PanelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedorPrincipal.Margin = new System.Windows.Forms.Padding(10);
            this.PanelContenedorPrincipal.Name = "PanelContenedorPrincipal";
            this.PanelContenedorPrincipal.Size = new System.Drawing.Size(584, 561);
            this.PanelContenedorPrincipal.TabIndex = 5;
            // 
            // LabelIngredients
            // 
            this.LabelIngredients.AutoSize = true;
            this.LabelIngredients.Depth = 0;
            this.LabelIngredients.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelIngredients.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelIngredients.Location = new System.Drawing.Point(13, 253);
            this.LabelIngredients.Margin = new System.Windows.Forms.Padding(3);
            this.LabelIngredients.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelIngredients.Name = "LabelIngredients";
            this.LabelIngredients.Size = new System.Drawing.Size(113, 24);
            this.LabelIngredients.TabIndex = 13;
            this.LabelIngredients.Text = "Ingredientes";
            // 
            // LabelBottom
            // 
            this.LabelBottom.AutoSize = true;
            this.LabelBottom.Location = new System.Drawing.Point(14, 382);
            this.LabelBottom.Name = "LabelBottom";
            this.LabelBottom.Size = new System.Drawing.Size(0, 13);
            this.LabelBottom.TabIndex = 12;
            // 
            // wvImagen
            // 
            this.wvImagen.Location = new System.Drawing.Point(0, 47);
            this.wvImagen.Name = "wvImagen";
            this.wvImagen.Size = new System.Drawing.Size(584, 200);
            this.wvImagen.TabIndex = 14;
            this.wvImagen.URL = null;
            // 
            // frmDetalleReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.PanelContenedorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalleReceta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receta - Sandwich de salmón ahumado";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.PanelContenedorPrincipal.ResumeLayout(false);
            this.PanelContenedorPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labRecipeName;
        private MaterialSkin.Controls.MaterialLabel LabelInstructions;
        private System.Windows.Forms.ListBox ListBoxIngredients;
        private System.Windows.Forms.TextBox TextBoxInstructions;
        private System.Windows.Forms.Panel PanelContenedorPrincipal;
        private System.Windows.Forms.Label LabelBottom;
        private MaterialSkin.Controls.MaterialLabel LabelIngredients;
        private Controles.ucWebView wvImagen;
    }
}