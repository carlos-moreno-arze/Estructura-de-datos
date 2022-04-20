namespace Diccionario {
  class Lista {
    // head = cabeza
    private Nodo head;
    private Nodo aux;

    // construct 
    public Lista () {
      // instanciamos la clase
      head = new Nodo();
      // hacemos referencia que la lista inicialmente
      // estara vacia
      head.Enlace = null;
    }
    public void addList (string datoInsertar) {
      aux = head;
      while (aux.Enlace != null) {
        aux = aux.Enlace;
      }
      // Aqui instanciamos la clase nodo y se crea un nuevo nodo
      Nodo newNodo = new Nodo();
      newNodo.Dato = datoInsertar;
      newNodo.Enlace = null;
      aux.Enlace = newNodo;
    }
    // show = mostrar
    public void show () {
      aux = head;
      while (aux.Enlace != null) {
        aux = aux.Enlace;
        string dato = aux.Dato;
        Console.Write(dato + " - ");
      }
    }
    public void edit () {
      Nodo actual = new Nodo();
      actual = head;
      bool encontrado = false;
      Console.WriteLine("Ingrese la letra a modificar");
      string letraBuscada = Console.ReadLine();
      if (head != null) {
        while((actual != null)&&(encontrado != true)) {
          if ((actual.Dato == letraBuscada)) {
            Console.WriteLine("La letra" + letraBuscada + " fue encontrada ");
            Console.WriteLine("Ingrese el nuevo valor para esta letra : ");
            actual.Dato = Console.ReadLine();
            Console.WriteLine("Letra modificada exitosamente!!");
            encontrado = true;
          }
          actual = actual.Enlace;
        }
        if (!encontrado) {
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("No se encontro la letra en la lista");
        }
      }
      else {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("La lista se encuenta vacía");
      }
    }
    public void delete () {
      Nodo delete = new Nodo();
      delete = head;
      bool encontrado = false;
      Console.WriteLine("Ingrese la letra a eliminar");
      var letraEliminar = Console.ReadLine();
      if (head != null) {
        while((delete != null)&&(encontrado != true)) {
          if ((delete.Dato == letraEliminar)) {
            Console.WriteLine("La letra => { " + letraEliminar + " } fue encontrada ");
            delete.Dato = null;
            Console.WriteLine("Letra fue eliminada exitosamente!!");
            encontrado = true;
          }
          delete = delete.Enlace;
        }
        if (!encontrado) {
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("No se encontro la letra en la lista");
        }
      }
      else {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("La lista se encuenta vacía");
      }
    }
    public void clearList () {
      head = null;
    }
  }
}