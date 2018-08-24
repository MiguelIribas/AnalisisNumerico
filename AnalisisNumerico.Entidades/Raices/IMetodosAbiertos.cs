using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades;

namespace AnalisisNumerico.Entidades
{
    public interface IMetodosAbiertos
    {
        Resultado MetodoTangente(ParametrosRaiz parametros);

        Resultado MetodoSecante(ParametrosRaiz parametros);
    }
}
