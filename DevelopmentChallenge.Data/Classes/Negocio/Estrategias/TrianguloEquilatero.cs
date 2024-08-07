using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes.Negocio.Estrategias
{
    public class TrianguloEquilatero : FiguraGeometricaEquilatera
    {
        public TrianguloEquilatero(decimal ancho) : base(ancho)
        {
            Tipo = TipoDeForma.TrianguloEquilatero;
            OrdenDeImpresion = 10;
        }

        public override decimal Area
        {
            get { return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado; }
        }

        public override decimal Perimetro
        {
            get { return _lado * 3; }
        }
    }
}
