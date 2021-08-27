using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("-----------Creation de la fonction Addition");
            int result = Addition(3, 5);
            Console.WriteLine($"L'addition de 3 et 5 égale à : {result}");
            decimal result2 = Addition(2.3m, 6.7m);
            Console.WriteLine($"L'addition de 2.3 et 6.7 égale à : {result2}");
            Console.ReadKey();
        }

        private static int Addition(int a, int b)
        {
            return a + b;
        }

        private static decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

    }
}
