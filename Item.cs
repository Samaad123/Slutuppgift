namespace Slutuppgift;

class Item
{
    public string Name;
    public string Description;
    public string Owner;

    // konstruktör 
    public Item(string name, string description, string owner)
    {
        Name = name;
        Description = description;
        Owner = owner;
    }
}