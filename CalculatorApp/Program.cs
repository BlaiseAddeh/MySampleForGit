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
            Console.ReadKey();
        }

        private static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
