namespace Dueling_traditions;
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