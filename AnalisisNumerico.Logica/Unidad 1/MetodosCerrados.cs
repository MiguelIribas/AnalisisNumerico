using System;
using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;


namespace AnalisisNumerico.Logica.Unidad_1
{
    public class MetodosCerrados : IMetodosCerrados
    {
        public double Xr { get; set; }
        public int contador { get; set; }
        public double Xant { get; set; }
        public double fXr { get; set; }
        public double ErrorRelativo { get; set; }

        public MetodosCerrados()
        {
            this.Xr = 0;
            this.contador = 0;
            this.Xant = 0;
            this.fXr = 0;
            this.ErrorRelativo = 0;
        }

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
            Function funcion = new Function(parametros.Funcion);
            var Xi = new Argument("x", parametros.ValorInicial);
            var Xd = new Argument("x", parametros.ValorFinal);
            double x1 = parametros.ValorInicial;
            double x2 = parametros.ValorFinal;

            Resultado res = new Resultado();
            var nombre = parametros.Funcion.Split('=')[0].Trim();
            var fXi = EvaluarExpresion(nombre, funcion, Xi);
            var fXd = EvaluarExpresion(nombre, funcion, Xd);

            this.Xr = 0;
            this.contador = 0;
            this.Xant = 0;
            this.fXr = 0;
            this.ErrorRelativo = 0;

            if (double.IsNaN(fXi)|| double.IsNaN(fXd))
            {
                res.Mensaje = "LA FUNCIÓN INGRESADA ES INCORRECTA";
                res.Raiz = null;
                res.TipoResultado = TipoResultado.FuncionIncorrecta;
                return res;
            }
          
            if (fXi * fXd == 0)
            {
                res.Mensaje = "SE ENCONTRÓ LA RAIZ";
                res.Iteraciones = 1;
                res.Raiz = x1;
                res.Error = ErrorRelativo;
                res.TipoResultado = TipoResultado.Raiz;

                if (fXd == 0)
                {
                    res.Raiz = x2;
                }

                return res;
            }

            if ((fXi * fXd) >= 0)
            {
                res.Mensaje = "ENTRE EL VALOR INICIAL Y FINAL NO EXISTE LA RAIZ";
                res.Raiz = null;
                res.TipoResultado = TipoResultado.FueradeLimites;
                return res;
            }

            this.AveriguarDatos(averiguarXr, x1, x2, fXi, fXd, nombre, funcion);

            if (fXr == 0)
            {
                res.Raiz = Math.Round(Xr, 6);
                res.Mensaje = "SE ENCONTRÓ LA RAIZ";
                res.Iteraciones = contador;
                res.TipoResultado = TipoResultado.Raiz;
                res.Error = ErrorRelativo;
                return res;
            }

            while (!(Math.Abs(fXr) < parametros.Tolerancia || ((Math.Abs(ErrorRelativo) < parametros.Tolerancia) && (Xr != 0)) || (contador >= parametros.Iteraciones)))
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

                this.AveriguarDatos(averiguarXr, x1, x2, fXi, fXd, nombre, funcion);
            }
            res.Raiz = Math.Round(Xr, 6);
            res.Mensaje = "SE ENCONTRÓ LA RAIZ";
            res.Iteraciones = contador;
            res.TipoResultado = TipoResultado.Raiz;
            res.Error = ErrorRelativo;
            return res;
        }

        public double EvaluarExpresion(string nombre, Function funcion, Argument argumento)
        {
            var expresion = new Expression(nombre, funcion, argumento);
            var fX = expresion.calculate();
            return fX;
        }

        private void AveriguarDatos(MetodoCerradoDelegate averiguarXr, double x1, double x2, double fXi, double fXd, string nombre, Function funcion)
        {
            Xr = averiguarXr(x1, x2, fXd, fXi);
            contador += 1;
            fXr = EvaluarExpresion(nombre, funcion, new Argument("x", Xr));
            ErrorRelativo = Math.Abs((Xr - Xant) / Xr);
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
