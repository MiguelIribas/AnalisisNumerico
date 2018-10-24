using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades.AjusteDeCurvas;
using org.mariuszgromada.math.mxparser;
using AnalisisNumerico.Entidades.Ecuaciones;
using AnalisisNumerico.Logica.Unidad_2;

namespace AnalisisNumerico.Logica.Unidad_3
{
    public class MinimosCuadrados : IMinimosCuadrados
    {
        public List<decimal> ValoresXi { get; set; }
        public List<decimal> MultiplicacionXY { get; set; }
        public List<List<int>> SistemaGrado10 { get; set; }

        public MinimosCuadrados()
        {
            this.ValoresXi = new List<decimal>();
            this.MultiplicacionXY = new List<decimal>();
            this.SistemaGrado10 = new List<List<int>>();
        }

        public ResultadoMinimosCuadrados ResolverCurvaLineal(ParametrosMinimosCuadrados parametros)
        {
            this.ObtenerValoresXi(parametros.ValoresX, 2);
            this.ObtenerMultiplicacionXY(parametros.ValoresX, parametros.ValoresY);

            decimal SumatoriaXY = this.ObtenerSuma(MultiplicacionXY);
            decimal SumatoriaXCuadrado = this.ObtenerSuma(ValoresXi);
            decimal SumatoriaX = this.ObtenerSuma(parametros.ValoresX);
            decimal SumatoriaY = this.ObtenerSuma(parametros.ValoresY);
            int puntos = parametros.ValoresX.Count;

            decimal Pendiente = ((puntos * SumatoriaXY) - (SumatoriaX * SumatoriaY)) / ((puntos * SumatoriaXCuadrado) - Convert.ToDecimal(Math.Pow(Convert.ToDouble(SumatoriaX), 2)));

            decimal Ordenada = ((SumatoriaY) - Pendiente * (SumatoriaX)) / puntos;

            decimal Sr = 0;

            for (int i = 0; i <= parametros.ValoresX.Count - 1; i++)
            {
                Sr += Math.Round(this.ObtenerDiferencias(Convert.ToDouble(Pendiente), Convert.ToDouble(Ordenada), Convert.ToDouble(parametros.ValoresX[i]), Convert.ToDouble(parametros.ValoresY[i])), 4);
            }
            decimal yPrima = parametros.ValoresY.Average();

            decimal St = 0;

            foreach (var y in parametros.ValoresY)
            {
                St += Convert.ToDecimal(Math.Pow(Convert.ToDouble((y - yPrima)), 2));
            }

            decimal CoeficienteCorrelacion = Convert.ToDecimal(Math.Sqrt((Convert.ToDouble(St) - Convert.ToDouble(Sr)) / Convert.ToDouble(St)));
            decimal Porcentaje = CoeficienteCorrelacion * 100;

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();
            resultado.RectaMejorAjuste = "Y = (" + (Convert.ToString(Math.Round(Pendiente, 4)) + "x");

            if (Math.Round(Ordenada, 4)<0)
            {
                resultado.RectaMejorAjuste = resultado.RectaMejorAjuste +Convert.ToString(Math.Round(Ordenada, 4)) + ")";
            }
            else
            {
                resultado.RectaMejorAjuste = resultado.RectaMejorAjuste +"+"+ Convert.ToString(Math.Round(Ordenada, 4)) + ")";
            }
            if (Porcentaje >= 80)
            {
                resultado.Ajuste = "ACEPTABLE";
            }
            else
            {
                resultado.Ajuste = "NO ACEPTABLE";
            }
            resultado.CoeficientedeCorrelacion = Math.Round(Porcentaje, 4);
            return resultado;
        }

