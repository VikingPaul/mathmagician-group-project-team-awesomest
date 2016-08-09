using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odd
    {
        // Counts all integers up to the user-entered count value and adds only the values 
        //  that have a non-zero modulus value and returns that values
        public List<int> CountOddNumbers(int SentNumOfOdds)
        {
            // Stores the resulting list of odd numbers
            List<int> oddNumbers = new List<int>();

            for (int count = 1; oddNumbers.Count < SentNumOfOdds; count++)
            {
                if (count % 2 != 0)
                {
                    oddNumbers.Add(count);
                }
            }

            return oddNumbers;
        }
    }
}
