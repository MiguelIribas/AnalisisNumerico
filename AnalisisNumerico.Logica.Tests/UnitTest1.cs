using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica.Unidad_1;


namespace AnalisisNumerico.Logica.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //SIII DAAAA
        public void BiseccionEjercicio1()
        {
            MetodosCerrados Biseccion = new MetodosCerrados();
            Resultado res = new Resultado();

            res.Raiz = 1.3000;
            Resultado ResultadoMetodoBiseccion = Biseccion.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=((x^5-1)*exp(1)^x-10)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 1, ValorFinal = 2, TipoMetodo = TipoMetodo.Biseccion });
            Assert.AreEqual(ResultadoMetodoBiseccion.Raiz, res.Raiz);
        }

        [TestMethod] //MAL ESCRITA LA FUNCION
        public void BiseccionEjercicio2()
        {
            MetodosCerrados Biseccion = new MetodosCerrados();
            Resultado res = new Resultado();

            res.Raiz = 0.22;
            Resultado ResultadoMetodoBiseccion2 = Biseccion.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=(log(x+1)/(x-3))", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 0.1, ValorFinal =0.3, TipoMetodo = TipoMetodo.Biseccion });
            Assert.AreEqual(ResultadoMetodoBiseccion2.Raiz, res.Raiz);
        }

        [TestMethod] //SIII DAAAA
        public void BiseccionEjercicio3()
        {
            MetodosCerrados Biseccion = new MetodosCerrados();
            Resultado res = new Resultado();

            res.Raiz = 6.699;
            Resultado ResultadoMetodoBiseccion2 = Biseccion.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=((1/10*(x-3)^(1/5))+(1/24*x^2)-2)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 5, ValorFinal = 10, TipoMetodo = TipoMetodo.Biseccion });
            Assert.AreEqual(ResultadoMetodoBiseccion2.Raiz, res.Raiz);
        }
        

               
        [TestMethod] //SIII DAAAA
        public void ReglaFalsaEjercicio1()
        {
            MetodosCerrados ReglaFalsa = new MetodosCerrados();
            Resultado res = new Resultado();

            res.Raiz = 1.3000;
            Resultado ResultadoMetodoReglaFalsa = ReglaFalsa.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=((x^5-1)*exp(1)^x-10)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 1, ValorFinal = 2, TipoMetodo = TipoMetodo.Biseccion });
            Assert.AreEqual(ResultadoMetodoReglaFalsa.Raiz, res.Raiz);
        }

        [TestMethod] //MAL ESCRITA LA FUNCION
        public void ReglaFalsaEjercicio2()
        {
            MetodosCerrados ReglaFalsa = new MetodosCerrados();
            Resultado res = new Resultado();

            res.Raiz = 1.300728;
            Resultado ResultadoMetodoReglaFalsa = ReglaFalsa.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=(x^5-1)*Exp(1)^x-10", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 1, ValorFinal = 1.5, TipoMetodo = TipoMetodo.ReglaFalsa });
            Assert.AreEqual(ResultadoMetodoReglaFalsa.Raiz, res.Raiz);
        }

        [TestMethod] //SIII DAAAA
        public void ReglaFalsaEjercicio3()
        {
            MetodosCerrados ReglaFalsa = new MetodosCerrados();
            Resultado res = new Resultado();

            res.Raiz = 6.699;
            Resultado ResultadoMetodoReglaFalsa = ReglaFalsa.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=((1/10*(x-3)^(1/5))+(1/24*x^2)-2)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 5, ValorFinal = 10, TipoMetodo = TipoMetodo.Biseccion });
            Assert.AreEqual(ResultadoMetodoReglaFalsa.Raiz, res.Raiz);
        }



        [TestMethod] //VER DE USAR LAS MISMAS FUNCIONES PERO INGRESANDO UN SOLO VALOR
        public void TangenteEjercicio1()
        {
            MetodosAbiertos Tangente = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 2;

            Resultado ResultadoMetodoTangente = Tangente.MetodoTangente(new ParametrosRaiz { Funcion = "f(x)=((x^5-1)*exp(1)^x-10)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 1, TipoMetodo = TipoMetodo.Biseccion });

            Assert.AreEqual(ResultadoMetodoTangente.Raiz, res.Raiz);

        }

        [TestMethod] //VER DE USAR LAS MISMAS FUNCIONES PERO INGRESANDO UN SOLO VALOR
        public void TangenteEjercicio2()
        {
            MetodosAbiertos Tangente = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 2;

            Resultado ResultadoMetodoTangente = Tangente.MetodoTangente(new ParametrosRaiz { Funcion = "f(x)=((x^2)-(2*x))", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 3, TipoMetodo = TipoMetodo.Tangente });

            Assert.AreEqual(ResultadoMetodoTangente.Raiz, res.Raiz);

        }

        [TestMethod] //VER DE USAR LAS MISMAS FUNCIONES PERO INGRESANDO UN SOLO VALOR
        public void TangenteEjercicio3()
        {
            MetodosAbiertos Tangente = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 2;

            Resultado ResultadoMetodoTangente = Tangente.MetodoTangente(new ParametrosRaiz { Funcion = "f(x)=((x^2)-(2*x))", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 3, TipoMetodo = TipoMetodo.Tangente });

            Assert.AreEqual(ResultadoMetodoTangente.Raiz, res.Raiz);

        }



        [TestMethod] //SIII DAAAA
        public void SecanteEjercicio1()
        {
            MetodosAbiertos Secante = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 1.3000;

            Resultado ResultadoMetodoSecante = Secante.MetodoSecante(new ParametrosRaiz { Funcion = "f(x)=((x^5-1)*exp(1)^x-10)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 1, ValorFinal = 2, TipoMetodo = TipoMetodo.Biseccion });

            Assert.AreEqual(ResultadoMetodoSecante.Raiz, res.Raiz);

        }

        [TestMethod] //MAL ESCRITA LA FUNCION
        public void SecanteEjercicio2()
        {
            MetodosAbiertos Secante = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 2;

            Resultado ResultadoMetodoSecante = Secante.MetodoSecante(new ParametrosRaiz { Funcion = "f(x)=((x^2)-2*x)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 3, ValorFinal = 5, TipoMetodo = TipoMetodo.Secante });

            Assert.AreEqual(ResultadoMetodoSecante.Raiz, res.Raiz);

        }

        [TestMethod]//SIII DAAAA
        public void SecanteEjercicio3()
        {
            MetodosAbiertos Secante = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 6.699;

            Resultado ResultadoMetodoSecante = Secante.MetodoSecante(new ParametrosRaiz { Funcion = "f(x)=((1/10*(x-3)^(1/5))+(1/24*x^2)-2)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 5, ValorFinal = 10, TipoMetodo = TipoMetodo.Biseccion });

            Assert.AreEqual(ResultadoMetodoSecante.Raiz, res.Raiz);

        }

    }
}
