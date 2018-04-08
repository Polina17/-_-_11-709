using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothSort
{
    public static class ArrayExtension
    {
        public static int[] Sort(this int[] array)
        {
            var s = new SmoothSort();
            s.Sort(array);
            return array;
        }
    }
}
