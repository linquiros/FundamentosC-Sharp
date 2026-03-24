using System;

namespace Practica4
{
    // HERENCIA: Estudiante hereda de Persona
    public class Estudiante : Persona
    {
        private string Carrera;

        public Estudiante(string nombre, string cedula, int edad, string carrera) 
            : base(nombre, cedula, edad)
        {
            this.Carrera = carrera;
        }

        public string GetCarrera() => this.Carrera;

        // POLIMORFISMO: Sobrescribir comportamiento de la base
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Estudiante] Cédula: {GetCedula()} | Nombre: {GetNombre()} | Edad: {Edad} | Carrera: {Carrera}");
        }

        public override decimal CalcularPago()
        {
            if (Carrera == "Medicina") return 2000;
            if (Carrera == "Ingeniería") return 1500;
            return 1200;
        }
    }
}