using System.Runtime.InteropServices;
using static Labb5_OOP.Program;

namespace Labb5_OOP
{
    
    internal class Program
    {

        static void Main(string[] args)
        {

            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            PrintCircle(circle1);

            PrintCircle(circle2);

            
        }


        //Method to print all information about circles
        private static void PrintCircle(Circle circle)
        {
            Console.WriteLine($"Circle radius: {circle.GetRadius()}");
            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine($"Circle Circumference: {circle.GetCircumference()}");
            Console.WriteLine();
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
    }
}