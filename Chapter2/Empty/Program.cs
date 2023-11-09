namespace Empty
{
    internal class Program
    {
        
        static char[] arr = {'0','1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choiceNum;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("플레이어 1 : X   플레이어 2 : O \n");

                if (player % 2 != 0)
                {
                    Console.WriteLine(" 플레이어 1 (X) 의 차례 - (원하는 자리의 숫자를 입력해주세요) \n");
                }
                else
                {
                    Console.WriteLine(" 플레이어 2 (O) 의 차례 - (원하는 자리의 숫자를 입력해주세요)\n");
                }
                Board();
                string number = Console.ReadLine();
                bool success = int.TryParse(number, out choiceNum);
                if (success)
                {
                    if (arr[choiceNum] != 'O' && arr[choiceNum] != 'X')
                    {
                        if (player % 2 != 0)
                        {
                            arr[choiceNum] = 'X';
                        }
                        else
                        {
                            arr[choiceNum] = 'O';
                        }
                        player++;
                    }
                    else 
                    {
                        Console.WriteLine("이미 선택된 자리입니다!!");
                        Console.WriteLine("Enter를 누르고 다시 입력해 주세요!!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다");
                    Console.WriteLine("Enter를 누르고 다시 입력해 주세요!!");
                    Console.ReadLine();
                }
                flag = CheckFinish();

            } while (flag == 0);

            if (flag == 1)
            {
                Console.WriteLine("플레이어 {0} 이 승리하였습니다.", player % 2 + 1);
            }
            else
            {
                Console.WriteLine("무승부");
            }


        }

        static void Board()
        {
            Console.WriteLine(" --- --- --- ");
            Console.WriteLine("| {0} | {1} | {2} |", arr[1], arr[2], arr[3]);
            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| {0} | {1} | {2} |", arr[4], arr[5], arr[6]);
            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| {0} | {1} | {2} |", arr[7], arr[8], arr[9]);
            Console.WriteLine(" --- --- --- ");
        }

        static int CheckFinish()
        {
            //가로 조건
            if ((arr[1] == arr[2] && arr[2] == arr[3]) ||
                (arr[4] == arr[5] && arr[5] == arr[6]) ||
                (arr[7] == arr[8] && arr[8] == arr[9]))
            {
                return 1;
            }
            //세로 조건
            else if ((arr[1] == arr[4] && arr[4] == arr[7]) ||
                     (arr[2] == arr[5] && arr[5] == arr[8]) ||
                     (arr[3] == arr[6] && arr[6] == arr[9]))
            {
                return 1;
            }
            //대각선 조건
            else if ((arr[1] == arr[5] && arr[5] == arr[9]) ||
                     (arr[3] == arr[5] && arr[5] == arr[7]))
            {
                return 1;
            }
            //무승부 조건
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' &&
                     arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
                return 0;
        } 
    }
}