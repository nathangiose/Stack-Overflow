//Nathan John Giose 
using System;

namespace Stack_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print numbers 1 - 250
            for (int j = 1; j <= 250; j++)
            {
                string Answer = "";
                //Print "Stack" in increments of 2
                if (j % 2 == 0) Answer = "Stack ";

                //Print "Overflow" in increments of 4
                if (j % 4 == 0) Answer = Answer + "Overflow";

                //Print numbers normally if it is not divisible by Stack and Overflow's increments
                if (Answer.Length == 0) Answer = j.ToString();


                Console.WriteLine(Answer);
            }
            
        }
    }
}
