using System;
#pragma warning disable CS8600
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 15;
            // Concatenación
            Console.WriteLine("Tu edad es: " + edad);
            // Conoversión de datos
            string teclado = "25645128";
            int dni = Convert.ToInt32(teclado);
            // Reemplazo por posicion
            Console.WriteLine("Tu dni es: {0}", dni);
            int año = 2022;
            // Reemplazo por nombre
            Console.WriteLine($"El año actual es: {año}");
            // Otros tipos de datos
            float piFloat = 3.14159f;
            double piDouble = 3.14159265358979;
            decimal piDecimal = 3.1415926535897932384626433833m;
            Console.WriteLine("Pi con diferentes Presiciones de datos");
            Console.WriteLine("{0} {1} {2}", piFloat, piDouble, piDecimal);
            byte bits8min = byte.MinValue, bits8max = byte.MaxValue;
            short bits16min = short.MinValue, bits16max = short.MaxValue;
            int bits32min = int.MinValue, bits32max = int.MaxValue;
            long bits64min = long.MinValue, bits64max = long.MaxValue;
            Console.WriteLine("Valores minimos y maximos para tipos enteros");
            Console.WriteLine("byte: {0} - {1}", bits8min, bits8max);
            Console.WriteLine("short: {0} - {1}", bits16min, bits16max);
            Console.WriteLine("int: {0} - {1}", bits32min, bits32max);
            Console.WriteLine("long: {0} - {1}", bits64min, bits64max);
            char tecla = 'd';
            Console.WriteLine("Observa la siguitente tecla " + tecla);
            Console.WriteLine("Bien hecho");
            bool logico = false;
            Console.WriteLine("El siguiente valor lógico describe el tipo de persona que eres: " + logico);
            Console.ReadKey();
        }
    }
}