using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.minimarket.Entidades.DTO
{
   public class ProductoDTO
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string medidas { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public int marcaid { get; set; }
        public int proveedorid { get; set; }
        public int categoriaid { get; set; }
    }
}
