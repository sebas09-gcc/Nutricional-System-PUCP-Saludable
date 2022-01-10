
namespace PUCPSaludable.Common
{
    partial class frmMostrarUbicación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarUbicación));
            this.panMap = new System.Windows.Forms.Panel();
            this.mcMap = new GMap.NET.WindowsForms.GMapControl();
            this.panMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMap
            // 
            this.panMap.Controls.Add(this.mcMap);
            this.panMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMap.Location = new System.Drawing.Point(0, 0);
            this.panMap.Margin = new System.Windows.Forms.Padding(0);
            this.panMap.Name = "panMap";
            this.panMap.Size = new System.Drawing.Size(784, 461);
            this.panMap.TabIndex = 3;
            // 
            // mcMap
            // 
            this.mcMap.BackColor = System.Drawing.Color.Transparent;
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
            this.mcMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.ViewCenter;
            this.mcMap.Name = "mcMap";
            this.mcMap.NegativeMode = false;
            this.mcMap.PolygonsEnabled = false;
            this.mcMap.RetryLoadTile = 0;
            this.mcMap.RoutesEnabled = false;
            this.mcMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.mcMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mcMap.ShowTileGridLines = false;
            this.mcMap.Size = new System.Drawing.Size(784, 461);
            this.mcMap.TabIndex = 0;
            this.mcMap.Zoom = 14D;
            // 
            // frmMostrarUbicación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panMap);
            this.Name = "frmMostrarUbicación";
            this.Text = "Ubicación";
            this.panMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMap;
        private GMap.NET.WindowsForms.GMapControl mcMap;
    }
}