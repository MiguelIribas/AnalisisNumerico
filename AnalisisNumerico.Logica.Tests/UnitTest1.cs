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
            Resultado ResultadoMetodoBiseccion = Biseccion.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=((x^2)+4*x)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = -5, ValorFinal = -1, TipoMetodo = TipoMetodo.Biseccion });
            Assert.AreEqual(ResultadoMetodoBiseccion.Raiz, res.Raiz);
        }

        [TestMethod]
        public void Biseccion2()
        {
            MetodosCerrados Biseccion = new MetodosCerrados();
            Resultado res = new Resultado();

            res.Raiz = 1.249877;
            Resultado ResultadoMetodoBiseccion2 = Biseccion.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=(x^5-1)*Exp(1)^x-10", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 1, ValorFinal = 1.5, TipoMetodo = TipoMetodo.Biseccion });
            Assert.AreEqual(ResultadoMetodoBiseccion2.Raiz, res.Raiz);
        }

        

        [TestMethod]
        public void ReglaFalsa()
        {
            MetodosCerrados ReglaFalsa = new MetodosCerrados();
            Resultado res = new Resultado();
            res.Raiz = 3;

            Resultado ResultadoMetodoReglaFalsa = ReglaFalsa.MetodoReglaFalsa(new ParametrosRaiz { Funcion = "f(x)=x-3", Iteraciones = 1000, Tolerancia = 0.001, ValorInicial = 2, ValorFinal = 4, TipoMetodo = TipoMetodo.ReglaFalsa });
            Assert.IsTrue(ResultadoMetodoReglaFalsa.Raiz > 2.999 && ResultadoMetodoReglaFalsa.Raiz < 3.001);

        }

        [TestMethod]
        public void Tangente()
        {
            MetodosAbiertos Tangente = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 2;

            Resultado ResultadoMetodoTangente = Tangente.MetodoTangente(new ParametrosRaiz { Funcion = "f(x)=((x^2)-(2*x))", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 3, TipoMetodo = TipoMetodo.Tangente });

            Assert.AreEqual(ResultadoMetodoTangente.Raiz, res.Raiz);

        }

        [TestMethod]
        public void Secante()
        {
            MetodosAbiertos Secante = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 2;

            Resultado ResultadoMetodoSecante = Secante.MetodoSecante(new ParametrosRaiz { Funcion = "f(x)=((x^2)-2*x)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 3, ValorFinal = 5, TipoMetodo = TipoMetodo.Secante });

            Assert.AreEqual(ResultadoMetodoSecante.Raiz, res.Raiz);

        }

    }
}
