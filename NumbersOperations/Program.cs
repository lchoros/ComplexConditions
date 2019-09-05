using System;

namespace NumbersOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = int.Parse(Console.ReadLine());
            decimal n2 = int.Parse(Console.ReadLine());
            string character = Console.ReadLine();
            string output = string.Empty;
            decimal result = 0.00M;

            if(character.Equals("+"))
            {
                result = n1 + n2;
                output += $"{n1} {character} {n2} = {result} - ";
            }
            else if(character.Equals("-"))
            {
                result = n1 - n2;
                output += $"{n1} {character} {n2} = {result} - ";

            }
            else if(character.Equals("*"))
            {
                result = n1 * n2;
                output += $"{n1} {character} {n2} = {result} - ";
            }
            if (character.Equals("+") || character.Equals("-") || character.Equals("*"))
            {
                if(result % 2 == 0)
                {
                    output += "even";
                }
                else
                {
                    output += "odd";
                }
            }
            else if (character.Equals("%"))
            {
                if(n2 != 0)
                {
                    result = n1 % n2;
                    output += $"{n1} % {n2} = {result}";
                }
                else
                {
                    output = $"Cannot divide {n1} by zero";
                }
            }
            else if (character.Equals("/"))
            {
                if (n2 != 0)
                {
                    result = n1 / n2;
                    output += $"{n1} / {n2} = {result}";
                }
                else
                {
                    output = $"Cannot divide {n1} by zero";
                }
            }
            Console.WriteLine(output);
        }
    }
}
