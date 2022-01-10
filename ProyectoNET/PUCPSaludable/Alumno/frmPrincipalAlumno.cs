using MaterialSkin;
using MaterialSkin.Controls;
using PUCPSaludable.Usuario;
//using PUCPSaludable.Alumno.Citas;
using PUCPSaludable.Alumno.Nutricionista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUCPSaludable.Alumno.Citas;

namespace PUCPSaludable.Alumno
{
    public partial class frmPrincipalAlumno : Form
    {
        private AutenticacionWS.AutenticacionClient _psws;
        frmDashboardAlumno _frmDashboard;
        frmIndicadoresDeSalud _frmIndicadoresSalud;
        frmPlanAlimentario _frmPlanAlimenticio;        
        frmPerfilAlumno _frmPerfil;
        frmCitasAlumno _frmCitas;

        public frmPrincipalAlumno()
        {
            InitializeComponent();
        }
        private void frmPrincipalAlumno_Load(object sender, EventArgs e)
        {
            _psws = new AutenticacionWS.AutenticacionClient();
            _frmDashboard = new frmDashboardAlumno();
            inicializarPestanas();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey100, Primary.Pink100, Primary.Pink900, Accent.Pink400, TextShade.WHITE);
            // Mostrar dashboard
            _frmDashboard.Show();
            reiniciarBotones();
            btnDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            // Si es la primera vez
            var settings = Properties.Settings.Default;
//            settings.firstTime = true;
            settings.Save();
            if (settings.firstTime)
            {
                frmBienvenido _frmb = new frmBienvenido();
                _frmb.Show();
                settings.firstTime = false;
                settings.Save();
            }
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
            btnSalud.Type = MaterialButton.MaterialButtonType.Text;
            btnCitas.Type = MaterialButton.MaterialButtonType.Text;
            btnPlanAlimentario.Type = MaterialButton.MaterialButtonType.Text;
            btnPerfil.Type = MaterialButton.MaterialButtonType.Text;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pbPrincipal.Visible = true;
            reiniciarPestanas();
            _frmDashboard.resetCumplimientoPlanAlimentario();
            _frmDashboard.Show();
            reiniciarBotones();
            btnDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pbPrincipal.Visible = false;
        }
        private void btnSalud_Click(object sender, EventArgs e)
        {
            pbPrincipal.Visible = true;
            if (_frmIndicadoresSalud == null)
            {
                _frmIndicadoresSalud = new frmIndicadoresDeSalud();
                // Indicadores Salud
                _frmIndicadoresSalud.TopLevel = false;
                _frmIndicadoresSalud.Dock = DockStyle.Fill;
                panPrincipal.Controls.Add(_frmIndicadoresSalud);
            }
            reiniciarPestanas();
            _frmIndicadoresSalud.Show();
            reiniciarBotones();
            btnSalud.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pbPrincipal.Visible = false;
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            pbPrincipal.Visible = true;
            if (_frmCitas == null)
            {
                _frmCitas = new frmCitasAlumno();
                //Citas Alumno
                _frmCitas.TopLevel = false;
                _frmCitas.Dock = DockStyle.Fill;
                panPrincipal.Controls.Add(_frmCitas);
            }
            reiniciarPestanas();
            _frmCitas.Show();
            reiniciarBotones();
            btnCitas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pbPrincipal.Visible = false;
        }

        private void btnPlanAlimentario_Click(object sender, EventArgs e)
        {
            pbPrincipal.Visible = true;
            if (_frmPlanAlimenticio == null)
            {
                _frmPlanAlimenticio = new frmPlanAlimentario();
                //Plan Alimenticio
                _frmPlanAlimenticio.TopLevel = false;
                _frmPlanAlimenticio.Dock = DockStyle.Fill;
                panPrincipal.Controls.Add(_frmPlanAlimenticio);
            }
            reiniciarPestanas();
            _frmPlanAlimenticio.Show();
            reiniciarBotones();
            btnPlanAlimentario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pbPrincipal.Visible = false;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            pbPrincipal.Visible = true;
            if (_frmPerfil == null)
            {
                _frmPerfil = new frmPerfilAlumno();
                // Perfil
                _frmPerfil.TopLevel = false;
                _frmPerfil.Dock = DockStyle.Fill;
                panPrincipal.Controls.Add(_frmPerfil);
            }
            reiniciarPestanas();
            _frmPerfil.Show();
            reiniciarBotones();
            btnPerfil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pbPrincipal.Visible = false;
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
    }
}
