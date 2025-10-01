// See https://aka.ms/new-console-template for more information
// 

using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Slutuppgift;

using Slutuppgift;
        // Lägger till lista på de enkla saker som behövs medans programmet kör
        List<User> users = new List<User>();
        List<Item> items = new List<Item>();
        //List<TradeRequest> TradeRequests = new();
        //List<TradeRequest> CompletedTrades = new();




        bool running = true;

while (running)
{
    Console.WriteLine("Välj ett alternative:");
    Console.WriteLine("1. Registrera Konto");
    Console.WriteLine("2. Logga in");
    Console.WriteLine("3. Logga ut");
    Console.WriteLine("4. Ladda upp item");
    Console.WriteLine("5. List Others Items");
    Console.WriteLine("6. Begär en trade");
    Console.WriteLine("7. Acceptera Request");
    Console.WriteLine("8. Neka trade");
    Console.WriteLine("9. Visa genomförda trades");
    Console.WriteLine("0. Avsluta");

    string choice = Console.ReadLine(); // skapar en string till det som usern väljer

    switch (choice)
    {
        case "1":
            Register();
            break;

        case "2":
            //Login();
            break;

        case "3":
            //Logout();
            break;

        case "4":
            //UploadItem();
            break;

        case "5":
            //ListOthersItems();
            break;

        case "6":
            //RequestTrade();
            break;

        case "7":
            //AcceptRequest();
            break;

        case "8":
                //DenyRequest();
            break;

        case "9":
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







// methods

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



//while (bool = running );

//switch 1-5 
