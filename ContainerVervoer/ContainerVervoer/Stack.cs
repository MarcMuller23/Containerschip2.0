using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Stack
    {
        public int StackPosition { get;internal set; }
        List<Container> ContainerList = new List<Container>();
        public Stack(int stackPosition)
        {
            StackPosition = stackPosition;
        }
        public void PlaceContainer() { }
        public List<Container> GetContainerList() { return ContainerList; }
    }
}
