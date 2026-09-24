using System.Xml;

namespace sifra;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadej zprávu k šifrování (pouze A -Z): ");

        var message = Console.ReadLine();

        var cypher = CypherMessage(message, 5);

        Console.WriteLine($"Cyphered message is {cypher}.");
    }

    static string CypherMessage(string message, int key)
    {
        var output = "";

        foreach (char character in message)
        {


            if (character == 32)
            {
                output = output + character;
            }

            if (character < 65 || character > 90)
            {
                Console.WriteLine($"Tenhle znak {character} je neplatný!");

                continue;
            }

            var codedChar = character - 'A';
            codedChar = codedChar + key;
            codedChar = codedChar % 26;
            codedChar = codedChar + 'A';

            output = output + (char)codedChar;

        }
        
        return output;

    }
}