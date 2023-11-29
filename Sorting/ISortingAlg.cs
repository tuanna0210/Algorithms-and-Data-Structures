using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public interface ISortingAlg<T>
    {
        T[] Sort(T[] data);
    }
}
