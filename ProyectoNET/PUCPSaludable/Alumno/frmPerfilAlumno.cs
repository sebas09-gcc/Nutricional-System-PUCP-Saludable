using MaterialSkin;
using PUCPSaludable.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Alumno
{
    public partial class frmPerfilAlumno : Form
    {
        private Estado _estado;
        private BackgroundWorker bWObtenerDatosPersonales;
        private BackgroundWorker bWObtenerSesiones;
        private AutenticacionWS.AutenticacionClient _psws =  new AutenticacionWS.AutenticacionClient();
        private AlumnoWS.AlumnoServiceClient _alumnoDAO = new AlumnoWS.AlumnoServiceClient();
        private AlumnoWS.alumno[] _alumno;
        private AutenticacionWS.AutenticacionClient _espe = new AutenticacionWS.AutenticacionClient();
        public frmPerfilAlumno()
        {
            inicializarBackgroundWorkers();
            InitializeComponent();
            cbEspecialidad.DisplayMember = "nombreEspecialidad";
            cbEspecialidad.ValueMember = "id_especialidad";
            if (bWObtenerDatosPersonales.IsBusy)
            {
                bWObtenerDatosPersonales.CancelAsync();
            }
            else
            {
                bWObtenerDatosPersonales.RunWorkerAsync(Common.Session.UserID);
            }
            if (bWObtenerSesiones.IsBusy)
            {
                bWObtenerSesiones.CancelAsync();
            }
            else
            {
                bWObtenerSesiones.RunWorkerAsync(argument: Common.Session.UserID);
            }
        }

        private void inicializarBackgroundWorkers()
        {
            // Obtener datos personales
            bWObtenerDatosPersonales = new BackgroundWorker();
            bWObtenerDatosPersonales.WorkerSupportsCancellation = true;
            bWObtenerDatosPersonales.DoWork += new DoWorkEventHandler(obtenerDatosPersonales_DoWork);
            bWObtenerDatosPersonales.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerDatosPersonales_RunWorkerCompleted);

            // Obtener sesiones
            bWObtenerSesiones = new BackgroundWorker();
            bWObtenerSesiones.WorkerSupportsCancellation = true;
            bWObtenerSesiones.DoWork += new DoWorkEventHandler(obtenerSesiones_DoWork);
            bWObtenerSesiones.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerSesiones_RunWorkerCompleted);
        }

        private void obtenerDatosPersonales_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWObtenerDatosPersonales.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                int id = (int) e.Argument;
                e.Result = (_alumnoDAO.listarAlumnoID(id), _espe.getSpecialties());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void obtenerDatosPersonales_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AutenticacionWS.especialidad[] _especialidades;
            (_alumno, _especialidades) = ((AlumnoWS.alumno[], AutenticacionWS.especialidad[])) e.Result;
            if (_alumno != null)
            {
                _estado = Estado.Inicial;
                tbCodigo.Text = _alumno[0].codigoPUCP;
                tbApellidos.Text = _alumno[0].apellidos;
                tbNombres.Text = _alumno[0].nombres;
                tbEmailPUCP.Text = _alumno[0].emailPUCP;
                tbEmailPersonal.Text = _alumno[0].emailPersonal;
                ucFechaNacimiento.Fecha = _alumno[0].fechaNacimiento;
                tbCreditos.Text = _alumno[0].creditosAprobados.ToString();
                tbApellidosNombres.Text = _alumno[0].nombreContacto;
                tbTelefono.Text = _alumno[0].numContacto;
                tbParentesco.Text = _alumno[0].parentezcoContacto;
                try { tbEmailPersonal.Text = _alumno[0].emailPersonal; } catch { }
                ushort sexo = _alumno[0].sexo;
                if (sexo == 'M') rbHombre.Checked = true;
                else if (sexo == 'F') rbMujer.Checked = true;
                else rbOtro.Checked = true;
                try
                {
                    MemoryStream ms1 = new MemoryStream(_alumno[0].fotoSrc);
                    pbFoto.Image = new Bitmap(ms1);
                }
                catch { }
                establecerEstadoComponentes();
            }
            if (_especialidades != null)
            {
                cbEspecialidad.DataSource = new BindingList<AutenticacionWS.especialidad>(_especialidades);
                cbEspecialidad.SelectedValue = _alumno[0].especialidad.id_especialidad;
            }
        }

        private void obtenerEspecialidades_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void obtenerSesiones_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWObtenerDatosPersonales.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                int id = (int) e.Argument;
                e.Result = _psws.sessionsList(id); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void obtenerSesiones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AutenticacionWS.sesionActiva[] sesiones = (AutenticacionWS.sesionActiva[]) e.Result;
            if (sesiones != null)
            {
                foreach (AutenticacionWS.sesionActiva sa in sesiones)
                {
                    ucSesion us = new ucSesion();
                    us.Dock = DockStyle.Top;
                    us.Descripcion = sa.descripcion;
                    us.FechaHoraInicio = sa.fechaInicio.ToString();
                    panSesiones.Controls.Add(us);
                }
            }
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    cbEspecialidad.Enabled = false;
                    btEditar.Enabled = true;
                    btGuardar.Enabled = false;
                    btCancelar.Enabled = false;
                    btnCambiarFoto.Enabled = false;
                    tbCodigo.Enabled = false;
                    tbCodigo.ReadOnly = true;
                    tbApellidos.Enabled = false;
                    tbApellidos.ReadOnly = true;
                    tbNombres.Enabled = false;
                    tbNombres.ReadOnly = false;
                    tbEmailPUCP.Enabled = false;
                    tbEmailPUCP.ReadOnly = true;
                    tbEmailPersonal.Enabled = false;
                    tbEmailPersonal.ReadOnly = true;
                    pbFoto.Enabled = false;
                    ucFechaNacimiento.Enabled = false;
                    rbHombre.Enabled = false;
                    rbMujer.Enabled = false;
                    rbOtro.Enabled = false;
                    tbCreditos.Enabled = false;
                    tbCreditos.ReadOnly = true;
                    tbApellidosNombres.Enabled = false;
                    tbApellidosNombres.ReadOnly = true;
                    tbParentesco.Enabled = false;
                    tbParentesco.ReadOnly = true;
                    tbTelefono.Enabled = false;
                    tbTelefono.ReadOnly = true;
                    break;
                case Estado.Editar:
                    cbEspecialidad.Enabled = true;
                    btEditar.Enabled = false;
                    btGuardar.Enabled = true;
                    btCancelar.Enabled = true;
                    btnCambiarFoto.Enabled = true;
                    tbApellidos.Enabled = true;
                    tbApellidos.ReadOnly = false;
                    tbNombres.Enabled = true;
                    tbNombres.ReadOnly = false;
                    tbEmailPUCP.Enabled = true;
                    tbEmailPUCP.ReadOnly = false;
                    tbEmailPersonal.Enabled = true;
                    tbEmailPersonal.ReadOnly = false;
                    pbFoto.Enabled = true;
                    ucFechaNacimiento.Enabled = true;
                    rbHombre.Enabled = true;
                    rbMujer.Enabled = true;
                    rbOtro.Enabled = true;
                    tbCreditos.Enabled = true;
                    tbCreditos.ReadOnly = false;
                    tbApellidosNombres.Enabled = true;
                    tbApellidosNombres.ReadOnly = false;
                    tbParentesco.Enabled = true;
                    tbParentesco.ReadOnly = false;
                    tbTelefono.Enabled = true;
                    tbTelefono.ReadOnly = false;
                    break;
                    
            }
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            ofdElegirFoto.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (ofdElegirFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = new Bitmap(ofdElegirFoto.FileName);
            }
        }

        private void btnCerrarSesionesActivas_Click(object sender, EventArgs e)
        {
            if (Common.Session.UserID > 0)
            {
                panSesiones.Controls.Clear();
                AutenticacionWS.sesionActiva[] sesiones = _psws.sessionsList(Common.Session.UserID);
                foreach (AutenticacionWS.sesionActiva sa in sesiones)
                {
                    if (Common.Session.SessionID != sa.id)
                    {
                        _psws.signOut(sa.id);
                    }
                    else
                    {
                        ucSesion us = new ucSesion();
                        us.Dock = DockStyle.Top;
                        us.Descripcion = sa.descripcion;
                        us.FechaHoraInicio = sa.fechaInicio.ToString();
                        panSesiones.Controls.Add(us);
                    }
                }
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (bWObtenerDatosPersonales.IsBusy)
            {
                bWObtenerDatosPersonales.CancelAsync();
            }
            else
            {
                bWObtenerDatosPersonales.RunWorkerAsync(Common.Session.UserID);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            AlumnoWS.alumno al = new AlumnoWS.alumno();
            al.id_usuario = Common.Session.UserID;
            al.codigoPUCP = tbCodigo.Text;
            al.contrasena = _alumno[0].contrasena;
            al.nombres = tbNombres.Text;
            al.apellidos = tbApellidos.Text;
            al.emailPUCP = tbEmailPUCP.Text;
            al.emailPersonal = tbEmailPersonal.Text;
            al.telefonoMovil = "";
            al.fechaNacimiento = ucFechaNacimiento.Fecha;
            al.fechaNacimientoSpecified = true;

            if (rbHombre.Checked == true) al.sexo = 'M';
            else if (rbMujer.Checked == true) al.sexo = 'F';
            else al.sexo = 'O';

            al.estado = 1;
            try
            {
                al.fotoSrc = ImageToByteArray(pbFoto.Image);
            }
            catch
            {}
            al.especialidad = new AlumnoWS.especialidad();
            al.especialidad.id_especialidad = ((AutenticacionWS.especialidad)cbEspecialidad.SelectedItem).id_especialidad;
            al.creditosAprobados = Convert.ToDouble(tbCreditos.Text);

            al.nombreContacto = tbApellidosNombres.Text;
            al.parentezcoContacto = tbParentesco.Text;
            al.matriculado = 1;
            al.numContacto = tbTelefono.Text;
            _alumnoDAO.modificarAlumnoID(al);
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
