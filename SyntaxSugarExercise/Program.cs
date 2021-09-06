using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"The number is less than nine" : "The number is greater than or equal to 9";

            Console.WriteLine(response);

            
          //int answer = 4;
           // string response;

           // if (answer < 9)
            {
             //   response = answer + " is less than nine";
            }
           // else
            {
           //     response = answer + “greater than or equal to nine”;
            }



        }
    }
}
