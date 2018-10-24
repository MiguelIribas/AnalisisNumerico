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
            parametros.ValorX=4;

            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            resultado = minimos.ResolverPolinomioLagrange(parametros);
        }
    }
}
