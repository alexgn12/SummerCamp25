internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Introduce un nunmero del 1 al 7 (o 0 para salir):");

        while (true)
        {
            int numero = int.Parse(Console.ReadLine());

            // Bucle para seguir pidiendo números hasta que se introduzca 0

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                case 0:
                    Console.WriteLine("Hasta luego!!");
                    return;
                default:
                    Console.WriteLine("Valor no valido, intenta de nuevo.");
                    break;
            }
        }
    }
}