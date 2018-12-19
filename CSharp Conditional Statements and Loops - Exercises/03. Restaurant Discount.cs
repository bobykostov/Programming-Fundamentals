using System;

namespace Pr3RestaurantDiscount
{
    class Pr3RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            int smallHallPrice = 2500;
            int terracePrice = 5000;
            int greatHallPrice = 7500;

            int normalServicePrice = 500;
            int goldServicePrice = 750;
            int platinumServicePrice = 1000;

            double normalDiscount = 0.05;
            double goldDiscount = 0.1;
            double platinumDiscount = 0.15;

            double totalPrice = 0;

            if (groupSize > 0 && groupSize <= 50)
            {
                string hallName = "Small Hall";
                double sum = 0;
                double perPerson = 0;
                switch (package)
                {
                    case "Normal":
                        sum = smallHallPrice + normalServicePrice;
                        totalPrice = sum - (sum * normalDiscount);
                        perPerson = totalPrice / groupSize;
                        Console.WriteLine($"We can offer you the {hallName}");
                        Console.WriteLine($"The price per person is {perPerson:F2}$");
                        break;
                    case "Gold":
                        sum = smallHallPrice + goldServicePrice;
                        totalPrice = sum - (sum * goldDiscount);
                        perPerson = totalPrice / groupSize;
                        Console.WriteLine($"We can offer you the {hallName}");
                        Console.WriteLine($"The price per person is {perPerson:F2}$");
                        break;
                    case "Platinum":
                        sum = smallHallPrice + platinumServicePrice;
                        totalPrice = sum - (sum * platinumDiscount);
                        perPerson = totalPrice / groupSize;
                        Console.WriteLine($"We can offer you the {hallName}");
                        Console.WriteLine($"The price per person is {perPerson:F2}$");
                        break;
                    default: Console.WriteLine("We do not have an appropriate hall."); break;
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                string hallName = "Terrace";
                double sum = 0;
                double perPerson = 0;
                switch (package)
                {
                    case "Normal":
                        sum = terracePrice + normalServicePrice;
                        totalPrice = sum - (sum * normalDiscount);
                        perPerson = totalPrice / groupSize;
                        Console.WriteLine($"We can offer you the {hallName}");
                        Console.WriteLine($"The price per person is {perPerson:F2}$");
                        break;
                    case "Gold":
                        sum = terracePrice + goldServicePrice;
                        totalPrice = sum - (sum * goldDiscount);
                        perPerson = totalPrice / groupSize;
                        Console.WriteLine($"We can offer you the {hallName}");
                        Console.WriteLine($"The price per person is {perPerson:F2}$");
                        break;
                    case "Platinum":
                        sum = terracePrice + platinumServicePrice;
                        totalPrice = sum - (sum * platinumDiscount);
                        perPerson = totalPrice / groupSize;
                        Console.WriteLine($"We can offer you the {hallName}");
                        Console.WriteLine($"The price per person is {perPerson:F2}$");
                        break;
                    default: Console.WriteLine("We do not have an appropriate hall."); break;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                string hallName = "Great Hall";
                double sum = 0;
                double perPerson = 0;
                switch (package)
                {
                    case "Normal":
                        sum = greatHallPrice + normalServicePrice;
                        totalPrice = sum - (sum * normalDiscount);
                        perPerson = totalPrice / groupSize;
                        Console.WriteLine($"We can offer you the {hallName}");
                        Console.WriteLine($"The price per person is {perPerson:F2}$");
                        break;
                    case "Gold":
                        sum = greatHallPrice + goldServicePrice;
                        totalPrice = sum - (sum * goldDiscount);
                        perPerson = totalPrice / groupSize;
                        Console.WriteLine($"We can offer you the {hallName}");
                        Console.WriteLine($"The price per person is {perPerson:F2}$");
                        break;
                    case "Platinum":
                        sum = greatHallPrice + platinumServicePrice;
                        totalPrice = sum - (sum * platinumDiscount);
                        perPerson = totalPrice / groupSize;
                        Console.WriteLine($"We can offer you the {hallName}");
                        Console.WriteLine($"The price per person is {perPerson:F2}$");
                        break;
                    default: Console.WriteLine("We do not have an appropriate hall."); break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}