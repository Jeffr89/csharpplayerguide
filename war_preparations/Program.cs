
Sword original = new Sword(Material.Iron, Gemstone.None, 55, 15);
Sword special_sword = original with { Material = Material.Binarium, Gemstone = Gemstone.Bitstone };
Sword sapphire_sword = original with { Gemstone = Gemstone.Sapphire };

Console.WriteLine(original);
Console.WriteLine(special_sword);
Console.WriteLine(sapphire_sword);





public record Sword(Material Material, Gemstone Gemstone, double Lenght, double CrossGuardWidth);

public enum Gemstone
{
    None,
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone
}
public enum Material
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium
}