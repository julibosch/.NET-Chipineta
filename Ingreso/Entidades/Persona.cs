using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso.Entidades
{
    internal class Persona
    {
        string nombre;
        string apellido;
        string mail;
        string password;

        public Persona()
        {
            nombre = "";
            apellido = "";
            mail = "";
            password = "";
        }

        public Persona(string nombre, string apellido, string mail, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.password = password;
        }

        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public string getMail()
        {
            return mail;
        }

        public string getPassword()
        {
            return password;
        }

    }
}
