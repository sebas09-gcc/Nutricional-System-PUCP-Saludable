using MaterialSkin;
using PUCPSaludable.Common;
using PUCPSaludable.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Administrador
{
    public partial class frmPrincipalAdministrador : Form
    {
        private BackgroundWorker bWBuscarPendientes;
        private BackgroundWorker bWBuscarAtendidos;
        private BackgroundWorker bWBuscarUsuarios;
        private AdministradorWS.AdministradorServiceClient _psws = new AdministradorWS.AdministradorServiceClient();
        private AutenticacionWS.AutenticacionClient _asws = new AutenticacionWS.AutenticacionClient();
        public frmPrincipalAdministrador()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey50, Primary.Green900, Primary.Green400, Accent.Amber400, TextShade.BLACK);
            InitializeComponent();
            inicializarBackgroundWorkers();
            dgvPendiente.AutoGenerateColumns = false;
            dgvAtendido.AutoGenerateColumns = false;
            dgvUsuario.AutoGenerateColumns = false;
        }
        private void inicializarBackgroundWorkers()
        {
            bWBuscarPendientes = new BackgroundWorker();
            bWBuscarPendientes.WorkerSupportsCancellation = true;
            bWBuscarPendientes.DoWork += new DoWorkEventHandler(buscarPendiente_DoWork);
            bWBuscarPendientes.RunWorkerCompleted += new RunWorkerCompletedEventHandler(buscarPendiente_RunWorkerCompleted);

            bWBuscarAtendidos = new BackgroundWorker();
            bWBuscarAtendidos.WorkerSupportsCancellation = true;
            bWBuscarAtendidos.DoWork += new DoWorkEventHandler(buscarAtendidos_DoWork);
            bWBuscarAtendidos.RunWorkerCompleted += new RunWorkerCompletedEventHandler(buscarAtendidos_RunWorkerCompleted);

            bWBuscarUsuarios = new BackgroundWorker();
            bWBuscarUsuarios.WorkerSupportsCancellation = true;
            bWBuscarUsuarios.DoWork += new DoWorkEventHandler(buscarUsuarios_DoWork);
            bWBuscarUsuarios.RunWorkerCompleted += new RunWorkerCompletedEventHandler(buscarUsuarios_RunWorkerCompleted);
        }

        private void frmPrincipalAdministrador_Load(object sender, EventArgs e)
        {
            bWBuscarPendientes.RunWorkerAsync();
            bWBuscarAtendidos.RunWorkerAsync();
            bWBuscarUsuarios.RunWorkerAsync();
        }

        private void cerrarSesiones(int uid)
        {
            AutenticacionWS.sesionActiva[] sesiones = _asws.sessionsList(uid);
            if (sesiones != null)
            {
                foreach (AutenticacionWS.sesionActiva sa in sesiones)
                {
                    _asws.signOut(sa.id);
                }
            }
        }

        private void btnRechazarPendiente_Click(object sender, EventArgs e)
        {
            if (dgvPendiente.SelectedRows.Count > 0)
            {
                AdministradorWS.usuario usr = (AdministradorWS.usuario)dgvPendiente.SelectedRows[0].DataBoundItem;
                _psws.changeUserStatus(usr.id_usuario, 3);
                if (bWBuscarPendientes.IsBusy)
                {
                    bWBuscarPendientes.CancelAsync();
                }
                else
                {
                    bWBuscarPendientes.RunWorkerAsync();
                }
                if (bWBuscarAtendidos.IsBusy)
                {
                    bWBuscarAtendidos.CancelAsync();
                }
                else
                {
                    bWBuscarAtendidos.RunWorkerAsync();
                }
                cerrarSesiones(usr.id_usuario);
            }
        }

        private void btnAutorizarPendiente_Click(object sender, EventArgs e)
        {
            if (dgvPendiente.SelectedRows.Count > 0)
            {
                AdministradorWS.usuario usr = (AdministradorWS.usuario)dgvPendiente.SelectedRows[0].DataBoundItem;
                frmMessageBoxSiNo _frmmbsn = new frmMessageBoxSiNo("Confirmar autorización", "¿Desea utorizar al usuario en el rol de nutricionista?");
                DialogResult mbAutorizar = _frmmbsn.ShowDialog();
                if (mbAutorizar == DialogResult.Yes)
                {
                    _psws.changeUserStatus(usr.id_usuario, 1);
                    if (bWBuscarPendientes.IsBusy)
                    {
                        bWBuscarPendientes.CancelAsync();
                    }
                    else
                    {
                        bWBuscarPendientes.RunWorkerAsync();
                    }
                    if (bWBuscarAtendidos.IsBusy)
                    {
                        bWBuscarAtendidos.CancelAsync();
                    }
                    else
                    {
                        bWBuscarAtendidos.RunWorkerAsync();
                    }
                    cerrarSesiones(usr.id_usuario);
                }
            }
        }

        private void btnConsultarPendiente_Click(object sender, EventArgs e)
        {
            AdministradorWS.usuario usr = (AdministradorWS.usuario)dgvPendiente.SelectedRows[0].DataBoundItem;
            frmConsultarUsuario conUsr = new frmConsultarUsuario(usr);
            conUsr.ShowDialog();
        }

        private void btnConsultarAtendido_Click(object sender, EventArgs e)
        {
            AdministradorWS.usuario usr = (AdministradorWS.usuario) dgvAtendido.SelectedRows[0].DataBoundItem;
            frmConsultarUsuario conUsr = new frmConsultarUsuario(usr);
            conUsr.ShowDialog();
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            AdministradorWS.usuario usr = (AdministradorWS.usuario)dgvUsuario.SelectedRows[0].DataBoundItem;
            frmConsultarUsuario conUsr = new frmConsultarUsuario(usr);
            conUsr.ShowDialog();
        }

        private void dgvPendiente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                AdministradorWS.usuario user = (AdministradorWS.usuario) dgvPendiente.Rows[e.RowIndex].DataBoundItem;
                if (user != null)
                {
                    dgvPendiente.Rows[e.RowIndex].Cells[0].Value = user.codigoPUCP;
                    dgvPendiente.Rows[e.RowIndex].Cells[1].Value = user.apellidos;
                    dgvPendiente.Rows[e.RowIndex].Cells[2].Value = user.nombres;
                    dgvPendiente.Rows[e.RowIndex].Cells[3].Value = "Nutricionista";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvAtendido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                AdministradorWS.usuario user = (AdministradorWS.usuario)dgvAtendido.Rows[e.RowIndex].DataBoundItem;
                if (user != null)
                {
                    dgvAtendido.Rows[e.RowIndex].Cells[0].Value = user.codigoPUCP;
                    dgvAtendido.Rows[e.RowIndex].Cells[1].Value = user.apellidos;
                    dgvAtendido.Rows[e.RowIndex].Cells[2].Value = user.nombres;
                    dgvAtendido.Rows[e.RowIndex].Cells[3].Value = "Nutricionista";
                    if (user.estado == 1)
                    {
                        dgvAtendido.Rows[e.RowIndex].Cells[4].Value = "Aceptada";
                    }
                    else
                    {
                        dgvAtendido.Rows[e.RowIndex].Cells[4].Value = "Rechazada";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                AdministradorWS.usuario user = (AdministradorWS.usuario)dgvUsuario.Rows[e.RowIndex].DataBoundItem;
                if (user != null)
                {
                    dgvUsuario.Rows[e.RowIndex].Cells[0].Value = user.codigoPUCP;
                    dgvUsuario.Rows[e.RowIndex].Cells[1].Value = user.apellidos;
                    dgvUsuario.Rows[e.RowIndex].Cells[2].Value = user.nombres;
                    if (user is AdministradorWS.alumno)
                    {
                        dgvUsuario.Rows[e.RowIndex].Cells[3].Value = "Alumno";
                    }
                    else if (user is AdministradorWS.nutricionista)
                    {
                        dgvUsuario.Rows[e.RowIndex].Cells[3].Value = "Nutricionista";
                    }
                    else
                    {
                        dgvUsuario.Rows[e.RowIndex].Cells[3].Value = "Desconocido";
                    }
                    if (user.estado == 0)
                    {
                        dgvUsuario.Rows[e.RowIndex].Cells[4].Value = "Inactivo";
                    }
                    else if (user.estado == 1 || user.estado == 3)
                    {
                        dgvUsuario.Rows[e.RowIndex].Cells[4].Value = "Activo";
                    }
                    else if (user.estado == 2)
                    {
                        dgvUsuario.Rows[e.RowIndex].Cells[4].Value = "Pendiente de confirmación";
                    }
                    else
                    {
                        dgvUsuario.Rows[e.RowIndex].Cells[4].Value = "Desconocido";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarPendiente_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWBuscarPendientes.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                string key = Regex.Replace(tbBuscarPendiente.Text, "\\s+", "");
                e.Result = new BindingList<AdministradorWS.usuario>(_psws.getUsersByStatus(key, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarPendiente_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvPendiente.DataSource = (BindingList<AdministradorWS.usuario>)e.Result;
        }

        private void tbBuscarPendiente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
            {
                if (bWBuscarPendientes.IsBusy)
                {
                    bWBuscarPendientes.CancelAsync();
                }
                else
                {
                    bWBuscarPendientes.RunWorkerAsync();
                }
            }
        }

        private void buscarAtendidos_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWBuscarAtendidos.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                string key = Regex.Replace(tbBuscarAtendido.Text, "\\s+", "");
                BindingList <AdministradorWS.usuario> blba = new BindingList<AdministradorWS.usuario>(_psws.getUsersByStatus(key, 100));
                BindingList<AdministradorWS.usuario> blba2 = new BindingList<AdministradorWS.usuario>();
                foreach (AdministradorWS.usuario us in blba)
                {
                    if (us is AdministradorWS.alumno)
                    {
                    }
                    else
                    {
                        blba2.Add(us);
                    }
                }
                e.Result = blba2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarAtendidos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvAtendido.DataSource = (BindingList<AdministradorWS.usuario>)e.Result;
        }

        private void tbBuscarAtendido_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
            {
                if (bWBuscarAtendidos.IsBusy)
                {
                    bWBuscarAtendidos.CancelAsync();
                }
                else
                {
                    bWBuscarAtendidos.RunWorkerAsync();
                }
            }
        }

        private void buscarUsuarios_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWBuscarUsuarios.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                string key = Regex.Replace(tbBuscarUsuario.Text, "\\s+", "");
                e.Result = new BindingList<AdministradorWS.usuario>(_psws.getUsersByStatus(key, -1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarUsuarios_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvUsuario.DataSource = (BindingList<AdministradorWS.usuario>) e.Result;
        }

        private void tbBuscarUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
            {
                if (bWBuscarUsuarios.IsBusy)
                {
                    bWBuscarUsuarios.CancelAsync();
                }
                else
                {
                    bWBuscarUsuarios.RunWorkerAsync();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AdministradorWS.usuario usr = (AdministradorWS.usuario)dgvUsuario.SelectedRows[0].DataBoundItem;
            frmMessageBoxSiNo _frmmbsn = new frmMessageBoxSiNo("Confirmar eliminación", "¿Desea eliminar al usuario " + usr.nombreCompleto + "?");
            if (_frmmbsn.ShowDialog() == DialogResult.Yes)
            {
                _psws.changeUserStatus(usr.id_usuario, 0);
            }
            if (bWBuscarUsuarios.IsBusy)
            {
                bWBuscarUsuarios.CancelAsync();
            }
            else
            {
                bWBuscarUsuarios.RunWorkerAsync();
            }
        }

        private void cbSwitch_MouseUp(object sender, MouseEventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0 && cbSwitch.Enabled == true)
            {
                AdministradorWS.usuario usr = (AdministradorWS.usuario)dgvUsuario.SelectedRows[0].DataBoundItem;
                if (usr.estado == 0)
                {
                    _psws.changeUserStatus(usr.id_usuario, 1);
                }
                else
                {
                    _psws.changeUserStatus(usr.id_usuario, 0);
                }
                if (bWBuscarUsuarios.IsBusy)
                {
                    bWBuscarUsuarios.CancelAsync();
                }
                else
                {
                    bWBuscarUsuarios.RunWorkerAsync();
                }
            }
        }

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                AdministradorWS.usuario usr = (AdministradorWS.usuario)dgvUsuario.SelectedRows[0].DataBoundItem;
                cbSwitch.Enabled = true;
                if (usr.estado == 0)
                {
                    cbSwitch.Checked = false;
                }
                else if (usr.estado == 2 || usr.estado == 3)
                {
                    cbSwitch.Checked = false;
                    cbSwitch.Enabled = false;
                }
                else
                {
                    cbSwitch.Checked = true;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar sesión
            var settings = Properties.Settings.Default;
            _asws.signOut(Convert.ToInt32(settings.sessionID));
            settings.sessionID = 0;
            settings.userID = 0;
            settings.Save();

            this.Hide();
            // Eliminar la sesión en base de datos
            frmIniciarSesion fis = new frmIniciarSesion();
            fis.ShowDialog();
            this.Close();
        }
    }
}
