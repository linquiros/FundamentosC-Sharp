using System;

namespace FarmaciaProyecto
{
    [cite_start]// HERENCIA: ProductoBelleza extiende la funcionalidad de Producto [cite: 10]
    public class ProductoBelleza : Producto
    {
        public string Marca { get; set; }

        public ProductoBelleza(string codigo, string nombre, decimal precio, string marca) 
            : base(codigo, nombre, precio)
        {
            this.Marca = marca;
        }

        [cite_start]// POLIMORFISMO: Implementación propia del método MostrarDetalle [cite: 13]
        public override void MostrarDetalle()
        {
            Console.WriteLine($"[BELLEZA] Cód: {GetCodigo()} | Nombre: {GetNombre()} | Precio: {Precio:C} | Marca: {Marca}");
        }
    }
}