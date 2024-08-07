using DevelopmentChallenge.Data.Classes.Negocio.Estrategias;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;
using System;

namespace DevelopmentChallenge.Data.Tests.Negocio.Estrategias
{
    [TestFixture]
    public class TrianguloEquilateroTests
    {
        [TestCase]
        public void TestCuadradoConstructor()
        {
            var result = new TrianguloEquilatero(1);
            Assert.AreEqual(10, result.OrdenDeImpresion);
            Assert.AreEqual(TipoDeForma.TrianguloEquilatero, result.Tipo);
        }

        [TestCase]
        public void TestCuadradoArea()
        {
            var result = new TrianguloEquilatero(1);
            Assert.AreEqual(0.43, Math.Round(result.Area, 2));
        }

        [TestCase]
        public void TestCuadradoPerimetro()
        {
            var result = new TrianguloEquilatero(1);
            Assert.AreEqual(3, result.Perimetro);
        }
    }
}
