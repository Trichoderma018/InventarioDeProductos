using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioDeProductos
{
    internal interface IRepositorio
    {
        void Agregar(Producto producto);
        Producto Obtener(int id);
        IEnumerable<Producto> ListarTodos();
    }
}
