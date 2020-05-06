using System;
using System.Collections.Generic;
using System.Text;

namespace RC_01.Clases
{

    enum TipoRecubrimiento
    {
        FENOL, HULE, POLIUTERANO
    }

    class Rueda : VehiculoComponente
    {
        
        private readonly int[] _durometro;
        private TipoRecubrimiento _recubrimiento;
        
        public Rueda(TipoRecubrimiento recubrimiento, int minDurometro, int maxDurometro)
        {
            Recubrimiento = recubrimiento;
            _durometro = new int[] { minDurometro, maxDurometro };
            Durometro = _durometro;
        }

        public TipoRecubrimiento Recubrimiento
        {
            get => _recubrimiento;
            set => Enum.TryParse(value.ToString(), out _recubrimiento);
        }

        public int[] Durometro
        {
            get { return _durometro; }
            set
            {
                if (value.GetType().IsArray)
                    if(_durometro[0] <= _durometro[1])
                    {
                        _durometro[0] = value[0];
                        _durometro[1] = value[1];

                    }
                    else
                    {
                        _durometro[0] = -1;
                        _durometro[1] = -1;
                    }
            }
        }
        
        
    }
}
