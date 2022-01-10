using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Alumno.Nutricionista
{
    public partial class frmAgregarAlimento : Form
    {
        int id_alumno_hold;
        int _pref;
        AlimentoWS.AlimentoWebServiceClient _alimws = new AlimentoWS.AlimentoWebServiceClient();
        IngredienteWS.IngredienteServiceClient _ingwsadd = new IngredienteWS.IngredienteServiceClient();
        public frmAgregarAlimento(int id_al)
        {
            InitializeComponent();
            id_alumno_hold = id_al;
            _pref = 0;
            btnAgregar.Enabled = false;
            //cbSelAlimento.DataSource = _ingwsadd.listarIngredientesNoClasificados(id_alumno_hold);
            //cbSelAlimento.DisplayMember = "nombre";
            //cbSelAlimento.ValueMember = "idIngrediente";
            //IngredienteWS.ingrediente ab = new IngredienteWS.ingrediente();
            //ab.
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idIngHold = cbSelAlimento.SelectedValue.ToString();
            int idIngParsed = Int32.Parse(idIngHold);
            var a = _alimws.adquirirAlimento(id_alumno_hold, idIngParsed);
            if (a.fid_alumno == -1)//no existe, insertar
            {
                AlimentoWS.alimento alim = new AlimentoWS.alimento();
                alim.fid_alumno = id_alumno_hold;
                alim.fid_ingrediente = idIngParsed;
                alim.preferencia = _pref;
                _alimws.insertarAlimento(alim);
            }else //existe,modificar
            {
                AlimentoWS.alimento alim = new AlimentoWS.alimento();
                alim.fid_alumno = id_alumno_hold;
                alim.fid_ingrediente = idIngParsed;
                alim.preferencia = _pref;
                _alimws.modificarAlimento(alim);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscarIngre(string key)
        {
            cbSelAlimento.DataSource = _ingwsadd.listarIngredientesNombre(key);
            cbSelAlimento.DisplayMember = "nombre";
            cbSelAlimento.ValueMember = "idIngrediente";
            btnAgregar.Enabled = true;
        }

        private void txbIngredi_TextChanged(object sender, EventArgs e)
        {
            string key = Regex.Replace(txbIngredi.Text, "\\s+", "");
            if (key.Length >= 4)
            {
                btnBuscarIngre(key);
            }
        }

        private void cbSelAlimento_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void rbPredielcto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPredielcto.Checked)
            {
                _pref = 1;
            }
        }

        private void rbNoPredilecto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoPredilecto.Checked)
            {
                _pref = 0;
            }
        }

        private void rbAlergico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlergico.Checked)
            {
                _pref = 2;
            }
        }
    }
}
