using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Circle : IShape
    {
        public double CalculateArea(int x, int y)
        {
            throw new NotImplementedException();
        }

        public double CalculateArea(int x)
        {
            double area = Math.PI * x * x;
            return area;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
