namespace CrearPersona
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;

        public Persona()
        {         
        }

        public Persona(string nombre,string apellido,int edad,int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;

            Console.WriteLine("Se ha creado con éxito la Persona!");

        }

        ~Persona()
        {
            Console.WriteLine("La persona ha sido destruida con éxito!");
        }

        public string Nombre {
            get => nombre;
            set {
                nombre = value;
            }
        }

        public string Apellido {
            get => apellido;
            set {
                apellido = value;   
            }
        }

        public int Edad {
            get => edad;
            set {
                edad = value;
            }
        }

        public int Dni {
            get => dni;
            set {
                dni = value;    
            }
        }

        public string GetFullName()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public int GetAge()
        {
            return this.Edad;
        }
    }
}