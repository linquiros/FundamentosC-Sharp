using System;

class Seguridad
{
    static void Main()
    {
        
        string usuario = "admin";//Datos para simular
        string password = "1234";

        //Consulta sin parametros.
        string consultaInsegura =
            "SELECT * FROM Usuarios WHERE usuario = '"
            + usuario + "' AND password = '" + password + "'";

        //Consulta CON parametros
        string consultaSegura =
            "SELECT * FROM Usuarios WHERE usuario = @usuario AND password = @password";

        Console.WriteLine("\nConsulta insegura:");
        Console.WriteLine(consultaInsegura);

        Console.WriteLine("\nConsulta segura:");
        Console.WriteLine(consultaSegura);

        /*
         usar parámetros como usuario y password
         es más seguro porque no estamos pegando directamente
         lo que la persona escribe dentro del código SQL.
         
         Si concatenamos las cadenas, alguien podría escribir algo
         malicioso como: ' OR '1'='1 y alterar la consulta.
         
         En cambio, cuando usamos parámetros, la base de datos
         interpreta esos valores solo como datos y no como código
         
         Entonces eso ayuda a evitar ataques de inyección SQL
         y hace que la aplicación sea más segura.
        */
    }
}