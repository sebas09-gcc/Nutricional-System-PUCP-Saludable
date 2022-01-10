using PUCPSaludable.Alumno.Citas.Controles;
using PUCPSaludable.Alumno.Nutricionista;
using PUCPSaludable.Common;
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

namespace PUCPSaludable.Alumno.Nutricionista
{
    public partial class frmIndicadoresDeSalud : Form
    {
        private CRutinaWS.CumplimientoRutinaServiceClient _crs = new CRutinaWS.CumplimientoRutinaServiceClient();
        private IndicadorSaludWS.IndicadorSaludServiceClient _isws = new IndicadorSaludWS.IndicadorSaludServiceClient();

        private IndicadorAntropometricoWS.IndicadorAntropoServiceClient _iaws = new IndicadorAntropometricoWS.IndicadorAntropoServiceClient();
        private IngredienteWS.IngredienteServiceClient _ingws = new IngredienteWS.IngredienteServiceClient();
        private HorarioHabitualWS.HorarioHabitualServiceClient _horHabws = new HorarioHabitualWS.HorarioHabitualServiceClient();
        private AlimentoWS.AlimentoWebServiceClient _aliws = new AlimentoWS.AlimentoWebServiceClient();
        private AlumnoWS.AlumnoServiceClient _alumAux = new AlumnoWS.AlumnoServiceClient();
        private HorasSuenhoWS.HorasSuenhoServicesClient _hsws = new HorasSuenhoWS.HorasSuenhoServicesClient();

        private IndicadorAntropometricoWS.indicadorAntropometrico[] indicAntLista = null;
        private HorasSuenhoWS.horasSuenho[] horasSunLista = null;

        private BackgroundWorker bwListarCumplimiento;

        private bool flag = false;

        frmAgregarAlimento _fAgAlm = new frmAgregarAlimento(Common.Session.UserID);
        int i;
        int j;
        
        public frmIndicadoresDeSalud()
        {
            inicializarBackgroundWorkers();

            i = 0;
            j = 0;
            InitializeComponent();
            panGeneratorUcs.Controls.Clear();
            
            listarIndicadoresSaludRespec();
            dgvIndicaAntropo.AutoGenerateColumns = false;
            dgvHorasSuenho.AutoGenerateColumns = false;
            flag = false;
            this.btnRegistarComida.Enabled = false;
            deshabilitarCheckboxes();

            
            //listarCumplimientoPlanAlimentario();

            dtpFechaRegistrarComida.Fecha = DateTime.Now;
            //setupHorariosHabituales();
            actzPreferenciasComidas();

            

            //ucWebView wvHorasSueno = new ucWebView();
            //wvHorasSueno.Dock = DockStyle.Fill;
            //wvHorasSueno.URL = "http://ws.pucpsaludable.ml/da_sleep.php?uid=" + Common.Session.UserID;
            //panel5.Controls.Add(wvHorasSueno);

        }

        private void frmIndicadoresDeSalud_Load(object sender, EventArgs e)
        {
            cargarIndicadoresAntropom();
            cargarHorasSuenho();
            setupHorariosHabituales();

            bwListarCumplimiento.RunWorkerAsync();
        }

        private void inicializarBackgroundWorkers()
        {
            bwListarCumplimiento = new BackgroundWorker();
            bwListarCumplimiento.WorkerSupportsCancellation = true;
            bwListarCumplimiento.DoWork += new DoWorkEventHandler(listarCumplimiento_DoWork);
            bwListarCumplimiento.RunWorkerCompleted += new RunWorkerCompletedEventHandler(listarCumplimiento_RunWorkerCompleted);
        }

        private void listarCumplimiento_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panGeneratorUcs.Controls.Clear();

            CRutinaWS.cumplimientoRutina[] cumplimientoRutinas = (CRutinaWS.cumplimientoRutina[]) e.Result;

