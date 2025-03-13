
Console.WriteLine("Push a key to identify the repeat!");
RecentNumbers recentNumbers = new RecentNumbers();
Thread thread = new Thread(NumberGenerator);
thread.Start(recentNumbers);

while (true)
{
    ConsoleKeyInfo consoleKey = Console.ReadKey();
    if (recentNumbers.IsRepeat()) Console.WriteLine("Correct!");
    else Console.WriteLine("Wrong");

}

void NumberGenerator(object? obj)
{
    Random random = new Random();
    RecentNumbers recentNumbers = (RecentNumbers)obj;
    while (true)
    {
        int randomNumber = random.Next(10);
        Console.WriteLine(randomNumber);
        recentNumbers.NewNumber(randomNumber);
        Thread.Sleep(500);
    }
}
public class RecentNumbers
{
    private readonly object _numberLock = new object();

    private int _previous;
    private int _current;

    public RecentNumbers()
    {
        _previous = -1;
        _current = -2;
    }

    public void NewNumber(int num)
    {
        lock (_numberLock)
        {
            _previous = _current;
            _current = num;
        }
    }


    public bool IsRepeat() => _current == _previous;

}