
namespace Diccionario {
  class Program {
    static void Main (string [] args) {
      Lista lista = new Lista();
      string respuesta = "";
      do {

        Console.WriteLine("|                                                              |\n");
        Console.WriteLine("|                    Menu de Opciones                      |\n");
        Console.WriteLine("|1.- Añadir palabra|\n");
        Console.WriteLine("|2.- Mostrar palabras\n");
        Console.WriteLine("|3.- Eliminar palabra\n");
        Console.WriteLine("|4.- Editar palabra|\n");
        Console.WriteLine("|5.- ****** Salir *******|\n");
        //  Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("|      © Derechos reservados diseñado por: Kevin Jhonatan M.        |\n");

        // Console.BackgroundColor = ConsoleColor.Blue;
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
          case 1: {
            string resp = "";
            do {
              Console.WriteLine("Ingrese una palabra");
              string dato = Console.ReadLine();
              lista.addList(dato);
              Console.WriteLine("**************************");
              Console.WriteLine("Añadir palabra ... Si o No");
              Console.WriteLine("**************************");
              resp = Console.ReadLine();
            }while(resp != "No");
            Console.Clear();
            break;
          }
          case 2: {
            lista.show();
            Console.Clear();
            break;
          }
          case 3: {
            lista.delete();
            Console.Clear();
            break;
          }
          case 4: {
            lista.edit();
            Console.Clear();
            break;
          }
          case 5: {
            break;
          }
        }
        Console.WriteLine();
        Console.WriteLine("Volver al menú... Si o No ...");
        respuesta = Console.ReadLine();
      } while (respuesta != "No");
      Console.Clear();
    }
  }
}