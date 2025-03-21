public static class UIFinalBattleGame
{
    private const string Header = "BATTLE";
    private const string Vs = "VS";
    private const char Separator1 = '=';
    private const char Separator2 = '-';

    public static void DisplayBattle(TheFinalBattleGameSingleBattle battle)
    {
        int width = Console.WindowWidth;
        string separatorLine = new string(Separator1, width);
        string vsLine = new string(Separator2, width);


        Console.WriteLine(CenterText(Header, width, Separator1));


        foreach (var member in battle.Heroes.Members)
        {
            if (battle.currentCharacter == member) Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{member.Name} ( {member.CurrentHP}/{member.MaxHP} )");
            Console.ForegroundColor = ConsoleColor.White;
        }


        Console.WriteLine(CenterText(Vs, width, Separator2));


        foreach (var member in battle.Monsters.Members)
        {
            if (battle.currentCharacter == member) Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{member.Name} ( {member.CurrentHP}/{member.MaxHP} )".PadLeft(width));
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine(CenterText(separatorLine, width));
    }

    private static string CenterText(string text, int width, char filler = ' ')
    {
        int padding = (width - text.Length) / 2;
        return new string(filler, padding) + text + new string(filler, padding + (width - text.Length) % 2);
    }
}