using MaterialSkin;
using MaterialSkin.Controls;
using PUCPSaludable.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Nutricionista
{
    public partial class frmPrincipalNutricionista : Form
    {
        private AutenticacionWS.AutenticacionClient _psws;
        frmDashboardNutricionista _frmDashboard;
        //frmPerfilAlumno _frmPerfil;
        frmCitasNutricionista _frmCitas;
        frmPerfilNutricionista _frmPerfil;
        frmBuscarAlumnos _frmBuscarAlumnos;
        frmDisponibilidad2 _frmDisp;

        public frmPrincipalNutricionista()
        {
            InitializeComponent();
            _psws = new AutenticacionWS.AutenticacionClient();
            _frmDashboard = new frmDashboardNutricionista();
            inicializarPestanas();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey100, Primary.Blue100, Primary.Blue900, Accent.Blue400, TextShade.WHITE);
            // Mostrar dashboard
            _frmDashboard.Show();
            reiniciarBotones();
            btnDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDashboard.UseAccentColor = true;
        }

        public void inicializarPestanas()
        {
            // Dashboard
            _frmDashboard.TopLevel = false;
            _frmDashboard.Dock = DockStyle.Fill;
            panPrincipal.Controls.Add(_frmDashboard);
        }

        public void reiniciarPestanas()
        {
            int nctrls = panPrincipal.Controls.Count;
            foreach (Control c in panPrincipal.Controls)
            {
                if (c is Form)
                {
                    c.Hide();
                }
            }
        }

        public void reiniciarBotones()
        {
            btnDashboard.Type = MaterialButton.MaterialButtonType.Text;
            btnDashboard.UseAccentColor = false;
            btnCitas.Type = MaterialButton.MaterialButtonType.Text;
            btnCitas.UseAccentColor = false;
            btnDisponibilidad.Type = MaterialButton.MaterialButtonType.Text;
            btnDisponibilidad.UseAccentColor = false;
            btnAlumnos.Type = MaterialButton.MaterialButtonType.Text;
            btnAlumnos.UseAccentColor = false;
            btnPerfil.Type = MaterialButton.MaterialButtonType.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reiniciarPestanas();
            _frmDashboard.Show();
            reiniciarBotones();
            btnDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDashboard.UseAccentColor = true;
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (_frmCitas == null)
            {
                _frmCitas = new frmCitasNutricionista();
                //Citas Nutricionista
                _frmCitas.TopLevel = false;
                _frmCitas.Dock = DockStyle.Fill;
                panPrincipal.Controls.Add(_frmCitas);
            }
            reiniciarPestanas();
            _frmCitas.Show();
            reiniciarBotones();
            btnCitas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCitas.UseAccentColor = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar sesión
            var settings = Properties.Settings.Default;
            _psws.signOut(Convert.ToInt32(settings.sessionID));
            settings.sessionID = 0;
            settings.userID = 0;
            settings.Save();

            this.Hide();
            // Eliminar la sesión en base de datos
            frmIniciarSesion fis = new frmIniciarSesion();
            fis.ShowDialog();
            this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if(_frmPerfil == null)
            {
                _frmPerfil = new frmPerfilNutricionista();
                // Perfil
                _frmPerfil.TopLevel = false;
                _frmPerfil.Dock = DockStyle.Fill;
                panPrincipal.Controls.Add(_frmPerfil);
            }
            reiniciarPestanas();
            _frmPerfil.Show();
            reiniciarBotones();
            btnPerfil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPerfil.UseAccentColor = true;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            if (_frmBuscarAlumnos == null)
            {
                _frmBuscarAlumnos = new frmBuscarAlumnos();
                //Alumnos
                _frmBuscarAlumnos.TopLevel = false;
                _frmBuscarAlumnos.Dock = DockStyle.Fill;
                panPrincipal.Controls.Add(_frmBuscarAlumnos);

            }
            reiniciarPestanas();
            _frmBuscarAlumnos.Show();
            reiniciarBotones();
            btnAlumnos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAlumnos.UseAccentColor = true;
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            if (_frmDisp == null)
            {
                _frmDisp = new frmDisponibilidad2();
                //Disponibilidad
                _frmDisp.TopLevel = false;
                _frmDisp.Dock = DockStyle.Fill;
                panPrincipal.Controls.Add(_frmDisp);
            }
            reiniciarPestanas();
            _frmDisp.Show();
            reiniciarBotones();
            btnDisponibilidad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDisponibilidad.UseAccentColor = true;
        }
    }
}
