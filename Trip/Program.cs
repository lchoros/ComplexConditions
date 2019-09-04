using System;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());

            string season = Console.ReadLine();
            string destination = "Balkans";
            string vacationType = "Camp";
            int expensesPercent = 0;

            if(season == "winter")
            {
                vacationType = "Hotel";
            }

            if(budget <= 100)
            {
                destination = "Bulgaria";
                if(season == "summer")
                {
                    expensesPercent = 30;
                }
                else
                {
                    expensesPercent = 70;
                }
            }
            else if(budget > 100 && budget < 1000)
            {
                if (season == "summer")
                {
                    expensesPercent = 40;
                }
                else
                {
                    expensesPercent = 80;
                }
            }
            else if(budget > 1000)
            {
                destination = "Europe";
                vacationType = "Hotel";
                expensesPercent = 90;
            }

            decimal moneySpent = budget * expensesPercent / 100;
            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:F2}", vacationType, moneySpent);
        }
    }
}
