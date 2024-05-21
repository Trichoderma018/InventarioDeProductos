using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioDeProductos
{
    internal class Repositorio
    {
        private List<Producto> _productos = new List<Producto>();
        public void Agregar(Producto producto)
        {


        }

        public IEnumerable<Producto> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Producto Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
