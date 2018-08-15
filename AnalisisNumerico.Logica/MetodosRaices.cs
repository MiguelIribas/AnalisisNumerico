using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;

namespace AnalisisNumerico.Logica
{
    public class MetodosRaices : IMetodosRaices
    {
        public Resultado MetodoBiseccion(ParametrosBiseccion parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var Xi = new Argument("x1", parametros.ValorInicial);
            var Xd = new Argument("x2", parametros.ValorFinal);
            var x1 = parametros.ValorInicial;
            var x2 = parametros.ValorFinal;
            
            //validar ingresar mal los valores inicial y final.

            Resultado res = new Resultado();

            var nombre = parametros.Funcion.Split('=')[0].Trim();

            var fXi = EvaluarExpresion(funcion, Xi);
            var fXd = EvaluarExpresion(funcion, Xd);

            if (fXi * fXd != 0)
            {
                if ((fXi*fXd)<0)
                {
                    var contador = 0;
                    double Xant = 0;

                    var Xr = ((x1 * x2) / 2);
                    contador += 1;
                    var fXr = EvaluarExpresion(funcion, new Argument("x", Xr));
                    var ErrorRelativo = (Xr - Xant) / Xr;

                    while (fXr >= parametros.Tolerancia || ErrorRelativo >= parametros.Tolerancia || contador < parametros.Iteraciones)
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

                        Xr = ((x1 * x2) / 2);
                        contador += 1;
                        fXr = EvaluarExpresion(funcion, new Argument("x", Xr));
                        ErrorRelativo = (Xr - Xant) / Xr;
                    }
                    res.Raiz = Xr;
                    res.Mensaje = "Se encontró la raiz";
                    res.Iteraciones = contador;
                    res.Error = ErrorRelativo;

                    //Preguntar que devolver en caso que se supere el numero de iteraciones y la raiz no sea correcta.
                }
                else
                {
                    res.Mensaje = "Entre el valor inicial y final no existe la raiz";
                }     
            }
            else
            {
                if (fXi==0)
                {
                    res.Raiz = x1;
                    res.Mensaje = "Se encontró la raiz";
                    res.Iteraciones = parametros.Iteraciones;
                    // res.Error = parametros.Tolerancia;
                }
                else
                {
                    res.Raiz = x2;
                    res.Mensaje = "Se encontró la raiz";
                    res.Iteraciones = parametros.Iteraciones;
                   // res.Error = parametros.Tolerancia;
                }
            }

            //var expresion = new Expression(nombre, funcion, argumento1, argumento2);

            return res;

        }

        public double EvaluarExpresion(Function funcion, Argument argumento)
        {
            var expresion = new Expression(funcion, argumento);
            var fX = expresion.calculate();

            return fX;
        }
    }
}
