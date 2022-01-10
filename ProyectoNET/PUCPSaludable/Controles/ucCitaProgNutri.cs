using PUCPSaludable.Alumno.Citas.Controles;
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
    public partial class ucCitaProgNutri : UserControl
    {
        Button btnx = new Button();
        private DateTime _fecha;
        private string _lugar;
        private EProgramacion _programacion;
        private EIcon _icon;
        private AlumnoWS.AlumnoServiceClient _dao = new AlumnoWS.AlumnoServiceClient();
        private int _IDalm;
        private CitasWS.cita _citaResp;
        public ucCitaProgNutri()
        {
            InitializeComponent();

        }

        public CitasWS.cita CitaRespec
        {
            get
            {
                return this._citaResp;
            }
            set
            {
                this._citaResp = value;

            }
        }

        public int IDalm
        {
            get
            {
                return this._IDalm;
            }
            set
            {
                this._IDalm = value;

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


        public string Lugar
        {
            get => _lugar;
            set
            {
                _lugar = value;
                labLugar.Text = value;
            }
        }

        public EProgramacion Programacion
        {
            set
            {
                var resources = new ResourceManager(typeof(ucCitaProg));
                this._programacion = value;
                switch (this._programacion)
                {

                    case EProgramacion.Hoy:
                        this.ptbProg.Image = (System.Drawing.Image)resources.GetObject("hoy");
                        break;
                    case EProgramacion.Manana:
                        this.ptbProg.Image = (System.Drawing.Image)resources.GetObject("manana");
                        break;
                    case EProgramacion.Pronto:
                        this.ptbProg.Image = (System.Drawing.Image)resources.GetObject("Pronto");
                        break;
                    default:
                        break;
                }
            }
            get
            {
                return this._programacion;
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
        public void insertarBoton(MaterialSkin.Controls.MaterialButton btn, CitasWS.cita CITALM)
        {


            //btn.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            //btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            //btn.Depth = 0;
            btn.Dock = System.Windows.Forms.DockStyle.Fill;
            //btn.DrawShadows = false;
            //btn.HighEmphasis = true;
            //btn.Icon = null;
            //btn.Location = new System.Drawing.Point(35, 55);
            //btn.Margin = new System.Windows.Forms.Padding(0);
            //btn.MouseState = MaterialSkin.MouseState.HOVER;
            //btn.Name = "btnDetalle";
            btn.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            //btn.Size = new System.Drawing.Size(265, 20);
            //btn.TabIndex = 4;
            btn.Text = "ver detalle";
            //btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn.UseAccentColor = true;
            btn.UseVisualStyleBackColor = true;
            btn.Tag = CITALM;
            //this.tblCard.Controls.Add(this.btnDetalle, 1, 2);
            tblCard.Controls.Add(btn, 1, 2);

        }

    }
}
//this.tblCard.Controls.Add(this.btnDetalle, 1, 2);