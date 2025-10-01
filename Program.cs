// See https://aka.ms/new-console-template for more information
// 

using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using Slutuppgift;

using Slutuppgift;
        // Lägger till lista på de enkla saker som behövs medans programmet kör
        List<User> users = new List<User>();
        List<Item> items = new List<Item>();
//List<TradeRequest> TradeRequests = new();
//List<TradeRequest> CompletedTrades = new();

User? active_user = null;

User user_ett = new User ("Lukas", "Lösenord");
Item ettItem = new Item("Dator", "Svart", "samaad");

Console.WriteLine("användare ett har lösenord: " + ettItem.Owner);
        bool running = true;

while (running)
{
    Console.WriteLine("Välj ett nummer:");
    Console.WriteLine("1. Registrera Konto");
    Console.WriteLine("2. Logga in");
    Console.WriteLine("3. Logga ut");
    Console.WriteLine("4. Ladda upp item");
    Console.WriteLine("5. Show All Items");
    Console.WriteLine("6. Show My Items");
    // Console.WriteLine("7. Begär en trade");
    // Console.WriteLine("8. Acceptera Request");
    // Console.WriteLine("9. Neka trade");
    // Console.WriteLine("10. Visa genomförda trades");
    // Console.WriteLine("0. Avsluta");

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
            //ListOthersItems();
            break;

        case "6":
            showMyItems();
            //ListOthersItems();
            break;

        case "7":
            //RequestTrade();
            break;

        case "8":
            //AcceptRequest();
            break;

        case "9":
                //DenyRequest();
            break;

        case "10":
            //ViewCompletedTrades();
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
    Console.WriteLine("Hej då!");

}


void UploadItem()
{

    Console.WriteLine("Enter item name");
    string name = Console.ReadLine();

    Console.WriteLine("Enter item description");
    string description = Console.ReadLine();

    Console.WriteLine("Enter owner email");
    string owner = Console.ReadLine();
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



 



//while (bool = running );

//switch 1-5 
