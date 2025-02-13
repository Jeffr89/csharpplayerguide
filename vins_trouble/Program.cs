

Arrow arrow = getArrow();

Console.WriteLine($"The arrow costs: {arrow.GetCost()}");




Arrow getArrow()
{
    ArrowheadType arrowheadType = GetArrowheadType();
    FletchingType fletchingType = GetFletchingType();
    float length = getLenght();

    return new Arrow(arrowheadType, fletchingType, length);
}

ArrowheadType GetArrowheadType()
{
    Console.WriteLine("Pick your arrowhead (steel/wood/obsidian):");
    string inputArrowhead = Console.ReadLine();
    Enum.TryParse(inputArrowhead, ignoreCase: true, out ArrowheadType arrowheadType);
    return arrowheadType;
}

FletchingType GetFletchingType()
{
    Console.WriteLine("Pick your fletching (plastic/turkey/goose):");
    string inputFletching = Console.ReadLine();
    Enum.TryParse(inputFletching, ignoreCase: true, out FletchingType fletchingType);
    return fletchingType;

}

float getLenght()
{
    float length = 0;
    while (length < 60 || length > 100)
    {
        Console.WriteLine("Choose the length between 60 and 100; ");
        length = float.Parse(Console.ReadLine());
    }
    return length;

}


class Arrow
{
    private ArrowheadType _arrowheadType;
    private FletchingType _fletchingType;
    private float _length;

    public Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float length)
    {
        _arrowheadType = arrowheadType;
        _fletchingType = fletchingType;
        _length = length;
    }

    public float GetCost()
    {
        return (int)_arrowheadType + (int)_fletchingType + _length * 0.05f;

    }

    public ArrowheadType GetArrowheadType() => _arrowheadType;

    public FletchingType GetFletchingType() => _fletchingType;
    public float GetLength() => _length;

}


enum ArrowheadType
{
    Steel = 10,
    Wood = 3,
    Obsidian = 5
}

enum FletchingType
{
    Plastic = 10,
    TurkeyFeather = 5,
    GooseFeather = 3
}

