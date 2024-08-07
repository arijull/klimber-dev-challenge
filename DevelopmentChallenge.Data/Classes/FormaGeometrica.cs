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

using DevelopmentChallenge.Data.Classes.Negocio;
using DevelopmentChallenge.Data.Classes.Negocio.Estrategias;
using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using DevelopmentChallenge.Data.Classes.Negocio.Impresion;

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

        #endregion

        private FiguraGeometrica _implementacion;

        public FormaGeometrica(int tipo, params decimal[] lados)
        {
            var ancho = lados.First();

            TipoDeForma TipoForma = (TipoDeForma)tipo;
            switch (TipoForma)
            {
                case TipoDeForma.Cuadrado:
                    _implementacion = new Cuadrado(ancho);
                    break;
                case TipoDeForma.TrianguloEquilatero:
                    _implementacion = new TrianguloEquilatero(ancho);
                    break;
                case TipoDeForma.Circulo:
                    _implementacion = new Circulo(ancho);
                    break;
                case TipoDeForma.Trapecio:
                    _implementacion = new Trapecio(lados[0], lados[1], lados[2], lados[3], lados[4]);
                    break;
                default:
                    break;
            }
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            if (idioma == Castellano)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            }

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

                var groupByTipo = formas
                    .GroupBy(f => f._implementacion.Tipo)
                    .Select(g => FactoriaImpresiones.CrearFiguraParaImprimir(
                        g.First()._implementacion.Tipo,
                        g.First()._implementacion.OrdenDeImpresion,
                        g.Count(),
                        g.Sum(c => c._implementacion.Area),
                        g.Sum(c => c._implementacion.Perimetro))
                    )
                    .OrderBy(f => f.Orden)
                    .ToList();

                foreach (var item in groupByTipo)
                {
                    sb.Append(item.Imprimir());
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(groupByTipo.Sum(r => r.Cantidad) + " " + Localizacion.Mensajes.Formas + " ");
                sb.Append($"{Localizacion.Mensajes.Perimetro} {groupByTipo.Sum(r => r.PerimetroTotal).ToString("#.##")} ");
                sb.Append($"{Localizacion.Mensajes.Area} {groupByTipo.Sum(r => r.AreaTotal).ToString("#.##")}");
            }

            return sb.ToString();
        }
    }
}
