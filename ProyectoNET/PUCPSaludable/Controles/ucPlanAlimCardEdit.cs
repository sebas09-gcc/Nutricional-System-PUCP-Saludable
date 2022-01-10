using PUCPSaludable.Alumno.Nutricionista;
using PUCPSaludable.Nutricionista;
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

namespace PUCPSaludable.Controles
{
    public partial class ucPlanAlimCardEdit : UserControl
    {
        private PlanAlimentarioWS.presetReceta _preset;
        private bool _editable;
        public presetReceta Preset
        {
            get => _preset;
            set
            {
                labNombreReceta.Text = value.nombre;
                labKcal.Text = value.kcal + " kcal";
                _preset = value;
            }
        }

        public ucPlanAlimCardEdit()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is TableLayoutPanel || c is Panel)
                {
                    DBuff(c);
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.ExStyle |= 0x02000000;
                return p;
            }
        }
        public bool Editable
        {
            get => _editable;
            set
            {
                _editable = value;
                btnEditar.Visible = value;
            }
        }

        public static void DBuff(System.Windows.Forms.Control control)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                return;
            }
            System.Reflection.PropertyInfo propInf = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propInf.SetValue(control, true, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarRecetaPlanAlimentario _frmerpa = new frmEditarRecetaPlanAlimentario(_preset.tipo);
            if (_frmerpa.ShowDialog() == DialogResult.OK)
            {
                int d = _preset.estado;
                int tC = _preset.tipo;
                Preset = _frmerpa.PresetSel;
                _preset.estado = d;
                _preset.tipo = tC;
            }
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.Image = global::PUCPSaludable.Properties.Resources.edit;
        }

        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            btnEditar.Image = global::PUCPSaludable.Properties.Resources.edit_hover;
        }

        private void btnMostrar_MouseHover(object sender, EventArgs e)
        {
            btnMostrar.Image = global::PUCPSaludable.Properties.Resources.arrow_right_up_hover;
        }

        private void btnMostrar_MouseLeave(object sender, EventArgs e)
        {
            btnMostrar.Image = global::PUCPSaludable.Properties.Resources.arrow_right_up;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmDetalleReceta _frmerpa = new frmDetalleReceta(this.Preset.idPresetReceta);
            if (_frmerpa.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
