namespace src_manager
{
    partial class w_Manager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_Manager));
            groupBox1 = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            php_version = new ComboBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            btn_guardar_php = new Button();
            groupBox2 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            nginx_puerto = new NumericUpDown();
            flowLayoutPanel8 = new FlowLayoutPanel();
            btn_guardar_nginx = new Button();
            groupBox3 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            apache_puerto = new NumericUpDown();
            flowLayoutPanel9 = new FlowLayoutPanel();
            btn_guardar_apache = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            flowLayoutPanel10 = new FlowLayoutPanel();
            install = new Button();
            flowLayoutPanel11 = new FlowLayoutPanel();
            TrayIcon = new NotifyIcon(components);
            TrayMenu = new ContextMenuStrip(components);
            menu_iniciarServicios = new ToolStripMenuItem();
            menu_detenerServicios = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menu_configurar = new ToolStripMenuItem();
            menu_salir = new ToolStripMenuItem();
            panel2 = new Panel();
            menuPrincipal = new MenuStrip();
            m_archivo = new ToolStripMenuItem();
            m_listaIP = new ToolStripMenuItem();
            m_lista_procesos = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            m_clearLog = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            m_salir = new ToolStripMenuItem();
            m_servicios = new ToolStripMenuItem();
            m_serv_iniciar = new ToolStripMenuItem();
            m_serv_detener = new ToolStripMenuItem();
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox4 = new GroupBox();
            txtLog = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_listaIP = new Button();
            btn_listaProcesos = new Button();
            btn_limpiarLog = new Button();
            groupBox1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nginx_puerto).BeginInit();
            flowLayoutPanel8.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)apache_puerto).BeginInit();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            flowLayoutPanel11.SuspendLayout();
            TrayMenu.SuspendLayout();
            panel2.SuspendLayout();
            menuPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(flowLayoutPanel4);
            groupBox1.Controls.Add(flowLayoutPanel6);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(109, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PHP";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(php_version);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 19);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(103, 29);
            flowLayoutPanel4.TabIndex = 5;
            // 
            // php_version
            // 
            php_version.FormattingEnabled = true;
            php_version.Location = new Point(3, 3);
            php_version.Name = "php_version";
            php_version.Size = new Size(97, 23);
            php_version.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.Controls.Add(btn_guardar_php);
            flowLayoutPanel6.Dock = DockStyle.Bottom;
            flowLayoutPanel6.Location = new Point(3, 48);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(103, 31);
            flowLayoutPanel6.TabIndex = 6;
            // 
            // btn_guardar_php
            // 
            btn_guardar_php.AutoSize = true;
            btn_guardar_php.Location = new Point(3, 3);
            btn_guardar_php.Name = "btn_guardar_php";
            btn_guardar_php.Size = new Size(97, 25);
            btn_guardar_php.TabIndex = 0;
            btn_guardar_php.Text = "Guardar";
            btn_guardar_php.UseVisualStyleBackColor = true;
            btn_guardar_php.Click += btn_guardar_php_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Controls.Add(flowLayoutPanel8);
            groupBox2.Location = new Point(118, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(109, 82);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "NGINX";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(nginx_puerto);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(103, 29);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // nginx_puerto
            // 
            nginx_puerto.Location = new Point(3, 3);
            nginx_puerto.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nginx_puerto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nginx_puerto.Name = "nginx_puerto";
            nginx_puerto.Size = new Size(97, 23);
            nginx_puerto.TabIndex = 0;
            nginx_puerto.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel8.Controls.Add(btn_guardar_nginx);
            flowLayoutPanel8.Dock = DockStyle.Bottom;
            flowLayoutPanel8.Location = new Point(3, 48);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(103, 31);
            flowLayoutPanel8.TabIndex = 7;
            // 
            // btn_guardar_nginx
            // 
            btn_guardar_nginx.AutoSize = true;
            btn_guardar_nginx.Location = new Point(3, 3);
            btn_guardar_nginx.Name = "btn_guardar_nginx";
            btn_guardar_nginx.Size = new Size(97, 25);
            btn_guardar_nginx.TabIndex = 0;
            btn_guardar_nginx.Text = "Guardar";
            btn_guardar_nginx.UseVisualStyleBackColor = true;
            btn_guardar_nginx.Click += btn_guardar_nginx_Click;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(flowLayoutPanel3);
            groupBox3.Controls.Add(flowLayoutPanel9);
            groupBox3.Location = new Point(233, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = RightToLeft.No;
            groupBox3.Size = new Size(109, 82);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Apache";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(apache_puerto);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 19);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(103, 29);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // apache_puerto
            // 
            apache_puerto.Location = new Point(3, 3);
            apache_puerto.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            apache_puerto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            apache_puerto.Name = "apache_puerto";
            apache_puerto.Size = new Size(97, 23);
            apache_puerto.TabIndex = 0;
            apache_puerto.Value = new decimal(new int[] { 8080, 0, 0, 0 });
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.AutoSize = true;
            flowLayoutPanel9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel9.Controls.Add(btn_guardar_apache);
            flowLayoutPanel9.Dock = DockStyle.Bottom;
            flowLayoutPanel9.Location = new Point(3, 48);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(103, 31);
            flowLayoutPanel9.TabIndex = 7;
            // 
            // btn_guardar_apache
            // 
            btn_guardar_apache.AutoSize = true;
            btn_guardar_apache.Location = new Point(3, 3);
            btn_guardar_apache.Name = "btn_guardar_apache";
            btn_guardar_apache.Size = new Size(97, 25);
            btn_guardar_apache.TabIndex = 0;
            btn_guardar_apache.Text = "Guardar";
            btn_guardar_apache.UseVisualStyleBackColor = true;
            btn_guardar_apache.Click += btn_guardar_apache_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoScroll = true;
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Dock = DockStyle.Top;
            flowLayoutPanel5.Location = new Point(5, 29);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(510, 0);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoScroll = true;
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel7.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel7.Controls.Add(flowLayoutPanel10);
            flowLayoutPanel7.Controls.Add(flowLayoutPanel11);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Location = new Point(5, 5);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(500, 137);
            flowLayoutPanel7.TabIndex = 2;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.AutoSize = true;
            flowLayoutPanel10.Controls.Add(install);
            flowLayoutPanel10.Dock = DockStyle.Top;
            flowLayoutPanel10.Location = new Point(3, 3);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(345, 35);
            flowLayoutPanel10.TabIndex = 3;
            // 
            // install
            // 
            install.AccessibleDescription = "Instala las aplicaciones y aplica las configuraciones guardadas";
            install.AutoSize = true;
            install.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            install.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            install.Location = new Point(3, 3);
            install.Name = "install";
            install.Size = new Size(190, 29);
            install.TabIndex = 0;
            install.Text = "Instalar y aplicar cambios";
            install.UseVisualStyleBackColor = true;
            install.Click += install_Click;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.AutoSize = true;
            flowLayoutPanel11.Controls.Add(groupBox1);
            flowLayoutPanel11.Controls.Add(groupBox2);
            flowLayoutPanel11.Controls.Add(groupBox3);
            flowLayoutPanel11.Dock = DockStyle.Fill;
            flowLayoutPanel11.Location = new Point(3, 44);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(345, 88);
            flowLayoutPanel11.TabIndex = 4;
            // 
            // TrayIcon
            // 
            TrayIcon.ContextMenuStrip = TrayMenu;
            TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            TrayIcon.Text = "MultiPHP2";
            TrayIcon.Visible = true;
            TrayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            // 
            // TrayMenu
            // 
            TrayMenu.Items.AddRange(new ToolStripItem[] { menu_iniciarServicios, menu_detenerServicios, toolStripSeparator1, menu_configurar, menu_salir });
            TrayMenu.Name = "contextMenuStrip1";
            TrayMenu.RenderMode = ToolStripRenderMode.System;
            TrayMenu.ShowImageMargin = false;
            TrayMenu.Size = new Size(139, 98);
            TrayMenu.Text = "TrayMenu";
            // 
            // menu_iniciarServicios
            // 
            menu_iniciarServicios.Name = "menu_iniciarServicios";
            menu_iniciarServicios.Size = new Size(138, 22);
            menu_iniciarServicios.Text = "&Iniciar servicios";
            menu_iniciarServicios.Click += menu_iniciarServicios_Click;
            // 
            // menu_detenerServicios
            // 
            menu_detenerServicios.Name = "menu_detenerServicios";
            menu_detenerServicios.Size = new Size(138, 22);
            menu_detenerServicios.Text = "&Detener servicios";
            menu_detenerServicios.Click += menu_detenerServicios_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(135, 6);
            // 
            // menu_configurar
            // 
            menu_configurar.Name = "menu_configurar";
            menu_configurar.Size = new Size(138, 22);
            menu_configurar.Text = "&Configurar...";
            menu_configurar.Click += menu_configurar_Click;
            // 
            // menu_salir
            // 
            menu_salir.Name = "menu_salir";
            menu_salir.Size = new Size(138, 22);
            menu_salir.Text = "Salir (&X)";
            menu_salir.Click += menu_salir_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(flowLayoutPanel7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 29);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(510, 147);
            panel2.TabIndex = 5;
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { m_archivo, m_servicios });
            menuPrincipal.Location = new Point(5, 5);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.RenderMode = ToolStripRenderMode.System;
            menuPrincipal.Size = new Size(510, 24);
            menuPrincipal.TabIndex = 6;
            menuPrincipal.Text = "MenuPrincipal";
            // 
            // m_archivo
            // 
            m_archivo.DropDownItems.AddRange(new ToolStripItem[] { m_listaIP, m_lista_procesos, toolStripSeparator2, m_clearLog, toolStripSeparator4, m_salir });
            m_archivo.Name = "m_archivo";
            m_archivo.Size = new Size(60, 20);
            m_archivo.Text = "&Archivo";
            // 
            // m_listaIP
            // 
            m_listaIP.Name = "m_listaIP";
            m_listaIP.Size = new Size(164, 22);
            m_listaIP.Text = "Lista de &IP";
            m_listaIP.Click += m_listaIP_Click;
            // 
            // m_lista_procesos
            // 
            m_lista_procesos.Name = "m_lista_procesos";
            m_lista_procesos.Size = new Size(164, 22);
            m_lista_procesos.Text = "Lista de &procesos";
            m_lista_procesos.Click += m_lista_procesos_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(161, 6);
            // 
            // m_clearLog
            // 
            m_clearLog.Name = "m_clearLog";
            m_clearLog.Size = new Size(164, 22);
            m_clearLog.Text = "&Limpiar log";
            m_clearLog.Click += m_clearLog_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(161, 6);
            // 
            // m_salir
            // 
            m_salir.Name = "m_salir";
            m_salir.Size = new Size(164, 22);
            m_salir.Text = "Salir (&X)";
            m_salir.Click += exitToolStripMenuItem_Click;
            // 
            // m_servicios
            // 
            m_servicios.DropDownItems.AddRange(new ToolStripItem[] { m_serv_iniciar, m_serv_detener });
            m_servicios.Name = "m_servicios";
            m_servicios.Size = new Size(65, 20);
            m_servicios.Text = "&Servicios";
            // 
            // m_serv_iniciar
            // 
            m_serv_iniciar.Name = "m_serv_iniciar";
            m_serv_iniciar.Size = new Size(163, 22);
            m_serv_iniciar.Text = "&Iniciar servicios";
            m_serv_iniciar.Click += m_serv_iniciar_Click;
            // 
            // m_serv_detener
            // 
            m_serv_detener.Name = "m_serv_detener";
            m_serv_detener.Size = new Size(163, 22);
            m_serv_detener.Text = "&Detener servicios";
            m_serv_detener.Click += m_serv_detener_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 176);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(510, 285);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 275);
            panel3.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtLog);
            groupBox4.Controls.Add(flowLayoutPanel1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(500, 275);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Log";
            // 
            // txtLog
            // 
            txtLog.AccessibleName = "txtLog";
            txtLog.Dock = DockStyle.Fill;
            txtLog.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLog.Location = new Point(3, 50);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(494, 222);
            txtLog.TabIndex = 0;
            txtLog.Text = "";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btn_listaIP);
            flowLayoutPanel1.Controls.Add(btn_listaProcesos);
            flowLayoutPanel1.Controls.Add(btn_limpiarLog);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(494, 31);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_listaIP
            // 
            btn_listaIP.AutoSize = true;
            btn_listaIP.Location = new Point(3, 3);
            btn_listaIP.Name = "btn_listaIP";
            btn_listaIP.Size = new Size(75, 25);
            btn_listaIP.TabIndex = 0;
            btn_listaIP.Text = "Lista de &IP";
            btn_listaIP.UseVisualStyleBackColor = true;
            btn_listaIP.Click += btn_listaIP_Click;
            // 
            // btn_listaProcesos
            // 
            btn_listaProcesos.AutoSize = true;
            btn_listaProcesos.Location = new Point(84, 3);
            btn_listaProcesos.Name = "btn_listaProcesos";
            btn_listaProcesos.Size = new Size(107, 25);
            btn_listaProcesos.TabIndex = 0;
            btn_listaProcesos.Text = "Lista de &procesos";
            btn_listaProcesos.UseVisualStyleBackColor = true;
            btn_listaProcesos.Click += btn_listaProcesos_Click;
            // 
            // btn_limpiarLog
            // 
            btn_limpiarLog.AutoSize = true;
            btn_limpiarLog.Location = new Point(197, 3);
            btn_limpiarLog.Name = "btn_limpiarLog";
            btn_limpiarLog.Size = new Size(77, 25);
            btn_limpiarLog.TabIndex = 0;
            btn_limpiarLog.Text = "&Limpiar log";
            btn_limpiarLog.UseVisualStyleBackColor = true;
            btn_limpiarLog.Click += btn_limpiarLog_Click;
            // 
            // w_Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(520, 466);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(menuPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(280, 200);
            Name = "w_Manager";
            Padding = new Padding(5);
            Text = "MultiPHP2";
            FormClosing += w_Manager_FormClosing;
            Load += w_Manager_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nginx_puerto).EndInit();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)apache_puerto).EndInit();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            flowLayoutPanel11.ResumeLayout(false);
            flowLayoutPanel11.PerformLayout();
            TrayMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel3;
        private NumericUpDown apache_puerto;
        private Button btn_guardar_apache;
        private FlowLayoutPanel flowLayoutPanel4;
        private ComboBox php_version;
        private Button btn_guardar_php;
        private FlowLayoutPanel flowLayoutPanel2;
        private NumericUpDown nginx_puerto;
        private Button btn_guardar_nginx;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel9;
        private Button install;
        private ContextMenuStrip TrayMenu;
        private ToolStripMenuItem menu_salir;
        private ToolStripMenuItem menu_configurar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menu_detenerServicios;
        private ToolStripMenuItem menu_iniciarServicios;
        private NotifyIcon TrayIcon;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel11;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem appToolStripMenuItem;
        private MenuStrip menuPrincipal;
        private ToolStripMenuItem m_archivo;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem m_salir;
        private ToolStripMenuItem m_servicios;
        private ToolStripMenuItem m_serv_iniciar;
        private ToolStripMenuItem m_serv_detener;
        private Panel panel1;
        private ToolStripMenuItem m_clearLog;
        private ToolStripMenuItem m_lista_procesos;
        private ToolStripMenuItem m_listaIP;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_listaIP;
        private Panel panel3;
        private Button btn_limpiarLog;
        private Button btn_listaProcesos;
        private RichTextBox txtLog;
        private ToolStripSeparator toolStripSeparator2;
        private GroupBox groupBox4;
    }
}
