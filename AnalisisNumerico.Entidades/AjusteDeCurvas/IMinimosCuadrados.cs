using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.AjusteDeCurvas
{
    public interface IMinimosCuadrados
    {
        ResultadoMinimosCuadrados ResolverCurvaLineal(ParametrosMinimosCuadrados parametros);

        ResultadoMinimosCuadrados ResolverCurvaPolinomial(ParametrosMinimosCuadrados parametros);

        ResultadoMinimosCuadrados ResolverPolinomioLagrange(ParametrosMinimosCuadrados parametros);
    }
}
