using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    interface ISort
    {
        IList<Decimal> Sort(IList<Decimal> vault);
    }
}
