namespace Slutuppgift;

class TradeRequest
{
    public string RequestingUser;  //user who requested the trade
    public string UserItem;        // Item that the user wants to trade
    public string TargetItem;      // Item from the other user that they want to trade for
    public string Status;        // Status of the trade request (Pending/Accepted/Denied)
    public string ItemOwner;  // owner of the item

    // Constructor to create a trade request
    public TradeRequest(string requestingUser, string userItem, string targetItem, string itemOwner)
    {
        RequestingUser = requestingUser;
        UserItem = userItem;
        TargetItem = targetItem;
        ItemOwner = itemOwner;
        Status = "Pending";  // Default status
    }

       // Getter methods
    public string GetRequestingUserEmail() => RequestingUser;
    public string GetUserItem() => UserItem;
    public string GetTargetItem() => TargetItem;
    public string GetStatus() => Status;
    public string GetItemOwner() => ItemOwner;
}
