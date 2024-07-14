using MVC_Controlador;
using MVC_Modelo;
using MVC_Vista;

namespace Trivia
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Visible = false;

            UserController controller = new UserController(principal);
            principal.ShowDialog();
        }
    }
}