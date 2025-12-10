using System;

class Estudiante
{
    public int ID;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos = new string[3];  // Array para 3 teléfonos
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();

        Console.WriteLine("=== Registro de Estudiante ===");

        Console.Write("Ingrese el ID del estudiante: ");
        estudiante.ID = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los nombres del estudiante: ");
        estudiante.Nombres = Console.ReadLine();

        Console.Write("Ingrese los apellidos del estudiante: ");
        estudiante.Apellidos = Console.ReadLine();

        Console.Write("Ingrese la dirección del estudiante: ");
        estudiante.Direccion = Console.ReadLine();

        Console.WriteLine("\nIngrese los 3 números de teléfono:");
        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            estudiante.Telefonos[i] = Console.ReadLine();
        }

        // Mostrar datos
        Console.WriteLine("\n=== Datos Registrados ===");
        Console.WriteLine($"ID: {estudiante.ID}");
        Console.WriteLine($"Nombres: {estudiante.Nombres}");
        Console.WriteLine($"Apellidos: {estudiante.Apellidos}");
        Console.WriteLine($"Dirección: {estudiante.Direccion}");

        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.WriteLine($"  {i + 1}. {estudiante.Telefonos[i]}");
        }
    }
}
