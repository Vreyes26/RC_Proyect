using System;
using System.Collections.Generic;
using System.Text;

namespace RC_01.Clases
{
    class Automovil
    {
        public string _marca;
        public int _año;
        public int _kilometraje;

        public Automovil(int kilometraje, string marca, int año)
        {
            _kilometraje = kilometraje;
            _marca = marca;
            _año = año;
        }


    }   
}
