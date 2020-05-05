using System;
using System.Collections.Generic;
using System.Text;

namespace RC_01.VehiculoComponentes
{
    enum TipoMezclador
    {
        CARBURADOR, INYECTOR
    }

    class Mezclador : VehiculoComponente
    {
        private TipoMezclador _tipo;

        public Mezclador(TipoMezclador tipo)
        {
            _tipo = tipo;
            
        }

        public string Tipo
        {
            get { return _tipo.ToString(); }
            set { Enum.TryParse(value, out _tipo); }
        }
    }
}
