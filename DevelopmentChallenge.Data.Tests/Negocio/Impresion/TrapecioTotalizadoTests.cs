using DevelopmentChallenge.Data.Classes.Negocio.Impresion;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Negocio.Impresion
{
    [TestFixture]
    public class TrapecioTotalizadoTests
    {
        [TestCase]
        public void TestTrapecioTotalizadoSingularImprimir()
        {
            var figura = new TrapecioTotalizado(TipoDeForma.Trapecio, 1, 1, 10, 20);
            var result = figura.Imprimir();
            Assert.AreEqual("1 Trapezoid | Area 10 | Perimeter 20 <br/>", result);
        }

        [TestCase]
        public void TestTrapecioTotalizadoPluralImprimir()
        {
            var figura = new TrapecioTotalizado(TipoDeForma.Trapecio, 1, 2, 10, 20);
            var result = figura.Imprimir();
            Assert.AreEqual("2 Trapezoids | Area 10 | Perimeter 20 <br/>", result);
        }
    }
}
