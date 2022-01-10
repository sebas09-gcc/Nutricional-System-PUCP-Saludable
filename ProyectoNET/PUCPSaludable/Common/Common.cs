using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUCPSaludable.Common
{
    public static class Server
    {
        private static string _serverIP = "pucpsaludable.ml";

        public static string ServerIP
        {
            set
            {
                _serverIP = value;
            }
            get
            {
                return _serverIP;
            }
        }
    }

    public static class Session
    {
        private static int _sessionID = 0;
        private static int _userID = 0;
        private static string _userRole = "";

        public static int SessionID
        {
            set
            {
                _sessionID = value;
            }
            get
            {
                return _sessionID;
            }
        }

        public static int UserID
        {
            set
            {
                _userID = value;
            }
            get
            {
                return _userID;
            }
        }

        public static string UserRole
        {
            get => _userRole;
            set => _userRole = value;
        }

        public static void Create(int sessionID, int userID, string role)
        {
            var settings = Properties.Settings.Default;
            settings.sessionID = sessionID;
            settings.userID = userID;
            settings.role = role;
            settings.Save();
            _sessionID = sessionID;
            _userID = userID;
            _userRole = role;
        }
    }
    public static class Progress
    {
        public static void Show(this Form form, ProgressBar progressBar, int position = 4)
        {
            progressBar.Location = new System.Drawing.Point(-8, 0);
            progressBar.Margin = new System.Windows.Forms.Padding(0);
            progressBar.MarqueeAnimationSpeed = 1;
            progressBar.Maximum = 10;
            progressBar.Name = "LoadProgress";
            progressBar.Size = new System.Drawing.Size(400, position);
            progressBar.Step = 1;
            progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            form.Controls.Add(progressBar);
        }

        public static void Hide(this Form form, ProgressBar progressBar)
        {
            form.Controls.Remove(progressBar);
        }
    }
    public static class LoadingAnimation
    {
        public static void Show(this Form form, TableLayoutPanel tlpSpinner)
        {
            PictureBox pbSpinnerAnimation = new System.Windows.Forms.PictureBox();
            pbSpinnerAnimation.Image = global::PUCPSaludable.Properties.Resources.Spinner;
            pbSpinnerAnimation.SizeMode = PictureBoxSizeMode.Zoom;
            pbSpinnerAnimation.Location = new System.Drawing.Point(350, 175);
            pbSpinnerAnimation.Margin = new System.Windows.Forms.Padding(0);
            pbSpinnerAnimation.Name = "pbSpinnerAnimation";
            pbSpinnerAnimation.Size = new System.Drawing.Size(100, 100);
            pbSpinnerAnimation.TabIndex = 0;
            pbSpinnerAnimation.TabStop = false;
            tlpSpinner.ColumnCount = 3;
            tlpSpinner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSpinner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tlpSpinner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSpinner.Controls.Add(pbSpinnerAnimation, 1, 1);
            tlpSpinner.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpSpinner.Location = new System.Drawing.Point(0, 0);
            tlpSpinner.Name = "tlpSpinner";
            tlpSpinner.RowCount = 3;
            tlpSpinner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSpinner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tlpSpinner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSpinner.Size = new System.Drawing.Size(800, 450);
            tlpSpinner.TabIndex = 0;
            form.Controls.Add(tlpSpinner);
        }

        public static void Show(this Panel panel, TableLayoutPanel tlpSpinner)
        {
            PictureBox pbSpinnerAnimation = new System.Windows.Forms.PictureBox();
            pbSpinnerAnimation.Image = global::PUCPSaludable.Properties.Resources.Spinner;
            pbSpinnerAnimation.SizeMode = PictureBoxSizeMode.Zoom;
            pbSpinnerAnimation.Location = new System.Drawing.Point(350, 175);
            pbSpinnerAnimation.Margin = new System.Windows.Forms.Padding(0);
            pbSpinnerAnimation.Name = "pbSpinnerAnimation";
            pbSpinnerAnimation.Size = new System.Drawing.Size(100, 100);
            pbSpinnerAnimation.TabIndex = 0;
            pbSpinnerAnimation.TabStop = false;
            tlpSpinner.BackColor = System.Drawing.Color.White;
            tlpSpinner.ColumnCount = 3;
            tlpSpinner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSpinner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tlpSpinner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSpinner.Controls.Add(pbSpinnerAnimation, 1, 1);
            tlpSpinner.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpSpinner.Location = new System.Drawing.Point(0, 0);
            tlpSpinner.Name = "tlpSpinner";
            tlpSpinner.RowCount = 3;
            tlpSpinner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSpinner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tlpSpinner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSpinner.Size = new System.Drawing.Size(800, 450);
            tlpSpinner.TabIndex = 0;
            panel.Controls.Add(tlpSpinner);
        }

        public static void Hide(this Form form, TableLayoutPanel tlpSpinner)
        {
            form.Controls.Remove(tlpSpinner);
        }

        public static void Hide(this Panel panel, TableLayoutPanel tlpSpinner)
        {
            panel.Controls.Remove(tlpSpinner);
        }
    }

    public static class Encrypt
    {
        public static string Hash(string str)
        {
            StringBuilder hash = new StringBuilder();
            byte[] ch;
            using (HashAlgorithm ha = SHA256.Create())
            {
                ch = ha.ComputeHash(Encoding.UTF8.GetBytes(str));
            }
            foreach (byte b in ch)
            {
                hash.Append(b.ToString("X3"));
            }
            return hash.ToString();
        }
    }
    public static class Common
    {
        public static void CorrectPanelScrollBar(Panel panel)
        {
            panel.AutoScroll = false;
            panel.HorizontalScroll.Enabled = false;
            panel.HorizontalScroll.Visible = false;
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = true;
        }
        public static void ResizeIfScrollBar(this Form form, Panel panel)
        {
            if (panel.VerticalScroll.Visible)
            {
                form.Width += 10;
            }
        }
    }

    public static class NoData
    {
        public static void Show(this Panel panel, TableLayoutPanel tlpMensajeNoData, string titulo, string detalle)
        {
            MaterialSkin.Controls.MaterialLabel labNoDataTitulo = new MaterialSkin.Controls.MaterialLabel();
            Label labNoDataDetalle = new Label();
            tlpMensajeNoData.ColumnCount = 3;
            tlpMensajeNoData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpMensajeNoData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMensajeNoData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpMensajeNoData.Controls.Add(labNoDataTitulo, 1, 1);
            tlpMensajeNoData.Controls.Add(labNoDataDetalle, 1, 2);
            tlpMensajeNoData.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMensajeNoData.Location = new System.Drawing.Point(0, 0);
            tlpMensajeNoData.Name = "tlpMensajeNoData";
            tlpMensajeNoData.RowCount = 4;
            tlpMensajeNoData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpMensajeNoData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tlpMensajeNoData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tlpMensajeNoData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpMensajeNoData.Size = new System.Drawing.Size(350, 224);
            tlpMensajeNoData.TabIndex = 0;
            labNoDataTitulo.Depth = 0;
            labNoDataTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            labNoDataTitulo.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labNoDataTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labNoDataTitulo.Location = new System.Drawing.Point(23, 62);
            labNoDataTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            labNoDataTitulo.Name = "labNoDataTitulo";
            labNoDataTitulo.Size = new System.Drawing.Size(304, 50);
            labNoDataTitulo.TabIndex = 0;
            labNoDataTitulo.Text = titulo;
            labNoDataTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labNoDataDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            labNoDataDetalle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labNoDataDetalle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            labNoDataDetalle.Location = new System.Drawing.Point(23, 112);
            labNoDataDetalle.Name = "labNoDataDetalle";
            labNoDataDetalle.Size = new System.Drawing.Size(304, 50);
            labNoDataDetalle.TabIndex = 1;
            labNoDataDetalle.Text = detalle;
            labNoDataDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panel.Controls.Add(tlpMensajeNoData);
        }
    }
}
