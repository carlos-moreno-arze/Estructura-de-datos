namespace Diccionario {
  class Nodo {
    // Declaramos dato que es un atributo de la lista
    private string dato;
    // aqui tendremos siguiente o enlace que nos ayuda
    // a pasar al siguiente nodo
    private Nodo enlace = null;
    // Usamos los metodos get y set para poder asignar 
    // directo a atributo dato
    public string Dato {
      // get es obtener el dato 
      get => dato;
      // set es asignar el valor obtenido a value o valor
      set => dato = value;
    }
    // De igual manera es un metodo para asignar valor directo
    // al atributo enlace de la clase Nodo
    public Nodo Enlace {
      get {
        return enlace;
      }
      set {
        enlace = value;
      }
    }
  }
}