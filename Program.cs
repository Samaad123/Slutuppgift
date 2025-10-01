// See https://aka.ms/new-console-template for more information
// 

using System;

namespace Slutuppgift
{
    class Program
    {
        // Lägger till lista på de enkla saker som behövs medans programmet kör
        static List<User> Users = new();
        static List<Item> Items = new();
        static List<TradeRequest> TradeRequests = new();
        static List<TradeRequest> CompletedTrades = new();

       

        bool running = true;

        While(running)
        {
            Console.WriteLine("Välj ett alternative:");
            Console.WriteLine("1. Registrera Konto");
            Console.WriteLine("2. Logga in");
            Console.WriteLine("3. Logga ut");
            Console.WriteLine("4. Ladda upp item");
            Console.WriteLine("5. Begär en trade");
            Console.WriteLine("6. Acceptera Request");
            Console.WriteLine("7. Neka trade");
            Console.WriteLine("8. Visa genomförda trades");
            Console.WriteLine("9. Avsluta");

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
                    RequestTrade();
                    break;

                case "6":
                    AcceptRequest();
                    break;

                case "7"
                    DenyRequest();
                    break;

                case "8":
                    ViewCompletedTrades();
                    break;

                case "9":
                    running = false;
                    Console.WriteLine("Hej då!");
                    break;

                default:
                    Console.WriteLine("Ogiltigt Val. Försök igen");
                    break;
            }

        }

    }

}


//while (bool = running );

//switch 1-5 
