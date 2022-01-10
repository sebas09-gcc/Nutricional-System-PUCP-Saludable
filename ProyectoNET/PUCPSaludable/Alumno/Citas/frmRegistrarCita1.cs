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
    public partial class frmRegistrarCita1 : Form
    {
        public frmRegistrarCita1(CitasWS.cita miCita, CitasWS.especialistaSalud esp)
        {
            InitializeComponent();
            string[] ubicacion = esp.direccionLaboral.Split('#');
            labDetalle.Text = "Especialidad: Nutrición\nEspecialista: " + esp.nombreCompleto + "\nFecha: " + miCita.fechaHoraAtencion.ToString("dd/MM/yyyy") + "\nHora: " + miCita.fechaHoraAtencion.ToString("hh:mm") + "\nLugar: " + ubicacion[0];
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel ;
        }

        private void btnAceptarReserva_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
