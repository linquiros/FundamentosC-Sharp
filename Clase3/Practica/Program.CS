using System;

namespace Practica
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            //Estudiante estudiante1 = new Estudiante("Jeffry", 35, "Ingenieria Informatica");
            //EstudianteBecado estudiante2 = new EstudianteBecado("Luis", 23, "Derecho", "Académica");
            //estudiante1.MostrarInfo();
            //estudiante2.MostrarInfo();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n ---MENU DEL ESTUDIANTE---");
                Console.WriteLine("1.Agregar un estudiante.");
                Console.WriteLine("2.Listar los estudiantes actuales.");
                Console.WriteLine("3.Buscar estudiante por cedula");
                Console.WriteLine("4.Filtrar estudiante por edad");// Usar LINQ
                Console.WriteLine("5Atender estudiante"); // Queue
                Console.WriteLine("6. Registrar estudiante atendido"); // Stack
                Console.WriteLine("7. Salir");
                Console.WriteLine("Ingrese una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": AgregarEstudiante(); break;
                    case "7": salir = true; break;
                    default: Console.WriteLine("Opción no válida. Intente de nuevo."); break;
                }
            }
        }
            public static void AgregarEstudiante()
        {
            Console.WriteLine("Ingrese si es un estudiante becado (s/n): ");
            string esBecado = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del estudiante: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la carrera del estudiante: ");
            string carrera = Console.ReadLine();

            //Parte nueva

            if (esBecado == "s")
            {
                Console.WriteLine("Ingrese el tipo de beca");
                string TipoBeca = Console.ReadLine();

                EstudianteBecado estudiante1 = new EstudianteBecado( nombre,  edad,  carrera,  tipoBeca);
                personas.Add(estudiante1);

                Console.WriteLine("Estudiante agregado exitosamente");
            }
            else
            {
                Estudiante estudiante1 = new Estudiante( nombre, edad, carrera);
                persona.Add(estudiante1);
                Console.WriteLine("Estudiante agregado exitosamente");
            }

        }

        }
    }