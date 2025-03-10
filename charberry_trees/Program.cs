CharberryTree tree = new CharberryTree();
CharberryTreeNotifier charberryTreeNotifier = new CharberryTreeNotifier(tree);
CharberryTreeHarvester charberryTreeHarvester = new CharberryTreeHarvester(tree);

while (true)
    tree.MaybeGrow();


public class CharberryTree
{
    private Random _random = new Random();
    public bool Ripe { get; set; }

    public event Action? Ripened;
    public void MaybeGrow()
    {
        // Only a tiny chance of ripening each time, but we try a lot!
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
            Ripened?.Invoke();
        }
    }
}

public class CharberryTreeNotifier
{

    public CharberryTree Tree { get; }

    public CharberryTreeNotifier(CharberryTree tree)
    {
        Tree = tree;
        Tree.Ripened += HandleRipeNotification;

    }

    public void HandleRipeNotification()
    {
        Console.WriteLine("A charberry fruit has ripened!");
    }

}


public class CharberryTreeHarvester
{
    public CharberryTree Tree { get; }


    public CharberryTreeHarvester(CharberryTree tree)
    {
        Tree = tree;
        Tree.Ripened += HandleRipeNotification;
    }

    public void HandleRipeNotification()
    {
        Tree.Ripe = false;
    }
}