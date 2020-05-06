using System;
using System.Collections.Generic;
using System.Text;

namespace RC_01.Clases
{
    class Automovil : VehiculoComponente
    {
        private string _Marca = "";
        private int _Año = 0;
        private int _Kilometraje = 0;

        public string Marca (string nombre)
        {
            this._Marca = nombre;
            return nombre;
        }
        public int Año(int año)
        {
            this._Año = año;
            return año;
        }
        public int Kilometraje(int kilometraje)
        {
            this._Kilometraje = kilometraje;
            return kilometraje;
        }

        public string TipoMotor()
        public override string ToString()
        {
            string convertir_kilo = Convert.ToString(_Kilometraje);
            string convert_año = Convert.ToString(_Año);
            string[] Lista = new string[3];
            Lista[0] = _Marca;
            Lista[1] = convert_año;
            Lista[2] = convertir_kilo;
            return "lOS RESULTADOS SON:" + "\n" + 
                "Marca: " + Lista[0] + "\n" + 
                "Año : " + Lista[1] + "\n" + 
                "Kilometraje: " + Lista[2];
        }

    }
}
