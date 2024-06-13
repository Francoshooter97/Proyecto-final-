using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {
        private int Id;

        private string Descripcion;

        private int Costo;

        private int PrecioVenta;

        private int Stock;

        private int IdUsuario { get; set; }
        private object nombre { get; set; }
        private object apellido { get; set; }
        private object usuario { get; set; }
        private object pass { get; set; }

        private object mail { get; set; }

        public Producto() { }

        public Producto(object nombre, object apellido, object usuario, object pass, object mail)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.pass = pass;
            this.mail = mail;
        }

        public Producto(int id, string descripcion, int costo, int precioVenta, int stock, int idUsuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }

        public Producto(object nombre, object apellido, object usuario, object pass, object mail, string idUsuario1, int idUsuario2) : this(nombre, apellido, usuario, pass, mail)
        {
        }

        public int id
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }
        public string descripcion
        {
            get
            {
                return this.Descripcion;
            }
            set
            {
                this.Descripcion = value;
            }
        }

        public int costo
        {
            get
            {
                return this.Costo;
            }
            set
            {
                this.Costo = value;
            }
        }

        public int precioVenta
        {
            get
            {
                return this.PrecioVenta;
            }
            set
            {
                this.PrecioVenta = value;
            }
        }
        public int stock
        {
            get
            {
                return this.Stock;
            }
            set
            {
                this.Stock = value;
            }
        }

        public int idUsuario
        {
            get
            {
                return this.IdUsuario;
            }
            set
            {
                this.IdUsuario = value;
            }
        }


    }
}