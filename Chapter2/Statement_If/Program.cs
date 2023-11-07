﻿namespace Statement_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 80;

            if (playerScore >= 70)
            {
                Console.WriteLine("플레이어의 점수는 70점 이상입니다. 합격입니다!");
            }
            else if (playerScore == 100)
            {
                Console.WriteLine("플레이어의 점수는 만점입니다!!");
            }
            else
            Console.WriteLine("프로그램이 종료됩니다.");

            


            int itemCount = 0;
            string itemName = "HP 포션";

            if (itemCount > 0)
            {
                Console.WriteLine($"보유한 {itemName}의 수량 : {itemCount}");
            }
            else
            {
                Console.WriteLine($"보유한 {itemName}이 없습니다.");
            }


            int score = 100;
            string playerRank = "";

            if (score >= 90)
            {
                playerRank = "Diamond";
            }
            else if (score >= 80)
            {
                playerRank = "Platinum";
            }
            else if (score >= 70)
            {
                playerRank = "Gold";
            }
            else
            {
                playerRank = "Silver";
            }

            Console.WriteLine($"플레이어의 등급은 {playerRank} 입니다");


            Console.WriteLine("게임을 시작합니다.");
            Console.WriteLine("1: 전사 / 2: 마법사 / 3: 궁수");
            Console.Write("직업을 선택하세요: ");
            string job = Console.ReadLine();

            switch (job)
            {
                case "1":
                    Console.WriteLine("전사를 선택하셨습니다");
                    break;
                case "2": 
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    break;
                case "3": 
                    Console.WriteLine("궁수를 선택하셨습니다.");
                    break;
                default:
                    Console.WriteLine("올바른 값을 입력해주세요.");
                    break;


            }

            Console.WriteLine("게임을 종료합니다.");

            int currentExp = 1200;
            int requiredExp = 2000;

            string result = (currentExp >= requiredExp) ? "레벨업 가능" : "레벨업 불가능";
            Console.WriteLine(result);

            if (currentExp >= requiredExp)
            {
                Console.WriteLine("레벨업 가능");
            }
            else
            {
                Console.WriteLine("레벨업 불가능");
            }
        }
    }
}