namespace ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 드래그한 부분을 전체 주석처리 하고싶을때
            // Ctrl K + C(주석처리), K + U(주석 해제)
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi Hello, {0}!", name);

            Console.Write("Enter tow numbers: ");
            string input = Console.ReadLine(); // "10 20" 과 같은 문자열을 입력받음

            string[] numbers = input.Split(' '); // 문자열을 공백으로 구분하여 배열로 받음
            // { "10" , "20" }
            int num1 = int.Parse(numbers[0]); // 첫 번째 값을 정수로 변환하여 저장
            int num2 = int.Parse(numbers[1]); // 두 번째 값을 정수로 변환하여 저장

            int sum = num1 + num2;

            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
        }
    }
}