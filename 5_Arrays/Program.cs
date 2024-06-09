namespace _5_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limite = 5;
            string[] nombres = new string[limite];
            int[] edades = {2, 4, 8, 16, 32};
            nombres[0] = "Alberto";
            nombres[1] = "Juan";
            nombres[2] = "Micaela";
            nombres[3] = "Raul";
            nombres[4] = "Ulman";
            Console.WriteLine("Empleados = [({0} {1}), ({2}, {3})]",
                nombres[3], edades[3], nombres[1], edades[1]);
            Console.WriteLine("Clientes = [({0} {1}), ({2}, {3}), ({4}, {5})]",
                nombres[4], edades[4], nombres[0], edades[0], nombres[2], edades[2]);
            const int año = 2;
            const int materia = 2;
            string[,] alumnos = new string[año,materia];
            alumnos[0, 0] = "Raul";
            alumnos[0, 1] = "Roberto";
            alumnos[1, 0] = "Hector";
            alumnos[1, 1] = "Angel";
            Console.WriteLine("Alumnos listados por año");
            Console.WriteLine("Primer año: {0}, {1}", alumnos[0, 0], alumnos[0, 1]);
            Console.WriteLine("Segundo año: {0}, {1}", alumnos[1, 0], alumnos[1, 1]);
        }
    }
}
