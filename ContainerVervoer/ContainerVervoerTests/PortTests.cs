using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoer.Tests
{
    [TestClass()]
    public class PortTests
    {

        //rotterdam kleine letter
        [TestMethod()]
        public void BuildStacks_ValuableContainerStack_2ValuableContainers_Succes()
        {
            //arrange
            Port rotterdamHarbor = new Port();
            for (int i = 0; i < 2; i++)
            {
                rotterdamHarbor.ValuableContainerList.Add(new Container(Container.ContainerType.Valuable, 4000));
            }
            //act
            rotterdamHarbor.CreateShip(4, 4, 4);
            rotterdamHarbor.BuildStacks();
            //Assert
            Assert.AreEqual(2, rotterdamHarbor.StackList.Count);
        }
        [TestMethod()]
        public void BuildStacks_ValuableContainerStack_4ValuableContainers_Succes()//or 4 stacks?
        {
            //arrange
            Port rotterdamHarbor = new Port();
            for (int i = 0; i < 4; i++)
            {
                rotterdamHarbor.ValuableContainerList.Add(new Container(Container.ContainerType.Valuable, 4000));
            }
            //act
            rotterdamHarbor.CreateShip(4, 4, 4);
            rotterdamHarbor.BuildStacks();
            //Assert
            Assert.AreEqual(4, rotterdamHarbor.StackList.Count);
        }

        [TestMethod()]
        public void CreateShip_CalculateShipValues_MaxStacks_16_Succes()
        {
            //arrange
            Port rotterdamHarbor = new Port();

            //act
            rotterdamHarbor.CreateShip(4, 4, 4);
            //assert
            Assert.AreEqual(16, rotterdamHarbor.GeenVrachtWagen.MaxStacks);
        }
        [TestMethod()]
        public void CreateShip_CalculateShipValues_MaxValuable_8_Succes()
        {
            //arrange
            Port rotterdamHarbor = new Port();

            //act
            rotterdamHarbor.CreateShip(4, 4, 4);
            //assert
            Assert.AreEqual(8, rotterdamHarbor.GeenVrachtWagen.MaxValuable);
        }
        [TestMethod()]//meer hiervan vanwege formule
        public void CreateShip_CalculateShipValues_MaxCoolable_16_Succes()
        {
            //arrange
            Port rotterdamHarbor = new Port();

            //act
            rotterdamHarbor.CreateShip(4, 4, 4);
            //assert
            Assert.AreEqual(16, rotterdamHarbor.GeenVrachtWagen.MaxCoolable);
        }
        [TestMethod()]//meer hiervan vanwege formule
        public void CreateShip_CalculateShipValues_MaxCoolable_15_Succes()
        {
            //arrange
            Port rotterdamHarbor = new Port();
            for (int i = 0; i < 2; i++)
            {
                rotterdamHarbor.ValuableContainerList.Add(new Container(Container.ContainerType.Valuable, 4000));
            }
            //act
            rotterdamHarbor.CreateShip(4, 4, 4);
            //assert
            Assert.AreEqual(15, rotterdamHarbor.GeenVrachtWagen.MaxCoolable);
        }

        [TestMethod()]
        public void CreateShip_CreateRows_4_Succes()
        {
            //arrange
            Port rotterdamHarbor = new Port();

            //act
            rotterdamHarbor.CreateShip(4, 4, 4);
            //assert
            Assert.AreEqual(4, rotterdamHarbor.GeenVrachtWagen.RowList.Count);
        }
    }
}