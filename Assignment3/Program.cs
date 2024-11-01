using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A loop for looping untill it terminate 
            while (true)
            {
                Console.WriteLine("Please enter a number from(0-9999) or type 'quit' to terminate the program:");

                string WordNum = Console.ReadLine();

                if (WordNum.ToLower() == "quit")
                    break;

                if (int.TryParse(WordNum, out int Num))
                {
                    if (Num >= 0 && Num < 10000)
                    {
                        string result = NumberToWords(Num);
                        Console.WriteLine($"{Num}: This will result in: {result}\n");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number from(0-9999) or type 'quit' to terminate the program:");
                        WordNum = Console.ReadLine();
                        string result = NumberToWords(Num);
                        Console.WriteLine($"{Num}: This will result in: {result}\n");
                       

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.\n");
                }
            }
        }

        static string NumberToWords(int Number)
        {
            string[] UnitNum = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                          "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] TensNum = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (Number == 0)
                return UnitNum[0];

            string ReturnedWord  = "";

            //Comparison on  Thousands
            if (Number >= 1000)
            {
               ReturnedWord += UnitNum[Number / 1000] + " Thousand ";
                Number %= 1000;

                if (Number > 0)
                    ReturnedWord += " ";
            }

            //Comparison on Hundreds
            if (Number >= 100)
            {
                ReturnedWord += UnitNum[Number / 100] + " Hundred ";
                Number %= 100;

                if (Number > 0)
                    ReturnedWord += " ";
            }

            //Comparison of Tens and Units
            if (Number > 0)
            {
                if (Number < 20)
                    ReturnedWord += UnitNum[Number];
                else
                {
                    ReturnedWord += TensNum[Number / 10];
                    if ((Number % 10) > 0)
                        ReturnedWord += "-" + UnitNum[Number % 10];
                }
            }

            return ReturnedWord;//a returned string words
        }
    }
}
        
