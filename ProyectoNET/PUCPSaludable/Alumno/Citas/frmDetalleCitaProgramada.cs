using PUCPSaludable.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Alumno.Citas
{
    public partial class frmDetalleCitaProgramada : Form
    {
        private AlumnoWS.AlumnoServiceClient _aws = new AlumnoWS.AlumnoServiceClient();
        private NutricionistaWS.NutricionistaServiceClient _nws = new NutricionistaWS.NutricionistaServiceClient();
        private CitasWS.CitasServiceClient _cws = new CitasWS.CitasServiceClient();
        private CitasWS.cita _cita;
        public frmDetalleCitaProgramada(CitasWS.cita miCita)
        {
            InitializeComponent();
            if (Common.Session.UserRole == "Alumno")
            {
                NutricionistaWS.nutricionista[] nut = _nws.listarNutricionistaID(miCita.fid_especialista);
                _cita = miCita;
                string[] ubicacion = nut[0].direccionLaboral.Split('#');
                if (ubicacion != null)
                {
                    if(ubicacion[1] != null)
                    {
                        NumberFormatInfo provider = new NumberFormatInfo();
                        provider.NumberDecimalSeparator = ".";
                        double latitude = Convert.ToDouble(ubicacion[1], provider);
                        double longitude = Convert.ToDouble(ubicacion[2], provider);
                        labFecha.Text = "Registrada en " + Convert.ToString(miCita.fechaHoraRegistro);
                        labDetalle.Text = "Especialista: " + nut[0].nombreCompleto + "\nFecha: " + miCita.fechaHoraAtencion.ToString("dd/MM/yyyy") + "\nHora: " + miCita.fechaHoraAtencion.ToString("hh:mm") + "\nLugar: " + ubicacion[0];
                        miUbicacion.Ubicacion = (latitude, longitude, ubicacion[0]);
                    }
                }
                else
                {
                    frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("", "Dirección erónea");
                    _frmmba.ShowDialog();
                }
            }
            else
            {
                NutricionistaWS.nutricionista[] nut = _nws.listarNutricionistaID(miCita.fid_especialista);
                AlumnoWS.alumno[] alu = _aws.listarAlumnoID(miCita.fid_alumno);
                _cita = miCita;
                string[] ubicacion = nut[0].direccionLaboral.Split('#');
                if (ubicacion != null)
                {
                    if (ubicacion[1] != null)
                    {
                        NumberFormatInfo provider = new NumberFormatInfo();
                        provider.NumberDecimalSeparator = ".";
                        double latitude = Convert.ToDouble(ubicacion[1], provider);
                        double longitude = Convert.ToDouble(ubicacion[2], provider);
                        labFecha.Text = "Registrada en " + Convert.ToString(miCita.fechaHoraRegistro);
                        labDetalle.Text = "Paciente: " + nut[0].nombreCompleto + "\nFecha: " + miCita.fechaHoraAtencion.ToString("dd/MM/yyyy") + "\nHora: " + miCita.fechaHoraAtencion.ToString("hh:mm") + "\nLugar: " + ubicacion[0];
                        miUbicacion.Ubicacion = (latitude, longitude, ubicacion[0]);
                    }
                }
                else
                {
                    frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("", "Dirección erónea");
                    _frmmba.ShowDialog();
                }
            }
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            frmMessageBoxSiNo _frmMB = new frmMessageBoxSiNo("¿Cancelar la cita?", "Si cancela la cita, perderá la reserva. Desea continuar");
            if (_frmMB.ShowDialog() == DialogResult.Yes)
            {
                _cws.eliminarCitaxId(_cita.id_cita);
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
