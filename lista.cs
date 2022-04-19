namespace Diccionario
{
    class Lista
    {
        // head = cabeza
        private Nodo head;
        private Nodo aux;

        // construct 
        public Lista()
        {
            // instanciamos la clase
            head = new Nodo();
            // hacemos referencia que la lista inicialmente
            // estara vacia
            head.Enlace = null;
        }
        public void addList(string datoInsertar)
        {
            aux = head;
            while (aux.Enlace != null)
            {
                aux = aux.Enlace;
            }
            // Aqui instanciamos la clase nodo y se cree un nuevo nodo
            Nodo newNodo = new Nodo();
            newNodo.Dato = datoInsertar;
            newNodo.Enlace = null;
            aux.Enlace = newNodo;
        }
        // show = mostrar
        public void show()
        {
            aux = head;
            while (aux.Enlace != null)
            {
                aux = aux.Enlace;
                string dato = aux.Dato;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(" " + dato + " - ");
            }
        }
        public void edit()
        {


        }
        public void delete()
        {

        }
    }
}