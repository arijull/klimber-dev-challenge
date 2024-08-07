using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), 1));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), 2));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new FormaGeometrica(FormaGeometrica.Cuadrado, 5)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 1),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Trapecio, 4, 5, 3, 3.2m, 3),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.Trapecio, 6.05m, 13.95m, 7, 8, 6.3m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Trapezoids | Area 76,5 | Perimeter 50,2 <br/>TOTAL:<br/>9 shapes Perimeter 147,86 Area 168,15",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Trapecio, 4, 5, 3, 3.2m, 3),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.Trapecio, 6.05m, 13.95m, 7, 8, 6.3m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>2 Trapecios | Area 76,5 | Perimetro 50,2 <br/>TOTAL:<br/>9 formas Perimetro 147,86 Area 168,15",
                resumen);
        }

        [TestCase]
        public void TestImprimirUnTrapecioEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Trapecio, 4, 5, 3, 3.2m, 3)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Trapecio | Area 13,5 | Perimetro 15,2 <br/>TOTAL:<br/>1 formas Perimetro 15,2 Area 13,5",
                resumen);
        }

        [TestCase]
        public void TestImprimirUnTrapecioEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Trapecio, 6.05m, 13.95m, 7, 8, 6.3m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Trapezoid | Area 63 | Perimeter 35 <br/>TOTAL:<br/>1 shapes Perimeter 35 Area 63",
                resumen);
        }

        [TestCase]
        public void TestImprimirDosTrapeciosEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Trapecio, 4, 5, 3, 3.2m, 3),
                new FormaGeometrica(FormaGeometrica.Trapecio, 6.05m, 13.95m, 7, 8, 6.3m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Trapecios | Area 76,5 | Perimetro 50,2 <br/>TOTAL:<br/>2 formas Perimetro 50,2 Area 76,5",
                resumen);
        }

        [TestCase]
        public void TestImprimirDosTrapeciosEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Trapecio, 4, 5, 3, 3.2m, 3),
                new FormaGeometrica(FormaGeometrica.Trapecio, 6.05m, 13.95m, 7, 8, 6.3m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Trapezoids | Area 76,5 | Perimeter 50,2 <br/>TOTAL:<br/>2 shapes Perimeter 50,2 Area 76,5",
                resumen);
        }

        [TestCase]
        public void TestImprimirUnaDeCadaFormaEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Trapecio, 4, 5, 3, 3.2m, 3),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto di forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>1 Circolo | Area 7,07 | Perimetro 9,42 <br/>1 Triangolo | Area 6,93 | Perimetro 12 <br/>1 Trapezio | Area 13,5 | Perimetro 15,2 <br/>TOTALE:<br/>4 forme Perimetro 56,62 Area 52,5",
                resumen);
        }

        [TestCase]
        public void TestImprimirVariasDeCadaFormasEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Trapecio, 4, 5, 3, 3.2m, 3),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.Trapecio, 6.05m, 13.95m, 7, 8, 6.3m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto di forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Circoli | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>2 Trapezzi | Area 76,5 | Perimetro 50,2 <br/>TOTALE:<br/>9 forme Perimetro 147,86 Area 168,15",
                resumen);
        }
    }
}
