using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Controles
{
    public partial class ucWebView : UserControl
    {
        string _url;
        TableLayoutPanel _tlp = new System.Windows.Forms.TableLayoutPanel();
        public ucWebView()
        {
            InitializeComponent();
            Common.LoadingAnimation.Show(panel, _tlp);
        }
        public string URL
        {
            set
            {
                this._url = value;
                if (value != "" && value != null)
                {
                    try
                    {
                        webView.Source = new Uri(value);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            get
            {
                return this._url;
            }
        }
        private void webView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Common.LoadingAnimation.Hide(panel, _tlp);
            webView.Visible = true;
        }
    }
}
