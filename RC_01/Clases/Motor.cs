using System;
using System.Collections.Generic;
using System.Text;

namespace RC_01.Clases
{

    enum TipoMotor
    {
        DOS_TIEMPOS,
        CUATRO_TIEMPOS 
    }

    class Motor: VehiculoComponente
    {
        private readonly int _id;
        private readonly TipoMotor _tipo;
        private double _cilindrada;
        private int _numeroMotor;
        

        public Motor(int id, TipoMotor tipo, double cilindrada)
        {
            _id = id;
            _tipo = tipo;
            _cilindrada = cilindrada;
        }

        public NumMotor()
        {
            while (numMotor != 1 && numMotor != 2)
            {
                if (numMotor == 1)
                {
                    TipoMotor tipo_Motor = TipoMotor.DOS_TIEMPOS;
                }
                else if (numMotor == 2)
                {
                    TipoMotor tipo_Motor = TipoMotor.CUATRO_TIEMPOS;
                    
                }
                else
                {
                    Console.WriteLine("Error, debe ingresar un tipo de motor");
                }

            }
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
