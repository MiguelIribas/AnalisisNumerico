using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica.Unidad_1;

namespace AnalisisNumerico.Logica.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Biseccion()
        {
            MetodosCerrados Biseccion = new MetodosCerrados();
            Resultado res = new Resultado();
            res.Raiz = -4;

            Resultado ResultadoMetodoBiseccion = Biseccion.MetodoRaiz(new ParametrosMetodosCerrados { Funcion = "f(x)=((x^2)+4*x)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = -5, ValorFinal = -1 , TipoMetodoCerrado=TipoMetodoCerrado.Biseccion});

            Assert.AreEqual(ResultadoMetodoBiseccion.Raiz, res.Raiz);

        }

        [TestMethod]
        public void ReglaFalsa()
        {
            MetodosCerrados ReglaFalsa = new MetodosCerrados();
            Resultado res = new Resultado();
            res.Raiz = 3;

            Resultado ResultadoMetodoReglaFalsa = ReglaFalsa.MetodoRaiz(new ParametrosMetodosCerrados { Funcion = "f(x)=x-3", Iteraciones = 1000, Tolerancia = 0.001, ValorInicial = 2, ValorFinal = 4, TipoMetodoCerrado = TipoMetodoCerrado.ReglaFalsa });
            Assert.IsTrue(ResultadoMetodoReglaFalsa.Raiz > 2.999 && ResultadoMetodoReglaFalsa.Raiz < 3.001);

        }

    }
}
