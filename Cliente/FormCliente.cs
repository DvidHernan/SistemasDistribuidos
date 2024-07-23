using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cliente
{
    public partial class FormCliente : Form
    {
        public static ConexionTcp conexionTcp = new ConexionTcp();
        public static string IPADDRESS = "127.0.0.1";
        public const int PORT = 1982;

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            //conexionTcp.OnDataRecieved += MensajeRecibido;

            //if (!conexionTcp.Connectar(IPADDRESS, PORT))
            //{
            //    MessageBox.Show("Error conectando con el servidor!");
            //    return;
            //}
        }

        private void MensajeRecibido(string datos)
        {
            var paquete = new Paquete(datos);
            string comando = paquete.Comando;
            if (comando == "resultado")
            {
                string contenido = paquete.Contenido;

                Invoke(new Action(() => lblRespuesta.Text = contenido));
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            conexionTcp.OnDataRecieved += MensajeRecibido;
            
            if (!conexionTcp.Connectar(IPADDRESS, PORT))
            {
                MessageBox.Show("Error conectando con el servidor!");
                return;
            }
            else{
                var msgPack = new Paquete("Jugador", string.Format("{0}", txtJugador.Text));
                conexionTcp.EnviarPaquete(msgPack);
            }
        }

        private void FormCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
