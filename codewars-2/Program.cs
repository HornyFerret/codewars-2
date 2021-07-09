using System;

namespace codewars_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char operation = Convert.ToChar(Console.ReadLine());
            double value1 = Convert.ToDouble(Console.ReadLine());
            double value2 = Convert.ToDouble(Console.ReadLine());

        }
        public static double basicOp(char operation, double value1, double value2)
        {

            if (operation == '+')
            {
                value1 = value1 + value2;
                return value1;
            }
            else if (operation == '-')
            {
                value1 = value1 - value2;
                return value1;
            }
            else if (operation == '*')
            {
                value1 = value1 * value2;
                return value1;
            }
            else if (operation == '/')
            {
                value1 = value1 / value2;
                return value1;
            }
            else
            {
                return operation;
            }
        }
    }
}
