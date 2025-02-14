
using System.Drawing;

Color a = new Color(23, 23, 32);
Color b = Color.Red;

Console.WriteLine($"RED: {a.R} GREEN: {a.G} BLUE: {a.B}");
Console.WriteLine($"RED: {b.R} GREEN: {b.G} BLUE: {b.B}");
class Color
{
    public byte R { get; }
    public byte G { get; }
    public byte B { get; }

    public Color(byte red, byte green, byte blue)
    {
        if ((red >= 0) && (red <= 255) && (green >= 0) && (green <= 255) && (blue >= 0) && (blue <= 255))
        {
            R = red;
            G = green;
            B = blue;
        }
        else throw new Exception("Error");
    }

    // public static Color GetColor(string color)
    // {
    //     return color.ToLower() switch
    //     {
    //         "white" => new Color(255, 255, 255),
    //         "black" => new Color(0, 0, 0),
    //         "red" => new Color(255, 0, 0),
    //         "orange" => new Color(255, 165, 0),
    //         "yellow" => new Color(255, 255, 0),
    //         "green" => new Color(0, 128, 0),
    //         "blue" => new Color(0, 0, 255),
    //         "purple" => new Color(128, 0, 128),
    //         _ => new Color(0, 0, 0),
    //     };
    // }

    static public Color White() => new Color(255, 255, 255);
    static public Color Black => new Color(0, 0, 0);
    static public Color Red => new Color(255, 0, 0);
    static public Color Orange => new Color(255, 165, 0);
    static public Color Yellow => new Color(255, 255, 0);
    static public Color Green => new Color(0, 128, 0);
    static public Color Blue => new Color(0, 0, 255);
    static public Color Purple => new Color(128, 0, 128);
}