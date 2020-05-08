using RC_01.Clases;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

namespace RC_01
{
    class Program
    {
        private static TipoMotor tipo_Motor;

        static void Main(string[] args)
        {

            string usuario = "admin";
            string password = "abc123";
            string menu = "0";

            do{
                Console.WriteLine("Nombre de usuario: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                password = Console.ReadLine();
            } while (usuario != "admin" && password != "1234");

            do
            {
            Console.WriteLine("Ingrese el numero correspondiente a la opcion: \n" +
                            "1: Agregar vehiculo \n" +
                            "2: Ver datos de vehiculo \n" +
                            "0: Salir \n");
            menu = Console.ReadLine();

            switch (menu)
            {
                case "1": //AGREGAR DATOS
                    Console.WriteLine("Agregar marca: ");
                    string marca = Console.ReadLine();

                    Console.WriteLine("Agregar año: ");
                    int año = int.Parse(Console.ReadLine());
                        
                    Console.WriteLine("Kilometraje : ");
                    int kilometraje = int.Parse(Console.ReadLine());

                    Automovil auto = new Automovil(kilometraje, marca, año);
                    Console.WriteLine(auto._marca, auto._año, auto._kilometraje);
                    Console.WriteLine("Ingrese ID del motor ");
                    int id_Motor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el numero correspondiente al tipo de motor:\n" +
                                        "1: Motor de dos tiempos.\n" +
                                        "2: Motor de cuatro tiempos.");

                    int numMotor = Convert.ToInt32(Console.ReadLine());

                    do
                    {
                        if (numMotor == 1)
                        {
                            TipoMotor tipo_Motor = TipoMotor.DOS_TIEMPOS;
                        }
                        else if (numMotor == 2)
                        {
                            TipoMotor tipo_motor = TipoMotor.CUATRO_TIEMPOS;

                        }
                        else
                        {
                            Console.WriteLine("Error, debe ingresar un tipo de motor");
                        }
                    } while (numMotor != 1 && numMotor != 2);

                    Console.WriteLine("Ingrese el tipo de cilindrada del vehiculo: ");
                    double cilindrada_V = Convert.ToDouble(Console.ReadLine());
                    Motor motor = new Motor(id_Motor, tipo_Motor, cilindrada_V);
                    break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Datos Vehiculo");
                        
                        Console.WriteLine();
                        break;
            }

        } while (menu != "0");




        }
    }
}
