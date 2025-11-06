using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace src_manager
{
    internal static class Program
    {
        public static w_Manager configUI { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool createdNew;
            using (Mutex mutex = new Mutex(true, Application.ProductName + ":" + GetHash(dir()), out createdNew))
            {
                if (createdNew)
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(configUI=new w_Manager());

                }
                else
                {
                    MessageBox.Show(title() + " ya está en ejecución.");
                }
            }
        }

        public static string title()
        {
            return Application.ProductName + " (" + dir() + ")";
        }

        public static string GetHash(string input)
        {
            using (MD5 hash = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);  // Convertir la cadena a bytes
                byte[] hashBytes = hash.ComputeHash(inputBytes);  // Calcular el hash

                // Convertir el hash en un formato legible (hexadecimal)
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));  // Convertir cada byte a hexadecimal
                }
                return sb.ToString();
            }
        }

        public static void ConfirmExit()
        {
            // Mostrar un cuadro de confirmación
            DialogResult result = MessageBox.Show(
                "Esto no detiene los servicios iniciados\n¿Estás seguro que deseas salir?",
                "Confirmación de salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static async Task ExecuteCmdAsync(string command, string args = "", bool interactive=true)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                UseShellExecute = interactive,
                RedirectStandardOutput = !interactive,
                FileName = command,
                WorkingDirectory = dir(),
                Arguments = args,  // El comando a ejecutar
                WindowStyle = ProcessWindowStyle.Normal
            };
            try
            {
                var tcs = new TaskCompletionSource<bool>();
                using (var process = new Process() { StartInfo = startInfo, EnableRaisingEvents = true })
                {
                    process.Exited += (s, e) => tcs.SetResult(true);
                    process.Start();
                    await tcs.Task; // Espera asíncronamente sin bloquear UI
                    if(!interactive)
                    {
                        configUI.addLog("Resultado: " + command + " " + args);
                        string output = process.StandardOutput.ReadToEnd();
                        configUI.addLog(output);
                    }
                    if (process.ExitCode != 0)
                    {
                        string msg = $"{command} terminó con error. Exitcode: {process.ExitCode}";
                        configUI.addLog(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = $"Error al ejecutar {command}:\n" + ex.Message;
                configUI.addLog(msg);
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public static string dir()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void opendir()
        {
            ExecuteCmdAsync("explorer", "\""+dir()+"\"");
        }

        public static void cmd()
        {
            ExecuteCmdAsync("cmd.exe", "/K");
        }

        public static void Lista_IP_ui() {
            ExecuteCmdAsync("bin\\iplist.bat", "1");
        }

        public static void Lista_IP()
        {
            ExecuteCmdAsync("bin\\iplist.bat", "", false);
        }

        public static void Lista_Procesos()
        {
            ExecuteCmdAsync("bin\\proclist.bat", "%cd%", false);
        }
        public static void Probar_Servicios()
        {
            ExecuteCmdAsync("service-test.bat", "1");
        }
        public static void Recargar_Servicios()
        {
            ExecuteCmdAsync("service-reload.bat");
        }
        public static void Iniciar_Servicios()
        {
            ExecuteCmdAsync("service-start.bat");
        }
        public static void Detener_Servicios()
        {
            ExecuteCmdAsync("service-stop.bat");
        }

        public static void Install()
        {
            ExecuteCmdAsync("install.bat");
        }
    }
}