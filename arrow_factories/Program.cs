
Arrow arrow = null;


while (arrow == null)
{
    Console.WriteLine("What kind of arrow would you like?");
    Console.WriteLine("1 - Elite Arrow");
    Console.WriteLine("2 - Beginner Arrow");
    Console.WriteLine("3 - Marksman Arrow");
    Console.WriteLine("0 - Customize your arrow!");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            arrow = Arrow.CreateEliteArrow();

            break;
        case "2":
            arrow = Arrow.CreateBeginnerArrow();

            break;
        case "3":
            arrow = Arrow.CreateMarksmanArrow();

            break;
        case "0":
            arrow = getArrow();

            break;
        default:
            Console.WriteLine("Wrong option!");
            break;
    }
}

Console.WriteLine($"The arrow costs: {arrow.Cost}");




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
    public ArrowheadType ArrowheadType { get; }
    public FletchingType FletchingType { get; }
    public float Length { get; }


    public Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float length)
    {
        ArrowheadType = arrowheadType;
        FletchingType = fletchingType;
        Length = length;
    }
    public float Cost
    {

        get
        {
            return (int)ArrowheadType + (int)FletchingType + Length * 0.05f;
        }

    }
    public static Arrow CreateEliteArrow() => new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowheadType.Wood, FletchingType.Goose, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowheadType.Steel, FletchingType.Goose, 65);
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
    Turkey = 5,
    Goose = 3
}

