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

namespace PUCPSaludable.Controles
{
    public partial class ucFecha : UserControl
    {
        DateTime _fecha;
        public ucFecha()
        {
            InitializeComponent();
            List<int> yearsSource = new List<int>();
            for (int i = 2021; i > 1970; i--)
            {
                yearsSource.Add(i);
            }
            cbAnio.DataSource = new BindingSource(yearsSource, null);
            string[] months = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            Dictionary<string, string> monthsSource = new Dictionary<string, string>();
            for (int i = 0; i < months.Length - 1; i++)
            {
                monthsSource.Add(Convert.ToString(i + 1), months[i]);
            }
            cbMes.DataSource = new BindingSource(monthsSource, null);
            cbMes.DisplayMember = "Value";
            cbMes.ValueMember = "Key";
            actualizarDias();
            this._fecha = DateTime.Parse(cbAnio.Text + "-" + cbMes.SelectedValue + "-" + cbDia.Text);
        }
        public DateTime Fecha
        {
            get
            {
                this._fecha = DateTime.Parse(cbAnio.Text + "-" + cbMes.SelectedValue + "-" + cbDia.Text);
                return this._fecha;
            }
            set
            {
                this._fecha = value;
                cbAnio.SelectedIndex = 2021 - _fecha.Year;
                cbMes.SelectedIndex = _fecha.Month -1;
                cbDia.SelectedIndex = _fecha.Day - 1;
            }
        }
        private void cbDia_MouseClick(object sender, MouseEventArgs e)
        {
            actualizarDias();
        }
        private void actualizarDias()
        {
            string yearKey = cbAnio.SelectedItem.ToString();
            string monthKey = ((KeyValuePair<string, string>)cbMes.SelectedItem).Key;
            int monthDays = DateTime.DaysInMonth(Convert.ToInt32(yearKey), Convert.ToInt32(monthKey));
            List<int> daysSource = new List<int>();
            for (int i = 1; i <= monthDays; i++)
            {
                daysSource.Add(i);
            }
            cbDia.DataSource = new BindingSource(daysSource, null);
        }

        private void cbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
