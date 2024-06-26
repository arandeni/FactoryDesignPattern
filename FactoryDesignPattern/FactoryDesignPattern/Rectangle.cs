using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Rectangle : IShape
    {
        public double CalculateArea(int x, int y)
        {
            double area = x * y;
            return area;
        }

        public double CalculateArea(int x)
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
