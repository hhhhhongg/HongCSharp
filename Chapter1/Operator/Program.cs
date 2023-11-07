namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("산술 연산자");
            int num1 = 20, num2 = 10;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 % num2);

            Console.WriteLine();


            Console.WriteLine("관계연산자");
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 >= num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine();


            Console.WriteLine("논리연산자");

            int num3 = 15;
            // 0 <= num3 <= 20
            Console.WriteLine(0 <= num3 && num3 <= 20);
            Console.WriteLine(0 > num3 || num3 < 20); // 0 ~ 20 사이에 포함되지 않으면





            Console.WriteLine();

        }
    }
}