using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes.Negocio.Estrategias
{
    public class Trapecio : FiguraGeometrica
    {
        private decimal _base1;
        private decimal _base2;
        private decimal _lado1;
        private decimal _lado2;
        private decimal _h;

        public Trapecio(decimal base1, decimal base2, decimal lado1, decimal lado2, decimal altura)
        {
            Tipo = TipoDeForma.Trapecio;
            OrdenDeImpresion = 15;

            _base1 = base1;
            _base2 = base2;
            _lado1 = lado1;
            _lado2 = lado2;
            _h = altura;
        }

        public override decimal Area
        {
            get { return ((_base1 + _base2) * _h) / 2; }
        }

        public override decimal Perimetro
        {
            get { return _base1 + _base2 + _lado1 + _lado2; }
        }
    }
}
