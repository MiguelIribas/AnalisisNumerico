using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica.Unidad_1;
using AnalisisNumerico.Entidades.Raices;

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

        [TestMethod]
        public void Tangente()
        {
            MetodosAbiertos Tangente = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 2;

            Resultado ResultadoMetodoTangente = Tangente.MetodoRaiz(new ParametrosMetodosAbiertos { Funcion = "f(x)=((x^2)-(2*x))", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial =3, TipoMetodoAbierto = TipoMetodoAbierto.Tangente });

            Assert.AreEqual(ResultadoMetodoTangente.Raiz, res.Raiz);

        }

        [TestMethod]
        public void Secante()
        {
            MetodosAbiertos Secante = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 2;

            Resultado ResultadoMetodoTangente = Secante.MetodoRaiz(new ParametrosMetodosAbiertos { Funcion = "f(x)=((x^2)-(2*x))", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 3, TipoMetodoAbierto = TipoMetodoAbierto.Secante });

            Assert.AreEqual(ResultadoMetodoTangente.Raiz, res.Raiz);

        }

    }
}
