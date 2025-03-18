
int addInt = Adds.Add(3, 3);
Console.WriteLine(addInt);
double addDouble = Adds.Add((double)3.5, (double)3.5);
Console.WriteLine(addDouble);
string addString = Adds.Add("4", "4");
Console.WriteLine(addString);
DateTime addDateTime = Adds.Add(DateTime.Now, TimeSpan.FromDays(2));
Console.WriteLine(addDateTime);

public static class Adds
{
    public static dynamic Add(dynamic a, dynamic b) => a + b;

}


