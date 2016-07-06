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
                Console.WriteLine("Result: {0:f2}", Divide(firstNum, secondNum));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter an integer");
            }
            catch (OverflowException)
            {
                // Number too large or small to fit in int32
                Console.WriteLine("Error: Number too large.");
                Console.WriteLine("Please enter an integer smaller than 2,147,483,647 ");
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
