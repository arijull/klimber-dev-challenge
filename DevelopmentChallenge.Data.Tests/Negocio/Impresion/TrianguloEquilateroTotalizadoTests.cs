using DevelopmentChallenge.Data.Classes.Negocio.Impresion;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Negocio.Impresion
{
    [TestFixture]
    public class TrianguloEquilateroTotalizadoTests
    {
        [TestCase]
        public void TestTrianguloEquilateroTotalizadoSingularImprimir()
        {
            var figura = new TrianguloEquilateroTotalizado(TipoDeForma.TrianguloEquilatero, 1, 1, 10, 20);
            var result = figura.Imprimir();
            Assert.AreEqual("1 Triangle | Area 10 | Perimeter 20 <br/>", result);
        }

        [TestCase]
        public void TestTrianguloEquilateroTotalizadoPluralImprimir()
        {
            var figura = new TrianguloEquilateroTotalizado(TipoDeForma.TrianguloEquilatero, 1, 2, 10, 20);
            var result = figura.Imprimir();
            Assert.AreEqual("2 Triangles | Area 10 | Perimeter 20 <br/>", result);
        }
    }
}
