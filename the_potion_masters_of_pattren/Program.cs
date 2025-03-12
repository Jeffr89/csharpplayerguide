using System.Diagnostics;

Potion potion = Potion.Water;


while (true)
{
    Console.Clear();
    if (potion == Potion.Ruined)
    {
        Console.WriteLine("You ruined the potion. Start again!");
        potion = Potion.Water;
    }

    Console.WriteLine($"Currently you have a: {potion} Potion");
    Console.WriteLine("""
Choose the ingredient to add:
1 - Stardust
2 - SnakeVenom
3 - Dragon Breath
4 - Shadow Glass
5 - Eyeshine Gem
0 - End the alchemy
""");
    int input = int.Parse(Console.ReadLine());
    if (input == 0) break;
    Ingredient ingredient = input switch
    {
        1 => Ingredient.Stardust,
        2 => Ingredient.SnakeVenom,
        3 => Ingredient.DragonBreath,
        4 => Ingredient.ShadowGlass,
        5 => Ingredient.EyeshineGem,
        _ => Ingredient.None

    };




    potion = (ingredient, potion) switch
    {
        (Ingredient.Stardust, Potion.Water) => Potion.Elixir,
        (Ingredient.SnakeVenom, Potion.Elixir) => Potion.Poison,
        (Ingredient.DragonBreath, Potion.Elixir) => Potion.Flying,
        (Ingredient.ShadowGlass, Potion.Elixir) => Potion.Invisibility,
        (Ingredient.EyeshineGem, Potion.Elixir) => Potion.NightSight,
        (Ingredient.ShadowGlass, Potion.NightSight) => Potion.CloudyBrew,
        (Ingredient.EyeshineGem, Potion.Invisibility) => Potion.CloudyBrew,
        (Ingredient.Stardust, Potion.CloudyBrew) => Potion.Wraith,
        (Ingredient.None, _) => potion,
        _ => Potion.Ruined
    };


}

public enum Ingredient
{
    None,
    Stardust,
    SnakeVenom,
    DragonBreath,
    ShadowGlass,
    EyeshineGem

}
public enum Potion
{
    Water,
    Elixir,
    Poison,
    Flying,
    Invisibility,
    NightSight,
    CloudyBrew,
    Wraith,
    Ruined
}