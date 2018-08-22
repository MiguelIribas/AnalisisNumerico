using System;
using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;


//public delegate void DelegadoRaiz();


//DELEGADO
//HACER EL FORMULARIO (PASAR BIEN LOS DATOS)
//OPTIMIZAR EL CODIGO
//VALIDACIONES (X==0) Y CUANDO LA FUNCION TIENE 2 RAICES

namespace AnalisisNumerico.Logica.Unidad_1
{
    public class MetodosCerrados : IMetodosCerrados
    {
        public Resultado MetodoBiseccion(ParametrosMetodosCerrados parametros)
        {
            return this.MetodoRaiz(parametros);
        }

        public Resultado MetodoReglaFalsa(ParametrosMetodosCerrados parametros)
        {
            return this.MetodoRaiz(parametros);
        }

        public Resultado MetodoRaiz(ParametrosMetodosCerrados parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var Xi = new Argument("x", parametros.ValorInicial);
            var Xd = new Argument("x", parametros.ValorFinal);
            double x1 = parametros.ValorInicial;
            double x2 = parametros.ValorFinal;

            Resultado res = new Resultado();
            var nombre = parametros.Funcion.Split('=')[0].Trim();
            var fXi = EvaluarExpresion(nombre, funcion, Xi);
            var fXd = EvaluarExpresion(nombre, funcion, Xd);
            double Xr = 0;

            if (fXi * fXd == 0)
            {
                if (fXi == 0)
                {
                    res.Raiz = x1;
                    res.Mensaje = "Se encontró la raiz";
                    res.Iteraciones = parametros.Iteraciones;
                }
                else
                {
                    res.Raiz = x2;
                    res.Mensaje = "Se encontró la raiz";
                    res.Iteraciones = parametros.Iteraciones;
                }
                return res;
            }

            if ((fXi * fXd) >= 0)
            {
                //throw new ArgumentException("Entre el valor inicial y final no existe la raiz");
                res.Mensaje = "Entre el valor inicial y final no existe la raiz";
                return res;
            }

            var contador = 0;
            double Xant = 0;

            if (parametros.TipoMetodoCerrado == TipoMetodoCerrado.Biseccion)
            {
                Xr = AveriguarXrBiseccion(x1, x2);
            }
            else
            {
                Xr = AveriguarXrReglaFalsa(x1, x2, fXd, fXi);
            }
            contador += 1;
            var fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
            var ErrorRelativo = (Xr - Xant) / Xr;

            if (fXr==0)
            {
                res.Raiz = Xr;
                res.Mensaje = "Se encontró la raiz";
                res.Iteraciones = contador;
                res.Error = ErrorRelativo;
                return res;
            }
                             
            while ((Math.Abs(fXr) >= parametros.Tolerancia || ((ErrorRelativo >= parametros.Tolerancia) && (Xr!=0)) || (contador < parametros.Iteraciones)))
            {
                if ((fXi * fXr) > 0)
                {
                    x1 = Xr;
                }
                else
                {
                    x2 = Xr;
                }
                Xant = Xr;

                if (parametros.TipoMetodoCerrado == TipoMetodoCerrado.Biseccion)
                {
                    Xr = AveriguarXrBiseccion(x1, x2);
                }
                else
                {
                    Xr = AveriguarXrReglaFalsa(x1, x2, fXd, fXi);
                }
                contador += 1;
                fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
                ErrorRelativo = (Xr - Xant) / Xr;
            }
            res.Raiz = Math.Round(Xr,2);
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

        public double AveriguarXrBiseccion(double x1, double x2)
        {
            var Xr = ((x1 + x2) / 2);
            return Xr;
        }

        public double AveriguarXrReglaFalsa(double x1, double x2, double Fxd, double Fxi)
        {
            var Xr = (Fxd * x1 - Fxi * x2) / (Fxd - Fxi);
            return Xr;
        }
    }
}
