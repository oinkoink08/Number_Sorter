using NumberSorter.Sorting_Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    class Sort
    {
        private String _choice1, _choice2;
        private Decimal _tempdec;
        private IList<Decimal> _vault = new List<Decimal>();
        private String[] _vaultarr;

        public void GetInput()
        {
            Console.Write("Enter a list of numbers to be sorted separated by commas: ");
            _choice1 = Console.ReadLine();
        }

        public void GetSortingMethod()
        {
            Console.Write("Enter your choice of Sorting : (B)ubble Sort or (S)election Sort? : ");
            _choice2 = Console.ReadLine();

            ShowDetails();
        }

        private void ShowDetails()
        {
            Console.WriteLine();
            Console.Write("List of Numbers : ");
            _vaultarr = _choice1.Split(',');

            foreach (var x in _vaultarr)
            {
                if (Decimal.TryParse(x, out _tempdec))
                {
                    _vault.Add(_tempdec);
                    Console.Write(_tempdec);
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            Console.Write("Sorting Method : ");
            switch (_choice2.ToUpper())
            {
                case ("B"):
                    Console.WriteLine("Bubble Sort");
                    new Bubble().Sort(_vault);
                    break;
                case ("S"):
                    Console.WriteLine("Selection Sort");
                    new Selection().Sort(_vault);
                    break;
                default:
                    Console.WriteLine("Invalid Sort");
                    break;
            }
        }
    }
}
