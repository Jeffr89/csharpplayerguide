Console.WriteLine("Choose a word to randomly recreate!");
string input = Console.ReadLine();

DateTime start = DateTime.Now;
int result = await RandomlyRecreateAsync(input);
Console.WriteLine(DateTime.Now - start);
Console.WriteLine(result);



int RandomlyRecreate(string word)
{
    Random random = new Random();
    string randomWord = "";
    int countAttempt = 0;
    while (true)
    {
        countAttempt++;
        for (int i = 0; i < word.Length; i++)
        {
            char letter = (char)('a' + random.Next(26));
            randomWord += letter;
        }
        Console.WriteLine(randomWord);
        if (randomWord == word) break;
        randomWord = "";
    }
    return countAttempt;
}

Task<int> RandomlyRecreateAsync(string word)
{
    return Task.Run(() => RandomlyRecreate(word));
}