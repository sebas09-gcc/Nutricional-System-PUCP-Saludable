using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Usuario
{
    public partial class frmVerificacion : Form
    {
        private bool _activeLoop;

        public frmVerificacion(string PUCPCode)
        {
            InitializeComponent();
            verify(PUCPCode);
        }

        public void wait(int msec)
        {
            var setInterval = new System.Windows.Forms.Timer();
            if (msec == 0 || msec < 0)
            {
                return;
            }
            setInterval.Interval = msec;
            setInterval.Enabled = true;
            setInterval.Start();
            setInterval.Tick += (s, e) =>
            {
                setInterval.Enabled = false;
                setInterval.Stop();
            };
            while (setInterval.Enabled)
            {
                Application.DoEvents();
            }
        }

        private async void verify(string PUCPCode)
        {
            string serverip = Common.Server.ServerIP;
            HttpClient httpClient = new HttpClient();
            string code = PUCPCode;
            string url = "http://" + serverip + "/controller.php?action=sendToken&code=" + code;
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string uid = await response.Content.ReadAsStringAsync();
            this._activeLoop = true;
            for (; this._activeLoop;)
            {
                url = "http://" + serverip + "/controller.php?action=verifyToken&id=" + uid + "&code=" + code;
                response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string strr = await response.Content.ReadAsStringAsync();
                int statusCode = (int)long.Parse(strr);
                if (statusCode == 2)
                {
                    this._activeLoop = false;
                    this.DialogResult = DialogResult.OK;
                }
                wait(1000);
            }
        }
    }
}
