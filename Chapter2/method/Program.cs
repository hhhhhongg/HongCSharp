using System.Security.Cryptography.X509Certificates;
using System;
using System.Globalization;

namespace method
{
    internal class Program
    {
        

        static void PrintLine()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        static void PrintLine2(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            PrintLine();
            PrintLine2(30);

            int result = Add(10, 20);
            Console.WriteLine(result);
        }
    }
}