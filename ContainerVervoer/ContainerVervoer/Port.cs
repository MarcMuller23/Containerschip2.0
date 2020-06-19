using System.Collections.Generic;

namespace ContainerVervoer
{
    public class Port
    {
        ShipFactory Factory;        
        public List<Container> NormalContainers { get; internal set; } = new List<Container>();
        public List<Container> ValuableContainers { get; internal set; } = new List<Container>();
        public List<Container> CooledContainers { get; internal set; } = new List<Container>();
        public List<Container> LeftOverContainers { get; internal set; } = new List<Container>();
        //Stacklijsten
        public List<Stack> Stacks { get; internal set; } = new List<Stack>();
        public List<Stack> CooledStacks { get; internal set; } = new List<Stack>();
        public List<Stack> ValuableStacks { get; internal set; } = new List<Stack>();
        public List<Stack> NormalStacks { get; internal set; } = new List<Stack>();

        //Methods
        //Building the stacks before they go on ship
        public void BuildStacks()
        {
            
            
            Stacks.Add(new Stack());
            AddValuableContainers();
            AddCooledContainers();
            AddNormalContainers();
        }
        //Starting off with valuable containers
        private void AddValuableContainers()
        {
            foreach (var container in ValuableContainers)
            {
                for (int i = 0; i < 2; i++)
                {
                    bool newStack = false;
                    for (int e = 0; e < Stacks.Count; e++)
                    {
                        if (Stacks[e].CheckContainerCompatibility(container, Factory.GetShip().Height))
                        {
                            Stacks[e].PlaceContainer(container, Factory.GetShip().Height);
                            newStack = false;
                            i = 2;
                            e = Stacks.Count;
                        }
                        else
                        {
                            newStack = true;
                        }
                    }
                    if (Stacks.Count != Factory.GetShip().MaxStacks && newStack == true)
                    {
                        Stacks.Add(new Stack());
                    }
                }
            }
        }
        //Adding the cooled ones after the valuables
        private void AddCooledContainers()
        {
            foreach (var container in CooledContainers)
            {
                for (int i = 0; i < 2; i++)
                {
                    bool newStack = false;
                    for (int e = 0; e < Stacks.Count; e++)
                    {
                        if (Stacks[e].CheckContainerCompatibility(container, Factory.GetShip().Height))
                        {
                            Stacks[e].PlaceContainer(container, Factory.GetShip().Height);
                            newStack = false;
                            i = 2;
                            e = Stacks.Count;
                        }
                        else
                        {
                            newStack = true;
                        }
                    }
                    if (Stacks.Count != Factory.GetShip().MaxStacks && newStack == true)
                    {
                        Stacks.Add(new Stack());
                    }
                }
            }
        }
        //and then the normal containers
        private void AddNormalContainers()
        {
            foreach (var container in NormalContainers)
            {
                for (int i = 0; i < 2; i++)
                {
                    bool newStack = false;
                    for (int e = 0; e < Stacks.Count; e++)
                    {
                        if (Stacks[e].CheckContainerCompatibility(container, Factory.GetShip().Height))
                        {
                            Stacks[e].PlaceContainer(container, Factory.GetShip().Height);
                            newStack = false;
                            i = 2;
                            e = Stacks.Count;
                        }
                        else
                        {
                            newStack = true;
                        }
                    }
                    if (Stacks.Count != Factory.GetShip().MaxStacks && newStack == true)
                    {
                        Stacks.Add(new Stack());
                    }
                }
            }
        }
        //Geting the containerlist form the form
        public void SetContainerList(List<Container> normalContainerList, List<Container> valuableContainerList, List<Container> cooledContainerList)
        {
            NormalContainers = normalContainerList;
            ValuableContainers = valuableContainerList;
            CooledContainers = cooledContainerList;
        }
        
        

        //Assigning stacks to rows, starting with cooled then valuables and then normals
        public void AssignRow()
        {
            DivideStacks();
            AssignCooledStack();
            AssignValuableStack();
            AssignNormalStack();

        }
        //Seperating the diffrent types of stacks
        private void DivideStacks()
        {
            foreach (var stack in Stacks)
            {
                if (stack.Cooled == true)
                {
                    CooledStacks.Add(stack);
                }
                else if (stack.Valuable == true)
                {
                    ValuableStacks.Add(stack);
                }
                NormalStacks.Add(stack);
            }
        }
        //Assign the cooled ones
        private void AssignCooledStack()
        {
            foreach (var stack in CooledStacks)
            {
                Factory.GetShip().AssignStackToRow(stack);
            }
        }
        //Assign the valuable ones
        private void AssignValuableStack()
        {
            foreach (var stack in ValuableStacks)
            {
                Factory.GetShip().AssignStackToRow(stack);
            }
        }
        //Assign the normal ones
        private void AssignNormalStack()
        {
            foreach (var stack in NormalStacks)
            {
                Factory.GetShip().AssignStackToRow(stack);
            }
        }
        //testing
        public List<Container> GetStack()
        {
            return Stacks[0].Containers;
        }
        //Setting the factory so you have the same one from Form
        public void SetFactory(ShipFactory factory) { Factory = factory; }
    }
}
