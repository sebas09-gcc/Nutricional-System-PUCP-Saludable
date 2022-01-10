using PUCPSaludable.Alumno.Citas.Controles;
using PUCPSaludable.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Nutricionista
{
    public partial class frmCitasNutricionista : Form
    {
        TableLayoutPanel tlpCarga1, tlpCarga2, tlpCarga3;
        private CitasWS.CitasServiceClient _cws = new CitasWS.CitasServiceClient();
        private AlumnoWS.AlumnoServiceClient _alm = new AlumnoWS.AlumnoServiceClient();
        private IngredienteWS.IngredienteServiceClient _ing = new IngredienteWS.IngredienteServiceClient();
        private NutricionistaWS.NutricionistaServiceClient _nutri = new NutricionistaWS.NutricionistaServiceClient();
        private BackgroundWorker bWCitasHistoricas, bWCitasProgramadas, bWAlimentos, bWCitasAlumno;
        private static int idAnt;

        private CitasWS.cita citaCargada;
        public frmCitasNutricionista()
        {
            idAnt = -1;
            inicializarBackgroundWorkers();
            InitializeComponent();
            tlpPrincipal.Visible = false;
            actualizarHistYProg();
        }
        private void inicializarBackgroundWorkers()
        {
            // Obtener citas históricas
            bWCitasHistoricas = new BackgroundWorker();
            bWCitasHistoricas.WorkerSupportsCancellation = true;
            bWCitasHistoricas.DoWork += new DoWorkEventHandler(obtenerCitasHistoricas_DoWork);
            bWCitasHistoricas.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerCitasHistoricas_RunWorkerCompleted);

            // Obtener citas programadas
            bWCitasProgramadas = new BackgroundWorker();
            bWCitasProgramadas.WorkerSupportsCancellation = true;
            bWCitasProgramadas.DoWork += new DoWorkEventHandler(obtenerCitasProgramadas_DoWork);
            bWCitasProgramadas.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerCitasProgramadas_RunWorkerCompleted);

            // Obtener alimentos de un paciente
            bWAlimentos = new BackgroundWorker();
            bWAlimentos.WorkerSupportsCancellation = true;
            bWAlimentos.DoWork += new DoWorkEventHandler(obtenerAlimentos_DoWork);
            bWAlimentos.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerAlimentos_RunWorkerCompleted);

            // Obtener citas de un paciente
            bWCitasAlumno = new BackgroundWorker();
            bWCitasAlumno.WorkerSupportsCancellation = true;
            bWCitasAlumno.DoWork += new DoWorkEventHandler(obtenerCitasAlumno_DoWork);
            bWCitasAlumno.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerCitasAlumno_RunWorkerCompleted);
        }
        private void obtenerCitasProgramadas_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWCitasProgramadas.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                CitasWS.cita[] citasP = _cws.listarCitaProgramadaNutricionistaPorID(Common.Session.UserID);
                BindingList<string> alumnosP = new BindingList<string>();
                if (citasP != null)
                {
                    foreach (CitasWS.cita c in citasP)
                    {
                        AlumnoWS.alumno[] alumno = _alm.listarAlumnoID(c.fid_alumno);
                        if (alumno != null)
                        {
                            alumnosP.Add(alumno[0].nombreCompleto);
                        }
                        else
                        {
                            alumnosP.Add("-");
                        }
                    }
                }
                e.Result = new Tuple<CitasWS.cita[], BindingList<string>>(citasP, alumnosP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void obtenerCitasProgramadas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Tuple<CitasWS.cita[], BindingList<string>> citas = (Tuple<CitasWS.cita[], BindingList<string>>) e.Result;
            string[] alumnos = citas.Item2.ToArray();
            if (citas.Item1 != null)
            {
                int i = 0;
                foreach (CitasWS.cita c in citas.Item1)
                {
                    ucCitaProgNutri ch = new ucCitaProgNutri();
                    ch.IDalm = c.fid_alumno;
                    ch.Dock = DockStyle.Top;
                    ch.Fecha = c.fechaHoraAtencion;
                    ch.Lugar += alumnos[i];
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
                    MaterialSkin.Controls.MaterialButton btn = new MaterialSkin.Controls.MaterialButton();
                    btn.Click += new System.EventHandler(btn_Click);
                    ch.insertarBoton(btn, c);
                    panCitasProg.Controls.Add(ch);
                    i++;
                }
            }
            Common.LoadingAnimation.Hide(panCitasProg, tlpCarga2);
        }
        private void obtenerCitasHistoricas_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWCitasHistoricas.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                CitasWS.cita[] citasH = _cws.listarCitaHistoricaNutricionistaPorID(Common.Session.UserID);
                BindingList<string> alumnosH = new BindingList<string>();
                if (citasH != null)
                {
                    foreach (CitasWS.cita c in citasH)
                    {
                        AlumnoWS.alumno[] alumno = _alm.listarAlumnoID(c.fid_alumno);
                        if (alumno != null)
                        {
                            alumnosH.Add(alumno[0].nombreCompleto);
                        }
                        else
                        {
                            alumnosH.Add("-");
                        }
                    }
                }
                e.Result = new Tuple<CitasWS.cita[], BindingList<string>>(citasH, alumnosH);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void obtenerCitasHistoricas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Tuple<CitasWS.cita[], BindingList<string>> citas = (Tuple<CitasWS.cita[], BindingList<string>>) e.Result;
            string[] alumnos = citas.Item2.ToArray();
            if (citas.Item1 != null)
            {
                int i = 0;
                foreach (CitasWS.cita c in citas.Item1)
                {
                    ucCitaHistNutri ch = new ucCitaHistNutri();
                    ch.IDalm = c.fid_alumno;
                    ch.Dock = DockStyle.Top;
                    ch.Fecha = c.fechaHoraAtencion;
                    ch.Especialista += alumnos[i];
                    switch (c.estado)
                    {
                        case 2:
                            ch.Check = ECheck.Uncheck;
                            break;
                        case 3:
                            ch.Check = ECheck.Uncheck;
                            break;
                    }
                    MaterialSkin.Controls.MaterialButton btn = new MaterialSkin.Controls.MaterialButton();
                    btn.Click += new System.EventHandler(btn_Click);
                    ch.insertarBoton(btn, c);
                    panCItasHist.Controls.Add(ch);
                    i++;
                }
            }
            Common.LoadingAnimation.Hide(panCItasHist, tlpCarga1);
        }
        private void obtenerAlimentos_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWAlimentos.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                int id = (int) e.Argument;
                IngredienteWS.ingrediente[] listIngPref = _ing.listarIngredientesPrefAl(id, 1);
                IngredienteWS.ingrediente[] listIngNoPref = _ing.listarIngredientesPrefAl(id, 0);
                IngredienteWS.ingrediente[] listIngAleg = _ing.listarIngredientesPrefAl(id, 2);
                e.Result = (listIngPref, listIngNoPref, listIngAleg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void obtenerAlimentos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            (IngredienteWS.ingrediente[], IngredienteWS.ingrediente[], IngredienteWS.ingrediente[]) alimentos = ((IngredienteWS.ingrediente[], IngredienteWS.ingrediente[], IngredienteWS.ingrediente[])) e.Result;
            IngredienteWS.ingrediente[] listIngPref = alimentos.Item1;
            IngredienteWS.ingrediente[] listIngNoPref = alimentos.Item2;
            IngredienteWS.ingrediente[] listIngAleg = alimentos.Item3;
            string listapref = "", nomIng, listaNopref = "", listaAleg = "";
            if (listIngPref != null)
            {
                foreach (IngredienteWS.ingrediente ing in listIngPref)
                {
                    nomIng = "-" + ing.nombre + "\n";
                    listapref = listapref + nomIng;
                }
                tbAlimentosGusta.Text = "";
                tbAlimentosGusta.Text = listapref;
            }
            else
            {
                tbAlimentosGusta.Text = "";
            }

            if (listIngNoPref != null)
            {
                foreach (IngredienteWS.ingrediente ing in listIngNoPref)
                {
                    nomIng = "-" + ing.nombre + "\n";
                    listaNopref = listaNopref + nomIng;
                }
                tbAlimentosDisgusta.Text = "";
                tbAlimentosDisgusta.Text = listaNopref;
            }
            else
            {
                tbAlimentosDisgusta.Text = "";
            }

            if (listIngAleg != null)
            {
                foreach (IngredienteWS.ingrediente ing in listIngAleg)
                {
                    nomIng = "-" + ing.nombre + "\n";
                    listaAleg = listaAleg + nomIng;
                }
                tbAlimentosAlergias.Text = "";
                tbAlimentosAlergias.Text = listaAleg;
            }
            else
            {
                tbAlimentosAlergias.Text = "";
            }
        }

        private void obtenerCitasAlumno_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWAlimentos.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                int id = (int)e.Argument;
                CitasWS.cita[] citasH = _cws.listarCitaHistoricaPorID(id);
                BindingList<string> nutriP = new BindingList<string>();
                if (citasH != null)
                {
                    foreach (CitasWS.cita c in citasH)
                    {
                        NutricionistaWS.nutricionista[] nutri = _nutri.listarNutricionistaID(c.fid_especialista);
                        if (nutri != null)
                        {
                            nutriP.Add(nutri[0].direccionLaboral.Split('#')[0]);
                        }
                        else
                        {
                            nutriP.Add("-");
                        }
                    }
                }
                e.Result = (citasH, nutriP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void obtenerCitasAlumno_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            (CitasWS.cita[], BindingList<string>) citas = ((CitasWS.cita[], BindingList<string>)) e.Result;
            string [] linutri = citas.Item2.ToArray();
            if (citas.Item1 != null)
            {
                int i = 0;
                foreach (CitasWS.cita c in citas.Item1)
                {
                    ucCitaHist ch = new ucCitaHist();
                    ch.Cita = c;
                    ch.Dock = DockStyle.Top;
                    ch.Fecha = c.fechaHoraAtencion;
                    ch.Especialista += "Atendido por ";
                    ch.Especialista += linutri[i];
                    switch (c.estado)
                    {
                        case 2:
                            ch.Check = ECheck.Uncheck;
                            break;
                        case 3:
                            ch.Check = ECheck.Uncheck;
                            break;
                    }
                    panHistorialCitas.Controls.Add(ch);
                    i++;
                }
            }
            Common.LoadingAnimation.Hide(panHistorialCitas, tlpCarga3);
        }

        private void listarCitasProgramadas()
        {
            tlpCarga2 = new TableLayoutPanel();
            Common.LoadingAnimation.Show(panCitasProg, tlpCarga2);
            if (bWCitasProgramadas.IsBusy)
            {
                bWCitasProgramadas.CancelAsync();
            }
            else
            {
                bWCitasProgramadas.RunWorkerAsync();
            }
        }
        private void limpiarDetalleAlum()
        {
            tbAlimentosDisgusta.Text = "";
            tbAlimentosGusta.Text = "";
            tbAlimentosAlergias.Text = "";
        }
        private void listarCitasHistoricas()
        {
            tlpCarga1 = new TableLayoutPanel();
            Common.LoadingAnimation.Show(panCItasHist, tlpCarga1);
            if (bWCitasHistoricas.IsBusy)
            {
                bWCitasHistoricas.CancelAsync();
            }
            else
            {
                bWCitasHistoricas.RunWorkerAsync();
            }
        }
        private void actualizarHistYProg()
        {
            panCItasHist.Controls.Clear();
            panCitasProg.Controls.Clear();
            limpiarDetalleAlum();
            listarCitasHistoricas();
            listarCitasProgramadas();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            panHistorialCitas.Enabled = false;
            panCitasProg.Enabled = false;
            Button ucC = sender as Button;
            CitasWS.cita CITALM = (CitasWS.cita)ucC.Tag;
            labFechaCita.Text = CITALM.fechaHoraAtencion.Date.ToString();
            labHoraCita.Text = CITALM.fechaHoraAtencion.TimeOfDay.ToString();
            tbDetalleClinico.Text = CITALM.diagnostico;
            if (CITALM.fid_alumno != idAnt)
            {
                tlpPrincipal.Visible = true;
                limpiarDetalleAlum();
                listarCitasHistoricas(CITALM.fid_alumno);
                AlumnoWS.alumno [] alum = _alm.listarAlumnoID(CITALM.fid_alumno);
                lanNombrePaciente.Text = alum[0].nombres + " " + alum[0].apellidos;
                labEdad.Text = "Edad: " + (DateTime.Now.Year - alum[0].fechaNacimiento.Year);
                try
                {
                    MemoryStream ms1 = new MemoryStream(alum[0].fotoSrc);
                    pbFoto.Image = new Bitmap(ms1);
                }
                catch
                {
                    pbFoto.Image = Properties.Resources.Persona;
                }
                idAnt = CITALM.fid_alumno;
                citaCargada = CITALM;

                if (bWAlimentos.IsBusy)
                {
                    bWAlimentos.CancelAsync();
                }
                else
                {
                    bWAlimentos.RunWorkerAsync(argument: CITALM.fid_alumno);
                }
            }
            panHistorialCitas.Enabled = true;
            panCitasProg.Enabled = true;
        }


        private void listarCitasHistoricas(int id)
        {
            tlpCarga3 = new TableLayoutPanel();
            panHistorialCitas.Controls.Clear();
            Common.LoadingAnimation.Show(panHistorialCitas, tlpCarga3);
            if (bWCitasAlumno.IsBusy)
            {
                bWCitasAlumno.CancelAsync();
            }
            else
            {
                bWCitasAlumno.RunWorkerAsync(argument: id);
            }
        }

        private void btnAnhadirHistorialClinico_Click(object sender, EventArgs e)
        {
            frmIndicadoresNutriAl frminal = new frmIndicadoresNutriAl(idAnt);
            frminal.ShowDialog();
        }

        private void btnAnhadirPlanAlimentario_Click(object sender, EventArgs e)
        {
            if (idAnt != -1) { 
            frmPlanAlimentarioNutricionista frmPlanA = new frmPlanAlimentarioNutricionista(idAnt);
            frmPlanA.ShowDialog();
            }
        }

        private void btnRegistrarAtencion_Click(object sender, EventArgs e)
        {
            tlpEventos.Enabled = false;
            citaCargada.diagnostico = tbDetalleClinico.Text;
            citaCargada.estado = 1;
            _cws.modificarCita(citaCargada);
            // Volver a cargar las listas
            panCItasHist.Controls.Clear();
            panCitasProg.Controls.Clear();
            panHistorialCitas.Controls.Clear();
            listarCitasHistoricas();
            listarCitasProgramadas();
            listarCitasHistoricas(citaCargada.fid_alumno);
            tlpEventos.Enabled = true;
        }
    }
}
