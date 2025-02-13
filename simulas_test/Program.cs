ChestState strangeChest;
strangeChest = ChestState.Locked;

while (true)
{
    Console.Write($"The chest is {strangeChest}. What do you want to do?");
    string input = Console.ReadLine();
    switch (input)
    {
        case "lock":
            if (strangeChest == ChestState.Closed) strangeChest = ChestState.Locked;
            break;
        case "unlock":
            if (strangeChest == ChestState.Locked) strangeChest = ChestState.Closed;
            break;
        case "open":
            if (strangeChest == ChestState.Closed) strangeChest = ChestState.Open;
            break;
        case "close":
            if (strangeChest == ChestState.Open) strangeChest = ChestState.Closed;
            break;
        default:
            Console.WriteLine("Wrong action");
            break;
    }
}




enum ChestState
{
    Open,
    Closed,
    Locked
}

