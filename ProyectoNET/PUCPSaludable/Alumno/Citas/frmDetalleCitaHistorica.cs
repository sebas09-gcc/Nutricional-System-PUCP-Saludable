using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Alumno.Citas
{
    public partial class frmDetalleCitaHistorica : Form
    {
        private NutricionistaWS.NutricionistaServiceClient _nws = new NutricionistaWS.NutricionistaServiceClient();
        private AlumnoWS.AlumnoServiceClient _aws = new AlumnoWS.AlumnoServiceClient();
        public frmDetalleCitaHistorica(CitasWS.cita miCita)
        {
            InitializeComponent();
            if (Common.Session.UserRole == "Alumno")
            {
                NutricionistaWS.nutricionista[] nut = _nws.listarNutricionistaID(miCita.fid_especialista);
                labFecha.Text = "Registrada en " + Convert.ToString(miCita.fechaHoraRegistro);
                string estadoAtencion = "Desconocido";
                switch (miCita.estado)
                {
                    case 0:
                        estadoAtencion = "Aún no atendida";
                        break;
                    case 1:
                        estadoAtencion = "Atendida";
                        break;
                    case 2:
                        estadoAtencion = "Cancelada";
                        break;
                    case 3:
                        estadoAtencion = "Faltó";
                        break;
                }
                labDetalle.Text = "Especialidad: Nutrición\nEspecialista: " + nut[0].nombreCompleto + "\nFecha: " + miCita.fechaHoraAtencion.ToString("dd/MM/yyyy") + "\nHora: " + miCita.fechaHoraAtencion.ToString("hh:mm") + "\nEstado de atención: " + estadoAtencion + "\nDiagnóstico: " + miCita.diagnostico;
            }
            else
            {
                AlumnoWS.alumno[] nut = _aws.listarAlumnoID(miCita.fid_alumno);
                labFecha.Text = "Registrada en " + Convert.ToString(miCita.fechaHoraRegistro);
                string estadoAtencion = "Desconocido";
                switch (miCita.estado)
                {
                    case 0:
                        estadoAtencion = "Aún no atendida";
                        break;
                    case 1:
                        estadoAtencion = "Atendida";
                        break;
                    case 2:
                        estadoAtencion = "Cancelada";
                        break;
                    case 3:
                        estadoAtencion = "Faltó";
                        break;
                }
                labDetalle.Text = "Especialidad: Nutrición\nPaciente: " + nut[0].nombreCompleto + "\nFecha: " + miCita.fechaHoraAtencion.ToString("dd/MM/yyyy") + "\nHora: " + miCita.fechaHoraAtencion.ToString("hh:mm") + "\nEstado de atención: " + estadoAtencion + "\nDiagnóstico: " + miCita.diagnostico;
            }
        }
    }
}
