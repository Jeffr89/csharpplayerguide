namespace Dueling_traditions
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Pack pack = new Pack(300, 10, 10);
            while (true)
            {
                Console.Clear();

                Console.WriteLine(
                    $"Your pack has {pack.CurrentCount}/{pack.MaxItemNumber} item, {pack.CurrentWeight}/{pack.MaxWeight} weight, {pack.CurrentVolume}/{pack.MaxVolume} volume");

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
        }
    }
}