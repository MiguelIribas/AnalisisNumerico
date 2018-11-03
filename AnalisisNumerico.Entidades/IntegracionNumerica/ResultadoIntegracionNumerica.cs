using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.IntegracionNumerica
{
    public class ResultadoIntegracionNumerica
    {
        public decimal ValorIntegral { get; set; }

        public decimal Simpson13 { get; set; }

        public decimal Simpson38 { get; set; }
    }
}
