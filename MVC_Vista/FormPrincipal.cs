using MVC_Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MVC_Vista
{
    public partial class FormPrincipal : Form, IUserView
    {
        int contador = 0;
        public delegate void ClientCarrier(ConexionTcp conexionTcp);
        public event ClientCarrier OnClientConnected;
        public event ClientCarrier OnClientDisconnected;
        public delegate void DataRecieved(ConexionTcp conexionTcp, string data);
        public event DataRecieved OnDataRecieved;

        private TcpListener _tcpListener;
        private Thread _acceptThread;
        private List<ConexionTcp> connectedClients = new List<ConexionTcp>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        UserController _controller;

        public void SetController(UserController controller)
        {
            _controller = controller;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numero = random.Next(5000, 50000);
            txtNuevo.Text = numero.ToString();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            OnDataRecieved += MensajeRecibido;
            OnClientConnected += ConexionRecibida;
            OnClientDisconnected += ConexionCerrada;

            EscucharClientes("127.0.0.1", 1982);
        }

        private void MensajeRecibido(ConexionTcp conexionTcp, string datos)
        {
            var paquete = new Paquete(datos);
            string comando = paquete.Comando;
            if (comando == "Jugador")
            {
                string contenido = paquete.Contenido;
                List<string> valores = Mapa.Deserializar(contenido);
                contador += 1;
                string respuesta = valores[0];

                System.Windows.Forms.Button btnJugador = new System.Windows.Forms.Button();
                btnJugador.Name = "btnjugador" + contador.ToString();
                btnJugador.Height = 35;
                btnJugador.Width = 200;
                btnJugador.Text = respuesta;
                btnJugador.BackColor = System.Drawing.Color.White;
                btnJugador.TextAlign= System.Drawing.ContentAlignment.MiddleCenter;

                Invoke(new Action(() => flpJugadores.Controls.Add(btnJugador)));

                var msgPack = new Paquete("resultado", "Bienvenido");
                conexionTcp.EnviarPaquete(msgPack);
            }
        }

        private void ConexionRecibida(ConexionTcp conexionTcp)
        {
            lock (connectedClients)
                if (!connectedClients.Contains(conexionTcp))
                    connectedClients.Add(conexionTcp);
            Invoke(new Action(() => lblJugadores.Text = string.Format("{0}", connectedClients.Count)));
        }

        private void ConexionCerrada(ConexionTcp conexionTcp)
        {
            lock (connectedClients)
                if (connectedClients.Contains(conexionTcp))
                {
                    int cliIndex = connectedClients.IndexOf(conexionTcp);
                    connectedClients.RemoveAt(cliIndex);
                }
            Invoke(new Action(() => lblJugadores.Text = string.Format("{0}", connectedClients.Count)));
        }

        private void EscucharClientes(string ipAddress, int port)
        {
            try
            {
                _tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
                _tcpListener.Start();
                _acceptThread = new Thread(AceptarClientes);
                _acceptThread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private void AceptarClientes()
        {
            do
            {
                try
                {
                    var conexion = _tcpListener.AcceptTcpClient();
                    var srvClient = new ConexionTcp(conexion)
                    {
                        ReadThread = new Thread(LeerDatos)
                    };
                    srvClient.ReadThread.Start(srvClient);

                    if (OnClientConnected != null)
                        OnClientConnected(srvClient);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            } while (true);
        }

        private void LeerDatos(object client)
        {
            var cli = client as ConexionTcp;
            var charBuffer = new List<int>();

            do
            {
                try
                {
                    if (cli == null)
                        break;
                    if (cli.StreamReader.EndOfStream)
                        break;
                    int charCode = cli.StreamReader.Read();
                    if (charCode == -1)
                        break;
                    if (charCode != 0)
                    {
                        charBuffer.Add(charCode);
                        continue;
                    }
                    if (OnDataRecieved != null)
                    {
                        var chars = new char[charBuffer.Count];
                        //Convert all the character codes to their representable characters
                        for (int i = 0; i < charBuffer.Count; i++)
                        {
                            chars[i] = Convert.ToChar(charBuffer[i]);
                        }
                        //Convert the character array to a string
                        var message = new string(chars);

                        //Invoke our event
                        OnDataRecieved(cli, message);
                    }
                    charBuffer.Clear();
                }
                catch (IOException)
                {
                    break;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());

                    break;
                }
            } while (true);

            if (OnClientDisconnected != null)
                OnClientDisconnected(cli);
        }
    }
}
