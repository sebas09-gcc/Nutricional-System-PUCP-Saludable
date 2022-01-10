using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Alumno
{
    public partial class frmIMCDashboard : Form
    {
        IndicadorAntropometricoWS.IndicadorAntropoServiceClient _iaws = new IndicadorAntropometricoWS.IndicadorAntropoServiceClient();
        private IndicadorAntropometricoWS.indicadorAntropometrico[] indicAntLista = null;

        public frmIMCDashboard()
        {
            InitializeComponent();
            indicAntLista = _iaws.listarIndicadorAntropomPorAlumno(Common.Session.UserID);
        }

        private void btnSumarDatosIMC_Click(object sender, EventArgs e)
        {
            double pesoHold,alturaHold;
            panel2.Enabled = false;

            IndicadorAntropometricoWS.indicadorAntropometrico iaHold = new IndicadorAntropometricoWS.indicadorAntropometrico();
            iaHold.fid_alumno = Common.Session.UserID;
            iaHold.fechaRegistro = DateTime.Now.Date;
            iaHold.fechaRegistroSpecified = true;
            
            bool weightIsParsable = Double.TryParse(tbPesoHabitual.Text, out pesoHold);
            bool heightIsParsable = Double.TryParse(tbEstatura.Text, out alturaHold);
            if (weightIsParsable && heightIsParsable && pesoHold > 0 && alturaHold > 0)
            {
                iaHold.estatura = alturaHold;
                iaHold.pesoHabitual = pesoHold;
                if (indicAntLista != null)
                {
                    if (indicAntLista[0].fechaRegistro.Equals(iaHold.fechaRegistro))
                    {
                        iaHold.id_indicadorAntropometrico = indicAntLista[0].id_indicadorAntropometrico;
                        int m = _iaws.modificarIndicadorAntropom(iaHold);
                        if (m != 0)
                        {
                            MessageBox.Show("Dato ingresado con exito");
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        int a = _iaws.insertarIndicadorAntropom(iaHold);
                        if (a != 0)
                        {
                            MessageBox.Show("Dato ingresado con exito");
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                {
                    int d = _iaws.insertarIndicadorAntropom(iaHold);
                    if (d != 0)
                    {
                        MessageBox.Show("Dato ingresado con exito");
                        this.DialogResult = DialogResult.OK;
                    }
                }


                //int a = _iaws.insertarIndicadorAntropom(iaHold);
                //if (a != 0)
                //{
                //    MessageBox.Show("Dato ingresado con exito");
                //    this.DialogResult = DialogResult.OK;
                //}
                //else MessageBox.Show("Dato incorrecto");
            }
            else
            {
                MessageBox.Show("Ingrese un numero decimal correcto");
            }
            panel2.Enabled = true;
        }
    }
}
