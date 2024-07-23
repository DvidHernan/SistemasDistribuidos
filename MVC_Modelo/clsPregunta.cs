using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Modelo
{
    public class clsPregunta
    {
        public int codPregunta { get; set; }
        public string Pregunta { get; set; }
        public List<clsRespuesta> Respuestas { get; set; }
    }
}
