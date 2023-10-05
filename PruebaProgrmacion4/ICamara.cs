using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaProgrmacion4
{
    public interface ICamara
    {
        public string NombreDeFoto { get; set; }
        public string CantidadDeFoto { get; set; }
        public string MostrarAppCamara();
        public void TomarFotografia(string namefoto, string candadfoto);
    }
}
