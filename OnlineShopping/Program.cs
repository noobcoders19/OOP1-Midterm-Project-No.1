using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> cart = new List<string>();
        double total = 0;

        Console.Write("Enter your budget (PHP): ");
        double budget;
        while (!double.TryParse(Console.ReadLine(), out budget))
        {
            Console.Write("Invalid input! Enter a number: ");
        }

        int choice;
        int qty = 0;

        do
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Laptop");
            Console.WriteLine("2. Phone");
            Console.WriteLine("3. Shirt");
            Console.WriteLine("4. Shoes");
            Console.WriteLine("5. Checkout");
            Console.Write("Choose: ");

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Invalid input! Enter a number: ");
            }

            double itemTotal = 0;
            string itemName = "";

            if (choice == 1)
            {
                Console.WriteLine("\nLaptop Brands:");
                Console.WriteLine("1. Huawei - 900");
                Console.WriteLine("2. MacBook - 1500");
                Console.WriteLine("3. Asus - 1100");
                Console.WriteLine("4. HP - 1000");
                Console.Write("Choose brand: ");

                int brand;
                while (!int.TryParse(Console.ReadLine(), out brand))
                {
                    Console.Write("Invalid input! Enter a number: ");
                }

                Console.Write("Quantity: ");
                while (!int.TryParse(Console.ReadLine(), out qty))
                {
                    Console.Write("Invalid input! Enter a number: ");
                }

                Electronics? laptop = null;
                if (brand == 1) laptop = new Electronics("Huawei Laptop", 900);
                else if (brand == 2) laptop = new Electronics("MacBook", 1500);
                else if (brand == 3) laptop = new Electronics("Asus Laptop", 1100);
                else if (brand == 4) laptop = new Electronics("HP Laptop", 1000);

                if (laptop != null)
                {
                    itemTotal = laptop.GetPrice(qty);
                    itemName = laptop.name;
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("\nPhone Brands:");
                Console.WriteLine("1. iPhone 17 - 1200");
                Console.WriteLine("2. iPhone 17 Pro Max - 1500");
                Console.WriteLine("3. Samsung S23 - 1000");
                Console.WriteLine("4. Samsung Note 22 - 1100");
                Console.WriteLine("5. Xiaomi 13 - 900");
                Console.Write("Choose brand: ");

                int brand;
                while (!int.TryParse(Console.ReadLine(), out brand))
                {
                    Console.Write("Invalid input! Enter a number: ");
                }

                Console.Write("Quantity: ");
                while (!int.TryParse(Console.ReadLine(), out qty))
                {
                    Console.Write("Invalid input! Enter a number: ");
                }

                Electronics? phone = null;
                if (brand == 1) phone = new Electronics("iPhone 17", 1200);
                else if (brand == 2) phone = new Electronics("iPhone 17 Pro Max", 1500);
                else if (brand == 3) phone = new Electronics("Samsung S23", 1000);
                else if (brand == 4) phone = new Electronics("Samsung Note 22", 1100);
                else if (brand == 5) phone = new Electronics("Xiaomi 13", 900);

                if (phone != null)
                {
                    itemTotal = phone.GetPrice(qty);
                    itemName = phone.name;
                }
            }

            else if (choice == 3)
            {
                Console.WriteLine("\nShirt Brands:");
                Console.WriteLine("1. UA - 300");
                Console.WriteLine("2. Nike - 350");
                Console.WriteLine("3. Adidas - 400");
                Console.WriteLine("4. Zara - 450");
                Console.WriteLine("5. Prada - 600");
                Console.Write("Choose brand: ");

                int brand;
                while (!int.TryParse(Console.ReadLine(), out brand))
                {
                    Console.Write("Invalid input! Enter a number: ");
                }

                Console.Write("Quantity: ");
                while (!int.TryParse(Console.ReadLine(), out qty))
                {
                    Console.Write("Invalid input! Enter a number: ");
                }

                Clothing? shirt = null;
                if (brand == 1) shirt = new Clothing("UA Shirt", 300);
                else if (brand == 2) shirt = new Clothing("Nike Shirt", 350);
                else if (brand == 3) shirt = new Clothing("Adidas Shirt", 400);
                else if (brand == 4) shirt = new Clothing("Zara Shirt", 450);
                else if (brand == 5) shirt = new Clothing("Prada Shirt", 600);

                if (shirt != null)
                {
                    itemTotal = shirt.GetPrice(qty);
                    itemName = shirt.name;
                }
            }

            else if (choice == 4)
            {
                Console.WriteLine("\nShoes Brands:");
                Console.WriteLine("1. Nike - 500");
                Console.WriteLine("2. Adidas - 450");
                Console.WriteLine("3. Puma - 400");
                Console.WriteLine("4. Converse - 350");
                Console.WriteLine("5. Vans - 300");
                Console.Write("Choose brand: ");

                int brand;
                while (!int.TryParse(Console.ReadLine(), out brand))
                {
                    Console.Write("Invalid input! Enter a number: ");
                }

                Console.Write("Quantity: ");
                while (!int.TryParse(Console.ReadLine(), out qty))
                {
                    Console.Write("Invalid input! Enter a number: ");
                }

                Clothing? shoes = null;
                if (brand == 1) shoes = new Clothing("Nike Shoes", 500);
                else if (brand == 2) shoes = new Clothing("Adidas Shoes", 450);
                else if (brand == 3) shoes = new Clothing("Puma Shoes", 400);
                else if (brand == 4) shoes = new Clothing("Converse Shoes", 350);
                else if (brand == 5) shoes = new Clothing("Vans Shoes", 300);

                if (shoes != null)
                {
                    itemTotal = shoes.GetPrice(qty);
                    itemName = shoes.name;
                }
            }

            if (choice >= 1 && choice <= 4 && itemName != "")
            {
                if (total + itemTotal > budget)
                {
                    Console.WriteLine("Not enough budget!");
                }
                else
                {
                    total += itemTotal;
                    cart.Add(itemName + " x" + qty + " = PHP " + itemTotal);
                    Console.WriteLine("Added to cart!");
                }
            }

        } while (choice != 5);

        Console.WriteLine("\n=== RECEIPT ===");
        foreach (string item in cart)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Total: PHP " + total);
        Console.WriteLine("Remaining: PHP " + (budget - total));
        Console.WriteLine("Thank you for shopping!");
    }
}