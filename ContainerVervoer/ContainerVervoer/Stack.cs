using System.Collections.Generic;
using System.Linq;
using static ContainerVervoer.Container;

namespace ContainerVervoer
{
    public class Stack
    {   //props
        public int StackPosition { get; internal set; }
        public bool Cooled { get; internal set; }
        public bool Valuable { get; internal set; }
        public List<Container> ContainerList { get; internal set; } = new List<Container>();

        public int StackWeight { get; internal set; }
        public bool StackIsFull { get; internal set; }
        //Methods
        public bool CheckContainerCompatibility(Container container, int height)
        {
            bool compatible = true;

            for (int i = 0; i < ContainerList.Count; i++)
            {
                if (CheckIfFull(height) && CheckIfValuableIsPresent(container) && CheckMaxWeight(container))
                {
                    compatible = true;
                }
                else compatible = false;

            }
            return compatible;
        }
        private bool CheckIfFull(int height)
        {
            if (ContainerList.Count == height)
            {
                StackIsFull = true;
                return false;
            }
            else return true;
        }

        private bool CheckIfValuableIsPresent(Container container)
        {
            if (container.Containertype == ContainerType.Valuable)
            {
                for (int i = 0; i < ContainerList.Count; i++)
                {
                    if (ContainerList[i].Containertype == ContainerType.Valuable)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool CheckMaxWeight(Container container)
        {
            int maxWeightOnFirstContainer = StackWeight - ContainerList[0].Weight;

            if (maxWeightOnFirstContainer + container.Weight > 120000)
            {
                return false;
            }
            return true;
        }
        public void PlaceContainer(Container container)
        {
            //waardevolle container een plaats omhoog
            for (int i = 0; i < ContainerList.Count; i++)
            {
                if (ContainerList[i].Containertype == ContainerType.Valuable)
                {
                    ContainerList[i].SetPostition(ContainerList[i].Position + 1);
                }
            }
            GiveContainerPostition(container);
            CheckIfContainerIsValuable(container);
            CheckIfContainerIsCooled(container);
            SortContainerListOnPostion(ContainerList);
            StackWeight += container.Weight;

        }
        private void GiveContainerPostition(Container container)
        {
            if (Valuable)
            {
                int newPosition = ContainerList.Count;
                container.Position = ContainerList[newPosition - 1].Position - 1;
                ContainerList.Add(container);
            }
            else
            {
                container.Position = ContainerList.Count + 1;
                ContainerList.Add(container);
            }
        }
        private void CheckIfContainerIsValuable(Container container)
        {
            if (container.Containertype == ContainerType.Valuable)
            {
                Valuable = true;
            }
        }
        private void CheckIfContainerIsCooled(Container container)
        {
            if (container.Containertype == ContainerType.Cooled)
            {
                Cooled = true;
            }
        }
        private List<Container> SortContainerListOnPostion(List<Container> containerlist)
        {
            containerlist.OrderBy(container => container.Position).ToList();
            return containerlist;
        }

    }
}
