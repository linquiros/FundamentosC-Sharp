using System;
using System.Collections.Generic; // Para el uso de colecciones [cite: 12]
using System.Linq;

namespace FarmaciaProyecto
{
    class Program
    {
        [cite_start]// COLECCION: List para el almacenamiento dinámico del inventario [cite: 12, 17]
        static List<Producto> inventario = new List<Producto>();
        
        [cite_start]// COLECCION: Queue para simular la fila de atención (Primero en entrar, primero en salir) [cite: 12, 17]
        static Queue<string> filaClientes = new Queue<string>();

        static void Main(string[] args)
        {
            [cite_start]// MENU: Opciones básicas en consola para la interacción con el usuario [cite: 11]
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- SISTEMA DE FARMACIA ROCKET ---");
                Console.WriteLine("1. Registrar Medicamento");
                Console.WriteLine("2. Registrar Producto de Belleza");
                Console.WriteLine("3. Ver Inventario Completo (List)");
                Console.WriteLine("4. Agregar Cliente a la Fila (Queue)");
                Console.WriteLine("5. Atender Cliente");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": AgregarMedicamento(); break;
                    case "2": AgregarBelleza(); break;
                    case "3": ListarProductos(); break;
                    case "4": AnotarCliente(); break;
                    case "5": AtenderCliente(); break;
                    case "6": continuar = false; break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
        }

        public static void AgregarMedicamento()
        {
            Console.Write("Código: "); string c = Console.ReadLine();
            Console.Write("Nombre: "); string n = Console.ReadLine();
            Console.Write("Precio: "); decimal p = decimal.Parse(Console.ReadLine());
            Console.Write("¿Requiere receta? (S/N): "); string r = Console.ReadLine();
            
            inventario.Add(new Medicamento(c, n, p, r));
            Console.WriteLine("Medicamento registrado exitosamente.");
        }

        public static void AgregarBelleza()
        {
            Console.Write("Código: "); string c = Console.ReadLine();
            Console.Write("Nombre: "); string n = Console.ReadLine();
            Console.Write("Precio: "); decimal p = decimal.Parse(Console.ReadLine());
            Console.Write("Marca: "); string m = Console.ReadLine();
            
            inventario.Add(new ProductoBelleza(c, n, p, m));
            Console.WriteLine("Producto de belleza registrado exitosamente.");
        }

        public static void ListarProductos()
        {
            Console.WriteLine("\n--- INVENTARIO DE LA FARMACIA ---");
            [cite_start]// POLIMORFISMO: Se recorre la lista y se ejecuta la versión del método que corresponda a cada objeto [cite: 13]
            foreach (var prod in inventario) 
            { 
                prod.MostrarDetalle(); 
            }
        }

        public static void AnotarCliente()
        {
            Console.Write("Nombre del cliente: ");
            string cliente = Console.ReadLine();
            filaClientes.Enqueue(cliente); // Añadir a la cola [cite: 12]
            Console.WriteLine("Cliente añadido a la fila de espera.");
        }

        public static void AtenderCliente()
        {
            if (filaClientes.Count > 0)
            {
                string atendido = filaClientes.Dequeue(); // Sacar de la cola [cite: 12]
                Console.WriteLine($"Atendiendo a: {atendido}");
            }
            else
            {
                Console.WriteLine("No hay clientes en la fila.");
            }
        }
    }
}