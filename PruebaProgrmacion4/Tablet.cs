using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaProgrmacion4
{
    public class Tablet : IGps, ICamara
    {
        public string NombreDeFoto { get; set; }
        public string CantidadDeFoto { get; set; }

        public string Localizar()
        {
            string Localizando = "Localizando";
            return Localizando;
        }
        public string ObtenerCoordenadas()
        {
            string obteneerCoordenadas = "Las Coordenadas son: 48o 51’ 30.2328’’N, 2o 17’ 40.1388’’E";
            return obteneerCoordenadas;
        }

        public string MostrarAppCamara()
        {
            throw new NotImplementedException();
        }

        public void TomarFotografia(string namefoto, string candadfoto)
        {
            throw new NotImplementedException();
        }
    }
}
