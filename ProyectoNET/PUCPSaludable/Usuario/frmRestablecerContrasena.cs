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
    public partial class frmRestablecerContrasena : Form
    {
        AutenticacionWS.AutenticacionClient _dao = new AutenticacionWS.AutenticacionClient();
        public frmRestablecerContrasena()
        {
            InitializeComponent();
            btnEnviarConfirmacion.Enabled = false;
        }

        private void btnEnviarConfirmacion_Click(object sender, EventArgs e)
        {
            int uid = 0;
            if ((uid = _dao.verifyRegisteredUser(this.tbCodigo.Text)) > 0)
            {
                frmVerificacion rc2 = new frmVerificacion(this.tbCodigo.Text);
                rc2.ShowDialog();
                if (rc2.DialogResult == DialogResult.OK)
                {
                    frmRestablecerContrasenaPaso3 rc3 = new frmRestablecerContrasenaPaso3(uid);
                    rc3.ShowDialog();
                    if (rc3.DialogResult == DialogResult.OK)
                    {
                        frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Contraseña actualizada", "La contraseña se cambió correctamente. Ahora puedes iniciar sesión");
                        if (_frmmba.ShowDialog() == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
            else
            {
                frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Cuenta no encontrada", "Usted no tiene una cuenta registrada");
                _frmmba.ShowDialog();
            }
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Length == 8)
            {
                btnEnviarConfirmacion.Enabled = true;
            }
            else
            {
                btnEnviarConfirmacion.Enabled = false;
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
