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
            Console.Write("Enter a list of numbers to be sorted separated by commas: ");
            IList<Decimal> Input = Console.ReadLine().Split(',').Select(Decimal.Parse).ToList();

            Console.Write("Enter your choice of Sorting : (B)ubble Sort or (S)election Sort? : ");
            String SortType = Console.ReadLine();

            Sort sort = new Sort();
            ISort sort1 = sort.SortingMethod(SortType);

            Input = sort1.Sort(Input);
            foreach (Decimal d in Input)
            {
                Console.Write(d);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
