internal class Program
{
    private static void Main(string[] args)
    {
        int Number;

        Console.WriteLine("escribe un numero");
        Number = Convert.ToInt32(Console.ReadLine());
        if (Number % 2 == 0){
            Console.WriteLine("El numero es par");
        }
        else{
            Console.WriteLine("El numero es impar");
        }

    }
}