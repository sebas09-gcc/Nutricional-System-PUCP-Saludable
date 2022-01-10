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
    public partial class frmRegistrarsePaso3 : Form
    {
        private string _tipoEspecialista;
        public string TipoEspecialista
        {
            get
            {
                return this._tipoEspecialista;
            }
        }
        public frmRegistrarsePaso3()
        {
            InitializeComponent();
        }

        private void btnNutricionista_Click(object sender, EventArgs e)
        {
            this._tipoEspecialista = "Nutricionista";
            this.DialogResult = DialogResult.OK;
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            this._tipoEspecialista = "Alumno";
            this.DialogResult = DialogResult.OK;
        }
    }
}
