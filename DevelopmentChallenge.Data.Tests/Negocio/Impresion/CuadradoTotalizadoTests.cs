using DevelopmentChallenge.Data.Classes.Negocio.Impresion;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Negocio.Impresion
{
    [TestFixture]
    public class CuadradoTotalizadoTests
    {
        [TestCase]
        public void TestCuadradoTotalizadoSingularImprimir()
        {
            var figura = new CuadradoTotalizado(TipoDeForma.Cuadrado, 1, 1, 10, 20);
            var result = figura.Imprimir();
            Assert.AreEqual("1 Square | Area 10 | Perimeter 20 <br/>", result);
        }

        [TestCase]
        public void TestCuadradoTotalizadoPluralImprimir()
        {
            var figura = new CuadradoTotalizado(TipoDeForma.Cuadrado, 1, 2, 10, 20);
            var result = figura.Imprimir();
            Assert.AreEqual("2 Squares | Area 10 | Perimeter 20 <br/>", result);
        }
    }
}
