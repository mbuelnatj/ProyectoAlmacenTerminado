using System;

namespace ProyectoAlmacen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia
            Operacion operacion = new Operacion();
            //Llamada del metodo
            operacion.Menu();
            Console.ReadKey();
        }
    }
}
