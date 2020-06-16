using System.Collections.Generic;

namespace ContainerVervoer
{
    public class Ship
    {
        public Ship(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;

        }
        //Props
        public int Length { get; internal set; }
        public int Width { get; internal set; }
        public int Height { get; internal set; }
        public List<Row> RowList { get; internal set; } = new List<Row>();
        public int MaxStacks { get; internal set; }
        public int MaxCoolable { get; internal set; }
        public int MaxValuable { get; internal set; }
        

        //Methods
        public void AssignStackToRow(Stack stack)
        {
            if (stack.Cooled)
            {
                for (int i = 0; i < RowList.Count; i++)
                {
                    if (RowList[i].StackList.Count == 0)
                    {
                        RowList[i].StackList.Add(stack);
                        i = RowList.Count;
                        RowList[i].RowWeight += stack.StackWeight;
                    }
                }
            }
            else if (stack.Valuable)
            {

            }
            else
            {

            }

        }
        public void CreateRow()
        {
            RowList.Add(new Row());
        }

        public void SetShipValues(int maxStacks, int maxValuable, int maxCoolable)
        {
            MaxStacks = maxStacks;
            MaxCoolable = maxCoolable;
            MaxValuable = maxValuable;

        }


    }
}
