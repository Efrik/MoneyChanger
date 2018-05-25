using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] money = new int[9, 2] { { 1, 0 }, { 5, 0 }, { 10, 0 }, { 20, 0 }, { 50, 0 }, { 100, 0 }, { 200, 0 }, { 500, 0 }, { 1000, 0 } };
            int price = 0;
            int payment = 0;
            int change = 0;
            bool check = false;
            Console.WriteLine("You are now using the ECON'O'MATIC 3000+.");
            Console.WriteLine("Please, enter the price of the product:");
            while (check == false)
            {
                string price_string = Console.ReadLine();
                if (int.TryParse(price_string, out price))
                {
                    price = int.Parse(price_string);
                    check = true;
                }
                Console.Clear();
                Console.WriteLine("That was unclear.");
                Console.WriteLine("Please, enter the price of the product:");
            }
            Console.Clear();
            Console.WriteLine("Thanks.");
            Console.WriteLine("Price is "+price+" economical units.");
            Console.WriteLine("Please, enter client's payment:");
            while (check == true)
            {

                string payment_string = Console.ReadLine();
                if (int.TryParse(payment_string, out payment))
                {
                    payment = int.Parse(payment_string);
                    if (price <= payment)
                    {
                        check = false;
                        change = payment - price;
                    }
                }
                Console.Clear();
                Console.WriteLine("That was unclear.");
                Console.WriteLine("Price is " + price + " economical units.");
                Console.WriteLine("Please, enter client's payment:");
            }
            Console.Clear();
            for (int n = money.GetLength(0); n >0; n--)
            {
                while (change >= money[n-1, 0])
                {
                    change -= money[n-1, 0];
                    money[n-1, 1]++;
                }
            }
            Console.WriteLine("Thanks for your information.");
            Console.WriteLine("Price is " + price + " economical units.");
            Console.WriteLine("Payment is " + payment + " economical units.");
            Console.WriteLine("You shall give back to the customer " + (payment-price) + " economical units.");
            if ((payment - price) > 0)
            {
                Console.WriteLine("The change should be divided as:");
                for (int m = 0; m < money.GetLength(0); m++)
                {
                    if (money[m, 1] != 0)
                    {
                        Console.WriteLine("  " + money[m, 1] + " token of worth " + money[m, 0] + " economical units.");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Thanks for your time. Now, press any key to leave the program.");
            Console.ReadKey();
        }
    }
}
