using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
   public class Schip
    {
        public string Name { get; internal set; }
        public int Length { get; internal set; }
        public int Width { get; internal set; }
        public int Height { get; internal set; }

        public Schip(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;            
        }

    }
}
