using System.Dynamic;
using System.Runtime.InteropServices;
using static Labb5_OOP.Program;

namespace Labb5_OOP
{

    internal class Program
    {

        static void Main(string[] args)
        {
            CreateAndPrint();
        }

        private static void CreateAndPrint()
        {
            //Creates 3 circles with radius of 1,5 and 6
            Circle circle = new Circle(1);
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            //creates 2 triangles with equal sides of 5 and 9
            Triangle triangle = new Triangle(5);
            Triangle triangle1 = new Triangle(9);


            //prints information of the shapes
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

        //Overloaded Method to print for triangles
        private static void PrintShapeInfo(Triangle triangle)
        {
            Console.WriteLine($"Triangle side: {triangle.GetSide()}");
            Console.WriteLine($"Triangle Area: {triangle.GetTriangleArea()}");
        }
    }

    
    public class Circle
    {

        int _Radius;

        //Constructor with input for radius
        public Circle(int radius)
        {
            _Radius = radius;

        }

        //Calculates area using radius entered in constructor
        public double GetArea()
        {
            return _Radius * _Radius * Math.PI;
        }

        //Calculates Circumference using radius entered in constructor
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
        

    //Class for a Triangle with equal sides
    public class Triangle
    {
        int _Side;

        //Constructor with input for lenght of triangle side
        public Triangle(int side)
        {
            _Side = side;
        }

        //Calculates area using triangle side entered in constructor
        public double GetTriangleArea()
        {
            return MathF.Sqrt(3) * (_Side * _Side) / 4;
        }

        //Gets the lenght of a side for the print method
        public double GetSide() 
        {
            return _Side;
        }
    }
}