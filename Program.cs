using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuestion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 03-P-1-1  


            //string intString = "151";
            //int intValue;
            //if (int.TryParse(intString, out intValue))
            //{
            //   Console.WriteLine("TryParse successful. Converted integer value: " + intValue);
            //}
            //else
            //{
            //   Console.WriteLine("TryParse failed. Invalid input string.");
            //}


            // Assignment 03-P-1-2 
            //string doubleString = "1.90";
            //try
            //{
            //    double doubleValue = Convert.ToDouble(doubleString);
            //    Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Convert failed. Invalid input format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Convert failed. Input value is too large or too small.");
            //}

            //// Assignment 03-P-1-3 
            //string decimalString = "22.89";
            //try
            //{
            //    decimal decimalValue = decimal.Parse(decimalString);
            //    Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Parse failed. Invalid input format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Parse failed. Input value is too large or too small.");


            //Assignment 03-P2

            // Assignment 03-P2-1
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                int result = number * 5;
                Console.WriteLine($"The result is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Assignment 03-P2-2
            Console.WriteLine("Enter a date (dd/mm/yyyy): ");
            string dateInput = Console.ReadLine();
            try
            {
                DateTime date = Convert.ToDateTime(dateInput);
                DateTime newDate = date.AddMonths(-1);
                Console.WriteLine($"One month ago was: {newDate.ToShortDateString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid date in the format dd/mm/yyyy.");
            }

            // Assignment 03-P2-3
            Console.WriteLine("Enter a time (hh:mm:ss): ");
            string timeInput = Console.ReadLine();
            try
            {
                TimeSpan time = TimeSpan.Parse(timeInput);
                TimeSpan newTime = time.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Two hours later will be: {newTime.ToString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid time in the format hh:mm:ss.");
            }
        }
    }
}
