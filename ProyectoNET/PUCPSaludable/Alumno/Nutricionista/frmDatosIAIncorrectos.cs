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
    public partial class frmDatosIAIncorrectos : Form
    {
        private string _listaErrores;

        public string Errores
        {
            get
            {
                return this._listaErrores;
            }
            set
            {
                this._listaErrores = value;
                mltbErrores.Text = _listaErrores;
            }
        }

        public frmDatosIAIncorrectos()
        {
            InitializeComponent();
        }
    }
}
