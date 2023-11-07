using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    internal class calculator
    {
        static void main(string[] args)
        {
            Console.Write("첫번째 수를 입력하세요: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 수를 입력하세요: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;
        }
    }
}
