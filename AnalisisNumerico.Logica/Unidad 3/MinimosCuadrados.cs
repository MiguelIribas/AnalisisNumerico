using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades.AjusteDeCurvas;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.Logica.Unidad_3
{
    public class MinimosCuadrados : IMinimosCuadrados
    {
        public List<decimal> ValoresXCuadrado { get; set; }
        public List<decimal> MultiplicacionXY { get; set; }

        public MinimosCuadrados()
        {
            this.ValoresXCuadrado = new List<decimal>();
            this.MultiplicacionXY = new List<decimal>();
        }

        public ResultadoMinimosCuadrados ResolverCurva(ParametrosMinimosCuadrados parametros)
        {
            this.ObtenerValoresXCuadrado(parametros.ValoresX);
            this.ObtenerMultiplicacionXY(parametros.ValoresX, parametros.ValoresY);

            decimal SumatoriaXY = this.ObtenerSuma(MultiplicacionXY);
            decimal SumatoriaXCuadrado = this.ObtenerSuma(ValoresXCuadrado);
            decimal SumatoriaX = this.ObtenerSuma(parametros.ValoresX);
            decimal SumatoriaY = this.ObtenerSuma(parametros.ValoresY);
            int puntos = parametros.ValoresX.Count;

            decimal Pendiente = ((puntos * SumatoriaXY) - (SumatoriaX * SumatoriaY)) / ((puntos * SumatoriaXCuadrado) - Convert.ToDecimal(Math.Pow(Convert.ToDouble(SumatoriaX),2)));

            decimal Ordenada = ((SumatoriaY) - Pendiente * (SumatoriaX)) / puntos;

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();
            resultado.Pendiente = Pendiente;
            resultado.Ordenada = Ordenada;

            return resultado;
        }

        public void ObtenerValoresXCuadrado(List<decimal> valoresx)
        {
            for (int i = 0; i <= valoresx.Count-1; i++)
            {
                this.ValoresXCuadrado[i] = Convert.ToDecimal(Math.Pow(Convert.ToDouble(valoresx[i]), 2));
            }
        }

        public void ObtenerMultiplicacionXY(List<decimal> valoresx,List<decimal> valoresy)
        {
            for (int i = 0; i <= valoresx.Count - 1; i++)
            {
                this.MultiplicacionXY[i] = valoresx[i] * valoresy[i];

            }
        }

        public decimal ObtenerSuma(List<decimal> valores)
        {
            decimal suma = 0;

            for (int i = 0; i <= valores.Count-1; i++)
            {
                suma += valores[i];
            }

            return suma;
        }
    }
}
