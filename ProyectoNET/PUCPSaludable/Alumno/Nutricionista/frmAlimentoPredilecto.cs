using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Alumno.Nutricionista
{
    public partial class frmAlimentoPredilecto : Form
    {
        public frmAlimentoPredilecto()
        {
            InitializeComponent();
        }
        public frmAlimentoPredilecto(string datos)
        {
            InitializeComponent();
            labAlimento.Text = datos;
        }
    }
}
