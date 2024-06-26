using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public interface IShape
    {
        double CalculateArea(int x, int y);
        double CalculateArea(int x);
        void Draw();
    }
}
