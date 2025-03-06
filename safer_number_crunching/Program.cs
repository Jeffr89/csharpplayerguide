string input;
do
{
    Console.WriteLine("Enter number: ");
    input = Console.ReadLine();
    
}while(!int.TryParse(input, out int number));


do
{
    Console.WriteLine("Enter double: ");
    
}while(!double.TryParse(Console.ReadLine(), out double number2));

do
{
    Console.WriteLine("Enter boolean: ");
} while (!bool.TryParse(Console.ReadLine(), out bool boolean));