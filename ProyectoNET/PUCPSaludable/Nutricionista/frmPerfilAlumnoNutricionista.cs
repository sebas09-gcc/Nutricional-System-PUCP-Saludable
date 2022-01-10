using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Nutricionista
{
    public partial class frmPerfilAlumnoNutricionista : Form
    {
        int idAlum;
        private AutenticacionWS.AutenticacionClient _espe = new AutenticacionWS.AutenticacionClient();
        public frmPerfilAlumnoNutricionista()
        {
            InitializeComponent();
            cbEspecialidad.DataSource = new BindingList<AutenticacionWS.especialidad>(_espe.getSpecialties());
            cbEspecialidad.DisplayMember = "nombreEspecialidad";
            cbEspecialidad.ValueMember = "id_especialidad";
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            
            cbEspecialidad.Enabled = false;
            //tbCodigo.Enabled = false;
            //tbApellidos.Enabled = false;
            //tbNombres.Enabled = false;
            //tbEmailPUCP.Enabled = false;
            //tbEmailPersonal.Enabled = false;
            //pbFoto.Enabled = false;
            ucFechaNacimiento.Enabled = false;
            rbHombre.Enabled = false;
            rbMujer.Enabled = false;
            rbOtro.Enabled = false;
            //tbCreditos.Enabled = false;
            //tbApellidosNombres.Enabled = false; 
            //tbParentesco.Enabled = false; 
            //tbTelefono.Enabled = false;
        }

        public void establecerValores(AlumnoWS.alumno al)
        {
                idAlum = al.id_usuario;
                cbEspecialidad.SelectedValue = al.especialidad.id_especialidad;
                tbCodigo.Text = al.codigoPUCP;
                tbApellidos.Text = al.apellidos;
                tbNombres.Text = al.nombres;
                tbEmailPUCP.Text = al.emailPUCP;
                tbEmailPersonal.Text = al.emailPersonal;
                ucFechaNacimiento.Fecha = al.fechaNacimiento;
                tbCreditos.Text = al.creditosAprobados.ToString();
                tbApellidosNombres.Text = al.nombreContacto;
                tbTelefono.Text = al.numContacto;
                tbParentesco.Text = al.parentezcoContacto;
                try { tbEmailPersonal.Text = al.emailPersonal; } catch { }
                ushort sexo = al.sexo;
                if (sexo == 'M') rbHombre.Checked = true;
                else if (sexo == 'F') rbMujer.Checked = true;
                else rbOtro.Checked = true;
                try
                {
                    MemoryStream ms1 = new MemoryStream(al.fotoSrc);
                    pbFoto.Image = new Bitmap(ms1);
                }
                catch { }
        }

        private void btnAbrirIndicSalud_Click(object sender, EventArgs e)
        {
            if(idAlum!= -1)
            {
                frmIndicadoresNutriAl frminal = new frmIndicadoresNutriAl(idAlum);
                frminal.ShowDialog();
            }
            
        }

        private void btnAnhadirPlanAlimentario_Click(object sender, EventArgs e)
        {
            if (idAlum != -1)
            {
                frmPlanAlimentarioNutricionista frmPlanA = new frmPlanAlimentarioNutricionista(idAlum);
                frmPlanA.ShowDialog();
            }
        }
    }
}
