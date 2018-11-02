using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades.IntegracionNumerica;
using AnalisisNumerico.Logica.Unidad_4;
using org.mariuszgromada.math.mxparser;
using AnalisisNumerico.Entidades.AjusteDeCurvas;
using AnalisisNumerico.Logica.Unidad_3;

namespace AnalisisNumerico.Logica.Unidad_4
{
    public class IntegracionNumerica : IIntegracionNumerica
    {
        public string Nombre { get; set; }
        public Function Funcion { get; set; }
        public Argument xa { get; set; }
        public Argument xb { get; set; }
        public int Subintervalos { get; set; }

        public void ObtenerParametros(ParametrosIntegracionNumerica parametros)
        {
            this.Funcion = new Function(parametros.Funcion);
            this.xa = new Argument("x", parametros.ValorExtremo1);
            this.xb = new Argument("x", parametros.ValorExtremo2);
            this.Nombre = parametros.Funcion.Split('=')[0].Trim();
            this.Subintervalos = parametros.CantidadSubintervalos;
        }

        public ResultadoIntegracionNumerica ResolverTrapecioSimple(ParametrosIntegracionNumerica parametros)
        {
            this.ObtenerParametros(parametros);

            double Area = (((this.EvaluarFuncion(Nombre,Funcion,xa)+this.EvaluarFuncion(Nombre,Funcion,xb))*(parametros.ValorExtremo2-parametros.ValorExtremo1))/2);

            ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();
            resultado.ValorIntegral = Convert.ToDecimal(Area);

            return resultado;
        }

        public ResultadoIntegracionNumerica ResolverTrapecioMultiple(ParametrosIntegracionNumerica parametros)
        {
            this.ObtenerParametros(parametros);

            double h = ((parametros.ValorExtremo2 - parametros.ValorExtremo1) / parametros.CantidadSubintervalos);
            double fxi = 0;

            var contador = parametros.ValorExtremo1;
            while (contador<parametros.ValorExtremo2)
            {
                contador = contador + h;
                Argument xi = new Argument("x", contador);
                fxi += this.EvaluarFuncion(Nombre, Funcion, xi);
            }
            double Area = ((h / 2) * (this.EvaluarFuncion(Nombre, Funcion, xa) + 2*fxi + (this.EvaluarFuncion(Nombre, Funcion, xb))));

            ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();
            resultado.ValorIntegral = Convert.ToDecimal(Area);

            return resultado;
        }

        public ResultadoIntegracionNumerica ResolverSimpson13Simple(ParametrosIntegracionNumerica parametros)
        {
            this.ObtenerParametros(parametros);

            double xi = (parametros.ValorExtremo1 + parametros.ValorExtremo2) / 2;
            Argument xii = new Argument("x", xi);

            ParametrosMinimosCuadrados parametroslagrange = new ParametrosMinimosCuadrados();

            List<Decimal> ValoresX = new List<decimal>();
            ValoresX.Add(Convert.ToDecimal(parametros.ValorExtremo1));
            ValoresX.Add(Convert.ToDecimal(xi));
            ValoresX.Add(Convert.ToDecimal(parametros.ValorExtremo2));

            List<Decimal> ValoresY = new List<decimal>();
            ValoresY.Add(Convert.ToDecimal(this.EvaluarFuncion(Nombre,Funcion,xa)));
            ValoresY.Add(Convert.ToDecimal(this.EvaluarFuncion(Nombre,Funcion,xii)));
            ValoresY.Add(Convert.ToDecimal(this.EvaluarFuncion(Nombre, Funcion, xb)));

            parametroslagrange.ValoresX = ValoresX;
            parametroslagrange.ValoresY = ValoresY;

            MinimosCuadrados minimos = new MinimosCuadrados();

            parametroslagrange.ValorX = Convert.ToDecimal(parametros.ValorExtremo1);
            var Rfxa = minimos.ResolverPolinomioLagrange(parametroslagrange);
            parametroslagrange.ValorX = Convert.ToDecimal(xi);
            var Rfxi = minimos.ResolverPolinomioLagrange(parametroslagrange);
            parametroslagrange.ValorX = Convert.ToDecimal(parametros.ValorExtremo2);
            var Rfxb = minimos.ResolverPolinomioLagrange(parametroslagrange);

            var h = (parametros.ValorExtremo2-parametros.ValorExtremo1)/ 2;

            double Area = Convert.ToDouble((h / 3) * (Convert.ToDouble(Rfxa.Imagen) + (4 * Convert.ToDouble( Rfxi.Imagen)) + Convert.ToDouble(Rfxb.Imagen)));

            ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

            resultado.ValorIntegral = Convert.ToDecimal(Area);

            return resultado;
        }

        public ResultadoIntegracionNumerica ResolverSimpson13Multiple(ParametrosIntegracionNumerica parametros)
        {
            this.ObtenerParametros(parametros);

            double h = ((parametros.ValorExtremo2 - parametros.ValorExtremo1) / parametros.CantidadSubintervalos);
            double Simpson38 = 0;


            if (parametros.CantidadSubintervalos%2!=0)
            {
                this.Subintervalos = Subintervalos- 3;

                double x0 = parametros.ValorExtremo1;
                for (int i = 1; i <= Subintervalos; i++)
                {
                    x0 += h;
                }

                Simpson38=this.ResolverSimpson38(parametros,x0);
            }

            double pares = 0;
            double impares = 0;
            double intervalo = parametros.ValorExtremo1;

            for (int i = 0; i <= Subintervalos - 1; i++)
            {
                if (i != 0 && i != Subintervalos - 1)
                {
                    if ((i % 2) == 0)
                    {
                        Argument xi = new Argument("x", intervalo);
                        pares += this.EvaluarFuncion(Nombre, Funcion, xi);
                    }
                    else
                    {
                        Argument xi = new Argument("x", intervalo);
                        impares += this.EvaluarFuncion(Nombre, Funcion, xi);
                    }
                }
                intervalo = intervalo + h;
            }

            double Simpson13 = ((h / 3) * (this.EvaluarFuncion(Nombre, Funcion, xa) + 4 * pares + 2 * impares + (this.EvaluarFuncion(Nombre, Funcion, xb))));

            ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();
            resultado.ValorIntegral = Convert.ToDecimal(Simpson13+Convert.ToDouble(Simpson38));

            return resultado;
        }

        public double ResolverSimpson38(ParametrosIntegracionNumerica parametros, double x0)
        {
            double h = ((parametros.ValorExtremo2 - x0) / 3);
           
            Argument xi0 = new Argument("x", x0);
            var x1 = x0 + h;
            Argument xi1 = new Argument("x", x1);
            var x2 = x1 + h;
            Argument xi2= new Argument("x", x2);
            var x3 = parametros.ValorExtremo2;
            Argument xi3 = new Argument("x", x3);

            double fx0 = this.EvaluarFuncion(Nombre, Funcion, xi0);
            double fx1 = this.EvaluarFuncion(Nombre, Funcion, xi1);
            double fx2= this.EvaluarFuncion(Nombre, Funcion, xi2);
            double fx3 = this.EvaluarFuncion(Nombre, Funcion, xi3);

            double Area = ((h*3)/8) * (fx0 + 3 * fx1 + 3 * fx2 + fx3);

            return Area;
        }

        public double EvaluarFuncion(string nombre, Function funcion, Argument argumento)
        {
            var expresion = new Expression(nombre, funcion, argumento);
            var fx = expresion.calculate();
            return fx;
        }

        
    }
}
