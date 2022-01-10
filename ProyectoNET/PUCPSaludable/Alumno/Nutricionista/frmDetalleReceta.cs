using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUCPSaludable.Common;
namespace PUCPSaludable.Alumno.Nutricionista
{
    public partial class frmDetalleReceta : Form
    {
        private const int EM_GETLINECOUNT = 0xba;
        [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);
        PlanAlimentarioWS.PlanAlimentarioServiceClient _daoPlan;
        public frmDetalleReceta(int idPreset)
        {
            InitializeComponent();
            _daoPlan = new PlanAlimentarioWS.PlanAlimentarioServiceClient();
            PlanAlimentarioWS.receta receta = new PlanAlimentarioWS.receta();
            receta = _daoPlan.recetaPorPresetID(idPreset);
            labRecipeName.Text = receta.nombre;
            BindingList<PlanAlimentarioWS.ingrediente> ingredientes = new BindingList<PlanAlimentarioWS.ingrediente>(_daoPlan.ingredientesPreset(idPreset).ToList());
            // Nombre de la receta
            wvImagen.URL = "http://ws.pucpsaludable.ml/obtener_imagen.php?query=" + receta.nombre;
            this.Text = "Detalle de receta - " + receta.nombre;
            // Desactivar scroll horizontal
            Common.Common.CorrectPanelScrollBar(PanelContenedorPrincipal);
            // Ingredientes
            foreach (PlanAlimentarioWS.ingrediente ing in ingredientes)
            {
                ListBoxIngredients.Items.Add("• " + ing.detalle);
            }

            // Lista de ingredientes
            int ingredientsNumber = ingredientes.Count;
            ListBoxIngredients.Size = new Size(560, ListBoxIngredients.ItemHeight * ingredientsNumber);

            // Etiqueta de instrucciones
            LabelInstructions.Location = new Point(12, ListBoxIngredients.Location.Y + ListBoxIngredients.Size.Height + 10);
            // Lista de instrucciones
            TextBoxInstructions.Enabled = false;
            TextBoxInstructions.BackColor = System.Drawing.Color.White;
            TextBoxInstructions.Text = receta.indicaciones.Replace("\n", "\r\n"); ;
            TextBoxInstructions.Location = new Point(12, LabelInstructions.Location.Y + LabelInstructions.Size.Height);
            // Etique inferior auxiliar
            LabelBottom.Location = new Point(12, TextBoxInstructions.Location.Y + TextBoxInstructions.Size.Height);

            // Ajustar tamaño del formulario tras determinar si está presente la barra de scroll vertical
            Common.Common.ResizeIfScrollBar(this, PanelContenedorPrincipal);
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            // Envía documento a impresión
        }

        private void TextBoxInstructions_TextChanged(object sender, EventArgs e)
        {
            var n = SendMessage(TextBoxInstructions.Handle.ToInt32(), EM_GETLINECOUNT, 0, 0);
            TextBoxInstructions.Height = (TextBoxInstructions.Font.Height + 2) * n;
        }
    }
}
