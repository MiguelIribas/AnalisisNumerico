using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.IntegracionNumerica
{
    public class ParametrosIntegracionNumerica
    {
        public string Funcion { get; set; }

        public double ValorExtremo1 { get; set; }

        public double ValorExtremo2 { get; set; }

        public int CantidadSubintervalos { get; set; }
    }
}
