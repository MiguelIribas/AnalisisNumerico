using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.Logica.Unidad_1
{
    public class MetodosAbiertos : IMetodosAbiertos
    {
        public double Xr { get; set; }
        public int contador { get; set; }
        public double Xant { get; set; }
        public double fXr { get; set; }
        public double ErrorRelativo { get; set; }

        public MetodosAbiertos()
        {
            this.Xr = 0;
            this.contador = 0;
            this.Xant = 0;
            this.fXr = 0;
            this.ErrorRelativo = 0;
        }

        private delegate double MetodoAbiertoDelegate(double fxi, double fxd, double dfx, double x1, double x2);

        public Resultado MetodoTangente(ParametrosRaiz parametros)
        {
            return this.MetodoRaiz(parametros, AveriguarXrTangente);
        }

        public Resultado MetodoSecante(ParametrosRaiz parametros)
        {
            return this.MetodoRaiz(parametros, AveriguarXrSecante);
        }

        private Resultado MetodoRaiz(ParametrosRaiz parametros, MetodoAbiertoDelegate averiguarXr)
        {
            var funcion = new Function(parametros.Funcion);

            var xi = new Argument("x", parametros.ValorInicial);
            double x1 = parametros.ValorInicial;
            var nombre = parametros.Funcion.Split('=')[0].Trim();
            double fxi = 0;
            double fxii = 0;
            double fxd = 0;
            double x11 = 0;
            double x2 = 0;
            double dfx = 0;
            
            this.Xr = 0;
            this.contador = 0;
            this.Xant = 0;
            this.fXr = 0;
            this.ErrorRelativo = 0;

            Resultado res = new Resultado();

            if (parametros.TipoMetodo == TipoMetodo.Tangente)
            {
                var xii = new Argument("x", (parametros.ValorInicial + parametros.Tolerancia));
                x11 = (parametros.ValorInicial + parametros.Tolerancia);
                fxi = EvaluarExpresion(nombre, funcion, xi);
                fxii = EvaluarExpresion(nombre, funcion, xii);

                if (fxi == 0)
                {
                    res.Raiz = x1;
                    res.Mensaje = "SE ENCONTRO LA RAIZ.";
                    res.Error = ErrorRelativo;
                    res.Iteraciones = 1;
                    res.TipoResultado = TipoResultado.Raiz;
                    return res;
                }
                dfx = ((fxii - fxi) / parametros.Tolerancia);
            }
            else
            {
                var xd = new Argument("x", parametros.ValorFinal);
                x2 = parametros.ValorFinal;
                fxi = EvaluarExpresion(nombre, funcion, xi);
                fxd = EvaluarExpresion(nombre, funcion, xd);
                if (fxi * fxd == 0)
                {
                    res.Mensaje = "SE ENCONTRO LA RAIZ.";
                    res.Iteraciones = 1;
                    res.TipoResultado = TipoResultado.Raiz;
                    res.Raiz = x1;

                    if (fxd == 0)
                    {
                        res.Raiz = x2;
                    }
                    return res;
                }
            }        
            //VER EN QUE CASOS LA FUNCION NO TIENE RAIZ    

            this.AveriguarDatos(averiguarXr, x1, x2, fxi, fxd, dfx, nombre, funcion);

            if (Math.Round(fXr, 2) == 0)
            {
                res.Raiz = Math.Round(Xr, 6);
                res.Mensaje = "SE ENCONTRO LA RAIZ.";
                res.Iteraciones = contador;
                res.TipoResultado = TipoResultado.Raiz;
                res.Error = ErrorRelativo;
                return res;
            }

            while (!(Math.Abs(fXr) < parametros.Tolerancia || ((Math.Abs(ErrorRelativo) < parametros.Tolerancia) && (Xr != 0)) || (contador >= parametros.Iteraciones)))
            {
                Xant = Xr;

                if (parametros.TipoMetodo == TipoMetodo.Secante)
                {
                    x2 = x1;
                    x1 = Xr;
                    fxi = EvaluarExpresion(nombre, funcion, new Argument("x", x1));
                    fxd = EvaluarExpresion(nombre, funcion, new Argument("x", x2));
                }
                else
                {
                    x1 = Xr;
                    fxi = EvaluarExpresion(nombre, funcion, new Argument("x", x1));
                }

                this.AveriguarDatos(averiguarXr, x1, x2, fxi, fxd, dfx, nombre, funcion);
            }

            if (contador == parametros.Iteraciones && double.IsNaN(ErrorRelativo) && double.IsNaN(Xr))
            {
                if (parametros.TipoMetodo==TipoMetodo.Tangente)
                {
                    res.Mensaje = "EL VALOR INGRESADO "+ parametros.ValorInicial+" ES INCORRECTO. NO SE PUEDE EVALUAR LA FUNCION O LA RECTA TANGENTE EVALUADA EN ESE PUNTO ES CONSTANTE.";
                }
                else
                {
                    res.Mensaje = "NO SE PUEDE EVALUAR LA FUNCION EN LOS PUNTOS INGRESADOS";
                }               
                res.Raiz = null;
                res.Error = null;
                res.TipoResultado = TipoResultado.Constante;
                return res;
            }
            else
            {
                res.Raiz = Math.Round(Xr, 6);
                res.Mensaje = "SE ENCONTRO LA RAIZ.";
                res.TipoResultado = TipoResultado.Raiz;
                res.Iteraciones = contador;
                res.Error = ErrorRelativo;
                return res;
            }
        }

        private void AveriguarDatos(MetodoAbiertoDelegate averiguarXr, double x1, double x2, double fxi, double fxd, double dfx,string nombre, Function funcion)
        {
            Xr = averiguarXr(fxi,fxd,dfx,x1,x2);
            contador += 1;
            fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
            ErrorRelativo = Math.Abs(Xr - Xant) / Xr;
        }

        public double EvaluarExpresion(string nombre, Function funcion, Argument argumento)
        {
            var expresion = new Expression(nombre, funcion, argumento);
            var fX = expresion.calculate();
            return fX;
        }

        public double AveriguarXrTangente (double fxi, double fxd, double dfx, double x1, double x2) //(double xi, double fxi, double dfx)
        {
            var Xr = (x1 - (fxi / dfx));
            return Xr;
        }

        public double AveriguarXrSecante(double fxi, double fxd, double dfx, double x1, double x2)
        {
            var Xr = ((fxd * x1)-(fxi*x2))/(fxd-fxi);
            return Xr;
        }        
    }
}
