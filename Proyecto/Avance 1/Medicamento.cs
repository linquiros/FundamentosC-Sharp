using System;

namespace FarmaciaProyecto
{
    [cite_start]// HERENCIA: Medicamento hereda de la clase Producto [cite: 10, 16]
    public class Medicamento : Producto
    {
        public string RequiereReceta { get; set; }

        public Medicamento(string codigo, string nombre, decimal precio, string receta) 
            : base(codigo, nombre, precio)
        {
            this.RequiereReceta = receta;
        }

        [cite_start]// POLIMORFISMO: Sobrescribimos el método para mostrar información específica de medicamentos [cite: 13]
        public override void MostrarDetalle()
        {
            Console.WriteLine($"[MEDICAMENTO] Cód: {GetCodigo()} | Nombre: {GetNombre()} | Precio: {Precio:C} | Receta: {RequiereReceta}");
        }
    }
}