using DevelopmentChallenge.Data.Classes.Negocio.Impresion;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Negocio.Impresion
{
    [TestFixture]
    public class CirculoTotalizadoTests
    {
        [TestCase]
        public void TestCirculoTotalizadoSingularImprimir()
        {
            var figura = new CirculoTotalizado(TipoDeForma.Circulo, 1, 1, 10, 20);
            var result = figura.Imprimir();
            Assert.AreEqual("1 Circle | Area 10 | Perimeter 20 <br/>", result);
        }

        [TestCase]
        public void TestCirculoTotalizadoPluralImprimir()
        {
            var figura = new CirculoTotalizado(TipoDeForma.Circulo, 1, 2, 10, 20);
            var result = figura.Imprimir();
            Assert.AreEqual("2 Circles | Area 10 | Perimeter 20 <br/>", result);
        }
    }
}
