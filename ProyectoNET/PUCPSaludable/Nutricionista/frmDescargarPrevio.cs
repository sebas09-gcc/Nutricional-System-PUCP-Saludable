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
    public partial class frmDescargarPrevio : Form
    {
        public frmDescargarPrevio()
        {
            InitializeComponent();
        }

        private void materialTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            frmDescargarHistorialClinico disponibilidad = new frmDescargarHistorialClinico();
            if (disponibilidad.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
