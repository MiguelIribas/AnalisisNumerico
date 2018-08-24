﻿using System;
using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;

//HACER EL FORMULARIO (PASAR BIEN LOS DATOS)
//OPTIMIZAR EL CODIGO
//VALIDACIONES (X==0) Y CUANDO LA FUNCION TIENE 2 RAICES

namespace AnalisisNumerico.Logica.Unidad_1
{
    public class MetodosCerrados : IMetodosCerrados
    {
        private delegate double MetodoCerradoDelegate(double x1, double x2, double Fxd, double Fxi);

        public Resultado MetodoBiseccion(ParametrosRaiz parametros)
        {
            return this.MetodoRaiz(parametros, AveriguarXrBiseccion);
        }

        public Resultado MetodoReglaFalsa(ParametrosRaiz parametros)
        {
            return this.MetodoRaiz(parametros, AveriguarXrReglaFalsa);
        }

        private Resultado MetodoRaiz(ParametrosRaiz parametros, MetodoCerradoDelegate averiguarXr)
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
                    res.Mensaje = "SE ENCONTRÓ LA RAIZ";
                    res.Iteraciones = 0;
                }
                else
                {
                    res.Raiz = x2;
                    res.Mensaje = "SE ENCONTRÓ LA RAIZ";
                    res.Iteraciones = 0;
                }
                return res;
            }

            if ((fXi * fXd) >= 0)
            {
                //throw new ArgumentException("Entre el valor inicial y final no existe la raiz");
                res.Mensaje = "ENTRE EL VALOR INICIAL Y FINAL NO EXISTE LA RAIZ";
                res.Raiz = null;
                return res;
            }

            var contador = 0;
            double Xant = 0;

            Xr = averiguarXr(x1, x2, fXd, fXi);

            contador += 1;
            var fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
            var ErrorRelativo = (Xr - Xant) / Xr;

            if (fXr == 0)
            {
                res.Raiz = Xr;
                res.Mensaje = "SE ENCONTRÓ LA RAIZ";
                res.Iteraciones = contador;
                res.Error = ErrorRelativo;
                return res;
            }

            while ((Math.Abs(fXr) >= parametros.Tolerancia || ((ErrorRelativo >= parametros.Tolerancia) && (Xr != 0)) || (contador < parametros.Iteraciones)))
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

                Xr = averiguarXr(x1, x2, fXd, fXi);

                contador += 1;
                fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
                ErrorRelativo = (Xr - Xant) / Xr;
            }
            res.Raiz = Math.Round(Xr, 2);
            res.Mensaje = "SE ENCONTRÓ LA RAIZ";
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

        public double AveriguarXrBiseccion(double x1, double x2, double Fxd, double Fxi)
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
