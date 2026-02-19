using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar nombre
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        // Solicitar edad
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        // Mostrar saludo
        Console.WriteLine("Hola " + nombre + ", tienes " + edad + " años.");

        // Operador aritmético para calcular edad en 5 años
        int edadEnCinco = edad + 5;
        Console.WriteLine("En 5 años tendrás " + edadEnCinco + " años.");

        // Estructura condicional
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("Eres menor de edad.");
        }

        Console.ReadLine();
    }
}
