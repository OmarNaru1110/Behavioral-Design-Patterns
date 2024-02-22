using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    internal class DataStructure
    {
        protected List<int> Numbers = new List<int>();
        ISortAlgorithm _algorithm;
        public DataStructure(List<int> numbers, ISortAlgorithm sortAlgorithm)
        {
            Numbers = numbers;
            _algorithm = sortAlgorithm;
        }
        public void Sort()
        {
            this.Numbers = _algorithm.Sort(this.Numbers);
        }

        public void Print()
        {
            foreach (int number in this.Numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
