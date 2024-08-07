using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes.Negocio.Estrategias
{
    public class Cuadrado : FiguraGeometricaEquilatera
    {
        public Cuadrado(decimal ancho) : base(ancho)
        {
            Tipo = TipoDeForma.Cuadrado;
            OrdenDeImpresion = 1;
        }

        public override decimal Area
        {
            get { return _lado * _lado; }
        }

        public override decimal Perimetro
        {
            get { return _lado * 4; }
        }
    }
}
