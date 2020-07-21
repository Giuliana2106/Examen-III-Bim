using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contactos
{
    class Program
    {
       
        static void Main(string[] args)
        {
            char menú = 'n';
            int op = 0;
            string linea = "";

            while (menú != 's') ;
            {
                Console.WriteLine("1.-Crear Contacto");
                Console.WriteLine("2.-Ver Contacto");
                Console.WriteLine("3.-Buscar Contacto");
                Console.WriteLine("4.-Salir");
                Console.WriteLine("Opción: ");

                linea = Console.ReadLine();
                op = int.Parse(linea);

                try
                {
                    Console.WriteLine("Ingrese nombre: ");
                    linea = Console.ReadLine();
                }

                catch
                {
                    Console.WriteLine("Dato no válido");
                    Console.Write("Ingrese de nuevo el nombre: ");
                    linea = Console.ReadLine();
                }

                try
                {
                    Console.WriteLine("Ingrese apellido: ");
                    linea = Console.ReadLine();
                }

                catch
                {
                    Console.WriteLine("Dato no válido");
                    Console.Write("Ingrese de nuevo el apellido: ");
                    linea = Console.ReadLine();
                }

                try
                {
                    Console.WriteLine("Ingrese direccion: ");
                    linea = Console.ReadLine();
                }

                catch
                {
                    Console.WriteLine("Dato no válido");
                    Console.Write("Ingrese de nuevo la direccion: ");
                    linea = Console.ReadLine();
                }

                try
                {
                    Console.WriteLine("Ingrese telefono: ");
                    linea = Console.ReadLine();
                }

                catch
                {
                    Console.WriteLine("Dato no válido");
                    Console.Write("Ingrese de nuevo el telefono: ");
                    linea = Console.ReadLine();
                }

                Console.Write("Ingrese nombre: ");
                linea = Console.ReadLine();

                Console.Write("Ingrese apellido: ");
                linea = Console.ReadLine();

                Console.Write("Ingrese direccion: ");
                linea = Console.ReadLine();

                Console.Write("Ingrese telefono: ");
                linea = Console.ReadLine();

                if (op == 1)
                {
                    Console.WriteLine(" \\ n------------------------------------ \\ n ");
                    Console.Write("Ingrese nombre: ");
                    linea = Console.ReadLine();

                    Console.Write("Ingrese apellido: ");
                    linea = Console.ReadLine();

                    Console.Write("Ingrese direccion: ");
                    linea = Console.ReadLine();

                    Console.Write("Ingrese telefono: ");
                    linea = Console.ReadLine();

                    linea = Console.ReadLine();
                }

                else if(op == 2)
                {
                    Console.Write("Ingrese nombre del contacto a ver: ");

                    linea = Console.ReadLine();

                }

               else if(op == 3)
                {
                    Console.Write("Ingrese nombre del contacto a buscar: ");

                    linea = Console.ReadLine();

                }

                else if(op == 4)
                {
                    Console.WriteLine(" desea salir [s/n] ");
                    menú = char.Parse(Console.ReadLine());
                }


            }

            Console.ReadKey();
        }

    }
}
