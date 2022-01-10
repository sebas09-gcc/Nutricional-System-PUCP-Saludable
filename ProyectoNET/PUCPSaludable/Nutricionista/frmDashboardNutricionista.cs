using PUCPSaludable.Alumno.Citas.Controles;
using PUCPSaludable.Controles;
using PUCPSaludable.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Nutricionista
{
    public partial class frmDashboardNutricionista : Form
    {
        TableLayoutPanel tlpCarga1 = new TableLayoutPanel();
        private BackgroundWorker bWObtenerCitas;
        private AlumnoWS.AlumnoServiceClient _alm = new AlumnoWS.AlumnoServiceClient();
        private CitasWS.CitasServiceClient _cws = new CitasWS.CitasServiceClient();
        private EspecialistaWS.EspecialistaServiceClient _ews = new EspecialistaWS.EspecialistaServiceClient();
        private NutricionistaWS.NutricionistaServiceClient _nws = new NutricionistaWS.NutricionistaServiceClient();
        NutricionistaWS.nutricionista[] nutri;

        
        private int alph = 0;

        public frmDashboardNutricionista()
        {
            inicializarBackgroundWorkers();
            InitializeComponent();
            wvCitasMes.URL = "http://ws.pucpsaludable.ml/dn_citas_mes.php?uid=" + Common.Session.UserID;
            wvIMCEspecialidad.URL = "http://ws.pucpsaludable.ml/dn_imc_prom_esp.php";
            wvIMCCategoriaIMC.URL = "http://ws.pucpsaludable.ml/dn_imc_categoria.php";

            labSave.ForeColor = this.BackColor;
        }

        private void inicializarBackgroundWorkers()
        {
            // Obtener citas programadas e históricas
            bWObtenerCitas = new BackgroundWorker();
            bWObtenerCitas.WorkerSupportsCancellation = true;
            bWObtenerCitas.DoWork += new DoWorkEventHandler(obtenerCitas_DoWork);
            bWObtenerCitas.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerCitas_RunWorkerCompleted);
        }
        private void frmDashboardNutricionista_Load(object sender, EventArgs e)
        {
            Common.LoadingAnimation.Show(panEventos, tlpCarga1);
            nutri = _nws.listarNutricionistaID(Common.Session.UserID);
            labSaludo.Text = "¡Hola, " + nutri[0].nombres.Split(' ')[0] + "!";
            string [] vid = _ews.videoEspecialistaPorID(Common.Session.UserID);
            if (vid != null)
            {
                wvVideos.Source = new Uri(vid[0]);
            }
            else
            {
                wvVideos.Source = new Uri("https://www.youtube.com/embed/0a2miSscUNw");
            }
            bWObtenerCitas.RunWorkerAsync();

            String [] mensajeEspec = (_ews.mensajeEspecialistaPorID(Common.Session.UserID))[0].Split('#');
            this.tbTitulo.Text = mensajeEspec[0];
            this.tbMensaje.Text = mensajeEspec[1];

            this.labSave.Visible = false;
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
                CitasWS.cita[] citasP = _cws.listarCitaProgramadaNutricionistaPorID(Common.Session.UserID);
                BindingList<string> alumnoP = new BindingList<string>();
                if (citasP != null)
                {
                    foreach (CitasWS.cita c in citasP)
                    {
                        AlumnoWS.alumno[] alumno = _alm.listarAlumnoID(c.fid_alumno);
                        if (alumno != null)
                        {
                            alumnoP.Add(alumno[0].nombreCompleto);
                        }
                        else
                        {
                            alumnoP.Add("-");
                        }
                    }
                }
                e.Result = new Tuple<CitasWS.cita[], BindingList<string>>(citasP, alumnoP);
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
                string[] alumnos = citas.Item2.ToArray();
                panEventos.Controls.Clear();
                int i = 0;
                foreach (CitasWS.cita c in citas.Item1)
                {
                    ucCitaProg ch = new ucCitaProg();
                    ch.Cita = c;
                    ch.Dock = DockStyle.Top;
                    ch.Fecha = c.fechaHoraAtencion;
                    ch.Lugar = alumnos[i];
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
            Common.LoadingAnimation.Hide(panEventos, tlpCarga1);
        }



        private void listarCitasProgramadas()
        {
            CitasWS.cita[] citas = _cws.listarCitaProgramadaNutricionistaPorID(Common.Session.UserID);
            if (citas != null)
            {
                foreach (CitasWS.cita c in citas)
                {
                    ucCitaProg ch = new ucCitaProg();
                    ch.Dock = DockStyle.Top;
                    ch.Fecha = c.fechaHoraAtencion;
                    AlumnoWS.alumno[] lial = _alm.listarAlumnoID(c.fid_alumno);
                    if (lial != null)
                    {
                        foreach (AlumnoWS.alumno nut in lial)
                        {
                            ch.Lugar += nut.nombreCompleto;
                        }
                    }
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
                }
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

        private void btnElegirVideo_Click(object sender, EventArgs e)
        {
            frmElegirVideo fev = new frmElegirVideo();
            fev.ShowDialog();
            if (fev.DialogResult == DialogResult.OK)
            {
                wvVideos.Source = new Uri(fev.VideoURL);
                _ews.agregarVideo(Common.Session.UserID, fev.VideoURL);
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            int result = _ews.agregarMensaje(Common.Session.UserID, tbTitulo.Text, tbMensaje.Text);
            if (result == 1) {
                this.labSave.Visible = true;
                this.labSave.Text = "Mensaje guardado correctamente";
                wait(10000);
                this.labSave.Visible = false;
            }
        }

        public void wait(int msec)
        {
            var setInterval = new System.Windows.Forms.Timer();
            if (msec == 0 || msec < 0)
            {
                return;
            }
            setInterval.Interval = msec;
            setInterval.Enabled = true;
            setInterval.Start();
            setInterval.Tick += (s, e) =>
            {
                setInterval.Enabled = false;
                setInterval.Stop();
            };
            while (setInterval.Enabled)
            {
                Application.DoEvents();
            }
        }





    }
}
