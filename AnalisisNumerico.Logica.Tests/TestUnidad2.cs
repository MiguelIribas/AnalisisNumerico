using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades.Ecuaciones;
using AnalisisNumerico.Logica.Unidad_2;
using System.Collections.Generic;

namespace AnalisisNumerico.Logica.Tests
{
    [TestClass]
    public class TestUnidad2
    {
        [TestMethod]
        public void Ejercicio1Minimos()
        {
            ParametrosEcuaciones parametros = new ParametrosEcuaciones();

            List<decimal> Ecuacion1 = new List<decimal>() { 0.02M, 0.06M, 0.05M, 0.01M, 18.1M };
            List<decimal> Ecuacion2 = new List<decimal>() { 0.05M, 0.02M, 0M, 0M, 8.7M };
            List<decimal> Ecuacion3 = new List<decimal>() { 0M, 0.02M, 0.01M, 0.06M, 18M };
            List<decimal> Ecuacion4 = new List<decimal>() { 0.04M, 0.03M, 0.02M, 0.03M, 18.9M };

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3, Ecuacion4 };

            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            List<decimal> solucion = new List<decimal>(metodos.ResolverEcuacionGaussJordan(parametros).ResultadosEcuaciones);

            List<decimal> resultados = new List<decimal>() { 150.0000M, 60.0000M, 180.0000M, 250.0000M };

            for (int i = 0; i <= resultados.Count - 1; i++)
            {
                Assert.AreEqual(resultados[i], solucion[i]);
            }
        }

        [TestMethod]
        public void Ejercicio1Maximos()
        {
            ParametrosEcuaciones parametros = new ParametrosEcuaciones();

            List<decimal> Ecuacion1 = new List<decimal>() { 0.02M, 0.06M, 0.05M, 0.01M, 24.5M };
            List<decimal> Ecuacion2 = new List<decimal>() { 0.05M, 0.02M, 0M, 0M, 12.1M };
            List<decimal> Ecuacion3 = new List<decimal>() { 0M, 0.02M, 0.01M, 0.06M, 25M };
            List<decimal> Ecuacion4 = new List<decimal>() { 0.04M, 0.03M, 0.02M, 0.03M, 26.1M };

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3, Ecuacion4 };

            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            List<decimal> solucion = new List<decimal>(metodos.ResolverEcuacionGaussJordan(parametros).ResultadosEcuaciones);

            List<decimal> resultados = new List<decimal>() { 210.0000M, 80.0000M, 240.0000M, 350.0000M };

            for (int i = 0; i <= resultados.Count - 1; i++)
            {
                Assert.AreEqual(resultados[i], solucion[i]);
            }
        }

        [TestMethod]
        public void Ejercicio2()
        {
            ParametrosEcuaciones parametros = new ParametrosEcuaciones();

            List<decimal> Ecuacion1 = new List<decimal>() { 1M, -6M, 1.5M, -3M };
            List<decimal> Ecuacion2 = new List<decimal>() { 2.85M, -16.95M, 4.23M, -8.31M };
            List<decimal> Ecuacion3 = new List<decimal>() { -1.3M, 8M, -2.1M, 4.4M };

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3 };

            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            List<decimal> solucion = new List<decimal>(metodos.ResolverEcuacionGaussJordan(parametros).ResultadosEcuaciones);

            List<decimal> resultados = new List<decimal>() { 6.0M, 1.0M, -2M };

            for (int i = 0; i <= resultados.Count - 1; i++)
            {
                Assert.AreEqual(resultados[i], solucion[i]);
            }
        }

        [TestMethod]
        public void Ejercicio3()
        {
            ParametrosEcuaciones parametros = new ParametrosEcuaciones();

            List<decimal> Ecuacion1 = new List<decimal>() { 5M, 1M, -12.01015M, 8M};
            List<decimal> Ecuacion2 = new List<decimal>() { -8.301525M, -0.25M, 1.010075M, 20.225M};
            List<decimal> Ecuacion3 = new List<decimal>() { 3.751125M, -10.801216M, -3.002028M, 10.75M};

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3 };

            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            List<decimal> solucion = new List<decimal>(metodos.ResolverEcuacionGaussJordan(parametros).ResultadosEcuaciones);

            List<decimal> resultados = new List<decimal>() {-2.6225M, -1.3854M,-1.8732M };

            for (int i = 0; i <= resultados.Count - 1; i++)
            {
                Assert.AreEqual(resultados[i], solucion[i]);
            }
        }

        [TestMethod]
        public void Ejercicio4()
        {
            ParametrosEcuaciones parametros = new ParametrosEcuaciones();

            List<decimal> Ecuacion1 = new List<decimal>() { 1M,1M,1M,1M,96M };
            List<decimal> Ecuacion2 = new List<decimal>() { 0.25M,0.3333M,0.5M,0.5M,31M };
            List<decimal> Ecuacion3 = new List<decimal>() {-1M,-1M,10M,0M,0M, };
            List<decimal> Ecuacion4 = new List<decimal>() { -1M,-1M,-1M,15M,0M };

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3, Ecuacion4 };

            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            List<decimal> solucion = new List<decimal>(metodos.ResolverEcuacionGaussJordan(parametros).ResultadosEcuaciones);

            List<decimal> resultados = new List<decimal>() { 40.3470M,41.4711M,8.1818M,6 };

            for (int i = 0; i <= resultados.Count - 1; i++)
            {
                Assert.AreEqual(resultados[i], solucion[i]);
            }
        }

        [TestMethod]
        public void Ejercicio5()
        {
            ParametrosEcuaciones parametros = new ParametrosEcuaciones();

            List<decimal> Ecuacion1 = new List<decimal>() { 0M,1M,-1M,0M,4M,0M };
            List<decimal> Ecuacion2 = new List<decimal>() { 1M,1M,5M,0M,0M,0M };
            List<decimal> Ecuacion3 = new List<decimal>() { 2M,-0.5M,0M,-1M, 0M, 20M };
            List<decimal> Ecuacion4 = new List<decimal>() {0M,-1M,0.25M,-0.2M,-0.2M,17M};
            List<decimal> Ecuacion5 = new List<decimal>() { 0.5M,0M,0.25M,-1M,0M,0M };

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3, Ecuacion4,Ecuacion5 };

            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            List<decimal> solucion = new List<decimal>(metodos.ResolverEcuacionGaussJordan(parametros).ResultadosEcuaciones);

            List<decimal> resultados = new List<decimal>() { 7.5753M,-18.3518M,2.1553M,4.3265M,5.1268M };

            for (int i = 0; i <= resultados.Count - 1; i++)
            {
                Assert.AreEqual(resultados[i], solucion[i]);
            }
        }
    }
}