        public ResultadoMinimosCuadrados ResolverCurvaPolinomial(ParametrosMinimosCuadrados parametros)
        {
            this.InicializarSistemaGrado10();
            MetodosEcuaciones GaussJordan = new MetodosEcuaciones();
            List<List<decimal>> SistemaResolver = this.AveriguarMatrizGrado(parametros);

            ResultadoEcuaciones Incognitas = GaussJordan.ResolverEcuacionGaussJordan(new ParametrosEcuaciones { ValoresIniciales = SistemaResolver });

            List<int> ListaIndices = new List<int>();
            for (int i = 0; i <= parametros.Grado; i++)
            {
                ListaIndices.Add(i);
            }

            string Recta = "Y = ";
            decimal ValorY = 0;
            for (int i = parametros.Grado; i >= 0; i--)
            {
                Recta += "(" + (Convert.ToString(Math.Round(Incognitas.ResultadosEcuaciones[i], 4))) + "x^(" + ListaIndices[i] + "))";
                ValorY += (Incognitas.ResultadosEcuaciones[i] * Convert.ToDecimal(Math.Pow(Convert.ToDouble(parametros.ValorX), (Convert.ToDouble(ListaIndices[i])))));

                if (i != 0)
                {
                    Recta += "+";
                }
            }           

            decimal Sr = 0;

            for (int i = 0; i <= parametros.ValoresX.Count - 1; i++)
            {
                decimal Error = 0;
                int grado = parametros.Grado;
                for (int j = Incognitas.ResultadosEcuaciones.Count - 1; j >= 0; j--)
                {
                    Error += Incognitas.ResultadosEcuaciones[j] * (Convert.ToDecimal(Math.Pow(Convert.ToDouble(parametros.ValoresX[i]), grado)));
                    grado -= 1;
                }
                Error -= parametros.ValoresY[i];

                Sr += Convert.ToDecimal(Math.Pow(Convert.ToDouble(Error), 2));
            }

            decimal St = 0;

            decimal yPrima = parametros.ValoresY.Average();

            foreach (var y in parametros.ValoresY)
            {
                St += Convert.ToDecimal(Math.Pow(Convert.ToDouble((y - yPrima)), parametros.Grado));
            }

            decimal CoeficienteCorrelacion = Convert.ToDecimal(Math.Sqrt(Math.Abs((Convert.ToDouble(St) - Convert.ToDouble(Sr))) / Convert.ToDouble(St)));
            decimal Porcentaje = CoeficienteCorrelacion * 100;           

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();
            resultado.RectaMejorAjuste = Recta;
            resultado.Imagen = ValorY;

            if (Porcentaje >= 80)
            {
                resultado.Ajuste = "ACEPTABLE";
            }
            else
            {
                resultado.Ajuste = "NO ACEPTABLE";
            }

            resultado.CoeficientedeCorrelacion = Math.Round(Porcentaje, 4);

            return resultado;
        }

        public ResultadoMinimosCuadrados ResolverPolinomioLagrange(ParametrosMinimosCuadrados parametros)
        {
            string Polinomio = "Y= ";

            for (int i = 0; i <= parametros.ValoresX.Count-1; i++)
            {
                string Numerador = "";
                for (int x = 0; x <= parametros.ValoresX.Count-1; x++)
                {
                    if (x != i)
                    {
                        if (parametros.ValoresX[x] < 0)
                        {
                            Numerador = Numerador + "(x+" + Convert.ToString(parametros.ValoresX[x]*-1) + ")";
                        }
                        else
                        {
                            Numerador = Numerador + "(x-" + Convert.ToString(parametros.ValoresX[x]) + ")";
                        }
                        if (x != parametros.ValoresX.Count - 1)
                        {
                            if (i != parametros.ValoresX.Count - 1 && x != parametros.ValoresX.Count - 2)
                            {
                                Numerador = Numerador + "*";
                            }                          
                        }
                    }
                }

                int contador = 0;
                decimal denominador = 0;

                for (int x = 0; x <= parametros.ValoresX.Count - 1; x++)
                {                               
                    decimal resta = 0;
                    if (x != i)
                    {
                        resta = parametros.ValoresX[i] - parametros.ValoresX[x];
                        contador += 1;
                        if (contador == 1)
                        {
                            denominador = resta;
                        }
                        else
                        {
                            denominador = denominador * resta;
                        }
                    }
                }
                string Polinomiox = "";
                Polinomiox = "(" + Convert.ToString(parametros.ValoresY[i] + "*" + Numerador +"/"+denominador+")");
                Polinomio = Polinomio + Polinomiox;

                if (i!=parametros.ValoresX.Count-1)
                {
                    Polinomio = Polinomio + "+";
                }
            }

            decimal ValorPunto = 0;
            if (Convert.ToString(parametros.ValorX) != "")
            {
                for (int j = 0; j <= parametros.ValoresX.Count - 1; j++)
                {
                    decimal Productoria = 0;
                    int contador = 0;
                    for (int i = 0; i <= parametros.ValoresX.Count - 1; i++)
                    {
                        if (j != i)
                        {
                            decimal Operacion = ((parametros.ValorX - parametros.ValoresX[i]) / (parametros.ValoresX[j] - parametros.ValoresX[i]));
                            contador += 1;

                            if (contador == 1)
                            {
                                Productoria = Operacion;
                            }
                            else
                            {
                                Productoria = Productoria * Operacion;
                            }
                        }
                    }
                    ValorPunto += Productoria * parametros.ValoresY[j];
                }
            }

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            resultado.RectaMejorAjuste = Polinomio;
            resultado.Imagen = ValorPunto;

            return resultado;
        }

