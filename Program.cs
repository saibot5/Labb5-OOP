using System.Dynamic;
using System.Runtime.InteropServices;
using static Labb5_OOP.Program;

namespace Labb5_OOP
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Circle circle = new Circle(1);
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Triangle triangle = new Triangle(5);
            Triangle triangle1 = new Triangle(6);

            PrintShapeInfo(circle);

            PrintShapeInfo(circle1);

            PrintShapeInfo(circle2);

            PrintShapeInfo(triangle);

            PrintShapeInfo(triangle1);
        }


        //Method to print all information about circles
        private static void PrintShapeInfo(Circle circle)
        {
            Console.WriteLine($"Circle radius: {circle.GetRadius()}");
            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine($"Circle Circumference: {circle.GetCircumference()}");
            Console.WriteLine("If Sphere");
            Console.WriteLine($"Sphere Circumference: {circle.GetSphereCurcumference()}");
            Console.WriteLine($"Sphere Volume: {circle.GetSphereVolume()}");
            Console.WriteLine();
        }

        private static void PrintShapeInfo(Triangle triangle)
        {
            Console.WriteLine($"Triangle side: {triangle.GetSide()}");
            Console.WriteLine($"Triangle Area: {triangle.GetTriangleArea()}");
        }
    }

    public class Circle
    {
        int _Radius;

        public Circle(int radius)
        {
            _Radius = radius;

        }

        public double GetArea()
        {
            return _Radius * _Radius * Math.PI;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * _Radius;
        }

        //Gets the radius for the print method
        public int GetRadius()
        {
            return _Radius;
        }


        public double GetSphereCurcumference()
        {
            return 2*Math.PI * _Radius;
        }
        public double GetSphereVolume()
        {
            return (4.0/3) * Math.PI * (_Radius * _Radius * _Radius);
        }
    }
        
    public class Triangle
    {
        int _Side;
        public Triangle(int side)
        {
            _Side = side;
        }

        public double GetTriangleArea()
        {
            return MathF.Sqrt(3) * (_Side * _Side) / 4;
        }
        public double GetSide() 
        {
            return _Side;
        }
    }
}