/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Classes.Negocio.Estrategias;
using DevelopmentChallenge.Data.Classes.Negocio.Impresion;
using DevelopmentChallenge.Data.Enums;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;

        #endregion

        public decimal[] Lados { get; internal set; }
        public int Tipo { get; internal set; }

        //El constructor sigue teniendo casi la misma firma, de modo tal, de mantener la interfaz de los tests(y de cualquier consumidor externo) igual
        //el segundo parametro ahora es de tipo params decimal[] para soportar figuras con dimensiones no equilateras
        public FormaGeometrica(int tipo, params decimal[] lados)
        {
            Tipo = tipo;
            Lados = lados;
        }

        //Imprimir sigue teniendo la misma forma provista originalmente, de modo tal, de mantener la interfaz de los tests(y de cualquier consumidor externo) igual
        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            EstablecerIdiomaDeImpresion(idioma);

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{Localizacion.Mensajes.ListaVacia}</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($"<h1>{Localizacion.Mensajes.ReporteDeFormas}</h1>");

                //Convertimos la FormaGeometrica en un tipo de FiguraGeometrica son su estrategia especifica para calcular area y perimetro
                var formasEstrategia = formas.Select(f => FactoriaFiguraGeometrica.CrearFiguraParaCalculo(f.Tipo, f.Lados)).ToList();

                var groupByTipo = formasEstrategia
                    .GroupBy(f => f.Tipo)
                    .Select(g => FactoriaImpresiones.CrearFiguraParaImprimir( //se mapea el group by a clases especificas de impresion para cada forma
                        g.First().Tipo,
                        g.First().OrdenDeImpresion,
                        g.Count(),
                        g.Sum(c => c.Area),
                        g.Sum(c => c.Perimetro))
                    )
                    .OrderBy(f => f.Orden)
                    .ToList();

                foreach (var item in groupByTipo)
                {
                    sb.Append(item.Imprimir()); //Cada forma totalizada sabe cómo imprimirse
                }

                // FOOTER
                sb.Append($"{Localizacion.Mensajes.Total}:<br/>");
                sb.Append(groupByTipo.Sum(r => r.Cantidad) + " " + Localizacion.Mensajes.Formas + " ");
                sb.Append($"{Localizacion.Mensajes.Perimetro} {groupByTipo.Sum(r => r.PerimetroTotal).ToString("#.##")} ");
                sb.Append($"{Localizacion.Mensajes.Area} {groupByTipo.Sum(r => r.AreaTotal).ToString("#.##")}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Setea el Thread.CurrentThread.CurrentUICulture para seleccionar el resx Mensajes
        /// </summary>
        /// <param name="idioma">int const de la clase FormaGeometrica</param>
        private static void EstablecerIdiomaDeImpresion(int idioma)
        {
            Idioma idiomaEnum = (Idioma)idioma; //ToDo: validar si el int tipo no existe en el enum
            switch (idiomaEnum)
            {
                case Idioma.Castellano:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es");
                    break;
                case Idioma.Italiano:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("it");
                    break;
                case Idioma.Ingles:
                default:
                    break;
            }
        }
    }
}
