using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4
{
    public class DatosInicio
    {
        

        public string CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string NombrePerfil { get; set; }
        public DateTime FechaSistema { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public DatosInicio(string codigoUsuario, string nombreUsuario)
        {
            CodigoUsuario = codigoUsuario;
            NombreUsuario = nombreUsuario;
        }
        public DatosInicio() { }
    }
}
