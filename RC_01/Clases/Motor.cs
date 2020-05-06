using System;
using System.Collections.Generic;
using System.Text;

namespace RC_01.Clases
{

    enum TipoMotor
    {
        DOS_TIEMPOS = 1,
        CUATRO_TIEMPOS = 2
    }

    class Motor: VehiculoComponente
    {
        private readonly int _id;
        private readonly TipoMotor _tipo;
        private double _cilindrada;

        public Motor(int id, TipoMotor tipo, double cilindrada)
        {
            _id = id;
            _tipo = tipo;
            _cilindrada = cilindrada;
        }

        public int ID => _id;

        public TipoMotor Tipo => _tipo;

        public double cilindrada
        {
            get => _cilindrada;
            set => double.TryParse(value.ToString(), out _cilindrada);
        }
    }

    
}
