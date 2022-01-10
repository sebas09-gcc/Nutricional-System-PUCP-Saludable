
namespace PUCPSaludable.Controles
{
    partial class ucMap
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mcMap = new GMap.NET.WindowsForms.GMapControl();
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
            this.mcMap.MaxZoom = 2;
            this.mcMap.MinZoom = 2;
            this.mcMap.MouseWheelZoomEnabled = true;
            this.mcMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mcMap.Name = "mcMap";
            this.mcMap.NegativeMode = false;
            this.mcMap.PolygonsEnabled = true;
            this.mcMap.RetryLoadTile = 0;
            this.mcMap.RoutesEnabled = true;
            this.mcMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mcMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mcMap.ShowTileGridLines = false;
            this.mcMap.Size = new System.Drawing.Size(655, 412);
            this.mcMap.TabIndex = 0;
            this.mcMap.Zoom = 0D;
            // 
            // ucMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mcMap);
            this.Name = "ucMap";
            this.Size = new System.Drawing.Size(655, 412);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mcMap;
    }
}
