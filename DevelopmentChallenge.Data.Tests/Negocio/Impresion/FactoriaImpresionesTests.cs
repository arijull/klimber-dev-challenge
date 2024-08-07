using DevelopmentChallenge.Data.Classes.Negocio.Estrategias;
using DevelopmentChallenge.Data.Classes.Negocio.Impresion;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Negocio.Estrategias
{
    [TestFixture]
    public class FactoriaImpresionesTests
    {
        [TestCase]
        public void TestFactoriaImpresionesCuadrado()
        {
            var result = FactoriaImpresiones.CrearFiguraParaImprimir(TipoDeForma.Cuadrado, 1, 2, 10, 20);
            Assert.IsInstanceOf<CuadradoTotalizado>(result);
            Assert.AreEqual(1, result.Orden);
            Assert.AreEqual(2, result.Cantidad);
            Assert.AreEqual(10, result.AreaTotal);
            Assert.AreEqual(20, result.PerimetroTotal);
        }

        [TestCase]
        public void TestFactoriaImpresionesCirculo()
        {
            var result = FactoriaImpresiones.CrearFiguraParaImprimir(TipoDeForma.Circulo, 1, 2, 10, 20);
            Assert.IsInstanceOf<CirculoTotalizado>(result);
            Assert.AreEqual(1, result.Orden);
            Assert.AreEqual(2, result.Cantidad);
            Assert.AreEqual(10, result.AreaTotal);
            Assert.AreEqual(20, result.PerimetroTotal);
        }

        [TestCase]
        public void TestFactoriaImpresionesTrianguloEquilatero()
        {
            var result = FactoriaImpresiones.CrearFiguraParaImprimir(TipoDeForma.TrianguloEquilatero, 1, 2, 10, 20);
            Assert.IsInstanceOf<TrianguloEquilateroTotalizado>(result);
            Assert.AreEqual(1, result.Orden);
            Assert.AreEqual(2, result.Cantidad);
            Assert.AreEqual(10, result.AreaTotal);
            Assert.AreEqual(20, result.PerimetroTotal);
        }

        [TestCase]
        public void TestFactoriaImpresionesTrapecio()
        {
            var result = FactoriaImpresiones.CrearFiguraParaImprimir(TipoDeForma.Trapecio, 1, 2, 10, 20);
            Assert.IsInstanceOf<TrapecioTotalizado>(result);
            Assert.AreEqual(1, result.Orden);
            Assert.AreEqual(2, result.Cantidad);
            Assert.AreEqual(10, result.AreaTotal);
            Assert.AreEqual(20, result.PerimetroTotal);
        }
    }
}
