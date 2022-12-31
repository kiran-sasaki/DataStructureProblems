using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class UnOrderedList
    {
        public void Unorder()
        {
            LinkedList<string> list = new LinkedList<string>();
            string text = "Manchester United is the best football team";
            string[] textlist = text.Split(" ");
            foreach (var data in textlist)
            {
                list.Add(data);
            }
            list.Display();
            list.Search("United");
        }
    }
}
