namespace Slutuppgift;

class Item
{
    public string Name;
    public string Description;
    public User Owner;

    // konstruktör 
    public Item(string name, string description, User owner)
    {
        Name = name;
        Description = description;
        Owner = owner;
    }
}