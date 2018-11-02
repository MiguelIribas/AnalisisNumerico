using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades.IntegracionNumerica;
using AnalisisNumerico.Logica.Unidad_4;


namespace AnalisisNumerico.Logica.Tests
{
    public class TestUnidad4
    {
        [TestClass]
        public class TestUnidad2
        {
            [TestMethod]
            public void TrapecioSimple()
            {
                IntegracionNumerica integracion = new IntegracionNumerica();

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)= (x^(3))-(6*x^(2))+11*x-6";
                parametros.ValorExtremo1 = 1.3;
                parametros.ValorExtremo2 = 1.8;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioSimple(parametros);

                //Assert.AreEqual(resultado.RectaMejorAjuste, recta);
                //Assert.AreEqual(resultado.CoeficientedeCorrelacion, CoeficienteCorrelacion);
            }

            [TestMethod]
            public void TrapecioMultiple()
            {
                IntegracionNumerica integracion = new IntegracionNumerica();

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)= (x^(3))-(6*x^(2))+11*x-6";
                parametros.ValorExtremo1 = 1.3;
                parametros.ValorExtremo2 = 1.8;
                parametros.CantidadSubintervalos = 6;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioMultiple(parametros);

                //Assert.AreEqual(resultado.RectaMejorAjuste, recta);
                //Assert.AreEqual(resultado.CoeficientedeCorrelacion, CoeficienteCorrelacion);
            }

            [TestMethod]
            public void Simpson13()
            {
                IntegracionNumerica integracion = new IntegracionNumerica();

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)= (x^(3))-(6*x^(2))+11*x-6";
                parametros.ValorExtremo1 = 1.3;
                parametros.ValorExtremo2 = 1.8;
                parametros.CantidadSubintervalos = 6;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioMultiple(parametros);

                //Assert.AreEqual(resultado.RectaMejorAjuste, recta);
                //Assert.AreEqual(resultado.CoeficientedeCorrelacion, CoeficienteCorrelacion);
            }


            //----------------------------------------------------------------------------------------

            [TestMethod]
            public void TrapecioSimpleEjemplo()
            {
                IntegracionNumerica integracion = new IntegracionNumerica();

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)= (x^(3)/(1+x^(1/2)))";
                parametros.ValorExtremo1 = 1;
                parametros.ValorExtremo2 = 2;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioSimple(parametros);

                //Assert.AreEqual(resultado.RectaMejorAjuste, recta);
                //Assert.AreEqual(resultado.CoeficientedeCorrelacion, CoeficienteCorrelacion);
            }

            [TestMethod]
            public void TrapecioMultipleEjemplo()
            {
                IntegracionNumerica integracion = new IntegracionNumerica();

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)=((1/(x+0.5))+((1/4)*(x^(2))))";
                parametros.ValorExtremo1 = 0;
                parametros.ValorExtremo2 = 3;
                parametros.CantidadSubintervalos = 9;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverTrapecioMultiple(parametros);

                //Assert.AreEqual(resultado.RectaMejorAjuste, recta);
                //Assert.AreEqual(resultado.CoeficientedeCorrelacion, CoeficienteCorrelacion);
            }

            [TestMethod]
            public void Simpson13Ejemplo()
            {
                IntegracionNumerica integracion = new IntegracionNumerica();

                ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();

                parametros.Funcion = "f(x)= e^(x^(2))";
                //parametros.Funcion = "f(x)= (x^(3)/(1+x^(1/2)))";
                parametros.ValorExtremo1 = 0;
                parametros.ValorExtremo2 = 1;
                parametros.CantidadSubintervalos = 2;

                ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

                resultado = integracion.ResolverSimpson13Simple(parametros);

                //Assert.AreEqual(resultado.RectaMejorAjuste, recta);
                //Assert.AreEqual(resultado.CoeficientedeCorrelacion, CoeficienteCorrelacion);
            }

        }
    }
}
