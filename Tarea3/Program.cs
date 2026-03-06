using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animales = new List<Animal>();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- REFUGIO DE ANIMALES ---");
            Console.WriteLine("1. Agregar Perro");
            Console.WriteLine("2. Agregar Gato");
            Console.WriteLine("3. Agregar Ave");
            Console.WriteLine("4. Mostrar animales");
            Console.WriteLine("5. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarPerro(animales);
                    break;

                case "2":
                    AgregarGato(animales);
                    break;

                case "3":
                    AgregarAve(animales);
                    break;

                case "4":
                    MostrarAnimales(animales);
                    break;

                case "5":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void AgregarPerro(List<Animal> animales)
    {
        Console.WriteLine("Nombre del perro:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Edad:");
        int edad = int.Parse(Console.ReadLine());

        animales.Add(new Perro(nombre, edad));

        Console.WriteLine("Perro agregado.");
    }

    static void AgregarGato(List<Animal> animales)
    {
        Console.WriteLine("Nombre del gato:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Edad:");
        int edad = int.Parse(Console.ReadLine());

        animales.Add(new Gato(nombre, edad));

        Console.WriteLine("Gato agregado.");
    }

    static void AgregarAve(List<Animal> animales)
    {
        Console.WriteLine("Nombre del ave:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Edad:");
        int edad = int.Parse(Console.ReadLine());

        animales.Add(new Ave(nombre, edad));

        Console.WriteLine("Ave agregada.");
    }

    static void MostrarAnimales(List<Animal> animales)
    {
        Console.WriteLine("\nAnimales en el refugio:");

        foreach (Animal animal in animales)
        {
            Console.WriteLine($"Nombre: {animal.Nombre} - Edad: {animal.Edad}");
            animal.EmitirSonido();
        }
    }
}
