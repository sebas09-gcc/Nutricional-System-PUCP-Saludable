using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Controles
{
    public partial class ucMap : UserControl
    {
        GMapOverlay markers = new GMapOverlay("markers");
        (double, double, string) _location;
        public ucMap()
        {
            InitializeComponent();
            mcMap.DragButton = MouseButtons.Left;
            mcMap.MouseWheelZoomEnabled = true;
            mcMap.CanDragMap = true;
            mcMap.MapProvider = GoogleMapProvider.Instance;
            mcMap.MinZoom = 16;
            mcMap.MaxZoom = 20;
            mcMap.Zoom = 18;
            mcMap.ShowCenter = true;
            addMarkers();
        }

        public (double, double, string) Ubicacion
        {
            get => _location;
            set
            {
                _location = value;
                if (_location != (0, 0, null))
                {
                    double latitude = _location.Item1;
                    double longitude = _location.Item2;
                    mcMap.Position = new GMap.NET.PointLatLng(latitude, longitude);
                    var resources = new ResourceManager(typeof(ucMap));
                    var redpoint = new Bitmap((System.Drawing.Image)resources.GetObject("pointred"));
                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(_location.Item1, _location.Item2), redpoint);
                    marker.ToolTipText = _location.Item3;
                    marker.ToolTip.Fill = Brushes.White;
                    marker.ToolTip.Font = new Font("Arial", 9, FontStyle.Regular);
                    marker.ToolTip.Foreground = Brushes.Black;
                    marker.ToolTip.Stroke = Pens.White;
                    marker.ToolTipMode = MarkerTooltipMode.Always;
                    markers.Markers.Add(marker);
                    mcMap.Overlays.Add(markers);
                }
            }
        }
        private void addMarkers()
        {
            var resources = new ResourceManager(typeof(ucMap));
            var mapadeportes = new Bitmap((System.Drawing.Image)resources.GetObject("mapadeportes"));
            var biblioteca = new Bitmap((System.Drawing.Image)resources.GetObject("biblioteca"));
            var bolsadetrabajo = new Bitmap((System.Drawing.Image)resources.GetObject("bolsadetrabajo"));
            var mapamuseo = new Bitmap((System.Drawing.Image)resources.GetObject("mapamuseo"));
            var capilla = new Bitmap((System.Drawing.Image)resources.GetObject("capilla"));
            var mapafotocopia = new Bitmap((System.Drawing.Image)resources.GetObject("mapafotocopia"));
            var aulariocomplejoinnovacion = new Bitmap((System.Drawing.Image)resources.GetObject("aulariocomplejoinnovacion"));
            var edificioserviciosadministrativos = new Bitmap((System.Drawing.Image)resources.GetObject("edificioserviciosadministrativos"));
            var tinkuy = new Bitmap((System.Drawing.Image)resources.GetObject("tinkuy"));
            var mapaautos = new Bitmap((System.Drawing.Image)resources.GetObject("mapaautos"));
            var mapabicicleta = new Bitmap((System.Drawing.Image)resources.GetObject("mapabicicleta"));
            var mapamotos = new Bitmap((System.Drawing.Image)resources.GetObject("mapamotos"));
            var gabinetesarqueologia = new Bitmap((System.Drawing.Image)resources.GetObject("gabinetesarqueologia"));
            var oficinaseguros = new Bitmap((System.Drawing.Image)resources.GetObject("oficinaseguros"));
            var mapaparadero = new Bitmap((System.Drawing.Image)resources.GetObject("mapaparadero"));
            var publicacionesdocencia = new Bitmap((System.Drawing.Image)resources.GetObject("publicacionesdocencia"));
            var salacuna = new Bitmap((System.Drawing.Image)resources.GetObject("salacuna"));
            var salalectura = new Bitmap((System.Drawing.Image)resources.GetObject("salalectura"));
            var serviciosalud = new Bitmap((System.Drawing.Image)resources.GetObject("serviciosalud"));
            var tramitesdocumentarios = new Bitmap((System.Drawing.Image)resources.GetObject("tramitesdocumentarios"));
            var mapatelefono = new Bitmap((System.Drawing.Image)resources.GetObject("mapatelefono"));
            Font arialFont = new Font("Arial", 9, FontStyle.Regular);
            GMapMarker marker5 = new GMarkerGoogle(new PointLatLng(-12.066068464913114, -77.07968681120519), mapadeportes); marker5.ToolTipText = "Area de deportes"; marker5.ToolTip.Fill = Brushes.White; marker5.ToolTip.Font = arialFont; marker5.ToolTip.Foreground = Brushes.Black; marker5.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker5);
            GMapMarker marker21 = new GMarkerGoogle(new PointLatLng(-12.069036767820752, -77.079997211722), biblioteca); marker21.ToolTipText = "Biblioteca Central"; marker21.ToolTip.Fill = Brushes.White; marker21.ToolTip.Font = arialFont; marker21.ToolTip.Foreground = Brushes.Black; marker21.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker21);
            GMapMarker marker63 = new GMarkerGoogle(new PointLatLng(-12.066931414254107, -77.07994966766819), mapadeportes); marker63.ToolTipText = "Coliseo Polideportivo"; marker63.ToolTip.Fill = Brushes.White; marker63.ToolTip.Font = arialFont; marker63.ToolTip.Foreground = Brushes.Black; marker63.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker63);
            GMapMarker marker70 = new GMarkerGoogle(new PointLatLng(-12.07274712827262, -77.07961924375468), aulariocomplejoinnovacion); marker70.ToolTipText = "Complejo de Innovación Académica  Aulario"; marker70.ToolTip.Fill = Brushes.White; marker70.ToolTip.Font = arialFont; marker70.ToolTip.Foreground = Brushes.Black; marker70.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker70);
            GMapMarker marker71 = new GMarkerGoogle(new PointLatLng(-12.072084586396635, -77.08030834796773), biblioteca); marker71.ToolTipText = "Complejo de Innovación Académica  Biblioteca"; marker71.ToolTip.Fill = Brushes.White; marker71.ToolTip.Font = arialFont; marker71.ToolTip.Foreground = Brushes.Black; marker71.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker71);
            GMapMarker marker114 = new GMarkerGoogle(new PointLatLng(-12.068130808964245, -77.07946904004984), tinkuy); marker114.ToolTipText = "Edificio de Servicios Estudiantiles  Tinkuy"; marker114.ToolTip.Fill = Brushes.White; marker114.ToolTip.Font = arialFont; marker114.ToolTip.Foreground = Brushes.Black; marker114.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker114);
            GMapMarker marker200 = new GMarkerGoogle(new PointLatLng(-12.065953054701154, -77.07947491668278), mapadeportes); marker200.ToolTipText = "Gimnasio"; marker200.ToolTip.Fill = Brushes.White; marker200.ToolTip.Font = arialFont; marker200.ToolTip.Foreground = Brushes.Black; marker200.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker200);
            GMapMarker marker228 = new GMarkerGoogle(new PointLatLng(-12.06580879258676, -77.08056925803248), mapadeportes); marker228.ToolTipText = "Losa de Paleta Frontón"; marker228.ToolTip.Fill = Brushes.White; marker228.ToolTip.Font = arialFont; marker228.ToolTip.Foreground = Brushes.Black; marker228.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker228);
            GMapMarker marker229 = new GMarkerGoogle(new PointLatLng(-12.072185118055117, -77.08193450225735), mapadeportes); marker229.ToolTipText = "Losa deportiva de minas"; marker229.ToolTip.Fill = Brushes.White; marker229.ToolTip.Font = arialFont; marker229.ToolTip.Foreground = Brushes.Black; marker229.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker229);
            GMapMarker marker230 = new GMarkerGoogle(new PointLatLng(-12.065958300606408, -77.07976995968465), mapadeportes); marker230.ToolTipText = "Losas deportivas"; marker230.ToolTip.Fill = Brushes.White; marker230.ToolTip.Font = arialFont; marker230.ToolTip.Foreground = Brushes.Black; marker230.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker230);
            GMapMarker marker260 = new GMarkerGoogle(new PointLatLng(-12.069937290264473, -77.07914500498418), oficinaseguros); marker260.ToolTipText = "Oficina de Seguros"; marker260.ToolTip.Fill = Brushes.White; marker260.ToolTip.Font = arialFont; marker260.ToolTip.Foreground = Brushes.Black; marker260.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker260);
            GMapMarker marker298 = new GMarkerGoogle(new PointLatLng(-12.06975630916928, -77.07943200132831), serviciosalud); marker298.ToolTipText = "Servicio de salud"; marker298.ToolTip.Fill = Brushes.White; marker298.ToolTip.Font = arialFont; marker298.ToolTip.Foreground = Brushes.Black; marker298.ToolTip.Stroke = Pens.White; markers.Markers.Add(marker298);
            mcMap.Overlays.Add(markers);
        }
    }
}
