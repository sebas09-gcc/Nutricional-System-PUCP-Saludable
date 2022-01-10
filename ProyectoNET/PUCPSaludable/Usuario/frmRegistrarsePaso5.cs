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
    public partial class frmRegistrarsePaso5 : Form
    {
        public frmRegistrarsePaso5()
        {
            InitializeComponent();
        }

        private void btnOmitir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnElegirFoto_Click(object sender, EventArgs e)
        {
            ofdElegirFoto.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofdElegirFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = new Bitmap(ofdElegirFoto.FileName);
            }
        }

        private void btnAgregarForo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
