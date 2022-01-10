using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable
{
    public partial class frmBienvenido : Form
    {

        int _count = 1;

        public frmBienvenido()
        {
            InitializeComponent();
            initialState();
        }


        public void initialState() {
            
            btnBack.Visible = false;
            btnStart.Visible = false;
            btnGo.Visible = true;
            btnSkip.Visible = true;

            if (_count == 1)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._01;

        }

        public void endState() {
            
            btnBack.Visible = true;
            btnStart.Visible = true;
            btnGo.Visible = false;
            btnSkip.Visible = false;

            if (_count == 10)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._10;
        }

        public void normalState() {
            
            btnBack.Visible = true;
            btnStart.Visible = false;
            btnGo.Visible = true;
            btnSkip.Visible = true;

            if(_count == 2)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._02;
            else if (_count == 3)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._03;
            else if (_count == 4)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._04;
            else if (_count == 5)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._05;
            else if (_count == 6)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._06;
            else if (_count == 7)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._07;
            else if (_count == 8)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._08;
            else if (_count == 9)
                this.pbMessages.Image = global::PUCPSaludable.Properties.Resources._09;
        }

        public void loadState() {

            if (_count == 1)
                initialState();
            else if (_count == 10)
                endState();
            else
                normalState();        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _count--;
            loadState();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            _count++;
            loadState();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
