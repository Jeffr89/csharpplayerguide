while (true)
{
    Console.WriteLine("Choose a word to randomly recreate!");
    string input = Console.ReadLine();
    ConcurrentWord(input);

}

async Task ConcurrentWord(string word)
{
    DateTime start = DateTime.Now;
    int attempts = await RandomlyRecreateAsync(word);
    Console.WriteLine($"{word} took {attempts} attempts.");
    Console.WriteLine(DateTime.Now - start);
}

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
        if (randomWord == word) break;
        randomWord = "";
    }
    return countAttempt;
}

Task<int> RandomlyRecreateAsync(string word)
{
    return Task.Run(() => RandomlyRecreate(word));
}