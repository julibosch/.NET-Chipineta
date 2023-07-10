using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Ingreso
{
    internal static class Program
    {
        public static ArrayList personas = new ArrayList();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Persona persona1 = new Persona("Ale", "Fore", "a@f.com", "asd");
            Persona persona2 = new Persona("Tom", "Bro", "t@b.com", "asd");
            Persona persona3 = new Persona("Juan", "Bosch", "bocha@b.com", "asd");
            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(persona3);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new formLogin());
        }

        public static Boolean Validar(String mail, String pass)
        {
            Boolean validar = false;
            if (mail != null && pass != null) {
                foreach (Persona p in personas)
                {
                    if(p.getMail() == mail)
                    {
                        if(p.getPassword() == pass)
                        {
                            validar = true;
                            break;
                        }
                    }
                }

            }


            return validar;
        }

        public static Boolean AddPersona(Persona p)
        {
            Boolean val = true;
            foreach (Persona per in personas)
            {
                if (per.getMail() == p.getMail())
                {
                    val = false;
                }
            }
            if (val)
            {
                personas.Add(p);    

            }
            return val;
        }

    }
}