using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Entidades.Raices;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.Logica.Unidad_1
{
    public class MetodosAbiertos: IMetodosAbiertos
    {
        public Resultado MetodoTangente(ParametrosMetodosAbiertos parametros)
        {
            return this.MetodoRaiz(parametros);
        }
        
        public Resultado MetodoRaiz(ParametrosMetodosAbiertos parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var xi = new Argument("x", parametros.ValorInicial);
            var xii = new Argument("x", (parametros.ValorInicial + parametros.Tolerancia));

            double x1 = parametros.ValorInicial;
            double x11 = (parametros.ValorInicial + parametros.Tolerancia);
           
            Resultado res = new Resultado();
            var nombre = parametros.Funcion.Split('=')[0].Trim();
            var fxi = EvaluarExpresion(nombre, funcion, xi);
            var fxii = EvaluarExpresion(nombre, funcion, xii);

            var contador = 0;
            double Xant = 0;
            double Xr = 0;
            
            if (fxi==0)
            {
                res.Raiz = x1;
                res.Mensaje = "Se encontró la raiz";
                res.Iteraciones = parametros.Iteraciones;
                return res;
            }
            //VER EN QUE CASOS LA FUNCION NO TIENE RAIZ           
            var dfx = ((fxii - fxi) / parametros.Tolerancia);
            

            if (parametros.TipoMetodoAbierto == TipoMetodoAbierto.Tangente)
            {
                Xr = AveriguarXrTangente(x1,fxi,fxii);
            }
            else
            {
                Xr = AveriguarXrSecante(fxi, fxii, x1, x11);
            }
            
            contador += 1;
            var fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
            var ErrorRelativo = (Xr - Xant) / Xr;

            if (Math.Round(fXr,2) == 0)
            {
                res.Raiz = Math.Round(Xr,2);
                res.Mensaje = "Se encontró la raiz";
                res.Iteraciones = contador;
                res.Error = ErrorRelativo;
                return res;
            }

            while ((Math.Abs(fXr) >= parametros.Tolerancia || ((ErrorRelativo >= parametros.Tolerancia) && (Xr != 0)) || (contador < parametros.Iteraciones)))
            {                
                Xant = Xr;
                if (parametros.TipoMetodoAbierto == TipoMetodoAbierto.Tangente)
                {
                    Xr = AveriguarXrTangente(x1, fxi, fxii);
                }
                else
                {
                    Xr = AveriguarXrSecante(fxii, fxi, x1, x11);
                }
                contador += 1;
                fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
                ErrorRelativo = (Xr - Xant) / Xr;
            }
            res.Raiz = Math.Round(Xr, 2);
            res.Mensaje = "Se encontró la raiz";
            res.Iteraciones = contador;
            res.Error = ErrorRelativo;
            return res;
        }

        public double AveriguarXrTangente(double xi, double fxi, double dfx)
        {
            var Xr = (xi - (fxi / dfx));
            return Xr;
        }

        public double EvaluarExpresion(string nombre, Function funcion, Argument argumento)
        {
            var expresion = new Expression(nombre, funcion, argumento);
            var fX = expresion.calculate();
            return fX;
        }

        public double AveriguarXrSecante(double fxi, double fxii, double x1, double x11)
        {
            var Xr = ((fxii*x1)-(fxi*x11))/(fxii-fxi);
            return Xr;
        }

        public Resultado MetodoSecante(ParametrosMetodosAbiertos parametros)
        {
            throw new NotImplementedException();
        }
    }
}
