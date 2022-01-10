using PUCPSaludable.PlanAlimentarioWS;
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
    public partial class frmEditarRecetaPlanAlimentario : Form
    {
        private PlanAlimentarioWS.PlanAlimentarioServiceClient _presetDAO;
        private int _tipoCom;
        private PlanAlimentarioWS.presetReceta _presetSel;

        public presetReceta PresetSel { get => _presetSel; set => _presetSel = value; }

        public frmEditarRecetaPlanAlimentario(int tipoComida)
        {
            _tipoCom = tipoComida;
            InitializeComponent();
            tituloComida();
            _presetDAO = new PlanAlimentarioWS.PlanAlimentarioServiceClient();
            dgvPresets.AutoGenerateColumns = false;
            //PlanAlimentarioWS.presetReceta[] lista = _presetDAO.presetsPorTipo(tipoComida);
            dgvPresets.DataSource = _presetDAO.presetsPorTipoC(tipoComida);
        }

        private void tituloComida()
        {
            if (_tipoCom == 0) labTipoCom.Text = "Desayuno";
            if (_tipoCom == 1) labTipoCom.Text = "Media Mañana";
            if (_tipoCom == 2) labTipoCom.Text = "Almuerzo";
            if (_tipoCom == 3) labTipoCom.Text = "Merienda";
            if (_tipoCom == 4) labTipoCom.Text = "Cena";
        }
        private void dgvPresets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //AlumnoWS.alumno alumno = (AlumnoWS.alumno)dgvAlumnos.Rows[e.RowIndex].DataBoundItem;
            PlanAlimentarioWS.presetReceta preset = (PlanAlimentarioWS.presetReceta)dgvPresets.Rows[e.RowIndex].DataBoundItem;
            dgvPresets.Rows[e.RowIndex].Cells[0].Value = preset.nombre;
            dgvPresets.Rows[e.RowIndex].Cells[1].Value = preset.kcal;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPresets.SelectedRows.Count > 0)
            {
                _presetSel = (PlanAlimentarioWS.presetReceta)dgvPresets.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
