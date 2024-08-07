using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes.Negocio.Impresion
{
    public static class FactoriaImpresiones
    {
        //Se crea para cada figura, su estrategia especifica de impresión. Usé una clase base abtracta (en lugar de una interface) porque tengo comprotamiento en compun entre todas.
        public static FiguraGeometricaTotalizada CrearFiguraParaImprimir(TipoDeForma tipoDeForma, int orden, int cantidad, decimal areaTotal, decimal perimetroTotal)
        {
            switch (tipoDeForma)
            {
                case TipoDeForma.Cuadrado:
                    return new CuadradoTotalizado(tipoDeForma, orden, cantidad, areaTotal, perimetroTotal);
                case TipoDeForma.TrianguloEquilatero:
                    return new TrianguloEquilateroTotalizado(tipoDeForma, orden, cantidad, areaTotal, perimetroTotal);
                case TipoDeForma.Circulo:
                    return new CirculoTotalizado(tipoDeForma, orden, cantidad, areaTotal, perimetroTotal);
                case TipoDeForma.Trapecio:
                    return new TrapecioTotalizado(tipoDeForma, orden, cantidad, areaTotal, perimetroTotal);
                default:
                    return null;
            }

        }
    }
}
