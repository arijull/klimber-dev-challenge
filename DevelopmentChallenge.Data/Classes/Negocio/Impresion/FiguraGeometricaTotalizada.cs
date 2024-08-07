using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes.Negocio.Impresion
{
    public abstract class FiguraGeometricaTotalizada : IImprimible
    {
        public TipoDeForma Tipo { get; set; }
        public int Orden { get; set; }
        public int Cantidad { get; set; }
        public decimal AreaTotal { get; set; }
        public decimal PerimetroTotal { get; set; }

        protected abstract string FormaImprimible { get; }

        public FiguraGeometricaTotalizada(TipoDeForma tipo, int orden, int cantidad, decimal areaTotal, decimal perimetroTotal)
        {
            Tipo = tipo;
            Orden = orden;
            Cantidad = cantidad;
            AreaTotal = areaTotal;
            PerimetroTotal = perimetroTotal;
        }

        public string Imprimir()
        {
            return $"{Cantidad} {FormaImprimible} | {Localizacion.Mensajes.Area} {AreaTotal:#.##} | {Localizacion.Mensajes.Perimetro} {PerimetroTotal:#.##} <br/>";
        }
    }
}
