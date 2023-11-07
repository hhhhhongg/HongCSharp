namespace question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("이름을 입력하세요: ");
            //string name = Console.ReadLine();
            //Console.Write("나이를 입력하세요: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"안녕하세요, {name}님!, 당신의 나이는 {age}세 이군요.");

            //Console.Write("첫번째 수를 입력하세요: ");
            //float num1 = float.Parse(Console.ReadLine());
            //Console.Write("두번째 수를 입력하세요: ");
            //float num2 = float.Parse(Console.ReadLine());
            //float sum = num1 + num2;
            //float sub = num1 - num2;
            //float mul = num1 * num2;
            //float div = num1 / num2;
            //Console.WriteLine($"더하기 : {sum}");
            //Console.WriteLine($"빼기 : {sub}");
            //Console.WriteLine($"곱하기 : {mul}");
            //Console.WriteLine($"나누기 : {div}");

            //Console.Write("섭씨 온도를 입력하세요: ");
            //float sub = float.Parse(Console.ReadLine());
            //float hwa = (sub * 9 / 5) + 32;
            //Console.WriteLine($"변환된 화씨 온도 : {hwa}");

            Console.Write("본인의 키(m)를 입력해주세요: ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("본인의 몸무게(kg)를 입력해주세요: ");
            float weight = float.Parse(Console.ReadLine());
            float bmi = weight/(height*height);
            Console.WriteLine($"본인의 bmi 지수는 {bmi} 입니다.");
        }
    }
}