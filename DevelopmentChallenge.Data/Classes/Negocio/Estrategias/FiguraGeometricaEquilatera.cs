using System.Linq;

namespace DevelopmentChallenge.Data.Classes.Negocio
{
    public abstract class FiguraGeometricaEquilatera : FiguraGeometrica
    {
        protected decimal _lado;

        public FiguraGeometricaEquilatera(params decimal[] lados)
        {
            _lado = lados.First();
        }
    }
}