        public void InicializarSistemaGrado10()
        {
            int contador = 0;
            for (int f = 0; f <= 9; f++)
            {
                List<int> ecuacion = new List<int>();
                int cc = f;
                for (int c = cc; c <= cc + 9; c++)
                {
                    ecuacion.Add(c);
                    //contador += 1;
                }
                this.SistemaGrado10.Add(ecuacion);
            }
        }

        public List<List<decimal>> AveriguarMatrizGrado(ParametrosMinimosCuadrados parametros)
        {
            List<List<decimal>> Matriz = new List<List<decimal>>();
            for (int i = 0; i <= parametros.Grado; i++)
            {
                List<decimal> ecuacion = new List<decimal>();

                for (int x = 0; x <= parametros.Grado; x++)
                {
                    if (i == 0 && x == 0)
                    {
                        ecuacion.Add(parametros.ValoresX.Count);
                    }
                    else
                    {
                        this.ObtenerValoresXi(parametros.ValoresX, SistemaGrado10[i][x]);
                        var SumatoriaXi = this.ObtenerSuma(ValoresXi);
                        ecuacion.Add(SumatoriaXi);
                    }
                }
                if (i == 0)
                {
                    ecuacion.Add(this.ObtenerSuma(parametros.ValoresY));
                }
                else
                {
                    this.ObtenerValoresXi(parametros.ValoresX, i);
                    this.ObtenerMultiplicacionXY(ValoresXi, parametros.ValoresY);
                    ecuacion.Add(ObtenerSuma(this.MultiplicacionXY));
                }
                Matriz.Add(ecuacion);
            }
            return Matriz;
        }

        public void ObtenerValoresXi(List<decimal> valoresx, int grado)
        {
            this.ValoresXi.Clear();
            for (int i = 0; i <= valoresx.Count - 1; i++)
            {
                this.ValoresXi.Add(Convert.ToDecimal(Math.Pow(Convert.ToDouble(valoresx[i]), grado)));
            }
        }

        public void ObtenerMultiplicacionXY(List<decimal> valoresx, List<decimal> valoresy)
        {
            this.MultiplicacionXY.Clear();
            for (int i = 0; i <= valoresx.Count - 1; i++)
            {
                this.MultiplicacionXY.Add(valoresx[i] * valoresy[i]);
            }
        }

        public decimal ObtenerSuma(List<decimal> valores)
        {
            decimal suma = 0;

            for (int i = 0; i <= valores.Count - 1; i++)
            {
                suma += valores[i];
            }

            return suma;
        }

        public decimal ObtenerDiferencias(double pendiente, double ordenada, double x, double y)
        {
            var Diferencia = Math.Pow((pendiente * x) + ordenada - y, 2);
            return Convert.ToDecimal(Diferencia);
        }
    }
}
