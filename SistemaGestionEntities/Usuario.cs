using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Usuario
    {
        private int Id;

        private string Nombre;

        private string Apellido;

        private string NombreUsuario;

        private string Contrasenia;

        private string Mail;

        public string idproducto;

        public Usuario() { }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenia = contrasenia;
            this.Mail = mail;
        }
        public Usuario(string nombre, string apellido, string nombreUsuario, string password, string email)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = password;
            this.mail = email;
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

        public string nombre
        {
            get
            {
                return this.Nombre;
            }
            set
            {
                this.Nombre = value;
            }
        }

        public string apellido
        {
            get
            {
                return this.Apellido;
            }
            set
            {
                this.Apellido = value;
            }
        }

        public string nombreUsuario
        {
            get
            {
                return this.NombreUsuario;
            }
            set
            {
                this.NombreUsuario = value;
            }
        }

        public string contrasenia
        {
            get
            {
                return this.Contrasenia;
            }

            set
            {
                this.Contrasenia = value;
            }
        }
        public string mail
        {
            get
            {
                return this.Mail;
            }
            set
            {
                this.Mail = value;
            }
        }
    }
}



    


