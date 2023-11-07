namespace Statement_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int j = 0;
            //for (j = 0; j < 10; j++)
            //{
            //    Console.WriteLine(j);
            //}

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int count = 0;
            //while (count < 10)
            //{
            //    Console.WriteLine("적을 처치했습니다! 남은 적 수: " + (10 - count - 1));
            //    count++;
            //}
            //Console.WriteLine("축하합니다 게임에서 승리하셨습니다!");

            //int sum = 0;
            //int num;

            //do
            //{
            //    Console.Write("숫자를 입력하세요 (0 입력시 종료합니다): ");
            //    num = int.Parse(Console.ReadLine());
            //    sum += num;
            //} while (num != 0);

            //Console.WriteLine($"합계 : {sum}");

            // 구구단 출력
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.Write($"{j} x {i} = {i*j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);

            //    if (i == 7)
            //    {
            //        break;
            //    }
            //}

            int sum = 0;

            while (true) // 무한 루프, for(;;) <- 이것도 무한루프
            {
                Console.Write("숫자를 입력하세요: ");
                int input = int.Parse(Console.ReadLine());

                if(input == 0)
                {
                    Console.WriteLine("프로그램 종료"); ;
                    break;
                }

                if(input < 0)
                {
                    Console.WriteLine("음수는 무시");
                    continue;
                }

                sum += input;
                Console.WriteLine(sum);

            }

            Console.WriteLine($"합계: {sum}");
        }
    }
}