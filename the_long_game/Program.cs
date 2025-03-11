using System.Formats.Asn1;

int score = 0;
ConsoleKey key = ConsoleKey.None;
Console.WriteLine("What is your name adventurer?");
string extension = ".txt";

string username = Console.ReadLine();

if (File.Exists(username + extension))
{
    score = int.Parse(File.ReadAllText(username + extension));
}
while (true)
{
    Console.Clear();
    Console.WriteLine("The key spam begins!");
    Console.WriteLine($"Score: {score}");
    key = Console.ReadKey().Key;
    if (key == ConsoleKey.Enter) break;
    score++;
}

File.WriteAllText(username + extension, score.ToString());

// FileStream fileStream = File.Open(username, FileMode.Create);
// StreamWriter stream = new StreamWriter(fileStream);
// stream.WriteLine(score);
// stream.Close();
