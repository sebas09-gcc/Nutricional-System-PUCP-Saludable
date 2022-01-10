using Microsoft.Win32;
using PUCPSaludable.Administrador;
using PUCPSaludable.Alumno;
using PUCPSaludable.Common;
using PUCPSaludable.Nutricionista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Usuario
{
    public partial class frmIniciarSesion : Form
    {
        private AutenticacionWS.AutenticacionClient _psws = new AutenticacionWS.AutenticacionClient();
        public frmIniciarSesion()
        {
            InitializeComponent();
            btnIniciarSesion.Enabled = false;
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrarse reg = new frmRegistrarse();
            reg.ShowDialog();
            if (reg.DialogResult == DialogResult.OK)
            {
            }
            else if (reg.DialogResult == DialogResult.Cancel)
            {
            }
        }

        private void btnRestablecerContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRestablecerContrasena rc = new frmRestablecerContrasena();
            rc.ShowDialog();
            if (rc.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
            else if (rc.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        public string claveRegistro(string path, string key)
        {
            try
            {
                RegistryKey regkey = Registry.LocalMachine.OpenSubKey(path);
                if (regkey == null)
                {
                    return "";
                }
                return (string) regkey.GetValue(key);
            }
            catch
            {
                return "";
            }
        }

        public string nombreOS()
        {
            string product = claveRegistro(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName");
            string version = claveRegistro(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CSDVersion");
            if (product != "")
            {
                return (product.StartsWith("Microsoft") ? "" : "Microsoft ") + product +
                            (version != "" ? " " + version : "");
            }
            return "";
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string description = nombreOS() + " " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
            string[] response = _psws.signIn(tbUsuario.Text, Common.Encrypt.Hash(tbContrasena.Text), description);
            int sessionID = Convert.ToInt32(response[0]);
            int userID = Convert.ToInt32(response[1]);
            string userRole = response[2];
            if (sessionID > 0)
            {
                this.Hide();
                // Establecer sesión
                if (swiRecordarme.Checked)
                {
                    Common.Session.Create(sessionID, userID, userRole);
                }
                else
                {
                    Common.Session.Create(0, userID, userRole);
                }
                // Mostrar pantalla de inicio
                switch (userRole)
                {
                    case "Administrador":
                        frmPrincipalAdministrador mainA = new frmPrincipalAdministrador();
                        mainA.ShowDialog();
                        break;
                    case "Alumno":
                        frmPrincipalAlumno mainS = new frmPrincipalAlumno();
                        mainS.ShowDialog();
                        break;
                    case "Nutricionista":
                        frmPrincipalNutricionista mainN = new frmPrincipalNutricionista();
                        mainN.ShowDialog();
                        break;
                    default:
                        frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Rol desconocido", "Contacta con el administrador del sistema");
                        _frmmba.ShowDialog();
                        break;
                }
                this.Close();
            }
            else if (sessionID == 0)
            {
                frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Error al iniciar sesión", "Usuario o contraseña incorrecta");
                _frmmba.ShowDialog();
            }
            else if (sessionID == -1)
            {
                frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Error al iniciar sesión", "Su cuenta se encuentra deshabilitada. Contacte con el administrador del sistema");
                _frmmba.ShowDialog();
            }
            else if (sessionID == -2)
            {
                frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Error al iniciar sesión", "Esta cuanta aún está pendiente de confirmación. Intenta más tarde nuevamente");
                _frmmba.ShowDialog();
            }
            else if (sessionID == -3)
            {
                frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Error al iniciar sesión", "La aprobación de esta cuenta fue rechazada. Contacte con el administrador");
                _frmmba.ShowDialog();
            }
            else
            {
                frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Error al iniciar sesión", "Ocurrió un error desconocido");
                _frmmba.ShowDialog();
            }
        }

        private void tbVerificar_TextChanged(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Length >= 8 && tbContrasena.Text.Length >= 8)
            {
                btnIniciarSesion.Enabled = true;
            }
            else
            {
                btnIniciarSesion.Enabled = false;
            }
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {
            _psws.verifySession(0);
        }
    }
}
