namespace Recursive
{
    internal class Program
    {
        static void CountDown(int n)
        {
            if(n <= 0)
            {
                Console.WriteLine("Done");
                
            }
            else
            {
                Console.WriteLine(n);
                CountDown(n - 1);
            }
        }

        static void Main(string[] args)
        {
            CountDown(5);
        }
    }
}