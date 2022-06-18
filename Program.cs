using System;

namespace lab6_assignment
{
    // lab 6 question - Define an abstract class Shape with abstract method CalculateSurface() and fields width and height.
    // Define two additional classes for a triangle and a rectangle,which implement CalculateSurface().
    // This method has to return the areas of the rectangle (height*width) and the triangle (height*width/2).
    // Define a class for a circle with an appropriate constructor, which initializes the two fields (height and width) with the same value (the radius) and implement the abstract method for calculating the area.
    // Create an array of different shapes and calculate the area of each shape in another array.
    abstract class Shape 
    {
        public double Height;
        public double Width;
        public abstract double CalculateSurface();
    }
    class Triangle : Shape
    {
        public Triangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double CalculateSurface()
        {
           double area = (Height * Width) / 2;
           return area;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double CalculateSurface()
        {
            double area = (Height * Width);
            return area;
        }
    }
    class Circle : Shape
    {
        double pi = 3.124;
        public Circle(double radius)
        {
            Height = radius;
            Width = radius;
        }
        public override double CalculateSurface()
        {
            double area = (Height * Width) * pi;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape myTriangle = new Triangle(6,4);
            Shape mySquare = new Rectangle(6,4);
            Shape myCircle = new Circle(6);
            
    
            Shape[] shapes = {myTriangle, mySquare, myCircle};
            double[] Areas = new double[3];
            
            // foreach( Shape i in shapes)
            // {
            //     Areas[j] = i.CalculateSurface();
            //     j += 1;
            // }
            // foreach (double i in Areas)
            // {
            //     Console.WriteLine(i);
            // }
            for(int i = 0 ; i < shapes.Length; i++ )
            {
                Areas[i] = shapes[i].CalculateSurface();
            }
            
            foreach(double i in Areas)
            {
                Console.WriteLine(i);
                
            }
        }
    }
}
