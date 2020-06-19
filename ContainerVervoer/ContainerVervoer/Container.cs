namespace ContainerVervoer
{
    public class Container
    {
        //public int Position { get;internal set; }
        public ContainerType Containertype;
        public int Weight { get; internal set; }
        public Container(ContainerType _containerType, int weight)
        {
            Containertype = _containerType;
            Weight = weight;
        }
        //Enum for getting to know the container
        public enum ContainerType
        {
            Normal = 1,
            Valuable = 2,
            Cooled = 3

        }
        //Getting the enum int for the visualizer
        public int GetContainerTypeValue()
        {
            return (int)Containertype;
        }
        
        public override string ToString()
        {
            return Containertype.ToString() + " " + Weight;
        }
    }
}
