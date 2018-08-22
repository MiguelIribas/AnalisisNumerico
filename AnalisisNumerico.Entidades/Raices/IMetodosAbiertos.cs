using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades.Raices;

namespace AnalisisNumerico.Entidades
{
    public interface IMetodosAbiertos
    {
        Resultado MetodoTangente(ParametrosMetodosAbiertos parametros);

        Resultado MetodoSecante(ParametrosMetodosAbiertos parametros);
    }
}
