using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Searcher
    {
        public static bool SearchNumber(LinkedList<int> linkedList, int number)
        {
            
            if (linkedList.Contains(number))
            {
                return true;
            }
            
            return false;
        }
    }
}
