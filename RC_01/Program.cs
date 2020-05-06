using RC_01.Clases;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

namespace RC_01
{
    class Program
    {
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

            //INSTANCIAS
            Automovil x1 = new Automovil();
            
                do
                {
                Console.WriteLine("Ingrese el numero correspondiente a la opcion:\n" +
                                "1: Agregar vehiculo\n" +
                                "2: Ver datos de vehiculo\n" +
                                "0: Salir\n");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine("Agregar marca: ");
                        string marca = Console.ReadLine();
                        x1.Marca(marca);
                        Console.WriteLine("Agregar año: ");
                        int año = int.Parse(Console.ReadLine());
                        x1.Año(año);
                        Console.WriteLine("Klometraje : ");
                        int kilometraje = int.Parse(Console.ReadLine());
                        x1.Kilometraje(kilometraje);
                        Console.WriteLine("Ingrese ID del motor ");
                        int id_Motor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero correspondiente al tipo de motor:/n" +
                                          "1: Motor de dos tiempos./n" +
                                          "2: Motor de cuatro tiempos.");

                        int numMotor = Convert.ToInt32(Console.ReadLine());

                        
                        
                        Console.WriteLine("Ingrese el tipo de cilindrada del vehiculo: ");
                        double cilindrada_V = Convert.ToDouble(Console.ReadLine());

                        Motor x2 = new Motor(id_Motor, tipo_Motor, cilindrada_V);
                        break;

                    case "2":
                        Console.WriteLine(x1.ToString());
                        break;
                   
                }

            } while (menu != "0");




        }
    }
}
