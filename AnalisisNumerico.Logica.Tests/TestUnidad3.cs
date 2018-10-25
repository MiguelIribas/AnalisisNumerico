using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades.AjusteDeCurvas;
using AnalisisNumerico.Logica.Unidad_3;
using System.Collections.Generic;


namespace AnalisisNumerico.Logica.Tests
{
    [TestClass]
    public class TestUnidad3
    {
        [TestMethod]
        public void Ejercicio1()
        {
            MinimosCuadrados minimos = new MinimosCuadrados();

            ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();

            parametros.ValoresX = new List<decimal>() { -3, 0.5M, 1, 1.5M, 2, 3, 5 };
            parametros.ValoresY = new List<decimal>() { -7.5M, -2.25M, -1.5M, 1M, 0, 0, 4.5M };

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            resultado = minimos.ResolverCurvaLineal(parametros);

            string recta = "Y = (1,4384x - 2,8762)";
            decimal CoeficienteCorrelacion = 96.7211M;
            Assert.AreEqual(resultado.RectaMejorAjuste, recta);
            Assert.AreEqual(resultado.CoeficientedeCorrelacion, CoeficienteCorrelacion);
        }

        [TestMethod]
        public void Ejercicio2()
        {
            MinimosCuadrados minimos = new MinimosCuadrados();

            ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();

            parametros.ValoresX = new List<decimal>() { -1, 0, 2, 3, 5, 6 };
            parametros.ValoresY = new List<decimal>() { 6, 4, 1, 1, 2, 5 };
            parametros.Grado = 2;
            parametros.ValorX = 4;

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            resultado = minimos.ResolverCurvaPolinomial(parametros);
        }

        [TestMethod]
        public void Ejercicio2Lagrange()
        {
            MinimosCuadrados minimos = new MinimosCuadrados();

            ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();

            parametros.ValoresX = new List<decimal>() { -1, 0, 2, 3, 5, 6 };
            parametros.ValoresY = new List<decimal>() { 6, 4, 1, 1, 2, 5 };
            parametros.ValorX = 4;

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            resultado = minimos.ResolverPolinomioLagrange(parametros);
        }

        [TestMethod]
        public void Ejercicio4a()
        {
            MinimosCuadrados minimos = new MinimosCuadrados();

            ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();

            parametros.ValoresX = new List<decimal>() { 0, 0.5M, 1, 2, 3, 6, 9, 12 };
            parametros.ValoresY = new List<decimal>() { 4.5M, 2.5M, 1.8333M, 1.3M, 1.071M, 0.8076M, 0.71M, 0.66M };

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            resultado = minimos.ResolverCurvaLineal(parametros);

            string Recta = "Y = (-0,2073x+2,5410)";

            Assert.AreEqual(Recta, resultado.RectaMejorAjuste);
        }

        [TestMethod]
        public void Ejercicio4b()
        {
            MinimosCuadrados minimos = new MinimosCuadrados();

            ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();

            parametros.ValoresX = new List<decimal>() { 0, 0.5M, 1, 2, 3, 6, 9, 12 };
            parametros.ValoresY = new List<decimal>() { 4.5M, 2.5M, 1.8333M, 1.3M, 1.071M, 0.8076M, 0.71M, 0.66M };
            parametros.Grado = 2;

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            resultado = minimos.ResolverCurvaPolinomial(parametros);

            string Recta = "Y = (0,0482x^(2))+(-0,7632x^(1))+(3,2103x^(0))";

            Assert.AreEqual(Recta, resultado.RectaMejorAjuste);
        }

        [TestMethod]
        public void Ejercicio4c()
        {
            MinimosCuadrados minimos = new MinimosCuadrados();

            ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();

            parametros.ValoresX = new List<decimal>() { 0, 0.5M, 1, 2, 3, 6, 9, 12 };
            parametros.ValoresY = new List<decimal>() { 4.5M, 2.5M, 1.8333M, 1.3M, 1.071M, 0.8076M, 0.71M, 0.66M };
            parametros.Grado = 5;

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            resultado = minimos.ResolverCurvaPolinomial(parametros);
        }
    }
}
