
using System.Collections.Generic;

namespace AnalisisNumerico.Entidades.Ecuaciones
{
    public class ResultadoEcuaciones
    {
        public TipoResultado TipoResultado { get; set; }

        public List<decimal> ResultadosEcuaciones { get; set; }
    }

    public enum TipoResultado
    {
        Ecuacion,NoDD,DD
    }
}
