using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ContainerVervoer.Tests
{
    [TestClass()]
    public class StackTests
    {
        Stack stack = new Stack();
        //compatibility with containertype
        [TestMethod()]
        public void Check_If_Container_Valuable_Is_Compatible()
        {
            Container container = new Container(Container.ContainerType.Valuable, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);
            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Cooled_Is_Compatible()
        {
            Container container = new Container(Container.ContainerType.Cooled, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);
            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Normal_Is_Compatible()
        {
            Container container = new Container(Container.ContainerType.Normal, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);
            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Valuable_Is_Compatible_With_Valuable()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Valuable, 30));

            Container container = new Container(Container.ContainerType.Valuable, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsFalse(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Cooled_Is_Compatible_With_Valuable()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Valuable, 30));

            Container container = new Container(Container.ContainerType.Cooled, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Normal_Is_Compatible_With_Valuable()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Valuable, 30));

            Container container = new Container(Container.ContainerType.Normal, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Cooled_Is_Compatible_With_Cooled()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Cooled, 30));

            Container container = new Container(Container.ContainerType.Cooled, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Valuable_Is_Compatible_With_Cooled()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Cooled, 30));

            Container container = new Container(Container.ContainerType.Valuable, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Normal_Is_Compatible_With_Cooled()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Cooled, 30));

            Container container = new Container(Container.ContainerType.Normal, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Valuable_Is_Compatible_With_Normal()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Normal, 30));

            Container container = new Container(Container.ContainerType.Valuable, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Cooled_Is_Compatible_With_Normal()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Normal, 30));

            Container container = new Container(Container.ContainerType.Cooled, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsTrue(isCompatible);
        }

        [TestMethod()]
        public void Check_If_Container_Normal_Is_Compatible_With_Normal()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Normal, 30));

            Container container = new Container(Container.ContainerType.Normal, 30);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsTrue(isCompatible);
        }

        //Check if max weight is ok
        [TestMethod()]
        public void Check_If_Container_120t_Is_Compatible()
        {
            stack.Containers.Add(new Container(Container.ContainerType.Normal, 30));
            stack.SetStackWeight(30);

            Container container = new Container(Container.ContainerType.Normal, 130);
            bool isCompatible = stack.CheckContainerCompatibility(container, 4);

            Assert.IsFalse(isCompatible);
        }

        //Container placement
        [TestMethod()]
        public void Place_1_Cooled_Container()
        {
            Container container = new Container(Container.ContainerType.Cooled, 30);
            stack.PlaceContainer(container, 4);
            Assert.AreEqual(1, stack.Containers.Count);
        }

        [TestMethod()]
        public void Place_4_Cooled_Container()
        {
            List<Container> containers = new List<Container>();
            for (int i = 0; i < 4; i++)
            {
                containers.Add(new Container(Container.ContainerType.Cooled, 30));
            }
            foreach (var container in containers)
            {
                stack.PlaceContainer(container, 4);
            }

            Assert.AreEqual(4, stack.Containers.Count);
        }

        [TestMethod()]
        public void Place_1_Valuable_Container()
        {

            Container container = new Container(Container.ContainerType.Valuable, 30);
            stack.PlaceContainer(container, 4);


            Assert.AreEqual(1, stack.Containers.Count);
        }

        [TestMethod()]
        public void Place_1_Normal_Container()
        {

            Container container = new Container(Container.ContainerType.Normal, 30);
            stack.PlaceContainer(container, 4);


            Assert.AreEqual(1, stack.Containers.Count);
        }

        [TestMethod()]
        public void Place_4_Normal_Container()
        {

            List<Container> containers = new List<Container>();
            for (int i = 0; i < 4; i++)
            {
                containers.Add(new Container(Container.ContainerType.Normal, 30));
            }
            foreach (var container in containers)
            {
                stack.PlaceContainer(container, 4);
            }

            Assert.AreEqual(4, stack.Containers.Count);
        }
    }
}