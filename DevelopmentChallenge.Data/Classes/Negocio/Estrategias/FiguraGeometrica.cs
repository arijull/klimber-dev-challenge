using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes.Negocio.Estrategias
{
    public abstract class FiguraGeometrica
    {
        public int OrdenDeImpresion { get; protected set; }

        public TipoDeForma Tipo { get; protected set; }

        public abstract decimal Area { get; }

        public abstract decimal Perimetro { get; }

    }
}
