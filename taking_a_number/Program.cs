int AskForNumber(string text)
{
    Console.WriteLine(text);
    string input = Console.ReadLine();
    return int.Parse(input);
}


int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.WriteLine(text);
        string input = Console.ReadLine();
        int number = int.Parse(input);
        if (number < max && number > min) return number;

    }
}

int result = AskForNumberInRange("What is the airspeed velocityof an unladen swallow?", 5, 10);
