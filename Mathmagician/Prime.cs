using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Prime
    {
        List<int> primes = new List<int>();
        public Prime(int numOfPrimes)
        {
            ////////////////////////////primes ALL start with 2 (1 is not a prime number, only has 1 divisor(itself))
            int lastPrime = 2;
            Console.WriteLine(numOfPrimes);
            /////////////////////Runs untill the numOfPrimes is reached
            for(int count = 0; count < numOfPrimes; lastPrime++)
            {
                int numOfDivisors = 0;
                ///////////////////////////Checks if nextPrime is an actual prime
                for (int countTwo = 1; countTwo < lastPrime+1; countTwo++)
                {
                    ////////////////////////////////checks number of divisors. primes have 2 (itself and 1)
                    if(lastPrime%countTwo == 0)
                    {
                        numOfDivisors++;
                    }
                }
                /////////////////////////////////Adds new prime to the list of primes
                if(numOfDivisors == 2)
                {
                    primes.Add(lastPrime);
                    count++;
                }
            }
        }
        ///////////////////////I'm sure there's an easier way to find primes. 
        public List<int> PrimeList()
        {
            return primes;
        }
    }
}
