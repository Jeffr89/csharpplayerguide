
Console.WriteLine("""
Chose your filter:
1 - Is Even
2 - Is Positive
3 - Is Multiple Of Ten
""");

string input = Console.ReadLine();

Sieve sieve = input switch
{
    "1" => new Sieve(IsEven),
    "2" => new Sieve(IsPositive),
    "3" => new Sieve(IsMultipleTen)
};

while (true)
{
    Console.WriteLine("Pick a number!");
    input = Console.ReadLine();
    Console.WriteLine(sieve.IsGood(int.Parse(input)));
}


bool IsEven(int number)
{
    return number % 2 == 0;
}

bool IsPositive(int number)
{
    return number >= 0;
}

bool IsMultipleTen(int number)
{
    return number % 10 == 0;
}


public class Sieve
{
    public Func<int, bool> Func { get; }

    public Sieve(Func<int, bool> func)
    {
        Func = func;
    }
    public bool IsGood(int number)
    {
        return Func(number);
    }
}