List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
List<Card> cards = new List<Card>();

for (int i = 0; i < input.Count; i++)
{
    try
    {
        string[] currentCard = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string face = currentCard[0];
        string suit = currentCard[1];
        Card card = new Card(face, suit);
        card.CreateCard();
        cards.Add(card);
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

foreach (var card in cards)
{
    Console.Write(card.ToString());
}

public class Card
{
    private IReadOnlyCollection<string> faces = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    private IReadOnlyCollection<string> suits = new List<string>() { "S", "H", "D", "C" };

    public Card(string face, string suit)
    {
        Face = face;
        Suit = suit;
    }

    public string Face { get; }
    public string Suit { get; private set; }


    public void CreateCard()
    {
        if (faces.Contains(Face) && suits.Contains(Suit))
        {
            Card card = new Card(Face, Suit);
        }
        else
        {
            throw new ArgumentException("Invalid card!");
        }
    }

    public override string ToString()
    {
        switch (Suit)
        {
            case "S":
                Suit = "\u2660";
                break;
            case "H":
                Suit = "\u2665";
                break;
            case "D":
                Suit = "\u2666";
                break;
            case "C":
                Suit = "\u2663";
                break;
            default:
                return null;
        }

        return $"[{Face}{Suit}] ";
    }
}