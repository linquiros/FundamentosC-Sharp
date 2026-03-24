using System;

namespace Practica4
{
    // ABSTRACCION: Clase base que no se puede instanciar
    public abstract class Persona
    {
        // ENCAPSULACION: Atributos privados
        private string Nombre;
        private string Cedula;
        
        // ENCAPSULACION: Propiedad auto-implementada
        public int Edad { get; set; }

        public Persona(string nombre, string cedula, int edad)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Edad = edad;
        }

        // ENCAPSULACION: Métodos de acceso
        public string GetNombre() => this.Nombre;
        public string GetCedula() => this.Cedula;

        // POLIMORFISMO: Método abstracto para ser implementado en hijos
        public abstract void MostrarInfo();

        // POLIMORFISMO: Método virtual con implementación base
        public virtual decimal CalcularPago()
        {
            return 1000;
        }
    }
}