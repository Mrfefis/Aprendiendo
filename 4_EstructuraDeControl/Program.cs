namespace _4_EstructuraDeControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingresa un numero positivo mayor a 10: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("No es positivo");
            }
            else if (numero > 10)
            {
                Console.WriteLine("Es demasiado alto");
            }
            else if (numero == 0)
            {
                Console.WriteLine("No es positivo?");
            }
            else
            {
                Console.WriteLine("Gracias");
            }
            var resultado = (numero<0)?"No es positivo":
                (numero>10)?"Es demasiado alto":
                (numero == 0) ? "No es positivo?" : "Gracias";
            Console.WriteLine(resultado);
        }
    }
}