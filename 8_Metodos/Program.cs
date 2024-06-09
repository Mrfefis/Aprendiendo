namespace _8_Metodos
{
    internal class Program
    {
        private int limite;
        private string[] nombres;
        private int[] dnis;
        private byte ultima;

        public Program(int limite)
        {
            this.limite = limite;
            nombres = new string[limite];
            dnis = new int[limite];
            ultima = 0;
        }

        static void Main(string[] args)
        {
            string opcion = "";
            var clientes = new Program(1000);
            while (opcion!="0")
            {
                Console.Clear();
                opcion = Opciones();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        clientes.Cargar();
                        break;
                    case "2":
                        clientes.Mostrar();
                        break;
                    case "3":
                        clientes.Eliminar();
                        break;
                    default:
                        break;
                }
            }
        }
        private static string Opciones()
        {
            Console.WriteLine("Sistema Gestor de Clientes");
            Console.WriteLine("1. Cargar un cliente");
            Console.WriteLine("2. Mostrar la lista de Clientes");
            Console.WriteLine("3. Eliminar un cliente");
            Console.WriteLine("0. Terminar el programa");
            Console.Write("Opcion: ");
            string opcion = Console.ReadLine()!;
            return opcion;
        }

        public void Cargar()
        {
            if (ultima==limite)
            {
                Console.WriteLine("Cantidad maxima de empleados alcanzada");
            }
            else
            {
                Console.Write("Nombre: ");
                nombres[ultima] = Console.ReadLine()!;
                Console.Write("DNI: ");
                dnis[ultima] = Convert.ToInt32(Console.ReadLine());
                ultima++;
            }
        }

        public void Mostrar()
        {
            for (int i = 0; i < ultima; i++)
            {
                Console.WriteLine("({0}, {1})", nombres[i], dnis[i]);
            }
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void Eliminar()
        {
            if (ultima == 0)
            {
                Console.WriteLine("No hay clientes");
            }
            else
            {
                ultima--;
            }
        }
    }
}
