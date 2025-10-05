using System;
using System.Collections.Generic;
using System.IO;

namespace Slutuppgift;

    // A class to store all the system data
    class Save
    {
        // Save users to users.txt
        public static void SaveUsers(List<User> users)
        {
            using (StreamWriter writer = new StreamWriter("users.txt", append: false))
            {
                foreach (User user in users)
                {
                    // Write email and password for each user
                    writer.WriteLine(user.GetUserEmail() + ',' + user.GetPassword());
                }
            }
        }

        // Load users from users.txt
        public static List<User> LoadUsers()
        {
            List<User> users = new List<User>();

            // Ensure the file exists before reading
            if (!File.Exists("users.txt")) return users;

            using (StreamReader reader = new StreamReader("users.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        // Create new user with email and password
                        users.Add(new User(parts[0], parts[1]));
                    }
                }
            }
            return users;
        }

        // Save items to items.txt
        public static void SaveItems(List<Item> items)
        {
            using (StreamWriter writer = new StreamWriter("items.txt", append: false))
            {
                foreach (Item item in items)
                {
                    // Write item name, description, and owner email
                    writer.WriteLine(item.GetItemName() + ',' + item.GetItemDescription() + ',' + item.GetOwnerEmail());
                }
            }
        }

        // Load items from items.txt
        public static List<Item> LoadItems()
        {
            List<Item> items = new List<Item>();

            // Ensure the file exists before reading
            if (!File.Exists("items.txt")) return items;

            using (StreamReader reader = new StreamReader("items.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        // Create a new item
                        items.Add(new Item(parts[0], parts[1], parts[2]));
                    }
                }
            }
            return items;
        }

        // Save trade requests to trades.txt
        public static void SaveTrades(List<TradeRequest> tradeRequests)
        {
            using (StreamWriter writer = new StreamWriter("trades.txt", append: false))
            {
                foreach (TradeRequest trade in tradeRequests)
                {
                    // Write trade details: requesting user, item being traded, target item, status, item owner
                    writer.WriteLine($"{trade.GetRequestingUserEmail()},{trade.GetUserItem()},{trade.GetTargetItem()},{trade.GetStatus()},{trade.GetItemOwner()}");
                }
            }
        }

        // Load trade requests from trades.txt
        static List<TradeRequest> LoadTrades()
        {
            List<TradeRequest> tradeRequests = new List<TradeRequest>();

            // Ensure the file exists before reading
            if (!File.Exists("trades.txt")) return tradeRequests;

            using (StreamReader reader = new StreamReader("trades.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        // Parse and create a new trade request
                        string requestingUserEmail = parts[0];
                        string userItem = parts[1];
                        string targetItem = parts[2];
                        string status = parts[3];
                        string itemOwner = parts[4];

                        tradeRequests.Add(new TradeRequest(requestingUserEmail, userItem, targetItem, itemOwner)
                        {
                            Status = status // Set the trade request status
                        });
                    }
                }
            }
            return tradeRequests;
        }
    }

