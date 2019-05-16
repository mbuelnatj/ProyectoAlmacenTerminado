using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAlmacen
{
    public class Almacen
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int RestaProducto { get; set; }
        public int Temporar { get; set; }
        public int N { get; set; }

        List<Almacen> almacens = new List<Almacen>();

  
        public void MostrarAlmacen(List<Almacen> almacens)
        {
            foreach (var almacen in almacens)
            {
                Console.WriteLine("Id:  " + almacen.Id + "\n" + "Tipo del Producto:  " + almacen.Tipo + "\n"
                + "Nombre del Producto: " + almacen.Nombre + "\n" + "Cantidad en el Almacen : " + almacen.Temporar);

            }

            Console.ReadKey();
        }


        public Almacen VentasAlmacen(Almacen almacen)
        {
            Console.WriteLine("Ingrese Cantidad: ");
            almacen.N = int.Parse(Console.ReadLine());
            almacen.Cantidad = almacen.Cantidad - almacen.N;

            return almacen;

        }

        public void CierreDia(List<Almacen> almacens)
        {
            foreach (var almacen in almacens)
            {
                Console.WriteLine("Id:  "+almacen.Id + "\n" +"Tipo del Producto:  "+almacen.Tipo+"\n"
                +"Nombre del Producto: "+ almacen.Nombre+"\n"+ "cantidad Inicial: "+ almacen.Temporar+"\n" 
                + "Cantidad Final " + almacen.Cantidad);

            }

            Console.ReadKey();

        }

    }
}
