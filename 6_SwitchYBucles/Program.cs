using System;

namespace _6_SwitchYBucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado, valores, opcion;
            Console.WriteLine("Operaciones de numeros enteros");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Multiplicar");
            Console.Write("Opcion: ");
            var entrada = Console.ReadLine();
            opcion = Convert.ToInt32(entrada);
            switch (opcion)
            {
                case 2:
                    resultado = 1;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            Console.Clear();
            Console.WriteLine("Ingresa numeros enteros diferentes de 0");
            Console.Write("Numero: ");
            entrada = Console.ReadLine();
            valores = Convert.ToInt32(entrada);
            while (valores != 0)
            {
                switch (opcion)
                {
                    case 1:
                        resultado += valores;
                        break;
                    case 2:
                        resultado *= valores;
                        break;
                    default:
                        break;
                }
                Console.Write("Numero: ");
                entrada = Console.ReadLine();
                valores = Convert.ToInt32(entrada);
            }
            Console.WriteLine("El total es: " + resultado);
            Console.Write("Ingresa la cantidad de nombres a guardar: ");
            int limite = Convert.ToInt32(Console.ReadLine());
            if (limite <= 0)
            {
                Console.WriteLine("Bueno, no se guarda ningun nombre");
            }
            else
            {
                string[] nombres = new string[limite];
                for (int n = 0; n < limite; n++)
                {
                    Console.Write("Nombre {0} : ", n + 1);
                    entrada = Console.ReadLine();
                    nombres[n] = (entrada == null) ? "" : entrada;
                }
                Console.Write("Nombres = ");
                foreach (string nombre in nombres)
                {
                    Console.Write(nombre + ", ");
                }
            }
        }
    }
}
