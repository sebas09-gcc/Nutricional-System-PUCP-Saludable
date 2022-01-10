using PUCPSaludable.Alumno.Nutricionista;
using PUCPSaludable.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Alumno
{
    public partial class frmPlanAlimentario : Form
    {
        private int IDALM;
        TableLayoutPanel tlpCarga = new TableLayoutPanel();
        private BackgroundWorker bWObtenerPlan;
        private PlanAlimentarioWS.PlanAlimentarioServiceClient _daoPlan = new PlanAlimentarioWS.PlanAlimentarioServiceClient();
        private AlumnoWS.AlumnoServiceClient _daoAlumno = new AlumnoWS.AlumnoServiceClient();
        public frmPlanAlimentario()
        {
            inicializarBackgroundWorkers();
            IDALM = Common.Session.UserID;
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

        private void inicializarBackgroundWorkers()
        {
            bWObtenerPlan = new BackgroundWorker();
            bWObtenerPlan.WorkerSupportsCancellation = true;
            bWObtenerPlan.DoWork += new DoWorkEventHandler(obtenerPlan_DoWork);
            bWObtenerPlan.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerPlan_RunWorkerCompleted);
        }

        private void obtenerPlan_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWObtenerPlan.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                e.Result = _daoPlan.planAlimentarioAlumnoPreset(IDALM);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void obtenerPlan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PlanAlimentarioWS.presetReceta [] presets = (PlanAlimentarioWS.presetReceta[]) e.Result;
            if (presets != null)
            {
                foreach (PlanAlimentarioWS.presetReceta p in presets)
                {
                    ucPlanAlimCardEdit card = new ucPlanAlimCardEdit();
                    card.Dock = DockStyle.Top;
                    card.Preset = p;
                    card.Editable = false;
                    tlpCalendario.Controls.Add(card, p.estado + 1, p.tipo + 1);
                }
            }
            else
            {
                btnGenerarPDF.Enabled = false;
                btnLista.Enabled = false;
                panCalendario.Controls.Clear();
                TableLayoutPanel tlpNoData = new TableLayoutPanel();
                Common.NoData.Show(panCalendario, tlpNoData, "No tienes un plan alimentario", "Luego de tu cita con el nutricionista, al abrir la app, encontrarás aquí tus comidas del día");
            }
            Common.LoadingAnimation.Hide(this, tlpCarga);
            tlp_base.Visible = true;
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

        public static void DBuff(System.Windows.Forms.Control control)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                return;
            }
            System.Reflection.PropertyInfo propInf = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propInf.SetValue(control, true, null);
        }

        private void tlpCalendario_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var tlp = sender as TableLayoutPanel;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            var cell = e.CellBounds;
            using (var pen = new Pen(Color.FromArgb(245, 0, 87), 1))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                if (e.Row == (tlp.RowCount - 1))
                {
                    cell.Height -= 1;
                }

                if (e.Column == (tlp.ColumnCount - 1))
                {
                    cell.Width -= 1;
                }
                e.Graphics.DrawRectangle(pen, cell);
            }
        }

        private void frmPlanAlimentario_Load(object sender, EventArgs e)
        {
            Common.LoadingAnimation.Show(this, tlpCarga);
            tlp_base.Visible = false;
            bWObtenerPlan.RunWorkerAsync();
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            byte[] reportePlanAlim = _daoAlumno.generarPlanAlimenticio(Common.Session.UserID);
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF Files|*.pdf";
            if (saveDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = saveDialog.FileName;
            File.WriteAllBytes(fileName, reportePlanAlim);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            byte[] reportePlanAlim = _daoPlan.generarIngredientesCompra(Common.Session.UserID);
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF Files|*.pdf";
            if (saveDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = saveDialog.FileName;
            File.WriteAllBytes(fileName, reportePlanAlim);
        }
    }
}
