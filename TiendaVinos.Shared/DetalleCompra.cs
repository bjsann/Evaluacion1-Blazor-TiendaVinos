using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVinos.Shared
{
    public class DetalleCompra
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }

        public int CompraId { get; set; }
        public Compra Compra { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}