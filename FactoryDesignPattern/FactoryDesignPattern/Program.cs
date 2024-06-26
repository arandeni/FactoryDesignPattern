// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using FactoryDesignPattern;

IShape sh1 = ShapeFactory.GetShape("Circle");
double area1 = sh1.CalculateArea(2);
Console.WriteLine(area1);

IShape sh2 = ShapeFactory.GetShape("Rectangle");
double area2 = sh2.CalculateArea(2, 4);
Console.WriteLine(area2);

IShape sh3 = ShapeFactory.GetShape("Triangle");
double area3 = sh3.CalculateArea(2, 4);
Console.WriteLine(area3);
