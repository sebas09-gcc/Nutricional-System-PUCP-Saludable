using PUCPSaludable.Alumno.Citas.Controles;
using PUCPSaludable.Alumno.Nutricionista;
using PUCPSaludable.Controles;
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
    public partial class frmIndicadoresNutriAl : Form
    {
        private CRutinaWS.CumplimientoRutinaServiceClient _crs = new CRutinaWS.CumplimientoRutinaServiceClient();
        private IndicadorSaludWS.IndicadorSaludServiceClient _isws = new IndicadorSaludWS.IndicadorSaludServiceClient();
        private IndicadorAntropometricoWS.IndicadorAntropoServiceClient _iaws = new IndicadorAntropometricoWS.IndicadorAntropoServiceClient();
        private IngredienteWS.IngredienteServiceClient _ingws = new IngredienteWS.IngredienteServiceClient();
        private HorarioHabitualWS.HorarioHabitualServiceClient _horHabws = new HorarioHabitualWS.HorarioHabitualServiceClient();
        //private AlimentoWS.AlimentoWebServiceClient _aliws = new AlimentoWS.AlimentoWebServiceClient();
        private AlumnoWS.AlumnoServiceClient _alumAux = new AlumnoWS.AlumnoServiceClient();
        private HorasSuenhoWS.HorasSuenhoServicesClient _hsws = new HorasSuenhoWS.HorasSuenhoServicesClient();

        private bool flag = false;
        int i;
        int j;

        private IndicadorAntropometricoWS.indicadorAntropometrico[] indicAntLista = null;
        private HorasSuenhoWS.horasSuenho[] horasSunLista = null;

        int _idalum;
        public frmIndicadoresNutriAl(int idalum)
        {
            _idalum = idalum;
            i = 0;
            j = 0;
            InitializeComponent();
            panGeneratorUcs.Controls.Clear();

            listarIndicadoresSaludRespec();
            dgvIndicaAntropo.AutoGenerateColumns = false;
            dgvHorasSuenho.AutoGenerateColumns = false;
            flag = false;
            listarCumplimientoPlanAlimentario();
            deshabilitarCheckboxes();
            dtpFechaRegistrarComida.Fecha = DateTime.Now;



        }

        private void frmIndicadoresNutriAl_Load(object sender, EventArgs e)
        {
            listarIndicadoresSaludRespec();//TODO BIEN
            cargarIndicadoresAntropom();//COPIAR
            setupHorariosHabituales();//TODO BIEN
            //lo de Marco ta bien, solo es deshabilitar el boton de agregar
            //horasSueno
            cargarHorasSuenho();

            ucWebView wvIMC = new ucWebView();
            wvIMC.Dock = DockStyle.Fill;
            wvIMC.URL = "http://ws.pucpsaludable.ml/da_imc.php?uid=" + _idalum;
            panWvIMC.Controls.Add(wvIMC);
            ucWebView wvHorasSueno = new ucWebView();
            wvHorasSueno.Dock = DockStyle.Fill;
            wvHorasSueno.URL = "http://ws.pucpsaludable.ml/da_sleep.php?uid=" + _idalum;
            panWvHorasSueno.Controls.Add(wvHorasSueno);


        }

        private void cargarFechayModificar()
        {

        }

        private void setupHorariosHabituales()
        {
            HorarioHabitualWS.horarioHabitual hh = _horHabws.obtenerHorarioHabitual(_idalum);
            //revisar si existe para este usuario, si existe insert sino modify
            ucHoraA1.HoraCompleta = hh.desayuno;
            ucHoraA2.HoraCompleta = hh.mediaManana;
            ucHoraA3.HoraCompleta = hh.comida;
            ucHoraA4.HoraCompleta = hh.merienda;
            ucHoraA5.HoraCompleta = hh.cena;
            ucHoraV1.HoraCompleta = hh.despertarse;
            ucHoraV2.HoraCompleta = hh.acostarse;

            ucHoraA1.Enabled = false;
            ucHoraA2.Enabled = false;
            ucHoraA3.Enabled = false;
            ucHoraA4.Enabled = false;
            ucHoraA5.Enabled = false;
            ucHoraV1.Enabled = false;
            ucHoraV2.Enabled = false;


        }

        private void cargarIndicadoresAntropom()
        {
            try
            {
                indicAntLista = _iaws.listarIndicadorAntropomPorAlumno(_idalum);
                if (indicAntLista != null)
                    dgvIndicaAntropo.DataSource = new BindingList<IndicadorAntropometricoWS.indicadorAntropometrico>(indicAntLista);

            }
            catch
            {
                //tbPesoHabitual.Text = "No hay datos";
            }
        }




        private void listarUnaFecha()
        {


            CRutinaWS.cumplimientoRutina[] cumplimientoRutinas = _crs.listarCumplimientoRutinaAlimentariaxAlumnoyFecha(_idalum, dtpFechaRegistrarComida.Fecha);
            CRutinaWS.cumplimientoRutina[] nombres = _crs.listarPlanAlimentarioNombreRecetasxAlumnoyFecha(_idalum, dtpFechaRegistrarComida.Fecha);
            if (nombres != null)
            {
                labComidasHoy.Text = "Comidas del día " + dtpFechaRegistrarComida.Fecha.ToString("dd/MM/yyyy");
                cbDesayuno.Text = nombres[0].nombreReceta;
                cbMediaManana.Text = nombres[1].nombreReceta;
                cbComida.Text = nombres[2].nombreReceta;
                cbMerienda.Text = nombres[3].nombreReceta;
                cbCena.Text = nombres[4].nombreReceta;

                if (cumplimientoRutinas != null)
                {
                    if (cumplimientoRutinas[0].cumplio == 1)
                        cbDesayuno.Checked = true;
                    else cbDesayuno.Checked = false;

                    if (cumplimientoRutinas[1].cumplio == 1)
                        cbMediaManana.Checked = true;
                    else cbMediaManana.Checked = false;

                    if (cumplimientoRutinas[2].cumplio == 1)
                        cbComida.Checked = true;
                    else cbComida.Checked = false;

                    if (cumplimientoRutinas[3].cumplio == 1)
                        cbMerienda.Checked = true;
                    else cbMerienda.Checked = false;

                    if (cumplimientoRutinas[4].cumplio == 1)
                        cbCena.Checked = true;
                    else cbCena.Checked = false;
                }
                else
                {
                    cbDesayuno.Checked = false;
                    cbMediaManana.Checked = false;
                    cbComida.Checked = false;
                    cbMerienda.Checked = false;
                    cbCena.Checked = false;
                }
                //flag = true;
                //this.btnRegistarComida.Enabled = true;
                //this.cbDesayuno.Enabled = false;
                //this.cbMediaManana.Enabled = false;
                //this.cbComida.Enabled = false;
                //this.cbMerienda.Enabled = false;
                //this.cbCena.Enabled = false;
            }
            else
            {
                labComidasHoy.Text = "Seleccione una fecha para encontrar su plan alimentario";
                cbDesayuno.Text = "";
                cbMediaManana.Text = "";
                cbComida.Text = "";
                cbMerienda.Text = "";
                cbCena.Text = "";
                cbDesayuno.Checked = false;
                cbMediaManana.Checked = false;
                cbComida.Checked = false;
                cbMerienda.Checked = false;
                cbCena.Checked = false;
                //this.cbDesayuno.Enabled = false;
                //this.cbMediaManana.Enabled = false;
                //this.cbComida.Enabled = false;
                //this.cbMerienda.Enabled = false;
                //this.cbCena.Enabled = false;

                flag = false;
                frmNoPlanAlimentario noplan = new frmNoPlanAlimentario();
                noplan.Show();

            }


        }



        private void listarIndicadoresSaludRespec()
        {
            IndicadorSaludWS.indicadorSalud isal = _isws.adquirirIndicadorSalud(_idalum);//idAlumno en sesion
            //llenamos los ComboBox
            if (isal.diarrea) cbxDiarrea.Checked = true;
            else cbxDiarrea.Checked = false;
            if (isal.aFCancer) cbxCancer.Checked = true;
            else cbxCancer.Checked = false;
            cbxDiabetes.Checked = isal.aFDiabetes;
            cbxHiperColest.Checked = isal.aFHipercolesterolemia;
            cbxHiperTrigli.Checked = isal.aFHipertrigliceridemia;
            cbxHTA.Checked = isal.aFHTA;
            cbxObesidad.Checked = isal.aFObesidad;
            cbxAlcohol.Checked = isal.alcohol;
            mtbAlergias.Text = isal.alergiasMed;
            cbxAnalgesicos.Checked = isal.analgesicos;
            cbxAntiacidos.Checked = isal.antiacidos;
            cbxAnticonceptivosO.Checked = isal.anticonceptivosOrales;
            cbxCafe.Checked = isal.cafe;
            cbxCeliaquia.Checked = isal.celiaquia;
            mtbCirugias.Text = isal.cirugiasPrevias;
            cbxClimaterio.Checked = isal.climaterio;
            cbxColitis.Checked = isal.colitis;
            cbxDentadura.Checked = isal.dentadura;

            cbxDiureticos.Checked = isal.diureticos;
            cbxEmbarazo.Checked = isal.embarazo;
            cbxEstrenimiento.Checked = isal.estrenimiento;
            cbxGastritis.Checked = isal.gastritis;
            cbxLaxantes.Checked = isal.laxantes;
            cbxNauseas.Checked = isal.nausea;
            cbxPirosis.Checked = isal.pirosis;
            cbxSensibilidadDen.Checked = isal.sensibilidadDental;
            cbxTabaco.Checked = isal.tabaco;
            cbxTerapiaHorm.Checked = isal.terapiaHormonal;
            cbxUlceras.Checked = isal.ulcera;
            cbxVomitos.Checked = isal.vomito;
        }
        private void listarCumplimientoPlanAlimentario()
        {
            panGeneratorUcs.Controls.Clear();
            CRutinaWS.cumplimientoRutina[] cumplimientoRutinas = _crs.listarCumplimientoRutinaAlimentariaxAlumno(_idalum);
            if (cumplimientoRutinas != null)
            {
                labComidasHoy.Text = "Comidas del día " + dtpFechaRegistrarComida.Fecha.ToString("dd/MM/yyyy");
                for (int i = 0; i < cumplimientoRutinas.Length; i += 5)
                {
                    ucHistComidas hc = new ucHistComidas();
                    hc.Dock = DockStyle.Top;
                    hc.Fecha = cumplimientoRutinas[i].fecha.ToString("dd/MM/yyyy");

                    if (cumplimientoRutinas[i].cumplio == 1)
                        hc.Check1 = ECheckComidas.Check;
                    else hc.Check1 = ECheckComidas.Uncheck;

                    if (cumplimientoRutinas[i + 1].cumplio == 1)
                        hc.Check2 = ECheckComidas.Check;
                    else hc.Check2 = ECheckComidas.Uncheck;

                    if (cumplimientoRutinas[i + 2].cumplio == 1)
                        hc.Check3 = ECheckComidas.Check;
                    else hc.Check3 = ECheckComidas.Uncheck;

                    if (cumplimientoRutinas[i + 3].cumplio == 1)
                        hc.Check4 = ECheckComidas.Check;
                    else hc.Check4 = ECheckComidas.Uncheck;

                    if (cumplimientoRutinas[i + 4].cumplio == 1)
                        hc.Check5 = ECheckComidas.Check;
                    else hc.Check5 = ECheckComidas.Uncheck;

                    panGeneratorUcs.Controls.Add(hc);

                }

            }
        }
        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            listarUnaFecha();
        }

        private void cargarHorasSuenho()
        {
            try
            {
                horasSunLista = _hsws.listarHorasSuenPorAlum(_idalum);
                if (horasSunLista != null)
                    dgvHorasSuenho.DataSource = new BindingList<HorasSuenhoWS.horasSuenho>(horasSunLista);
            }
            catch (Exception exce)
            {
                //tbHorasSueno.Text = "NoHayDatos?";
            }

        }

        private void dgvHorasSuenho_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            HorasSuenhoWS.horasSuenho hsfila =
           (HorasSuenhoWS.horasSuenho)dgvHorasSuenho.Rows[e.RowIndex].DataBoundItem;
            if (hsfila != null)
            {
                dgvHorasSuenho.Rows[e.RowIndex].Cells[0].Value = hsfila.fecha.ToString("dd/MM/yyyy");
                dgvHorasSuenho.Rows[e.RowIndex].Cells[1].Value = hsfila.horas;
            }
        }

        private void dgvIndicaAntropo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                IndicadorAntropometricoWS.indicadorAntropometrico ia =
                    (IndicadorAntropometricoWS.indicadorAntropometrico)dgvIndicaAntropo.Rows[e.RowIndex].DataBoundItem;
                if (ia != null)
                {
                    dgvIndicaAntropo.Rows[e.RowIndex].Cells["Fecha"].Value = ia.fechaRegistro.ToString("dd/MM/yyyy");
                    dgvIndicaAntropo.Rows[e.RowIndex].Cells[1].Value = ia.pesoHabitual;
                    dgvIndicaAntropo.Rows[e.RowIndex].Cells[2].Value = ia.estatura;
                    dgvIndicaAntropo.Rows[e.RowIndex].Cells[3].Value = ia.circunferenciaBrazo;
                    dgvIndicaAntropo.Rows[e.RowIndex].Cells[4].Value = ia.circunferenciaCintura;
                    dgvIndicaAntropo.Rows[e.RowIndex].Cells[5].Value = ia.circunferenciaCadera;
                    dgvIndicaAntropo.Rows[e.RowIndex].Cells[6].Value = ia.circunferenciaAbdominal;
                }
            }
            catch (Exception excep)
            {
                //tbPesoHabitual.Text = "Null";
            }
        }


        private void habilitarCheckboxes()
        {
            labComidasHoy.Text = "Comidas del día "+ dtpFechaRegistrarComida.Fecha.ToString("dd/MM/yyyy");
            this.cbDesayuno.Enabled = true;
            this.cbMediaManana.Enabled = true;
            this.cbComida.Enabled = true;
            this.cbMerienda.Enabled = true;
            this.cbCena.Enabled = true;

            this.cbDesayuno.Checked = false;
            this.cbMediaManana.Checked = false;
            this.cbComida.Checked = false;
            this.cbMerienda.Checked = false;
            this.cbCena.Checked = false;
        }

        private void deshabilitarCheckboxes()
        {
            labComidasHoy.Text = "Seleccione una fecha para encontrar su plan alimentario";

            cbDesayuno.Text = "";
            cbMediaManana.Text = "";
            cbComida.Text = "";
            cbMerienda.Text = "";
            cbCena.Text = "";

            //this.cbDesayuno.Enabled = false;
            //this.cbMediaManana.Enabled = false;
            //this.cbComida.Enabled = false;
            //this.cbMerienda.Enabled = false;
            //this.cbCena.Enabled = false;

            this.cbDesayuno.Checked = false;
            this.cbMediaManana.Checked = false;
            this.cbComida.Checked = false;
            this.cbMerienda.Checked = false;
            this.cbCena.Checked = false;

        }
    }
}
