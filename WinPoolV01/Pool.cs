using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPoolV01
{
    internal class Pool
    {
        public Pool() 
        {
            Length = 2.50;
            Width = 1.25;
            Height = 1.75;
        }

        public double Length { get; set; }
        
        public double Width { get; set; }
        
        public double Height { get; set; }

        public double Area
        { get 
            { var w = Width;
                var l = Length;
                var m2 = w * l;
                return m2;    
            } 
        }

        public double Volume
        { get 
            {
                return Area * Height;
            } 
        }
    }
}
