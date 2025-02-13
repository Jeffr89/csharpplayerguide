
(FoodVariation, MainIngredient, Seasoning) soup;



soup = (getFoodVariation(), getMainIngredient(), getSeasoning());
Console.WriteLine($"{soup.Item3} {soup.Item2} {soup.Item1}");

FoodVariation getFoodVariation()
{
    while (true)
    {
        Console.WriteLine("Select the type soup variation you'd like: (Soup/Stew/Gumbo)");
        string inputFoodVariation = Console.ReadLine();
        if (!Enum.TryParse(inputFoodVariation, ignoreCase: true, out FoodVariation foodVariation))
        {
            Console.WriteLine("Wrong option selected!");
            continue;
        }
        return foodVariation;
    }
}

MainIngredient getMainIngredient()
{
    while (true)
    {
        Console.WriteLine("Select the main ingredient you'd like: (Mushrooms/Chicken/Carrots/Potatoes)");
        string inputMainIngredient = Console.ReadLine();
        if (!Enum.TryParse(inputMainIngredient, ignoreCase: true, out MainIngredient mainIngredient))
        {
            Console.WriteLine("Wrong option selected!");
            continue;
        }
        return mainIngredient;
    }
}

Seasoning getSeasoning()
{
    while (true)
    {
        Console.WriteLine("Select the seasoning you'd like: (Spicy/Salty/Sweet)");
        string inputSeasoning = Console.ReadLine();
        if (!Enum.TryParse(inputSeasoning, ignoreCase: true, out Seasoning seasoning))
        {
            Console.WriteLine("Wrong option selected!");
            continue;
        }
        return seasoning;
    }
}
enum FoodVariation
{
    Unknown,
    Soup,
    Stew,
    Gumbo
}

enum MainIngredient
{
    Unknown,
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum Seasoning
{
    Unknown,
    Spicy,
    Salty,
    Sweet

}

