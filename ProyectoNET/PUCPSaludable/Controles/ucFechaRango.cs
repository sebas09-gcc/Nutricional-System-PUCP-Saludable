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
    public delegate void DateChanged(object sender, EventArgs e);
    public partial class ucFechaRango : UserControl
    {
        bool _firstTime = true;
        public event DateChanged DateChanged;
        DateTime _startDate = new DateTime(2021,01,01);
        DateTime _endDate = DateTime.Now;
        DateTime _date = DateTime.Now;
        public ucFechaRango()
        {
            InitializeComponent();
        }

        private void ucFechaRango_Load(object sender, EventArgs e)
        {
            refreshControl();
        }

        public DateTime FechaInicio { get => _startDate; set => _startDate = value; }

        public DateTime FechaFin { get => _endDate; set => _endDate = value; }

        public DateTime Fecha { get => _date; set => _date = value; }

        public bool FirstTime { get => _firstTime; set => _firstTime = value; }

        public void Actualizar()
        {
            refreshControl();
        }

        private void refreshControl()
        {
            List<int> yearsSource = new List<int>();
            // Agregar años a lista (fijo)
            for (int i = _endDate.Year; i >= _startDate.Year; i--)
            {
                yearsSource.Add(i);
            }
            cbAnio.DataSource = new BindingSource(yearsSource, null);
            // Agregar meses a lista (variable)
            _date = new DateTime(Convert.ToInt32(cbAnio.Text), _date.Month, _date.Day);
            cbAnio.SelectedItem = _date.Year;
            int x = 0;
            foreach (KeyValuePair<string, string> m in cbMes.Items)
            {
                if (Convert.ToInt32(m.Key) == _date.Month)
                {
                    cbMes.SelectedIndex = x;
                    break;
                }
                x++;
            }
            cbDia.SelectedItem = _date.Day;
        }

        // Inicializar meses
        private void initMonths()
        {
            // Comprueba las fecha de inicio y fin, y en base a ello determina los meses a mostrar para un año en concreto
            int sM = 1, eM = 12;
            if (_date.Year == _startDate.Year)
            {
                sM = _startDate.Month;
            }
            if (_date.Year == _endDate.Year)
            {
                eM = _endDate.Month;
            }
            // Obtener el nombre de los meses
            string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            Dictionary<string, string> monthsSource = new Dictionary<string, string>();
            for (int i = sM; i <= eM; i++)
            {
                monthsSource.Add(Convert.ToString(i), months[i - 1]);
            }
            // Establecer el data source del combo de meses
            cbMes.DataSource = new BindingSource(monthsSource, null);
            cbMes.DisplayMember = "Value";
            cbMes.ValueMember = "Key";
        }

        // Inicializar dias
        private void initDays()
        {
            // Comprueba las fecha de inicio y fin, y en base a ello determina los meses a mostrar para un año y mes en concreto
            string yearKey = cbAnio.SelectedItem.ToString();
            string monthKey = ((KeyValuePair<string, string>)cbMes.SelectedItem).Key;
            int monthDays = DateTime.DaysInMonth(Convert.ToInt32(yearKey), Convert.ToInt32(monthKey));
            int sD = 1, eD = monthDays;
            if (_date.Year == _startDate.Year && _date.Month == _startDate.Month)
            {
                sD = _startDate.Day;
            }
            if (_date.Year == _endDate.Year && _date.Month == _endDate.Month)
            {
                eD = _endDate.Day;
            }
            List<int> daysSource = new List<int>();
            for (int i = sD; i <= eD; i++)
            {
                daysSource.Add(i);
            }
            // Establecer el data source del combo de dias
            cbDia.DataSource = new BindingSource(daysSource, null);
        }

        private void cbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si cambia el índice en el combo de año, entonces de deben actualizar los meses y dias
            if (!_firstTime)
            {
                _date = new DateTime(Convert.ToInt32(cbAnio.Text), _date.Month, _date.Day);
            }
            initMonths();
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si cambia el índice en el combo de mes, entonces se deben actualizar los días
            if(!_firstTime)
            {
                KeyValuePair<string, string> seleccionado = (KeyValuePair<string, string>)cbMes.SelectedItem;
                _date = new DateTime(Convert.ToInt32(cbAnio.Text), Convert.ToInt32(seleccionado.Key), _date.Day);
            }
            initDays();
        }

        private void cbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!_firstTime)
            {
                KeyValuePair<string, string> seleccionado = (KeyValuePair<string, string>)cbMes.SelectedItem;
                _date = new DateTime(Convert.ToInt32(cbAnio.Text), Convert.ToInt32(seleccionado.Key), Convert.ToInt32(cbDia.Text));
            }
            if (DateChanged != null)
            {
                DateChanged(this, EventArgs.Empty);
            }
        }
    }
}
