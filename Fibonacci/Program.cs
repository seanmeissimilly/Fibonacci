using System;

namespace Fibonacci
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine(FibonacciI(4));
            Console.WriteLine(FibonacciR(4));
        }

        //Recursivo
       private static long FibonacciR(long n)
        {
            if (n <= 2) return 1;
            return FibonacciR(n - 1) + FibonacciR(n - 2);
        }

        //Iterativo
        private static long FibonacciI(long n)
        {
            if (n <= 2) return 1;

            long penultimo, result = 0;
            var ultimo = penultimo = 1;

            for (var i = 2; i < n; i++)
            {
                result = penultimo + ultimo;
                penultimo = ultimo;
                ultimo = result;
            }
            return result;
        }
    }
}
