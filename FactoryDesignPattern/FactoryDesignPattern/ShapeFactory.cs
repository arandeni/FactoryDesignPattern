using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class ShapeFactory
    {
        public static IShape GetShape(string type) 
        { 
            IShape shape = null;
            if (type == "Circle") {
                shape = new Circle();
            } 
            else if (type == "Rectangle") {
                shape = new Rectangle();
            } 
            else if (type == "Triangle") {
                shape = new Triangle();
            }
            return shape;
        }
    }
}
