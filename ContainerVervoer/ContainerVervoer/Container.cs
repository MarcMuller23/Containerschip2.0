using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Container
    {
        public int Position { get;internal set; }
        public ContainerType containertype;
        public int Weight { get;internal set; }
        public Container(int position, ContainerType _containerType,int weight)
        {
            Position = position;
            containertype = _containerType;
            Weight = weight;
        }
        public enum ContainerType
        {
            Cooled,
            Valuable,
            Normal
        }
    }
}
