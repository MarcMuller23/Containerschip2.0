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
        public int RowWeight { get; internal set; }
        public bool RowIsFull { get; internal set; }
        public List<Stack> StackList { get; internal set; } = new List<Stack>();
        public Row()
        {
            
        }        
        public List<Stack> GetStacks() { return StackList; }
    }
}
