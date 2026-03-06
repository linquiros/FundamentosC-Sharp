using System;

//Encapsulamiento

public class CuentaBancaria
{
    private decimal saldo;

    public void Depositar(decimal monto)
    {
        saldo += monto;
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}

//Herencia

public class Animal
{
    public void Comer()
    {
        Console.WriteLine("El animal está comiendo");
    }
}

public class Perro : Animal 
{
    public void Ladrad()
    {
        Console.WriteLine("El perro ladra.");
    }
}




//Polimorfismooo

public class Figura 
{
    public void Dibujar()
    {
        Console.WriteLine("Dibujando una figura.");
    }
}

public class Circulo : Figura 
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un circulo");
    }
}

public class Cuadrado : Figura 
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un cuadrado");
    }
}

//Abstraccion

public abstract class Vehiculo
{
    public abstract void Mover();
}

public class Bicicleta : Vehiculo
{
    public override void Mover()
    {
        Console.WriteLine("La bicicleta avanza pedaleando");
    }
}

public class Auto : Vehiculo
{
    public override void Mover()
    {
        Console.WriteLine("El auto avanza con motor");
    }
}