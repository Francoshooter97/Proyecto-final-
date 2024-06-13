using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        public object Text;

        private int Id;
        private int IdProducto;
        private int Stock;
        private int idVenta;

        public ProductoVendido() { }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.Id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;
        }

        public int id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        public int idProducto
        {
            get { return this.IdProducto; }
            set { this.IdProducto = value; }
        }

        public int stock
        {
            get { return this.Stock; }
            set { this.Stock = value; }
        }

        public int IdVenta
        {
            get { return this.idVenta; }
            set { this.idVenta = value; }
        }
    }
}