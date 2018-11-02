using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.IntegracionNumerica
{
    public interface IIntegracionNumerica
    {
        ResultadoIntegracionNumerica ResolverTrapecioSimple(ParametrosIntegracionNumerica parametros);

        ResultadoIntegracionNumerica ResolverTrapecioMultiple(ParametrosIntegracionNumerica parametros);

        ResultadoIntegracionNumerica ResolverSimpson13Simple(ParametrosIntegracionNumerica parametros);

        ResultadoIntegracionNumerica ResolverSimpson13Multiple(ParametrosIntegracionNumerica parametros);

    }
}
