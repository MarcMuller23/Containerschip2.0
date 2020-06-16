using System.Collections.Generic;

namespace ContainerVervoer
{
    public class Port
    {   //Prop
        public Ship GeenVrachtWagen;
        //containerlijsten
        public List<Container> NormalContainerList { get; internal set; } = new List<Container>();
        public List<Container> ValuableContainerList { get; internal set; } = new List<Container>();
        public List<Container> CooledContainerList { get; internal set; } = new List<Container>();
        //Stacklijsten
        public List<Stack> StackList { get; internal set; } = new List<Stack>();
        public List<Stack> CooledStackList { get; internal set; } = new List<Stack>();
        public List<Stack> ValuableStackList { get; internal set; } = new List<Stack>();
        public List<Stack> NormalStackList { get; internal set; } = new List<Stack>();
        //Methods
        //Stacks maken
        public void BuildStacks()
        {
            StackList.Add(new Stack());
            AddValuableContainers();
            AddCooledContainers();
            AddNormalContainers();
        }
        private void AddValuableContainers()
        {
            foreach (var container in ValuableContainerList)
            {
                for (int i = 0; i < StackList.Count; i++)
                {
                    if (StackList[i].CheckContainerCompatibility(container, GeenVrachtWagen.Height))
                    {

                        StackList[i].PlaceContainer(container);
                    }
                    else if (StackList.Count != GeenVrachtWagen.MaxStacks)
                    {
                        StackList.Add(new Stack());
                        i = StackList.Count;
                    }
                }
            }
        }
        private void AddCooledContainers()
        {
            foreach (var container in CooledContainerList)
            {
                for (int i = 0; i < StackList.Count; i++)
                {
                    if (StackList[i].CheckContainerCompatibility(container, GeenVrachtWagen.Height))
                    {

                        StackList[i].PlaceContainer(container);
                    }
                    else if (StackList.Count != GeenVrachtWagen.MaxStacks)
                    {
                        StackList.Add(new Stack());
                        i = StackList.Count;
                    }
                }
            }
        }
        private void AddNormalContainers()
        {
            foreach (var container in NormalContainerList)
            {
                for (int i = 0; i < StackList.Count; i++)
                {
                    if (StackList[i].CheckContainerCompatibility(container, GeenVrachtWagen.Height))
                    {

                        StackList[i].PlaceContainer(container);
                    }
                    else if (StackList.Count != GeenVrachtWagen.MaxStacks)
                    {
                        StackList.Add(new Stack());
                        i = StackList.Count;
                    }
                }
            }
        }
        public void SetContainerList(List<Container> normalContainerList, List<Container> valuableContainerList, List<Container> cooledContainerList)
        {
            NormalContainerList = normalContainerList;
            ValuableContainerList = valuableContainerList;
            CooledContainerList = cooledContainerList;
        }

        //Schip aanmaken
        public void CreateShip(int length, int width, int height)
        {
            GeenVrachtWagen = new Ship(length, width, height);
            CalculateShipValues(length, width, height);
            for (int i = 0; i < length; i++)
            {
                GeenVrachtWagen.CreateRow();
            }
        }
        private void CalculateShipValues(int length, int width, int height)
        {
            int maxStacks = length * width;
            int maxValuable = width * 2;
            int maxCoolable = width * height - (ValuableContainerList.Count / 2);
            GeenVrachtWagen.SetShipValues(maxStacks, maxValuable, maxCoolable);

        }
        //Stacks verdelen op rows

        public void AssignRow()
        {
            DivideStacks();
            AssignCooledStack();
            AssignValuableStack();
            AssignNormalStack();

        }
        private void DivideStacks()
        {
            foreach (var stack in StackList)
            {
                if (stack.Cooled == true)
                {
                    CooledStackList.Add(stack);
                }
                else if (stack.Valuable == true)
                {
                    ValuableStackList.Add(stack);
                }
                NormalStackList.Add(stack);

            }

        }
        private void AssignCooledStack()
        {
            foreach (var stack in CooledStackList)
            {
                GeenVrachtWagen.AssignStackToRow(stack);
            }
        }
        private void AssignValuableStack()
        {
            foreach (var stack in ValuableStackList)
            {
                GeenVrachtWagen.AssignStackToRow(stack);
            }
        }
        private void AssignNormalStack()
        {
            foreach (var stack in NormalStackList)
            {
                GeenVrachtWagen.AssignStackToRow(stack);
            }
        }

        //testing

        public List<Container> GetStack()
        {
            return StackList[0].ContainerList;
        }
    }
}
