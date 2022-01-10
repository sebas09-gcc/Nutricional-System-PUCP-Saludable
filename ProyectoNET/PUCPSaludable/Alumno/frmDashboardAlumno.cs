using PUCPSaludable.Alumno.Citas.Controles;
using PUCPSaludable.Alumno.Nutricionista;
using PUCPSaludable.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Alumno
{
    public partial class frmDashboardAlumno : Form
    {
        TableLayoutPanel tlpCarga1 = new TableLayoutPanel();
        TableLayoutPanel tlpNoData = new TableLayoutPanel();
        private BackgroundWorker bWObtenerCitas;
        private CitasWS.CitasServiceClient _cws = new CitasWS.CitasServiceClient();
        private NutricionistaWS.NutricionistaServiceClient _nws = new NutricionistaWS.NutricionistaServiceClient();
        private AlumnoWS.AlumnoServiceClient _aws = new AlumnoWS.AlumnoServiceClient();
        private EspecialistaWS.EspecialistaServiceClient _ews = new EspecialistaWS.EspecialistaServiceClient();
        private CRutinaWS.CumplimientoRutinaServiceClient _crs = new CRutinaWS.CumplimientoRutinaServiceClient();
        private bool flag = false;

        public frmDashboardAlumno()
        {
            inicializarBackgroundWorkers();
            AlumnoWS.alumno al = new AlumnoWS.alumno();
            InitializeComponent();
            flag = false;
        }

        private void frmDashboardAlumno_Load(object sender, EventArgs e)
        {
            deshabilitarCheckboxes();
            ucWebView wvIMC = new ucWebView();
            wvIMC.Dock = DockStyle.Fill;
            wvIMC.URL = "http://ws.pucpsaludable.ml/da_imc.php?uid=" + Common.Session.UserID;
            panWvIMC.Controls.Add(wvIMC);
            ucWebView wvHorasSueno = new ucWebView();
            wvHorasSueno.Dock = DockStyle.Fill;
            wvHorasSueno.URL = "http://ws.pucpsaludable.ml/da_sleep.php?uid=" + Common.Session.UserID;
            panWvHorasSueno.Controls.Add(wvHorasSueno);
            ucYouTube wvVideos = new ucYouTube();
            wvVideos.Dock = DockStyle.Fill;
            string[] vid = _ews.listarVideos();
            if (vid != null)
            {
                wvVideos.Playlist = vid;
                wvVideos.Actual = 0;
            }
            else
            {
                string [] auxv = new string[] {"https://www.youtube.com/embed/0a2miSscUNw" };
                wvVideos.Playlist = auxv;
                wvVideos.Actual = 0;
            }
            panWvVideos.Controls.Add(wvVideos);
            ucWebView wvConsejos = new ucWebView();
            wvConsejos.Dock = DockStyle.Fill;
            wvConsejos.URL = "http://ws.pucpsaludable.ml/advice.php";
            panWvConsejos.Controls.Add(wvConsejos);
            panEventos.Controls.Clear();
            Common.LoadingAnimation.Show(panEventos, tlpCarga1);
            bWObtenerCitas.RunWorkerAsync();
            AlumnoWS.alumno[] alumno = _aws.listarAlumnoID(Common.Session.UserID);
            labSaludo.Text = "¡Hola, " + alumno[0].nombres.Split(' ')[0] + "!";
            Common.NoData.Show(panComidasHoy, tlpNoData, "No cuentas con un plan alimentario", "Luego de tu cita con el nutricionista, al abrir la app, encontrarás aquí tus comidas del día");
            listarUnaFecha();
        }

        private void inicializarBackgroundWorkers()
        {
            // Obtener citas programadas e históricas
            bWObtenerCitas = new BackgroundWorker();
            bWObtenerCitas.WorkerSupportsCancellation = true;
            bWObtenerCitas.DoWork += new DoWorkEventHandler(obtenerCitas_DoWork);
            bWObtenerCitas.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerCitas_RunWorkerCompleted);
        }

        private void obtenerCitas_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWObtenerCitas.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                CitasWS.cita[] citasP = _cws.listarCitaProgramadaPorID(Common.Session.UserID);
                BindingList<string> lugarP = new BindingList<string>();
                if(citasP != null)
                {
                    foreach (CitasWS.cita c in citasP)
                    {
                        NutricionistaWS.nutricionista[] nutri = _nws.listarNutricionistaID(c.fid_especialista);
                        if (nutri != null)
                        {
                            lugarP.Add(nutri[0].direccionLaboral.Split('#')[0]);
                        }
                        else
                        {
                            lugarP.Add("-");
                        }
                    }
                }
                e.Result = new Tuple<CitasWS.cita[], BindingList<string>>(citasP, lugarP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void obtenerCitas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Tuple<CitasWS.cita[], BindingList<string>> citas = (Tuple<CitasWS.cita[], BindingList<string>>)e.Result;
            if (citas.Item1 != null)
            {
                string[] lugar = citas.Item2.ToArray();
                panEventos.Controls.Clear();
                int i = 0;
                foreach (CitasWS.cita c in citas.Item1)
                {
                    ucCitaProg ch = new ucCitaProg();
                    ch.Cita = c;
                    ch.Dock = DockStyle.Top;
                    ch.Fecha = c.fechaHoraAtencion;
                    ch.Lugar = lugar[i];
                    ch.Deleted += new Deleted(this.ucCitaProg_Deleted);
                    if (c.fechaHoraAtencion.Date == DateTime.Now.Date)
                    {
                        ch.Programacion = EProgramacion.Hoy;
                    }
                    else if (c.fechaHoraAtencion.Date == DateTime.Now.AddDays(1).Date)
                    {
                        ch.Programacion = EProgramacion.Manana;
                    }
                    else
                    {
                        ch.Programacion = EProgramacion.Pronto;
                    }
                    panEventos.Controls.Add(ch);
                    i++;
                }
            }
            else
            {
                TableLayoutPanel tlpNoData = new TableLayoutPanel();
                Common.NoData.Show(panEventos, tlpNoData, "No tienes citas programadas", "Tus citas programadas se mostrarán aquí cuando se registren");
            }
            Common.LoadingAnimation.Hide(panEventos, tlpCarga1);
        }

        public void resetCumplimientoPlanAlimentario()
        {
            listarUnaFecha();
        }

        //cumplimiento rutina alimentaria dashboard

        private void habilitarCheckboxes()
        {
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

            labComidasHoy.Text = "No tiene registrado un plan alimentario";
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
        private void listarUnaFecha()
        {
            CRutinaWS.cumplimientoRutina[] cumplimientoRutinas = _crs.listarCumplimientoRutinaAlimentariaxAlumnoyFecha(Common.Session.UserID, DateTime.Now);
            CRutinaWS.cumplimientoRutina[] nombres = _crs.listarPlanAlimentarioNombreRecetasxAlumnoyFecha(Common.Session.UserID, DateTime.Now);
            habilitarCheckboxes();
            tlpNoData.Visible = false;
            tlpComidasDelDia.Visible = true;
            if (nombres != null)
            {
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
                tlpNoData.Visible = true;
                tlpComidasDelDia.Visible = false;
                flag = false;
                this.btnRegistarComida.Enabled = false;
            }
        }

        private void btnRegistarComida_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                this.btnRegistarComida.Enabled = false;
            }

            else
            {

                CRutinaWS.cumplimientoRutina[] cumplimientoRutinas = _crs.listarCumplimientoRutinaAlimentariaxAlumnoyFecha(Common.Session.UserID, DateTime.Now);

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
                    listarUnaFecha();
                }

                else
                {
                    cumplimientoRutinas = new CRutinaWS.cumplimientoRutina[5];

                    for (int i = 0; i < 5; i++)
                        cumplimientoRutinas[i] = new CRutinaWS.cumplimientoRutina();


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
                        cumplimientoRutinas[i].fecha = DateTime.Now.Date;
                        cumplimientoRutinas[i].fechaSpecified = true;
                        cumplimientoRutinas[i].tipoRutina = 0;
                        cumplimientoRutinas[i].tipoComida = i + 1;
                        cumplimientoRutinas[i].id_cumplimientoRutina = _crs.insertarCumplimientoRutinaAlimentaria(cumplimientoRutinas[i]);
                    }
                    
                    listarUnaFecha();

                }


            }

        }

        private void mbtnMeterHorasSue_Click(object sender, EventArgs e)
        {
            frmHorasSueDashboard frmHSD = new frmHorasSueDashboard();
            frmHSD.ShowDialog();
            if(frmHSD.DialogResult == DialogResult.OK)
            {
                panWvHorasSueno.Controls.Clear();
                ucWebView wvHorasSueno = new ucWebView();
                wvHorasSueno.Dock = DockStyle.Fill;
                wvHorasSueno.URL = "http://ws.pucpsaludable.ml/da_sleep.php?uid=" + Common.Session.UserID;
                panWvHorasSueno.Controls.Add(wvHorasSueno);
            }
        }

        private void mbtnMeterIMC_Click(object sender, EventArgs e)
        {
            frmIMCDashboard frmIMC = new frmIMCDashboard();
            frmIMC.ShowDialog();
            if (frmIMC.DialogResult == DialogResult.OK)
            {
                panWvIMC.Controls.Clear();
                ucWebView wvIMC = new ucWebView();
                wvIMC.Dock = DockStyle.Fill;
                wvIMC.URL = "http://ws.pucpsaludable.ml/da_imc.php?uid=" + Common.Session.UserID;
                panWvIMC.Controls.Add(wvIMC);
            }
        }

        private void ucCitaProg_Deleted(object sender, EventArgs e)
        {
            tlpCarga1 = new TableLayoutPanel();
            panEventos.Controls.Clear();
            Common.LoadingAnimation.Show(panEventos, tlpCarga1);
            if (bWObtenerCitas.IsBusy)
            {
                bWObtenerCitas.CancelAsync();
            }
            else
            {
                bWObtenerCitas.RunWorkerAsync();
            }
        }
    }
}
