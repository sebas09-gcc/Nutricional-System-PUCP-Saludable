
namespace PUCPSaludable.Administrador
{
    partial class frmPrincipalAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalAdministrador));
            this.tsControlAdministrar = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcControlAdministrar = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPendiente = new System.Windows.Forms.TabPage();
            this.tlpPendiente = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPendienteSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.btnConsultarPendiente = new MaterialSkin.Controls.MaterialButton();
            this.panFiltrarPendiente = new System.Windows.Forms.Panel();
            this.tbBuscarPendiente = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAutorizarPendiente = new MaterialSkin.Controls.MaterialButton();
            this.btnRechazarPendiente = new MaterialSkin.Controls.MaterialButton();
            this.dgvPendiente = new System.Windows.Forms.DataGridView();
            this.CodigoPUCPPendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosPendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresPendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolSolicitadoPendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAtendido = new System.Windows.Forms.TabPage();
            this.tlpAtendido = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAtendidoSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.panFiltrarAtendido = new System.Windows.Forms.Panel();
            this.tbBuscarAtendido = new MaterialSkin.Controls.MaterialTextBox();
            this.btnConsultarAtendido = new MaterialSkin.Controls.MaterialButton();
            this.dgvAtendido = new System.Windows.Forms.DataGridView();
            this.CodigoPUCPAtendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosAtendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresAtendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolSolicitadoAtendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutorizadoAtendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.tlpUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUsuarioSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.panFiltrarUsuario = new System.Windows.Forms.Panel();
            this.tbBuscarUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.btnConsultarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.cbSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.CodigoPUCPUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panControlAdministrar = new System.Windows.Forms.Panel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNavegacion = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tcControlAdministrar.SuspendLayout();
            this.tabPendiente.SuspendLayout();
            this.tlpPendiente.SuspendLayout();
            this.tlpPendienteSuperior.SuspendLayout();
            this.panFiltrarPendiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendiente)).BeginInit();
            this.tabAtendido.SuspendLayout();
            this.tlpAtendido.SuspendLayout();
            this.tlpAtendidoSuperior.SuspendLayout();
            this.panFiltrarAtendido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendido)).BeginInit();
            this.tabUsuarios.SuspendLayout();
            this.tlpUsuario.SuspendLayout();
            this.tlpUsuarioSuperior.SuspendLayout();
            this.panFiltrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.panControlAdministrar.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tlpNavegacion.SuspendLayout();
            this.panPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsControlAdministrar
            // 
            this.tsControlAdministrar.BaseTabControl = this.tcControlAdministrar;
            this.tsControlAdministrar.Depth = 0;
            this.tsControlAdministrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsControlAdministrar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tsControlAdministrar.Location = new System.Drawing.Point(0, 0);
            this.tsControlAdministrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tsControlAdministrar.Name = "tsControlAdministrar";
            this.tsControlAdministrar.Size = new System.Drawing.Size(1177, 48);
            this.tsControlAdministrar.TabIndex = 1;
            // 
            // tcControlAdministrar
            // 
            this.tcControlAdministrar.Controls.Add(this.tabPendiente);
            this.tcControlAdministrar.Controls.Add(this.tabAtendido);
            this.tcControlAdministrar.Controls.Add(this.tabUsuarios);
            this.tcControlAdministrar.Depth = 0;
            this.tcControlAdministrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcControlAdministrar.Location = new System.Drawing.Point(0, 0);
            this.tcControlAdministrar.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tcControlAdministrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcControlAdministrar.Multiline = true;
            this.tcControlAdministrar.Name = "tcControlAdministrar";
            this.tcControlAdministrar.SelectedIndex = 0;
            this.tcControlAdministrar.Size = new System.Drawing.Size(1171, 488);
            this.tcControlAdministrar.TabIndex = 0;
            // 
            // tabPendiente
            // 
            this.tabPendiente.BackColor = System.Drawing.Color.White;
            this.tabPendiente.Controls.Add(this.tlpPendiente);
            this.tabPendiente.Location = new System.Drawing.Point(4, 22);
            this.tabPendiente.Name = "tabPendiente";
            this.tabPendiente.Padding = new System.Windows.Forms.Padding(10);
            this.tabPendiente.Size = new System.Drawing.Size(1163, 462);
            this.tabPendiente.TabIndex = 0;
            this.tabPendiente.Text = "Solicitudes pendiente";
            // 
            // tlpPendiente
            // 
            this.tlpPendiente.ColumnCount = 1;
            this.tlpPendiente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPendiente.Controls.Add(this.tlpPendienteSuperior, 0, 0);
            this.tlpPendiente.Controls.Add(this.dgvPendiente, 0, 1);
            this.tlpPendiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPendiente.Location = new System.Drawing.Point(10, 10);
            this.tlpPendiente.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPendiente.Name = "tlpPendiente";
            this.tlpPendiente.RowCount = 2;
            this.tlpPendiente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPendiente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPendiente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPendiente.Size = new System.Drawing.Size(1143, 442);
            this.tlpPendiente.TabIndex = 0;
            // 
            // tlpPendienteSuperior
            // 
            this.tlpPendienteSuperior.ColumnCount = 4;
            this.tlpPendienteSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPendienteSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPendienteSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPendienteSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPendienteSuperior.Controls.Add(this.btnConsultarPendiente, 0, 0);
            this.tlpPendienteSuperior.Controls.Add(this.panFiltrarPendiente, 0, 0);
            this.tlpPendienteSuperior.Controls.Add(this.btnAutorizarPendiente, 3, 0);
            this.tlpPendienteSuperior.Controls.Add(this.btnRechazarPendiente, 2, 0);
            this.tlpPendienteSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPendienteSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpPendienteSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPendienteSuperior.Name = "tlpPendienteSuperior";
            this.tlpPendienteSuperior.RowCount = 1;
            this.tlpPendienteSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPendienteSuperior.Size = new System.Drawing.Size(1143, 50);
            this.tlpPendienteSuperior.TabIndex = 0;
            // 
            // btnConsultarPendiente
            // 
            this.btnConsultarPendiente.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnConsultarPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarPendiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarPendiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultarPendiente.Depth = 0;
            this.btnConsultarPendiente.DrawShadows = false;
            this.btnConsultarPendiente.HighEmphasis = true;
            this.btnConsultarPendiente.Icon = null;
            this.btnConsultarPendiente.Location = new System.Drawing.Point(847, 6);
            this.btnConsultarPendiente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultarPendiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultarPendiente.Name = "btnConsultarPendiente";
            this.btnConsultarPendiente.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConsultarPendiente.Size = new System.Drawing.Size(92, 36);
            this.btnConsultarPendiente.TabIndex = 3;
            this.btnConsultarPendiente.Text = "CONSULTAR";
            this.btnConsultarPendiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultarPendiente.UseAccentColor = true;
            this.btnConsultarPendiente.UseVisualStyleBackColor = true;
            this.btnConsultarPendiente.Click += new System.EventHandler(this.btnConsultarPendiente_Click);
            // 
            // panFiltrarPendiente
            // 
            this.panFiltrarPendiente.Controls.Add(this.tbBuscarPendiente);
            this.panFiltrarPendiente.Location = new System.Drawing.Point(0, 0);
            this.panFiltrarPendiente.Margin = new System.Windows.Forms.Padding(0);
            this.panFiltrarPendiente.Name = "panFiltrarPendiente";
            this.panFiltrarPendiente.Size = new System.Drawing.Size(422, 50);
            this.panFiltrarPendiente.TabIndex = 1;
            // 
            // tbBuscarPendiente
            // 
            this.tbBuscarPendiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbBuscarPendiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbBuscarPendiente.Depth = 0;
            this.tbBuscarPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbBuscarPendiente.HideSelection = true;
            this.tbBuscarPendiente.Hint = "Escribe para buscar";
            this.tbBuscarPendiente.LeadingIcon = null;
            this.tbBuscarPendiente.Location = new System.Drawing.Point(3, 6);
            this.tbBuscarPendiente.MaxLength = 32767;
            this.tbBuscarPendiente.MouseState = MaterialSkin.MouseState.OUT;
            this.tbBuscarPendiente.Name = "tbBuscarPendiente";
            this.tbBuscarPendiente.PasswordChar = '\0';
            this.tbBuscarPendiente.PrefixSuffixText = null;
            this.tbBuscarPendiente.ReadOnly = false;
            this.tbBuscarPendiente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbBuscarPendiente.SelectedText = "";
            this.tbBuscarPendiente.SelectionLength = 0;
            this.tbBuscarPendiente.SelectionStart = 0;
            this.tbBuscarPendiente.ShortcutsEnabled = true;
            this.tbBuscarPendiente.Size = new System.Drawing.Size(420, 36);
            this.tbBuscarPendiente.TabIndex = 0;
            this.tbBuscarPendiente.TabStop = false;
            this.tbBuscarPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbBuscarPendiente.TrailingIcon = null;
            this.tbBuscarPendiente.UseSystemPasswordChar = false;
            this.tbBuscarPendiente.UseTallSize = false;
            this.tbBuscarPendiente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBuscarPendiente_KeyUp);
            // 
            // btnAutorizarPendiente
            // 
            this.btnAutorizarPendiente.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAutorizarPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutorizarPendiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAutorizarPendiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAutorizarPendiente.Depth = 0;
            this.btnAutorizarPendiente.DrawShadows = false;
            this.btnAutorizarPendiente.HighEmphasis = true;
            this.btnAutorizarPendiente.Icon = null;
            this.btnAutorizarPendiente.Location = new System.Drawing.Point(1047, 6);
            this.btnAutorizarPendiente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAutorizarPendiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAutorizarPendiente.Name = "btnAutorizarPendiente";
            this.btnAutorizarPendiente.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAutorizarPendiente.Size = new System.Drawing.Size(92, 36);
            this.btnAutorizarPendiente.TabIndex = 0;
            this.btnAutorizarPendiente.Text = "Autorizar";
            this.btnAutorizarPendiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAutorizarPendiente.UseAccentColor = true;
            this.btnAutorizarPendiente.UseVisualStyleBackColor = true;
            this.btnAutorizarPendiente.Click += new System.EventHandler(this.btnAutorizarPendiente_Click);
            // 
            // btnRechazarPendiente
            // 
            this.btnRechazarPendiente.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnRechazarPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechazarPendiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRechazarPendiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRechazarPendiente.Depth = 0;
            this.btnRechazarPendiente.DrawShadows = false;
            this.btnRechazarPendiente.HighEmphasis = true;
            this.btnRechazarPendiente.Icon = null;
            this.btnRechazarPendiente.Location = new System.Drawing.Point(947, 6);
            this.btnRechazarPendiente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRechazarPendiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRechazarPendiente.Name = "btnRechazarPendiente";
            this.btnRechazarPendiente.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRechazarPendiente.Size = new System.Drawing.Size(92, 36);
            this.btnRechazarPendiente.TabIndex = 2;
            this.btnRechazarPendiente.Text = "Rechazar";
            this.btnRechazarPendiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRechazarPendiente.UseAccentColor = true;
            this.btnRechazarPendiente.UseVisualStyleBackColor = true;
            this.btnRechazarPendiente.Click += new System.EventHandler(this.btnRechazarPendiente_Click);
            // 
            // dgvPendiente
            // 
            this.dgvPendiente.AllowUserToAddRows = false;
            this.dgvPendiente.AllowUserToDeleteRows = false;
            this.dgvPendiente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            this.dgvPendiente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPendiente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendiente.BackgroundColor = System.Drawing.Color.White;
            this.dgvPendiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendiente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPendiente.ColumnHeadersHeight = 30;
            this.dgvPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPendiente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPUCPPendiente,
            this.ApellidosPendiente,
            this.NombresPendiente,
            this.RolSolicitadoPendiente});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendiente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPendiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendiente.EnableHeadersVisualStyles = false;
            this.dgvPendiente.Location = new System.Drawing.Point(3, 53);
            this.dgvPendiente.MultiSelect = false;
            this.dgvPendiente.Name = "dgvPendiente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendiente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPendiente.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendiente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPendiente.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dgvPendiente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendiente.Size = new System.Drawing.Size(1137, 386);
            this.dgvPendiente.TabIndex = 1;
            this.dgvPendiente.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPendiente_CellFormatting);
            // 
            // CodigoPUCPPendiente
            // 
            this.CodigoPUCPPendiente.FillWeight = 20F;
            this.CodigoPUCPPendiente.HeaderText = "Codigo PUCP";
            this.CodigoPUCPPendiente.MinimumWidth = 50;
            this.CodigoPUCPPendiente.Name = "CodigoPUCPPendiente";
            // 
            // ApellidosPendiente
            // 
            this.ApellidosPendiente.FillWeight = 30F;
            this.ApellidosPendiente.HeaderText = "Apellidos";
            this.ApellidosPendiente.Name = "ApellidosPendiente";
            // 
            // NombresPendiente
            // 
            this.NombresPendiente.FillWeight = 30F;
            this.NombresPendiente.HeaderText = "Nombres";
            this.NombresPendiente.Name = "NombresPendiente";
            // 
            // RolSolicitadoPendiente
            // 
            this.RolSolicitadoPendiente.FillWeight = 20F;
            this.RolSolicitadoPendiente.HeaderText = "Rol Solicitado";
            this.RolSolicitadoPendiente.MinimumWidth = 100;
            this.RolSolicitadoPendiente.Name = "RolSolicitadoPendiente";
            // 
            // tabAtendido
            // 
            this.tabAtendido.BackColor = System.Drawing.Color.White;
            this.tabAtendido.Controls.Add(this.tlpAtendido);
            this.tabAtendido.Location = new System.Drawing.Point(4, 22);
            this.tabAtendido.Name = "tabAtendido";
            this.tabAtendido.Padding = new System.Windows.Forms.Padding(10);
            this.tabAtendido.Size = new System.Drawing.Size(1163, 462);
            this.tabAtendido.TabIndex = 1;
            this.tabAtendido.Text = "Solicitudes atendidas";
            // 
            // tlpAtendido
            // 
            this.tlpAtendido.ColumnCount = 1;
            this.tlpAtendido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAtendido.Controls.Add(this.tlpAtendidoSuperior, 0, 0);
            this.tlpAtendido.Controls.Add(this.dgvAtendido, 0, 1);
            this.tlpAtendido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAtendido.Location = new System.Drawing.Point(10, 10);
            this.tlpAtendido.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAtendido.Name = "tlpAtendido";
            this.tlpAtendido.RowCount = 2;
            this.tlpAtendido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAtendido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAtendido.Size = new System.Drawing.Size(1143, 442);
            this.tlpAtendido.TabIndex = 0;
            // 
            // tlpAtendidoSuperior
            // 
            this.tlpAtendidoSuperior.ColumnCount = 2;
            this.tlpAtendidoSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAtendidoSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpAtendidoSuperior.Controls.Add(this.panFiltrarAtendido, 0, 0);
            this.tlpAtendidoSuperior.Controls.Add(this.btnConsultarAtendido, 1, 0);
            this.tlpAtendidoSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAtendidoSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpAtendidoSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAtendidoSuperior.Name = "tlpAtendidoSuperior";
            this.tlpAtendidoSuperior.RowCount = 1;
            this.tlpAtendidoSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAtendidoSuperior.Size = new System.Drawing.Size(1143, 50);
            this.tlpAtendidoSuperior.TabIndex = 0;
            // 
            // panFiltrarAtendido
            // 
            this.panFiltrarAtendido.Controls.Add(this.tbBuscarAtendido);
            this.panFiltrarAtendido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFiltrarAtendido.Location = new System.Drawing.Point(0, 0);
            this.panFiltrarAtendido.Margin = new System.Windows.Forms.Padding(0);
            this.panFiltrarAtendido.Name = "panFiltrarAtendido";
            this.panFiltrarAtendido.Size = new System.Drawing.Size(1043, 50);
            this.panFiltrarAtendido.TabIndex = 2;
            // 
            // tbBuscarAtendido
            // 
            this.tbBuscarAtendido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbBuscarAtendido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbBuscarAtendido.Depth = 0;
            this.tbBuscarAtendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbBuscarAtendido.HideSelection = true;
            this.tbBuscarAtendido.Hint = "Escribe para buscar";
            this.tbBuscarAtendido.LeadingIcon = null;
            this.tbBuscarAtendido.Location = new System.Drawing.Point(3, 6);
            this.tbBuscarAtendido.MaxLength = 32767;
            this.tbBuscarAtendido.MouseState = MaterialSkin.MouseState.OUT;
            this.tbBuscarAtendido.Name = "tbBuscarAtendido";
            this.tbBuscarAtendido.PasswordChar = '\0';
            this.tbBuscarAtendido.PrefixSuffixText = null;
            this.tbBuscarAtendido.ReadOnly = false;
            this.tbBuscarAtendido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbBuscarAtendido.SelectedText = "";
            this.tbBuscarAtendido.SelectionLength = 0;
            this.tbBuscarAtendido.SelectionStart = 0;
            this.tbBuscarAtendido.ShortcutsEnabled = true;
            this.tbBuscarAtendido.Size = new System.Drawing.Size(420, 36);
            this.tbBuscarAtendido.TabIndex = 0;
            this.tbBuscarAtendido.TabStop = false;
            this.tbBuscarAtendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbBuscarAtendido.TrailingIcon = null;
            this.tbBuscarAtendido.UseSystemPasswordChar = false;
            this.tbBuscarAtendido.UseTallSize = false;
            this.tbBuscarAtendido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBuscarAtendido_KeyUp);
            // 
            // btnConsultarAtendido
            // 
            this.btnConsultarAtendido.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnConsultarAtendido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarAtendido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarAtendido.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultarAtendido.Depth = 0;
            this.btnConsultarAtendido.DrawShadows = false;
            this.btnConsultarAtendido.HighEmphasis = true;
            this.btnConsultarAtendido.Icon = null;
            this.btnConsultarAtendido.Location = new System.Drawing.Point(1047, 6);
            this.btnConsultarAtendido.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultarAtendido.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultarAtendido.Name = "btnConsultarAtendido";
            this.btnConsultarAtendido.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConsultarAtendido.Size = new System.Drawing.Size(92, 36);
            this.btnConsultarAtendido.TabIndex = 3;
            this.btnConsultarAtendido.Text = "Consultar";
            this.btnConsultarAtendido.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultarAtendido.UseAccentColor = true;
            this.btnConsultarAtendido.UseVisualStyleBackColor = true;
            this.btnConsultarAtendido.Click += new System.EventHandler(this.btnConsultarAtendido_Click);
            // 
            // dgvAtendido
            // 
            this.dgvAtendido.AllowUserToAddRows = false;
            this.dgvAtendido.AllowUserToDeleteRows = false;
            this.dgvAtendido.AllowUserToResizeRows = false;
            this.dgvAtendido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAtendido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtendido.BackgroundColor = System.Drawing.Color.White;
            this.dgvAtendido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAtendido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAtendido.ColumnHeadersHeight = 30;
            this.dgvAtendido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAtendido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPUCPAtendido,
            this.ApellidosAtendido,
            this.NombresAtendido,
            this.RolSolicitadoAtendido,
            this.AutorizadoAtendido});
            this.dgvAtendido.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAtendido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtendido.EnableHeadersVisualStyles = false;
            this.dgvAtendido.Location = new System.Drawing.Point(3, 53);
            this.dgvAtendido.MultiSelect = false;
            this.dgvAtendido.Name = "dgvAtendido";
            this.dgvAtendido.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAtendido.RowHeadersVisible = false;
            this.dgvAtendido.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAtendido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtendido.Size = new System.Drawing.Size(1137, 386);
            this.dgvAtendido.TabIndex = 1;
            this.dgvAtendido.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAtendido_CellFormatting);
            // 
            // CodigoPUCPAtendido
            // 
            this.CodigoPUCPAtendido.FillWeight = 20F;
            this.CodigoPUCPAtendido.HeaderText = "Codigo PUCP";
            this.CodigoPUCPAtendido.MinimumWidth = 50;
            this.CodigoPUCPAtendido.Name = "CodigoPUCPAtendido";
            // 
            // ApellidosAtendido
            // 
            this.ApellidosAtendido.FillWeight = 25F;
            this.ApellidosAtendido.HeaderText = "Apellidos";
            this.ApellidosAtendido.Name = "ApellidosAtendido";
            // 
            // NombresAtendido
            // 
            this.NombresAtendido.FillWeight = 25F;
            this.NombresAtendido.HeaderText = "Nombres";
            this.NombresAtendido.Name = "NombresAtendido";
            // 
            // RolSolicitadoAtendido
            // 
            this.RolSolicitadoAtendido.FillWeight = 15F;
            this.RolSolicitadoAtendido.HeaderText = "Rol Solicitado";
            this.RolSolicitadoAtendido.MinimumWidth = 100;
            this.RolSolicitadoAtendido.Name = "RolSolicitadoAtendido";
            // 
            // AutorizadoAtendido
            // 
            this.AutorizadoAtendido.FillWeight = 15F;
            this.AutorizadoAtendido.HeaderText = "¿Autorizado?";
            this.AutorizadoAtendido.MinimumWidth = 30;
            this.AutorizadoAtendido.Name = "AutorizadoAtendido";
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.White;
            this.tabUsuarios.Controls.Add(this.tlpUsuario);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(10);
            this.tabUsuarios.Size = new System.Drawing.Size(1163, 462);
            this.tabUsuarios.TabIndex = 3;
            this.tabUsuarios.Text = "Usuarios";
            // 
            // tlpUsuario
            // 
            this.tlpUsuario.ColumnCount = 1;
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuario.Controls.Add(this.tlpUsuarioSuperior, 0, 0);
            this.tlpUsuario.Controls.Add(this.dgvUsuario, 0, 1);
            this.tlpUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuario.Location = new System.Drawing.Point(10, 10);
            this.tlpUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUsuario.Name = "tlpUsuario";
            this.tlpUsuario.RowCount = 2;
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuario.Size = new System.Drawing.Size(1143, 442);
            this.tlpUsuario.TabIndex = 1;
            // 
            // tlpUsuarioSuperior
            // 
            this.tlpUsuarioSuperior.ColumnCount = 3;
            this.tlpUsuarioSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuarioSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpUsuarioSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpUsuarioSuperior.Controls.Add(this.panFiltrarUsuario, 0, 0);
            this.tlpUsuarioSuperior.Controls.Add(this.btnConsultarUsuario, 2, 0);
            this.tlpUsuarioSuperior.Controls.Add(this.cbSwitch, 1, 0);
            this.tlpUsuarioSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarioSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuarioSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUsuarioSuperior.Name = "tlpUsuarioSuperior";
            this.tlpUsuarioSuperior.RowCount = 1;
            this.tlpUsuarioSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuarioSuperior.Size = new System.Drawing.Size(1143, 50);
            this.tlpUsuarioSuperior.TabIndex = 0;
            // 
            // panFiltrarUsuario
            // 
            this.panFiltrarUsuario.Controls.Add(this.tbBuscarUsuario);
            this.panFiltrarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFiltrarUsuario.Location = new System.Drawing.Point(0, 0);
            this.panFiltrarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.panFiltrarUsuario.Name = "panFiltrarUsuario";
            this.panFiltrarUsuario.Size = new System.Drawing.Size(943, 50);
            this.panFiltrarUsuario.TabIndex = 3;
            // 
            // tbBuscarUsuario
            // 
            this.tbBuscarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbBuscarUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbBuscarUsuario.Depth = 0;
            this.tbBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbBuscarUsuario.HideSelection = true;
            this.tbBuscarUsuario.Hint = "Escribe para buscar";
            this.tbBuscarUsuario.LeadingIcon = null;
            this.tbBuscarUsuario.Location = new System.Drawing.Point(3, 6);
            this.tbBuscarUsuario.MaxLength = 32767;
            this.tbBuscarUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.tbBuscarUsuario.Name = "tbBuscarUsuario";
            this.tbBuscarUsuario.PasswordChar = '\0';
            this.tbBuscarUsuario.PrefixSuffixText = null;
            this.tbBuscarUsuario.ReadOnly = false;
            this.tbBuscarUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbBuscarUsuario.SelectedText = "";
            this.tbBuscarUsuario.SelectionLength = 0;
            this.tbBuscarUsuario.SelectionStart = 0;
            this.tbBuscarUsuario.ShortcutsEnabled = true;
            this.tbBuscarUsuario.Size = new System.Drawing.Size(420, 36);
            this.tbBuscarUsuario.TabIndex = 0;
            this.tbBuscarUsuario.TabStop = false;
            this.tbBuscarUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbBuscarUsuario.TrailingIcon = null;
            this.tbBuscarUsuario.UseSystemPasswordChar = false;
            this.tbBuscarUsuario.UseTallSize = false;
            this.tbBuscarUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBuscarUsuario_KeyUp);
            // 
            // btnConsultarUsuario
            // 
            this.btnConsultarUsuario.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnConsultarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultarUsuario.Depth = 0;
            this.btnConsultarUsuario.DrawShadows = false;
            this.btnConsultarUsuario.HighEmphasis = true;
            this.btnConsultarUsuario.Icon = null;
            this.btnConsultarUsuario.Location = new System.Drawing.Point(1047, 6);
            this.btnConsultarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConsultarUsuario.Size = new System.Drawing.Size(92, 36);
            this.btnConsultarUsuario.TabIndex = 4;
            this.btnConsultarUsuario.Text = "Consultar";
            this.btnConsultarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultarUsuario.UseAccentColor = true;
            this.btnConsultarUsuario.UseVisualStyleBackColor = true;
            this.btnConsultarUsuario.Click += new System.EventHandler(this.btnConsultarUsuario_Click);
            // 
            // cbSwitch
            // 
            this.cbSwitch.AutoSize = true;
            this.cbSwitch.Depth = 0;
            this.cbSwitch.Location = new System.Drawing.Point(943, 0);
            this.cbSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.cbSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbSwitch.Name = "cbSwitch";
            this.cbSwitch.Ripple = true;
            this.cbSwitch.Size = new System.Drawing.Size(61, 37);
            this.cbSwitch.TabIndex = 5;
            this.cbSwitch.Text = " ";
            this.cbSwitch.UseVisualStyleBackColor = true;
            this.cbSwitch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbSwitch_MouseUp);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsuario.ColumnHeadersHeight = 30;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPUCPUsuario,
            this.ApellidosUsuario,
            this.NombresUsuario,
            this.RolUsuario,
            this.ActivoUsuario});
            this.dgvUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuario.EnableHeadersVisualStyles = false;
            this.dgvUsuario.Location = new System.Drawing.Point(3, 53);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsuario.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange;
            this.dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(1137, 386);
            this.dgvUsuario.TabIndex = 1;
            this.dgvUsuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsuario_CellFormatting);
            this.dgvUsuario.SelectionChanged += new System.EventHandler(this.dgvUsuario_SelectionChanged);
            // 
            // CodigoPUCPUsuario
            // 
            this.CodigoPUCPUsuario.FillWeight = 20F;
            this.CodigoPUCPUsuario.HeaderText = "Codigo PUCP";
            this.CodigoPUCPUsuario.MinimumWidth = 50;
            this.CodigoPUCPUsuario.Name = "CodigoPUCPUsuario";
            // 
            // ApellidosUsuario
            // 
            this.ApellidosUsuario.FillWeight = 25F;
            this.ApellidosUsuario.HeaderText = "Apellidos";
            this.ApellidosUsuario.MinimumWidth = 100;
            this.ApellidosUsuario.Name = "ApellidosUsuario";
            // 
            // NombresUsuario
            // 
            this.NombresUsuario.FillWeight = 25F;
            this.NombresUsuario.HeaderText = "Nombres";
            this.NombresUsuario.MinimumWidth = 100;
            this.NombresUsuario.Name = "NombresUsuario";
            // 
            // RolUsuario
            // 
            this.RolUsuario.FillWeight = 15F;
            this.RolUsuario.HeaderText = "Rol";
            this.RolUsuario.MinimumWidth = 100;
            this.RolUsuario.Name = "RolUsuario";
            // 
            // ActivoUsuario
            // 
            this.ActivoUsuario.FillWeight = 15F;
            this.ActivoUsuario.HeaderText = "¿Activo?";
            this.ActivoUsuario.MinimumWidth = 30;
            this.ActivoUsuario.Name = "ActivoUsuario";
            // 
            // panControlAdministrar
            // 
            this.panControlAdministrar.Controls.Add(this.tcControlAdministrar);
            this.panControlAdministrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControlAdministrar.Location = new System.Drawing.Point(3, 117);
            this.panControlAdministrar.Name = "panControlAdministrar";
            this.panControlAdministrar.Size = new System.Drawing.Size(1171, 488);
            this.panControlAdministrar.TabIndex = 2;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpNavegacion, 0, 0);
            this.tlpPrincipal.Controls.Add(this.panControlAdministrar, 0, 2);
            this.tlpPrincipal.Controls.Add(this.panPrincipal, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1177, 608);
            this.tlpPrincipal.TabIndex = 3;
            // 
            // tlpNavegacion
            // 
            this.tlpNavegacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlpNavegacion.ColumnCount = 4;
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNavegacion.Controls.Add(this.btnSalir, 2, 1);
            this.tlpNavegacion.Controls.Add(this.materialLabel1, 1, 1);
            this.tlpNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavegacion.Location = new System.Drawing.Point(0, 0);
            this.tlpNavegacion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNavegacion.Name = "tlpNavegacion";
            this.tlpNavegacion.RowCount = 3;
            this.tlpNavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpNavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpNavegacion.Size = new System.Drawing.Size(1177, 66);
            this.tlpNavegacion.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.DrawShadows = false;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = global::PUCPSaludable.Properties.Resources.logout;
            this.btnSalir.Location = new System.Drawing.Point(1121, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSalir.Size = new System.Drawing.Size(42, 34);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnSalir.UseAccentColor = true;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panPrincipal
            // 
            this.panPrincipal.Controls.Add(this.tsControlAdministrar);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Location = new System.Drawing.Point(0, 66);
            this.panPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(1177, 48);
            this.panPrincipal.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(13, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(220, 46);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Administrador";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 608);
            this.Controls.Add(this.tlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipalAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUCP Saludable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipalAdministrador_Load);
            this.tcControlAdministrar.ResumeLayout(false);
            this.tabPendiente.ResumeLayout(false);
            this.tlpPendiente.ResumeLayout(false);
            this.tlpPendienteSuperior.ResumeLayout(false);
            this.tlpPendienteSuperior.PerformLayout();
            this.panFiltrarPendiente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendiente)).EndInit();
            this.tabAtendido.ResumeLayout(false);
            this.tlpAtendido.ResumeLayout(false);
            this.tlpAtendidoSuperior.ResumeLayout(false);
            this.tlpAtendidoSuperior.PerformLayout();
            this.panFiltrarAtendido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendido)).EndInit();
            this.tabUsuarios.ResumeLayout(false);
            this.tlpUsuario.ResumeLayout(false);
            this.tlpUsuarioSuperior.ResumeLayout(false);
            this.tlpUsuarioSuperior.PerformLayout();
            this.panFiltrarUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.panControlAdministrar.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpNavegacion.ResumeLayout(false);
            this.panPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tsControlAdministrar;
        private MaterialSkin.Controls.MaterialTabControl tcControlAdministrar;
        private System.Windows.Forms.TabPage tabPendiente;
        private System.Windows.Forms.TableLayoutPanel tlpPendiente;
        private System.Windows.Forms.TableLayoutPanel tlpPendienteSuperior;
        private MaterialSkin.Controls.MaterialButton btnConsultarPendiente;
        private System.Windows.Forms.Panel panFiltrarPendiente;
        private MaterialSkin.Controls.MaterialTextBox tbBuscarPendiente;
        private MaterialSkin.Controls.MaterialButton btnAutorizarPendiente;
        private MaterialSkin.Controls.MaterialButton btnRechazarPendiente;
        private System.Windows.Forms.DataGridView dgvPendiente;
        private System.Windows.Forms.TabPage tabAtendido;
        private System.Windows.Forms.TableLayoutPanel tlpAtendido;
        private System.Windows.Forms.TableLayoutPanel tlpAtendidoSuperior;
        private System.Windows.Forms.Panel panFiltrarAtendido;
        private MaterialSkin.Controls.MaterialTextBox tbBuscarAtendido;
        private MaterialSkin.Controls.MaterialButton btnConsultarAtendido;
        private System.Windows.Forms.DataGridView dgvAtendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPUCPAtendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosAtendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresAtendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolSolicitadoAtendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorizadoAtendido;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlpUsuario;
        private System.Windows.Forms.TableLayoutPanel tlpUsuarioSuperior;
        private System.Windows.Forms.Panel panFiltrarUsuario;
        private MaterialSkin.Controls.MaterialTextBox tbBuscarUsuario;
        private MaterialSkin.Controls.MaterialButton btnConsultarUsuario;
        private MaterialSkin.Controls.MaterialSwitch cbSwitch;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPUCPUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivoUsuario;
        private System.Windows.Forms.Panel panControlAdministrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolSolicitadoPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPUCPPendiente;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpNavegacion;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}