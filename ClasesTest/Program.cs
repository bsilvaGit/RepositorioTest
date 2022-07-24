using System;

namespace ClasesTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conceptos de POO");
            Console.WriteLine("================\n");

            try
            {
                Console.WriteLine(new Date(2022, 12, 07));
                Console.WriteLine(new Date(1974, 09, 23));
                Console.WriteLine(new Date(1985, 11, 15));
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
