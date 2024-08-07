using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes.Negocio.Impresion
{
    public class CirculoTotalizado : FiguraGeometricaTotalizada
    {
        public CirculoTotalizado(TipoDeForma tipo, int orden, int cantidad, decimal areaTotal, decimal perimetroTotal)
            : base(tipo, orden, cantidad, areaTotal, perimetroTotal)
        {
        }

        protected override string FormaImprimible
        {
            get
            {
                var forma = (Cantidad == 1) ? Localizacion.Mensajes.Círculo : Localizacion.Mensajes.Círculos;
                return forma;
            }
        }
    }
}
