using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ------------------------------------- ");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|    ★블랙잭 게임을 시작합니다★     |");
        Console.WriteLine("|                                     |");
        Console.WriteLine(" ------------------------------------- ");

    }

        
}

class Card
{
    public string Suit { get; set; }
    public string Rank { get; set; }
    public int Value { get; set; }

    public Card(string suit, string rank, int value)
    {
        Suit = suit;
        Rank = rank;
        Value = value;
    }
}

class Deck
{
    private List<Card> cards = new List<Card>();

    public Deck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                int value = 0;
                if (rank == "Jack" || rank == "Queen" || rank == "King")
                {
                    value = 10;
                }
                else if (rank == "Ace")
                {
                    value = 11;
                }
                else
                {
                    value = int.Parse(rank);
                }

                cards.Add(new Card(suit, rank, value));
            }
        }
    }

    public void Shuffle()
    {
        Random random = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }

    public Card DrawCard()
    {
        Card drawnCard = cards[0];
        cards.RemoveAt(0);
        return drawnCard;
    }
}

class Hand
{
    protected List<Card> cards = new List<Card>();

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public string GetHand()
    {
        string handString = "";
        foreach (var card in cards)
        {
            handString += $"{card.Rank} of {card.Suit}, ";
        }
        return handString.TrimEnd(',', ' ');
    }

    public int GetScore()
    {
        int score = 0;
        int numberOfAces = 0;

        foreach (var card in cards)
        {
            score += card.Value;

            if (card.Rank == "Ace")
            {
                numberOfAces++;
            }
        }

        // Ace를 11로 계산했을 때 21을 넘는 경우, Ace를 1로 계산
        while (numberOfAces > 0 && score > 21)
        {
            score -= 10;
            numberOfAces--;
        }

        return score;
    }
}

class Player : Hand
{
}

class Dealer : Hand
{
    // 딜러의 첫 번째 카드를 가려두기 위한 오버라이드
    public new string GetHand()
    {
        return $"{cards[0].Rank} of {cards[0].Suit}, Hidden";
    }
}
