using System;
using System.Collections.Generic;
using System.Diagnostics;

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
        public List<Row> Rows { get; internal set; } = new List<Row>();
        public int MaxStacks { get; internal set; }
        public int MaxCoolable { get; internal set; }
        public int MaxValuable { get; internal set; }
        public int MinWeight { get; internal set; }
        public int MaxWeight { get; internal set; }
        public int MaxNormal { get; internal set; }
        //Methods
        //Assigning the stack to a row
        public void AssignStackToRow(Stack stack)
        {
            if (stack.Cooled)
            {

                for (int i = 0; i < Rows.Count ; i++)
                {
                    if (!Rows[i].RowIsFull == true)
                    {
                        if (Rows[i].Stacks.Count == 0)
                        {
                            Rows[i].Stacks.Add(stack);

                            Rows[i].RowWeight += stack.StackWeight;
                            if (Rows[i].Stacks.Count == Length)
                            {
                                Rows[i].SetRowIsFull();
                            }
                            i = Rows.Count;
                        }

                    }
                }
            }
            else if (stack.Valuable)
            {
                for (int i = 0; i < Rows.Count; i++)
                {
                    if (!Rows[i].RowIsFull == true)
                    {
                        if (Rows[i].Stacks.Count == 0)
                        {
                            Rows[i].Stacks.Add(stack);
                            Rows[i].RowWeight += stack.StackWeight;
                            if (Rows[i].Stacks.Count == Length)
                            {
                                Rows[i].SetRowIsFull();
                            }
                            i = Rows.Count;

                        }
                        //else if (Rows[i].Stacks[Length] == null)
                        //{
                        //    Rows[Length].Stacks.Add(stack);
                        //    Rows[Length].RowWeight += stack.StackWeight;
                        //    i = Rows.Count;
                        //}
                    }
                }
            }
            else
            {

                for (int i = 0; i < Rows.Count; i++)
                {
                    if (!Rows[i].RowIsFull == true)
                    {
                        Rows[i].Stacks.Add(stack);
                        Rows[i].RowWeight += stack.StackWeight;
                        if (Rows[i].Stacks.Count == Length)
                        {
                            Rows[i].SetRowIsFull();
                        }
                        i = Rows.Count;
                    }

                }
            }
        }
        //creating rows for the ship
        public void CreateRow()
        {
            Rows.Add(new Row());
        }
        //Setting the shipvalues, this way you can check if some properties son't overreach
        public void SetShipValues(int maxStacks, int maxValuable, int maxCoolable, int minWeight, int maxWeight, int maxNormal)
        {
            MaxStacks = maxStacks;
            MaxCoolable = maxCoolable;
            MaxValuable = maxValuable;
            MinWeight = minWeight;
            MaxWeight = maxWeight;
            MaxNormal = maxNormal;
        }

        //the visualizer
        public void Visualizer()
        {
            string stack = "";
            string weight = "";
            for (int z = 0; z < Rows.Count; z++)
            {

                if (z > 0)
                {
                    stack += '/';
                    weight += '/';
                }


                for (int x = 0; x < Rows[z].Stacks.Count; x++)
                {

                    if (x > 0)
                    {
                        stack += ',';
                        weight += ',';
                    }

                    for (int y = 0; y < Rows[z].Stacks[x].Containers.Count; y++)
                    {
                        Container container = Rows[z].Stacks[x].Containers[y];



                        stack += Convert.ToString(container.GetContainerTypeValue());
                        weight += Convert.ToString(container.Weight);
                        if (y < (Rows[z].Stacks[x].Containers.Count - 1))
                        {
                            weight += "-";
                        }

                    }
                }
            }
            Process.Start("https://i872272core.venus.fhict.nl/ContainerVisualizer/index.html?length=" + Length + "&width=" + Width + "&stacks=" + stack + "&weights=" + weight + "");
        }
        
    }
}
