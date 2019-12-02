using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class RectangularDimension : IDimension
    {
        int width;
        int height;

        public RectangularDimension(int width,int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
