namespace ContainerVervoer
{
    public class ShipFactory
    {
        private Ship GeenVrachtWagen;
        //Creating a ship for us to work with
        public void CreateShip(int length, int width, int height,int ValuableContainerCount, int cooledContainerCount)
        {
            GeenVrachtWagen = new Ship(length, width, height);
            CalculateShipValues(length, width, height, ValuableContainerCount,  cooledContainerCount);
            for (int i = 0; i < length; i++)
            {
                GeenVrachtWagen.CreateRow();
            }            
        }
        //Calculating the ship values for checking
        private void CalculateShipValues(int length, int width, int height,int valuableContainerCount, int cooledContainerCount)
        {
            int maxStacks = length * width;
            int maxValuable = width;
            int maxCoolable = width * height - valuableContainerCount ;           
            int maxWeight = maxStacks * 150000;
            int minWeight =maxWeight/2;
            int maxNormal = length * width * height - valuableContainerCount - cooledContainerCount;
            GeenVrachtWagen.SetShipValues(maxStacks, maxValuable, maxCoolable,minWeight,maxWeight, maxNormal);
        }
        //Geting the ship to another class to read
        public Ship GetShip() { return GeenVrachtWagen; }
    }
}
