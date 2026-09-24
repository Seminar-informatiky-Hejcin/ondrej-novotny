using Microsoft.VisualBasic;

namespace AreaVolume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vyber geometrický tvar:");
        Console.WriteLine("1 - čtverec");
        Console.WriteLine("2 - kruh");

        var shape = Console.ReadLine();

        switch (shape)
        {
            case "1":
                CalculateSquare();
                break;
            case "2":
                CalculateCircle();
                break;
            default:
                Console.WriteLine("Neplatná volba!");
                break;
        }



    }

    static void CalculateSquare()
    {
        Console.WriteLine("Zadej a:");
        var input = Console.ReadLine();

        var a = double.Parse(input);

        var area = a * a;
        var perimeter = 4 * a;

        Console.WriteLine($"Obsah: {area}");
        Console.WriteLine($"Obvod: {perimeter}");
    }

    static void CalculateCircle()
    {
        // ...
    }
}
