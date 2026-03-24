using System;

namespace FarmaciaProyecto
{
    [cite_start]// ABSTRACCION: Definimos una clase base que representa la idea general de un producto [cite: 16]
    public abstract class Producto
    {
        [cite_start]// ENCAPSULACION: Atributos privados para proteger los datos sensibles [cite: 10, 16]
        private string codigo;
        private string nombre;
        
        [cite_start]// ENCAPSULACION: Propiedad pública para el precio con control de acceso [cite: 10]
        public decimal Precio { get; set; }

        public Producto(string codigo, string nombre, decimal precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.Precio = precio;
        }

        // ENCAPSULACION: Métodos para obtener datos privados de forma segura
        public string GetCodigo() => codigo;
        public string GetNombre() => nombre;

        [cite_start]// POLIMORFISMO: Método abstracto que será implementado de forma distinta en cada hijo [cite: 13, 16]
        public abstract void MostrarDetalle();
    }
}