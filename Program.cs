using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            sort.GetInput();
            sort.GetSortingMethod();
        }
    }
}