            if (cumplimientoRutinas != null)
            {

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

        private void listarCumplimiento_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                if (bwListarCumplimiento.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                
                //CRutinaWS.cumplimientoRutina[] cumplimientoRutinas = _crs.listarCumplimientoRutinaAlimentariaxAlumno(Common.Session.UserID);
                e.Result = _crs.listarCumplimientoRutinaAlimentariaxAlumno(Common.Session.UserID);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void habilitarCheckboxes() {
            labComidasHoy.Text = "Comidas para hoy:";
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

            this.cbDesayuno.Enabled = false;            
            this.cbMediaManana.Enabled = false;
            this.cbComida.Enabled = false;
            this.cbMerienda.Enabled = false;
            this.cbCena.Enabled = false;

            this.cbDesayuno.Checked = false;
            this.cbMediaManana.Checked = false;
            this.cbComida.Checked = false;
            this.cbMerienda.Checked = false;
            this.cbCena.Checked = false;

        }


        private void setupHorariosHabituales()
        {
            HorarioHabitualWS.horarioHabitual hh = _horHabws.obtenerHorarioHabitual(Common.Session.UserID);
            //revisar si existe para este usuario, si existe insert sino modify
            if (hh.fid_alumno == -1)//llamamos a insertar, todo en false y vacio
            {
                hh.fid_alumno = Common.Session.UserID;
                hh.acostarseSpecified = true;
                hh.cenaSpecified = true;
                hh.comidaSpecified = true;
                hh.desayunoSpecified = true;
                hh.despertarseSpecified = true;
                hh.mediaMananaSpecified = true;
                hh.meriendaSpecified = true;
                _horHabws.insertarHorarioHabitual(hh);
            }
            ucHoraA1.HoraCompleta = hh.desayuno;
            ucHoraA2.HoraCompleta = hh.mediaManana;
            ucHoraA3.HoraCompleta = hh.comida;
            ucHoraA4.HoraCompleta = hh.merienda;
            ucHoraA5.HoraCompleta = hh.cena;
            ucHoraV1.HoraCompleta = hh.despertarse;
            ucHoraV2.HoraCompleta = hh.acostarse;
        }

        private void cargarIndicadoresAntropom()
        {
            try {
                indicAntLista = _iaws.listarIndicadorAntropomPorAlumno(Common.Session.UserID);
                if (indicAntLista != null)
                dgvIndicaAntropo.DataSource = new BindingList<IndicadorAntropometricoWS.indicadorAntropometrico>(indicAntLista);
                panel9.Controls.Clear();
                ucWebView wvIMC = new ucWebView();
                wvIMC.Dock = DockStyle.Fill;
                wvIMC.URL = "http://ws.pucpsaludable.ml/da_imc.php?uid=" + Common.Session.UserID;
                panel9.Controls.Add(wvIMC);
            }
            catch
            {
                tbPesoHabitual.Text = "No hay datos";
            }
        }

        

        private void listarUnaFecha()
        {


            CRutinaWS.cumplimientoRutina[] cumplimientoRutinas = _crs.listarCumplimientoRutinaAlimentariaxAlumnoyFecha(Common.Session.UserID, dtpFechaRegistrarComida.Fecha);
            CRutinaWS.cumplimientoRutina[] nombres = _crs.listarPlanAlimentarioNombreRecetasxAlumnoyFecha(Common.Session.UserID, dtpFechaRegistrarComida.Fecha);
            if (nombres != null)
            {
                habilitarCheckboxes();
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
                flag = true;
                this.btnRegistarComida.Enabled = true;
            }
            else
            {

                deshabilitarCheckboxes();

                flag = false;
                this.btnRegistarComida.Enabled = false;
                frmNoPlanAlimentario noplan = new frmNoPlanAlimentario();
                noplan.Show();
            }


        }



        private void listarIndicadoresSaludRespec()
        {
            IndicadorSaludWS.indicadorSalud isal = _isws.adquirirIndicadorSalud(Common.Session.UserID);//idAlumno en sesion
            if(isal.fid_alumno == -1)//llamamos a insertar, todo en false y vacio
            {
                isal.fid_alumno = Common.Session.UserID;
                _isws.insertarIndicadorSalud(isal);
            }
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
            cbxTabaco.Checked =  isal.tabaco;
            cbxTerapiaHorm.Checked = isal.terapiaHormonal;
            cbxUlceras.Checked = isal.ulcera;
            cbxVomitos.Checked = isal.vomito;
        }
        private void listarCumplimientoPlanAlimentario()
        {
            panGeneratorUcs.Controls.Clear();
            CRutinaWS.cumplimientoRutina[] cumplimientoRutinas = _crs.listarCumplimientoRutinaAlimentariaxAlumno(Common.Session.UserID);
            if (cumplimientoRutinas != null)
            {

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

        private void btnRegistarIndic_Click(object sender, EventArgs e)
        {
            panel10.Enabled = false;
            double holdA, holdB, holdCA, holdCC,holdE,holdPH;
            IndicadorAntropometricoWS.indicadorAntropometrico ia = new IndicadorAntropometricoWS.indicadorAntropometrico();
            bool ParsA = Double.TryParse(tbAbdomen.Text, out holdA);
            bool ParsB = Double.TryParse(tbBrazo.Text, out holdB);
            bool ParsCA = Double.TryParse(tbCadera.Text, out holdCA);
            bool ParsCC = Double.TryParse(tbCintura.Text, out holdCC);
            bool ParsE = Double.TryParse(tbEstatura.Text, out holdE);
            bool ParsPH = Double.TryParse(tbPesoHabitual.Text, out holdPH);
            ia.fechaRegistro = DateTime.Now.Date;
            ia.fechaRegistroSpecified = true;
            ia.fid_alumno = Common.Session.UserID;
            if(ParsA && ParsB && ParsCA && ParsCC && ParsE && ParsPH
                && holdA > 0 && holdB > 0 && holdCA > 0 && holdCC >0 && holdE >0 && holdPH >0)
            {
                ia.circunferenciaAbdominal = holdA;
                ia.circunferenciaBrazo = holdB;
                ia.circunferenciaCadera = holdCA;
                ia.circunferenciaCintura = holdCC;
                ia.estatura = holdE;
                ia.pesoHabitual = holdPH;
                if (indicAntLista != null)
                {
                    if (indicAntLista[0].fechaRegistro.Equals(ia.fechaRegistro))
                    {
                        ia.id_indicadorAntropometrico = indicAntLista[0].id_indicadorAntropometrico;
                        int m = _iaws.modificarIndicadorAntropom(ia);
                    }
                    else
                    {
                        _iaws.insertarIndicadorAntropom(ia);
                    }
                }
                else
                {
                    _iaws.insertarIndicadorAntropom(ia);
                }
                //buscar el primer elemento de la lista q sera el más reciente
                //si la fecha es la misma que la del ia actual
                //llamamos a modificar
                //sino a insertar
                panel10.Enabled = true;
                cargarIndicadoresAntropom();//recargamos la lista

            }
            else
            {
                string listaErrores;
                frmDatosIAIncorrectos formErrores = new frmDatosIAIncorrectos();
                listaErrores = "";
                if(!ParsA || holdA <= 0)
                {
                    listaErrores += "Abdomen \n";
                }
                if (!ParsB || holdB <= 0)
                {
                    listaErrores += "Brazo \n";
                }
                if (!ParsCA || holdCA <= 0)
                {
                    listaErrores += "Cadera \n";
                }
                if (!ParsCC || holdCC <= 0)
                {
                    listaErrores += "Cintura \n";
                }
                if (!ParsE || holdE <= 0)
                {
                    listaErrores += "Estatura \n";
                }
                if (!ParsPH || holdPH <= 0)
                {
                    listaErrores += "Altura \n";
                }
                formErrores.Errores = listaErrores;
                formErrores.ShowDialog();
                panel10.Enabled = true;
            }



        }

        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            listarUnaFecha();
        }

        private void btnRegistrarIndiSalud_Click(object sender, EventArgs e)
        {
            tabPage1.Enabled = false;
            IndicadorSaludWS.indicadorSalud isal = new IndicadorSaludWS.indicadorSalud();
            isal.aFCancer = cbxCancer.Checked;
            isal.aFDiabetes = cbxDiabetes.Checked;
            isal.aFHipercolesterolemia = cbxHiperColest.Checked;
            isal.aFHipertrigliceridemia = cbxHiperTrigli.Checked;
            isal.aFHTA = cbxHTA.Checked;
            isal.aFObesidad = cbxObesidad.Checked;
            isal.alcohol = cbxAlcohol.Checked;
            isal.alergiasMed = mtbAlergias.Text;
            isal.analgesicos = cbxAnalgesicos.Checked;
            isal.antiacidos = cbxAntiacidos.Checked;
            isal.anticonceptivosOrales = cbxAnticonceptivosO.Checked;
            isal.cafe = cbxCafe.Checked;
            isal.celiaquia = cbxCeliaquia.Checked;
            isal.cirugiasPrevias = mtbCirugias.Text;
            isal.climaterio = cbxClimaterio.Checked;
            isal.colitis = cbxColitis.Checked;
            isal.dentadura = cbxDentadura.Checked;
            isal.diarrea = cbxDiarrea.Checked;
            isal.diureticos = cbxDiureticos.Checked;
            isal.embarazo = cbxEmbarazo.Checked;
            isal.estrenimiento = cbxEstrenimiento.Checked;
            isal.fid_alumno = Common.Session.UserID;
            isal.gastritis = cbxGastritis.Checked;
            isal.laxantes = cbxLaxantes.Checked;
            isal.nausea = cbxNauseas.Checked;
            isal.pirosis = cbxPirosis.Checked;
            isal.sensibilidadDental = cbxSensibilidadDen.Checked;
            isal.tabaco = cbxTabaco.Checked;
            isal.terapiaHormonal = cbxTerapiaHorm.Checked;
            isal.ulcera = cbxUlceras.Checked;
            isal.vomito = cbxVomitos.Checked;
            _isws.modificarIndicadorSalud(isal);
            tabPage1.Enabled = true;
        }

        

        

        private void btnRegistarComida_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                this.btnRegistarComida.Enabled = false;
            }

            else
            {
                CRutinaWS.cumplimientoRutina[] cumplimientoRutinas = _crs.listarCumplimientoRutinaAlimentariaxAlumnoyFecha(Common.Session.UserID, dtpFechaRegistrarComida.Fecha);

                //si existe un registro para la fecha
                if (cumplimientoRutinas != null)
                {
                    if (cbDesayuno.Checked == true)
                        cumplimientoRutinas[0].cumplio = 1;
                    else
                        cumplimientoRutinas[0].cumplio = 0;

                    if (cbMediaManana.Checked == true)
                        cumplimientoRutinas[1].cumplio = 1;
                    else
                        cumplimientoRutinas[1].cumplio = 0;

                    if (cbComida.Checked == true)
                        cumplimientoRutinas[2].cumplio = 1;
                    else
                        cumplimientoRutinas[2].cumplio = 0;

                    if (cbMerienda.Checked == true)
                        cumplimientoRutinas[3].cumplio = 1;
                    else
                        cumplimientoRutinas[3].cumplio = 0;

                    if (cbCena.Checked == true)
                        cumplimientoRutinas[4].cumplio = 1;
                    else
                        cumplimientoRutinas[4].cumplio = 0;


                    for (int i = 0; i < 5; i++)
                    {
                        cumplimientoRutinas[i].id_cumplimientoRutina = _crs.modificarCumplimientoRutinaAlimentaria(cumplimientoRutinas[i]);
                    }

                    if (bwListarCumplimiento.IsBusy)
                        bwListarCumplimiento.CancelAsync();
                    else
                        bwListarCumplimiento.RunWorkerAsync();

                    listarUnaFecha();
                }

                else
                {
                    cumplimientoRutinas = new CRutinaWS.cumplimientoRutina[5];

                    for (int i = 0; i < 5; i++)
                        cumplimientoRutinas[i] = new CRutinaWS.cumplimientoRutina();


                    /*
                     *  cs.setInt("_fid_alumno", cumple.getFid_alumno());
                        cs.setDate("_fecha",new java.sql.Date(cumple.getFecha().getTime()));
                        cs.setInt("_cumplio", 1);
                        cs.setInt("_tipoRutina", 0);
                        cs.setInt("_tipoComida", cumple.getTipoComida());            
                        cs.executeUpdate();
                        cumple.setId_cumplimientoRutina(cs.getInt("_id_cumplimientoRutina"));
                     */

                    if (cbDesayuno.Checked == true)
                        cumplimientoRutinas[0].cumplio = 1;
                    else
                        cumplimientoRutinas[0].cumplio = 0;

                    if (cbMediaManana.Checked == true)
                        cumplimientoRutinas[1].cumplio = 1;
                    else
                        cumplimientoRutinas[1].cumplio = 0;

                    if (cbComida.Checked == true)
                        cumplimientoRutinas[2].cumplio = 1;
                    else
                        cumplimientoRutinas[2].cumplio = 0;

                    if (cbMerienda.Checked == true)
                        cumplimientoRutinas[3].cumplio = 1;
                    else
                        cumplimientoRutinas[3].cumplio = 0;

                    if (cbCena.Checked == true)
                        cumplimientoRutinas[4].cumplio = 1;
                    else
                        cumplimientoRutinas[4].cumplio = 0;


                    for (int i = 0; i < 5; i++)
                    {
                        cumplimientoRutinas[i].fid_alumno = Common.Session.UserID;
                        cumplimientoRutinas[i].fecha = dtpFechaRegistrarComida.Fecha;
                        cumplimientoRutinas[i].fechaSpecified = true;
                        cumplimientoRutinas[i].tipoRutina = 0;
                        cumplimientoRutinas[i].tipoComida = i + 1;
                        cumplimientoRutinas[i].id_cumplimientoRutina = _crs.insertarCumplimientoRutinaAlimentaria(cumplimientoRutinas[i]);
                    }
                    //listarCumplimientoPlanAlimentario();
                    if (bwListarCumplimiento.IsBusy)
                        bwListarCumplimiento.CancelAsync();
                    else
                        bwListarCumplimiento.RunWorkerAsync();
                    listarUnaFecha();

                }


            }
        }

        private void btnAgregarAli_Click(object sender, EventArgs e)
        {
            frmAgregarAlimento formConsulta = new frmAgregarAlimento(Common.Session.UserID);
            if(formConsulta.ShowDialog() == DialogResult.OK)
            {
                //actualizarPaneles
                actzPreferenciasComidas();
                   
                //dgvIngrePref.DataSource = _ingws.listarIngredientesPrefAl(Common.Session.UserID, 1);
                //dgvAlimNopref.DataSource = _ingws.listarIngredientesPrefAl(Common.Session.UserID, 0);
                //dgvAlimAlergia.DataSource = _ingws.listarIngredientesPrefAl(Common.Session.UserID, 2);
                //ESTOS SI FUNCIONARON, SIN CELLFORMATTING
            }
        }


        private void btnHorasReg_Click(object sender, EventArgs e)
        {
            gbAlimentacion.Enabled = false;
            gbVigilia.Enabled = false;
            HorarioHabitualWS.horarioHabitual hh = new HorarioHabitualWS.horarioHabitual();
            //el insert se hace al entrar por primera vez
            hh.fid_alumno = Common.Session.UserID;
            hh.desayuno = ucHoraA1.HoraCompleta;
            hh.mediaManana = ucHoraA2.HoraCompleta;
            hh.comida = ucHoraA3.HoraCompleta;
            hh.merienda = ucHoraA4.HoraCompleta;
            hh.cena = ucHoraA5.HoraCompleta;
            hh.despertarse = ucHoraV1.HoraCompleta;
            hh.acostarse = ucHoraV2.HoraCompleta;
            hh.acostarseSpecified = true;
            hh.cenaSpecified = true;
            hh.comidaSpecified = true;
            hh.desayunoSpecified = true;
            hh.despertarseSpecified = true;
            hh.mediaMananaSpecified = true;
            hh.meriendaSpecified = true;
            _horHabws.modificarHorarioHabitual(hh);
            gbAlimentacion.Enabled = true;
            gbVigilia.Enabled = true;
        }

        private void actzPreferenciasComidas()
        {
            panListPref.Controls.Clear();
            panListNoPref.Controls.Clear();
            panListAler.Controls.Clear();
            listarAlimsPref();
            listarAlimsNoPref();
            listarAlimsAlergia();
        }

        private void listarAlimsPref()
        {
            panListPref.Controls.Clear();
            IngredienteWS.ingrediente[] ingreds = _ingws.listarIngredientesPrefAl(Common.Session.UserID, 1);
            if (ingreds != null)
            {
                foreach (IngredienteWS.ingrediente com in ingreds)
                {
                    ucAlimentoListado ch = new ucAlimentoListado();
                    ch.NomIng = com.nombre;
                    ch.Dock = DockStyle.Top;
                    MaterialSkin.Controls.MaterialButton btnBor = new MaterialSkin.Controls.MaterialButton();
                    btnBor.Click += new System.EventHandler(btnBor_Click);
                    ch.insertarBoton(btnBor, com.idIngrediente,Common.Session.UserID,1);
                    panListPref.Controls.Add(ch);
                }
            }
        }

        private void listarAlimsNoPref()
        {
            panListNoPref.Controls.Clear();
            IngredienteWS.ingrediente[] ingreds = _ingws.listarIngredientesPrefAl(Common.Session.UserID, 0);
            if (ingreds != null)
            {
                foreach (IngredienteWS.ingrediente com in ingreds)
                {
                    ucAlimentoListado ch = new ucAlimentoListado();
                    //ch.Cita = c;
                    ch.NomIng = com.nombre;
                    ch.Dock = DockStyle.Top;
                    MaterialSkin.Controls.MaterialButton btnBor = new MaterialSkin.Controls.MaterialButton();
                    btnBor.Click += new System.EventHandler(btnBor_Click);
                    ch.insertarBoton(btnBor, com.idIngrediente, Common.Session.UserID, 0);
                    panListNoPref.Controls.Add(ch);
                }
            }
        }

        private void listarAlimsAlergia()
        {
            panListAler.Controls.Clear();
            IngredienteWS.ingrediente[] ingreds = _ingws.listarIngredientesPrefAl(Common.Session.UserID, 2);
            if (ingreds != null)
            {
                foreach (IngredienteWS.ingrediente com in ingreds)
                {
                    ucAlimentoListado ch = new ucAlimentoListado();
                    ch.NomIng = com.nombre;
                    ch.Dock = DockStyle.Top;
                    MaterialSkin.Controls.MaterialButton btnBor = new MaterialSkin.Controls.MaterialButton();
                    btnBor.Click += new System.EventHandler(btnBor_Click);
                    ch.insertarBoton(btnBor, com.idIngrediente, Common.Session.UserID, 2);
                    panListAler.Controls.Add(ch);
                }
            }
        }

        private void btnBor_Click(object sender, EventArgs e)
        {

            Button ucC = sender as Button;
            AlimentoWS.alimento OBALM = (AlimentoWS.alimento) ucC.Tag;
            _aliws.eliminarAlimento(OBALM.fid_alumno,OBALM.fid_ingrediente) ;
            //actualizar el panel respectivo
            if (OBALM.preferencia == 1)
            {
                //panListPref.Controls.Clear();
                listarAlimsPref();
            } else if (OBALM.preferencia == 2)
            {
                //panListAler.Controls.Clear();
                listarAlimsAlergia();
            }
            else
            {
                //panListNoPref.Controls.Clear();
                listarAlimsNoPref();
            }
        }

        private void btnRegistarHoras_Click(object sender, EventArgs e)
        {
            panelInHorasSuenho.Enabled = false;
            double horaHold;
            HorasSuenhoWS.horasSuenho hsHold = new HorasSuenhoWS.horasSuenho();
            hsHold.fid_alumno = Common.Session.UserID;
            hsHold.fecha = dtpFechaHoraSueno.Fecha;
            hsHold.fechaSpecified = true;
            bool isHourParsable = Double.TryParse(tbHorasSueno.Text,out horaHold);
            //hsHold.horas = Convert.ToInt32(tbHorasSueno.Text);
            if(isHourParsable && horaHold >= 0 && horaHold < 24)
            {
                hsHold.horas = horaHold;
                if (horasSunLista != null)
                {
                    if (hsHold.fecha == horasSunLista[0].fecha)
                    {
                        //modificar
                        hsHold.id_horasSueno = horasSunLista[0].id_horasSueno;
                        int m = _hsws.modificarHorasSuenho(hsHold);
                    }
                    else
                    {
                        int a = _hsws.insertarHorasSuenho(hsHold);
                    }
                }
                else
                {
                    int a = _hsws.insertarHorasSuenho(hsHold);
                }
                panelInHorasSuenho.Enabled = true;
                //actualizarTabla con DataSource
                cargarHorasSuenho();

            }else
            {
                frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Horas incorrectas", "La cantidad de horas debe ser un número positivo menor a 24");
                _frmmba.ShowDialog();
                panelInHorasSuenho.Enabled = true;
            }
        }

        private void cargarHorasSuenho()
        {
            try
            {
                horasSunLista = _hsws.listarHorasSuenPorAlum(Common.Session.UserID);
                if (horasSunLista != null)
                    dgvHorasSuenho.DataSource = new BindingList<HorasSuenhoWS.horasSuenho>(horasSunLista);
                panel5.Controls.Clear();
                ucWebView wvHorasSueno = new ucWebView();
                wvHorasSueno.Dock = DockStyle.Fill;
                wvHorasSueno.URL = "http://ws.pucpsaludable.ml/da_sleep.php?uid=" + Common.Session.UserID;
                panel5.Controls.Add(wvHorasSueno);
            }
            catch (Exception exce)
            {
                tbHorasSueno.Text = "NoHayDatos?";
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
        {//NO SON NECESARIOS CAMBIOS
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
                tbPesoHabitual.Text = "Null";
            }
        }
    }
}
