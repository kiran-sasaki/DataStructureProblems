using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class OrderedList
    {
        public void Order()
        {
            List<int> number = new List<int> { 1, 6, 7, 5, 9, 8 };
            number.Sort();
            LinkedList<int> list = new LinkedList<int>();
            foreach (int i in number)
            {
                list.Add(i);
            }
            list.Display();
        }
    }
}
