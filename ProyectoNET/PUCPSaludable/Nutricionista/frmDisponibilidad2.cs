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
    public partial class frmDisponibilidad2 : Form
    {

        private HorarioCitaWS.HorarioCitasServiceClient _hcs = new HorarioCitaWS.HorarioCitasServiceClient();
        Color _checkColor = System.Drawing.Color.FromArgb(41, 121, 255);
        Color _unCheckColor = System.Drawing.Color.White;

        private string[] horasIni = {  "08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
                                        "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00"};
        private string[] horasFin = {  "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00",
                                        "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00"};

        public frmDisponibilidad2()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is TableLayoutPanel || c is Panel)
                {
                    DBuff(c);
                }
            }
            tlpCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // Processing Code
            estadoInicial();
        }

        private void updateColor(System.Windows.Forms.CheckBox check) 
        {
            if (check.Checked == true)
            {
                check.BackColor = _checkColor;
                check.FlatAppearance.MouseDownBackColor = _checkColor;
            }
            else
            {
                check.BackColor = _unCheckColor;
                check.FlatAppearance.MouseDownBackColor = _unCheckColor;
            }
        }
        private void chbDom1_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom1);}
        private void chbDom2_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom2);}
        private void chbDom3_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom3);}
        private void chbDom4_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom4);}
        private void chbDom5_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom5);}
        private void chbDom6_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom6);}
        private void chbDom7_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom7);}
        private void chbDom8_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom8);}
        private void chbDom9_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom9);}
        private void chbDom10_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom10);}
        private void chbDom11_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom11);}
        private void chbDom12_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom12);}
        private void chbDom13_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom13);}
        private void chbDom14_CheckedChanged(object sender, EventArgs e) { updateColor(chbDom14);}
        private void chbLun1_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun1); }
        private void chbLun2_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun2); }
        private void chbLun3_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun3); }
        private void chbLun4_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun4); }
        private void chbLun5_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun5); }
        private void chbLun6_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun6); }
        private void chbLun7_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun7); }
        private void chbLun8_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun8); }
        private void chbLun9_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun9); }
        private void chbLun10_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun10); }
        private void chbLun11_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun11); }
        private void chbLun12_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun12); }
        private void chbLun13_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun13); }
        private void chbLun14_CheckedChanged(object sender, EventArgs e) { updateColor(chbLun14); }
        private void chbMar1_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar1); }
        private void chbMar2_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar2); }
        private void chbMar3_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar3); }
        private void chbMar4_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar4); }
        private void chbMar5_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar5); }
        private void chbMar6_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar6); }
        private void chbMar7_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar7); }
        private void chbMar8_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar8); }
        private void chbMar9_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar9); }
        private void chbMar10_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar10); }
        private void chbMar11_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar11); }
        private void chbMar12_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar12); }
        private void chbMar13_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar13); }
        private void chbMar14_CheckedChanged(object sender, EventArgs e) { updateColor(chbMar14); }
        private void chbMie1_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie1); }
        private void chbMie2_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie2); }
        private void chbMie3_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie3); }
        private void chbMie4_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie4); }
        private void chbMie5_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie5); }
        private void chbMie6_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie6); }
        private void chbMie7_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie7); }
        private void chbMie8_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie8); }
        private void chbMie9_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie9); }
        private void chbMie10_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie10); }
        private void chbMie11_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie11); }
        private void chbMie12_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie12); }
        private void chbMie13_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie13); }
        private void chbMie14_CheckedChanged(object sender, EventArgs e) { updateColor(chbMie14); }
        private void chbJue1_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue1); }
        private void chbJue2_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue2); }
        private void chbJue3_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue3); }
        private void chbJue4_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue4); }
        private void chbJue5_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue5); }
        private void chbJue6_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue6); }
        private void chbJue7_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue7); }
        private void chbJue8_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue8); }
        private void chbJue9_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue9); }
        private void chbJue10_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue10); }
        private void chbJue11_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue11); }
        private void chbJue12_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue12); }
        private void chbJue13_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue13); }
        private void chbJue14_CheckedChanged(object sender, EventArgs e) { updateColor(chbJue14); }
        private void chbVie1_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie1); }
        private void chbVie2_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie2); }
        private void chbVie3_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie3); }
        private void chbVie4_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie4); }
        private void chbVie5_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie5); }
        private void chbVie6_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie6); }
        private void chbVie7_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie7); }
        private void chbVie8_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie8); }
        private void chbVie9_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie9); }
        private void chbVie10_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie10); }
        private void chbVie11_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie11); }
        private void chbVie12_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie12); }
        private void chbVie13_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie13); }
        private void chbVie14_CheckedChanged(object sender, EventArgs e) { updateColor(chbVie14); }
        private void chbSab1_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab1); }
        private void chbSab2_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab2); }
        private void chbSab3_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab3); }
        private void chbSab4_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab4); }
        private void chbSab5_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab5); }
        private void chbSab6_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab6); }
        private void chbSab7_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab7); }
        private void chbSab8_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab8); }
        private void chbSab9_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab9); }
        private void chbSab10_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab10); }
        private void chbSab11_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab11); }
        private void chbSab12_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab12); }
        private void chbSab13_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab13); }
        private void chbSab14_CheckedChanged(object sender, EventArgs e) { updateColor(chbSab14); }
        

        //ESTADOS

        public void estadoInicial() {

            
            string fecha = listarHorario();//cargar el horario actual
            //aqui entra que cargue el dia en la descripcion
            labDetalleHorarioVigente.Text = fecha;



            labDetalleHorarioVigente.Enabled = true;

            btnNuevo.Enabled = true;
            materialCard1.Enabled = false;
            ucFecha1.Enabled = false;
            btnFecha.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            labDetalleNuevoHorario.Visible = false;

            //cargar horario actual
        }

        public void estadoRegistro() {
            
            btnNuevo.Enabled = false;
            labDetalleHorarioVigente.Enabled = false;

            //limpiar checks
            limpiarChecks();

            materialCard1.Enabled = false;
            ucFecha1.Enabled = true;
            btnFecha.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;


        }

        public void estadoFecha() {

            //if para verificar que la fecha sea correcta
            if (ucFecha1.Fecha <= DateTime.Now.Date) {
                //aca mandara el formulario de error
                string mensaje = "Ingrese una fecha correcta";
                string titulo = "Fecha menor a la actual";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, titulo, boton, MessageBoxIcon.Warning);
                return;
            }

            //aca debe cargarse la fecha del ucFecha al texto de detalle
            labDetalleNuevoHorario.Text = "Haga clic sobre las casillas para registrar su disponibilidad a partir de la fecha " + ucFecha1.Fecha.ToShortDateString();
            labDetalleNuevoHorario.Visible = true;
            materialCard1.Enabled = true;
            btnGuardar.Enabled = true;
        }

        public void estadoGuardar() {

            HorarioCitaWS.horario[] horarios = new HorarioCitaWS.horario[98];
            for (int i = 0, j = 0; i < 98; i++, j++) {
                horarios[i] = new HorarioCitaWS.horario();

                j = j % 14;
                horarios[i].fid_especialista = Common.Session.UserID;
                horarios[i].fechaHoraRegistro = ucFecha1.Fecha;
                horarios[i].fechaHoraRegistroSpecified = true;
                horarios[i].estado = 0;
                horarios[i].horarioInicio = DateTime.ParseExact(horasIni[j], "HH:mm:ss", CultureInfo.InvariantCulture);
                horarios[i].horarioInicioSpecified = true;
                horarios[i].horaFin = DateTime.ParseExact(horasFin[j], "HH:mm:ss", CultureInfo.InvariantCulture);
                horarios[i].horaFinSpecified = true;
                horarios[i].diaSemana = (i / 14);
                
            }


            //dia == 1              
            if(chbDom1.Checked == true){horarios[0].estado = 1;}                
            if(chbDom2.Checked == true){horarios[1].estado = 1;}                
            if(chbDom3.Checked == true){horarios[2].estado = 1;}                
            if(chbDom4.Checked == true){horarios[3].estado = 1;}                
            if(chbDom5.Checked == true){horarios[4].estado = 1;}                
            if(chbDom6.Checked == true){horarios[5].estado = 1;}                
            if(chbDom7.Checked == true){horarios[6].estado = 1;}                
            if(chbDom8.Checked == true){horarios[7].estado = 1;}
            if(chbDom9.Checked == true){horarios[8].estado = 1;}                
            if(chbDom10.Checked == true){horarios[9].estado = 1;}                
            if(chbDom11.Checked == true){horarios[10].estado = 1;}                
            if(chbDom12.Checked == true){horarios[11].estado = 1;}                
            if(chbDom13.Checked == true){horarios[12].estado = 1;}                
            if(chbDom14.Checked == true){horarios[13].estado = 1;}           

            //dia == 2                
            if(chbLun1.Checked == true){horarios[14].estado = 1;}                
            if(chbLun2.Checked == true){horarios[15].estado = 1;}                
            if(chbLun3.Checked == true){horarios[16].estado = 1;}                
            if(chbLun4.Checked == true){horarios[17].estado = 1;}                
            if(chbLun5.Checked == true){horarios[18].estado = 1;}                
            if(chbLun6.Checked == true){horarios[19].estado = 1;}                
            if(chbLun7.Checked == true){horarios[20].estado = 1;}                
            if(chbLun8.Checked == true){horarios[21].estado = 1;}                
            if(chbLun9.Checked == true){horarios[22].estado = 1;}                
            if(chbLun10.Checked == true){horarios[23].estado = 1;}                
            if(chbLun11.Checked == true){horarios[24].estado = 1;}                
            if(chbLun12.Checked == true){horarios[25].estado = 1;}                
            if(chbLun13.Checked == true){horarios[26].estado = 1;}                
            if(chbLun14.Checked == true){horarios[27].estado = 1;}
            
            //dia == 3               
            if(chbMar1.Checked == true){horarios[28].estado = 1;}                
            if(chbMar2.Checked == true){horarios[29].estado = 1;}                
            if(chbMar3.Checked == true){horarios[30].estado = 1;}                
            if(chbMar4.Checked == true){horarios[31].estado = 1;}                
            if(chbMar5.Checked == true){horarios[32].estado = 1;}                
            if(chbMar6.Checked == true){horarios[33].estado = 1;}                
            if(chbMar7.Checked == true){horarios[34].estado = 1;}                
            if(chbMar8.Checked == true){horarios[35].estado = 1;}                
            if(chbMar9.Checked == true){horarios[36].estado = 1;}                
            if(chbMar10.Checked == true){horarios[37].estado = 1;}                
            if(chbMar11.Checked == true){horarios[38].estado = 1;}                
            if(chbMar12.Checked == true){horarios[39].estado = 1;}                
            if(chbMar13.Checked == true){horarios[40].estado = 1;}                
            if(chbMar14.Checked == true){horarios[41].estado = 1;}

            //dia == 4                
            if(chbMie1.Checked == true){horarios[42].estado = 1;}                
            if(chbMie2.Checked == true){horarios[43].estado = 1;}                
            if(chbMie3.Checked == true){horarios[44].estado = 1;}                
            if(chbMie4.Checked == true){horarios[45].estado = 1;}                
            if(chbMie5.Checked == true){horarios[46].estado = 1;}                
            if(chbMie6.Checked == true){horarios[47].estado = 1;}                
            if(chbMie7.Checked == true){horarios[48].estado = 1;}                
            if(chbMie8.Checked == true){horarios[49].estado = 1;}                            
            if(chbMie9.Checked == true){horarios[50].estado = 1;}                
            if(chbMie10.Checked == true){horarios[51].estado = 1;}                
            if(chbMie11.Checked == true){horarios[52].estado = 1;}                
            if(chbMie12.Checked == true){horarios[53].estado = 1;}                
            if(chbMie13.Checked == true){horarios[54].estado = 1;}                
            if(chbMie14.Checked == true){horarios[55].estado = 1;}            

            //dia == 5  
            if(chbJue1.Checked == true){horarios[56].estado = 1;}                
            if(chbJue2.Checked == true){horarios[57].estado = 1;}                
            if(chbJue3.Checked == true){horarios[58].estado = 1;}                
            if(chbJue4.Checked == true){horarios[59].estado = 1;}                
            if(chbJue5.Checked == true){horarios[60].estado = 1;}                
            if(chbJue6.Checked == true){horarios[61].estado = 1;}                
            if(chbJue7.Checked == true){horarios[62].estado = 1;}                
            if(chbJue8.Checked == true){horarios[63].estado = 1;}                
            if(chbJue9.Checked == true){horarios[64].estado = 1;}                
            if(chbJue10.Checked == true){horarios[65].estado = 1;}                
            if(chbJue11.Checked == true){horarios[66].estado = 1;}                
            if(chbJue12.Checked == true){horarios[67].estado = 1;}                
            if(chbJue13.Checked == true){horarios[68].estado = 1;}                
            if(chbJue14.Checked == true){horarios[69].estado = 1;}
            
            //dia == 6               
            if(chbVie1.Checked == true){horarios[70].estado = 1;}                
            if(chbVie2.Checked == true){horarios[71].estado = 1;}                
            if(chbVie3.Checked == true){horarios[72].estado = 1;}                
            if(chbVie4.Checked == true){horarios[73].estado = 1;}                
            if(chbVie5.Checked == true){horarios[74].estado = 1;}                
            if(chbVie6.Checked == true){horarios[75].estado = 1;}                
            if(chbVie7.Checked == true){horarios[76].estado = 1;}                
            if(chbVie8.Checked == true){horarios[77].estado = 1;}                
            if(chbVie9.Checked == true){horarios[78].estado = 1;}                
            if(chbVie10.Checked == true){horarios[79].estado = 1;}                
            if(chbVie11.Checked == true){horarios[80].estado = 1;}                
            if(chbVie12.Checked == true){horarios[81].estado = 1;}                
            if(chbVie13.Checked == true){horarios[82].estado = 1;}                
            if(chbVie14.Checked == true){horarios[83].estado = 1;}            

            //dia == 7                
            if(chbSab1.Checked == true){horarios[84].estado = 1;}                
            if(chbSab2.Checked == true){horarios[85].estado = 1;}                
            if(chbSab3.Checked == true){horarios[86].estado = 1;}                
            if(chbSab4.Checked == true){horarios[87].estado = 1;}                
            if(chbSab5.Checked == true){horarios[88].estado = 1;}                
            if(chbSab6.Checked == true){horarios[89].estado = 1;}                
            if(chbSab7.Checked == true){horarios[90].estado = 1;}                
            if(chbSab8.Checked == true){horarios[91].estado = 1;}                
            if(chbSab9.Checked == true){horarios[92].estado = 1;}                
            if(chbSab10.Checked == true){horarios[93].estado = 1;}                
            if(chbSab11.Checked == true){horarios[94].estado = 1;}                
            if(chbSab12.Checked == true){horarios[95].estado = 1;}                
            if(chbSab13.Checked == true){horarios[96].estado = 1;}                
            if(chbSab14.Checked == true){horarios[97].estado = 1;}

            int a = _hcs.eliminarHorariosAnteriores(Common.Session.UserID);

            for (int i = 0; i < 98; i++) {
                if(horarios[i].estado == 1)
                    horarios[i].id_horario = _hcs.insertar(horarios[i]);
            }
            

        }

        
        public void limpiarChecks()
        {
            //foreach (Control c in this.Controls)
            //{
            //    if (c is CheckBox)
            //    {
            //        ((CheckBox)c).Checked = false;
            //    }
            //}
            chbDom1.Checked = false;
            chbDom2.Checked = false;
            chbDom3.Checked = false;
            chbDom4.Checked = false;
            chbDom5.Checked = false;
            chbDom6.Checked = false;
            chbDom7.Checked = false;
            chbDom8.Checked = false;
            chbDom9.Checked = false;
            chbDom10.Checked = false;
            chbDom11.Checked = false;
            chbDom12.Checked = false;
            chbDom13.Checked = false;
            chbDom14.Checked = false;

            chbLun1.Checked = false;
            chbLun2.Checked = false;
            chbLun3.Checked = false;
            chbLun4.Checked = false;
            chbLun5.Checked = false;
            chbLun6.Checked = false;
            chbLun7.Checked = false;
            chbLun8.Checked = false;
            chbLun9.Checked = false;
            chbLun10.Checked = false;
            chbLun11.Checked = false;
            chbLun12.Checked = false;
            chbLun13.Checked = false;
            chbLun14.Checked = false;

            chbMar1.Checked = false;
            chbMar2.Checked = false;
            chbMar3.Checked = false;
            chbMar4.Checked = false;
            chbMar5.Checked = false;
            chbMar6.Checked = false;
            chbMar7.Checked = false;
            chbMar8.Checked = false;
            chbMar9.Checked = false;
            chbMar10.Checked = false;
            chbMar11.Checked = false;
            chbMar12.Checked = false;
            chbMar13.Checked = false;
            chbMar14.Checked = false;

            chbMie1.Checked = false;
            chbMie2.Checked = false;
            chbMie3.Checked = false;
            chbMie4.Checked = false;
            chbMie5.Checked = false;
            chbMie6.Checked = false;
            chbMie7.Checked = false;
            chbMie8.Checked = false;
            chbMie9.Checked = false;
            chbMie10.Checked = false;
            chbMie11.Checked = false;
            chbMie12.Checked = false;
            chbMie13.Checked = false;
            chbMie14.Checked = false;

            chbJue1.Checked = false;
            chbJue2.Checked = false;
            chbJue3.Checked = false;
            chbJue4.Checked = false;
            chbJue5.Checked = false;
            chbJue6.Checked = false;
            chbJue7.Checked = false;
            chbJue8.Checked = false;
            chbJue9.Checked = false;
            chbJue10.Checked = false;
            chbJue11.Checked = false;
            chbJue12.Checked = false;
            chbJue13.Checked = false;
            chbJue14.Checked = false;

            chbVie1.Checked = false;
            chbVie2.Checked = false;
            chbVie3.Checked = false;
            chbVie4.Checked = false;
            chbVie5.Checked = false;
            chbVie6.Checked = false;
            chbVie7.Checked = false;
            chbVie8.Checked = false;
            chbVie9.Checked = false;
            chbVie10.Checked = false;
            chbVie11.Checked = false;
            chbVie12.Checked = false;
            chbVie13.Checked = false;
            chbVie14.Checked = false;

            chbSab1.Checked = false;
            chbSab2.Checked = false;
            chbSab3.Checked = false;
            chbSab4.Checked = false;
            chbSab5.Checked = false;
            chbSab6.Checked = false;
            chbSab7.Checked = false;
            chbSab8.Checked = false;
            chbSab9.Checked = false;
            chbSab10.Checked = false;
            chbSab11.Checked = false;
            chbSab12.Checked = false;
            chbSab13.Checked = false;
            chbSab14.Checked = false;
        }

        public string listarHorario() {

            

            HorarioCitaWS.horario[] horarioActual = _hcs.listarPorEspec(Common.Session.UserID);

            limpiarChecks();

            if (horarioActual != null) {

                foreach (HorarioCitaWS.horario h in horarioActual) {

                    //string ga = h.horarioInicio.ToString("hh:mm:ss");

                    //dia == 1
                    if (h.diaSemana == 0) {
                        if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:00:00"))
                            chbDom1.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:30:00"))
                            chbDom2.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:00:00"))
                            chbDom3.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:30:00"))
                            chbDom4.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:00:00"))
                            chbDom5.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:30:00"))
                            chbDom6.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:00:00"))
                            chbDom7.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:30:00"))
                            chbDom8.Checked = true;                        
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:00:00"))
                            chbDom9.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:30:00"))
                            chbDom10.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:00:00"))
                            chbDom11.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:30:00"))
                            chbDom12.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:00:00"))
                            chbDom13.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:30:00"))
                            chbDom14.Checked = true;
                    }

                    //dia == 2
                    else if (h.diaSemana == 1) {
                        if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:00:00"))
                            chbLun1.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:30:00"))
                            chbLun2.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:00:00"))
                            chbLun3.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:30:00"))
                            chbLun4.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:00:00"))
                            chbLun5.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:30:00"))
                            chbLun6.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:00:00"))
                            chbLun7.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:30:00"))
                            chbLun8.Checked = true;

                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:00:00"))
                            chbLun9.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:30:00"))
                            chbLun10.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:00:00"))
                            chbLun11.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:30:00"))
                            chbLun12.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:00:00"))
                            chbLun13.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:30:00"))
                            chbLun14.Checked = true;
                    }

                    //dia == 3
                    else if (h.diaSemana == 2) {
                        if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:00:00"))
                            chbMar1.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:30:00"))
                            chbMar2.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:00:00"))
                            chbMar3.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:30:00"))
                            chbMar4.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:00:00"))
                            chbMar5.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:30:00"))
                            chbMar6.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:00:00"))
                            chbMar7.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:30:00"))
                            chbMar8.Checked = true;

                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:00:00"))
                            chbMar9.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:30:00"))
                            chbMar10.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:00:00"))
                            chbMar11.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:30:00"))
                            chbMar12.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:00:00"))
                            chbMar13.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:30:00"))
                            chbMar14.Checked = true;
                    }


                    //dia == 4
                    else if (h.diaSemana == 3) {
                        if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:00:00"))
                            chbMie1.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:30:00"))
                            chbMie2.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:00:00"))
                            chbMie3.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:30:00"))
                            chbMie4.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:00:00"))
                            chbMie5.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:30:00"))
                            chbMie6.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:00:00"))
                            chbMie7.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:30:00"))
                            chbMie8.Checked = true;

                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:00:00"))
                            chbMie9.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:30:00"))
                            chbMie10.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:00:00"))
                            chbMie11.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:30:00"))
                            chbMie12.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:00:00"))
                            chbMie13.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:30:00"))
                            chbMie14.Checked = true;
                    }

                    //dia == 5
                    else if (h.diaSemana == 4) {
                        if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:00:00"))
                            chbJue1.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:30:00"))
                            chbJue2.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:00:00"))
                            chbJue3.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:30:00"))
                            chbJue4.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:00:00"))
                            chbJue5.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:30:00"))
                            chbJue6.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:00:00"))
                            chbJue7.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:30:00"))
                            chbJue8.Checked = true;

                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:00:00"))
                            chbJue9.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:30:00"))
                            chbJue10.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:00:00"))
                            chbJue11.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:30:00"))
                            chbJue12.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:00:00"))
                            chbJue13.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:30:00"))
                            chbJue14.Checked = true;
                    }


                    //dia == 6
                    else if (h.diaSemana == 5) {
                        if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:00:00"))
                            chbVie1.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:30:00"))
                            chbVie2.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:00:00"))
                            chbVie3.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:30:00"))
                            chbVie4.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:00:00"))
                            chbVie5.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:30:00"))
                            chbVie6.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:00:00"))
                            chbVie7.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:30:00"))
                            chbVie8.Checked = true;

                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:00:00"))
                            chbVie9.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:30:00"))
                            chbVie10.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:00:00"))
                            chbVie11.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:30:00"))
                            chbVie12.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:00:00"))
                            chbVie13.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:30:00"))
                            chbVie14.Checked = true;
                    }

                    //dia == 7
                    else if (h.diaSemana == 6) {
                        if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:00:00"))
                            chbSab1.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "08:30:00"))
                            chbSab2.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:00:00"))
                            chbSab3.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "09:30:00"))
                            chbSab4.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:00:00"))
                            chbSab5.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "10:30:00"))
                            chbSab6.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:00:00"))
                            chbSab7.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "11:30:00"))
                            chbSab8.Checked = true;

                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:00:00"))
                            chbSab9.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "14:30:00"))
                            chbSab10.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:00:00"))
                            chbSab11.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "15:30:00"))
                            chbSab12.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:00:00"))
                            chbSab13.Checked = true;
                        else if (String.Equals(h.horarioInicio.ToString("HH:mm:ss"), "16:30:00"))
                            chbSab14.Checked = true;
                    }

                }
            

            
            
            }
            if(horarioActual != null)
            {
                return "Horario vigente registrado el día" +
                    horarioActual[0].fechaHoraRegistro.ToString(" dd/MM/yyyy") + 
                    "\nSi desea registrar un nuevo horario, haga clic en el botón.";                
            }
            else 
                return "Aun no tiene un horario registrado.";

        }
        
        //BOTONES

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoRegistro();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            estadoFecha();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            estadoInicial();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estadoGuardar();
            estadoInicial();
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

        private void frmDisponibilidad2_Load(object sender, EventArgs e)
        {
            ucFecha1.FechaInicio = DateTime.Now.AddDays(1);
            ucFecha1.Fecha = DateTime.Now.AddDays(1);
            ucFecha1.FechaFin = DateTime.Now.AddMonths(1);
            ucFecha1.Actualizar();
            ucFecha1.FirstTime = false;
        }
    }
}
