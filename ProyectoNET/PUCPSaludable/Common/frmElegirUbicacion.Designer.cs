
namespace PUCPSaludable.Common
{
    partial class frmElegirUbicacion
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
            this.mcMap = new GMap.NET.WindowsForms.GMapControl();
            this.panHeader = new System.Windows.Forms.Panel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panHeaderLocation = new System.Windows.Forms.Panel();
            this.tbLatitude = new MaterialSkin.Controls.MaterialTextBox();
            this.tbName = new MaterialSkin.Controls.MaterialTextBox();
            this.tbLongitude = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChooseLocation = new MaterialSkin.Controls.MaterialButton();
            this.panMap = new System.Windows.Forms.Panel();
            this.panHeader.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.panHeaderLocation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcMap
            // 
            this.mcMap.Bearing = 0F;
            this.mcMap.CanDragMap = true;
            this.mcMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.mcMap.GrayScaleMode = false;
            this.mcMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mcMap.LevelsKeepInMemmory = 5;
            this.mcMap.Location = new System.Drawing.Point(0, 0);
            this.mcMap.MarkersEnabled = true;
            this.mcMap.MaxZoom = 20;
            this.mcMap.MinZoom = 14;
            this.mcMap.MouseWheelZoomEnabled = true;
            this.mcMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mcMap.Name = "mcMap";
            this.mcMap.NegativeMode = false;
            this.mcMap.PolygonsEnabled = false;
            this.mcMap.RetryLoadTile = 0;
            this.mcMap.RoutesEnabled = false;
            this.mcMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.mcMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mcMap.ShowTileGridLines = false;
            this.mcMap.Size = new System.Drawing.Size(800, 390);
            this.mcMap.TabIndex = 0;
            this.mcMap.Zoom = 14D;
            this.mcMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.mcMap_OnMarkerClick);
            this.mcMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mcMap_MouseClick);
            // 
            // panHeader
            // 
            this.panHeader.Controls.Add(this.tlpHeader);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(800, 60);
            this.panHeader.TabIndex = 1;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpHeader.Controls.Add(this.panHeaderLocation, 0, 0);
            this.tlpHeader.Controls.Add(this.panel1, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(800, 60);
            this.tlpHeader.TabIndex = 5;
            // 
            // panHeaderLocation
            // 
            this.panHeaderLocation.Controls.Add(this.tbLatitude);
            this.panHeaderLocation.Controls.Add(this.tbName);
            this.panHeaderLocation.Controls.Add(this.tbLongitude);
            this.panHeaderLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHeaderLocation.Location = new System.Drawing.Point(0, 0);
            this.panHeaderLocation.Margin = new System.Windows.Forms.Padding(0);
            this.panHeaderLocation.Name = "panHeaderLocation";
            this.panHeaderLocation.Size = new System.Drawing.Size(650, 60);
            this.panHeaderLocation.TabIndex = 0;
            // 
            // tbLatitude
            // 
            this.tbLatitude.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbLatitude.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLatitude.Depth = 0;
            this.tbLatitude.Enabled = false;
            this.tbLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLatitude.HideSelection = true;
            this.tbLatitude.Hint = "Latitud";
            this.tbLatitude.LeadingIcon = null;
            this.tbLatitude.Location = new System.Drawing.Point(12, 12);
            this.tbLatitude.MaxLength = 32767;
            this.tbLatitude.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.PasswordChar = '\0';
            this.tbLatitude.PrefixSuffixText = null;
            this.tbLatitude.ReadOnly = false;
            this.tbLatitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLatitude.SelectedText = "";
            this.tbLatitude.SelectionLength = 0;
            this.tbLatitude.SelectionStart = 0;
            this.tbLatitude.ShortcutsEnabled = true;
            this.tbLatitude.Size = new System.Drawing.Size(107, 36);
            this.tbLatitude.TabIndex = 2;
            this.tbLatitude.TabStop = false;
            this.tbLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLatitude.TrailingIcon = null;
            this.tbLatitude.UseSystemPasswordChar = false;
            this.tbLatitude.UseTallSize = false;
            // 
            // tbName
            // 
            this.tbName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbName.Depth = 0;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbName.HideSelection = true;
            this.tbName.Hint = "Lugar";
            this.tbName.LeadingIcon = null;
            this.tbName.Location = new System.Drawing.Point(229, 12);
            this.tbName.MaxLength = 32767;
            this.tbName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PrefixSuffixText = null;
            this.tbName.ReadOnly = false;
            this.tbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(418, 36);
            this.tbName.TabIndex = 4;
            this.tbName.TabStop = false;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.TrailingIcon = null;
            this.tbName.UseSystemPasswordChar = false;
            this.tbName.UseTallSize = false;
            // 
            // tbLongitude
            // 
            this.tbLongitude.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbLongitude.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLongitude.Depth = 0;
            this.tbLongitude.Enabled = false;
            this.tbLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLongitude.HideSelection = true;
            this.tbLongitude.Hint = "Longitud";
            this.tbLongitude.LeadingIcon = null;
            this.tbLongitude.Location = new System.Drawing.Point(125, 12);
            this.tbLongitude.MaxLength = 32767;
            this.tbLongitude.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.PasswordChar = '\0';
            this.tbLongitude.PrefixSuffixText = null;
            this.tbLongitude.ReadOnly = false;
            this.tbLongitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLongitude.SelectedText = "";
            this.tbLongitude.SelectionLength = 0;
            this.tbLongitude.SelectionStart = 0;
            this.tbLongitude.ShortcutsEnabled = true;
            this.tbLongitude.Size = new System.Drawing.Size(98, 36);
            this.tbLongitude.TabIndex = 3;
            this.tbLongitude.TabStop = false;
            this.tbLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLongitude.TrailingIcon = null;
            this.tbLongitude.UseSystemPasswordChar = false;
            this.tbLongitude.UseTallSize = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChooseLocation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(650, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnChooseLocation
            // 
            this.btnChooseLocation.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnChooseLocation.AutoSize = false;
            this.btnChooseLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseLocation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChooseLocation.Depth = 0;
            this.btnChooseLocation.DrawShadows = false;
            this.btnChooseLocation.HighEmphasis = true;
            this.btnChooseLocation.Icon = null;
            this.btnChooseLocation.Location = new System.Drawing.Point(13, 12);
            this.btnChooseLocation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChooseLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseLocation.Name = "btnChooseLocation";
            this.btnChooseLocation.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnChooseLocation.Size = new System.Drawing.Size(124, 36);
            this.btnChooseLocation.TabIndex = 0;
            this.btnChooseLocation.Text = "seleccionar";
            this.btnChooseLocation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChooseLocation.UseAccentColor = true;
            this.btnChooseLocation.UseVisualStyleBackColor = true;
            this.btnChooseLocation.Click += new System.EventHandler(this.btnChooseLocation_Click);
            // 
            // panMap
            // 
            this.panMap.Controls.Add(this.mcMap);
            this.panMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMap.Location = new System.Drawing.Point(0, 60);
            this.panMap.Margin = new System.Windows.Forms.Padding(0);
            this.panMap.Name = "panMap";
            this.panMap.Size = new System.Drawing.Size(800, 390);
            this.panMap.TabIndex = 2;
            // 
            // frmElegirUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panMap);
            this.Controls.Add(this.panHeader);
            this.Name = "frmElegirUbicacion";
            this.Text = "Elegir ubicación";
            this.panHeader.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.panHeaderLocation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mcMap;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panMap;
        private MaterialSkin.Controls.MaterialTextBox tbLongitude;
        private MaterialSkin.Controls.MaterialTextBox tbLatitude;
        private MaterialSkin.Controls.MaterialTextBox tbName;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Panel panHeaderLocation;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnChooseLocation;
    }
}