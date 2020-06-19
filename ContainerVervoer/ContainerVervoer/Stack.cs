using System.Collections.Generic;
using static ContainerVervoer.Container;

namespace ContainerVervoer
{
    public class Stack
    {   //props
        public int StackPosition { get; internal set; }
        public bool Cooled { get; internal set; }
        public bool Valuable { get; internal set; }
        public List<Container> Containers = new List<Container>();
        public int Height => Containers.Count;
        public int StackWeight { get; internal set; }
        public bool StackIsFull { get; internal set; }
        //Methods
        //The first time checking if the container is compatible
        public bool CheckContainerCompatibility(Container container, int height)
        {
            bool compatible = true;

            for (int i = 0; i < Containers.Count; i++)
            {
                if (CheckIfFull(height) && CheckMaxWeight(container) && CheckIfValuableIsPresent(container))
                {
                    compatible = true;
                }
                else compatible = false;

            }
            return compatible;
        }
        //Checking if the stack is ful
        private bool CheckIfFull(int height)
        {
            if (Containers.Count == height)
            {
                StackIsFull = true;
                return false;
            }
            else return true;
        }
        //Checking if valuable is present, so no extra valuables are added
        private bool CheckIfValuableIsPresent(Container container)
        {
            if (container.Containertype == ContainerType.Valuable)
            {
                for (int i = 0; i < Containers.Count; i++)
                {
                    if (Containers[i].Containertype == ContainerType.Valuable)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //Checking if the weight limit is overreached
        private bool CheckMaxWeight(Container container)
        {
            
            int maxWeightOnFirstContainer =120;

            if ((StackWeight-Containers[0].Weight + container.Weight  ) > maxWeightOnFirstContainer)
            {
                return false;
            }
            return true;
        }
        //Giving the container a place within the stack
        public void PlaceContainer(Container container, int height)
        {
            if (CheckContainerCompatibility(container, height))
            {
                Container valuableContainer = null;
                for (int i = 0; i < Containers.Count; i++)
                {
                    if (Containers[i].Containertype == ContainerType.Valuable)
                    {
                        valuableContainer = Containers[i];
                        Containers.RemoveAt(i);
                        
                        
                        i = Containers.Count;
                    }
                }
                Containers.Add(container);
                Containers.Add(valuableContainer);
                for (int i = 0; i < Containers.Count; i++)
                {
                    if (Containers[i]==null)
                    {
                        Containers.RemoveAt(i);
                    }
                }


                CheckIfContainerIsValuable(container);
                CheckIfContainerIsCooled(container);
                StackWeight += container.Weight;
            }
        }
        //Checking if the container is valuable, so the stack knows if its a valuable stack
        private void CheckIfContainerIsValuable(Container container)
        {
            if (container.Containertype == ContainerType.Valuable)
            {
                Valuable = true;
            }
        }
        //Checking if the container is Cooled, so the stack knows if its a cooled stack
        private void CheckIfContainerIsCooled(Container container)
        {
            if (container.Containertype == ContainerType.Cooled)
            {
                Cooled = true;
            }
        }
        public void SetStackWeight(int weight) { StackWeight = +weight; }
    }
}
