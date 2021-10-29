using System;
using AlcoholemiaApp.Domain.Interfaces;

namespace AlcoholemiaApp.Domain.Entities
{
    public class Consumo : IOperacionCalcular
    {
        public double _cantidad = 0.0;
        public double _Talcohol = 0.0;
        public double _mlt = 0.0;
        public double _ehot = 0.0;
        public double _total = 0.0;
        public double _peso = 0.0;
        public double _edad = 0.0;
        public double _sangre = 0.0;
        public double _alcoholemia = 0.0;
        public double _directo = 0.0;
        public double _masa = 0.0;
        public double _conslusion = 0.0;
        public void Calcular( double cantidad, double mililitro, double alcohol, double peso, double edad)
        {
            _mlt = mililitro;
            _cantidad = cantidad;
            _ehot = alcohol;
            _peso = peso;
            _edad = edad;

            _total = _cantidad*_mlt;

            _Talcohol = _total*_ehot/100;

            _directo = _Talcohol*15/100;

            _masa = _directo*0.789;

            _sangre = _peso*8/100;

            _alcoholemia = _masa/_sangre;

        }

        public string RetornarResultados()
        {
                return $"{_alcoholemia}";
        }
    }

}