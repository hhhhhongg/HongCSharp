namespace OutRef
{
    internal class Program
    {

        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int quitient, remainder;
            Divide(7,3,out quitient,out remainder);
            Console.WriteLine($"{quitient},{remainder}");

            int x = 1, y = 2;
            Swap(ref x, ref y);
            Console.WriteLine($"{x}, {y}");
        }
    }
}