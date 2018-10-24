using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.AjusteDeCurvas
{
    public class ResultadoMinimosCuadrados
    {
        public string RectaMejorAjuste { get; set; }
        public string Ajuste { get; set; }
        public decimal CoeficientedeCorrelacion { get; set; }
        public decimal Imagen { get; set; }
    }
}
