using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Controles
{
    public partial class ucAlimentoListado : UserControl
    {
        private string _nombreIng;
        private AlimentoWS.alimento _alim;
        private AlimentoWS.AlimentoWebServiceClient _daoALIM = new AlimentoWS.AlimentoWebServiceClient();
        public ucAlimentoListado()
        {
            InitializeComponent();
        }

        public string NomIng
        {
            set
            {
                this._nombreIng = value;
                this.labAlimento.Text = this._nombreIng;
            }
            get
            {
                return _nombreIng;
            }
        }

        public void insertarBoton(MaterialSkin.Controls.MaterialButton btn, int idIng,int idAlum,int pref)
        {
            _alim = new AlimentoWS.alimento();
            _alim.fid_alumno = idAlum;
            _alim.fid_ingrediente = idIng;
            _alim.preferencia = pref;
            btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn.Dock = System.Windows.Forms.DockStyle.Fill;
            btn.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            btn.Text = "Borrar";
            btn.UseAccentColor = true;
            btn.UseVisualStyleBackColor = true;
            btn.Tag = _alim;
            tlpAlimentoCalif.Controls.Add(btn, 1, 0);

        }

    }
}
