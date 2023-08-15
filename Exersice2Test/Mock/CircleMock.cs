using Exercise2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice2Test.Mock
{
    public class CircleMock : Circle
    {
        public CircleMock(float x, float y, double radius) : base(x, y, radius)
        {
            x = 0;
            y = 0;
            radius = -1;
        }
    }
}
