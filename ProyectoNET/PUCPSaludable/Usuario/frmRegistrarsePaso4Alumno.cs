using PUCPSaludable.AutenticacionWS;
using PUCPSaludable.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Usuario
{
    public partial class frmRegistrarsePaso4Alumno : Form
    {
        AutenticacionWS.alumno _usr = new AutenticacionWS.alumno();
        private AutenticacionWS.AutenticacionClient _psws = new AutenticacionWS.AutenticacionClient();
        public frmRegistrarsePaso4Alumno()
        {
            InitializeComponent();
            cbEspecialidad.DataSource = new BindingList<AutenticacionWS.especialidad>(_psws.getSpecialties());
            cbEspecialidad.DisplayMember = "nombreEspecialidad";
            cbEspecialidad.ValueMember = "id_especialidad";
        }

        public alumno Alumno { get => _usr; set => _usr = value; }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            frmMessageBoxSiNo _frmmba = new frmMessageBoxSiNo("Confirmar registro", "¿Confirmar registro como Alumno?");
            if (_frmmba.ShowDialog() == DialogResult.Yes)
            {
                _usr.numContacto = tbTelefono.Text;
                _usr.parentezcoContacto = tbParentesco.Text;
                _usr.nombreContacto = tbApellidosNombres.Text;
                _usr.especialidad = (AutenticacionWS.especialidad) cbEspecialidad.SelectedItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
