using PUCPSaludable.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Nutricionista
{
    public partial class frmPlanAlimentarioNutricionista : Form
    {
        private int IDALM;
        TableLayoutPanel tlpCarga = new TableLayoutPanel();
        private PlanAlimentarioWS.PlanAlimentarioServiceClient _daoPlan = new PlanAlimentarioWS.PlanAlimentarioServiceClient();
        private BackgroundWorker bWObtenerPlan;
        public frmPlanAlimentarioNutricionista(int id)
        {
            IDALM = id;
            this.DoubleBuffered = true;
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is TableLayoutPanel || c is Panel)
                {
                    DBuff(c);
                }
            }
            inicializarBackgroundWorkers();
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
                bool ar = (bool) e.Argument;
                if(ar == false)
                {
                    e.Result = _daoPlan.planAlimentarioAlumnoPreset(IDALM);
                }
                else
                {
                    e.Result = _daoPlan.generarNuevoPlanAlumno(IDALM);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void obtenerPlan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PlanAlimentarioWS.presetReceta[] preslist = (PlanAlimentarioWS.presetReceta[])e.Result;
            if (preslist != null)
            {
                tlpCalendario.Controls.Clear();
                foreach (PlanAlimentarioWS.presetReceta pa in preslist)
                {
                    ucPlanAlimCardEdit card = new ucPlanAlimCardEdit();
                    card.Dock = DockStyle.Top;
                    card.Preset = pa;
                    card.Editable = true;
                    tlpCalendario.Controls.Add(card, pa.estado + 1, pa.tipo + 1);
                }
                agregarCabeceras();
            }
            else
            {

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
            using (var pen = new Pen(Color.FromArgb(41, 121, 255), 1))
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            tlpCarga = new TableLayoutPanel();
            Common.LoadingAnimation.Show(this, tlpCarga);
            tlp_base.Visible = false;
            if (bWObtenerPlan.IsBusy)
            {
                bWObtenerPlan.CancelAsync();
            }
            else
            {
                bWObtenerPlan.RunWorkerAsync(argument: true);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            BindingList<PlanAlimentarioWS.planAlimentario> planesl = new BindingList<PlanAlimentarioWS.planAlimentario>();
            foreach (Control c in tlpCalendario.Controls)
            {
                if (c is ucPlanAlimCardEdit)
                {
                    PlanAlimentarioWS.planAlimentario plan = new PlanAlimentarioWS.planAlimentario();
                    PlanAlimentarioWS.alumno alum = new PlanAlimentarioWS.alumno();
                    alum.id_usuario = IDALM;
                    plan.alumno = alum;
                    plan.alumno.fechaNacimientoSpecified = true;
                    plan.fechaSpecified = true;
                    plan.comida = ((ucPlanAlimCardEdit)c).Preset;
                    plan.fid_Nutricionista = Common.Session.UserID;
                    plan.dia = ((ucPlanAlimCardEdit)c).Preset.estado;
                    planesl.Add(plan);
                }
            }
            tlpCarga = new TableLayoutPanel();
            Common.LoadingAnimation.Show(this, tlpCarga);
            tlp_base.Visible = false;
            _daoPlan.insertarNuevoPlan(planesl.ToArray<PlanAlimentarioWS.planAlimentario>());
            if (bWObtenerPlan.IsBusy)
            {
                bWObtenerPlan.CancelAsync();
            }
            else
            {
                bWObtenerPlan.RunWorkerAsync(argument: false);
            }
        }

        private void frmPlanAlimentarioNutricionista_Load(object sender, EventArgs e)
        {
            Common.LoadingAnimation.Show(this, tlpCarga);
            tlp_base.Visible = false;
            bWObtenerPlan.RunWorkerAsync(argument: false);
        }

        void agregarCabeceras()
        {
            Panel panHeaderMiercoles = new System.Windows.Forms.Panel();
            Label labHeaderMiercoles = new System.Windows.Forms.Label();
            Panel panHeaderSabado = new System.Windows.Forms.Panel();
            Label labHeaderSabado = new System.Windows.Forms.Label();
            Panel panHeaderViernes = new System.Windows.Forms.Panel();
            Label labHeaderViernes = new System.Windows.Forms.Label();
            Panel panHeaderJueves = new System.Windows.Forms.Panel();
            Label labHeaderJueves = new System.Windows.Forms.Label();
            Panel panHeaderMartes = new System.Windows.Forms.Panel();
            Label labHeaderMartes = new System.Windows.Forms.Label();
            Panel panHeaderLunes = new System.Windows.Forms.Panel();
            Label labHeaderLunes = new System.Windows.Forms.Label();
            Panel panHeaderDomingo = new System.Windows.Forms.Panel();
            Label labHeaderDomingo = new System.Windows.Forms.Label();
            Panel panComida = new System.Windows.Forms.Panel();
            Label labHeaderComida = new System.Windows.Forms.Label();
            MaterialSkin.Controls.MaterialLabel labDesayuno = new MaterialSkin.Controls.MaterialLabel();
            MaterialSkin.Controls.MaterialLabel labMediMan = new MaterialSkin.Controls.MaterialLabel();
            MaterialSkin.Controls.MaterialLabel labAlmuerzo = new MaterialSkin.Controls.MaterialLabel();
            MaterialSkin.Controls.MaterialLabel labMerienda = new MaterialSkin.Controls.MaterialLabel();
            MaterialSkin.Controls.MaterialLabel labCena = new MaterialSkin.Controls.MaterialLabel();
            // 
            // panHeaderMiercoles
            // 
            panHeaderMiercoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            panHeaderMiercoles.Controls.Add(labHeaderMiercoles);
            panHeaderMiercoles.Dock = System.Windows.Forms.DockStyle.Fill;
            panHeaderMiercoles.Location = new System.Drawing.Point(380, 0);
            panHeaderMiercoles.Margin = new System.Windows.Forms.Padding(0);
            panHeaderMiercoles.Name = "panHeaderMiercoles";
            panHeaderMiercoles.Size = new System.Drawing.Size(95, 30);
            panHeaderMiercoles.TabIndex = 3;
            // 
            // labHeaderMiercoles
            // 
            labHeaderMiercoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            labHeaderMiercoles.Dock = System.Windows.Forms.DockStyle.Fill;
            labHeaderMiercoles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labHeaderMiercoles.ForeColor = System.Drawing.Color.White;
            labHeaderMiercoles.Location = new System.Drawing.Point(0, 0);
            labHeaderMiercoles.Name = "labHeaderMiercoles";
            labHeaderMiercoles.Size = new System.Drawing.Size(95, 30);
            labHeaderMiercoles.TabIndex = 1;
            labHeaderMiercoles.Text = "Miércoles";
            labHeaderMiercoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderSabado
            // 
            panHeaderSabado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            panHeaderSabado.Controls.Add(labHeaderSabado);
            panHeaderSabado.Dock = System.Windows.Forms.DockStyle.Fill;
            panHeaderSabado.Location = new System.Drawing.Point(665, 0);
            panHeaderSabado.Margin = new System.Windows.Forms.Padding(0);
            panHeaderSabado.Name = "panHeaderSabado";
            panHeaderSabado.Size = new System.Drawing.Size(99, 30);
            panHeaderSabado.TabIndex = 6;
            // 
            // labHeaderSabado
            // 
            labHeaderSabado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            labHeaderSabado.Dock = System.Windows.Forms.DockStyle.Fill;
            labHeaderSabado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labHeaderSabado.ForeColor = System.Drawing.Color.White;
            labHeaderSabado.Location = new System.Drawing.Point(0, 0);
            labHeaderSabado.Name = "labHeaderSabado";
            labHeaderSabado.Size = new System.Drawing.Size(99, 30);
            labHeaderSabado.TabIndex = 1;
            labHeaderSabado.Text = "Sábado";
            labHeaderSabado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderViernes
            // 
            panHeaderViernes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            panHeaderViernes.Controls.Add(labHeaderViernes);
            panHeaderViernes.Dock = System.Windows.Forms.DockStyle.Fill;
            panHeaderViernes.Location = new System.Drawing.Point(570, 0);
            panHeaderViernes.Margin = new System.Windows.Forms.Padding(0);
            panHeaderViernes.Name = "panHeaderViernes";
            panHeaderViernes.Size = new System.Drawing.Size(95, 30);
            panHeaderViernes.TabIndex = 5;
            // 
            // labHeaderViernes
            // 
            labHeaderViernes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            labHeaderViernes.Dock = System.Windows.Forms.DockStyle.Fill;
            labHeaderViernes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labHeaderViernes.ForeColor = System.Drawing.Color.White;
            labHeaderViernes.Location = new System.Drawing.Point(0, 0);
            labHeaderViernes.Name = "labHeaderViernes";
            labHeaderViernes.Size = new System.Drawing.Size(95, 30);
            labHeaderViernes.TabIndex = 1;
            labHeaderViernes.Text = "Viernes";
            labHeaderViernes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderJueves
            // 
            panHeaderJueves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            panHeaderJueves.Controls.Add(labHeaderJueves);
            panHeaderJueves.Dock = System.Windows.Forms.DockStyle.Fill;
            panHeaderJueves.Location = new System.Drawing.Point(475, 0);
            panHeaderJueves.Margin = new System.Windows.Forms.Padding(0);
            panHeaderJueves.Name = "panHeaderJueves";
            panHeaderJueves.Size = new System.Drawing.Size(95, 30);
            panHeaderJueves.TabIndex = 4;
            // 
            // labHeaderJueves
            // 
            labHeaderJueves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            labHeaderJueves.Dock = System.Windows.Forms.DockStyle.Fill;
            labHeaderJueves.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labHeaderJueves.ForeColor = System.Drawing.Color.White;
            labHeaderJueves.Location = new System.Drawing.Point(0, 0);
            labHeaderJueves.Name = "labHeaderJueves";
            labHeaderJueves.Size = new System.Drawing.Size(95, 30);
            labHeaderJueves.TabIndex = 1;
            labHeaderJueves.Text = "Jueves";
            labHeaderJueves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderMartes
            // 
            panHeaderMartes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            panHeaderMartes.Controls.Add(labHeaderMartes);
            panHeaderMartes.Dock = System.Windows.Forms.DockStyle.Fill;
            panHeaderMartes.Location = new System.Drawing.Point(285, 0);
            panHeaderMartes.Margin = new System.Windows.Forms.Padding(0);
            panHeaderMartes.Name = "panHeaderMartes";
            panHeaderMartes.Size = new System.Drawing.Size(95, 30);
            panHeaderMartes.TabIndex = 2;
            // 
            // labHeaderMartes
            // 
            labHeaderMartes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            labHeaderMartes.Dock = System.Windows.Forms.DockStyle.Fill;
            labHeaderMartes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labHeaderMartes.ForeColor = System.Drawing.Color.White;
            labHeaderMartes.Location = new System.Drawing.Point(0, 0);
            labHeaderMartes.Name = "labHeaderMartes";
            labHeaderMartes.Size = new System.Drawing.Size(95, 30);
            labHeaderMartes.TabIndex = 1;
            labHeaderMartes.Text = "Martes";
            labHeaderMartes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderLunes
            // 
            panHeaderLunes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            panHeaderLunes.Controls.Add(labHeaderLunes);
            panHeaderLunes.Dock = System.Windows.Forms.DockStyle.Fill;
            panHeaderLunes.Location = new System.Drawing.Point(190, 0);
            panHeaderLunes.Margin = new System.Windows.Forms.Padding(0);
            panHeaderLunes.Name = "panHeaderLunes";
            panHeaderLunes.Size = new System.Drawing.Size(95, 30);
            panHeaderLunes.TabIndex = 1;
            // 
            // labHeaderLunes
            // 
            labHeaderLunes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            labHeaderLunes.Dock = System.Windows.Forms.DockStyle.Fill;
            labHeaderLunes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labHeaderLunes.ForeColor = System.Drawing.Color.White;
            labHeaderLunes.Location = new System.Drawing.Point(0, 0);
            labHeaderLunes.Name = "labHeaderLunes";
            labHeaderLunes.Size = new System.Drawing.Size(95, 30);
            labHeaderLunes.TabIndex = 1;
            labHeaderLunes.Text = "Lunes";
            labHeaderLunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeaderDomingo
            // 
            panHeaderDomingo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            panHeaderDomingo.Controls.Add(labHeaderDomingo);
            panHeaderDomingo.Dock = System.Windows.Forms.DockStyle.Fill;
            panHeaderDomingo.Location = new System.Drawing.Point(95, 0);
            panHeaderDomingo.Margin = new System.Windows.Forms.Padding(0);
            panHeaderDomingo.Name = "panHeaderDomingo";
            panHeaderDomingo.Size = new System.Drawing.Size(95, 30);
            panHeaderDomingo.TabIndex = 0;
            // 
            // labHeaderDomingo
            // 
            labHeaderDomingo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            labHeaderDomingo.Dock = System.Windows.Forms.DockStyle.Fill;
            labHeaderDomingo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labHeaderDomingo.ForeColor = System.Drawing.Color.White;
            labHeaderDomingo.Location = new System.Drawing.Point(0, 0);
            labHeaderDomingo.Name = "labHeaderDomingo";
            labHeaderDomingo.Size = new System.Drawing.Size(95, 30);
            labHeaderDomingo.TabIndex = 1;
            labHeaderDomingo.Text = "Domingo";
            labHeaderDomingo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panComida
            // 
            panComida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            panComida.Controls.Add(labHeaderComida);
            panComida.Dock = System.Windows.Forms.DockStyle.Fill;
            panComida.Location = new System.Drawing.Point(0, 0);
            panComida.Margin = new System.Windows.Forms.Padding(0);
            panComida.Name = "panComida";
            panComida.Size = new System.Drawing.Size(95, 30);
            panComida.TabIndex = 7;
            // 
            // labHeaderComida
            // 
            labHeaderComida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            labHeaderComida.Dock = System.Windows.Forms.DockStyle.Fill;
            labHeaderComida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labHeaderComida.ForeColor = System.Drawing.Color.White;
            labHeaderComida.Location = new System.Drawing.Point(0, 0);
            labHeaderComida.Name = "labHeaderComida";
            labHeaderComida.Size = new System.Drawing.Size(95, 30);
            labHeaderComida.TabIndex = 0;
            labHeaderComida.Text = "Comida";
            labHeaderComida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDesayuno
            // 
            labDesayuno.AutoSize = true;
            labDesayuno.BackColor = System.Drawing.Color.Transparent;
            labDesayuno.Depth = 0;
            labDesayuno.Dock = System.Windows.Forms.DockStyle.Fill;
            labDesayuno.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labDesayuno.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            labDesayuno.Location = new System.Drawing.Point(10, 40);
            labDesayuno.Margin = new System.Windows.Forms.Padding(10);
            labDesayuno.MouseState = MaterialSkin.MouseState.HOVER;
            labDesayuno.Name = "labDesayuno";
            labDesayuno.Size = new System.Drawing.Size(75, 70);
            labDesayuno.TabIndex = 9;
            labDesayuno.Text = "Desayuno";
            labDesayuno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMediMan
            // 
            labMediMan.AutoSize = true;
            labMediMan.BackColor = System.Drawing.Color.Transparent;
            labMediMan.Depth = 0;
            labMediMan.Dock = System.Windows.Forms.DockStyle.Fill;
            labMediMan.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labMediMan.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            labMediMan.Location = new System.Drawing.Point(10, 130);
            labMediMan.Margin = new System.Windows.Forms.Padding(10);
            labMediMan.MouseState = MaterialSkin.MouseState.HOVER;
            labMediMan.Name = "labMediMan";
            labMediMan.Size = new System.Drawing.Size(75, 70);
            labMediMan.TabIndex = 10;
            labMediMan.Text = "Media Mañana";
            labMediMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAlmuerzo
            // 
            labAlmuerzo.AutoSize = true;
            labAlmuerzo.BackColor = System.Drawing.Color.Transparent;
            labAlmuerzo.Depth = 0;
            labAlmuerzo.Dock = System.Windows.Forms.DockStyle.Fill;
            labAlmuerzo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labAlmuerzo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            labAlmuerzo.Location = new System.Drawing.Point(10, 220);
            labAlmuerzo.Margin = new System.Windows.Forms.Padding(10);
            labAlmuerzo.MouseState = MaterialSkin.MouseState.HOVER;
            labAlmuerzo.Name = "labAlmuerzo";
            labAlmuerzo.Size = new System.Drawing.Size(75, 70);
            labAlmuerzo.TabIndex = 11;
            labAlmuerzo.Text = "Almuerzo";
            labAlmuerzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMerienda
            // 
            labMerienda.AutoSize = true;
            labMerienda.BackColor = System.Drawing.Color.Transparent;
            labMerienda.Depth = 0;
            labMerienda.Dock = System.Windows.Forms.DockStyle.Fill;
            labMerienda.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labMerienda.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            labMerienda.Location = new System.Drawing.Point(10, 310);
            labMerienda.Margin = new System.Windows.Forms.Padding(10);
            labMerienda.MouseState = MaterialSkin.MouseState.HOVER;
            labMerienda.Name = "labMerienda";
            labMerienda.Size = new System.Drawing.Size(75, 70);
            labMerienda.TabIndex = 12;
            labMerienda.Text = "Merienda";
            labMerienda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCena
            // 
            labCena.AutoSize = true;
            labCena.BackColor = System.Drawing.Color.Transparent;
            labCena.Depth = 0;
            labCena.Dock = System.Windows.Forms.DockStyle.Fill;
            labCena.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labCena.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            labCena.Location = new System.Drawing.Point(10, 400);
            labCena.Margin = new System.Windows.Forms.Padding(10);
            labCena.MouseState = MaterialSkin.MouseState.HOVER;
            labCena.Name = "labCena";
            labCena.Size = new System.Drawing.Size(75, 71);
            labCena.TabIndex = 13;
            labCena.Text = "Cena";
            labCena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tlpCalendario
            //
            tlpCalendario.Controls.Add(panHeaderMiercoles, 4, 0);
            tlpCalendario.Controls.Add(panHeaderSabado, 7, 0);
            tlpCalendario.Controls.Add(panHeaderViernes, 6, 0);
            tlpCalendario.Controls.Add(panHeaderJueves, 5, 0);
            tlpCalendario.Controls.Add(panHeaderMartes, 3, 0);
            tlpCalendario.Controls.Add(panHeaderLunes, 2, 0);
            tlpCalendario.Controls.Add(panHeaderDomingo, 1, 0);
            tlpCalendario.Controls.Add(panComida, 0, 0);
            tlpCalendario.Controls.Add(labDesayuno, 0, 1);
            tlpCalendario.Controls.Add(labMediMan, 0, 2);
            tlpCalendario.Controls.Add(labAlmuerzo, 0, 3);
            tlpCalendario.Controls.Add(labMerienda, 0, 4);
            tlpCalendario.Controls.Add(labCena, 0, 5);
        }
    }
}
