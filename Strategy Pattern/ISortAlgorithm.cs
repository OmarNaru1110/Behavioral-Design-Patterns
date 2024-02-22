using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal interface ISortAlgorithm
    {
        List<int> Sort(List<int> numbers);
    }
}
