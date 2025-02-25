

Pack pack = new Pack(300, 10, 10);
while (true)
{
    Console.Clear();

    Console.WriteLine($"Your pack has {pack.CurrentCount}/{pack.MaxItemNumber} item, {pack.CurrentWeight}/{pack.MaxWeight} weight, {pack.CurrentVolume}/{pack.MaxVolume} volume");

    Console.WriteLine("""
Create a new pack! Select which item wanna add:
1 - Arrow
2 - Bow
3 - Rope
4 - Water
5 - Food
6 - Sword

""");

    int input = int.Parse(Console.ReadLine());


    InventoryItem inventoryItem = input switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword(),
    };

    if (pack.Add(inventoryItem) == false)
    {
        Console.WriteLine("Your pack is full");
        break;
    }


}
public class InventoryItem
{
    public double Weight { get; }
    public double Volume { get; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }

}

public class Arrow : InventoryItem { public Arrow() : base(0.1, 0.05) { } }

public class Bow : InventoryItem { public Bow() : base(1, 4) { } }

public class Rope : InventoryItem { public Rope() : base(1, 1.5) { } }

public class Water : InventoryItem { public Water() : base(2, 3) { } }
public class Food : InventoryItem { public Food() : base(1, 0.5f) { } }
public class Sword : InventoryItem { public Sword() : base(5, 3) { } }
public class Pack
{
    public InventoryItem[] inventoryItems { get; }
    public double MaxWeight { get; }
    public double MaxVolume { get; }
    public int MaxItemNumber { get; }
    public int CurrentCount { get; private set; }
    public double CurrentVolume { get; private set; }
    public double CurrentWeight { get; private set; }





    public Pack(int maxInventoryItem, double maxWeight, double maxVolume)
    {
        MaxItemNumber = maxInventoryItem;
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;
        inventoryItems = new InventoryItem[MaxItemNumber];

    }
    // // can be converted to a property
    // public int CurrentCount()
    // {
    //     int currentItemNumber = 0;
    //     foreach (InventoryItem item in inventoryItems)
    //     {
    //         if (item != null) currentItemNumber++;
    //     }
    //     return currentItemNumber;
    // }
    // // Can be converted to a property
    // public double CurrentWeight()
    // {
    //     double currentWeight = 0;
    //     foreach (InventoryItem item in inventoryItems)
    //     {
    //         if (item != null) currentWeight += item.Weight;
    //     }
    //     return currentWeight;
    // }
    // // Can be converted to a property
    // public double CurrentVolume()
    // {
    //     double currentVolume = 0;
    //     foreach (InventoryItem item in inventoryItems)
    //     {
    //         if (item != null) currentVolume += item.Volume;
    //     }
    //     return currentVolume;

    // }



    public bool Add(InventoryItem item)
    {
        if (CurrentCount == MaxItemNumber) return false;
        if ((CurrentVolume + item.Volume) > MaxVolume) return false;
        if ((CurrentWeight + item.Weight) > MaxWeight) return false;

        inventoryItems[CurrentCount] = item;
        CurrentCount++;
        CurrentVolume += item.Volume;
        CurrentWeight += item.Weight;
        return true;


    }

}