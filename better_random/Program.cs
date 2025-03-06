Random newran = new Random();
Console.WriteLine(newran.NextDouble(32));
Console.WriteLine(newran.NextString("pippo", "pluto", "paperino"));
Console.WriteLine(newran.CoinFlip(0));
public static class RandomExtension
{
    public static double NextDouble(this Random random, int max)
    {

        return random.NextDouble() * max;

    }

    public static string NextString(this Random random, params string[] strings)
    {
        return strings[random.Next(0, strings.Length)];
    }

    public static bool CoinFlip(this Random random, float headFrequency = 0.5f)
    {
        return random.NextSingle() < headFrequency;
    }

}


