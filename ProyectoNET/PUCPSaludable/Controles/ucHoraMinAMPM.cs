using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Controles
{
    public partial class ucHoraMinAMPM : UserControl
    {
        DateTime _hora;
        public ucHoraMinAMPM()
        {
            InitializeComponent();
             
        }

        public int Hora { get => Convert.ToInt32(cbHora.Text); }
        public int Minutos{ get => Convert.ToInt32(cbMinutos.Text); }

        public String Zona { get => cbAMPM.Text; }

        public DateTime HoraCompleta
        {
            get
            {
                this._hora = DateTime.Parse(cbHora.Text + " " + cbAMPM.Text);
                this._hora=this._hora.AddMinutes(Minutos);
                return this._hora;
                //_hora.pm
            }
            set
            {
                this._hora = value;
                int hourHold, minHold;
                hourHold = _hora.Hour;
                minHold = _hora.Minute;
                if (_hora.Hour == 12)
                {
                    cbHora.SelectedIndex = 11;
                    cbAMPM.SelectedIndex = 1;
                }
                else if (_hora.Hour == 0)
                {
                    cbHora.SelectedIndex = 11;
                    cbAMPM.SelectedIndex = 0;
                }
                else if (_hora.Hour > 12)
                {
                    cbAMPM.SelectedIndex = 1;
                    cbHora.SelectedIndex = hourHold - 13;
                }
                else
                {
                    cbAMPM.SelectedIndex = 0;
                    cbHora.SelectedIndex = hourHold - 1;
                }
                cbMinutos.SelectedIndex = minHold / 15;
            }
        }
    }
}
