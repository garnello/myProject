using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2._10
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the value of the triangle A:");
            double FitrstSide = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of the triangle B:");
            double SecondSide = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of the triangle C:");
            double ThirdSide = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(FitrstSide, SecondSide, ThirdSide);
            while (true)
            {
                Console.WriteLine(
                "1.Find perimeter.\n" +
                "2.Find square.\n" +
                "3.Median intersection point.\n" +
                "4.Exit\n");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine(triangle.Perimeter());
                        break;

                    case 2:
                        Console.WriteLine(triangle.Square());
                        break;

                    case 3:
                        Console.WriteLine(triangle.GetMedianIntersection());
                        break;

                    case 4:
                        return;
                        break;
                }
            }
        }
    }
}
