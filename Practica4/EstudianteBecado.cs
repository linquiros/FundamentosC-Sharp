using System;

namespace Practica4
{
    // HERENCIA: Hereda de Estudiante
    public class EstudianteBecado : Estudiante
    {
        public string TipoBeca { get; set; }

        public EstudianteBecado(string nombre, string cedula, int edad, string carrera, string tipoBeca)
            : base(nombre, cedula, edad, carrera)
        {
            this.TipoBeca = tipoBeca;
        }

        // POLIMORFISMO: Nueva redefinición de MostrarInfo
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Becado] Cédula: {GetCedula()} | Nombre: {GetNombre()} | Beca: {TipoBeca} | Carrera: {GetCarrera()}");
        }

        public override decimal CalcularPago()
        {
            // Uso de base para obtener el cálculo previo y aplicar descuento
            return base.CalcularPago() * 0.5m;
        }
    }
}