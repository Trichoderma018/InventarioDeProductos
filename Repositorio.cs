using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioDeProductos
{
    public class Repositorio : IRepositorio
    {
        private List<Producto> _productos = new List<Producto>();
        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
        }

        public IEnumerable<Producto> ListarTodos()
        {
            return _productos;
        }

        public Producto Obtener(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }
    }
}
