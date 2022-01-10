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
    public partial class frmRegistrarsePaso4Nutricionista : Form
    {
        AutenticacionWS.nutricionista _usr = new AutenticacionWS.nutricionista();
        public frmRegistrarsePaso4Nutricionista()
        {
            InitializeComponent();
        }

        public nutricionista Nutricionista { get => _usr; set => _usr = value; }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            frmMessageBoxSiNo _frmmba = new frmMessageBoxSiNo("Confirmar registro", "¿Confirmar registro como Nutricionista?");
            if (_frmmba.ShowDialog() == DialogResult.Yes)
            {
                _usr.colegiatura = tbColegiatura.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
