using System.Text;

namespace _7_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris " +
                "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
                "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla " +
                "pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa" +
                " qui officia deserunt mollit anim id est laborum.";
            Console.WriteLine(lorem);
            Console.WriteLine();
            string dolor = lorem.Substring(12, 5);
            Console.WriteLine(dolor);
            Console.WriteLine("Donde esta el dolor? " + lorem.IndexOf("dolor"));
            string nodolor = lorem.Remove(12, 6);
            Console.WriteLine(nodolor);
            lorem = lorem.Replace("dolor", "no");
            Console.WriteLine();
            Console.WriteLine(lorem);
            Console.Write("Ingresa un Palindromo: ");
            var entrada = Console.ReadLine();
            string palindromo = entrada == null ? "" : entrada;
            string inverso = "";
            foreach (char letra in palindromo)
            {
                inverso += letra;
            }
            if (palindromo == inverso)
            {
                Console.WriteLine("Es un palindromo");
            }
            else
            {
                Console.WriteLine(" No es palindromo");
            }
        }
    }
}
