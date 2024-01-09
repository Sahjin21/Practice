using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    internal class Blocks
    {
        internal class Block
        {
            private int width;
            private int height;
            private int length;

            public Block(int[] dimensions)
            {
                width = dimensions[0];
                length = dimensions[1];
                height = dimensions[2];
                
            }

            public int GetWidth()
            {
                return width;
            }
            public int GetHeight()
            {
                return height;
            }

            public int GetLength()
            {
                return length;
            }
            public int GetVolume()
            {
                return width * height * length;
            }

            public int GetSurfaceArea()
            {
                return 2 * (length * width + length * height + width * height);
            }


        }

    }


    /*    

        b.GetLength(); // -> 4


        b.GetHeight(); // -> 6

        b.GetVolume(); // -> 48


        b.GetSurfaceArea(); // -> 88*/
}
