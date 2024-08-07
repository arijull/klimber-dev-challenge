using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes.Negocio.Impresion
{
    public class CuadradoTotalizado : FiguraGeometricaTotalizada
    {
        public CuadradoTotalizado(TipoDeForma tipo, int orden, int cantidad, decimal areaTotal, decimal perimetroTotal)
            : base(tipo, orden, cantidad, areaTotal, perimetroTotal)
        {
        }

        protected override string FormaImprimible
        {
            get
            {
                var forma = (Cantidad == 1) ? Localizacion.Mensajes.Cuadrado : Localizacion.Mensajes.Cuadrados;
                return forma;
            }
        }
    }
}
