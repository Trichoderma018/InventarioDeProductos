using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioDeProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario();
        }

        static void Inventario()
        {
            IRepositorio inventario = new Repositorio();
            inventario.Agregar(new Producto { Id = 1, Nombre = "Gallinasa", Gramaje = 45.00 });
            inventario.Agregar(new Producto { Id = 2, Nombre = "Carbonato", Gramaje = 50.00 });
            inventario.Agregar(new Producto { Id = 3, Nombre = "Cal", Gramaje = 23.00 });
            Producto producto = inventario.Obtener(2);
            Console.WriteLine("El Producto es: ", producto.Nombre);
            Console.WriteLine("El Gramaje es: ", producto.Gramaje, " Kilos");
            Console.WriteLine("");
            IEnumerable<Producto> productos = inventario.ListarTodos();
            foreach (var item in productos)
            {
                Console.WriteLine(item.Nombre);
            }
        }
    }
}
