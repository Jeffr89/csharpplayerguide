int[] lennikArray = new int[] { 1, 9, 2, 8, 3, 7, 4, 6, 5 };

Console.WriteLine(string.Join(", ", lennikArray));

Console.WriteLine(string.Join(", ", ProceduralQuery(lennikArray)));
Console.WriteLine(string.Join(", ", KeywordQuery(lennikArray)));
Console.WriteLine(string.Join(", ", MethodCallQuery(lennikArray)));

IEnumerable<int> ProceduralQuery(int[] numbers)
{
    int OddCount = 0;

    foreach (var number in numbers)
    {
        if (number % 2 == 0) OddCount++;
    }

    int[] newArray = new int[OddCount];

    int newArrayCount = 0;

    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            newArray[newArrayCount++] = number;

        }
    }

    Array.Sort(newArray);

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = newArray[i] * 2;
    }


    return newArray;

}

IEnumerable<int> KeywordQuery(int[] numbers)
{
    var queryResult = from n in numbers
                      where n % 2 == 0
                      orderby n
                      select n * 2;

    return queryResult;


}

IEnumerable<int> MethodCallQuery(int[] numbers)
{

    var queryResult = numbers
                            .Where(n => n % 2 == 0)
                            .OrderBy(n => n)
                            .Select(n => n * 2);

    return queryResult;
}

