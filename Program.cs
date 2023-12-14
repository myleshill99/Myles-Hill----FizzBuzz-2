using System;


namespace FIzzBuzz2
{
    public class Program
    {
        static void Main(string[] args)
        {
            void FizzBuzz (int number)
            {

                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }

                //when the number is divisible by 3 print the word by fizz
                else if (number % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine( "buzz");
                }

                
                //when the number is divisible by 5 print the word buzz

                //when the number is divisible by both print fizzbuzz 

            }
        }
    }
}
