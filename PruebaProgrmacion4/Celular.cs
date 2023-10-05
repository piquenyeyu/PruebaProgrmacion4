using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaProgrmacion4
{
    public class Celular : ICamara
    {
        public string NombreDeFoto { get; set; }
        public string CantidadDeFoto { get; set; }

        public string MostrarAppCamara()
        {
            string Mostrar = "mostrando la App de la Cámara";
            return Mostrar;
        }

        public void TomarFotografia(string namefoto, string candadfoto)
        {

           Console.WriteLine($"Tomando fotografia , Con Nombre: {namefoto} y Registro {candadfoto}");

        }
    }
}
