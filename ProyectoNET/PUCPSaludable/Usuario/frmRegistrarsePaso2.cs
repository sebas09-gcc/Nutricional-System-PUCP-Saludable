using PUCPSaludable.AutenticacionWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Usuario
{
    public partial class frmRegistrarsePaso2 : Form
    {
        AutenticacionWS.usuario _usr = new AutenticacionWS.alumno();

        public usuario Usuario { get => _usr; set => _usr = value; }

        public async void studentBasics()
        {
            tbNombres.SelectionStart = 0;
            tbNombres.SelectionLength = 0;
            ProgressBar progressBar = new ProgressBar();
            Common.Progress.Show(this, progressBar);
            HttpClient httpClient = new HttpClient();
            string serverip = Common.Server.ServerIP;
            string url = "https://" + serverip + "/controller.php?action=studentBasics&code=" + this.tbCodigo.Text;
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string stdBas = await response.Content.ReadAsStringAsync();
            string[] stdBasArr = stdBas.Split(',');
            tbEmailPUCP.Text = stdBasArr[2];
            tbApellidos.Text = stdBasArr[0];
            tbNombres.Text = stdBasArr[1];
            tbNombres.SelectionStart = tbNombres.Text.Length;
            tbNombres.SelectionLength = 0;
            Common.Progress.Hide(this, progressBar);
        }

        public frmRegistrarsePaso2(string code)
        {
            InitializeComponent();
            if (code.Length == 8)
            {
                this.tbCodigo.Text = code;
                studentBasics();
            }
            btnContinuar.Enabled = false;
            rbHombre.Checked = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            _usr.codigoPUCP = tbCodigo.Text;
            _usr.contrasena = tbContrasena.Text;
            _usr.nombres = tbNombres.Text;
            _usr.apellidos = tbApellidos.Text;
            _usr.emailPUCP = tbEmailPUCP.Text;
            _usr.telefonoMovil = tbTelefonoMovil.Text;
            _usr.fechaNacimiento = Convert.ToDateTime(ucFechaNacimiento.Fecha);
            if (rbHombre.Checked)
            {
                _usr.sexo = 'M';
            }
            else if (rbMujer.Checked)
            {
                _usr.sexo = 'F';
            }
            else
            {
                _usr.sexo = 'O';
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbContrasena_TextChanged(object sender, EventArgs e)
        {
            if (tbContrasena.Text == tbConfirmarContraseña.Text && tbContrasena.Text.Length >= 8)
            {
                btnContinuar.Enabled = true;
            }
            else
            {
                btnContinuar.Enabled = false;
            }
        }
    }
}
