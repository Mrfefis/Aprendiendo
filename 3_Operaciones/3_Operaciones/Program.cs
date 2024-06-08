namespace _3_Operaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = 90;
            num2 = 15;
            // Operadores Aritmeticos
            var resultado = num1 + num2;
            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, resultado);
            resultado = num1 - num2;
            Console.WriteLine("La resta de {0} - {1} = {2}", num1, num2, resultado);
            resultado = num1 * num2;
            Console.WriteLine("El producto de {0} * {1} = {2}", num1, num2, resultado);
            resultado = num1 / num2;
            Console.WriteLine("El cociente de {0} / {1} = {2}", num1, num2, resultado);
            resultado = num1 % num2;
            Console.WriteLine("El resto de {0} % {1} = {2}", num1, num2, resultado);
            // Operadores Logicos
            bool encontrado;
            encontrado = (num1 == num2);
            Console.WriteLine("Num1 == Num2? " + encontrado);
            encontrado = (num1 != num2);
            Console.WriteLine("Num1 != Num2? " + encontrado);
            encontrado = (num1 > num2);
            Console.WriteLine("Num1 > Num2? " + encontrado);
            encontrado = (num1 < num2);
            Console.WriteLine("Num1 < Num2? " + encontrado);
            encontrado = (num1 >= num2);
            Console.WriteLine("Num1 >= Num2? " + encontrado);
            encontrado = (num1 <= num2);
            Console.WriteLine("Num1 <= Num2? " + encontrado);
        }
    }
}
