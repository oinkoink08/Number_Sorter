using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    interface ISort
    {
        void Sort(IList<Decimal> vault);
    }
}
