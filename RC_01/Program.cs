using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

namespace RC_01
{
    class Program
    {
        static void Main(string[] args)
        {

            string usuario = "admin" ;
            string contraseña = "abc123";
            bool login = false;

            do
            {

                Console.Write("Ingrese su usuario: ");
                String User = Console.ReadLine();
                Console.Write("Ingrese su contraseña: ");
                String Pass = Console.ReadLine();

                if (User == usuario && Pass == contraseña)
                {
                    Console.Clear();
                    Console.WriteLine("-------Bienvenido-------");
                    login = true;
                    Clases.Menu _menu = new Clases.Menu();
                    _menu.ListOptions();
                }
                else
                {
                    Console.WriteLine("-------Usuario o contraseña incorrectos-------");
                }
            } while (login == false);

            

            
        }
    }
}
