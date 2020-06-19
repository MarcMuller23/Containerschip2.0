using System.Collections.Generic;

namespace ContainerVervoer
{
    public class Row
    {
        public Row()
        {
        }
        public int RowNumber { get; internal set; }
        public int RowWeight { get; internal set; }
        public bool RowIsFull { get; internal set; }
        public List<Stack> Stacks { get; internal set; } = new List<Stack>();        
        public List<Stack> GetStacks() { return Stacks; }
        public void SetRowIsFull() { RowIsFull = true; }
    }
}
