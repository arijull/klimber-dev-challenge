using DevelopmentChallenge.Data.Classes.Negocio.Estrategias;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;
using System;

namespace DevelopmentChallenge.Data.Tests.Negocio.Estrategias
{
    [TestFixture]
    public class CuadradoTests
    {
        [TestCase]
        public void TestCuadradoConstructor()
        {
            var result = new Cuadrado(1);
            Assert.AreEqual(1, result.OrdenDeImpresion);
            Assert.AreEqual(TipoDeForma.Cuadrado, result.Tipo);
        }

        [TestCase]
        public void TestCuadradoArea()
        {
            var result = new Cuadrado(1);
            Assert.AreEqual(1, result.Area);
        }

        [TestCase]
        public void TestCuadradoPerimetro()
        {
            var result = new Cuadrado(1);
            Assert.AreEqual(4, result.Perimetro);
        }
    }
}
