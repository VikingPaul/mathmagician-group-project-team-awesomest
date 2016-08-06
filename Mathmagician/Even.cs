using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even
    {
        List<int> evens = new List<int>();
        public Even(int numOfEvens)
        {
            for(int count = 1; evens.Count < numOfEvens; count++)
            {
                if (count%2 == 0)
                {
                    evens.Add(count);
                }
            }
        }
        public List<int> EvenList()
        {
            return evens;
        }

    }
}
