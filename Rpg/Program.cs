using System.Runtime.InteropServices.Marshalling;

namespace Rpg;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var pepa = new Character("Pepa", 10, new Position(0,0,0));
    }
}

struct Position
{
    public int x;
    public int y;
    public int z;
    public Position(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}
class Character
{
    public string Name;
    public int Maxhealth;
    public int ActiveHealth;
    public Inventory inventory;
    public Position CurrentPosition;
    public Character(string name, int maxhealth, Position position)
    {
        Name = name;
        Maxhealth = maxhealth;
        CurrentPosition = position;
    }
}

class PlayerCharacter : Character
{
    //AI
}

class NPC : Character
{
    //control
}

class Inventory
{
    private List<Item> items;

    public void AddItem(Item item)
    {}

    public void RemoveItem(Item item)
    {}

}

class Item
{
    public int Weight;
    public float Price;
    public string Name;
}

class Weapon : Item
{
    public int Damage;
}

class DroppedItem
{
    public Item item;
    public Position position;
}

class Chest
{
 public Inventory inventory;
 public Position position;    
}
