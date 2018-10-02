﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades.AjusteDeCurvas
{
    public interface IMinimosCuadrados
    {
        ResultadoMinimosCuadrados ResolverCurva(ParametrosMinimosCuadrados parametros);
    }
}
