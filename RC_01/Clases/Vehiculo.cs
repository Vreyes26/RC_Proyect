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
        private Mezclador _mezclador;
        
        public Vehiculo (int idMotor, TipoMotor tipoMotor, int cilindrada,
                         int numRuedas, TipoRecubrimiento tipoRecubrimiento,
                         int minDurometro, int maxDurometro,
                         TipoMezclador tipoMezclador, double capacidad)
        {
            _motor = new Motor(idMotor, tipoMotor, cilindrada);
            _ruedas = new Rueda[numRuedas];
            for (int i = 0; i < numRuedas; i++)
                _ruedas[i] = new Rueda(tipoRecubrimiento, minDurometro, maxDurometro);

            _estanque = new Estanque(capacidad);
            _mezclador = new Mezclador(tipoMezclador);
        }
        internal Rueda[] Ruedas { get => _ruedas; set => _ruedas = value; }
    }
}
