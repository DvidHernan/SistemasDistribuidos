using MVC_Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Vista
{
    public partial class FormPrincipal : Form, IUserView
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        UserController _controller;

        public void SetController(UserController controller)
        {
            _controller = controller;
        }

        private void btnJugador_Click(object sender, EventArgs e)
        {
            FormJugador jugador = new FormJugador();
            jugador.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numero = random.Next(5000, 50000);
            txtNuevo.Text = numero.ToString();
        }
    }
}
