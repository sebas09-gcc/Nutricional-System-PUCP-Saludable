using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using PUCPSaludable.Alumno;
using PUCPSaludable.Nutricionista;
using PUCPSaludable.Administrador;
using PUCPSaludable.Common;
using PUCPSaludable.Usuario;
using PUCPSaludable.Alumno.Nutricionista;
using PUCPSaludable.Alumno.Citas;

namespace PUCPSaludable
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutenticacionWS.AutenticacionClient _psws = new AutenticacionWS.AutenticacionClient();
            var settings = Properties.Settings.Default;
            // Verificar si fue establecida una sesión
            if (settings.sessionID > 0)
            {
                // Verificar si la sesión es válida
                string[] response = _psws.verifySession(Convert.ToInt32(settings.sessionID));
                int userID = Convert.ToInt32(response[0]);
                string userRole = response[1];
                if (userID > 0 && userID == settings.userID)
                {
                    Common.Session.SessionID = settings.sessionID;
                    Common.Session.UserID = settings.userID;
                    Common.Session.UserRole = userRole;
                    // Mostrar pantalla de inicio
                    switch (userRole)
                    {
                        case "Administrador":
                            Application.Run(new frmPrincipalAdministrador());
                            break;
                        case "Alumno":
                            Application.Run(new frmPrincipalAlumno());
                            break;
                        case "Nutricionista":
                            Application.Run(new frmPrincipalNutricionista());
                            break;
                        default:
                            frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Rol desconocido", "Contacta con el administrador del sistema");
                            _frmmba.ShowDialog();
                            break;
                    }
                    Common.Session.Create(settings.sessionID, settings.userID, userRole);
                }
                else
                {
                    // Iniciar sesión
                    Application.Run(new frmIniciarSesion());
                }
            }
            else
            {
                // Iniciar sesión
                Application.Run(new frmIniciarSesion());
            }
        }
    }
}
