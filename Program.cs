using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            do
            {

                Console.WriteLine("|                                                              |\n");
                Console.WriteLine("|                    Menu de Opciones                      |\n");
                Console.WriteLine("|1.- Añadir palabra al diccionario|\n");
                Console.WriteLine("|2.- Eliminar palabra del diccionario|\n");
                Console.WriteLine("|3.- Buscar palabra en el diccionario|\n");
                Console.WriteLine("|4.- ****** Salir *******|\n");
                //  Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("|      © Derechos reservados diseñado por:         |\n");

                // Console.BackgroundColor = ConsoleColor.Blue;
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            string resp = "";
                            do
                            {
                                Console.WriteLine("Ingrese una palabra");
                                string dato = Console.ReadLine();
                                Lista listaUno = new Lista();
                                listaUno.addList(dato);
                                listaUno.show();
                                Console.WriteLine("**************************");
                                Console.WriteLine("Añadir palabra ... Si o No");
                                Console.WriteLine("**************************");
                                resp = Console.ReadLine();
                            } while (resp != "No");
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ingrese una palabra");
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                }
                Console.WriteLine("Realizar otra operación... Si o No ...");
                respuesta = Console.ReadLine();
            } while (respuesta != "No");
            Console.Clear();
        }
    }
}

