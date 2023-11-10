using System;
using System.Collections.Generic;

public enum Suit { Hearts, Diamonds, Clubs, Spades }
public enum Rank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }

// 카드 한 장을 표현하는 클래스
public class Card
{
    public Suit Suit { get; private set; }
    public Rank Rank { get; private set; }

    public Card(Suit s, Rank r)
    {
        Suit = s;
        Rank = r;
    }

    public int GetValue()
    {
        if ((int)Rank <= 10)
        {
            return (int)Rank;
        }
        else if ((int)Rank <= 13)
        {
            return 10;
        }
        else
        {
            return 11;
        }
    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}

// 덱을 표현하는 클래스
public class Deck
{
    private List<Card> cards;

    public Deck()
    {
        cards = new List<Card>();

        foreach (Suit s in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(s, r));
            }
        }

        Shuffle();
    }

    public void Shuffle()
    {
        Random rand = new Random();

        for (int i = 0; i < cards.Count; i++)
        {
            int j = rand.Next(i, cards.Count);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    public Card DrawCard()
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}

// 패를 표현하는 클래스
public class Hand
{
    private List<Card> cards;

    public Hand()
    {
        cards = new List<Card>();
    }

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public int GetTotalValue()
    {
        int total = 0;
        int aceCount = 0;

        foreach (Card card in cards)
        {
            if (card.Rank == Rank.Ace)
            {
                aceCount++;
            }
            total += card.GetValue();
        }

        while (total > 21 && aceCount > 0)
        {
            total -= 10;
            aceCount--;
        }

        return total;
    }
}

// 플레이어를 표현하는 클래스
public class Player
{
    public Hand Hand { get; private set; }

    public Player()
    {
        Hand = new Hand();
    }

    public Card DrawCardFromDeck(Deck deck)
    {
        Card choice = deck.DrawCard();
        Hand.AddCard(choice);
        return choice;
    }
}

// 여기부터는 학습자가 작성
// 딜러 클래스를 작성하고, 딜러의 행동 로직을 구현하세요.
public class Dealer : Player
{
    // 코드를 여기에 작성하세요
    // 딜러는 총점이 17점 미만일 때 계속해서 카드를 뽑는다
    public void KeepDrawingCard(Deck deck)
    {
        while (Hand.GetTotalValue() < 17)
        {
            Card choice = DrawCardFromDeck(deck);
            Console.WriteLine($"딜러가 뽑은 카드는 {choice}입니다.");
            Console.WriteLine($"딜러가 뽑은 카드의 총합은 {Hand.GetTotalValue()} 입니다.");
        }
    }
}

// 블랙잭 게임을 구현하세요. 
public class Blackjack
{
    // 코드를 여기에 작성하세요
    private Player player;
    private Dealer dealer;
    private Deck deck;

    public void PlayGame()
    {
        player = new Player();
        dealer = new Dealer();
        deck = new Deck();

        player.DrawCardFromDeck(deck);
        player.DrawCardFromDeck(deck);

        dealer.DrawCardFromDeck(deck);
        dealer.DrawCardFromDeck(deck);

        Console.WriteLine(" ------------------------------------- ");
        Console.WriteLine("|                                     |");
        Console.WriteLine("|    ★블랙잭 게임을 시작합니다★     |");
        Console.WriteLine("|                                     |");
        Console.WriteLine(" ------------------------------------- ");
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("플레이어와 딜러는 카드 두장씩 받았습니다. ");
        Console.WriteLine();
        Console.WriteLine($"플레이어가 가지고 있는 현재 두장의 카드의 합 : {player.Hand.GetTotalValue()}");
        Console.WriteLine($"딜러가 가지고 있는 현재 두장의 카드의 합 : {dealer.Hand.GetTotalValue()}");

        //플레이어 턴 ( 21 점이 넘지 않는다면 카드를 계속 뽑을 수 있음)

        while (player.Hand.GetTotalValue() < 21)
        {
            Console.Write("카드를 더 뽑으시겠습니까? (y/n): ");
            string input = Console.ReadLine();

            if(input.ToLower() == "y")
            {
                Card choice = player.DrawCardFromDeck(deck);
                Console.WriteLine($"플레이어가 뽑은 카드는 {choice} 입니다" );
                Console.WriteLine($"플레이어의 카드 총합은 {player.Hand.GetTotalValue()} 입니다");
            }
            else
            {
                Console.WriteLine("플레이어의 턴을 종료합니다");
                break;
            }
            
        }

        //딜러 턴
        Console.WriteLine("딜러의 턴입니다.");
        dealer.KeepDrawingCard(deck);

        if (player.Hand.GetTotalValue() > 21)
        {
            Console.WriteLine("플레이어의 카드 합이 21점을 초과했습니다. 딜러의 승리입니다.");
        }
        else if (dealer.Hand.GetTotalValue() > 21)
        {
            Console.WriteLine("딜러의 카드 합이 21점을 초과했습니다. 플레이어의 승리입니다.");
        }
        else if (player.Hand.GetTotalValue() > dealer.Hand.GetTotalValue())
        {
            Console.WriteLine("플레이어의 카드 합이 더 높습니다. 플레이어의 승리입니다.");
        }
        else
        {
            Console.WriteLine("딜러의 카드 합이 더 높거나 같습니다. 딜러의 승리입니다.");
        }





    }
   
}

class Program
{
    static void Main(string[] args)
    {
        Blackjack blackjack = new Blackjack();
        blackjack.PlayGame();
    }
}