using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Alumno
{
    public partial class frmHorasSueDashboard : Form
    {
        private HorasSuenhoWS.HorasSuenhoServicesClient _hsws = new HorasSuenhoWS.HorasSuenhoServicesClient();
        private HorasSuenhoWS.horasSuenho[] horasSunLista = null;
        public frmHorasSueDashboard()
        {
            InitializeComponent();
            horasSunLista = _hsws.listarHorasSuenPorAlum(Common.Session.UserID);
        }

        private void btnSumarHorasSue_Click(object sender, EventArgs e)
        {
            double horasHold;
            panel2.Enabled = false;

            HorasSuenhoWS.horasSuenho hsHold = new HorasSuenhoWS.horasSuenho();
            hsHold.fid_alumno = Common.Session.UserID;
            hsHold.fecha = DateTime.Now.Date;
            hsHold.fechaSpecified = true;
            bool isParsable = Double.TryParse(tbHorasSueno.Text, out horasHold);
            if (isParsable && horasHold < 24 && horasHold>=0)
            {
                hsHold.horas = horasHold;
                if (horasSunLista != null)
                {
                    if (hsHold.fecha == horasSunLista[0].fecha)
                    {
                        hsHold.id_horasSueno = horasSunLista[0].id_horasSueno;
                        int m = _hsws.modificarHorasSuenho(hsHold);
                        if(m != 0)
                        {
                            MessageBox.Show("Dato ingresado con exito");
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        int b = _hsws.insertarHorasSuenho(hsHold);
                        if (b != 0)
                        {
                            MessageBox.Show("Dato ingresado con exito");
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                {
                    int a = _hsws.insertarHorasSuenho(hsHold);
                    if (a != 0)
                    {
                        MessageBox.Show("Dato ingresado con exito");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero decimal correcto");
            }
            panel2.Enabled = true;
        }
    }
}
