using PUCPSaludable.Alumno.Citas.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Controles
{

    public partial class ucHistComidas : UserControl
    {


        private string _fecha;
        private ECheckComidas _check1;
        private ECheckComidas _check2;
        private ECheckComidas _check3;
        private ECheckComidas _check4;
        private ECheckComidas _check5;

        public ucHistComidas()
        {
            InitializeComponent();
            labFechaHistComida.Text = "24/05/1986";
        }

        public string Fecha { 
            get => _fecha;
            set {
                _fecha = value;
                labFechaHistComida.Text = value;
            }  
        }

        public ECheckComidas Check1
        {
            set
            {
                var resources = new ResourceManager(typeof(ucHistComidas));

                this._check1 = value;

                switch (this._check1)
                {

                    case ECheckComidas.Check:
                        this.pbCheck1.Image = (System.Drawing.Image)resources.GetObject("check");
                        break;
                    case ECheckComidas.Uncheck:
                        this.pbCheck1.Image = (System.Drawing.Image)resources.GetObject("uncheck");
                        break;
                    default:
                        break;
                }
            }
            get
            {
                return this._check1;
            }

        }

        public ECheckComidas Check2
        {
            set
            {
                var resources = new ResourceManager(typeof(ucHistComidas));

                this._check2 = value;

                switch (this._check2)
                {

                    case ECheckComidas.Check:
                        this.pbCheck2.Image = (System.Drawing.Image)resources.GetObject("check");
                        break;
                    case ECheckComidas.Uncheck:
                        this.pbCheck2.Image = (System.Drawing.Image)resources.GetObject("uncheck");
                        break;
                    default:
                        break;
                }
            }
            get
            {
                return this._check2;
            }

        }

        public ECheckComidas Check3
        {
            set
            {
                var resources = new ResourceManager(typeof(ucHistComidas));

                this._check3 = value;

                switch (this._check3)
                {

                    case ECheckComidas.Check:
                        this.pbCheck3.Image = (System.Drawing.Image)resources.GetObject("check");
                        break;
                    case ECheckComidas.Uncheck:
                        this.pbCheck3.Image = (System.Drawing.Image)resources.GetObject("uncheck");
                        break;
                    default:
                        break;
                }
            }
            get
            {
                return this._check3;
            }

        }

        public ECheckComidas Check4
        {
            set
            {
                var resources = new ResourceManager(typeof(ucHistComidas));

                this._check4 = value;

                switch (this._check4)
                {

                    case ECheckComidas.Check:
                        this.pbCheck4.Image = (System.Drawing.Image)resources.GetObject("check");
                        break;
                    case ECheckComidas.Uncheck:
                        this.pbCheck4.Image = (System.Drawing.Image)resources.GetObject("uncheck");
                        break;
                    default:
                        break;
                }
            }
            get
            {
                return this._check4;
            }

        }

        public ECheckComidas Check5
        {
            set
            {
                var resources = new ResourceManager(typeof(ucHistComidas));

                this._check5 = value;

                switch (this._check5)
                {

                    case ECheckComidas.Check:
                        this.pbCheck5.Image = (System.Drawing.Image)resources.GetObject("check");
                        break;
                    case ECheckComidas.Uncheck:
                        this.pbCheck5.Image = (System.Drawing.Image)resources.GetObject("uncheck");
                        break;
                    default:
                        break;
                }
            }
            get
            {
                return this._check5;
            }

        }



        private void pbCheck1_Click(object sender, EventArgs e)
        {

        }
    }
}
