using PUCPSaludable.AlumnoWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Nutricionista
{
    public partial class frmBuscarAlumnos : Form
    {
        private BackgroundWorker bWBuscarAlumnos;
        private AlumnoWS.alumno alumnoSeleccionado;
        private AlumnoWS.AlumnoServiceClient _alumnoDAO = new AlumnoWS.AlumnoServiceClient();
        frmPerfilAlumnoNutricionista frmPerfilAlum = new frmPerfilAlumnoNutricionista();
        public frmBuscarAlumnos()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
            inicializarBackgroundWorkers();
        }

        private void inicializarBackgroundWorkers()
        {
            bWBuscarAlumnos = new BackgroundWorker();
            bWBuscarAlumnos.WorkerSupportsCancellation = true;
            bWBuscarAlumnos.DoWork += new DoWorkEventHandler(buscarAlumnos_DoWork);
            bWBuscarAlumnos.RunWorkerCompleted += new RunWorkerCompletedEventHandler(buscarAlumnos_RunWorkerCompleted);
        }
        public alumno AlumnoSeleccionado { get => alumnoSeleccionado; set => alumnoSeleccionado = value; }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            alumnoSeleccionado = (AlumnoWS.alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            frmPerfilAlum.establecerValores(alumnoSeleccionado);
            frmPerfilAlum.ShowDialog();
        }

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AlumnoWS.alumno alumno = (AlumnoWS.alumno)dgvAlumnos.Rows[e.RowIndex].DataBoundItem;
            dgvAlumnos.Rows[e.RowIndex].Cells[0].Value = alumno.nombres + " " +alumno.apellidos;
            dgvAlumnos.Rows[e.RowIndex].Cells[1].Value = alumno.codigoPUCP;
            dgvAlumnos.Rows[e.RowIndex].Cells[2].Value = alumno.emailPUCP;
            dgvAlumnos.Rows[e.RowIndex].Cells[3].Value = alumno.telefonoMovil;
        }

        private void tbNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
            {
                if (bWBuscarAlumnos.IsBusy)
                {
                    bWBuscarAlumnos.CancelAsync();
                }
                else
                {
                    bWBuscarAlumnos.RunWorkerAsync();
                }
            }
        }

        private void frmBuscarAlumnos_Load(object sender, EventArgs e)
        {
            bWBuscarAlumnos.RunWorkerAsync();
        }

        private void buscarAlumnos_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (bWBuscarAlumnos.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                string key = Regex.Replace(tbNombre.Text, "\\s+", "");
                e.Result = new BindingList<AlumnoWS.alumno>(_alumnoDAO.listarAlumnoNombreCodigo(key));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarAlumnos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvAlumnos.DataSource = (BindingList<AlumnoWS.alumno>)e.Result;
        }
    }
}
