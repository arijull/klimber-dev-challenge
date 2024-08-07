using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes.Negocio.Estrategias
{
    public class Circulo : FiguraGeometricaEquilatera
    {
        public Circulo(decimal diametro) : base(diametro)
        {
            Tipo = TipoDeForma.Circulo;
            OrdenDeImpresion = 5;
        }

        public override decimal Area
        {
            get { return (decimal)Math.PI * (_lado / 2) * (_lado / 2); }
        }

        public override decimal Perimetro
        {
            get { return (decimal)Math.PI * _lado; }
        }
    }
}
