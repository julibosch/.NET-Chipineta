using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;



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
        public static Boolean NuevoSocio(Persona per)
        {
            string nombre = per.getNombre();
            string apellido = per.getApellido();
            string mail = per.getMail();
            string password = per.getPassword();

            string cadenaConexion = "Data Source=NOTEBOOK-DE-TOM\\SQLEXPRESS;Initial Catalog=BaseClub;Integrated Security=True;";

            string consulta = "INSERT INTO Persona (nombre, apellido, mail, password) VALUES (@Nombre, @Apellido, @Mail, @Password)";

            try
            {   
                // Abrir la conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    // Crear el comando SQL con parámetros
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Apellido", apellido);
                        comando.Parameters.AddWithValue("@Mail", mail);
                        comando.Parameters.AddWithValue("@Password", password);

                        // Ejecutar la consulta de inserción
                        comando.ExecuteNonQuery();
                        // El nuevo socio ha sido guardado en la base de datos
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la inserción
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

    }
    
}