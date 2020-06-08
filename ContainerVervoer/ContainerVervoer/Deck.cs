using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Deck
    {
        List<Row> RowList = new List<Row>();
        public void CreateRow() { }
        public List<Row> GetRows() { return RowList; }
    }
}
