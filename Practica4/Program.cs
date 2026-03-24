using System;
using System.Collections.Generic;
using System.Linq; // LINQ: Necesario para consultas

namespace Practica4
{
    public class Program
    {
        // COLECCIONES: Declaración de las estructuras solicitadas
        static List<Persona> listaEstudiantes = new List<Persona>();
        static Queue<Persona> colaAtencion = new Queue<Persona>();
        static Stack<Persona> historialAtendidos = new Stack<Persona>();

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n--- MENU DEL ESTUDIANTE ---");
                Console.WriteLine("1. Agregar un estudiante");
                Console.WriteLine("2. Listar los estudiantes actuales (List)");
                Console.WriteLine("3. Buscar estudiante por cedula (LINQ)");
                Console.WriteLine("4. Filtrar estudiante por edad (LINQ)");
                Console.WriteLine("5. Enviar a fila de espera (Queue)");
                Console.WriteLine("6. Registrar como atendido (Stack)");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": AgregarEstudiante(); break;
                    case "2": ListarEstudiantes(); break;
                    case "3": BuscarPorCedula(); break;
                    case "4": FiltrarPorEdad(); break;
                    case "5": AtenderEstudiante(); break; // Enviar a cola
                    case "6": RegistrarAtendido(); break; // Pasar a historial
                    case "7": salir = true; break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
        }

        // METODO: Agregar con lógica de herencia
        public static void AgregarEstudiante()
        {
            Console.Write("¿Es becado? (s/n): ");
            string esBecado = Console.ReadLine().ToLower();
            Console.Write("Cédula: "); string cedula = Console.ReadLine();
            Console.Write("Nombre: "); string nombre = Console.ReadLine();
            Console.Write("Edad: "); int edad = int.Parse(Console.ReadLine());
            Console.Write("Carrera: "); string carrera = Console.ReadLine();

            if (esBecado == "s")
            {
                Console.Write("Tipo de Beca: ");
                string tipo = Console.ReadLine();
                listaEstudiantes.Add(new EstudianteBecado(nombre, cedula, edad, carrera, tipo));
            }
            else
            {
                listaEstudiantes.Add(new Estudiante(nombre, cedula, edad, carrera));
            }
            Console.WriteLine("¡Estudiante agregado!");
        }

        // LIST: Recorrer la lista y mostrar info (Polimorfismo en acción)
        public static void ListarEstudiantes()
        {
            Console.WriteLine("\n--- LISTADO DE ESTUDIANTES ---");
            if (listaEstudiantes.Count == 0) Console.WriteLine("Lista vacía.");
            foreach (var p in listaEstudiantes)
            {
                p.MostrarInfo();
            }
        }

        // LINQ: Buscar un estudiante por cédula (FirstOrDefault)
        public static void BuscarPorCedula()
        {
            Console.Write("Ingrese la cédula a buscar: ");
            string ced = Console.ReadLine();

            var encontrado = listaEstudiantes.FirstOrDefault(p => p.GetCedula() == ced);

            if (encontrado != null) encontrado.MostrarInfo();
            else Console.WriteLine("No se encontró un estudiante con esa cédula.");
        }

        // LINQ: Filtrar usando Where
        public static void FiltrarPorEdad()
        {
            Console.Write("Mostrar estudiantes mayores a: ");
            int edadMinima = int.Parse(Console.ReadLine());

            var filtrados = listaEstudiantes.Where(p => p.Edad > edadMinima).ToList();

            Console.WriteLine($"\n--- Mayores de {edadMinima} años ---");
            filtrados.ForEach(f => f.MostrarInfo());
        }

        // QUEUE: Simular entrada a atención (FIFO)
        public static void AtenderEstudiante()
        {
            if (listaEstudiantes.Count == 0)
            {
                Console.WriteLine("No hay nadie registrado para enviar a la cola.");
                return;
            }

            // Tomamos al primero de la lista para la cola
            Persona p = listaEstudiantes[0];
            colaAtencion.Enqueue(p);
            Console.WriteLine($"{p.GetNombre()} ha entrado a la cola de espera.");
        }

        // STACK: Registrar que ya fue atendido (LIFO)
        public static void RegistrarAtendido()
        {
            if (colaAtencion.Count == 0)
            {
                Console.WriteLine("La cola de atención está vacía.");
                return;
            }

            // Sale de la cola y entra a la pila (Historial)
            Persona atendido = colaAtencion.Dequeue();
            historialAtendidos.Push(atendido);

            Console.WriteLine($"Se ha atendido a: {atendido.GetNombre()}. Registro guardado en historial.");
            Console.WriteLine($"Total en historial: {historialAtendidos.Count}");
        }
    }
}