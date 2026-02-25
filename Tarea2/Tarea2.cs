using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

class Bucles
{
    static void Main()
    {
        
        // FOR
    
        Console.WriteLine("Ciclo FOR");

        for (int i = 1; i <= 50; i++)
        {
            if (i == 25)
            {
                break; // Detiene el ciclo cuando llega a 25
            }

            if (i % 5 == 0)
            {
                continue; // Salta los múltiplos de 5
            }

            Console.WriteLine(i);
        }

        
        // FOREACH
        
        Console.WriteLine("Ciclo FOREACH");

        List<string> estudiantes = new List<string>()
        {
            "Andrés",
            "Lindsay",
            "Rosi",
            "José"
        };

        foreach (string nombre in estudiantes)
        {
            if (nombre == "Lindsay")
            {
                continue; // No muestra saludo a Lindsay
            }

            Console.WriteLine("Hola " + nombre + "!");
        }

        
        // WHILE
        
        Console.WriteLine("Ciclo WHILE");

        while (true)
        {
            Console.Write("Ingrese un número positivo o 0 para salir: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                break; // Termina cuando el usuario ingresa 0
            }

            if (numero > 100)
            {
                Console.WriteLine("Número mayor a 100. Se detiene el ciclo.");
                break; // Se detiene si es mayor a 100
            }

            Console.WriteLine("Número válido: " + numero);
        }

        
        // DO WHILE + SWITCH
        
        Console.WriteLine("Ciclo DO WHILE");

        int opcion;

        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Mostrar números pares");
            Console.WriteLine("2. Mostrar números impares");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Números pares del 1 al 20:");
                    for (int i = 1; i <= 20; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Números impares del 1 al 20:");
                    for (int i = 1; i <= 20; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 3);

    }
}