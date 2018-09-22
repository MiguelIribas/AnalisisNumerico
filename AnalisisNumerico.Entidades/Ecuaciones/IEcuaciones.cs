using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.Ecuaciones
{
    public interface IEcuaciones
    {
        ResultadoEcuaciones ResolverEcuacionGaussJordan(ParametrosEcuaciones parametros);

        ResultadoEcuaciones ResolverEcuacionGaussSeidel(ParametrosGaussSeidel parametros);
    }
}
