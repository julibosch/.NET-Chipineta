using System;
using System.Collections.Generic;

class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Sueldo { get; set; }

    public Empleado(int id, string nombre, decimal sueldo)
    {
        Id = id;
        Nombre = nombre;
        Sueldo = sueldo;
    }
}

class Program
{
    static void Main()
    {
        List<Empleado> ListaEmpleados = new List<Empleado>();

        DarDeAltaEmpleado(ListaEmpleados, 1, "Juan", 2500);
        DarDeAltaEmpleado(ListaEmpleados, 2, "María", 3000);
        DarDeAltaEmpleado(ListaEmpleados, 3, "Pedro", 2000);

        static void DarDeAltaEmpleado(List<Empleado> ListaEmpleados, int id, string nombre, decimal sueldo)
        {
            Empleado empleado = new Empleado ( id , nombre, sueldo );
            ListaEmpleados.Add(empleado);
        } 

        Console.WriteLine("Sistema de gestión de empleados");

        while (true)
        {
            Console.WriteLine("\n1. Agregar empleado");
            Console.WriteLine("2. Mostrar empleados ordenados por sueldo (ascendente)");
            Console.WriteLine("3. Mostrar empleados ordenados por sueldo (descendente)");
            Console.WriteLine("4. Salir");
            Console.Write("\nIngrese la opción deseada: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarEmpleado(ListaEmpleados);
                    break;
                case "2":
                    MostrarEmpleadosOrdenadosPorSueldo(ListaEmpleados, true);
                    break;
                case "3":
                    MostrarEmpleadosOrdenadosPorSueldo(ListaEmpleados, false);
                    break;
                case "4":
                    Console.WriteLine("\n¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("\nOpción inválida. Por favor, ingrese una opción válida.");
                    break;
            }
        }
    }


    static void AgregarEmpleado(List<Empleado> empleados)
    {
        Console.WriteLine("\nIngrese los datos del empleado:");

        Console.Write("ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Sueldo: ");
        decimal sueldo = Convert.ToDecimal(Console.ReadLine());

        Empleado empleado = new Empleado(id, nombre, sueldo);
        empleados.Add(empleado);

        Console.WriteLine("\nEmpleado agregado exitosamente.");
    }

    static void MostrarEmpleadosOrdenadosPorSueldo(List<Empleado> empleados, bool ascendente)
    {
        Console.WriteLine("\nEmpleados ordenados por sueldo:");

        if (ascendente)
        {
            empleados.Sort((emp1, emp2) => emp1.Sueldo.CompareTo(emp2.Sueldo));
        }
        else
        {
            empleados.Sort((emp1, emp2) => emp2.Sueldo.CompareTo(emp1.Sueldo));
        }

        foreach (var empleado in empleados)
        {
            Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre}, Sueldo: {empleado.Sueldo}");
        }
    }
}