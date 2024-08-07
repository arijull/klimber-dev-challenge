using DevelopmentChallenge.Data.Classes.Negocio.Estrategias;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Negocio.Estrategias
{
    [TestFixture]
    public class FactoriaFiguraGeometricaTests
    {
        [TestCase]
        public void TestFactoriaFiguraGeometricaCuadrado()
        {
            var result = FactoriaFiguraGeometrica.CrearFiguraParaCalculo((int)TipoDeForma.Cuadrado, 10);
            Assert.IsInstanceOf<Cuadrado>(result);
        }

        [TestCase]
        public void TestFactoriaFiguraGeometricaCirculo()
        {
            var result = FactoriaFiguraGeometrica.CrearFiguraParaCalculo((int)TipoDeForma.Circulo, 10);
            Assert.IsInstanceOf<Circulo>(result);
        }

        [TestCase]
        public void TestFactoriaFiguraGeometricaTrianguloEquilatero()
        {
            var result = FactoriaFiguraGeometrica.CrearFiguraParaCalculo((int)TipoDeForma.TrianguloEquilatero, 10);
            Assert.IsInstanceOf<TrianguloEquilatero>(result);
        }

        [TestCase]
        public void TestFactoriaFiguraGeometricaTrapecio()
        {
            var result = FactoriaFiguraGeometrica.CrearFiguraParaCalculo((int)TipoDeForma.Trapecio, 10, 10, 10, 10, 10);
            Assert.IsInstanceOf<Trapecio>(result);
        }
    }
}
