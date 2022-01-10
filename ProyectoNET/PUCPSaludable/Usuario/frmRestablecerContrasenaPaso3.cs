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
    public partial class frmRestablecerContrasenaPaso3 : Form
    {
        AutenticacionWS.AutenticacionClient _dao = new AutenticacionWS.AutenticacionClient();
        private int _userid;
        public frmRestablecerContrasenaPaso3(int userid)
        {
            InitializeComponent();
            _userid = userid;
            btnConfirmar.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (tbNuevaContrasena.Text == tbConfirmarContrasena.Text)
            {
                _dao.changePassword(_userid, Common.Encrypt.Hash(tbNuevaContrasena.Text));
                this.DialogResult = DialogResult.OK;
            }
        }

        private void tbConfirmarContrasena_TextChanged(object sender, EventArgs e)
        {
            if (tbNuevaContrasena.Text == tbConfirmarContrasena.Text && tbNuevaContrasena.Text.Length >= 8)
            {
                btnConfirmar.Enabled = true;
            }
            else
            {
                btnConfirmar.Enabled = false;
            }
        }
    }
}
