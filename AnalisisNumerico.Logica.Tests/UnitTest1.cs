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
        public void BiseccionEjercicio1()
        {
            MetodosCerrados Biseccion = new MetodosCerrados();
            Resultado res = new Resultado();
            res.Raiz = 0.89325;
            Resultado ResultadoMetodoBiseccion = Biseccion.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=((x^(5)-0.5)*exp(3*x)-1)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 0, ValorFinal = 1, TipoMetodo = TipoMetodo.Biseccion });
             
            Assert.AreEqual(ResultadoMetodoBiseccion.Raiz, res.Raiz);
        }
                      
               
        [TestMethod]
        public void ReglaFalsaEjercicio1()
        {
            MetodosCerrados ReglaFalsa = new MetodosCerrados();
            Resultado res = new Resultado();
            res.Raiz = 0.89325;
            Resultado ResultadoMetodoReglaFalsa = ReglaFalsa.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=((x^(5)-0.5)*exp(3*x)-1)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 0, ValorFinal = 1, TipoMetodo = TipoMetodo.ReglaFalsa });
            Assert.AreEqual(ResultadoMetodoReglaFalsa.Raiz, res.Raiz);
        }

        
        [TestMethod]
        public void TangenteEjercicio1()
        {
            MetodosAbiertos Tangente = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 0.417061;

            Resultado ResultadoMetodoTangente = Tangente.MetodoTangente(new ParametrosRaiz { Funcion = "f(x)=4-(1/x^2)-2*ln(x)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = 0.4, TipoMetodo = TipoMetodo.Tangente });

            Assert.AreEqual(ResultadoMetodoTangente.Raiz, res.Raiz);
        }

        
        [TestMethod]
        public void SecanteEjercicio1()
        {
            MetodosAbiertos Secante = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = 0.417065;

            Resultado ResultadoMetodoSecante = Secante.MetodoSecante(new ParametrosRaiz { Funcion = "f(x)=4-(1/x^2)-2*ln(x)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial =0.3, ValorFinal = 0.7, TipoMetodo = TipoMetodo.Secante });

            Assert.AreEqual(ResultadoMetodoSecante.Raiz, res.Raiz);
        }


        [TestMethod]
        public void TangenteEjercicio2()
        {
            MetodosAbiertos Tangente = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = -7.207061;

            Resultado ResultadoMetodoTangente = Tangente.MetodoTangente(new ParametrosRaiz { Funcion = "f(x)=x^(4)*e^(x)-2", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = -8, TipoMetodo = TipoMetodo.Tangente });

            Assert.AreEqual(ResultadoMetodoTangente.Raiz, res.Raiz);
        }


        [TestMethod]
        public void SecanteEjercicio2()
        {
            MetodosAbiertos Secante = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz =-7.207144;

            Resultado ResultadoMetodoSecante = Secante.MetodoSecante(new ParametrosRaiz { Funcion = "f(x)=x^(4)*e^(x)-2", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = -6, ValorFinal = -8, TipoMetodo = TipoMetodo.Secante });

            Assert.AreEqual(ResultadoMetodoSecante.Raiz, res.Raiz);
        }


        [TestMethod]
        public void BiseccionEjercicio4()
        {
            MetodosCerrados Biseccion = new MetodosCerrados();
            Resultado res = new Resultado();
            res.Raiz = -5.141602;
            Resultado ResultadoMetodoBiseccion = Biseccion.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=(x+1)*sin(x+2) ", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = -5, ValorFinal = -6, TipoMetodo = TipoMetodo.Biseccion });

            Assert.AreEqual(ResultadoMetodoBiseccion.Raiz, res.Raiz);
        }


        [TestMethod]
        public void ReglaFalsaEjercicio4()
        {
            MetodosCerrados ReglaFalsa = new MetodosCerrados();
            Resultado res = new Resultado();
            res.Raiz = -5.141602;
            Resultado ResultadoMetodoReglaFalsa = ReglaFalsa.MetodoBiseccion(new ParametrosRaiz { Funcion = "f(x)=(x+1)*sin(x+2) ", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = -6, ValorFinal = -5, TipoMetodo = TipoMetodo.ReglaFalsa });
            Assert.AreEqual(ResultadoMetodoReglaFalsa.Raiz, res.Raiz);
        }


        [TestMethod]
        public void TangenteEjercicio4()
        {
            MetodosAbiertos Tangente = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = -5.141589;

            Resultado ResultadoMetodoTangente = Tangente.MetodoTangente(new ParametrosRaiz { Funcion = "f(x)=(x+1)*sin(x+2)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = -5, TipoMetodo = TipoMetodo.Tangente });

            Assert.AreEqual(ResultadoMetodoTangente.Raiz, res.Raiz);
        }


        [TestMethod]
        public void SecanteEjercicio4()
        {
            MetodosAbiertos Secante = new MetodosAbiertos();
            Resultado res = new Resultado();
            res.Raiz = -5.141595;

            Resultado ResultadoMetodoSecante = Secante.MetodoSecante(new ParametrosRaiz { Funcion = "f(x)=(x+1)*sin(x+2)", Iteraciones = 100, Tolerancia = 0.0001, ValorInicial = -6, ValorFinal = -5, TipoMetodo = TipoMetodo.Secante });

            Assert.AreEqual(ResultadoMetodoSecante.Raiz, res.Raiz);
        }




    }
}
