using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using Ingreso.Entidades;

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

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new formLogin());
        }

        public static Persona Validar(String mail, String pass)
        {
            Persona persona = null;
            if (mail != null && pass != null) {
                // validacion en base de datos
                string cadenaConexion = "Data Source=NOTEBOOK-DE-TOM\\SQLEXPRESS;Initial Catalog=BaseClub;Integrated Security=True;";

                string consulta = "SELECT * FROM personas p WHERE p.mail=@Mail";

                try
                {
                    // Abrir la conexión a la base de datos
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        // Crear el comando SQL con parámetros
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Mail", mail);
                            // Ejecutar la consulta
                            using (SqlDataReader reader = comando.ExecuteReader())
                            {
                                // Comprobar si hay algún resultado
                                if (reader.Read())
                                {
                                    // Leer los datos de la persona
                                    string nombre = reader["Nombre"].ToString();
                                    string apellido = reader["Apellido"].ToString();
                                    string correo = reader["Mail"].ToString();
                                    string password = reader["Password"].ToString();

                                    if (password == pass)
                                    {
                                        //usuario validado
                                        persona = new Persona(nombre,apellido,correo,password);
                                    } 
                                    else
                                    {
                                        //contraseña incorrecta
                                    }                                    
                                }
                                else
                                {
                                    // No se encontró el usuario, maneja el caso en consecuencia
                                }
                            }

                        }

                        conexion.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir durante la inserción
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return persona;
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

            string cadenaConexion = @"Data Source=NOTEBOOK-DE-TOM\SQLEXPRESS;Initial Catalog=BaseClub;Integrated Security=True;";

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

                    conexion.Close();  

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