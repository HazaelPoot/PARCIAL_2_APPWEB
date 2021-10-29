using System;

namespace AlcoholemiaApp.Domain.Interfaces
{
    public interface IOperacionCalcular
    {
        void Calcular( double cantidad, double mililitro, double alcohol, double peso, double edad);
        string RetornarResultados();
    }
}