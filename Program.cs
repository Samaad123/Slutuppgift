// See https://aka.ms/new-console-template for more information
// 

using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Transactions;
using Slutuppgift;

using Slutuppgift;
        // Lägger till lista på de enkla saker som behövs medans programmet kör
        List<User> users = new List<User>();
        List<Item> items = new List<Item>();
        List<TradeRequest> tradeRequests = new List<TradeRequest>();
//List<TradeRequest> TradeRequests = new();
    List<TradeRequest> CompletedTrades = new();

    Console.WriteLine("New account added successfully");

User? active_user = null;

User user_ett = new User ("Lukas", "Lösenord");
Item ettItem = new Item("Dator", "Svart", "samaad");

Console.WriteLine("användare ett har lösenord: " + ettItem.Owner);
        bool running = true;

while (running)
{

    Console.WriteLine("Välj ett nummer:");
    Console.WriteLine("1. Register Account");
    Console.WriteLine("2. Log in");
    Console.WriteLine("3. Log out");
    Console.WriteLine("4. Upload an item");
    Console.WriteLine("5. Show All Items");
    Console.WriteLine("6. Show My Items");
    Console.WriteLine("7. Request a trade");
    Console.WriteLine("8. Display all trade requests");
    Console.WriteLine("9. Accept Request");
    Console.WriteLine("10. Deny Request");
    Console.WriteLine("11. Show completed trades");
    Console.WriteLine("0. Quit");

    string choice = Console.ReadLine(); // skapar en string till det som usern väljer

    switch (choice)
    {
        case "1":
            Register();
            break;

        case "2":
            Login();
            break;

        case "3":
            Logout();
            break;

        case "4":
            UploadItem();
            break;

        case "5":
            showAllItems();
            break;

        case "6":
            showMyItems();
            break;

        case "7":
            RequestTrade();
            break;

        case "8":
            DisplayTradeRequests();
            break;


        case "9":
            AcceptRequest();
            break;

        case "10":
            DenyRequest();
            break;

        case "11":
            ViewCompletedTrades();
            break;

        case "0":
            running = false;
            Console.WriteLine("Hej då!");
            break;

        default:
            Console.WriteLine("Ogiltigt Val. Försök igen");
            break;


    }

    Console.WriteLine("=====Trading System====");
    Console.WriteLine();
}












void Register()
{
    Console.Write("Add your email: ");
    string userEmail = Console.ReadLine();
    Console.Write("Add your password: ");
    string password = Console.ReadLine();

    User newUser = new User(userEmail, password);

    users.Add(newUser);

    Console.WriteLine("New account added successfully");
    
}

void Login()
{
    Console.Write("Write your email: ");
    string userEmail = Console.ReadLine();
    Console.Write("Write your password: ");
    string password = Console.ReadLine();

    foreach (User test in users)
    {
        if (userEmail == test.Email && password == test._password)
        {
            active_user = test;
        }
        else
        {
            Console.WriteLine("Fel info");
        }
    }
    Console.WriteLine("inloggad användare är: " + active_user.Email);

}


void Logout()
{
    running = false;
    Console.WriteLine("Goodbye!");

}


void UploadItem()
{

    Console.WriteLine("Enter item name");
    string? name = Console.ReadLine();

    Console.WriteLine("Enter item description");
    string? description = Console.ReadLine();

    Console.WriteLine("Enter owner email");
    string? owner = Console.ReadLine();
    Item itemToAdd = new Item(name, description, owner);

    items.Add(itemToAdd);

    Console.WriteLine("Item has sucessfully been added!");

}

void showAllItems()
{
    foreach (Item item in items)
    {
        Console.WriteLine("Itemname: " + item.Name + ". Item description: " + item.Description + ". Item owner: " + item.Owner);
    }
}

void showMyItems()
{
    foreach (Item item in items)
    {
        if (item.Owner == active_user?.Email)
        {
            Console.WriteLine("Itemname: " + item.Name + ". Item description: " + item.Description + ". Item owner: " + item.Owner);
        }

        else
        {
            Console.WriteLine("No current items, or user not logged in. Please Try again.");
        }

    }
}

void RequestTrade()
{
    Console.WriteLine("Enter your email: ");
    string RequestingUser = Console.ReadLine();

    Console.WriteLine("Enter item you would like to trade away: ");
    string UserItem = Console.ReadLine();

    Console.WriteLine("Enter item you would like to receive: ");
    string TargetItem = Console.ReadLine();

    Console.WriteLine("Enter item the email of the item owner: ");
    string ItemOwner = Console.ReadLine();


    TradeRequest tradeRequest = new TradeRequest(RequestingUser, UserItem, TargetItem, ItemOwner);
    tradeRequests.Add(tradeRequest);  // adding traderequest to the traderequest list.


    Console.WriteLine("Trade Request Successful and Pending");


}


void DisplayTradeRequests()
{
    Console.WriteLine("All Trade Requests:");
        foreach (var request in tradeRequests)
        {
            Console.WriteLine($"From: {request.RequestingUser} wants to trade {request.UserItem}, item owner is {request.ItemOwner} for {request.TargetItem}. Status: {request.Status}");
        }
}

void AcceptRequest()
{
    Console.WriteLine("Enter your email: ");
    string email = Console.ReadLine();

    Console.WriteLine("Pending Trade Requests:");
    
    // Show all pending requests for this user
    for (int i = 0; i < tradeRequests.Count; i++)
    {
        TradeRequest request = tradeRequests[i];
        if (request.ItemOwner == email && request.Status == "Pending")
        {
            Console.WriteLine($"{i + 1}. From {request.RequestingUser} - {request.UserItem} for {request.TargetItem}");
        }
    }

    Console.WriteLine("Enter the number of the trade request you want to accept:");
    int choice = int.Parse(Console.ReadLine()) - 1;

    if (choice < 0 || choice >= tradeRequests.Count)
    {
        Console.WriteLine("Invalid choice.");
        return;
    }

    // Accept the trade request
    tradeRequests[choice].Status = "Accepted";
    Console.WriteLine($"Trade accepted! {tradeRequests[choice].UserItem} will be traded for {tradeRequests[choice].TargetItem}");
}



void DenyRequest()
{
    Console.WriteLine("Enter your email: ");
    string email = Console.ReadLine();

    Console.WriteLine("Pending Trade Requests:");

    // Show all pending requests for this user
    for (int i = 0; i < tradeRequests.Count; i++)
    {
        TradeRequest request = tradeRequests[i];
        if (request.ItemOwner == email && request.Status == "Pending")
        {
            Console.WriteLine($"{i + 1}. From {request.RequestingUser} - {request.UserItem} for {request.TargetItem}");
        }
    }

    Console.WriteLine("Enter the number of the trade request you want to deny:");
    int choice = int.Parse(Console.ReadLine()) - 1;

    if (choice < 0 || choice >= tradeRequests.Count)
    {
        Console.WriteLine("Invalid choice.");
        return;
    }

    // Accept the trade request
    tradeRequests[choice].Status = "Denied";
    Console.WriteLine($"Trade denied!");
}

void ViewCompletedTrades()
{
    Console.WriteLine("Completed Trades:");

    // Check if there are any completed trades (Accepted or Denied)
    foreach (var request in tradeRequests)
    {
        if (request.Status == "Accepted" || request.Status == "Denied")
        {
            Console.WriteLine($"{request.RequestingUser} wanted to trade {request.UserItem} for {request.TargetItem}. Status: {request.Status}");
        }
    }
}






