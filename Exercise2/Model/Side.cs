using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Model
{
    public class Side
    {
        private Lazy<double> _length;

        public double Length => _length.Value;
        public Direction Start { get; }

        public Direction End { get; }
        public Side(float xStart, float yStart, float xEnd, float yEnd)
        {
            Start = new Direction(xStart, yStart);
            End = new Direction(xEnd, yEnd);
            _length = new Lazy<double>(CalculateLength);
        }

        private double CalculateLength()
        {
            return Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
        }
    }
}
