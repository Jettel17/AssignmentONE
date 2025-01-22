using System;
using System.Collection.Generic;

public class playingCard
{
    public string Suit { get; set; }
    public string Value { get; set; }

    public playingCard() : this("Joker", "Joker")
    {
    }

    public playingCard(string suit, string value)
    {
        Suit = suit;
        Value = value;
    }

    public void printCard()
    {
        Console.WriteLine($"{Value} of {Suit}")
    }
}


public class deck
{
    public List<playingCard> cards;
    public deck()
    {
        cards = new List<playingCard>();
        startDeck();
    }
    public void startDeck()
    {
        string suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string values = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

        foreach (var suit in suits)
        {
            foreach (var value in values)
            {
                cards.Add(new playingCard(suit, value));
            }
        }

        cards.Add(new playingCard());
    }

    public playingCard Draw()
    {
        if (cards.Count == 0)
        {
            throw new emptyDeck("No cards left")
        }

        var topCard = cards[0];
        cards.RemoveAt(0);
        return topCard;
    }
}

class prog
{
    static void Main(string[] args)
    {
        deck deck = new deck();

        for (int i = 0; i < 53; i++)
        {
            playingCard card = deck.Draw();
            card.printCard();
        }
    }
}

