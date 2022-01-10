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
    public partial class frmPlanAlimentarioDetalleEdit : Form
    {
        PlanAlimentarioWS.PlanAlimentarioServiceClient _daoPlan;
        public frmPlanAlimentarioDetalleEdit()
        {
            InitializeComponent();
        }
        public frmPlanAlimentarioDetalleEdit(int idPreset)
        {
            InitializeComponent();
            _daoPlan = new PlanAlimentarioWS.PlanAlimentarioServiceClient();
            PlanAlimentarioWS.receta receta = new PlanAlimentarioWS.receta();
            receta = _daoPlan.recetaPorPresetID(idPreset);
            labNombreReceta.Text = receta.nombre;
            BindingList<PlanAlimentarioWS.ingrediente> ingredientes = new BindingList<PlanAlimentarioWS.ingrediente>(_daoPlan.ingredientesPreset(idPreset).ToList());
            //bucle de recetas
            string listaIngred ="";
            foreach(PlanAlimentarioWS.ingrediente ing in ingredientes)
            {
                listaIngred = listaIngred + " " + ing.detalle + "\n";
            }
            labIngredientes.Text= listaIngred;
            labPreparacion.Text = receta.indicaciones;

        }
    }
}
