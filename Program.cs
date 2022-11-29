using System;

namespace EvenFibSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the sum of even Fibonacci Sequence numbers below 4 million
            int limit = 4000000;
            int current = 1;
            int prev = 0;
            int twoPrev = 0;
            int evenInt = 0;
            int evenSum = 0;

            //while the current even integer is less than 4,000,000
            while(evenInt < limit)
            {
                //keep track of last two values
                twoPrev = prev;
                prev = current;
                //current is the sum of last two values (Fibbonacci number)
                current = prev + twoPrev;
                
                //if the current Fibbonacci number is even, and it is less than 4,000,000
                if((current % 2 == 0) && (evenInt < limit)) 
                {
                    //add current even Fib integer to running sum and update evenInt with the current Fib number
                    evenSum += evenInt;
                    evenInt = current;
                }
            }
            Console.WriteLine($"Sum: {evenSum}");
        }
    }
}
