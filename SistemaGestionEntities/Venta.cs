using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Venta
    {
        private int Id;

        private string Comentarios;

        private int IdUsuario;

        public Venta()
        {
        }

        public Venta(string id)
        {
        }

        public Venta(int userId, int id) { }
        public Venta(int id, string comentarios, int idUsuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.IdUsuario = idUsuario;
        }

        public Venta(int userId, int id, string? comentarios) : this(userId, id)
        {
        }

        public Venta(string id, string comentarios, int idUsuario) : this(id)
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
        public string comentarios
        {
            get
            {
                return this.Comentarios;
            }
            set
            {
                this.Comentarios = value;
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

        public Venta GetVentaById(int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
