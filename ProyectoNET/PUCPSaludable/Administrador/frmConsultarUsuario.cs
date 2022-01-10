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

namespace PUCPSaludable.Administrador
{
    public partial class frmConsultarUsuario : Form
    {
        private AdministradorWS.usuario _usr;
        public frmConsultarUsuario(AdministradorWS.usuario usr)
        {
            InitializeComponent();
            _usr = usr;
            labApellidoT.Text = usr.apellidos;
            labNombreT.Text = usr.nombres;
            labCodigoT.Text = usr.codigoPUCP;
            labEmailT.Text = usr.emailPUCP;
            this.Text = "Usuario - " + usr.nombreCompleto;
            try
            {
                MemoryStream ms1 = new MemoryStream(usr.fotoSrc);
                pbFoto.Image = new Bitmap(ms1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (usr is AdministradorWS.alumno)
            {
                labRolT.Text = "Alumno";
            }
            else if (usr is AdministradorWS.nutricionista)
            {
                labRolT.Text = "Nutricionista";
            }
            else
            {
                labRolT.Text = "Desconocido";
            }
        }
    }
}
