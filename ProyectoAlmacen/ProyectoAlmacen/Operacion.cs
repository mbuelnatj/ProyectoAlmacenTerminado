 using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAlmacen
{
    public class Operacion
    {
        List<Almacen> almacens = new List<Almacen>();
        public int Op { get; set; }

        public void AgregarProductos(Almacen almacen)
        {
            almacens.Add(almacen);

        }

        public void Menu()
        {

            do
            {
                Console.Clear();
                Console.WriteLine("Menu del Almacen");
                Console.WriteLine("1-) Alta del Producto al Almacen");
                Console.WriteLine("2-) Ver Productos guardados en el Almacen");
                Console.WriteLine("3-) Ventas de Productos");
                Console.WriteLine("4-) Cierre del Dia");
                Console.WriteLine("0-) Salida");
                Op = Convert.ToInt32(Console.ReadLine());
                Almacen almacen = new Almacen();
                switch (Op)
                {
                    case 1:

                        CapturarAlmacen();

                        
                        break;


                    case 2:

                        almacen.MostrarAlmacen(almacens);

                        break;


                    case 3:
                        VentasAlmacen();

                        break;

                    case 4:

                        almacen.CierreDia(almacens);

                        break;

                    case 0:
                        Console.WriteLine("Saliendo del Programa");
                        break;
                    default:

                        Console.WriteLine("Comando equivocado, porfavor de elegir otra opcion");
                        Console.ReadKey();
                        break;
                         



                }

            } while (Op!=0);
        }

        private void CapturarAlmacen()
        {
            Almacen almacen = new Almacen();

            Console.WriteLine("Ingrese Id para el Producto");
            almacen.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingre el tipo del producto: ");
            almacen.Tipo = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre del Producto: ");
            almacen.Nombre = Console.ReadLine();

            Console.WriteLine("Cantidad que va a Ingresar al Almacen: ");
            almacen.Cantidad = int.Parse(Console.ReadLine());

            almacen.Temporar = almacen.Cantidad;
            Console.WriteLine("Producto Registrado");

            
            AgregarProductos(almacen);
        }




        private void VentasAlmacen()
        {
          
            foreach (var almacen in almacens)
            {
              
                Console.WriteLine($"Id: {almacen.Id}\t" + $"Titulo:{almacen.Tipo}" + $"Nombre: {almacen.Nombre}");

            }
           
            Console.WriteLine("Elija una Producto");
            int numeroProducto = Convert.ToInt32(Console.ReadLine());
           
            Almacen ven = new Almacen();
            Almacen ventaProducto = new Almacen();

            foreach (var almacen in almacens)
            {
                if (almacen.Id == numeroProducto)
                {
                    ventaProducto = ven.VentasAlmacen(almacen);
                }
            }
            var index = almacens.FindIndex(item => item.Id == numeroProducto);
            almacens[index] = ventaProducto;


        }
    }
}
