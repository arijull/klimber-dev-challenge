using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Negocio.Impresion
{
    public class TrapecioTotalizado : FiguraGeometricaTotalizada
    {
        public TrapecioTotalizado(TipoDeForma tipo, int orden, int cantidad, decimal areaTotal, decimal perimetroTotal)
            : base(tipo, orden, cantidad, areaTotal, perimetroTotal)
        {
        }

        protected override string FormaImprimible
        {
            get
            {
                var forma = (Cantidad == 1) ? Localizacion.Mensajes.Trapecio : Localizacion.Mensajes.Trapecios;
                return forma;
            }
        }
    }
}
