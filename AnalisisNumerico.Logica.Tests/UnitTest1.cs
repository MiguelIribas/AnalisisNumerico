using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;

namespace AnalisisNumerico.Logica.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Biseccion()
        {
            MetodosRaices metodosraices = new MetodosRaices();
            Resultado res = new Resultado();
            res.Raiz = 2;

            Resultado ResultadoMetodo = metodosraices.MetodoBiseccion(new ParametrosBiseccion { Funcion = "f(x)=x-3", Iteraciones = 1000, Tolerancia = 0.0001, ValorInicial = 1, ValorFinal = 5 });

            Assert.AreEqual(ResultadoMetodo.Raiz, res.Raiz);
            //HOLA CHAU
        }
    }
}
