namespace Overloading
{
    internal class Program
    {
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }

        static float AddNumbers(float a, float b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int sum1 = AddNumbers(10, 20);
            int sum2 = AddNumbers(20, 30, 40);
            float sum3 = AddNumbers(10.5f, 21.5f);
        }
    }
}