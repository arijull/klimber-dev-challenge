using DevelopmentChallenge.Data.Classes.Negocio.Estrategias;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;
using System;

namespace DevelopmentChallenge.Data.Tests.Negocio.Estrategias
{
    [TestFixture]
    public class TrapecioTests
    {
        [TestCase]
        public void TestCuadradoConstructor()
        {
            var result = new Trapecio(6.05m, 13.95m, 7, 8, 6.3m);
            Assert.AreEqual(15, result.OrdenDeImpresion);
            Assert.AreEqual(TipoDeForma.Trapecio, result.Tipo);
        }

        [TestCase]
        public void TestCuadradoArea()
        {
            var result = new Trapecio(6.05m, 13.95m, 7, 8, 6.3m);
            Assert.AreEqual(63, result.Area);
        }

        [TestCase]
        public void TestCuadradoPerimetro()
        {
            var result = new Trapecio(6.05m, 13.95m, 7, 8, 6.3m);
            Assert.AreEqual(35, result.Perimetro);
        }
    }
}
