
Console.WriteLine("""
Chose your filter:
1 - Is Even
2 - Is Positive
3 - Is Multiple Of Ten
""");

string input = Console.ReadLine();

Sieve sieve = input switch
{
    "1" => new Sieve(n => n % 2 == 0),
    "2" => new Sieve(n => n >= 0),
    "3" => new Sieve(n => n % 10 == 0)
};

while (true)
{
    Console.WriteLine("Pick a number!");
    input = Console.ReadLine();
    Console.WriteLine(sieve.IsGood(int.Parse(input)));
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