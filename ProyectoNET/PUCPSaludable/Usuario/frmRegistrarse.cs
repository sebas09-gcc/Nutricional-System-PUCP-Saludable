using PUCPSaludable.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Usuario
{
    public partial class frmRegistrarse : Form
    {
        AutenticacionWS.AutenticacionClient _dao = new AutenticacionWS.AutenticacionClient();
        public frmRegistrarse()
        {
            InitializeComponent();
            btnVerificar.Enabled = false;
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if (_dao.verifyRegisteredUser(this.tbCodigo.Text) == 0)
            {
                frmVerificacion reg1 = new frmVerificacion(this.tbCodigo.Text);
                if (reg1.ShowDialog() == DialogResult.OK)
                {
                    frmRegistrarsePaso2 reg2 = new frmRegistrarsePaso2(this.tbCodigo.Text);
                    if (reg2.ShowDialog() == DialogResult.OK)
                    {
                        frmRegistrarsePaso3 reg3 = new frmRegistrarsePaso3();
                        if (reg3.ShowDialog() == DialogResult.OK)
                        {
                            switch (reg3.TipoEspecialista)
                            {
                                case "Alumno":
                                    frmRegistrarsePaso4Alumno reg4a = new frmRegistrarsePaso4Alumno();
                                    if (reg4a.ShowDialog() == DialogResult.OK)
                                    {
                                        AutenticacionWS.alumno alu = new AutenticacionWS.alumno();
                                        alu.especialidad = reg4a.Alumno.especialidad;
                                        alu.nombreContacto = reg4a.Alumno.nombreContacto;
                                        alu.parentezcoContacto = reg4a.Alumno.parentezcoContacto;
                                        alu.numContacto = reg4a.Alumno.numContacto;
                                        alu.nombres = reg2.Usuario.nombres;
                                        alu.apellidos = reg2.Usuario.apellidos;
                                        alu.codigoPUCP = reg2.Usuario.codigoPUCP;
                                        alu.contrasena = Common.Encrypt.Hash(reg2.Usuario.contrasena);
                                        alu.fechaNacimiento = reg2.Usuario.fechaNacimiento;
                                        alu.fechaNacimientoSpecified = true;
                                        alu.sexo = reg2.Usuario.sexo;
                                        alu.emailPUCP = reg2.Usuario.emailPUCP;
                                        alu.telefonoMovil = reg2.Usuario.telefonoMovil;
                                        _dao.registerAsStudent(alu);
                                        this.DialogResult = DialogResult.OK;
                                    }
                                    break;
                                case "Nutricionista":
                                    frmRegistrarsePaso4Nutricionista reg4n = new frmRegistrarsePaso4Nutricionista();
                                    if (reg4n.ShowDialog() == DialogResult.OK)
                                    {
                                        AutenticacionWS.nutricionista nut = reg4n.Nutricionista;
                                        nut.nombres = reg2.Usuario.nombres;
                                        nut.apellidos = reg2.Usuario.apellidos;
                                        nut.codigoPUCP = reg2.Usuario.codigoPUCP;
                                        nut.contrasena = Common.Encrypt.Hash(reg2.Usuario.contrasena);
                                        nut.fechaNacimiento = reg2.Usuario.fechaNacimiento;
                                        nut.fechaNacimientoSpecified = true;
                                        nut.sexo = reg2.Usuario.sexo;
                                        nut.emailPUCP = reg2.Usuario.emailPUCP;
                                        nut.telefonoLaboral = reg2.Usuario.telefonoMovil;
                                        int ret = _dao.registerAsNutricionist(nut);
                                        this.DialogResult = DialogResult.OK;
                                    }
                                    break;
                                default:
                                    frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Error al registrarse", "Rol desconocido");
                                    _frmmba.ShowDialog();
                                    this.DialogResult = DialogResult.Abort;
                                    break;
                            }
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
            else
            {
                frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("Error al iniciar sesión", "Usted ya se encuentra registrado. Intente iniciar sesión");
                _frmmba.ShowDialog();
            }
        }

        private void btnVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Length == 8)
            {
                btnVerificar.Enabled = true;
            }
            else
            {
                btnVerificar.Enabled = false;
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
