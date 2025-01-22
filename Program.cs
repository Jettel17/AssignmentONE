using System;

public class PlayingCard
{
    public string suit;
    public string value;

    public PlayingCard() : this("Joker", "Joker")
    {
    }

    public PlayingCard(string suit, string value)
    {
        this.suit = suit;
        this.value = value;
    }

    public void printCard()
    {
        Console.WriteLine($"{value} of {suit}");
    }
}


public class Deck
{
    public List<PlayingCard> cards;
    public Deck()
    {
        cards = new List<PlayingCard>();
        startDeck();
    }
    public void startDeck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] values = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

        foreach (var suit in suits)
        {
            foreach (var value in values)
            {
                cards.Add(new PlayingCard(suit, value));
            }
        }

        cards.Add(new PlayingCard());
    }

    public PlayingCard Draw()
    {

        var topCard = cards[0];
        cards.RemoveAt(0);
        return topCard;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var deck = new Deck();

        for (int i = 0; i < 53; i++)
        {
            PlayingCard card = deck.Draw();
            card.printCard();
        }
    }
}

