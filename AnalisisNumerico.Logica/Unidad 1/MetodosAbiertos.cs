using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.Logica.Unidad_1
{
    public class MetodosAbiertos: IMetodosAbiertos
    {
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
            double x11=0;
            double x2=0;
            double dfx = 0;
            Resultado res = new Resultado();

            if (parametros.TipoMetodo==TipoMetodo.Tangente)
            {
                var xii = new Argument("x", (parametros.ValorInicial + parametros.Tolerancia));
                x11 = (parametros.ValorInicial + parametros.Tolerancia);
                fxi = EvaluarExpresion(nombre, funcion, xi);
                fxii = EvaluarExpresion(nombre, funcion, xii);

                if (fxi == 0)
                {
                    res.Raiz = x1;
                    res.Mensaje = "Se encontró la raiz";
                    res.Iteraciones = parametros.Iteraciones;
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
                    if (fxi==0)
                    {
                        res.Raiz = x1;
                        res.Mensaje = "Se encontró la raiz";
                        res.Iteraciones = parametros.Iteraciones;
                        return res;
                    }
                    else
                    {
                        res.Raiz = x2;
                        res.Mensaje = "Se encontró la raiz";
                        res.Iteraciones = parametros.Iteraciones;
                        return res;
                    }                    
                }
            }               
            var contador = 0;
            double Xant = 0;
            double Xr = 0;           
            //VER EN QUE CASOS LA FUNCION NO TIENE RAIZ    
            if (parametros.TipoMetodo == TipoMetodo.Tangente)
            {
                Xr = AveriguarXrTangente(fxi,fxd,dfx,x1,x2); 
            }
            else
            {
                Xr = AveriguarXrSecante(fxi, fxd, dfx, x1, x2);
            }            
            contador += 1;
            var fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
            var ErrorRelativo = (Xr - Xant) / Xr;

            if (Math.Round(fXr,2) == 0)
            {
                res.Raiz = Math.Round(Xr, 6);
                res.Mensaje = "Se encontró la raiz";
                res.Iteraciones = contador;
                res.Error = ErrorRelativo;
                return res;
            }

            while (!(Math.Abs(fXr) < parametros.Tolerancia || ((Math.Abs(ErrorRelativo) < parametros.Tolerancia) && (Xr != 0)) || (contador >= parametros.Iteraciones)))
            {                
                Xant = Xr;
                if (parametros.TipoMetodo == TipoMetodo.Tangente)
                {
                    Xr = AveriguarXrTangente(fxi, fxd, dfx, x1, x2);
                }
                else
                {
                    x2=x1;
                    x1 = Xr;
                    fxi = EvaluarExpresion(nombre, funcion, new Argument("x", x1));
                    fxd = EvaluarExpresion(nombre, funcion, new Argument("x", x2));
                    Xr = AveriguarXrSecante(fxi, fxd, dfx, x1, x2);
                }
                contador += 1;
                fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
                ErrorRelativo = (Xr - Xant) / Xr;
            }
            res.Raiz = Math.Round(Xr, 6);
            res.Mensaje = "Se encontró la raiz";
            res.Iteraciones = contador;
            res.Error = ErrorRelativo;
            return res;
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
