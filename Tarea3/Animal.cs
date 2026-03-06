using System;

public abstract class Animal
{
    // Atributos privados (Encapsulación)
    private string nombre;
    private int edad;

    // Propiedades
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set
        {
            if (value > 0)
                edad = value;
            else
                edad = 1;
        }
    }

    // Constructor
    public Animal(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Método abstracto
    public abstract void EmitirSonido();

}
public class Perro : Animal
{
    public Perro(string nombre, int edad) : base(nombre, edad)
    {
    }

    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} dice: Guau Guau");
    }
}

public class Gato : Animal
{
    public Gato(string nombre, int edad) : base(nombre, edad)
    {
    }

    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} dice: Miau");
    }
}

public class Ave : Animal
{
    public Ave(string nombre, int edad) : base(nombre, edad)
    {
    }

    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} dice: Pío Pío");
    }
}
