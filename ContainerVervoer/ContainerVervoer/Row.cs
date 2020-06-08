using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Row
    {
        public int RowNumber { get; internal set; }
        List<Stack> StackList = new List<Stack>();
        public Row(int rownumber)
        {
            RowNumber = rownumber;
        }
        public void CreateStack() { }
        public List<Stack> GetStacks() { return StackList; }
    }
}
