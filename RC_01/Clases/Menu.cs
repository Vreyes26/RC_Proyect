using System;
using System.Collections.Generic;
using System.Text;

namespace RC_01.Clases
{
    public class Menu
    {
        public void ListOptions()
        {
            string menu;

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
                        Console.WriteLine("Agregar vehiculo");

                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Ver datos del vehiculo");
                        Console.ReadKey();
                        break;
                }

            } while (menu != "0");
            
        }
        
    }
}
