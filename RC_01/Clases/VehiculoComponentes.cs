using System;
using System.Collections.Generic;
using System.Text;

namespace RC_01.VehiculoComponentes
{
    abstract class VehiculoComponente
    {
        private double _estado;

        protected VehiculoComponente()
        {
            _estado = 100.0;
        }

        public double Estado
        {
            get => _estado;
            set => double.TryParse(value.ToString(), out _estado);
        }
    }
}
