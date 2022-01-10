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

namespace PUCPSaludable.Alumno.Nutricionista
{
    public partial class frmConsultarPDF : Form
    {
        TableLayoutPanel _tlpSpinner = new System.Windows.Forms.TableLayoutPanel();
        private byte[] _proof;
        public frmConsultarPDF(byte[] proof)
        {
            Common.LoadingAnimation.Show(this, _tlpSpinner);
            InitializeComponent();
            _proof = proof;
            string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".pdf";
            File.WriteAllBytes(fileName, _proof);
            wbConstancia.Source = new Uri(fileName);
        }

        public byte[] Constancia
        {
            get
            {
                return this._proof;
            }
        }

        private void wbConstancia_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Common.LoadingAnimation.Hide(this, _tlpSpinner);
            tlpPrincipal.Visible = true;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF Files|*.pdf";
            if (saveDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = saveDialog.FileName;
            File.WriteAllBytes(fileName, _proof);
        }
    }
}
