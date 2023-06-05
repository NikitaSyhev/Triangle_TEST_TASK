using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_TEST_TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double triangle1, triangle2, triangle3;
            Console.WriteLine("Введите 3 стороны треугольника");
            triangle1 = double.Parse(Console.ReadLine());
            triangle2 = double.Parse(Console.ReadLine());
            triangle3 = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(triangle1, triangle2, triangle3);
            double squareTriangle = triangle.square(triangle);
            Console.WriteLine($"Площадь треугольника: {squareTriangle}");


            double radius;
            Console.WriteLine("Введите радиус круга");
            radius = double.Parse(Console.ReadLine());
            Round round = new Round(radius);
            double squareRound = round.square(round);
            Console.WriteLine($"Площадь круга: {squareRound}");

            Console.ReadLine();
        }
    }
}
