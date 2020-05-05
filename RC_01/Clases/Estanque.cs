using System;
using System.Collections.Generic;
using System.Text;

namespace RC_01.Clases
{
    class Estanque : VehiculoComponente
    {
        private readonly double _capacidad;
        private double _litros;

        public Estanque(double capacidad)
        {
            _capacidad = capacidad;
        }

        public double Capacidad => _capacidad;

        public double Litros { get => _litros; set => _litros = value; }

    }
}
