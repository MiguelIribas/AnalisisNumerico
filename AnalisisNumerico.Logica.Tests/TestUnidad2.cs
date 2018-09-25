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
        public void BiseccionEjercicio1()
        {
            ParametrosGaussSeidel parametros = new ParametrosGaussSeidel();

            List<decimal> Ecuacion1 = new List<decimal>() { 7, -1, 1, 2, 1 };
            List<decimal> Ecuacion2 = new List<decimal>() { -4, -15, 2, -4, 0 };
            List<decimal> Ecuacion3 = new List<decimal>() { 2, 4, -10, 1, 2 };
            List<decimal> Ecuacion4 = new List<decimal>() { -1, 2, 6, 10, -1 };

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3, Ecuacion4 };

            parametros.Iteraciones = 100;
            parametros.Tolerancia = Convert.ToDecimal("0,0001");
            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            metodos.ResolverEcuacionGaussSeidel(parametros);
        }

        [TestMethod]
        public void Ejercicio1()
        {
            ParametrosGaussSeidel parametros = new ParametrosGaussSeidel();

            List<decimal> Ecuacion1 = new List<decimal>() { 0.02M, 0.06M, 0.05M, 0.01M, 18.1M };
            List<decimal> Ecuacion2 = new List<decimal>() { 0.05M, 0.02M, 0M, 0M, 8.7M };
            List<decimal> Ecuacion3 = new List<decimal>() { 0M, 0.2M, 0.01M, 0.06M, 18M };
            List<decimal> Ecuacion4 = new List<decimal>() { 0.04M, 0.03M, 0.02M, 0.03M, 18.9M };

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3, Ecuacion4 };

            parametros.Iteraciones = 100;
            parametros.Tolerancia = Convert.ToDecimal("0,0001");
            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            metodos.ResolverEcuacionGaussSeidel(parametros);

            List<decimal> resultados = new List<decimal>();
        }

        [TestMethod]
        public void Ejercicio3()
        {
            ParametrosGaussSeidel parametros = new ParametrosGaussSeidel();

            List<decimal> Ecuacion1 = new List<decimal>() { 5M, 1M, -12.01015M, 8M };
            List<decimal> Ecuacion2 = new List<decimal>() { -8.301525M, -0.25M, 1.010075M, 20.225M };
            List<decimal> Ecuacion3 = new List<decimal>() { 3.751125M, -10.801216M, -3.002028M, 10.75M };

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3 };

            parametros.Iteraciones = 100;
            parametros.Tolerancia = 0.0001M;
            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            metodos.ResolverEcuacionGaussSeidel(parametros);

            List<decimal> resultados = new List<decimal>();

        }

        [TestMethod]
        public void Ejercicio5()
        {
            ParametrosGaussSeidel parametros = new ParametrosGaussSeidel();

            List<decimal> Ecuacion1 = new List<decimal>() { 0M, 1M, -1M, 0M, 4M, 0M };
            List<decimal> Ecuacion2 = new List<decimal>() { 1M, 1M, 5M, 0M, 0M, 0M };
            List<decimal> Ecuacion3 = new List<decimal>() { 2M, -0.5M, 0M, -1M, 0M, 20M };
            List<decimal> Ecuacion4 = new List<decimal>() { 0M, -1M, 0.25M, -0.2M, -0.2M, 17M };
            List<decimal> Ecuacion5 = new List<decimal>() { 0.5M, 0M, 0.25M, -1M, 0M, 0M };

            List<List<decimal>> Sistema = new List<List<decimal>>() { Ecuacion1, Ecuacion2, Ecuacion3, Ecuacion4, Ecuacion5 };

            parametros.Iteraciones = 100;
            parametros.Tolerancia = 0.0001M;
            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones metodos = new MetodosEcuaciones();
            metodos.ResolverEcuacionGaussSeidel(parametros);

            List<decimal> resultados = new List<decimal>();

        }
    }
}
