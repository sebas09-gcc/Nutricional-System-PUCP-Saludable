using PUCPSaludable.Alumno.Citas.Controles;
using PUCPSaludable.Controles;
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

namespace PUCPSaludable.Alumno.Citas
{
    public partial class frmCitasAlumno : Form
    {
        private bool noNutricionistas = false;
        TableLayoutPanel tlpCarga1 = new TableLayoutPanel();
        TableLayoutPanel tlpCarga2 = new TableLayoutPanel();
        private BackgroundWorker bWObtenerCitas;
        private BackgroundWorker bwObtenerHorasAtencion;
        private DateTime _fechaHoraSeleccionada;
        private DateTime _fechaHoraAuxiliar;
        private CitasWS.CitasServiceClient _cws = new CitasWS.CitasServiceClient();
        private NutricionistaWS.NutricionistaServiceClient _nws = new NutricionistaWS.NutricionistaServiceClient();
        public frmCitasAlumno()
        {
            inicializarBackgroundWorkers();
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is TableLayoutPanel || c is Panel)
                {
                    DBuff(c);
                }
            }
            cbEspecialista.DisplayMember = "nombreCompleto";
            cbEspecialista.ValueMember = "id_usuario";
            CitasWS.nutricionista [] nuttr = _cws.getNutritionists();
            if (nuttr != null)
            {
                cbEspecialista.DataSource = new BindingList<CitasWS.nutricionista>(nuttr);
                labLugar.Text = ((CitasWS.especialistaSalud)cbEspecialista.SelectedItem).direccionLaboral.Split('#')[0];
            }
            else
            {
                noNutricionistas = true;
            }
    btnReservar.Enabled = false;
        }

        private void frmCitasAlumno_Load(object sender, EventArgs e)
        {
            panHistorial.Controls.Clear();
            panProgramadas.Controls.Clear();
            Common.LoadingAnimation.Show(panProgramadas, tlpCarga1);
            Common.LoadingAnimation.Show(panHistorial, tlpCarga2);
            bWObtenerCitas.RunWorkerAsync();
            ucFecha.FechaInicio = DateTime.Now;
            ucFecha.Fecha = DateTime.Now;
            ucFecha.FechaFin = DateTime.Now.AddDays(14);
            ucFecha.Actualizar();
            ucFecha.FirstTime = false;
            flpHoras.Controls.Clear();
        }

        private void inicializarBackgroundWorkers()
        {
            // Obtener citas programadas e históricas
            bWObtenerCitas = new BackgroundWorker();
            bWObtenerCitas.WorkerSupportsCancellation = true;
            bWObtenerCitas.DoWork += new DoWorkEventHandler(obtenerCitas_DoWork);
            bWObtenerCitas.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerCitas_RunWorkerCompleted);
            // Obtener horas de atención
            bwObtenerHorasAtencion = new BackgroundWorker();
            bwObtenerHorasAtencion.WorkerSupportsCancellation = true;
            bwObtenerHorasAtencion.DoWork += new DoWorkEventHandler(obtenerHorasAtencion_DoWork);
            bwObtenerHorasAtencion.RunWorkerCompleted += new RunWorkerCompletedEventHandler(obtenerHorasAtencion_RunWorkerCompleted);
        }

        private void seleccionarHora(object sender, EventArgs e)
        {
            limpiarHoras();
            MaterialSkin.Controls.MaterialButton btn = sender as MaterialSkin.Controls.MaterialButton;
            btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            _fechaHoraAuxiliar = (DateTime) btn.Tag;
            if (cbEspecialista.SelectedIndex > -1 && _fechaHoraSeleccionada != null)
            {
                btnReservar.Enabled = true;
            }
            else
            {
                btnReservar.Enabled = false;
            }
        }
        private void limpiarHoras()
        {
            foreach (Control c in flpHoras.Controls)
            {
                if (c is MaterialSkin.Controls.MaterialButton)
                {
                    ((MaterialSkin.Controls.MaterialButton)c).Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
                }
            }
        }

        private void obtenerHorasAtencion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bwObtenerHorasAtencion.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                (int, DateTime) f = ((int, DateTime)) e.Argument;
                e.Result = _cws.getAvailableAppointments(f.Item1, f.Item2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void obtenerHorasAtencion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            flpHoras.Controls.Clear();
            DateTime[] horas = (DateTime[]) e.Result;
            if (horas != null)
            {
                foreach (DateTime hora in horas)
                {
                    MaterialSkin.Controls.MaterialButton btnHora = new MaterialSkin.Controls.MaterialButton();
                    btnHora.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
                    btnHora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                    btnHora.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                    btnHora.Depth = 0;
                    btnHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnHora.HighEmphasis = true;
                    btnHora.Margin = new System.Windows.Forms.Padding(2);
                    btnHora.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
                    btnHora.Size = new System.Drawing.Size(64, 36);
                    btnHora.Text = hora.ToString("HH:mm");
                    btnHora.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
                    btnHora.UseAccentColor = true;
                    btnHora.UseVisualStyleBackColor = true;
                    btnHora.Tag = hora;
                    btnHora.Click += new System.EventHandler(this.seleccionarHora);
                    flpHoras.Controls.Add(btnHora);
                }
            }
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
                CitasWS.cita[] citasH = _cws.listarCitaHistoricaPorID(Common.Session.UserID);
                BindingList<string> nombreEspH = new BindingList<string>();
                if(citasH != null)
                {
                    foreach (CitasWS.cita c in citasH)
                    {
                        NutricionistaWS.nutricionista[] nutri = _nws.listarNutricionistaID(c.fid_especialista);
                        if (nutri != null)
                        {
                            nombreEspH.Add(nutri[0].nombreCompleto);
                        }
                        else
                        {
                            nombreEspH.Add("-");
                        }
                    }
                }
                e.Result = new Tuple<Tuple<CitasWS.cita[], CitasWS.cita[]>, Tuple<BindingList<string>, BindingList<string>>>(new Tuple<CitasWS.cita[], CitasWS.cita[]>(citasP, citasH), new Tuple<BindingList<string>, BindingList<string>>(lugarP, nombreEspH));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void obtenerCitas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Tuple<Tuple<CitasWS.cita[], CitasWS.cita[]>, Tuple<BindingList<string>, BindingList<string>>> citas = (Tuple<Tuple<CitasWS.cita[], CitasWS.cita[]>, Tuple<BindingList<string>, BindingList<string>>>) e.Result;
            Tuple<CitasWS.cita[], CitasWS.cita[]> r1 = citas.Item1;
            Tuple<BindingList<string>, BindingList<string>> r2 = citas.Item2;
            string[] lugar = r2.Item1.ToArray();
            string[] especialista = r2.Item2.ToArray();
            if (r1.Item1 != null)
            {
                panProgramadas.Controls.Clear();
                int i = 0;
                foreach (CitasWS.cita c in r1.Item1)
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
                    panProgramadas.Controls.Add(ch);
                    i++;
                }
            }
            else
            {
                TableLayoutPanel tlpNoData = new TableLayoutPanel();
                Common.NoData.Show(panProgramadas, tlpNoData, "No tienes citas programadas", "Tus citas programadas se mostrarán aquí cuando se registren");
            }
            if (r1.Item2 != null)
            {
                panHistorial.Controls.Clear();
                int i = 0;
                foreach (CitasWS.cita c in r1.Item2)
                {
                    ucCitaHist ch = new ucCitaHist();
                    ch.Cita = c;
                    ch.Dock = DockStyle.Top;
                    ch.Fecha = c.fechaHoraAtencion;
                    ch.Especialista = especialista[i];
                    switch (c.estado)
                    {
                        case 2:
                            ch.Check = ECheck.Uncheck;
                            break;
                        case 3:
                            ch.Check = ECheck.Uncheck;
                            break;
                    }
                    if(ch.Fecha < DateTime.Now)
                        ch.Check = ECheck.Uncheck;
                    panHistorial.Controls.Add(ch);
                    i++;
                }

            }
            else
            {
                TableLayoutPanel tlpNoData = new TableLayoutPanel();
                Common.NoData.Show(panProgramadas, tlpNoData, "No tienes citas históricas", "Tus citas históricas se mostrarán aquí cuando se registren");
            }
            Common.LoadingAnimation.Hide(panProgramadas, tlpCarga1);
            Common.LoadingAnimation.Hide(panHistorial, tlpCarga2);
        }
        private void ucCitaProg_Deleted(object sender, EventArgs e)
        {
            tlpCarga1 = new TableLayoutPanel();
            tlpCarga2 = new TableLayoutPanel();
            panProgramadas.Controls.Clear();
            panHistorial.Controls.Clear();
            Common.LoadingAnimation.Show(panProgramadas, tlpCarga1);
            Common.LoadingAnimation.Show(panHistorial, tlpCarga2);
            if (bWObtenerCitas.IsBusy)
            {
                bWObtenerCitas.CancelAsync();
            }
            else
            {
                bWObtenerCitas.RunWorkerAsync();
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            _fechaHoraSeleccionada = ucFecha.Fecha;
            _fechaHoraSeleccionada = _fechaHoraSeleccionada.Add(new TimeSpan(_fechaHoraAuxiliar.Hour, _fechaHoraAuxiliar.Minute, 0));
            CitasWS.cita cita = new CitasWS.cita();
            cita.fechaHoraAtencion = _fechaHoraSeleccionada;
            cita.fechaHoraAtencionSpecified = true;
            cita.referencia = tbMotivo.Text;
            cita.fid_alumno = Common.Session.UserID;
            cita.fid_especialista = ((CitasWS.especialista) cbEspecialista.SelectedItem).id_usuario;
            _cws.registerAppointment(cita);
            frmRegistrarCita1 _fcar = new frmRegistrarCita1(cita, (CitasWS.especialistaSalud)cbEspecialista.SelectedItem);
            if (_fcar.ShowDialog() == DialogResult.OK)
            {
                limpiarHoras();
                frmRegistrarCita2 _frm = new frmRegistrarCita2();
                _frm.ShowDialog();
                if (_frm.DialogResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
                panHistorial.Controls.Clear();
                panProgramadas.Controls.Clear();
                tlpCarga1 = new TableLayoutPanel();
                tlpCarga2 = new TableLayoutPanel();
                Common.LoadingAnimation.Show(panProgramadas, tlpCarga1);
                Common.LoadingAnimation.Show(panHistorial, tlpCarga2);
                if (bWObtenerCitas.IsBusy)
                {
                    bWObtenerCitas.CancelAsync();
                }
                else
                {
                    bWObtenerCitas.RunWorkerAsync();
                }
                limpiarHoras();
                if (bwObtenerHorasAtencion.IsBusy)
                {
                    bwObtenerHorasAtencion.CancelAsync();
                }
                else
                {
                    bwObtenerHorasAtencion.RunWorkerAsync(argument: (((CitasWS.especialista)cbEspecialista.SelectedItem).id_usuario, ucFecha.Fecha));
                }
                tbMotivo.Text = "";
            }
        }

        private void cbEspecialista_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReservar.Enabled = false;
            flpHoras.Controls.Clear();
            labLugar.Text = ((CitasWS.especialistaSalud) cbEspecialista.SelectedItem).direccionLaboral;
            if (bwObtenerHorasAtencion.IsBusy)
            {
                bwObtenerHorasAtencion.CancelAsync();
            }
            else
            {
                bwObtenerHorasAtencion.RunWorkerAsync(argument: (((CitasWS.especialista)cbEspecialista.SelectedItem).id_usuario, ucFecha.Fecha));
            }
        }
        private void ucFecha_DateChanged(object sender, EventArgs e)
        {
            flpHoras.Controls.Clear();
            if (!noNutricionistas)
            {
                if (bwObtenerHorasAtencion.IsBusy)
                {
                    bwObtenerHorasAtencion.CancelAsync();
                }
                else
                {
                    bwObtenerHorasAtencion.RunWorkerAsync(argument: (((CitasWS.especialista)cbEspecialista.SelectedItem).id_usuario, ucFecha.Fecha));
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

        public static void DBuff(System.Windows.Forms.Control control)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                return;
            }
            System.Reflection.PropertyInfo propInf = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propInf.SetValue(control, true, null);
        }

    }
}
