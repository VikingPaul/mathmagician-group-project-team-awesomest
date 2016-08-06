using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public int[] PrintInteger(int numbers1)
        {
            int[] intArray = new int[numbers1];
            {
                for (var i = 0; i < numbers1; i++)
                {
                    intArray[i] = i;
                }

            }

            //foreach (int item in intArray)
            //{
            //    Console.Write("{0}, ", item);
            //}
            //Console.ReadLine();
            return intArray;
        }
    }
}
