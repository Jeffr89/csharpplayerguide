
var bluesword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
var redbow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
var greenaxe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);
bluesword.Display();
redbow.Display();
greenaxe.Display();

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<T>
{
    ConsoleColor ConsoleColor { get; }
    T Item { get; }

    public ColoredItem(T item, ConsoleColor consoleColor)
    {
        Item = item;
        ConsoleColor = consoleColor;
    }
    public void Display()
    {
        Console.ForegroundColor = ConsoleColor;
        Console.WriteLine(Item.ToString());
    }

}