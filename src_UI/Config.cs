
namespace src_manager
{
    public partial class w_Manager : Form
    {
        public w_Manager()
        {
            InitializeComponent();
            string dir = Program.title();
            this.Text = Program.title();
            TrayIcon.Text = this.Text;
            ocultar();
        }

        public void addLog(string txt)
        {
            txtLog.AppendText(txt + "\n");
            txtLog.ScrollToCaret();
        }

        public void clearLog()
        {
            txtLog.ResetText();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.ShowInTaskbar)
            {
                ocultar();
            }
            else
            {
                mostrar();
            }
        }

        public void mostrar()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Activate();
        }

        public void ocultar()
        {
            this.Hide();
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void w_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                ocultar();
            }
        }

        private void menu_salir_Click(object sender, EventArgs e)
        {
            Program.ConfirmExit();
        }

        private void menu_configurar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void install_Click(object sender, EventArgs e)
        {
            Program.Install();
        }

        private void w_Manager_Load(object sender, EventArgs e)
        {
            if (this.ShowInTaskbar)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }

        private void menu_detenerServicios_Click(object sender, EventArgs e)
        {
            Program.Detener_Servicios();
        }

        private void menu_iniciarServicios_Click(object sender, EventArgs e)
        {
            Program.Iniciar_Servicios();
        }

        private void btn_guardar_php_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ConfirmExit();
        }

        private void m_serv_iniciar_Click(object sender, EventArgs e)
        {
            Program.Iniciar_Servicios();
        }

        private void m_serv_detener_Click(object sender, EventArgs e)
        {
            Program.Detener_Servicios();
        }

        private void m_lista_procesos_Click(object sender, EventArgs e)
        {
            Program.Lista_Procesos();
        }

        private void btn_guardar_nginx_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_apache_Click(object sender, EventArgs e)
        {

        }

        private void m_clearLog_Click(object sender, EventArgs e)
        {
            clearLog();
        }

        private void m_listaIP_Click(object sender, EventArgs e)
        {
            Program.Lista_IP();
        }

        private void btn_listaIP_Click(object sender, EventArgs e)
        {
            Program.Lista_IP();
        }

        private void btn_listaProcesos_Click(object sender, EventArgs e)
        {
            Program.Lista_Procesos();
        }

        private void btn_limpiarLog_Click(object sender, EventArgs e)
        {
            clearLog();
        }
    }
}
