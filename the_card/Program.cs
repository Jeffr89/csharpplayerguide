
Color[] colors = [Color.Blue, Color.Green, Color.Red, Color.Yellow];
Rank[] ranks =
        {
            Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven,
            Rank.Eight, Rank.Nine, Rank.Ten, Rank.Dollar, Rank.DollarSign,
            Rank.Percent, Rank.Caret, Rank.Ampersand
        };

CreateDeck(colors, ranks);


void CreateDeck(Color[] colors, Rank[] ranks)
{
    foreach (Color color in colors)
    {
        foreach (Rank rank in ranks)

        {
            Card card = new Card(color, rank);
            Console.WriteLine($"The {card.Color} {card.Rank}");
            Console.WriteLine(card.IsNumber);
        }

    }
}
class Card
{
    public Color Color { get; }
    public Rank Rank { get; }

    public Card(Color color, Rank rank)
    {
        Color = color;
        Rank = rank;

    }

    // public bool IsNumber()
    // {
    //     return (int)Rank <= 10 ? true : false;
    // }

    // public bool IsSymbol()
    // {
    //     return (int)Rank > 10 ? true : false;
    // }

    public bool IsNumber => (int)Rank < 10 ? true : false;
    public bool IsSymbol => !IsSymbol;

}

enum Color
{
    Red,
    Green,
    Blue,
    Yellow

}

enum Rank
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    DollarSign,
    Percent,
    Caret,
    Ampersand,

}