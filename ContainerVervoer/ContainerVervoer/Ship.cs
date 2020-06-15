using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ContainerVervoer
{
    public class Ship
    {
        //Props
        public int Length { get; internal set; }
        public int Width { get; internal set; }
        public int Height { get; internal set; }        
        public List<Row> RowList { get; internal set; } = new List<Row>();
        public int MaxStacks { get; internal set; }
        public int MaxCoolable { get; internal set; }
        public int MaxValuable { get; internal set; }
        public bool RowIsFull { get; internal set; }
        public Ship(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;

        }
        //Methods
        public void AssignStackToRow(Stack stack)
        {
           

        }



        public void CreateRows() 
        {
            RowList.Add(new Row());
        }        
        
        public void SetShipValues(int maxStacks,int maxValuable, int maxCoolable) 
        {
        
        
        
        }


    }
}
