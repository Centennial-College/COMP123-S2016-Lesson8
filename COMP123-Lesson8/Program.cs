using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;

            try
            {
                Console.Write("Enter your numerator: ");
                firstNum = int.Parse(Console.ReadLine());
                Console.Write("Enter your denominator: ");
                secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + Divide(firstNum, secondNum));
            }
            catch 
            {
                Console.WriteLine("Error: Invalid Input");
            }

        }

        private static float Divide(int numerator, int denominator)
        {
            try
            {
                float result = Convert.ToSingle(numerator) / Convert.ToSingle(denominator);
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
                return 0f;
            }
        }
    }
}
