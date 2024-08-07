using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Negocio.Estrategias
{
    public static class FactoriaFiguraGeometrica
    {
        //Se crea para cada figura, su estrategia especifica para calcular área y perímetro.
        //Usé una clase base abtracta (en lugar de una interface) porque tengo comprotamiento en compun entre todas.
        public static FiguraGeometrica CrearFiguraParaCalculo(int tipo, params decimal[] lados)
        {
            var ancho = lados.First();

            TipoDeForma TipoForma = (TipoDeForma)tipo; //ToDo: validar si el int tipo no existe en el enum
            switch (TipoForma)
            {
                case TipoDeForma.Cuadrado:
                    return new Cuadrado(ancho);
                case TipoDeForma.TrianguloEquilatero:
                    return new TrianguloEquilatero(ancho);
                case TipoDeForma.Circulo:
                    return new Circulo(ancho);
                case TipoDeForma.Trapecio:
                    return new Trapecio(lados[0], lados[1], lados[2], lados[3], lados[4]);
                default:
                    return null;
            }

        }
    }
}
