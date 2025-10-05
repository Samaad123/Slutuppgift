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


    // Getter for Item Name
    public string GetItemName() => Name;

    // Getter for Item Description
    public string GetItemDescription() => Description;

    // Getter for Item Owner's Email
    public string GetOwnerEmail() => Owner;
}