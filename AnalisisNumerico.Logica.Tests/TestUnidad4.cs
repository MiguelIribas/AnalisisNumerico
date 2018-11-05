using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades.IntegracionNumerica;
using AnalisisNumerico.Logica.Unidad_4;
using AnalisisNumerico.Entidades.AjusteDeCurvas;
using System;

namespace AnalisisNumerico.Logica.Tests
{
    public class TestUnidad4
    {
        [TestClass]
        public class TestUnidad2
        {
            IMinimosCuadrados minimos;
            //EJERCICIO A
            [TestMethod]
            public void EjercicioAa()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)=((1/(x+0.5))+((1/4)*(x^(2))))";
                parametros.ValorExtremo1 = 0;
                parametros.ValorExtremo2 = 3;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioSimple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral,4), 6.8035);
                
            }

            [TestMethod]
            public void EjercicioAb()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)=((1/(x+0.5))+((1/4)*(x^(2))))";
                parametros.ValorExtremo1 = 0;
                parametros.ValorExtremo2 = 3;
                parametros.CantidadSubintervalos = 20;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioMultiple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 4.9996);
            }

            [TestMethod]
            public void EjercicioAc()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)=((1/(x+0.5))+((1/4)*(x^(2))))";
                parametros.ValorExtremo1 = 0;
                parametros.ValorExtremo2 = 3;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Simple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 4.3929);
            }

            [TestMethod]
            public void EjercicioAd()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)=((1/(x+0.5))+((1/4)*(x^(2))))";
                parametros.ValorExtremo1 = 0;
                parametros.ValorExtremo2 = 3;
                parametros.CantidadSubintervalos = 10;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Multiple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 3.3921);
            }

            [TestMethod]
            public void EjercicioAe()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)=((1/(x+0.5))+((1/4)*(x^(2))))";
                parametros.ValorExtremo1 = 0;
                parametros.ValorExtremo2 = 3;
                parametros.CantidadSubintervalos = 25;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Multiple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 3.9113);
            }

            //EJERCICIO B
            [TestMethod]
            public void EjercicioBa()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = ln(1+x^(2))";
                parametros.ValorExtremo1 = -2;
                parametros.ValorExtremo2 = 2;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioSimple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 6.4378);
            }

            [TestMethod]
            public void EjercicioBb()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = ln(1+x^(2))";
                parametros.ValorExtremo1 = -2;
                parametros.ValorExtremo2 = 2;
                parametros.CantidadSubintervalos = 20;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioMultiple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 3.5465);
            }

            [TestMethod]
            public void EjercicioBc()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = ln(1+x^(2))";
                parametros.ValorExtremo1 = -2;
                parametros.ValorExtremo2 = 2;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Simple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 2.1459);
            }

            [TestMethod]
            public void EjercicioBd()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = ln(1+x^(2))";
                parametros.ValorExtremo1 = -2;
                parametros.ValorExtremo2 = 2;
                parametros.CantidadSubintervalos = 10;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Multiple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 2.1414);
            }

            [TestMethod]
            public void EjercicioBe()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = ln(1+x^(2))";
                parametros.ValorExtremo1 = -2;
                parametros.ValorExtremo2 = 2;
                parametros.CantidadSubintervalos = 25;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Multiple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 2.6343);
            }

            //EJERCICIO C
            [TestMethod]
            public void EjercicioCa()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = e^(x)*(1-(0.5*x^(2)))";
                parametros.ValorExtremo1 = -1.4142;
                parametros.ValorExtremo2 = 1.4142;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioSimple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 0.0001);
            }

            [TestMethod]
            public void EjercicioCb()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = e^(x)*(1-(0.5*x^(2)))";
                parametros.ValorExtremo1 = -1.4142;
                parametros.ValorExtremo2 = 1.4142;
                parametros.CantidadSubintervalos = 20;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioMultiple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 2.2805);
            }

            [TestMethod]
            public void EjercicioCc()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = e^(x)*(1-(0.5*x^(2)))";
                parametros.ValorExtremo1 = -1.4142;
                parametros.ValorExtremo2 = 1.4142;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Simple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 1.8856);
            }

            [TestMethod]
            public void EjercicioCd()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = e^(x)*(1-(0.5*x^(2)))";
                parametros.ValorExtremo1 = -1.4142;
                parametros.ValorExtremo2 = 1.4142;
                parametros.CantidadSubintervalos = 10;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Multiple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 1.9997);
            }

            [TestMethod]
            public void EjercicioCe()
            {
                IntegracionNumerica integracion = new IntegracionNumerica(minimos);

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x) = e^(x)*(1-(0.5*x^(2)))";
                parametros.ValorExtremo1 = -1.4142;
                parametros.ValorExtremo2 = 1.4142;
                parametros.CantidadSubintervalos = 25;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Multiple(parametros);

                Assert.AreEqual(Math.Round(resultado.ValorIntegral, 4), 2.0865);
            }
        }
    }
}
