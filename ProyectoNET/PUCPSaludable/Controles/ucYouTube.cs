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
    public partial class ucYouTube : UserControl
    {
        string[] _playlist = new string[] {"Test"};
        int _current = 0;
        public ucYouTube()
        {
            InitializeComponent();
        }
        public int Actual
        {
            set
            {
                if (value >= 0 && value <= this._playlist.Length)
                {
                    this._current = value;
                    this.Video = this._playlist[value];
                }
                else
                {
                    this._current = 0;
                    this.Video = "about:blank";
                }
            }
            get
            {
                return this._current;
            }
        }

        public string[] Playlist
        {
            set
            {
                this._playlist = value;
                this._current = 0;
                this.Video = "about:blank";
            }
            get
            {
                return this._playlist;
            }
        }
        public string Video
        {
            set
            {
                if (value != "" && value != null)
                {
                    wvPlayer.URL = "http://ws.pucpsaludable.ml/web.php?url=" + value;
                }
                else
                {
                    wvPlayer.URL = "about:blank";
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this._current -= 1;
            if (this._current < 0)
            {
                this._current = this._playlist.Length - 1;
            }
            wvPlayer.URL = "http://ws.pucpsaludable.ml/web.php?url=" + this._playlist[this._current];
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            this._current += 1;
            this._current %= this._playlist.Length;
            wvPlayer.URL = "http://ws.pucpsaludable.ml/web.php?url=" + this._playlist[this._current];
        }
    }
}
