using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima.Tests
{
    class TaskIE
    {
        IEnumerable<T> Merge<T>(IEnumerable<int> order1, IEnumerable<T> source1, IEnumerable<T> source2)
        {
            
            int a = 0;
            foreach (int item in order1)
            {
                if (item == 1)
                {
                    a = 1;
                    return source1;
                }
                else if (item == 2)
                {
                    a = 2;
                    return source2;
                }
            }
            if (a==0) { throw new Exception("not found");}
            return source1;//почему нельзя без этого ретурна?
            //асинхронная реализация не сделана
        }
    }
}
