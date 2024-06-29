using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int fullPrice = 10;
            const int discountedPrice = 7;

            Console.Write("Please enter your age to calculate the ticket price: ");
            string input = Console.ReadLine();
            int age;

            if (int.TryParse(input, out age))
            {
                int ticketPrice = CalculateTicketPrice(age, fullPrice, discountedPrice);
                Console.WriteLine("Your ticket price is: " + ticketPrice);
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a numeric value.");
            }

            Console.ReadKey();
        }

        static int CalculateTicketPrice(int age, int fullPrice, int discountedPrice)
        {
            if (age <= 12 || age >= 65)
            {
                return discountedPrice;
            }
            else
            {
                return fullPrice;
            }
        }
    }
}
