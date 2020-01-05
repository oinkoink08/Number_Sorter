using NumberSorter.Sorting_Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    public class Sort
    {        
        public ISort SortingMethod(String SortType)
        {
            switch (SortType.ToUpper())
            {
                case ("B"):
                    Console.WriteLine("Bubble Sort");
                    return new Bubble();
                case ("S"):
                    Console.WriteLine("Selection Sort");
                    return new Selection();
                default:
                    Console.WriteLine("Invalid Sort");
                    throw new NotImplementedException();
            }
        }

        public string[] SortingMethod()
        {
            string[] sortingType = { "Bubble Sort", "Selection Sort" };

            return sortingType;
        }
    }
}
