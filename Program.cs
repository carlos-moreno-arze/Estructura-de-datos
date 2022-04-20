﻿
namespace Diccionario {
  class Program {
    static void Main (string [] args) {
      Lista lista = new Lista();
      lista.addList("A");
      lista.addList("B");
      lista.addList("C");
      lista.addList("D");
      lista.addList("E");
      lista.addList("F");
      lista.addList("G");
      lista.addList("H");
      lista.addList("I");
      lista.addList("J");
      lista.addList("K");
      lista.addList("L");
      lista.addList("M");
      lista.addList("N");
      lista.addList("Ñ");
      lista.addList("O");
      lista.addList("P");
      lista.addList("Q");
      lista.addList("R");
      lista.addList("S");
      lista.addList("T");
      lista.addList("U");
      lista.addList("V");
      lista.addList("W");
      lista.addList("X");
      lista.addList("Y");
      lista.addList("Z");
      string respuesta = "";
      do {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("|---------------------------------------------|\n");
        Console.WriteLine("|------------- Menu de Opciones --------------|\n");
        Console.WriteLine("|---------------------------------------------|\n");
        Console.WriteLine("|1.- Añadir palabra                           |\n");
        Console.WriteLine("|2.- Mostrar palabras                         |\n");
        Console.WriteLine("|3.- Eliminar palabra                         |\n");
        Console.WriteLine("|4.- Editar palabra                           |\n");
        Console.WriteLine("|5.- Vaciar lista                             |\n");
        Console.WriteLine("|6.- Salir                                    |\n");
        Console.WriteLine("|      © Derechos reservados                  |\n");
        Console.WriteLine("|_____________________________________________|\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingrese una opción para continuar...");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
          case 1: {
            Console.ForegroundColor = ConsoleColor.Green;
            string resp = "";
            do {
              Console.WriteLine("Ingrese una palabra a la lista");
              string dato = Console.ReadLine();
              lista.addList(dato);
              Console.WriteLine("---------------------------");
              Console.WriteLine("Añadir palabra ... Si o No");
              Console.WriteLine("---------------------------");
              resp = Console.ReadLine();
            }while(resp != "No");
            Console.Clear();
            break;
          }
          case 2: {
            Console.ForegroundColor = ConsoleColor.Green;
            lista.show();
            break;
          }
          case 3: {
            Console.ForegroundColor = ConsoleColor.Green;
            lista.delete();
            break;
          }
          case 4: {
            Console.ForegroundColor = ConsoleColor.Green;
            lista.edit();
            break;
          }
          case 5: {
            Console.ForegroundColor = ConsoleColor.Green;
            lista.clearList();
            break;
          }
          case 6: {
            break;
          }
        }
        Console.WriteLine();
        Console.WriteLine("Volver al menú... Si o No");
        respuesta = Console.ReadLine();
      } while (respuesta != "No");
      Console.Clear();
    }
  }
}