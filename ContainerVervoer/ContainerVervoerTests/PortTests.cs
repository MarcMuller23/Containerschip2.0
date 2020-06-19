using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ContainerVervoer.Tests
{
    [TestClass()]
    public class PortTests
    {
        Port RotterdamHarbor = new Port();
        ShipFactory Factory = new ShipFactory();
        
        //make new stack for new valuable
        [TestMethod()]
        public void Build_2_seperate_stacks_for_2_Valuable_Containers()
        {
            //arrange            
            for (int i = 0; i < 2; i++)
            {
                RotterdamHarbor.ValuableContainers.Add(new Container(Container.ContainerType.Valuable, 4000));
            }
            Factory.CreateShip(4, 4, 4, RotterdamHarbor.ValuableContainers.Count, RotterdamHarbor.CooledContainers.Count);
            //act

            RotterdamHarbor.SetFactory(Factory);
            RotterdamHarbor.BuildStacks();
            //Assert
            Assert.AreEqual(2, RotterdamHarbor.Stacks.Count);
        }

        [TestMethod()]
        public void Build_4_seperate_stacks_for_4_Valuable_Containers()
        {
            //arrange            
            for (int i = 0; i < 4; i++)
            {
                RotterdamHarbor.ValuableContainers.Add(new Container(Container.ContainerType.Valuable, 30));
            }
            Factory.CreateShip(4, 4, 4, RotterdamHarbor.ValuableContainers.Count, RotterdamHarbor.CooledContainers.Count);
            //act

            RotterdamHarbor.SetFactory(Factory);
            RotterdamHarbor.BuildStacks();
            //Assert
            Assert.AreEqual(4, RotterdamHarbor.Stacks.Count);
        }

        //calculating ship variables
        [TestMethod()]
        public void Calculating_Max_Values_Created_Ship()
        {
            //arrange
            //act           
            Factory.CreateShip(4, 4, 4, RotterdamHarbor.ValuableContainers.Count, RotterdamHarbor.CooledContainers.Count);
            RotterdamHarbor.SetFactory(Factory);
            //act
            //assert
            Assert.AreEqual(16, Factory.GetShip().MaxStacks);
            Assert.AreEqual(4, Factory.GetShip().MaxValuable);
            Assert.AreEqual(16, Factory.GetShip().MaxCoolable);
        }

        //creating rows
        [TestMethod()]
        public void Creating_4_Rows()
        {
            //arrange
            //act
            Factory.CreateShip(4, 4, 4, RotterdamHarbor.ValuableContainers.Count, RotterdamHarbor.CooledContainers.Count);
            RotterdamHarbor.SetFactory(Factory);
            //assert
            Assert.AreEqual(4, Factory.GetShip().Rows.Count);
        }

        [TestMethod()]
        public void Creating_16_Rows()
        {
            //arrange
            //act
            Factory.CreateShip(16, 4, 4, RotterdamHarbor.ValuableContainers.Count, RotterdamHarbor.CooledContainers.Count);
            RotterdamHarbor.SetFactory(Factory);
            //assert
            Assert.AreEqual(16, Factory.GetShip().Rows.Count);
        }

        //Assigning stacks to rows
        [TestMethod()]
        public void Assign_1_cooled_Valuable_Stack_To_Front_Row()
        {
            //arrange
            
            for (int i = 0; i < 1; i++)
            {
                RotterdamHarbor.ValuableContainers.Add(new Container(Container.ContainerType.Valuable, 30));
            }
            for (int i = 0; i < 3; i++)
            {
                RotterdamHarbor.CooledContainers.Add(new Container(Container.ContainerType.Cooled, 30));
            }
            Factory.CreateShip(4, 4, 4, RotterdamHarbor.ValuableContainers.Count, RotterdamHarbor.CooledContainers.Count);
            int totalContainers = RotterdamHarbor.ValuableContainers.Count + RotterdamHarbor.CooledContainers.Count;
            RotterdamHarbor.SetFactory(Factory);
            RotterdamHarbor.BuildStacks();
            //act
            RotterdamHarbor.AssignRow();
            //assert
            Assert.IsNotNull(Factory.GetShip().Rows[0].Stacks[0]);
            Assert.AreEqual(totalContainers, Factory.GetShip().Rows[0].Stacks[0].Containers.Count);
        }

        [TestMethod()]
        public void Assign_2_cooled_Valuable_Stack_To_Front_Row()
        {
            //arrange
            for (int i = 0; i < 2; i++)
            {
                RotterdamHarbor.ValuableContainers.Add(new Container(Container.ContainerType.Valuable, 30));
            }
            for (int i = 0; i < 6; i++)
            {
                RotterdamHarbor.CooledContainers.Add(new Container(Container.ContainerType.Cooled, 30));
            }
            Factory.CreateShip(4, 4, 4, RotterdamHarbor.ValuableContainers.Count, RotterdamHarbor.CooledContainers.Count);
            int totalContainers = RotterdamHarbor.ValuableContainers.Count + RotterdamHarbor.CooledContainers.Count;            
            RotterdamHarbor.SetFactory(Factory);
            RotterdamHarbor.BuildStacks();
            //act
            RotterdamHarbor.AssignRow();
            int totalContainerOnShip = Factory.GetShip().Rows[0].Stacks[0].Containers.Count + Factory.GetShip().Rows[1].Stacks[0].Containers.Count;
            //assert
            Assert.IsNotNull(Factory.GetShip().Rows[0].Stacks[0]);
            Assert.IsNotNull(Factory.GetShip().Rows[1].Stacks[0]);
            Assert.AreEqual(totalContainers, totalContainerOnShip);
        }

        [TestMethod()]
        public void Assign_3_cooled_Valuable_Stack_To_Front_Row()
        {
            //arrange
            for (int i = 0; i < 3; i++)
            {
                RotterdamHarbor.ValuableContainers.Add(new Container(Container.ContainerType.Valuable, 30));
            }
            for (int i = 0; i < 9; i++)
            {
                RotterdamHarbor.CooledContainers.Add(new Container(Container.ContainerType.Cooled, 30));
            }
            Factory.CreateShip(4, 4, 4, RotterdamHarbor.ValuableContainers.Count, RotterdamHarbor.CooledContainers.Count);
            int totalContainers = RotterdamHarbor.ValuableContainers.Count + RotterdamHarbor.CooledContainers.Count;
            RotterdamHarbor.SetFactory(Factory);
            RotterdamHarbor.BuildStacks();
            //act
            RotterdamHarbor.AssignRow();
            int totalContainerOnShip = Factory.GetShip().Rows[0].Stacks[0].Containers.Count + Factory.GetShip().Rows[1].Stacks[0].Containers.Count+ Factory.GetShip().Rows[2].Stacks[0].Containers.Count;
            //assert
            Assert.IsNotNull(Factory.GetShip().Rows[0].Stacks[0]);
            Assert.IsNotNull(Factory.GetShip().Rows[1].Stacks[0]);
            Assert.IsNotNull(Factory.GetShip().Rows[2].Stacks[0]);
            Assert.AreEqual(totalContainers, totalContainerOnShip);

        }

        //do all containers have a spot?
        [TestMethod()]
        public void Do_All_Containers_Have_Spots()
        {
            //arrange
            List<Container> startListContainers = new List<Container>();
            List<Container> containersOnShip = new List<Container>();
            for (int i = 0; i < 4; i++)
            {
                RotterdamHarbor.ValuableContainers.Add(new Container(Container.ContainerType.Valuable, 30));
                startListContainers.Add(new Container(Container.ContainerType.Valuable, 30));
            }
            for (int i = 0; i < 12; i++)
            {
                RotterdamHarbor.CooledContainers.Add(new Container(Container.ContainerType.Cooled, 30));
                startListContainers.Add(new Container(Container.ContainerType.Cooled, 30));
            }
            for (int i = 0; i < 48; i++)
            {
                RotterdamHarbor.NormalContainers.Add(new Container(Container.ContainerType.Normal, 30));
                startListContainers.Add(new Container(Container.ContainerType.Normal, 30));
            }
            Factory.CreateShip(4, 4, 4, RotterdamHarbor.ValuableContainers.Count, RotterdamHarbor.CooledContainers.Count);            
            RotterdamHarbor.SetFactory(Factory);
            RotterdamHarbor.BuildStacks();  
            //act
            RotterdamHarbor.AssignRow();
            foreach (var row in Factory.GetShip().Rows)
            {
                foreach (var stack in row.Stacks)
                {
                    foreach (var container in stack.Containers)
                    {
                        containersOnShip.Add(container);
                    }
                }
            }
            //assert
            Assert.AreEqual(startListContainers.Count, containersOnShip.Count);

        }
    }
}