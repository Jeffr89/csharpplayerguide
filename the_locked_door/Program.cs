Console.WriteLine("Choose a passcode for your door: ");
string inputPasscode = Console.ReadLine();
Door door = new Door(inputPasscode);

Console.Clear();

while (true)
{
    Console.WriteLine($"The door is: {door.DoorStatus}");
    Console.WriteLine(""""
What would you like to do? 
1 - Open the door
2 - Close the door
3 - Lock the door 
4 - Unlock the door
5 - Change passcode
"""");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            door.Open();
            break;

        case "2":
            door.Close();
            break;
        case "3":
            door.Lock();
            break;
        case "4":
            door.Unlock();
            break;
        case "5":
            door.ChangePasscode();
            break;
        default:
            break;
    }

}




class Door
{
    public DoorLock DoorStatus { get; private set; }
    private string _passcode;

    public Door(string passcode)
    {
        _passcode = passcode;
    }

    public void ChangePasscode()
    {
        Console.Clear();
        Console.WriteLine("Insert the current passcode");
        string currentPasscode = Console.ReadLine();
        Console.WriteLine("Insert the new passcode");
        string newPasscode = Console.ReadLine();


        if (currentPasscode == _passcode)
        {
            _passcode = newPasscode;
        }
        else
        {
            Console.WriteLine("Wrong passcode");
        }
    }

    public void Open()
    {

        if (DoorStatus == DoorLock.Closed)
        {
            Console.Clear();
            DoorStatus = DoorLock.Opened;
            Console.WriteLine("Door Opened");
        }
        else
        {
            Console.WriteLine("Cannot Open");
        }
    }

    public void Close()
    {

        if (DoorStatus == DoorLock.Opened)
        {
            Console.Clear();
            DoorStatus = DoorLock.Closed;
            Console.WriteLine("Door Closed");
        }
        else
        {
            Console.WriteLine("Cannot Close");
        }
    }

    public void Lock()
    {
        if (DoorStatus == DoorLock.Closed)
        {
            Console.Clear();
            DoorStatus = DoorLock.Locked;
            Console.WriteLine("Door Locked");
        }
        else
        {
            Console.WriteLine("Cannot Lock");
        }
    }

    public void Unlock()
    {

        if (DoorStatus == DoorLock.Locked)
        {
            Console.Clear();
            Console.WriteLine("Insert the current passcode");
            string currentPasscode = Console.ReadLine();
            if (_passcode == currentPasscode)
            {
                DoorStatus = DoorLock.Closed;
                Console.WriteLine("Door Unlocked");
            }
            else
            {
                Console.WriteLine("Wrong passcode");
            }
        }
        else
        {
            Console.WriteLine("Cannot Unlock");
        }
    }
}
enum DoorLock
{
    Opened,
    Closed,
    Locked,

}