using System;

namespace GameTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            if(people >= 1 && people <=4)
            {
                budget *= 0.25M;
            }
            else if(people >= 5 && people <= 9)
            {
                budget *= 0.40M;
            }
            else if(people >= 10 && people <= 24)
            {
                budget *= 0.50M;
            }
            else if(people >= 25 && people <= 49)
            {
                budget *= 0.60M;
            }
            else if(people > 50)
            {
                budget *= 0.75M;
            }
            switch (category)
            {
                case "vip":
                    budget -= 499.99M * people;
                    break;
                case "normal":
                    budget -= 249.99M * people;
                    break;
                default:
                    break;
            }
            if(budget >= 0)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", budget);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(budget));
            }
        }
    }
}
