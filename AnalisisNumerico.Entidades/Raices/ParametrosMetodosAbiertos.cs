using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.Raices
{
    public class ParametrosMetodosAbiertos
    {
        public string Funcion { get; set; }

        public double ValorInicial { get; set; }

        public int Iteraciones { get; set; }

        public double Tolerancia { get; set; }

        public TipoMetodoAbierto TipoMetodoAbierto { get; set; }
    }

    public enum TipoMetodoAbierto
    {
        Tangente, Secante
    }

}
