using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso
{
    internal class Persona
    {
        String nombre;
        String apellido;
        String mail;
        String password;

        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.mail = "";
            this.password = "";
        }

        public Persona(string nombre, string apellido, string mail, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.password = password;
        }

        public String getMail() 
        {
            return this.mail;
        }

        public String getPassword() 
        {
            return this.password;
        }

    }
}
