using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal class BubbleSort : ISortAlgorithm
    {
        public List<int> Sort(List<int> arr)
        {
            int n = arr.Count;
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)

            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
            return arr;
        }
    }
}
