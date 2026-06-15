using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVinos.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<DetalleCompra> Detalles { get; set; }
    }
}