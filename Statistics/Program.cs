namespace Statistics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadejte data k výpočtu statistiky (nebo konec):");

        var data = new List<int>();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "konec")
            {
                break;
            }

            var value = int.Parse(input);
            data.Add(value);
        }



    }

    static int GetMinValue(List<int> list)
    {
        if (list.Count == 0)
        {
            throw new Exception();
        }

        if (list.Count == 1)
        {
            return list[0];
        }

        var minimumSoFar = list[0];

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] < minimumSoFar)
            {
                minimumSoFar = list[i];
            }
        }

        return minimumSoFar;
    }
}
