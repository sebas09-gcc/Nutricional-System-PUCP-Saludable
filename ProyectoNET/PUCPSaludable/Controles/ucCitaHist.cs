using PUCPSaludable.Nutricionista;
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

namespace PUCPSaludable.Alumno.Citas.Controles
{
    public partial class ucCitaHist : UserControl
    {
        private DateTime _fecha;
        private string _especialista;
        private ECheck _check;
        private EIcon _icon;
        private AlumnoWS.AlumnoServiceClient _dao = new AlumnoWS.AlumnoServiceClient();
        public ucCitaHist()
        {
            InitializeComponent();
        }

        public object Cita
        {
            set
            {
                btnDetalle.Tag = value;
            }
            get
            {
                return btnDetalle.Tag;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this._fecha;
            }
            set
            {
                this._fecha = value;
                labFecha.Text = this._fecha.ToLongDateString();
                labHora.Text = this._fecha.ToShortTimeString();
            }
        }
        public string Especialista
        {            
            set
            {
                _especialista = value;
                labEspecialista.Text = value;
            }
            get
            {
                return this._especialista;
                
            }
        }

        public ECheck Check
        {
            set {
                var resources = new ResourceManager(typeof(ucCitaHist));
                this._check = value;
                switch (this._check) {

                    case ECheck.Check:
                        this.ptbCheck.Image = (System.Drawing.Image)resources.GetObject("check");
                        break;
                    case ECheck.Uncheck:
                        this.ptbCheck.Image = (System.Drawing.Image)resources.GetObject("uncheck");
                        break;
                    default:
                        break;
                }
            }
            get {
                return this._check;
            }
        
        }

        public EIcon Icon
        {
            set
            {
                var resources = new ResourceManager(typeof(ucCitaHist));
                this._icon = value;
                switch (this._icon)
                {

                    case EIcon.Nutricion:
                        this.ptbIco.Image = (System.Drawing.Image)resources.GetObject("manzana_small_bn");
                        break;
                    case EIcon.Psicologia:
                        this.ptbIco.Image = (System.Drawing.Image)resources.GetObject("cabeza_small_bn");
                        break;
                    default:
                        break;
                }
            }
            get
            {
                return this._icon;
            }

        }




        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new AutoSizeMode AutoSizeMode { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoSize { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override AutoValidate AutoValidate { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new BorderStyle BorderStyle { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Point Location { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new object Tag { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool UseWaitCursor { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Size PreferredSize { get; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override RightToLeft RightToLeft { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Padding Padding { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Size MinimumSize { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Size MaximumSize { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Padding Margin { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ImeMode ImeMode { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool TabStop { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new static Color DefaultForeColor { get; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ContextMenu ContextMenu { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool CausesValidation { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ImageLayout BackgroundImageLayout { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image BackgroundImage { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool AllowDrop { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new AccessibleRole AccessibleRole { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string AccessibleName { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string AccessibleDescription { get; set; }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Button ucC = sender as Button;
            CitasWS.cita miCita = (CitasWS.cita)ucC.Tag;
            frmDetalleCitaHistorica frmDetalle = new frmDetalleCitaHistorica(miCita);
            frmDetalle.ShowDialog();            
        }
    }
}
