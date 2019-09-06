using System;

namespace NumbersOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = int.Parse(Console.ReadLine());
            decimal n2 = int.Parse(Console.ReadLine());
            string nOperator = Console.ReadLine();
            string output = string.Empty;
            decimal result = 0.00M;
            if (n2 == 0 && (nOperator.Equals("/") || nOperator.Equals("%")))
            {
                output = $"Cannot divide {n1} by zero";
            }
            else if (nOperator.Equals("/"))
            {
                result = n1 / n2;
                output = $"{n1} {nOperator} {n2} = {result:F2}";
            }
            else if (nOperator.Equals("%"))
            {
                result = n1 % n2;
                output = $"{n1} {nOperator} {n2} = {result}";
            }
            else
            {
                if (nOperator.Equals("+"))
                {
                    result = n1 + n2;
                }
                else if (nOperator.Equals("-"))
                {
                    result = n1 - n2;
                }
                else if (nOperator.Equals("*"))
                {
                    result = n1 * n2;
                }
                output = string.Format("{0} {1} {2} = {3} - {4}", n1, nOperator, n2, result, result % 2 == 0 ? "even" : "odd");
            }
            Console.WriteLine(output);
        }
    }
}
