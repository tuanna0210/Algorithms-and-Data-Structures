using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public abstract class SortingAlgorithm<T> : ISortingAlg<T> where T : IComparable
    {
        public virtual T[] Sort(T[] data)
        {
            throw new NotImplementedException();
        }
    }
}
