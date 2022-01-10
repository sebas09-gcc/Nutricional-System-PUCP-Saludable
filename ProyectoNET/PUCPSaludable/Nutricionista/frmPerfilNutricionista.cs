using MaterialSkin;
using PUCPSaludable.Common;
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

namespace PUCPSaludable.Nutricionista
{
    public partial class frmPerfilNutricionista : Form
    {
        private Estado _estado;
        private AutenticacionWS.AutenticacionClient _psws;
        private NutricionistaWS.NutricionistaServiceClient _nutricionistaDAO;
        private NutricionistaWS.nutricionista[] nutricionistas;
        private AutenticacionWS.AutenticacionClient _espe = new AutenticacionWS.AutenticacionClient();

        public frmPerfilNutricionista()
        {
            InitializeComponent();
            establecerValores();
        }

        public void establecerValores()
        {
            _estado = Estado.Inicial;
            _psws = new AutenticacionWS.AutenticacionClient();
            _nutricionistaDAO = new NutricionistaWS.NutricionistaServiceClient();
            nutricionistas = _nutricionistaDAO.listarNutricionistaID(Common.Session.UserID);
            tbCodigo.Text = nutricionistas[0].codigoPUCP;
            tbApellidos.Text = nutricionistas[0].apellidos;
            tbNombres.Text = nutricionistas[0].nombres;
            tbEmailPUCP.Text = nutricionistas[0].emailPUCP;
            tbEmailPersonal.Text = nutricionistas[0].emailPersonal;
            tbColegiatura.Text = nutricionistas[0].colegiatura;
            tbDireccionLaboral.Text = nutricionistas[0].direccionLaboral;
            tbTelefonoLaboral.Text = nutricionistas[0].telefonoLaboral;
            ucFechaNacimiento.Fecha = nutricionistas[0].fechaNacimiento;
            try { tbEmailPersonal.Text = nutricionistas[0].emailPersonal; } catch { }
            ushort sexo = nutricionistas[0].sexo;
            if (sexo == 'M') rbHombre.Checked = true;
            else if (sexo == 'F') rbMujer.Checked = true;
            else rbOtro.Checked = true;
            try
            {
                MemoryStream ms1 = new MemoryStream(nutricionistas[0].fotoSrc);
                pbFoto.Image = new Bitmap(ms1);
            }
            catch { }
            establecerEstadoComponentes();
        }


        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnElegirUbicacion.Enabled = false;
                    btEditar.Enabled = true;
                    btGuardar.Enabled = false;
                    btCancelar.Enabled = false;
                    btnCambiarFoto.Enabled = false;
                    tbCodigo.Enabled = false;
                    tbCodigo.ReadOnly = true;
                    tbApellidos.Enabled = false;
                    tbApellidos.ReadOnly = true;
                    tbNombres.Enabled = false;
                    tbNombres.ReadOnly = false;
                    tbEmailPUCP.Enabled = false;
                    tbEmailPUCP.ReadOnly = true;
                    tbEmailPersonal.Enabled = false;
                    tbEmailPersonal.ReadOnly = true;
                    pbFoto.Enabled = false;
                    ucFechaNacimiento.Enabled = false;
                    rbHombre.Enabled = false;
                    rbMujer.Enabled = false;
                    rbOtro.Enabled = false;
                    tbTelefonoLaboral.Enabled = false;
                    tbTelefonoLaboral.ReadOnly = true;
                    tbDireccionLaboral.Enabled = false;
                    tbDireccionLaboral.ReadOnly = true;
                    tbColegiatura.Enabled = false;
                    tbColegiatura.ReadOnly = true;
                    break;
                case Estado.Editar:
                    btnElegirUbicacion.Enabled = true;
                    btEditar.Enabled = false;
                    btGuardar.Enabled = true;
                    btCancelar.Enabled = true;
                    btnCambiarFoto.Enabled = true;
                    tbApellidos.Enabled = true;
                    tbApellidos.ReadOnly = false;
                    tbNombres.Enabled = true;
                    tbNombres.ReadOnly = false;
                    tbEmailPUCP.Enabled = true;
                    tbEmailPUCP.ReadOnly = false;
                    tbEmailPersonal.Enabled = true;
                    tbEmailPersonal.ReadOnly = false;
                    tbColegiatura.Enabled = true;
                    tbColegiatura.ReadOnly = false;
                    pbFoto.Enabled = true;
                    ucFechaNacimiento.Enabled = true;
                    rbHombre.Enabled = true;
                    rbMujer.Enabled = true;
                    rbOtro.Enabled = true;  
                    tbTelefonoLaboral.Enabled = true;
                    tbTelefonoLaboral.ReadOnly = false;
                    tbDireccionLaboral.Enabled = true;
                    tbDireccionLaboral.ReadOnly = false;

                    break;

            }
        }


        private void btGuardar_Click_1(object sender, EventArgs e)
        {
            NutricionistaWS.nutricionista nu = new NutricionistaWS.nutricionista();
            nu.id_usuario = Common.Session.UserID;
            nu.codigoPUCP = tbCodigo.Text;
            nu.contrasena = nutricionistas[0].contrasena;
            nu.nombres = tbNombres.Text;
            nu.apellidos = tbApellidos.Text;
            nu.emailPUCP = tbEmailPUCP.Text;
            try
            {
                nu.emailPersonal = tbEmailPersonal.Text;
            }
            catch
            {
                nu.emailPersonal = "";
            }
            nu.telefonoMovil = "";
            nu.fechaNacimiento = ucFechaNacimiento.Fecha;
            nu.fechaNacimientoSpecified = true;

            if (rbHombre.Checked == true) nu.sexo = 'M';
            else if (rbMujer.Checked == true) nu.sexo = 'F';
            else nu.sexo = 'O';
            nu.fotoSrc = ImageToByteArray(pbFoto.Image);
            nu.estado = 1;
            nu.colegiatura = tbColegiatura.Text;
            nu.telefonoLaboral = tbTelefonoLaboral.Text;
            nu.direccionLaboral = tbDireccionLaboral.Text;
            nu.biografia = "";
            _nutricionistaDAO.modificarNutricionista(nu);
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Editar;
            establecerEstadoComponentes();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            establecerValores();
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            ofdElegirFoto.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (ofdElegirFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = new Bitmap(ofdElegirFoto.FileName);
            }
        }

        private void btnElegirUbicacion_Click(object sender, EventArgs e)
        {
            frmElegirUbicacion feu = new frmElegirUbicacion();
            if (feu.ShowDialog() == DialogResult.OK)
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                tbDireccionLaboral.Text = feu.MyLocation.Item3 + "#" + feu.MyLocation.Item1.ToString(provider) + "#" + feu.MyLocation.Item2.ToString(provider);
            }

        }
    }
}
