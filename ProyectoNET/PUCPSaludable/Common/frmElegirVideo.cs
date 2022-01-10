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
    public partial class frmElegirVideo : Form
    {
        private string _videoURL;

        public string VideoURL { get => _videoURL; set => _videoURL = value; }

        public frmElegirVideo()
        {
            InitializeComponent();
            tbURL.Text = "https://www.youtube.com/user/pucp/videos";
            irAURL();
            tbURL.Focus();
        }

        private void wbPaginaSolicitada_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            tbURL.Text = wvPaginaSolicitada.Source.ToString();
        }
        private void irAURL()
        {
            ((System.ComponentModel.ISupportInitialize)(this.wvPaginaSolicitada)).EndInit();
            if (tbURL.Text != "")
            {
                wvPaginaSolicitada.Show();
                try
                {
                    if (!tbURL.Text.Contains("https://"))
                    {
                        string URL = "https://" + tbURL.Text;
                        tbURL.Text = URL;
                    }
                    wvPaginaSolicitada.Source = new Uri(tbURL.Text);
                }
                catch
                {
                    frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("", "La URL ingresada no es válida");
                    _frmmba.ShowDialog();
                }
            }
            else
            {
                wvPaginaSolicitada.Source = new Uri("about:blank");
            }
        }
        private string obtenerParametro(Uri uri, string key)
        {
            foreach (string parametro in uri.Query.Split('&'))
            {
                string[] parametros = parametro.Replace("?", "").Split('=');
                if (parametros[0] == key)
                {
                    return parametros[1];
                }
            }
            return "";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string videoID = obtenerParametro(wvPaginaSolicitada.Source, "v");
            if (videoID != "")
            {
                ((System.ComponentModel.ISupportInitialize)(this.wvPaginaSolicitada)).EndInit();
                _videoURL = "https://www.youtube.com/embed/" + videoID;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                frmMessageBoxAceptar _frmmba = new frmMessageBoxAceptar("", "Video no válido");
                _frmmba.ShowDialog();
            }
        }
    }
}
