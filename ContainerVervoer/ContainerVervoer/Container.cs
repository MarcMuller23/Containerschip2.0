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
        public ContainerType Containertype;
        public int Weight { get;internal set; }
        public Container( ContainerType _containerType,int weight)
        {
            Containertype = _containerType;
            Weight = weight;
        }
        public enum ContainerType
        {
            Cooled,
            Valuable,
            Normal
        }
        public void SetPostition(int position) { Position = position; }
        public override string ToString()
        {
            return Containertype.ToString() + " " + Weight + " "+ Position;

        }
    }
}
