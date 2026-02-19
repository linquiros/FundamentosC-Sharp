using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar nombre y edad
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        //Frase inicial con el nombre y la edad
        Console.WriteLine("Hola " + nombre + ", tienes " + edad + " años.");

        // Calcular la edad en 5 años
        int edadEnCinco = edad + 5; //Operacion usando la edad que ya le habíamos solicitado al usuario
        Console.WriteLine("En 5 años tendrás " + edadEnCinco + " años.");

        // Condicnional para ver si la persona es mayor de edad o menor de edad
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
