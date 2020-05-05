using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace RC_01.Clases
{
    abstract class Vehiculo
    {
        private Motor _motor;
        private Rueda[] _ruedas;
        private Estanque _estanque;
        private Mezclador _mesclador;
        
        public Vehiculo (TipoMotor tipoMotor, int cilindrada,
                         int numRuedas, TipoRecubrimiento tipoRecubrimiento,
                         int minDurometro, int maxDurometro,
                         TipoMezclador tipoMezclador, double capacidad)
        {

        }
    }
}
