using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Common
{
    public partial class frmMessageBoxSiNo : Form
    {
        public frmMessageBoxSiNo(string titulo, string mensaje)
        {
            InitializeComponent();
            labTitulo.Text = titulo;
            tbDescripcion.Text = mensaje;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
