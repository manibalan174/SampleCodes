using System;
namespace ClassSample
{
    class Program
    { 

        static int Factorial( int Number)
        {
            if(Number == 0)
            {
             return 1;
            }
            else
            {
                return Number * Factorial( Number - 1);
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Number {0}",Factorial(4));
        }
    }
}
