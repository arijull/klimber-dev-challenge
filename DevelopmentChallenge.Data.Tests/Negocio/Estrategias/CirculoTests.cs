using DevelopmentChallenge.Data.Classes.Negocio.Estrategias;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;
using System;

namespace DevelopmentChallenge.Data.Tests.Negocio.Estrategias
{
    [TestFixture]
    public class CirculoTests
    {
        [TestCase]
        public void TestCuadradoConstructor()
        {
            var result = new Circulo(1);
            Assert.AreEqual(5, result.OrdenDeImpresion);
            Assert.AreEqual(TipoDeForma.Circulo, result.Tipo);
        }

        [TestCase]
        public void TestCuadradoArea()
        {
            var result = new Circulo(1);
            Assert.AreEqual(0.79m, Math.Round(result.Area, 2));
        }

        [TestCase]
        public void TestCuadradoPerimetro()
        {
            var result = new Circulo(1);
            Assert.AreEqual(3.14, Math.Round(result.Perimetro, 2));
        }
    }
}
