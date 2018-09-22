using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.Ecuaciones
{
    public class ParametrosGaussSeidel
    {
        public List<List<decimal>> ValoresIniciales { get; set; }

        public int Iteraciones { get; set; }

        public decimal Tolerancia { get; set; }

    }
}
